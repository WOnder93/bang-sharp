// ThreePlayersPlayerHelper.cs
//  
// Author:  WOnder93 <omosnacek@gmail.com>
// 
// Copyright (c) 2011 Ondrej Mosnáček
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
using System.Linq;
namespace Bang.AI
{
	internal sealed class ThreePlayersPlayerHelper : PlayerHelper
	{
		private IPublicPlayerView enemy;
		private IPublicPlayerView ally;

		public ThreePlayersPlayerHelper(IPlayerControl control) : base(control)
		{
			Role myRole = control.PrivatePlayerView.Role;
			Role enemyRole, allyRole;
			switch(myRole)
			{
			case Role.Deputy:
				enemyRole = Role.Renegade;
				allyRole = Role.Outlaw;
				break;
			case Role.Renegade:
				enemyRole = Role.Outlaw;
				allyRole = Role.Deputy;
				break;
			case Role.Outlaw:
				enemyRole = Role.Deputy;
				allyRole = Role.Renegade;
				break;
			default:
				throw new InvalidOperationException();
			}
			enemy = control.Game.Players.First(p => p.Role == enemyRole);
			ally = control.Game.Players.First(p => p.Role == allyRole);
		}

		public override IEnumerable<IPublicPlayerView> Allies
		{
			get { return ally.IsAlive ? new List<IPublicPlayerView> { ally } : new List<IPublicPlayerView>(); }
		}
		public override IEnumerable<IPublicPlayerView> Enemies
		{
			get { return enemy.IsAlive ? new List<IPublicPlayerView> { enemy } : new List<IPublicPlayerView>() { ally }; }
		}
	}
}

