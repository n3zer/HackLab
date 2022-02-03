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
			new IconDesktop(new Bitmap(Resources.Mail), new MessageGame("Ты пидор")),
			new IconDesktop(new Bitmap(Resources.wifi), new MessageGame("Ты пидор")),
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
			LoadDesktopFiles(_desktopIcons);
		}

		private void Desktop_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageGame mg = new MessageGame("Вы действительно хотите закрыть игру?");
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
    }
}
