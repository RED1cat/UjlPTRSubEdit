namespace ujl_subedit
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.panel1 = new System.Windows.Forms.Panel();
            this.alphaBlendTextBox2 = new ZBobb.AlphaBlendTextBox();
            this.alphaBlendTextBox3 = new ZBobb.AlphaBlendTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.alphaBlendTextBox3);
            this.panel1.Controls.Add(this.alphaBlendTextBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 544);
            this.panel1.TabIndex = 3;
            // 
            // alphaBlendTextBox2
            // 
            this.alphaBlendTextBox2.BackAlpha = 10;
            this.alphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox2.Location = new System.Drawing.Point(292, 254);
            this.alphaBlendTextBox2.Name = "alphaBlendTextBox2";
            this.alphaBlendTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alphaBlendTextBox2.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextBox2.TabIndex = 1;
            this.alphaBlendTextBox2.Text = "amogus";
            this.alphaBlendTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alphaBlendTextBox3
            // 
            this.alphaBlendTextBox3.BackAlpha = 0;
            this.alphaBlendTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alphaBlendTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox3.Font = new System.Drawing.Font("Dom Diagonal BoldC BT", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.alphaBlendTextBox3.ForeColor = System.Drawing.Color.White;
            this.alphaBlendTextBox3.Location = new System.Drawing.Point(12, 377);
            this.alphaBlendTextBox3.Name = "alphaBlendTextBox3";
            this.alphaBlendTextBox3.Size = new System.Drawing.Size(615, 52);
            this.alphaBlendTextBox3.TabIndex = 2;
            this.alphaBlendTextBox3.Text = "Chop chop back again";
            this.alphaBlendTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 544);
            this.Controls.Add(this.panel1);
            this.Name = "test";
            this.Text = "test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox3;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox2;
    }
}