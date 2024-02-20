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
            this.AdvanceModeCheckBox = new System.Windows.Forms.CheckBox();
            this.BackgroundsGroupBox = new System.Windows.Forms.GroupBox();
            this.BackgroundsRadioButton4 = new System.Windows.Forms.RadioButton();
            this.BackgroundsRadioButton3 = new System.Windows.Forms.RadioButton();
            this.BackgroundsRadioButton2 = new System.Windows.Forms.RadioButton();
            this.BackgroundsRadioButton1 = new System.Windows.Forms.RadioButton();
            this.FontsGroupBox = new System.Windows.Forms.GroupBox();
            this.FontsRadioButton2 = new System.Windows.Forms.RadioButton();
            this.FontsRadioButton1 = new System.Windows.Forms.RadioButton();
            this.UjlTextRender = new ujlptr_subedit.UjlTextPreviewRender();
            this.BackgroundsGroupBox.SuspendLayout();
            this.FontsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdvanceModeCheckBox
            // 
            this.AdvanceModeCheckBox.AutoSize = true;
            this.AdvanceModeCheckBox.Location = new System.Drawing.Point(305, 0);
            this.AdvanceModeCheckBox.Name = "AdvanceModeCheckBox";
            this.AdvanceModeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AdvanceModeCheckBox.TabIndex = 1;
            this.AdvanceModeCheckBox.UseVisualStyleBackColor = true;
            this.AdvanceModeCheckBox.CheckedChanged += new System.EventHandler(this.AdvanceModeCheckBox_CheckedChanged);
            // 
            // BackgroundsGroupBox
            // 
            this.BackgroundsGroupBox.Controls.Add(this.BackgroundsRadioButton4);
            this.BackgroundsGroupBox.Controls.Add(this.BackgroundsRadioButton3);
            this.BackgroundsGroupBox.Controls.Add(this.BackgroundsRadioButton2);
            this.BackgroundsGroupBox.Controls.Add(this.BackgroundsRadioButton1);
            this.BackgroundsGroupBox.Location = new System.Drawing.Point(326, 12);
            this.BackgroundsGroupBox.Name = "BackgroundsGroupBox";
            this.BackgroundsGroupBox.Size = new System.Drawing.Size(92, 112);
            this.BackgroundsGroupBox.TabIndex = 2;
            this.BackgroundsGroupBox.TabStop = false;
            this.BackgroundsGroupBox.Text = "Backgrounds";
            // 
            // BackgroundsRadioButton4
            // 
            this.BackgroundsRadioButton4.AutoSize = true;
            this.BackgroundsRadioButton4.Location = new System.Drawing.Point(6, 88);
            this.BackgroundsRadioButton4.Name = "BackgroundsRadioButton4";
            this.BackgroundsRadioButton4.Size = new System.Drawing.Size(57, 17);
            this.BackgroundsRadioButton4.TabIndex = 3;
            this.BackgroundsRadioButton4.Text = "bg №4";
            this.BackgroundsRadioButton4.UseVisualStyleBackColor = true;
            this.BackgroundsRadioButton4.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // BackgroundsRadioButton3
            // 
            this.BackgroundsRadioButton3.AutoSize = true;
            this.BackgroundsRadioButton3.Location = new System.Drawing.Point(6, 65);
            this.BackgroundsRadioButton3.Name = "BackgroundsRadioButton3";
            this.BackgroundsRadioButton3.Size = new System.Drawing.Size(57, 17);
            this.BackgroundsRadioButton3.TabIndex = 2;
            this.BackgroundsRadioButton3.Text = "bg №3";
            this.BackgroundsRadioButton3.UseVisualStyleBackColor = true;
            this.BackgroundsRadioButton3.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // BackgroundsRadioButton2
            // 
            this.BackgroundsRadioButton2.AutoSize = true;
            this.BackgroundsRadioButton2.Location = new System.Drawing.Point(6, 42);
            this.BackgroundsRadioButton2.Name = "BackgroundsRadioButton2";
            this.BackgroundsRadioButton2.Size = new System.Drawing.Size(57, 17);
            this.BackgroundsRadioButton2.TabIndex = 1;
            this.BackgroundsRadioButton2.Text = "bg №2";
            this.BackgroundsRadioButton2.UseVisualStyleBackColor = true;
            this.BackgroundsRadioButton2.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // BackgroundsRadioButton1
            // 
            this.BackgroundsRadioButton1.AutoSize = true;
            this.BackgroundsRadioButton1.Checked = true;
            this.BackgroundsRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.BackgroundsRadioButton1.Name = "BackgroundsRadioButton1";
            this.BackgroundsRadioButton1.Size = new System.Drawing.Size(57, 17);
            this.BackgroundsRadioButton1.TabIndex = 0;
            this.BackgroundsRadioButton1.TabStop = true;
            this.BackgroundsRadioButton1.Text = "bg №1";
            this.BackgroundsRadioButton1.UseVisualStyleBackColor = true;
            this.BackgroundsRadioButton1.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // FontsGroupBox
            // 
            this.FontsGroupBox.Controls.Add(this.FontsRadioButton2);
            this.FontsGroupBox.Controls.Add(this.FontsRadioButton1);
            this.FontsGroupBox.Location = new System.Drawing.Point(326, 130);
            this.FontsGroupBox.Name = "FontsGroupBox";
            this.FontsGroupBox.Size = new System.Drawing.Size(92, 77);
            this.FontsGroupBox.TabIndex = 3;
            this.FontsGroupBox.TabStop = false;
            this.FontsGroupBox.Text = "Fonts";
            // 
            // FontsRadioButton2
            // 
            this.FontsRadioButton2.AutoSize = true;
            this.FontsRadioButton2.Location = new System.Drawing.Point(6, 42);
            this.FontsRadioButton2.Name = "FontsRadioButton2";
            this.FontsRadioButton2.Size = new System.Drawing.Size(47, 17);
            this.FontsRadioButton2.TabIndex = 1;
            this.FontsRadioButton2.Text = "PTR";
            this.FontsRadioButton2.UseVisualStyleBackColor = true;
            this.FontsRadioButton2.CheckedChanged += new System.EventHandler(this.FontsRadioButton_CheckedChanged);
            // 
            // FontsRadioButton1
            // 
            this.FontsRadioButton1.AutoSize = true;
            this.FontsRadioButton1.Checked = true;
            this.FontsRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.FontsRadioButton1.Name = "FontsRadioButton1";
            this.FontsRadioButton1.Size = new System.Drawing.Size(44, 17);
            this.FontsRadioButton1.TabIndex = 0;
            this.FontsRadioButton1.TabStop = true;
            this.FontsRadioButton1.Text = "UJL";
            this.FontsRadioButton1.UseVisualStyleBackColor = true;
            this.FontsRadioButton1.CheckedChanged += new System.EventHandler(this.FontsRadioButton_CheckedChanged);
            // 
            // UjlTextRender
            // 
            this.UjlTextRender.Location = new System.Drawing.Point(0, 0);
            this.UjlTextRender.MouseHoverUpdatesOnly = false;
            this.UjlTextRender.Name = "UjlTextRender";
            this.UjlTextRender.Size = new System.Drawing.Size(320, 240);
            this.UjlTextRender.TabIndex = 0;
            this.UjlTextRender.Text = "ujlTextPreviewRender1";
            // 
            // UjlTextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 240);
            this.Controls.Add(this.FontsGroupBox);
            this.Controls.Add(this.BackgroundsGroupBox);
            this.Controls.Add(this.AdvanceModeCheckBox);
            this.Controls.Add(this.UjlTextRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UjlTextPreview";
            this.Text = "UjlTextPreview";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UjlTextPreview_FormClosing);
            this.BackgroundsGroupBox.ResumeLayout(false);
            this.BackgroundsGroupBox.PerformLayout();
            this.FontsGroupBox.ResumeLayout(false);
            this.FontsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public UjlTextPreviewRender UjlTextRender;
        private System.Windows.Forms.CheckBox AdvanceModeCheckBox;
        private System.Windows.Forms.GroupBox BackgroundsGroupBox;
        private System.Windows.Forms.RadioButton BackgroundsRadioButton3;
        private System.Windows.Forms.RadioButton BackgroundsRadioButton2;
        private System.Windows.Forms.RadioButton BackgroundsRadioButton1;
        private System.Windows.Forms.RadioButton BackgroundsRadioButton4;
        private System.Windows.Forms.GroupBox FontsGroupBox;
        private System.Windows.Forms.RadioButton FontsRadioButton2;
        private System.Windows.Forms.RadioButton FontsRadioButton1;
    }
}