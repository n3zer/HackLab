using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GrayHack.Properties;

namespace GrayHack.assets.scripts
{
	public class IconDesktop
	{
		private Image _icon;
		private string _name;
		public Form _programForm;

		private static int _size = 120;
		public Button button = new Button();

		public Control _parent;

		public static List<IconDesktop> _desktopIcons = new List<IconDesktop>()
		{
			new IconDesktop(new Bitmap(Resources.FileExplorer), new MessageGame(""), "FileExplorer"),
			new IconDesktop(new Bitmap(Resources.Terminal), new MessageGame(""), "Terminal"),
			new IconDesktop(new Bitmap(Resources.Map), new MessageGame(""), "Map"),
			new IconDesktop(new Bitmap(Resources.Mail), new MessageGame(""), "Mail"),
			new IconDesktop(new Bitmap(Resources.Browser), new MessageGame(""), "Browser"),
			new IconDesktop(new Bitmap(Resources.Notepad), new MessageGame(""), "Notepad"),
			new IconDesktop(new Bitmap(Resources.Manual), new MessageGame(""), "Manual")
	};


		public IconDesktop(Bitmap icon, Form programForm, string name)
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
			button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
			button.Size = new Size(_size, _size);
			button.SetRoundedShape(15);

			Pen pen = new Pen(Color.Black, 100f);
			Graphics g = button.CreateGraphics();
			g.DrawRectangle(pen, 1000, 1000, 100, 100);





			button.ContextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem AddToolStripMenuItem = new ToolStripMenuItem();
			AddToolStripMenuItem.Text = "Add";

			ToolStripMenuItem TextdocToolStripMenuItem = new ToolStripMenuItem();
			TextdocToolStripMenuItem.Text = "Text doc";

			AddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
				TextdocToolStripMenuItem
			});



			ToolStripMenuItem DeleteToolStripMenuItem = new ToolStripMenuItem();
			DeleteToolStripMenuItem.Text = "Delete";
			DeleteToolStripMenuItem.Click += (s, a) => { DeleteIcon(this); };

			button.ContextMenuStrip.Items.AddRange(new ToolStripItem[] {
				AddToolStripMenuItem, DeleteToolStripMenuItem
			});




			button.Click += (s, a) => { _programForm.Show(); };
			button.MouseEnter += (s, a) => { button.FlatAppearance.BorderSize = 5; };
			button.MouseLeave += (s, a) => { button.FlatAppearance.BorderSize = 0; };
		}
		// delete item il icons list
		public void DeleteIcon(IconDesktop icon)
		{
			_desktopIcons.Remove(icon);
			LoadIcon(_desktopIcons, _parent);
		}

		public static void LoadIcon(List<IconDesktop> icons, Control parent)
		{
			LoadIcon(icons, parent, null);
		}

		public static void LoadIcon(List<IconDesktop> icons, Control parent, ContextMenuStrip rmenu)
		{
			parent.Controls.Clear();
			foreach (IconDesktop icon in icons)
			{
				parent.Controls.Add(icon.button);
				icon._parent = parent;
			}
		}
	}
}