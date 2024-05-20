namespace ujlptr_subedit.TextPreview
{
    partial class FontConstructor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "00",
            "000",
            "000",
            "000",
            "000",
            "000",
            "NewLine"}, -1);
            this.Font_listView = new System.Windows.Forms.ListView();
            this.Number_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hex_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offset_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CharType_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Font_label = new System.Windows.Forms.Label();
            this.Font_comboBox = new System.Windows.Forms.ComboBox();
            this.Hex_textBox = new System.Windows.Forms.TextBox();
            this.Offset_textBox = new System.Windows.Forms.TextBox();
            this.Hex_label = new System.Windows.Forms.Label();
            this.Offset_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.Width_textBox = new System.Windows.Forms.TextBox();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.Height_label = new System.Windows.Forms.Label();
            this.Height_textBox = new System.Windows.Forms.TextBox();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.SaveFont_button = new System.Windows.Forms.Button();
            this.CharType_comboBox = new System.Windows.Forms.ComboBox();
            this.CharType_label = new System.Windows.Forms.Label();
            this.Create_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.X_label = new System.Windows.Forms.Label();
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Font_listView
            // 
            this.Font_listView.AutoArrange = false;
            this.Font_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number_column,
            this.Hex_column,
            this.Offset_column,
            this.X_column,
            this.Y_column,
            this.Width_column,
            this.Height_column,
            this.CharType_column});
            this.Font_listView.FullRowSelect = true;
            this.Font_listView.GridLines = true;
            this.Font_listView.HideSelection = false;
            this.Font_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Font_listView.Location = new System.Drawing.Point(176, 6);
            this.Font_listView.MultiSelect = false;
            this.Font_listView.Name = "Font_listView";
            this.Font_listView.Size = new System.Drawing.Size(343, 372);
            this.Font_listView.TabIndex = 13;
            this.Font_listView.UseCompatibleStateImageBehavior = false;
            this.Font_listView.View = System.Windows.Forms.View.Details;
            this.Font_listView.SelectedIndexChanged += new System.EventHandler(this.Font_listView_SelectedIndexChanged);
            // 
            // Number_column
            // 
            this.Number_column.Text = "№";
            this.Number_column.Width = 30;
            // 
            // Hex_column
            // 
            this.Hex_column.Text = "Hex";
            this.Hex_column.Width = 32;
            // 
            // Offset_column
            // 
            this.Offset_column.Text = "Offset";
            this.Offset_column.Width = 43;
            // 
            // X_column
            // 
            this.X_column.Text = "X";
            this.X_column.Width = 32;
            // 
            // Y_column
            // 
            this.Y_column.Text = "Y";
            this.Y_column.Width = 32;
            // 
            // Width_column
            // 
            this.Width_column.Text = "Width";
            this.Width_column.Width = 45;
            // 
            // Height_column
            // 
            this.Height_column.Text = "Height";
            this.Height_column.Width = 45;
            // 
            // CharType_column
            // 
            this.CharType_column.Text = "CharType";
            this.CharType_column.Width = 59;
            // 
            // Font_label
            // 
            this.Font_label.AutoSize = true;
            this.Font_label.Location = new System.Drawing.Point(9, 64);
            this.Font_label.Name = "Font_label";
            this.Font_label.Size = new System.Drawing.Size(31, 13);
            this.Font_label.TabIndex = 1;
            this.Font_label.Text = "Font:";
            // 
            // Font_comboBox
            // 
            this.Font_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Font_comboBox.FormattingEnabled = true;
            this.Font_comboBox.Location = new System.Drawing.Point(49, 61);
            this.Font_comboBox.Name = "Font_comboBox";
            this.Font_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Font_comboBox.TabIndex = 3;
            this.Font_comboBox.SelectedIndexChanged += new System.EventHandler(this.Font_comboBox_SelectedIndexChanged);
            // 
            // Hex_textBox
            // 
            this.Hex_textBox.Location = new System.Drawing.Point(49, 103);
            this.Hex_textBox.Name = "Hex_textBox";
            this.Hex_textBox.Size = new System.Drawing.Size(100, 20);
            this.Hex_textBox.TabIndex = 4;
            // 
            // Offset_textBox
            // 
            this.Offset_textBox.Location = new System.Drawing.Point(49, 137);
            this.Offset_textBox.Name = "Offset_textBox";
            this.Offset_textBox.Size = new System.Drawing.Size(100, 20);
            this.Offset_textBox.TabIndex = 5;
            // 
            // Hex_label
            // 
            this.Hex_label.AutoSize = true;
            this.Hex_label.Location = new System.Drawing.Point(9, 106);
            this.Hex_label.Name = "Hex_label";
            this.Hex_label.Size = new System.Drawing.Size(29, 13);
            this.Hex_label.TabIndex = 8;
            this.Hex_label.Text = "Hex:";
            // 
            // Offset_label
            // 
            this.Offset_label.AutoSize = true;
            this.Offset_label.Location = new System.Drawing.Point(9, 140);
            this.Offset_label.Name = "Offset_label";
            this.Offset_label.Size = new System.Drawing.Size(38, 13);
            this.Offset_label.TabIndex = 9;
            this.Offset_label.Text = "Offset:";
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(9, 242);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(38, 13);
            this.Width_label.TabIndex = 13;
            this.Width_label.Text = "Width:";
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.Location = new System.Drawing.Point(9, 208);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(17, 13);
            this.Y_label.TabIndex = 12;
            this.Y_label.Text = "Y:";
            // 
            // Width_textBox
            // 
            this.Width_textBox.Location = new System.Drawing.Point(49, 239);
            this.Width_textBox.Name = "Width_textBox";
            this.Width_textBox.Size = new System.Drawing.Size(100, 20);
            this.Width_textBox.TabIndex = 8;
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(49, 205);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(100, 20);
            this.Y_textBox.TabIndex = 7;
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Location = new System.Drawing.Point(9, 276);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(41, 13);
            this.Height_label.TabIndex = 16;
            this.Height_label.Text = "Height:";
            // 
            // Height_textBox
            // 
            this.Height_textBox.Location = new System.Drawing.Point(49, 273);
            this.Height_textBox.Name = "Height_textBox";
            this.Height_textBox.Size = new System.Drawing.Size(100, 20);
            this.Height_textBox.TabIndex = 9;
            // 
            // Modify_button
            // 
            this.Modify_button.Enabled = false;
            this.Modify_button.Location = new System.Drawing.Point(12, 326);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_button.TabIndex = 11;
            this.Modify_button.Text = "Modify";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(95, 326);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 12;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // SaveFont_button
            // 
            this.SaveFont_button.Location = new System.Drawing.Point(12, 355);
            this.SaveFont_button.Name = "SaveFont_button";
            this.SaveFont_button.Size = new System.Drawing.Size(158, 23);
            this.SaveFont_button.TabIndex = 14;
            this.SaveFont_button.Text = "Save font";
            this.SaveFont_button.UseVisualStyleBackColor = true;
            this.SaveFont_button.Click += new System.EventHandler(this.SaveFont_button_Click);
            // 
            // CharType_comboBox
            // 
            this.CharType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharType_comboBox.FormattingEnabled = true;
            this.CharType_comboBox.Items.AddRange(new object[] {
            "upper",
            "lower",
            "newline",
            "space"});
            this.CharType_comboBox.Location = new System.Drawing.Point(71, 299);
            this.CharType_comboBox.Name = "CharType_comboBox";
            this.CharType_comboBox.Size = new System.Drawing.Size(99, 21);
            this.CharType_comboBox.TabIndex = 10;
            // 
            // CharType_label
            // 
            this.CharType_label.AutoSize = true;
            this.CharType_label.Location = new System.Drawing.Point(9, 302);
            this.CharType_label.Name = "CharType_label";
            this.CharType_label.Size = new System.Drawing.Size(56, 13);
            this.CharType_label.TabIndex = 20;
            this.CharType_label.Text = "CharType:";
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(95, 32);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 2;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(9, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 23;
            this.name_label.Text = "Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(49, 6);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Location = new System.Drawing.Point(9, 174);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(17, 13);
            this.X_label.TabIndex = 26;
            this.X_label.Text = "X:";
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(49, 171);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(100, 20);
            this.X_textBox.TabIndex = 6;
            // 
            // FontConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 383);
            this.Controls.Add(this.X_label);
            this.Controls.Add(this.X_textBox);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.CharType_comboBox);
            this.Controls.Add(this.CharType_label);
            this.Controls.Add(this.SaveFont_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.Height_textBox);
            this.Controls.Add(this.Width_label);
            this.Controls.Add(this.Y_label);
            this.Controls.Add(this.Width_textBox);
            this.Controls.Add(this.Y_textBox);
            this.Controls.Add(this.Offset_label);
            this.Controls.Add(this.Hex_label);
            this.Controls.Add(this.Offset_textBox);
            this.Controls.Add(this.Hex_textBox);
            this.Controls.Add(this.Font_comboBox);
            this.Controls.Add(this.Font_label);
            this.Controls.Add(this.Font_listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FontConstructor";
            this.Text = "FontConstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Font_listView;
        private System.Windows.Forms.Label Font_label;
        private System.Windows.Forms.ComboBox Font_comboBox;
        private System.Windows.Forms.ColumnHeader Hex_column;
        private System.Windows.Forms.ColumnHeader X_column;
        private System.Windows.Forms.ColumnHeader Y_column;
        private System.Windows.Forms.ColumnHeader Width_column;
        private System.Windows.Forms.ColumnHeader Height_column;
        private System.Windows.Forms.ColumnHeader Number_column;
        private System.Windows.Forms.TextBox Hex_textBox;
        private System.Windows.Forms.TextBox Offset_textBox;
        private System.Windows.Forms.Label Hex_label;
        private System.Windows.Forms.Label Offset_label;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.TextBox Width_textBox;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.TextBox Height_textBox;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button SaveFont_button;
        private System.Windows.Forms.ComboBox CharType_comboBox;
        private System.Windows.Forms.Label CharType_label;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.ColumnHeader Offset_column;
        private System.Windows.Forms.ColumnHeader CharType_column;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.TextBox X_textBox;
    }
}