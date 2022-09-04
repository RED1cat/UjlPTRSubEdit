﻿
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
            HexContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            TextContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            saveProgress = new System.Windows.Forms.ProgressBar();
            this.downPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tabControl1 = new System.Windows.Forms.TabControl();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexContextMenu
            // 
            HexContextMenu.Name = "HexContextMenu";
            HexContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 525;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TextContextMenu
            // 
            TextContextMenu.Name = "TextContextMenu";
            TextContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // saveProgress
            // 
            saveProgress.Location = new System.Drawing.Point(770, 1);
            saveProgress.MarqueeAnimationSpeed = 400;
            saveProgress.Name = "saveProgress";
            saveProgress.Size = new System.Drawing.Size(100, 23);
            saveProgress.Step = 1;
            saveProgress.TabIndex = 527;
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.White;
            this.downPanel.Controls.Add(saveProgress);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 466);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(911, 25);
            this.downPanel.TabIndex = 527;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(911, 442);
            tabControl1.TabIndex = 528;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(911, 491);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(927, 1000);
            this.MinimumSize = new System.Drawing.Size(927, 530);
            this.Name = "Editor";
            this.Text = "Um Jammer Lammy Subtitle Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private static System.Windows.Forms.ContextMenuStrip HexContextMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private static System.Windows.Forms.ContextMenuStrip TextContextMenu;
        private static System.Windows.Forms.ProgressBar saveProgress;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private static System.Windows.Forms.TabControl tabControl1;
    }
}