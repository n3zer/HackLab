using GrayHack.assets.scripts;
using System;
using System.Diagnostics;
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
    }
}
