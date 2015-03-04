using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnEntryNameChanged (object sender, EventArgs e)
	{
		labelStatus.Text = entryName.Text;
	}
	protected void OnNewActionActivated (object sender, EventArgs e)
	{
		entryName.Text = "";
		entryPais.Text = "";
		entryCiudad.Text = "";
	}



	protected void OnExit (object sender, EventArgs e)
	{
		Application.Quit();
	}
	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
	}

