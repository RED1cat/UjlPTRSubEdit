using System;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class TextSearch : Form
    {
        private Editor Editor;
        public TextSearch(Editor editor)
        {
            InitializeComponent();
            this.Editor = editor;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (TextTextBox.Text != "")
            {
                Editor.FindText(TextTextBox.Text);
            }
        }
    }
}
