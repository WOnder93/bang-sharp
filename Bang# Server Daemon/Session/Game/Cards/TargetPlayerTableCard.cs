// TargetPlayerTableCard.cs
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
namespace BangSharp.Server.Daemon
{
	public abstract class TargetPlayerTableCard : PlayableTableCard
	{
		private sealed class TargetPlayerTableCardResponseHandler : ResponseHandler
		{
			private TargetPlayerTableCard parent;
			private Card card;

			public TargetPlayerTableCardResponseHandler(TargetPlayerTableCard parent, Card card) :
				base(parent.reqType, card.Owner)
			{
				this.parent = parent;
				this.card = card;
			}
			public TargetPlayerTableCardResponseHandler(TargetPlayerTableCard parent) :
				this(parent, parent)
			{
			}

			protected override void OnRespondPlayer(Player targetPlayer)
			{
				if(targetPlayer == RequestedPlayer && !parent.includeSelf)
					throw new BadTargetPlayerException();
				
				if(!targetPlayer.IsAlive)
					throw new BadTargetPlayerException();
				
				if(parent.Range != 0 && parent.Range < Game.GetDistance(RequestedPlayer, targetPlayer))
					throw new BadTargetPlayerException();

				parent.CheckPlay(targetPlayer);

				if(card != parent)
					Game.GameTable.PlayerPlayCard(card, parent.Type, targetPlayer);
				else
					Game.GameTable.PlayerPlayCard(card, targetPlayer);

				if(targetPlayer == RequestedPlayer || targetPlayer.HasCardEffect(card))
					parent.OnPlayFromTable(RequestedPlayer, targetPlayer);
				End();
			}
			protected override void OnRespondNoAction()
			{
				End();
			}
		}
		private RequestType reqType;
		private bool includeSelf;

		protected virtual int Range
		{
			get { return 0; }
		}

		protected TargetPlayerTableCard(Game game, int id, CardType type, CardSuit suit, CardRank rank, RequestType reqType, bool includeSelf = false) :
			base(game, id, type, suit, rank)
		{
			this.reqType = reqType;
			this.includeSelf = includeSelf;
		}

		protected override void OnPlayFromTable()
		{
			Game.GameCycle.PushTempHandler(new TargetPlayerTableCardResponseHandler(this));
		}
		protected override void OnPlayFromTableVirtually(Card card)
		{
			Game.GameCycle.PushTempHandler(new TargetPlayerTableCardResponseHandler(this, card));
		}

		protected virtual void CheckPlay(Player targetPlayer)
		{
		}
		protected abstract void OnPlayFromTable(Player owner, Player targetPlayer);
	}
}
