
// This file has been generated by the GUI designer. Do not modify.
namespace BangSharp.Client
{
	public partial class CreateSessionDialog
	{
		private global::Gtk.VBox vbox5;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Table table3;
		private global::Gtk.Expander expander1;
		private global::Gtk.VBox vbox6;
		private global::Gtk.CheckButton dodgeCityCheckbox;
		private global::Gtk.CheckButton highNoonCheckbox;
		private global::Gtk.CheckButton aFistfulOfCardsCheckbox;
		private global::Gtk.CheckButton wildWestShowCheckbox;
		private global::Gtk.Label GtkLabel7;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.SpinButton maxPlayerCountEntry;
		private global::Gtk.SpinButton maxSpectatorCountEntry;
		private global::Gtk.SpinButton minPlayerCountEntry;
		private global::Gtk.Entry playerPasswordEntry;
		private global::Gtk.TextView sessionDescriptionEntry;
		private global::Gtk.Entry sessionNameEntry;
		private global::Gtk.CheckButton shufflePlayersCheckbox;
		private global::Gtk.Entry spectatorPasswordEntry;
		private global::Gtk.Label GtkLabel3;
		private global::BangSharp.Client.PlayerDataWidget playerDataWidget;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BangSharp.Client.CreateSessionDialog
			this.Name = "BangSharp.Client.CreateSessionDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Create Session");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.DestroyWithParent = true;
			// Internal child BangSharp.Client.CreateSessionDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table (((uint)(9)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.expander1 = new global::Gtk.Expander (null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			this.expander1.Expanded = true;
			// Container child expander1.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			this.vbox6.BorderWidth = ((uint)(6));
			// Container child vbox6.Gtk.Box+BoxChild
			this.dodgeCityCheckbox = new global::Gtk.CheckButton ();
			this.dodgeCityCheckbox.CanFocus = true;
			this.dodgeCityCheckbox.Name = "dodgeCityCheckbox";
			this.dodgeCityCheckbox.Label = global::Mono.Unix.Catalog.GetString ("Dodge City");
			this.dodgeCityCheckbox.DrawIndicator = true;
			this.dodgeCityCheckbox.UseUnderline = true;
			this.vbox6.Add (this.dodgeCityCheckbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.dodgeCityCheckbox]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.highNoonCheckbox = new global::Gtk.CheckButton ();
			this.highNoonCheckbox.CanFocus = true;
			this.highNoonCheckbox.Name = "highNoonCheckbox";
			this.highNoonCheckbox.Label = global::Mono.Unix.Catalog.GetString ("High Noon");
			this.highNoonCheckbox.DrawIndicator = true;
			this.highNoonCheckbox.UseUnderline = true;
			this.vbox6.Add (this.highNoonCheckbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.highNoonCheckbox]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.aFistfulOfCardsCheckbox = new global::Gtk.CheckButton ();
			this.aFistfulOfCardsCheckbox.CanFocus = true;
			this.aFistfulOfCardsCheckbox.Name = "aFistfulOfCardsCheckbox";
			this.aFistfulOfCardsCheckbox.Label = global::Mono.Unix.Catalog.GetString ("A Fistful of Cards");
			this.aFistfulOfCardsCheckbox.DrawIndicator = true;
			this.aFistfulOfCardsCheckbox.UseUnderline = true;
			this.vbox6.Add (this.aFistfulOfCardsCheckbox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.aFistfulOfCardsCheckbox]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.wildWestShowCheckbox = new global::Gtk.CheckButton ();
			this.wildWestShowCheckbox.CanFocus = true;
			this.wildWestShowCheckbox.Name = "wildWestShowCheckbox";
			this.wildWestShowCheckbox.Label = global::Mono.Unix.Catalog.GetString ("Wild West Show");
			this.wildWestShowCheckbox.DrawIndicator = true;
			this.wildWestShowCheckbox.UseUnderline = true;
			this.vbox6.Add (this.wildWestShowCheckbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.wildWestShowCheckbox]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.expander1.Add (this.vbox6);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Expansions</b>");
			this.GtkLabel7.UseMarkup = true;
			this.GtkLabel7.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel7;
			this.table3.Add (this.expander1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3 [this.expander1]));
			w7.TopAttach = ((uint)(8));
			w7.BottomAttach = ((uint)(9));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table3.Add (this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3 [this.label3]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.Yalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Description:");
			this.table3.Add (this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.label4]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Min. Player Count:");
			this.table3.Add (this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.label5]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Max. Player Count:");
			this.table3.Add (this.label6);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.label6]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Max. Spectator Count:");
			this.table3.Add (this.label7);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.label7]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Player Password:");
			this.table3.Add (this.label8);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3 [this.label8]));
			w13.TopAttach = ((uint)(5));
			w13.BottomAttach = ((uint)(6));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Spectator Password:");
			this.table3.Add (this.label9);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3 [this.label9]));
			w14.TopAttach = ((uint)(6));
			w14.BottomAttach = ((uint)(7));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.maxPlayerCountEntry = new global::Gtk.SpinButton (2, 8, 1);
			this.maxPlayerCountEntry.CanFocus = true;
			this.maxPlayerCountEntry.Name = "maxPlayerCountEntry";
			this.maxPlayerCountEntry.Adjustment.PageIncrement = 10;
			this.maxPlayerCountEntry.ClimbRate = 1;
			this.maxPlayerCountEntry.Numeric = true;
			this.maxPlayerCountEntry.Value = 8;
			this.table3.Add (this.maxPlayerCountEntry);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3 [this.maxPlayerCountEntry]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.maxSpectatorCountEntry = new global::Gtk.SpinButton (0, 1000, 1);
			this.maxSpectatorCountEntry.CanFocus = true;
			this.maxSpectatorCountEntry.Name = "maxSpectatorCountEntry";
			this.maxSpectatorCountEntry.Adjustment.PageIncrement = 10;
			this.maxSpectatorCountEntry.ClimbRate = 1;
			this.maxSpectatorCountEntry.Numeric = true;
			this.table3.Add (this.maxSpectatorCountEntry);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3 [this.maxSpectatorCountEntry]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.minPlayerCountEntry = new global::Gtk.SpinButton (2, 8, 1);
			this.minPlayerCountEntry.CanFocus = true;
			this.minPlayerCountEntry.Name = "minPlayerCountEntry";
			this.minPlayerCountEntry.Adjustment.PageIncrement = 10;
			this.minPlayerCountEntry.ClimbRate = 1;
			this.minPlayerCountEntry.Numeric = true;
			this.minPlayerCountEntry.Value = 2;
			this.table3.Add (this.minPlayerCountEntry);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3 [this.minPlayerCountEntry]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.playerPasswordEntry = new global::Gtk.Entry ();
			this.playerPasswordEntry.CanFocus = true;
			this.playerPasswordEntry.Name = "playerPasswordEntry";
			this.playerPasswordEntry.IsEditable = true;
			this.playerPasswordEntry.ActivatesDefault = true;
			this.playerPasswordEntry.Visibility = false;
			this.playerPasswordEntry.InvisibleChar = '•';
			this.table3.Add (this.playerPasswordEntry);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3 [this.playerPasswordEntry]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.sessionDescriptionEntry = new global::Gtk.TextView ();
			this.sessionDescriptionEntry.CanFocus = true;
			this.sessionDescriptionEntry.Name = "sessionDescriptionEntry";
			this.table3.Add (this.sessionDescriptionEntry);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3 [this.sessionDescriptionEntry]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			// Container child table3.Gtk.Table+TableChild
			this.sessionNameEntry = new global::Gtk.Entry ();
			this.sessionNameEntry.CanFocus = true;
			this.sessionNameEntry.Name = "sessionNameEntry";
			this.sessionNameEntry.IsEditable = true;
			this.sessionNameEntry.ActivatesDefault = true;
			this.sessionNameEntry.InvisibleChar = '•';
			this.table3.Add (this.sessionNameEntry);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table3 [this.sessionNameEntry]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.shufflePlayersCheckbox = new global::Gtk.CheckButton ();
			this.shufflePlayersCheckbox.CanFocus = true;
			this.shufflePlayersCheckbox.Name = "shufflePlayersCheckbox";
			this.shufflePlayersCheckbox.Label = global::Mono.Unix.Catalog.GetString ("_Shuffle Players");
			this.shufflePlayersCheckbox.DrawIndicator = true;
			this.shufflePlayersCheckbox.UseUnderline = true;
			this.table3.Add (this.shufflePlayersCheckbox);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3 [this.shufflePlayersCheckbox]));
			w21.TopAttach = ((uint)(7));
			w21.BottomAttach = ((uint)(8));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.spectatorPasswordEntry = new global::Gtk.Entry ();
			this.spectatorPasswordEntry.CanFocus = true;
			this.spectatorPasswordEntry.Name = "spectatorPasswordEntry";
			this.spectatorPasswordEntry.IsEditable = true;
			this.spectatorPasswordEntry.ActivatesDefault = true;
			this.spectatorPasswordEntry.Visibility = false;
			this.spectatorPasswordEntry.InvisibleChar = '•';
			this.table3.Add (this.spectatorPasswordEntry);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table3 [this.spectatorPasswordEntry]));
			w22.TopAttach = ((uint)(6));
			w22.BottomAttach = ((uint)(7));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table3);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Session Options</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.vbox5.Add (this.frame2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame2]));
			w25.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.playerDataWidget = new global::BangSharp.Client.PlayerDataWidget ();
			this.playerDataWidget.Events = ((global::Gdk.EventMask)(256));
			this.playerDataWidget.Name = "playerDataWidget";
			this.vbox5.Add (this.playerDataWidget);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.playerDataWidget]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox5]));
			w27.Position = 0;
			// Internal child BangSharp.Client.CreateSessionDialog.ActionArea
			global::Gtk.HButtonBox w28 = this.ActionArea;
			w28.Name = "dialog1_ActionArea";
			w28.Spacing = 10;
			w28.BorderWidth = ((uint)(5));
			w28.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28 [this.buttonCancel]));
			w29.Expand = false;
			w29.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28 [this.buttonOk]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 481;
			this.DefaultHeight = 704;
			this.label3.MnemonicWidget = this.sessionNameEntry;
			this.label4.MnemonicWidget = this.sessionDescriptionEntry;
			this.label5.MnemonicWidget = this.minPlayerCountEntry;
			this.label6.MnemonicWidget = this.maxPlayerCountEntry;
			this.label7.MnemonicWidget = this.maxSpectatorCountEntry;
			this.label8.MnemonicWidget = this.playerPasswordEntry;
			this.label9.MnemonicWidget = this.spectatorPasswordEntry;
			this.buttonOk.HasDefault = true;
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
		}
	}
}
