using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class UjlTextPreview : Form
    {
        public UjlTextPreview(string[] text)
        {
            InitializeComponent();
            m_UjlTextPreviewRender.m_Hex = text;
        }
        public void m_ChangeId(int i)
        {
            m_UjlTextPreviewRender.m_TextIndex = i;
        }

        private void UjlTextPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_UjlTextPreviewRender.Dispose();
        }
    }
}
