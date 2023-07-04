namespace ujl_subedit
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
            this.m_ListView = new System.Windows.Forms.ListView();
            this.m_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_PointerLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_MaxLenght = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_CurrentLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_AddressInGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_AddressInFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_SwitchingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_Panel = new System.Windows.Forms.Panel();
            this.m_IdLabel = new System.Windows.Forms.Label();
            this.m_EditButton = new System.Windows.Forms.Button();
            this.m_MaxLengthLabel = new System.Windows.Forms.Label();
            this.m_LengthLabel = new System.Windows.Forms.Label();
            this.m_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_PointerLocationLabel = new System.Windows.Forms.Label();
            this.m_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ListView
            // 
            this.m_ListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.m_ListView.AutoArrange = false;
            this.m_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_Id,
            this.m_PointerLocation,
            this.m_MaxLenght,
            this.m_CurrentLength,
            this.m_Text,
            this.m_AddressInGame,
            this.m_AddressInFile,
            this.m_Time,
            this.m_SwitchingTime});
            this.m_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_ListView.FullRowSelect = true;
            this.m_ListView.GridLines = true;
            this.m_ListView.HideSelection = false;
            this.m_ListView.Location = new System.Drawing.Point(0, 0);
            this.m_ListView.MultiSelect = false;
            this.m_ListView.Name = "m_ListView";
            this.m_ListView.Size = new System.Drawing.Size(1159, 478);
            this.m_ListView.TabIndex = 0;
            this.m_ListView.UseCompatibleStateImageBehavior = false;
            this.m_ListView.View = System.Windows.Forms.View.Details;
            this.m_ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.m_ListView_ItemSelectionChanged);
            // 
            // m_Id
            // 
            this.m_Id.Text = "Id";
            this.m_Id.Width = 52;
            // 
            // m_PointerLocation
            // 
            this.m_PointerLocation.Text = "PointerLocation";
            this.m_PointerLocation.Width = 98;
            // 
            // m_MaxLenght
            // 
            this.m_MaxLenght.Text = "MaxLenght";
            this.m_MaxLenght.Width = 75;
            // 
            // m_CurrentLength
            // 
            this.m_CurrentLength.Text = "CurrentLength";
            this.m_CurrentLength.Width = 91;
            // 
            // m_Text
            // 
            this.m_Text.Text = "Text";
            this.m_Text.Width = 474;
            // 
            // m_AddressInGame
            // 
            this.m_AddressInGame.Text = "AddressInGame";
            this.m_AddressInGame.Width = 104;
            // 
            // m_AddressInFile
            // 
            this.m_AddressInFile.Text = "AddressInFile";
            this.m_AddressInFile.Width = 93;
            // 
            // m_Time
            // 
            this.m_Time.Text = "Time";
            this.m_Time.Width = 65;
            // 
            // m_SwitchingTime
            // 
            this.m_SwitchingTime.Text = "SwitchingTime";
            this.m_SwitchingTime.Width = 99;
            // 
            // m_Panel
            // 
            this.m_Panel.Controls.Add(this.m_PointerLocationLabel);
            this.m_Panel.Controls.Add(this.m_IdLabel);
            this.m_Panel.Controls.Add(this.m_EditButton);
            this.m_Panel.Controls.Add(this.m_MaxLengthLabel);
            this.m_Panel.Controls.Add(this.m_LengthLabel);
            this.m_Panel.Controls.Add(this.m_TextBox);
            this.m_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_Panel.Location = new System.Drawing.Point(0, 478);
            this.m_Panel.Name = "m_Panel";
            this.m_Panel.Size = new System.Drawing.Size(1159, 68);
            this.m_Panel.TabIndex = 1;
            // 
            // m_IdLabel
            // 
            this.m_IdLabel.AutoSize = true;
            this.m_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_IdLabel.Location = new System.Drawing.Point(4, 4);
            this.m_IdLabel.Name = "m_IdLabel";
            this.m_IdLabel.Size = new System.Drawing.Size(17, 15);
            this.m_IdLabel.TabIndex = 4;
            this.m_IdLabel.Text = "Id";
            // 
            // m_EditButton
            // 
            this.m_EditButton.Enabled = false;
            this.m_EditButton.Location = new System.Drawing.Point(799, 23);
            this.m_EditButton.Name = "m_EditButton";
            this.m_EditButton.Size = new System.Drawing.Size(75, 23);
            this.m_EditButton.TabIndex = 3;
            this.m_EditButton.Text = "Edit";
            this.m_EditButton.UseVisualStyleBackColor = true;
            this.m_EditButton.Click += new System.EventHandler(this.m_EditButton_Click);
            // 
            // m_MaxLengthLabel
            // 
            this.m_MaxLengthLabel.AutoSize = true;
            this.m_MaxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_MaxLengthLabel.Location = new System.Drawing.Point(157, 4);
            this.m_MaxLengthLabel.Name = "m_MaxLengthLabel";
            this.m_MaxLengthLabel.Size = new System.Drawing.Size(69, 15);
            this.m_MaxLengthLabel.TabIndex = 2;
            this.m_MaxLengthLabel.Text = "MaxLength";
            // 
            // m_LengthLabel
            // 
            this.m_LengthLabel.AutoSize = true;
            this.m_LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_LengthLabel.Location = new System.Drawing.Point(250, 4);
            this.m_LengthLabel.Name = "m_LengthLabel";
            this.m_LengthLabel.Size = new System.Drawing.Size(45, 15);
            this.m_LengthLabel.TabIndex = 1;
            this.m_LengthLabel.Text = "Length";
            // 
            // m_TextBox
            // 
            this.m_TextBox.Enabled = false;
            this.m_TextBox.Location = new System.Drawing.Point(319, 6);
            this.m_TextBox.Multiline = true;
            this.m_TextBox.Name = "m_TextBox";
            this.m_TextBox.Size = new System.Drawing.Size(474, 57);
            this.m_TextBox.TabIndex = 0;
            this.m_TextBox.Text = "1\r\n2\r\n3\r\n4";
            this.m_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_TextBox.TextChanged += new System.EventHandler(this.m_TextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_ListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 478);
            this.panel1.TabIndex = 2;
            // 
            // m_PointerLocationLabel
            // 
            this.m_PointerLocationLabel.AutoSize = true;
            this.m_PointerLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_PointerLocationLabel.Location = new System.Drawing.Point(69, 4);
            this.m_PointerLocationLabel.Name = "m_PointerLocationLabel";
            this.m_PointerLocationLabel.Size = new System.Drawing.Size(93, 15);
            this.m_PointerLocationLabel.TabIndex = 5;
            this.m_PointerLocationLabel.Text = "PointerLocation";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_Panel);
            this.Name = "Editor";
            this.Text = "Editor";
            this.m_Panel.ResumeLayout(false);
            this.m_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView m_ListView;
        private System.Windows.Forms.ColumnHeader m_Id;
        private System.Windows.Forms.ColumnHeader m_MaxLenght;
        private System.Windows.Forms.ColumnHeader m_CurrentLength;
        private System.Windows.Forms.ColumnHeader m_Text;
        private System.Windows.Forms.ColumnHeader m_AddressInGame;
        private System.Windows.Forms.ColumnHeader m_Time;
        private System.Windows.Forms.ColumnHeader m_SwitchingTime;
        private System.Windows.Forms.Panel m_Panel;
        private System.Windows.Forms.TextBox m_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_MaxLengthLabel;
        private System.Windows.Forms.Label m_LengthLabel;
        private System.Windows.Forms.Button m_EditButton;
        private System.Windows.Forms.Label m_IdLabel;
        private System.Windows.Forms.ColumnHeader m_PointerLocation;
        private System.Windows.Forms.ColumnHeader m_AddressInFile;
        private System.Windows.Forms.Label m_PointerLocationLabel;
    }
}