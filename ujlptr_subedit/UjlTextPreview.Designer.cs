namespace ujlptr_subedit
{
    partial class UjlTextPreview
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
            this.m_UjlTextPreviewRender = new ujlptr_subedit.UjlTextPreviewRender();
            this.SuspendLayout();
            // 
            // m_UjlTextPreviewRender
            // 
            this.m_UjlTextPreviewRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_UjlTextPreviewRender.Location = new System.Drawing.Point(0, 0);
            this.m_UjlTextPreviewRender.MouseHoverUpdatesOnly = false;
            this.m_UjlTextPreviewRender.Name = "m_UjlTextPreviewRender";
            this.m_UjlTextPreviewRender.Size = new System.Drawing.Size(320, 240);
            this.m_UjlTextPreviewRender.TabIndex = 0;
            this.m_UjlTextPreviewRender.Text = "ujlTextPreviewRender1";
            // 
            // UjlTextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.m_UjlTextPreviewRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UjlTextPreview";
            this.Text = "UjlTextPreview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UjlTextPreview_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UjlTextPreviewRender m_UjlTextPreviewRender;
    }
}