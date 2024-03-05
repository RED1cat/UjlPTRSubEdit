namespace ujlptr_subedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.ListView = new System.Windows.Forms.ListView();
            this.GroupColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointerLocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxLenghtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentLengthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SwitchingTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel = new System.Windows.Forms.Panel();
            this.SwitchingTimeTextBox = new System.Windows.Forms.TextBox();
            this.SwitchingTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.GroupIdLabel = new System.Windows.Forms.Label();
            this.AllLengthLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.MaxLengthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView.AutoArrange = false;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GroupColumn,
            this.IdColumn,
            this.PointerLocationColumn,
            this.MaxLenghtColumn,
            this.CurrentLengthColumn,
            this.TextColumn,
            this.TimeColumn,
            this.SwitchingTimeColumn});
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(1025, 478);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView_ItemChecked);
            this.ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            // 
            // GroupColumn
            // 
            this.GroupColumn.Text = "Group";
            this.GroupColumn.Width = 61;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 52;
            // 
            // PointerLocationColumn
            // 
            this.PointerLocationColumn.Text = "PointerLocation";
            this.PointerLocationColumn.Width = 98;
            // 
            // MaxLenghtColumn
            // 
            this.MaxLenghtColumn.Text = "MaxLenght";
            this.MaxLenghtColumn.Width = 75;
            // 
            // CurrentLengthColumn
            // 
            this.CurrentLengthColumn.Text = "CurrentLength";
            this.CurrentLengthColumn.Width = 91;
            // 
            // TextColumn
            // 
            this.TextColumn.Text = "Text";
            this.TextColumn.Width = 474;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Text = "Time";
            this.TimeColumn.Width = 65;
            // 
            // SwitchingTimeColumn
            // 
            this.SwitchingTimeColumn.Text = "SwitchingTime";
            this.SwitchingTimeColumn.Width = 99;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.SwitchingTimeTextBox);
            this.Panel.Controls.Add(this.SwitchingTimeLabel);
            this.Panel.Controls.Add(this.TimeLabel);
            this.Panel.Controls.Add(this.TimeTextBox);
            this.Panel.Controls.Add(this.GroupIdLabel);
            this.Panel.Controls.Add(this.AllLengthLabel);
            this.Panel.Controls.Add(this.IdLabel);
            this.Panel.Controls.Add(this.EditButton);
            this.Panel.Controls.Add(this.MaxLengthLabel);
            this.Panel.Controls.Add(this.LengthLabel);
            this.Panel.Controls.Add(this.TextBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 478);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1025, 68);
            this.Panel.TabIndex = 1;
            // 
            // SwitchingTimeTextBox
            // 
            this.SwitchingTimeTextBox.Enabled = false;
            this.SwitchingTimeTextBox.Location = new System.Drawing.Point(250, 30);
            this.SwitchingTimeTextBox.Name = "SwitchingTimeTextBox";
            this.SwitchingTimeTextBox.Size = new System.Drawing.Size(66, 20);
            this.SwitchingTimeTextBox.TabIndex = 16;
            this.SwitchingTimeTextBox.TabStop = false;
            this.SwitchingTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SwitchingTimeTextBox.Visible = false;
            // 
            // SwitchingTimeLabel
            // 
            this.SwitchingTimeLabel.AutoSize = true;
            this.SwitchingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwitchingTimeLabel.Location = new System.Drawing.Point(158, 31);
            this.SwitchingTimeLabel.Name = "SwitchingTimeLabel";
            this.SwitchingTimeLabel.Size = new System.Drawing.Size(91, 15);
            this.SwitchingTimeLabel.TabIndex = 15;
            this.SwitchingTimeLabel.Text = "SwitchingTime:";
            this.SwitchingTimeLabel.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(158, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(38, 15);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time:";
            this.TimeLabel.Visible = false;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Enabled = false;
            this.TimeTextBox.Location = new System.Drawing.Point(250, 7);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(66, 20);
            this.TimeTextBox.TabIndex = 13;
            this.TimeTextBox.TabStop = false;
            this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTextBox.Visible = false;
            // 
            // GroupIdLabel
            // 
            this.GroupIdLabel.AutoSize = true;
            this.GroupIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupIdLabel.Location = new System.Drawing.Point(3, 8);
            this.GroupIdLabel.Name = "GroupIdLabel";
            this.GroupIdLabel.Size = new System.Drawing.Size(51, 15);
            this.GroupIdLabel.TabIndex = 6;
            this.GroupIdLabel.Text = "GroupId";
            this.GroupIdLabel.Visible = false;
            // 
            // AllLengthLabel
            // 
            this.AllLengthLabel.AutoSize = true;
            this.AllLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllLengthLabel.Location = new System.Drawing.Point(78, 26);
            this.AllLengthLabel.Name = "AllLengthLabel";
            this.AllLengthLabel.Size = new System.Drawing.Size(58, 15);
            this.AllLengthLabel.TabIndex = 5;
            this.AllLengthLabel.Text = "AllLength";
            this.AllLengthLabel.Visible = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(3, 26);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(17, 15);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Id";
            this.IdLabel.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(799, 23);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Apply";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MaxLengthLabel
            // 
            this.MaxLengthLabel.AutoSize = true;
            this.MaxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxLengthLabel.Location = new System.Drawing.Point(78, 8);
            this.MaxLengthLabel.Name = "MaxLengthLabel";
            this.MaxLengthLabel.Size = new System.Drawing.Size(69, 15);
            this.MaxLengthLabel.TabIndex = 2;
            this.MaxLengthLabel.Text = "MaxLength";
            this.MaxLengthLabel.Visible = false;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthLabel.Location = new System.Drawing.Point(78, 44);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(45, 15);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length";
            this.LengthLabel.Visible = false;
            // 
            // TextBox
            // 
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(319, 6);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(474, 57);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "1\r\n2\r\n3\r\n4";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 478);
            this.panel1.TabIndex = 2;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader MaxLenghtColumn;
        private System.Windows.Forms.ColumnHeader CurrentLengthColumn;
        private System.Windows.Forms.ColumnHeader TextColumn;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.ColumnHeader SwitchingTimeColumn;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MaxLengthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ColumnHeader PointerLocationColumn;
        private System.Windows.Forms.Label AllLengthLabel;
        private System.Windows.Forms.ColumnHeader GroupColumn;
        private System.Windows.Forms.Label GroupIdLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox SwitchingTimeTextBox;
        private System.Windows.Forms.Label SwitchingTimeLabel;
        private System.Windows.Forms.Label TimeLabel;
    }
}