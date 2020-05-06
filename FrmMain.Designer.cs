namespace Chuong4_Bai1
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.chaoMungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaoMungToolStripMenuItem,
            this.tinhTongToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(788, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // chaoMungToolStripMenuItem
            // 
            this.chaoMungToolStripMenuItem.Name = "chaoMungToolStripMenuItem";
            this.chaoMungToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chaoMungToolStripMenuItem.Text = "ChaoMung";
            this.chaoMungToolStripMenuItem.Click += new System.EventHandler(this.chaoMungToolStripMenuItem_Click);
            // 
            // tinhTongToolStripMenuItem
            // 
            this.tinhTongToolStripMenuItem.Name = "tinhTongToolStripMenuItem";
            this.tinhTongToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tinhTongToolStripMenuItem.Text = "TinhTong";
            this.tinhTongToolStripMenuItem.Click += new System.EventHandler(this.tinhTongToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 504);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem chaoMungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhTongToolStripMenuItem;

    }
}