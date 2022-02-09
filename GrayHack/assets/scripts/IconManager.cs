using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GrayHack.Properties;

namespace GrayHack.assets.scripts
{
	public class IconManager
	{
		private Image _icon;
		private string _name;
		public Form _programForm;

		private static int _size = 120;
		public Button button = new Button();

		public Control _parent;

		


		public IconManager(List<IconManager> icons, Bitmap icon, Form programForm, string name)
		{
			_name = name;
			_programForm = programForm;
			_icon = icon;

			Typesetting();
		}


		private void Typesetting()
		{
			button.BackgroundImage = _icon;
			button.BackgroundImageLayout = ImageLayout.Zoom;
			button.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button.BackColor = Color.Transparent;
			button.FlatStyle = FlatStyle.Flat;
			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.BorderColor = Color.FromArgb(0, 76, 63);
			button.Size = new Size(_size, _size);
			button.SetRoundedShape(15);

			Pen pen = new Pen(Color.Black, 100f);
			Graphics g = button.CreateGraphics();
			g.DrawRectangle(pen, 1000, 1000, 100, 100);




			// Context Menu set
			button.ContextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem OpenToolStripMenuItem = new ToolStripMenuItem();
			OpenToolStripMenuItem.Text = "Open";

			ToolStripMenuItem DeleteToolStripMenuItem = new ToolStripMenuItem();
			DeleteToolStripMenuItem.Text = "Delete";
			DeleteToolStripMenuItem.Click += (s, a) => { DeleteIcon(this, Desktop._desktopIcons); };

			button.ContextMenuStrip.Items.AddRange(new ToolStripItem[] {
				OpenToolStripMenuItem, DeleteToolStripMenuItem
			});


			// bind method
			button.Click += (s, a) => { _programForm.Show(); };
			button.MouseEnter += (s, a) => { button.FlatAppearance.BorderSize = 5; };
			button.MouseLeave += (s, a) => { button.FlatAppearance.BorderSize = 0; };
		}

		// delete item il icons list
		public void DeleteIcon(IconManager icon, List<IconManager> icons)
		{
			icons.Remove(icon);
			_parent.Controls.Remove(icon.button);
		}
		
		public static void AddIcon(List<IconManager> icons, IconManager icon, Control control)
        {
			icons.Add(icon);
			icon._parent = control;
			icon._parent.Controls.Add(icon.button);
        }

		public static void LoadIcon(List<IconManager> icons, Control parent)
		{
			LoadIcon(icons, parent, null);
		}

		public static void LoadIcon(List<IconManager> icons, Control parent, ContextMenuStrip rmenu)
		{
			parent.Controls.Clear();
			foreach (IconManager icon in icons)
			{
				parent.Controls.Add(icon.button);
				icon._parent = parent;
			}
		}
	}
}