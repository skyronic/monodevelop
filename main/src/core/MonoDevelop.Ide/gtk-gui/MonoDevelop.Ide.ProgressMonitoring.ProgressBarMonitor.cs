
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.ProgressMonitoring
{
	public partial class ProgressBarMonitor
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.ProgressBar progressBar;
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.ProgressMonitoring.ProgressBarMonitor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.ProgressMonitoring.ProgressBarMonitor";
			// Container child MonoDevelop.Ide.ProgressMonitoring.ProgressBarMonitor.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 3;
			// Container child hbox1.Gtk.Box+BoxChild
			this.progressBar = new global::Gtk.ProgressBar ();
			this.progressBar.Name = "progressBar";
			this.hbox1.Add (this.progressBar);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.progressBar]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w3.Add (w6);
			w2.Add (w3);
			this.buttonCancel.Add (w2);
			this.hbox1.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonCancel]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
