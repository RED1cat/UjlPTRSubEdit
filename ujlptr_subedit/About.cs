using System.Diagnostics;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RED1cat/UjlPTRSubEdit");
        }
    }
}
