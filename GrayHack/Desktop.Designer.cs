using System.Diagnostics;

namespace GrayHack
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripButton();
            this.dateLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton,
            this.dateLabel});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 25);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "toolStrip1";
            // 
            // MenuButton
            // 
            this.MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(23, 22);
            this.MenuButton.Text = "toolStripButton1";
            // 
            // dateLabel
            // 
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 2000;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopMenu);
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Desktop_FormClosing);
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip TopMenu;
        private System.Windows.Forms.ToolStripButton MenuButton;
        private System.Windows.Forms.ToolStripLabel dateLabel;
        private System.Windows.Forms.Timer dateTimer;
    }
}