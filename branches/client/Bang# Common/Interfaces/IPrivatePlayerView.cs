// IPrivatePlayerView.cs
//  
// Author:  WOnder93 <omosnacek@gmail.com>
// 
// Copyright (c) 2011 Ondrej Mosnáček
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
using System.Collections.ObjectModel;
namespace Bang
{
	/// <summary>
	/// Provides player's properties as seen by himself.
	/// </summary>
	public interface IPrivatePlayerView : IPublicPlayerView
	{
		/// <summary>
		/// Gets the collection of the cards that the player is holding in his hand.
		/// </summary>
		new ReadOnlyCollection<ICard> Hand { get; }

		/// <summary>
		/// Gets the role of the player.
		/// </summary>
		new Role Role { get; }

		/// <summary>
		/// Gets the collection of the cards that are in a temporary selection.
		/// </summary>
		ReadOnlyCollection<ICard> Selection { get; }
	}
}
