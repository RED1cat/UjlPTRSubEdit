﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ujl_subedit
{
    public partial class GetFileInfo : Form
    {
        public GetFileInfo()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            addFile.file.FileInfo = fileInfoText.Text;
            this.Close();
        }
    }
}