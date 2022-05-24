using System;
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
            if(GetFile.region == true)
            {
                okButton.Enabled = false;
                button1.Enabled = true;
                fileInfoText.Text = "";
                MessageBox.Show("region");
            }
            else
            {
                okButton.Enabled = true;
                button1.Enabled = false;
                fileInfoText.Text = "";
                MessageBox.Show("file info");
            }
        }
        public class GetFile
        {
            public static bool region = false;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            addFile.file.FileInfo = fileInfoText.Text;
            this.Close();
            MessageBox.Show("region");
            fileInfoText.Text = "";
            button1.Enabled = true;
            okButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addFile.file.FileRegion = fileInfoText.Text;
            this.Close();
        }
    }
}
