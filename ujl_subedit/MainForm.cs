using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace ujl_subedit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void m_OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Editor editor = new Editor(m_ProgressBar);
                editor.MdiParent = this;
                editor.m_FileName = Path.GetFileName(m_OpenFileDialog.FileName);
                editor.m_FilePath = m_OpenFileDialog.FileName;
                editor.m_File = File.ReadAllBytes(editor.m_FilePath);
                editor.WindowState = FormWindowState.Maximized;
                editor.Show();
                editor.m_DecodeFile();
            }
        }

        private void m_SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                m_SaveFileDialog.FileName = editor.m_FileName;
                if(m_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    editor.m_SaveInFile(m_SaveFileDialog.FileName);
                }
            }
        }

        private void m_CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void m_TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        private void m_TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }
    }
}
