
// This file has been generated by the GUI designer. Do not modify.
namespace BangSharp.Client
{
	public partial class MainWindow
	{
		private global::BangSharp.Client.GameBoard.GameBoardWidget gameboard1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BangSharp.Client.MainWindow
			this.Name = "BangSharp.Client.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Bang# Client");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.AllowShrink = true;
			this.DefaultWidth = 600;
			this.DefaultHeight = 800;
			// Container child BangSharp.Client.MainWindow.Gtk.Container+ContainerChild
			this.gameboard1 = new global::BangSharp.Client.GameBoard.GameBoardWidget ();
			this.gameboard1.Name = "gameboard1";
			this.Add (this.gameboard1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.gameboard1.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnGameboard1KeyPressEvent);
		}
	}
}
