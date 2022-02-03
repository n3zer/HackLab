using GrayHack.assets.scripts;
using GrayHack.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GrayHack
{
	public partial class Desktop : Form
	{

		User _user;

		List<IconDesktop> _desktopIcons = new List<IconDesktop>()
        {
			new IconDesktop(new Bitmap(Resources.FileExplorer), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Terminal), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Map), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Mail), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Browser), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Notepad), new MessageGame("")),
			new IconDesktop(new Bitmap(Resources.Manual), new MessageGame(""))
	};
		public Desktop(User user)
		{
			InitializeComponent();
			_user = user;
		}

		private void Desktop_Load(object sender, EventArgs e)
		{
			
			dateTimer.Start();
			dateTimer.Tick += (s, a) => { dateLabel.SetDate(); };
			UserProfileButton.Text = _user._name;
			ShutdownButton.Click += (s, a) => { this.Close(); };

			MenuButton.Click += (s, a) => {
				StartMenuPanel.Visible = !StartMenuPanel.Visible;
			};

			LoadDesktopFiles(_desktopIcons);
		}

		private void Desktop_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageGame mg = new MessageGame("Вы уверены что хотите выключить компьютер?", "Shutdown");
			mg.ShowDialog();
			if (mg.result)
				Process.GetCurrentProcess().Kill();
			else
				e.Cancel = true;
		}

		private void LoadDesktopFiles(List<IconDesktop> icons)
        {
			foreach (IconDesktop icon in icons)
            {
				DesktopFilesPanel.Controls.Add(icon.button);
			}
		}

		//public static void DeleteDesktopFiles(IconDesktop icon)
		//      {
		//	_desktopIcons.Remove(icon);
		//	DesktopFilesPanel.Controls.Remove(icon.button);
		//}



	}
}
