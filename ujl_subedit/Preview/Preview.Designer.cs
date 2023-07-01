
namespace ujl_subedit.Preview
{
    partial class Preview
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
            this.drawPreview1 = new ujl_subedit.Preview.DrawPreview();
            this.SuspendLayout();
            // 
            // drawPreview1
            // 
            this.drawPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPreview1.Location = new System.Drawing.Point(0, 0);
            this.drawPreview1.MouseHoverUpdatesOnly = false;
            this.drawPreview1.Name = "drawPreview1";
            this.drawPreview1.Size = new System.Drawing.Size(800, 450);
            this.drawPreview1.TabIndex = 0;
            this.drawPreview1.Text = "drawPreview1";
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPreview1);
            this.Name = "Preview";
            this.Text = "Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private DrawPreview drawPreview1;
    }
}