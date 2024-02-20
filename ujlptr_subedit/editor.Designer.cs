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
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointerLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxLenghtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentLengthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressInGameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressInFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SwitchingTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel = new System.Windows.Forms.Panel();
            this.SwitchingTimeTextBox = new System.Windows.Forms.TextBox();
            this.SwitchingTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.ReduceMaxSymbolOnLineButton = new System.Windows.Forms.Button();
            this.NumberSymbolsToChangeTextBox = new System.Windows.Forms.TextBox();
            this.IncreaseMaxSymbolOnLineButton = new System.Windows.Forms.Button();
            this.GroupIdLabel = new System.Windows.Forms.Label();
            this.PointerLocationLabel = new System.Windows.Forms.Label();
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
            this.IdColumn,
            this.PointerLocation,
            this.MaxLenghtColumn,
            this.CurrentLengthColumn,
            this.TextColumn,
            this.AddressInGameColumn,
            this.AddressInFile,
            this.TimeColumn,
            this.SwitchingTimeColumn,
            this.Group});
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(1159, 478);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView_ItemChecked);
            this.ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 52;
            // 
            // PointerLocation
            // 
            this.PointerLocation.Text = "PointerLocation";
            this.PointerLocation.Width = 98;
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
            // AddressInGameColumn
            // 
            this.AddressInGameColumn.Text = "AddressInGame";
            this.AddressInGameColumn.Width = 104;
            // 
            // AddressInFile
            // 
            this.AddressInFile.Text = "AddressInFile";
            this.AddressInFile.Width = 93;
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
            // Group
            // 
            this.Group.Text = "Group";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.SwitchingTimeTextBox);
            this.Panel.Controls.Add(this.SwitchingTimeLabel);
            this.Panel.Controls.Add(this.TimeLabel);
            this.Panel.Controls.Add(this.TimeTextBox);
            this.Panel.Controls.Add(this.ReduceMaxSymbolOnLineButton);
            this.Panel.Controls.Add(this.NumberSymbolsToChangeTextBox);
            this.Panel.Controls.Add(this.IncreaseMaxSymbolOnLineButton);
            this.Panel.Controls.Add(this.GroupIdLabel);
            this.Panel.Controls.Add(this.PointerLocationLabel);
            this.Panel.Controls.Add(this.IdLabel);
            this.Panel.Controls.Add(this.EditButton);
            this.Panel.Controls.Add(this.MaxLengthLabel);
            this.Panel.Controls.Add(this.LengthLabel);
            this.Panel.Controls.Add(this.TextBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 478);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1159, 68);
            this.Panel.TabIndex = 1;
            // 
            // SwitchingTimeTextBox
            // 
            this.SwitchingTimeTextBox.Enabled = false;
            this.SwitchingTimeTextBox.Location = new System.Drawing.Point(893, 30);
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
            this.SwitchingTimeLabel.Location = new System.Drawing.Point(799, 31);
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
            this.TimeLabel.Location = new System.Drawing.Point(799, 7);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(38, 15);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time:";
            this.TimeLabel.Visible = false;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Enabled = false;
            this.TimeTextBox.Location = new System.Drawing.Point(893, 7);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(66, 20);
            this.TimeTextBox.TabIndex = 13;
            this.TimeTextBox.TabStop = false;
            this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTextBox.Visible = false;
            // 
            // ReduceMaxSymbolOnLineButton
            // 
            this.ReduceMaxSymbolOnLineButton.Enabled = false;
            this.ReduceMaxSymbolOnLineButton.Location = new System.Drawing.Point(63, 28);
            this.ReduceMaxSymbolOnLineButton.Name = "ReduceMaxSymbolOnLineButton";
            this.ReduceMaxSymbolOnLineButton.Size = new System.Drawing.Size(75, 23);
            this.ReduceMaxSymbolOnLineButton.TabIndex = 12;
            this.ReduceMaxSymbolOnLineButton.TabStop = false;
            this.ReduceMaxSymbolOnLineButton.Text = "ReduceMax";
            this.ReduceMaxSymbolOnLineButton.UseVisualStyleBackColor = true;
            this.ReduceMaxSymbolOnLineButton.Visible = false;
            this.ReduceMaxSymbolOnLineButton.Click += new System.EventHandler(this.ChangeMaxSymbolOnLineButton_Click);
            // 
            // NumberSymbolsToChangeTextBox
            // 
            this.NumberSymbolsToChangeTextBox.Enabled = false;
            this.NumberSymbolsToChangeTextBox.Location = new System.Drawing.Point(144, 30);
            this.NumberSymbolsToChangeTextBox.Name = "NumberSymbolsToChangeTextBox";
            this.NumberSymbolsToChangeTextBox.Size = new System.Drawing.Size(66, 20);
            this.NumberSymbolsToChangeTextBox.TabIndex = 11;
            this.NumberSymbolsToChangeTextBox.TabStop = false;
            this.NumberSymbolsToChangeTextBox.Text = "1";
            this.NumberSymbolsToChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberSymbolsToChangeTextBox.Visible = false;
            // 
            // IncreaseMaxSymbolOnLineButton
            // 
            this.IncreaseMaxSymbolOnLineButton.Enabled = false;
            this.IncreaseMaxSymbolOnLineButton.Location = new System.Drawing.Point(216, 28);
            this.IncreaseMaxSymbolOnLineButton.Name = "IncreaseMaxSymbolOnLineButton";
            this.IncreaseMaxSymbolOnLineButton.Size = new System.Drawing.Size(75, 23);
            this.IncreaseMaxSymbolOnLineButton.TabIndex = 10;
            this.IncreaseMaxSymbolOnLineButton.TabStop = false;
            this.IncreaseMaxSymbolOnLineButton.Text = "IncreaseMax";
            this.IncreaseMaxSymbolOnLineButton.UseVisualStyleBackColor = true;
            this.IncreaseMaxSymbolOnLineButton.Visible = false;
            this.IncreaseMaxSymbolOnLineButton.Click += new System.EventHandler(this.ChangeMaxSymbolOnLineButton_Click);
            // 
            // GroupIdLabel
            // 
            this.GroupIdLabel.AutoSize = true;
            this.GroupIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupIdLabel.Location = new System.Drawing.Point(4, 31);
            this.GroupIdLabel.Name = "GroupIdLabel";
            this.GroupIdLabel.Size = new System.Drawing.Size(51, 15);
            this.GroupIdLabel.TabIndex = 6;
            this.GroupIdLabel.Text = "GroupId";
            this.GroupIdLabel.Visible = false;
            // 
            // PointerLocationLabel
            // 
            this.PointerLocationLabel.AutoSize = true;
            this.PointerLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointerLocationLabel.Location = new System.Drawing.Point(61, 4);
            this.PointerLocationLabel.Name = "PointerLocationLabel";
            this.PointerLocationLabel.Size = new System.Drawing.Size(82, 15);
            this.PointerLocationLabel.TabIndex = 5;
            this.PointerLocationLabel.Text = "PointLocation";
            this.PointerLocationLabel.Visible = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(4, 4);
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
            this.MaxLengthLabel.Location = new System.Drawing.Point(141, 4);
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
            this.LengthLabel.Location = new System.Drawing.Point(221, 4);
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
            this.panel1.Size = new System.Drawing.Size(1159, 478);
            this.panel1.TabIndex = 2;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Editor_SizeChanged);
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
        private System.Windows.Forms.ColumnHeader AddressInGameColumn;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.ColumnHeader SwitchingTimeColumn;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MaxLengthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ColumnHeader PointerLocation;
        private System.Windows.Forms.ColumnHeader AddressInFile;
        private System.Windows.Forms.Label PointerLocationLabel;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.Label GroupIdLabel;
        private System.Windows.Forms.Button IncreaseMaxSymbolOnLineButton;
        private System.Windows.Forms.Button ReduceMaxSymbolOnLineButton;
        private System.Windows.Forms.TextBox NumberSymbolsToChangeTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox SwitchingTimeTextBox;
        private System.Windows.Forms.Label SwitchingTimeLabel;
        private System.Windows.Forms.Label TimeLabel;
    }
}