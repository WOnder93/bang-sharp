// NestedCommand.cs
//  
// Author:  WOnder93 <omosnacek@gmail.com>
// 
// Copyright (c) 2012 Ondrej Mosnáček
// 
// Created with the help of the source code of KBang (http://code.google.com/p/kbang)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;

namespace BangSharp.ConsoleUtils
{
	/// <summary>
	/// The delegate for the nested command template.
	/// </summary>
	/// <typeparam name="In">
	/// The type of the input parameter of the command template.
	/// </typeparam>
	/// <typeparam name="Out">
	/// The type of the output parameter of the command template.
	/// </typeparam>
	public delegate Out NestedCommandDelegate<In, Out>(In param, Queue<string> cmd);
	/// <summary>
	/// Represents a nested command template.
	/// </summary>
	/// <typeparam name="In">
	/// The type of the input parameter of the command template.
	/// </typeparam>
	/// <typeparam name="Out">
	/// The type of the output parameter of the command template.
	/// </typeparam>
	public class NestedCommand<In, Out> : Command<In>
	{
		private NestedCommandDelegate<In, Out> del;
		private Dictionary<string, Command<Out>> subcommands;

		public override IEnumerable<string> Subcommands
		{
			get { return subcommands.Keys; }
		}

		/// <summary>
		/// Gets or sets the subcommand with the specified name.
		/// </summary>
		/// <param name="text">
		/// The name of the subcommand.
		/// </param>
		public Command<Out> this[string text]
		{
			get
			{
				if(text == null)
					throw new ArgumentNullException("text");
				text = text.ToLower();
				try
				{
					return subcommands[text];
				}
				catch(KeyNotFoundException)
				{
					return null;
				}
			}
			set
			{
				if(text == null)
					throw new ArgumentNullException("text");
				text = text.ToLower();
				if(value == null)
					subcommands.Remove(text);
				subcommands[text] = value;
			}
		}

		/// <summary>
		/// Creates a new nested command template with the specified delegate.
		/// </summary>
		/// <param name="del">
		/// The delegate to be invoked when this command executes.
		/// </param>
		public NestedCommand(NestedCommandDelegate<In, Out> del)
		{
			this.del = del;
			subcommands = new Dictionary<string, Command<Out>>();
		}

		public override ICommand GetSubcommand(string text)
		{
			try
			{
				return subcommands[text];
			}
			catch(KeyNotFoundException)
			{
				return null;
			}
		}
		public override void Execute(In param, Queue<string> cmd)
		{
			Out outParam = del(param, cmd);
			if(outParam == null)
				return;
			string subCmd;
			try
			{
				subCmd = cmd.Dequeue();
			}
			catch(InvalidOperationException)
			{
				subCmd = "";
			}
			try
			{
				subcommands[subCmd].Execute(outParam, cmd);
			}
			catch(KeyNotFoundException)
			{
				throw new InvalidOperationException();
			}
		}
	}

	/// <summary>
	/// The delegate for the root nested command template.
	/// </summary>
	/// <typeparam name="Out">
	/// The type of the output parameter of the command template.
	/// </typeparam>
	public delegate Out NestedCommandDelegate<Out>(Queue<string> cmd);
	/// <summary>
	/// Represents a root nested command template.
	/// </summary>
	public class NestedCommand<Out> : NestedCommand<object, Out>
	{
		/// <summary>
		/// Creates a new root nested command template with the specified delegate.
		/// </summary>
		/// <param name="del">
		/// The delegate to be invoked when this command executes.
		/// </param>
		public NestedCommand(NestedCommandDelegate<Out> del) : base((param, cmd) => del(cmd))
		{
		}
	}
	/// <summary>
	/// Represents a root nested command template.
	/// </summary>
	public class NestedCommand : NestedCommand<object>
	{
		/// <summary>
		/// Creates a new root nested command template with the specified delegate.
		/// </summary>
		public NestedCommand() : base(cmd => new object())
		{
		}
	}
}
