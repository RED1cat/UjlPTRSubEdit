
namespace ujl_subedit
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.HexContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SharpToLineBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.TextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.TextPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.length = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.HexContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HexContextMenu
            // 
            this.HexContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpToLineBreak,
            this.TextCopy,
            this.TextPaste});
            this.HexContextMenu.Name = "HexContextMenu";
            this.HexContextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // SharpToLineBreak
            // 
            this.SharpToLineBreak.Name = "SharpToLineBreak";
            this.SharpToLineBreak.Size = new System.Drawing.Size(117, 22);
            this.SharpToLineBreak.Text = "23 to 0A";
            this.SharpToLineBreak.Click += new System.EventHandler(this.SharpToLineBreak_Click);
            // 
            // TextCopy
            // 
            this.TextCopy.Name = "TextCopy";
            this.TextCopy.Size = new System.Drawing.Size(117, 22);
            this.TextCopy.Text = "Copy";
            this.TextCopy.Click += new System.EventHandler(this.TextCopy_Click);
            // 
            // TextPaste
            // 
            this.TextPaste.Name = "TextPaste";
            this.TextPaste.Size = new System.Drawing.Size(117, 22);
            this.TextPaste.Text = "Paste";
            this.TextPaste.Click += new System.EventHandler(this.TextPaste_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.length.Font = new System.Drawing.Font("DomCasualBTW05-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.length.Location = new System.Drawing.Point(3, 63);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(83, 20);
            this.length.TabIndex = 58;
            this.length.Text = "Length  and №";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.last.Font = new System.Drawing.Font("DomCasualBTW05-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last.Location = new System.Drawing.Point(837, 63);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(28, 20);
            this.last.TabIndex = 59;
            this.last.Text = "Left";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 525;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(894, 491);
            this.panel.TabIndex = 526;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.ContextMenuStrip = this.HexContextMenu;
            this.Controls.Add(this.length);
            this.Controls.Add(this.last);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(910, 1000);
            this.MinimumSize = new System.Drawing.Size(910, 530);
            this.Name = "Editor";
            this.Text = "COMOD11_SNG";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.HexContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.ContextMenuStrip HexContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SharpToLineBreak;
        private System.Windows.Forms.ToolStripMenuItem TextCopy;
        private System.Windows.Forms.ToolStripMenuItem TextPaste;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel;
    }
}