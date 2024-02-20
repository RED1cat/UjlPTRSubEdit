namespace ujlptr_subedit
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.EncodingToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OffsetToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConverterToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextEncodingToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FileOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOffsetToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FileDecodeOffsetToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeconvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ConversionPatternToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.AdvancedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TextPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.EncodingToolStripStatusLabel,
            this.OffsetToolStripStatusLabel,
            this.ConverterToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 570);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.ShowItemToolTips = true;
            this.StatusStrip.Size = new System.Drawing.Size(1203, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Visible = false;
            // 
            // EncodingToolStripStatusLabel
            // 
            this.EncodingToolStripStatusLabel.Name = "EncodingToolStripStatusLabel";
            this.EncodingToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.EncodingToolStripStatusLabel.Text = "Encoding";
            this.EncodingToolStripStatusLabel.ToolTipText = "The currently selected text encoding";
            // 
            // OffsetToolStripStatusLabel
            // 
            this.OffsetToolStripStatusLabel.Name = "OffsetToolStripStatusLabel";
            this.OffsetToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.OffsetToolStripStatusLabel.Text = "Offset";
            this.OffsetToolStripStatusLabel.ToolTipText = "Selected offset";
            // 
            // ConverterToolStripStatusLabel
            // 
            this.ConverterToolStripStatusLabel.Name = "ConverterToolStripStatusLabel";
            this.ConverterToolStripStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.ConverterToolStripStatusLabel.Text = "Сonverter";
            this.ConverterToolStripStatusLabel.ToolTipText = "Currently selected character converter";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.ShowItemToolTips = true;
            this.MenuStrip.Size = new System.Drawing.Size(1203, 24);
            this.MenuStrip.TabIndex = 4;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ToolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.ToolTipText = "Open one or more files";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.ToolTipText = "Save the file to where it was originally opened or saved earlier";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            this.SaveAsToolStripMenuItem.ToolTipText = "Save the file in the selected path";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.ToolTipText = "Exit the app";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolToolStripMenuItem
            // 
            this.ToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncodingToolStripMenuItem,
            this.FileOffsetToolStripMenuItem,
            this.ConverterToolStripMenuItem,
            this.AdvancedModeToolStripMenuItem,
            this.ToolStripSeparator5,
            this.TextPreviewToolStripMenuItem});
            this.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem";
            this.ToolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ToolToolStripMenuItem.Text = "&Tool";
            // 
            // EncodingToolStripMenuItem
            // 
            this.EncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextEncodingToolStripComboBox});
            this.EncodingToolStripMenuItem.Enabled = false;
            this.EncodingToolStripMenuItem.Name = "EncodingToolStripMenuItem";
            this.EncodingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EncodingToolStripMenuItem.Text = "&Encoding";
            this.EncodingToolStripMenuItem.ToolTipText = "Setting the text encoding";
            // 
            // TextEncodingToolStripComboBox
            // 
            this.TextEncodingToolStripComboBox.Items.AddRange(new object[] {
            "Default",
            "ASCII",
            "UTF-7",
            "Windows-1252"});
            this.TextEncodingToolStripComboBox.Name = "TextEncodingToolStripComboBox";
            this.TextEncodingToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.TextEncodingToolStripComboBox.Text = "Default";
            this.TextEncodingToolStripComboBox.ToolTipText = "Selecting the encoding for the active window";
            this.TextEncodingToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.TextEncodingToolStripComboBox_SelectedIndexChanged);
            // 
            // FileOffsetToolStripMenuItem
            // 
            this.FileOffsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOffsetToolStripComboBox,
            this.FileDecodeOffsetToolStripComboBox});
            this.FileOffsetToolStripMenuItem.Enabled = false;
            this.FileOffsetToolStripMenuItem.Name = "FileOffsetToolStripMenuItem";
            this.FileOffsetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileOffsetToolStripMenuItem.Text = "&FileOffset";
            this.FileOffsetToolStripMenuItem.ToolTipText = "Setting the offsets for the file";
            // 
            // FileOffsetToolStripComboBox
            // 
            this.FileOffsetToolStripComboBox.Items.AddRange(new object[] {
            "UmJammerLammy Usa - 0x1c5750 ",
            "UmJammerLammy Jp - 0x1c5110 ",
            "UmJammerLammy eur - 0x1c4eb8",
            "PaRappaTheRapper Usa - 0x1c3870",
            "PaRappaTheRapper Jp - 0x1cc21c",
            "PaRappaTheRapper eur - 0x1c8af8"});
            this.FileOffsetToolStripComboBox.Name = "FileOffsetToolStripComboBox";
            this.FileOffsetToolStripComboBox.Size = new System.Drawing.Size(209, 23);
            this.FileOffsetToolStripComboBox.Text = "UmJammerLammy Usa - 0x1c5750 ";
            this.FileOffsetToolStripComboBox.ToolTipText = "Setting the basic offset, for the correct display of subtitles";
            this.FileOffsetToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FileOffsetToolStripComboBox_SelectedIndexChanged);
            // 
            // FileDecodeOffsetToolStripComboBox
            // 
            this.FileDecodeOffsetToolStripComboBox.Name = "FileDecodeOffsetToolStripComboBox";
            this.FileDecodeOffsetToolStripComboBox.Size = new System.Drawing.Size(209, 23);
            this.FileDecodeOffsetToolStripComboBox.Text = "None";
            this.FileDecodeOffsetToolStripComboBox.ToolTipText = "Optional offset setting for file parsing so that less garbage is displayed";
            this.FileDecodeOffsetToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FileDecodeOffsetToolStripComboBox_SelectedIndexChanged);
            // 
            // ConverterToolStripMenuItem
            // 
            this.ConverterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertToolStripMenuItem,
            this.DeconvertToolStripMenuItem,
            this.ToolStripSeparator4,
            this.ConversionPatternToolStripComboBox});
            this.ConverterToolStripMenuItem.Enabled = false;
            this.ConverterToolStripMenuItem.Name = "ConverterToolStripMenuItem";
            this.ConverterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ConverterToolStripMenuItem.Text = "&Сonverter";
            this.ConverterToolStripMenuItem.ToolTipText = "Configuring the converter with a symbol";
            // 
            // ConvertToolStripMenuItem
            // 
            this.ConvertToolStripMenuItem.Enabled = false;
            this.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem";
            this.ConvertToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ConvertToolStripMenuItem.Text = "&Convert selected items";
            this.ConvertToolStripMenuItem.ToolTipText = "Convert selected text";
            this.ConvertToolStripMenuItem.Click += new System.EventHandler(this.ConvertToolStripMenuItem_Click);
            // 
            // DeconvertToolStripMenuItem
            // 
            this.DeconvertToolStripMenuItem.Enabled = false;
            this.DeconvertToolStripMenuItem.Name = "DeconvertToolStripMenuItem";
            this.DeconvertToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.DeconvertToolStripMenuItem.Text = "&Deconvert selected items";
            this.DeconvertToolStripMenuItem.ToolTipText = "Deconvert the selected text";
            this.DeconvertToolStripMenuItem.Click += new System.EventHandler(this.DeconvertToolStripMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // ConversionPatternToolStripComboBox
            // 
            this.ConversionPatternToolStripComboBox.Name = "ConversionPatternToolStripComboBox";
            this.ConversionPatternToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.ConversionPatternToolStripComboBox.Text = "None";
            this.ConversionPatternToolStripComboBox.ToolTipText = "File selection";
            this.ConversionPatternToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ConversionPatternToolStripComboBox_SelectedIndexChanged);
            // 
            // AdvancedModeToolStripMenuItem
            // 
            this.AdvancedModeToolStripMenuItem.CheckOnClick = true;
            this.AdvancedModeToolStripMenuItem.Enabled = false;
            this.AdvancedModeToolStripMenuItem.Name = "AdvancedModeToolStripMenuItem";
            this.AdvancedModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AdvancedModeToolStripMenuItem.Text = "&Advanced Mode";
            this.AdvancedModeToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.AdvancedModeToolStripMenuItem_CheckStateChanged);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // TextPreviewToolStripMenuItem
            // 
            this.TextPreviewToolStripMenuItem.Enabled = false;
            this.TextPreviewToolStripMenuItem.Name = "TextPreviewToolStripMenuItem";
            this.TextPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TextPreviewToolStripMenuItem.Text = "TextPreview (beta)";
            this.TextPreviewToolStripMenuItem.ToolTipText = "Display a preview of the text of the active window";
            this.TextPreviewToolStripMenuItem.Click += new System.EventHandler(this.TextPreviewToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.TileHorizontalToolStripMenuItem,
            this.TileVerticalToolStripMenuItem});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.WindowToolStripMenuItem.Text = "&Window";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Enabled = false;
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CascadeToolStripMenuItem.Text = "Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // TileHorizontalToolStripMenuItem
            // 
            this.TileHorizontalToolStripMenuItem.Enabled = false;
            this.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            this.TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // TileVerticalToolStripMenuItem
            // 
            this.TileVerticalToolStripMenuItem.Enabled = false;
            this.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem";
            this.TileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.TileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.TileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.ToolStripSeparator3,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Enabled = false;
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.SearchToolStripMenuItem.Text = "&Search";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(106, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Filter = resources.GetString("OpenFileDialog.Filter");
            this.OpenFileDialog.Multiselect = true;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = resources.GetString("SaveFileDialog.Filter");
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 592);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Um Jammer Lammy & Parappa The Rapper Subtitle editor";
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox TextEncodingToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem ConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeconvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox ConversionPatternToolStripComboBox;
        private System.Windows.Forms.ToolStripStatusLabel EncodingToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ConverterToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel OffsetToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem FileOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FileOffsetToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TextPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FileDecodeOffsetToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem ConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdvancedModeToolStripMenuItem;
    }
}