// Jail.cs
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
using System.Linq;

namespace BangSharp.Server.Daemon.Cards
{
	public sealed class Jail : TableCard
	{
		private sealed class JailResponseHandler : ResponseHandler
		{
			private Jail parent;

			public JailResponseHandler(Jail parent) :
				base(RequestType.JailTarget, parent.Owner)
			{
				this.parent = parent;
			}

			protected override void OnRespondPlayer(Player player)
			{
				if(!player.IsAlive)
					throw new BadTargetPlayerException();

				if(player.IsSheriff)
					throw new BadTargetPlayerException();

				if(player.Table.Any(c => c.Type == CardType.Jail))
					throw new BadTargetPlayerException();

				Game.GameTable.PassTableCard(parent, player);
				End();
			}

			protected override void OnRespondNoAction()
			{
				End();
			}
		}

		public override int PredrawCheckPriority
		{
			get { return 2; }
		}

		public Jail(Game game, int id, CardSuit suit, CardRank rank) :
			base(game, id, CardType.Jail, suit, rank)
		{
		}

		protected override void OnPlay()
		{
			if(!IsInHand)
				throw new BadUsageException();
			Game.GameCycle.PushTempHandler(new JailResponseHandler(this));
		}
		
		protected override void OnPredrawCheck()
		{
			Owner.CheckDeck(this, c => c.Suit == CardSuit.Hearts, OnResult);
		}
		
		private void OnResult(Card causedBy, bool result)
		{
			Player owner = Owner;
			Game.GameTable.CancelCard(this);
			if(!result)
				owner.SkipTurn = true;
		}
	}
}
