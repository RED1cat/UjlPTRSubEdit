using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace ujl_subedit
{
    public partial class MainForm : Form
    {
        Dictionary<string, HexConverter> m_HexsConverter = new Dictionary<string, HexConverter>();
        public MainForm()
        {
            InitializeComponent();
            m_GetFilesForHexConverter();
        }
        private class HexConverter
        {
            public Dictionary<string, string> m_Convert = new Dictionary<string, string>();
            public Dictionary<string, string> m_Deconvert = new Dictionary<string, string>();
        }
        public static Encoding m_GetEncodingByName(string name)
        {
            switch (name)
            {
                case "Default":
                    return Encoding.Default;
                case "ASCII":
                    return Encoding.ASCII;
                case "UTF-7":
                    return Encoding.UTF7;
                case "Windows-1252":
                    return Encoding.GetEncoding(1252);
                default:
                    return Encoding.Default;
            }
        }
        private void m_GetFilesForHexConverter()
        {
            string[] lines = new string[1];
            string name = "";
            foreach (string item in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory))
            {
                if (Path.GetExtension(item) == ".cfg")
                {
                    try
                    {
                        lines = File.ReadAllLines(item);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message,
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                        continue;
                    }
                    finally 
                    {
                        HexConverter hex = new HexConverter();
                        name = Path.GetFileNameWithoutExtension(item);
                        m_ConversionPatternToolStripComboBox.Items.Add(name);
                        foreach (string line in lines)
                        {
                            if(line.Length == 5)
                            {
                                string a = line.Remove(2);
                                string b = line.Remove(0, 3);
                                if (!hex.m_Convert.ContainsKey(a))
                                {
                                    hex.m_Convert.Add(a, b);
                                }
                                if (!hex.m_Deconvert.ContainsKey(b))
                                {
                                    hex.m_Deconvert.Add(b, a);
                                }
                            }
                        }
                        m_HexsConverter.Add(name, hex);
                    }
                }
            }
        }
        private void m_OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in m_OpenFileDialog.FileNames)
                {
                    m_OpenFile(file);
                }
            }
        }
        private void m_OpenFile(string file)
        {
            Editor editor = new Editor(m_ProgressBar);
            try
            {
                editor.m_File = File.ReadAllBytes(file);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                return;
            }
            editor.MdiParent = this;
            editor.m_FileName = Path.GetFileName(file);
            editor.m_FilePath = file;
            editor.WindowState = FormWindowState.Maximized;
            editor.m_CodePage = m_GetEncodingByName(m_TextEncodingToolStripComboBox.Text);
            editor.Show();
            editor.m_DecodeFile();

        }

        private void m_SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                if (editor.m_FileEdit)
                {
                    string converter = "None";
                    if (m_ConversionPatternToolStripComboBox.SelectedItem != null)
                    {
                        converter = m_ConversionPatternToolStripComboBox.SelectedItem.ToString();
                    }
                     
                    if (converter != "None" & m_HexsConverter.ContainsKey(converter))
                    {
                        editor.m_SaveInFile(m_HexsConverter[converter].m_Convert);
                    }
                    else
                    {
                        editor.m_SaveInFile();
                    }
                }
            }
        }
        private void m_SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                if (editor.m_FileEdit)
                {
                    m_SaveFileDialog.FileName = editor.m_FileName;
                    if (m_SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string converter = m_ConversionPatternToolStripComboBox.SelectedItem.ToString();
                        if (converter != "None" & m_HexsConverter.ContainsKey(converter))
                        {
                            editor.m_SaveInFile(m_HexsConverter[converter].m_Convert, m_SaveFileDialog.FileName);
                        }
                        else
                        {
                            editor.m_SaveInFile(filePath: m_SaveFileDialog.FileName);
                        }
                    }
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

        private void m_TextEncodingToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                editor.m_CodePage = m_GetEncodingByName(m_TextEncodingToolStripComboBox.SelectedItem.ToString());
                m_EncodingToolStripStatusLabel.Text = $"Encoding: {editor.m_CodePage.HeaderName}";
                editor.m_DecodeFile();
            }
        }
        private void m_ConversionPatternToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                editor.m_ConverterName = m_ConversionPatternToolStripComboBox.SelectedItem.ToString();
                m_ConverterToolStripStatusLabel.Text = $"Converter: {editor.m_ConverterName}";
            }
        }
        private void m_FileOffsetToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                switch (m_FileOffsetToolStripComboBox.SelectedIndex)
                {
                    case 0:
                        editor.m_AddressOffset = 0x1c5750;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1c5750";
                        break;
                    case 1:
                        editor.m_AddressOffset = 0x1c5110;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1c5110";
                        break;
                    case 2:
                        editor.m_AddressOffset = 0x1c4eb8;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1c4eb8";
                        break;
                    case 3:
                        editor.m_AddressOffset = 0x1c3870;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1c3870";
                        break;
                    case 4:
                        editor.m_AddressOffset = 0x1c8af8;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1c8af8";
                        break;
                    case 5:
                        editor.m_AddressOffset = 0x1cc21c;
                        m_OffsetToolStripStatusLabel.Text = "Offset: 0x1cc21c";
                        break;
                }
                editor.m_DecodeFile();
            }
        }

        private void m_ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                m_EncodingToolStripStatusLabel.Text = $"Encoding: {editor.m_CodePage.HeaderName}";
                m_ConverterToolStripStatusLabel.Text = $"Converter: {editor.m_ConverterName}";
                m_OffsetToolStripStatusLabel.Text = $"Offset: {editor.m_AddressOffset}";

                m_TextEncodingToolStripComboBox.Text = editor.m_CodePage.HeaderName;
                m_ConversionPatternToolStripComboBox.Text = editor.m_ConverterName;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                m_OpenFile(file);
            }
        }

        private void m_AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void m_DeconvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                Editor editor = ((Editor)this.ActiveMdiChild);
                if (editor.m_ConverterName != "None")
                {
                    editor.m_DecodeLines(m_HexsConverter[editor.m_ConverterName].m_Deconvert);
                }
            }
        }
    }
}
