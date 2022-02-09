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

		public static List<IconManager> _desktopIcons = new List<IconManager>()
		{
			new IconManager(_desktopIcons, new Bitmap(Resources.FileExplorer), new FileExplorer(FileManager.pathToPlayerPc), "FileExplorer"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Terminal), new MessageGame(""), "Terminal"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Map), new MessageGame(""), "Map"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Mail), new MessageGame(""), "Mail"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Browser), new MessageGame(""), "Browser"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Notepad), new MessageGame(""), "Notepad"),
			new IconManager(_desktopIcons, new Bitmap(Resources.Manual), new MessageGame(""), "Manual")
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

			folderToolStripMenuItem.Click += (s, a) => { IconManager.AddIcon(_desktopIcons, new IconManager(_desktopIcons, new Bitmap(Resources.Folder), new MessageGame(""), "Folder"), DesktopFilesPanel); };

			IconManager.LoadIcon(_desktopIcons, DesktopFilesPanel);
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
    }
}
