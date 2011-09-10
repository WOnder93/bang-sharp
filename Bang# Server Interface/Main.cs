// Main.cs
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
using System.Runtime.Remoting;
using System.Runtime.Serialization;
namespace Bang.Server
{
	class MainClass
	{
		public static void Main(string[] cmdArgs)
		{
			ConsoleUtils.Commands = new string[]
			{
				"server",
				"name",
				"description",
				"sessions",
				"count",
				"session",
				"game",
				"players",
				"player",
				"graveyardtop",
				"reqtype",
				"current",
				"requested",
				"causedby",
				"hand",
				"role",
				"selection",
				"exit",
				"issheriff",
				"isalive",
				"iswinner",
				"lifepoints",
				"maxlifepoints",
				"table",
				"character",
				"state",
				"minplayers",
				"maxplayers",
				"maxspectators",
				"hasplayerpassword",
				"hasspectatorpassword",
				"creator",
				"dodgecity",
				"highnoon",
				"fistfulofcards",
				"wildwestshow",
				"gamesplayed",
				"spectators",
				"spectator",
				"haspassword",
				"iscreator",
				"isai",
				"haslistener",
				"wins",
				"winsassheriff",
				"winsasdeputy",
				"winsasoutlaw",
				"winsasrenegade",
				"end",
				"reset",
				"changepassword",
			};
			ConsoleUtils.PrintLine("Bang# Server Interface");
			ConsoleUtils.PrintLine("----------------------");

			string address;
			string portString;
			if(cmdArgs.Length != 2)
			{
				ConsoleUtils.Print("Server Address: ");
				address = ConsoleUtils.ReadLine();
				ConsoleUtils.Print("Server Port: ");
				portString = ConsoleUtils.ReadLine();
			}
			else
			{
				address = cmdArgs[0];
				portString = cmdArgs[1];
			}
			int port;
			try
			{
				port = int.Parse(portString);
			}
			catch(FormatException)
			{
				ConsoleUtils.ErrorLine("Bad number format!");
				return;
			}

			ConsoleUtils.PrintLine("Connecting to {0} on port {1}...", address, port);
			ServerProxy<Server> serverProxy = (ServerProxy<Server>)Utils.Connect(address, port);

			ConsoleUtils.PrintLine();

			try
			{
				/*
				if(!Utils.IsServerCompatible(server))
				{
					ConsoleUtils.ErrorLine("Server version {0}.{1} not compatible with client version {2}.{3}!",
						server.InterfaceVersionMajor, server.InterfaceVersionMinor,
						Utils.InterfaceVersionMajor, Utils.InterfaceVersionMinor);
					return;
				}
				*/
				ConsoleUtils.PrintLine("Server name: {0}", ((IServer)serverProxy).Name);
				ConsoleUtils.PrintLine("Server description: {0}", ((IServer)serverProxy).Description);
				ConsoleUtils.SuccessLine("Connection estabilished!");
				ConsoleUtils.PrintLine();

				ConsoleUtils.Print("Server password: ");
				Password password = ConsoleUtils.ReadPassword();
				Server server;
				try
				{
					server = serverProxy.GetServerObject(password);
				}
				catch(BadServerPasswordException)
				{
					ConsoleUtils.ErrorLine("Password rejected!");
					return;
				}
				ConsoleUtils.SuccessLine("Password accepted!");

				ConsoleUtils.PrintLine();
				while (true) // command-line loop
				{
					Queue<string> args = ConsoleUtils.ReadCommand();
					string arg;
					try
					{
						switch (arg = args.Dequeue())
						{
						case "server":
							switch (arg = args.Dequeue())
							{
							case "name":
								ConsoleUtils.PrintLine(server.Name);
								break;
							case "description":
								ConsoleUtils.PrintLine(server.Description);
								break;
							case "sessions":
								if(args.Count == 0)
								{
									foreach(Session s in server.Sessions)
									{
										ConsoleUtils.PrintLine("Session {0}:", s.ID);
										ConsoleUtils.Print(s);
									}
									break;
								}
								switch (args.Dequeue())
								{
								case "count":
									ConsoleUtils.PrintLine(server.Sessions.Count);
									break;
								case "reset":
									server.ResetSessions();
									ConsoleUtils.SuccessLine();
									break;
								default:
									ConsoleUtils.ErrorLine("Unknown command!");
									break;
								}
								break;
							case "session":
								Session session;
								try
								{
									int id = int.Parse(args.Dequeue());
									session = server.GetSession(id);
								}
								catch(FormatException)
								{
									ConsoleUtils.ErrorLine("Expected an ID!");
									break;
								}
								catch(InvalidIdException)
								{
									ConsoleUtils.ErrorLine("Invalid ID!");
									break;
								}
								switch(arg = args.Dequeue())
								{
								case "game":
									Game game = session.Game;
									if(game == null)
									{
										ConsoleUtils.ErrorLine("Game not started!");
										break;
									}
									switch(arg = args.Dequeue())
									{
									case "players":
										if(args.Count == 0)
										{
											foreach(Player p in game.Players)
											{
												ConsoleUtils.PrintLine("Player #{0}:", p.ID);
												Print(p);
											}
											break;
										}
										switch(arg = args.Dequeue())
										{
										case "count":
											ConsoleUtils.PrintLine(game.Players.Count);
											break;
										default:
											ConsoleUtils.ErrorLine("Unknown command!");
											break;
										}
										break;
									case "player":
										Player player;
										try
										{
											int id = int.Parse(args.Dequeue());
											player = game.GetPlayer(id);
										}
										catch(FormatException)
										{
											ConsoleUtils.ErrorLine("Expected an ID!");
											break;
										}
										catch(InvalidIdException)
										{
											ConsoleUtils.ErrorLine("Invalid ID!");
											break;
										}
										switch(arg = args.Dequeue())
										{
										case "hand":
											if(args.Count == 0)
											{
												foreach(Card c in player.Hand)
												{
													ConsoleUtils.PrintLine("Card #{0}:", c.ID);
													ConsoleUtils.Print(c);
												}
												break;
											}
											switch(arg = args.Dequeue())
											{
											case "count":
												ConsoleUtils.PrintLine(player.Hand.Count);
												break;
											default:
												ConsoleUtils.ErrorLine("Unknown command!");
												break;
											}
											break;
										case "role":
											ConsoleUtils.PrintLine(player.Role);
											break;
										default:
											ConsoleUtils.PlayerCommand(arg, args, player);
											break;
										}
										break;
									default:
										ConsoleUtils.GameCommand(arg, args, game);
										break;
									}
									break;
								case "end":
									session.End();
									break;
								default:
									ConsoleUtils.SessionCommand(arg, args, session);
									break;
								}
								break;
							case "changepassword":
								ConsoleUtils.Print("Current password: ");
								password = ConsoleUtils.ReadPassword();
								ConsoleUtils.Print("New password: ");
								Password newPassword = ConsoleUtils.ReadPassword();
								try
								{
									serverProxy.ChangePassword(password, newPassword);
									ConsoleUtils.SuccessLine("Password changed!");
								}
								catch(BadServerPasswordException)
								{
									ConsoleUtils.ErrorLine("Password rejected!");
								}
								break;
							default:
								ConsoleUtils.ErrorLine("Unknown command!");
								break;
							}
							break;
						case "exit":
							return;
						default:
							ConsoleUtils.ErrorLine("Unknown command!");
							break;
						}
					}
					catch(InvalidOperationException)
					{
						ConsoleUtils.ErrorLine("Too few arguments!");
					}
				}
			}
			catch(RemotingException e)
			{
				ConsoleUtils.ErrorLine("Remoting error!");
#if DEBUG
				ConsoleUtils.DebugLine(e.ToString());
#endif
				return;
			}
			catch(SerializationException e)
			{
				ConsoleUtils.ErrorLine("Serialization error!");
#if DEBUG
				ConsoleUtils.DebugLine(e.ToString());
#endif
				return;
			}
		}
		private static void Print(Player player)
		{
			if(player == null)
				return;
			ConsoleUtils.PrintLine("\tIsAlive: {0}", player.IsAlive);
			ConsoleUtils.PrintLine("\tIsWinner: {0}", player.IsWinner);
			ConsoleUtils.PrintLine("\tLifePoints: {0}/{1}", player.LifePoints, player.MaxLifePoints);
			ConsoleUtils.PrintLine("\tRole: {0}", player.Role);
			ConsoleUtils.PrintLine("\tCharacter: {0}", player.CharacterType);
		}
	}
}

