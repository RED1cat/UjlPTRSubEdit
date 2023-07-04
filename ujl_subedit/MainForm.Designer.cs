namespace ujl_subedit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.m_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.m_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.m_FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.m_AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.m_WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_TileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_StatusStrip.SuspendLayout();
            this.m_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_StatusStrip
            // 
            this.m_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ProgressBar});
            this.m_StatusStrip.Location = new System.Drawing.Point(0, 550);
            this.m_StatusStrip.Name = "m_StatusStrip";
            this.m_StatusStrip.Size = new System.Drawing.Size(1058, 22);
            this.m_StatusStrip.TabIndex = 3;
            this.m_StatusStrip.Text = "statusStrip1";
            // 
            // m_ProgressBar
            // 
            this.m_ProgressBar.Name = "m_ProgressBar";
            this.m_ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.m_ProgressBar.Visible = false;
            // 
            // m_MenuStrip
            // 
            this.m_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_FileToolStripMenuItem,
            this.m_ToolToolStripMenuItem,
            this.m_HelpToolStripMenuItem,
            this.m_WindowToolStripMenuItem});
            this.m_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_MenuStrip.Name = "m_MenuStrip";
            this.m_MenuStrip.Size = new System.Drawing.Size(1058, 24);
            this.m_MenuStrip.TabIndex = 4;
            // 
            // m_FileToolStripMenuItem
            // 
            this.m_FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_OpenToolStripMenuItem,
            this.m_ToolStripSeparator1,
            this.m_SaveToolStripMenuItem,
            this.m_SaveAsToolStripMenuItem,
            this.m_ToolStripSeparator2,
            this.m_ExitToolStripMenuItem});
            this.m_FileToolStripMenuItem.Name = "m_FileToolStripMenuItem";
            this.m_FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.m_FileToolStripMenuItem.Text = "&File";
            // 
            // m_OpenToolStripMenuItem
            // 
            this.m_OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_OpenToolStripMenuItem.Image")));
            this.m_OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_OpenToolStripMenuItem.Name = "m_OpenToolStripMenuItem";
            this.m_OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.m_OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_OpenToolStripMenuItem.Text = "&Open";
            this.m_OpenToolStripMenuItem.Click += new System.EventHandler(this.m_OpenToolStripMenuItem_Click);
            // 
            // m_ToolStripSeparator1
            // 
            this.m_ToolStripSeparator1.Name = "m_ToolStripSeparator1";
            this.m_ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // m_SaveToolStripMenuItem
            // 
            this.m_SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_SaveToolStripMenuItem.Image")));
            this.m_SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_SaveToolStripMenuItem.Name = "m_SaveToolStripMenuItem";
            this.m_SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.m_SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_SaveToolStripMenuItem.Text = "&Save";
            this.m_SaveToolStripMenuItem.Click += new System.EventHandler(this.m_SaveToolStripMenuItem_Click);
            // 
            // m_SaveAsToolStripMenuItem
            // 
            this.m_SaveAsToolStripMenuItem.Name = "m_SaveAsToolStripMenuItem";
            this.m_SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_SaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // m_ToolStripSeparator2
            // 
            this.m_ToolStripSeparator2.Name = "m_ToolStripSeparator2";
            this.m_ToolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // m_ExitToolStripMenuItem
            // 
            this.m_ExitToolStripMenuItem.Name = "m_ExitToolStripMenuItem";
            this.m_ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_ExitToolStripMenuItem.Text = "&Exit";
            // 
            // m_ToolToolStripMenuItem
            // 
            this.m_ToolToolStripMenuItem.Name = "m_ToolToolStripMenuItem";
            this.m_ToolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.m_ToolToolStripMenuItem.Text = "&Tool";
            // 
            // m_HelpToolStripMenuItem
            // 
            this.m_HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_SearchToolStripMenuItem,
            this.m_ToolStripSeparator3,
            this.m_AboutToolStripMenuItem});
            this.m_HelpToolStripMenuItem.Name = "m_HelpToolStripMenuItem";
            this.m_HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.m_HelpToolStripMenuItem.Text = "&Help";
            // 
            // m_SearchToolStripMenuItem
            // 
            this.m_SearchToolStripMenuItem.Name = "m_SearchToolStripMenuItem";
            this.m_SearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_SearchToolStripMenuItem.Text = "&Search";
            // 
            // m_ToolStripSeparator3
            // 
            this.m_ToolStripSeparator3.Name = "m_ToolStripSeparator3";
            this.m_ToolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // m_AboutToolStripMenuItem
            // 
            this.m_AboutToolStripMenuItem.Name = "m_AboutToolStripMenuItem";
            this.m_AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_AboutToolStripMenuItem.Text = "&About";
            // 
            // m_OpenFileDialog
            // 
            this.m_OpenFileDialog.FileName = "m_OpenFileDialog";
            this.m_OpenFileDialog.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode " +
    "File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu F" +
    "ile (*.MEN)|*.MEN|All files (*.*)|*.*";
            // 
            // m_SaveFileDialog
            // 
            this.m_SaveFileDialog.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode " +
    "File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu F" +
    "ile (*.MEN)|*.MEN|All files (*.*)|*.*";
            // 
            // m_WindowToolStripMenuItem
            // 
            this.m_WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_CascadeToolStripMenuItem,
            this.m_TileHorizontalToolStripMenuItem,
            this.m_TileVerticalToolStripMenuItem});
            this.m_WindowToolStripMenuItem.Name = "m_WindowToolStripMenuItem";
            this.m_WindowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.m_WindowToolStripMenuItem.Text = "&Window";
            // 
            // m_CascadeToolStripMenuItem
            // 
            this.m_CascadeToolStripMenuItem.Name = "m_CascadeToolStripMenuItem";
            this.m_CascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_CascadeToolStripMenuItem.Text = "Cascade";
            this.m_CascadeToolStripMenuItem.Click += new System.EventHandler(this.m_CascadeToolStripMenuItem_Click);
            // 
            // m_TileHorizontalToolStripMenuItem
            // 
            this.m_TileHorizontalToolStripMenuItem.Name = "m_TileHorizontalToolStripMenuItem";
            this.m_TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_TileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.m_TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.m_TileHorizontalToolStripMenuItem_Click);
            // 
            // m_TileVerticalToolStripMenuItem
            // 
            this.m_TileVerticalToolStripMenuItem.Name = "m_TileVerticalToolStripMenuItem";
            this.m_TileVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.m_TileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.m_TileVerticalToolStripMenuItem.Click += new System.EventHandler(this.m_TileVerticalToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 572);
            this.Controls.Add(this.m_StatusStrip);
            this.Controls.Add(this.m_MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.m_MenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.m_StatusStrip.ResumeLayout(false);
            this.m_StatusStrip.PerformLayout();
            this.m_MenuStrip.ResumeLayout(false);
            this.m_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip m_StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar m_ProgressBar;
        private System.Windows.Forms.MenuStrip m_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem m_ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_ToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_ToolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem m_AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog m_OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem m_WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_TileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_TileVerticalToolStripMenuItem;
    }
}