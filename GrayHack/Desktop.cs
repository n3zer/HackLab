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

		static User _user;
		static ToolStrip _toolStrip;


		public static List<IconManager> _desktopIcons;
		public Desktop(User user)
		{
			InitializeComponent();
			_user = user;
			_toolStrip = BottomMenu;
		}

		

		private void Desktop_Load(object sender, EventArgs e)
		{
			
			dateTimer.Start();
			dateTimer.Tick += (s, a) => { dateLabel.SetDate(); };
			UserProfileButton.Text = _user._name;
			ShutdownButton.Click += (s, a) => { this.Close(); };
			this.Deactivate += (s, a) => { };

			MenuButton.Click += (s, a) => {
				StartMenuPanel.Visible = !StartMenuPanel.Visible;
			};

			folderToolStripMenuItem.Click += (s, a) => { IconManager.AddIcon(_desktopIcons, new IconManager(_desktopIcons, new Bitmap(Resources.Folder), new MessageGame(""), "Folder"), DesktopFilesPanel); };


			_desktopIcons = new List<IconManager>()
			{
				new IconManager(_desktopIcons, new Bitmap(Resources.FileExplorer), new FileExplorer(_user._nowPath), "FileExplorer"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Terminal), new MessageGame(""), "Terminal"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Map), new MessageGame(""), "Map"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Mail), new MessageGame(""), "Mail"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Browser), new MessageGame(""), "Browser"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Notepad), new MessageGame(""), "Notepad"),
				new IconManager(_desktopIcons, new Bitmap(Resources.Manual), new MessageGame(""), "Manual")
			};



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

        public static void AddProgramToMenu(string name, IconManager icon)
        {
			ToolStripButton button = new ToolStripButton(name);
			button.ForeColor = Color.White;
			button.BackColor = Color.FromArgb(51, 51, 51);
			button.Click += (s, a) => { icon._programForm.TopMost = true; icon._programForm.TopMost = false; };
			_toolStrip.Items.Add(button);
		}

		public static void RemoveProgramToMenu(string name)
		{
			foreach (ToolStripButton button in _toolStrip.Items)
            {
				if (button.Text == name)
                {
					_toolStrip.Items.Remove(button);
					return;
                }
            }
		}



		
	}


	

}
