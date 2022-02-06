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

			IconDesktop.LoadIcon(IconDesktop._desktopIcons, DesktopFilesPanel, IconContextMenu);
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
