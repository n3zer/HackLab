using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayHack
{
	public partial class Desktop : Form
	{
		

		public Desktop()
		{
			InitializeComponent();
		}

		private void Desktop_Load(object sender, EventArgs e)
		{

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
