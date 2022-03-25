
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ujlLogo = new System.Windows.Forms.PictureBox();
            this.length = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.TextContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveProgress = new System.Windows.Forms.ProgressBar();
            this.downPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ujlLogo)).BeginInit();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexContextMenu
            // 
            this.HexContextMenu.Name = "HexContextMenu";
            this.HexContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // ujlLogo
            // 
            this.ujlLogo.Image = ((System.Drawing.Image)(resources.GetObject("ujlLogo.Image")));
            this.ujlLogo.Location = new System.Drawing.Point(-1, -20);
            this.ujlLogo.Name = "ujlLogo";
            this.ujlLogo.Size = new System.Drawing.Size(878, 190);
            this.ujlLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ujlLogo.TabIndex = 57;
            this.ujlLogo.TabStop = false;
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
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 525;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(894, 441);
            this.panel.TabIndex = 526;
            // 
            // TextContextMenu
            // 
            this.TextContextMenu.Name = "TextContextMenu";
            this.TextContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // saveProgress
            // 
            this.saveProgress.Location = new System.Drawing.Point(770, 1);
            this.saveProgress.Name = "saveProgress";
            this.saveProgress.Size = new System.Drawing.Size(100, 23);
            this.saveProgress.Step = 20;
            this.saveProgress.TabIndex = 527;
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.White;
            this.downPanel.Controls.Add(this.saveProgress);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 466);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(894, 25);
            this.downPanel.TabIndex = 527;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.ContextMenuStrip = this.HexContextMenu;
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.length);
            this.Controls.Add(this.last);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ujlLogo);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(910, 530);
            this.MinimumSize = new System.Drawing.Size(910, 530);
            this.Name = "Editor";
            this.Text = "COMOD11_SNG";
            //this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ujlLogo)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox ujlLogo;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.ContextMenuStrip HexContextMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ContextMenuStrip TextContextMenu;
        private System.Windows.Forms.ProgressBar saveProgress;
        private System.Windows.Forms.Panel downPanel;
    }
}