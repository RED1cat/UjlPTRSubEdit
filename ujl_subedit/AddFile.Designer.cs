
namespace ujl_subedit
{
    partial class addFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFile));
            this.encodeText = new System.Windows.Forms.TextBox();
            this.FirstAddress = new System.Windows.Forms.TextBox();
            this.LengthLine = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numberLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encodeText
            // 
            this.encodeText.Font = new System.Drawing.Font("Courier New", 12F);
            this.encodeText.Location = new System.Drawing.Point(12, 41);
            this.encodeText.Multiline = true;
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(406, 120);
            this.encodeText.TabIndex = 2;
            // 
            // FirstAddress
            // 
            this.FirstAddress.Font = new System.Drawing.Font("Courier New", 12F);
            this.FirstAddress.Location = new System.Drawing.Point(93, 11);
            this.FirstAddress.Name = "FirstAddress";
            this.FirstAddress.Size = new System.Drawing.Size(100, 26);
            this.FirstAddress.TabIndex = 3;
            this.FirstAddress.Text = "84960";
            // 
            // LengthLine
            // 
            this.LengthLine.AutoSize = true;
            this.LengthLine.Font = new System.Drawing.Font("Courier New", 12F);
            this.LengthLine.Location = new System.Drawing.Point(307, 14);
            this.LengthLine.Name = "LengthLine";
            this.LengthLine.Size = new System.Drawing.Size(108, 18);
            this.LengthLine.TabIndex = 4;
            this.LengthLine.Text = "LengthLine";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Courier New", 12F);
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 5;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Courier New", 12F);
            this.Start.Location = new System.Drawing.Point(211, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numberLines
            // 
            this.numberLines.AutoSize = true;
            this.numberLines.Font = new System.Drawing.Font("Courier New", 12F);
            this.numberLines.Location = new System.Drawing.Point(424, 44);
            this.numberLines.Name = "numberLines";
            this.numberLines.Size = new System.Drawing.Size(118, 18);
            this.numberLines.TabIndex = 7;
            this.numberLines.Text = "numberLines";
            // 
            // addFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(510, 167);
            this.Controls.Add(this.numberLines);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.LengthLine);
            this.Controls.Add(this.FirstAddress);
            this.Controls.Add(this.encodeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(526, 206);
            this.MinimumSize = new System.Drawing.Size(526, 206);
            this.Name = "addFile";
            this.Load += new System.EventHandler(this.AddFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox encodeText;
        private System.Windows.Forms.TextBox FirstAddress;
        private System.Windows.Forms.Label LengthLine;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label numberLines;
    }
}