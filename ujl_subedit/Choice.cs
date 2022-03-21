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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void Choice_Load(object sender, EventArgs e)
        {
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Space)
            {
                No.PerformClick();
                return true;
            }
            else if(keyData == Keys.Escape)
            {
                Stop.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            addFile.file.add = "true";
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            addFile.file.add = "false";
            this.Close();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            addFile.file.add = "stop";
            this.Close();
        }
    }
}
