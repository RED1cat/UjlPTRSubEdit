namespace ujlptr_subedit.TextPreview
{
    partial class TextPreview
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
            this.AdvanceMode_checkBox = new System.Windows.Forms.CheckBox();
            this.Backgrounds_groupBox = new System.Windows.Forms.GroupBox();
            this.Backgrounds_radioButton4 = new System.Windows.Forms.RadioButton();
            this.Backgrounds_radioButton3 = new System.Windows.Forms.RadioButton();
            this.Backgrounds_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Backgrounds_radioButton1 = new System.Windows.Forms.RadioButton();
            this.Fonts_groupBox = new System.Windows.Forms.GroupBox();
            this.Font_comboBox = new System.Windows.Forms.ComboBox();
            this.TextRender = new ujlptr_subedit.TextPreview.TextPreviewRender();
            this.Backgrounds_groupBox.SuspendLayout();
            this.Fonts_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdvanceMode_checkBox
            // 
            this.AdvanceMode_checkBox.AutoSize = true;
            this.AdvanceMode_checkBox.Location = new System.Drawing.Point(305, 0);
            this.AdvanceMode_checkBox.Name = "AdvanceMode_checkBox";
            this.AdvanceMode_checkBox.Size = new System.Drawing.Size(15, 14);
            this.AdvanceMode_checkBox.TabIndex = 1;
            this.AdvanceMode_checkBox.UseVisualStyleBackColor = true;
            this.AdvanceMode_checkBox.CheckedChanged += new System.EventHandler(this.AdvanceModeCheckBox_CheckedChanged);
            // 
            // Backgrounds_groupBox
            // 
            this.Backgrounds_groupBox.Controls.Add(this.Backgrounds_radioButton4);
            this.Backgrounds_groupBox.Controls.Add(this.Backgrounds_radioButton3);
            this.Backgrounds_groupBox.Controls.Add(this.Backgrounds_radioButton2);
            this.Backgrounds_groupBox.Controls.Add(this.Backgrounds_radioButton1);
            this.Backgrounds_groupBox.Location = new System.Drawing.Point(326, 12);
            this.Backgrounds_groupBox.Name = "Backgrounds_groupBox";
            this.Backgrounds_groupBox.Size = new System.Drawing.Size(92, 112);
            this.Backgrounds_groupBox.TabIndex = 2;
            this.Backgrounds_groupBox.TabStop = false;
            this.Backgrounds_groupBox.Text = "Backgrounds";
            // 
            // Backgrounds_radioButton4
            // 
            this.Backgrounds_radioButton4.AutoSize = true;
            this.Backgrounds_radioButton4.Location = new System.Drawing.Point(6, 88);
            this.Backgrounds_radioButton4.Name = "Backgrounds_radioButton4";
            this.Backgrounds_radioButton4.Size = new System.Drawing.Size(57, 17);
            this.Backgrounds_radioButton4.TabIndex = 3;
            this.Backgrounds_radioButton4.Text = "bg №4";
            this.Backgrounds_radioButton4.UseVisualStyleBackColor = true;
            this.Backgrounds_radioButton4.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // Backgrounds_radioButton3
            // 
            this.Backgrounds_radioButton3.AutoSize = true;
            this.Backgrounds_radioButton3.Location = new System.Drawing.Point(6, 65);
            this.Backgrounds_radioButton3.Name = "Backgrounds_radioButton3";
            this.Backgrounds_radioButton3.Size = new System.Drawing.Size(57, 17);
            this.Backgrounds_radioButton3.TabIndex = 2;
            this.Backgrounds_radioButton3.Text = "bg №3";
            this.Backgrounds_radioButton3.UseVisualStyleBackColor = true;
            this.Backgrounds_radioButton3.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // Backgrounds_radioButton2
            // 
            this.Backgrounds_radioButton2.AutoSize = true;
            this.Backgrounds_radioButton2.Location = new System.Drawing.Point(6, 42);
            this.Backgrounds_radioButton2.Name = "Backgrounds_radioButton2";
            this.Backgrounds_radioButton2.Size = new System.Drawing.Size(57, 17);
            this.Backgrounds_radioButton2.TabIndex = 1;
            this.Backgrounds_radioButton2.Text = "bg №2";
            this.Backgrounds_radioButton2.UseVisualStyleBackColor = true;
            this.Backgrounds_radioButton2.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // Backgrounds_radioButton1
            // 
            this.Backgrounds_radioButton1.AutoSize = true;
            this.Backgrounds_radioButton1.Checked = true;
            this.Backgrounds_radioButton1.Location = new System.Drawing.Point(6, 19);
            this.Backgrounds_radioButton1.Name = "Backgrounds_radioButton1";
            this.Backgrounds_radioButton1.Size = new System.Drawing.Size(57, 17);
            this.Backgrounds_radioButton1.TabIndex = 0;
            this.Backgrounds_radioButton1.TabStop = true;
            this.Backgrounds_radioButton1.Text = "bg №1";
            this.Backgrounds_radioButton1.UseVisualStyleBackColor = true;
            this.Backgrounds_radioButton1.CheckedChanged += new System.EventHandler(this.BackgroundsRadioButton_CheckedChanged);
            // 
            // Fonts_groupBox
            // 
            this.Fonts_groupBox.Controls.Add(this.Font_comboBox);
            this.Fonts_groupBox.Location = new System.Drawing.Point(326, 130);
            this.Fonts_groupBox.Name = "Fonts_groupBox";
            this.Fonts_groupBox.Size = new System.Drawing.Size(92, 52);
            this.Fonts_groupBox.TabIndex = 3;
            this.Fonts_groupBox.TabStop = false;
            this.Fonts_groupBox.Text = "Fonts";
            // 
            // Font_comboBox
            // 
            this.Font_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Font_comboBox.FormattingEnabled = true;
            this.Font_comboBox.Location = new System.Drawing.Point(6, 19);
            this.Font_comboBox.Name = "Font_comboBox";
            this.Font_comboBox.Size = new System.Drawing.Size(80, 21);
            this.Font_comboBox.TabIndex = 0;
            this.Font_comboBox.SelectedIndexChanged += new System.EventHandler(this.Font_comboBox_SelectedIndexChanged);
            // 
            // TextRender
            // 
            this.TextRender.Location = new System.Drawing.Point(0, 0);
            this.TextRender.MouseHoverUpdatesOnly = false;
            this.TextRender.Name = "TextRender";
            this.TextRender.Size = new System.Drawing.Size(320, 240);
            this.TextRender.TabIndex = 0;
            this.TextRender.Text = "ujlTextPreviewRender1";
            // 
            // TextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 240);
            this.Controls.Add(this.Fonts_groupBox);
            this.Controls.Add(this.Backgrounds_groupBox);
            this.Controls.Add(this.AdvanceMode_checkBox);
            this.Controls.Add(this.TextRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TextPreview";
            this.Text = "UjlTextPreview";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UjlTextPreview_FormClosing);
            this.Backgrounds_groupBox.ResumeLayout(false);
            this.Backgrounds_groupBox.PerformLayout();
            this.Fonts_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextPreviewRender TextRender;
        private System.Windows.Forms.CheckBox AdvanceMode_checkBox;
        private System.Windows.Forms.GroupBox Backgrounds_groupBox;
        private System.Windows.Forms.RadioButton Backgrounds_radioButton3;
        private System.Windows.Forms.RadioButton Backgrounds_radioButton2;
        private System.Windows.Forms.RadioButton Backgrounds_radioButton1;
        private System.Windows.Forms.RadioButton Backgrounds_radioButton4;
        private System.Windows.Forms.GroupBox Fonts_groupBox;
        private System.Windows.Forms.ComboBox Font_comboBox;
    }
}