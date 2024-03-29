// PlayerControl.cs
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

namespace BangSharp.Server.Daemon
{
	public sealed class PlayerControl : ImmortalMarshalByRefObject, IPlayerControl
	{
		private Player player;
		
		private Game Game
		{
			get { return player.Game; }
		}
		private GameCycle GameCycle
		{
			get { return player.Game.GameCycle; }
		}
		private GameTable GameTable
		{
			get { return player.Game.GameTable; }
		}
		
		public Player Player
		{
			get { return player; }
		}
		IPrivatePlayerView IPlayerControl.PrivatePlayerView
		{
			get { return player.PrivatePlayerView; }
		}
		IGame IPlayerControl.Game
		{
			get { return player.Game; }
		}
		
		public PlayerControl(Player player)
		{
			this.player = player;
		}

		void IPlayerControl.RespondDraw()
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();

			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondDraw(player);
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}

		void IPlayerControl.RespondCard(int id)
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();

			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondCard(player, game.GameTable.GetCard(id));
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}

		void IPlayerControl.RespondPlayer(int id)
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();

			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondPlayer(player, game.GetPlayer(id));
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}

		void IPlayerControl.RespondCharacter(CharacterType character)
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();
			
			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondCharacter(player, character);
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}

		void IPlayerControl.RespondNoAction()
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();

			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondNoAction(player);
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}

		void IPlayerControl.RespondUseAbility()
		{
			if(!player.Parent.CheckListener())
				throw new InvalidOperationException();

			Game game = Game;
			lock(game.Session.Lock)
			{
				game.GameCycle.PlayerRespondUseAbility(player);
				if(game.Session.State == SessionState.Playing)
					game.Session.EventManager.OnNewRequest(game.GameCycle.RequestType, game.GameCycle.RequestedPlayer, game.GameCycle.CausedBy);
			}
		}
	}
}
