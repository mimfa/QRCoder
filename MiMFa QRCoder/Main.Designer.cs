namespace MiMFa_BarCoder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.cms_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ni_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbc_Main = new C1.Win.C1BarCode.C1QRCode();
            this.cb_RealTime = new System.Windows.Forms.CheckBox();
            this.cms_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Text
            // 
            this.tb_Text.ContextMenuStrip = this.cms_Main;
            this.tb_Text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_Text.Location = new System.Drawing.Point(0, 296);
            this.tb_Text.Multiline = true;
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Text.Size = new System.Drawing.Size(269, 67);
            this.tb_Text.TabIndex = 2;
            this.tb_Text.Text = "MiMFa QRCoder";
            this.tb_Text.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // cms_Main
            // 
            this.cms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.cms_Main.Name = "cms_Main";
            this.cms_Main.Size = new System.Drawing.Size(173, 92);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.selectAllToolStripMenuItem.Text = "انتخاب همه";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyToolStripMenuItem.Text = "کپی";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cutToolStripMenuItem.Text = "برش";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pasteToolStripMenuItem.Text = "جایگذاری";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // ni_Main
            // 
            this.ni_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_Main.Icon")));
            this.ni_Main.Text = "MiMFa BarCoder";
            this.ni_Main.Visible = true;
            this.ni_Main.Click += new System.EventHandler(this.ni_Main_Click);
            // 
            // cbc_Main
            // 
            this.cbc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbc_Main.Location = new System.Drawing.Point(0, 0);
            this.cbc_Main.Name = "cbc_Main";
            this.cbc_Main.Size = new System.Drawing.Size(269, 273);
            this.cbc_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbc_Main.TabIndex = 3;
            this.cbc_Main.Text = "MiMFa Quick BarCoder";
            this.cbc_Main.Click += new System.EventHandler(this.cbc_Main_Click);
            this.cbc_Main.DoubleClick += new System.EventHandler(this.cbc_Main_DoubleClick);
            // 
            // cb_RealTime
            // 
            this.cb_RealTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_RealTime.AutoSize = true;
            this.cb_RealTime.Checked = true;
            this.cb_RealTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_RealTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_RealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_RealTime.Location = new System.Drawing.Point(0, 273);
            this.cb_RealTime.Name = "cb_RealTime";
            this.cb_RealTime.Size = new System.Drawing.Size(269, 23);
            this.cb_RealTime.TabIndex = 4;
            this.cb_RealTime.Text = "RealTime";
            this.cb_RealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_RealTime.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 363);
            this.Controls.Add(this.cbc_Main);
            this.Controls.Add(this.cb_RealTime);
            this.Controls.Add(this.tb_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiMFa QRCoder";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.cms_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.NotifyIcon ni_Main;
        private C1.Win.C1BarCode.C1QRCode cbc_Main;
        private System.Windows.Forms.ContextMenuStrip cms_Main;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_RealTime;
    }
}

