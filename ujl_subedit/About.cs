using System;
using System.Drawing;
using System.Windows.Forms;

namespace ujl_subedit
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            fontInit();
        }

        private void fontInit()
        {
            text.Font = new Font(Editor.m_DomFont.Families[1], 14);
        }

        private void git_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RED1cat/UjlSubEdit");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
