namespace ujl_subedit
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.text = new System.Windows.Forms.Label();
            this.git = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("DomCasualBTW05-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(12, 9);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(396, 120);
            this.text.TabIndex = 2;
            this.text.Text = "Um Jammer Lammy subtitle editor\r\nTool for editing subtitles in the game Um Jammer" +
    " Lammy\r\nIf you find any bug, write to me in the discord \"REDcat#5249\"\r\n\r\n©2022 R" +
    "EDcat";
            // 
            // git
            // 
            this.git.Location = new System.Drawing.Point(124, 106);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(75, 23);
            this.git.TabIndex = 4;
            this.git.Text = "Git";
            this.git.UseVisualStyleBackColor = true;
            this.git.Click += new System.EventHandler(this.git_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(327, 106);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "Сontinue";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(411, 135);
            this.ControlBox = false;
            this.Controls.Add(this.ok);
            this.Controls.Add(this.git);
            this.Controls.Add(this.text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(427, 174);
            this.MinimumSize = new System.Drawing.Size(427, 174);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button git;
        private System.Windows.Forms.Button ok;
    }
}