﻿using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using ujlptr_subedit;

namespace ujlptr_subedit
{
    public partial class MainForm : Form
    {
        Dictionary<string, HexConverter> m_HexsConverter = new Dictionary<string, HexConverter>();
        Dictionary<string, FileDecodeOffset> m_FilesDecodeOffsets = new Dictionary<string, FileDecodeOffset>();
        public MainForm()
        {
            InitializeComponent();
            m_GetFilesForHexConverter();
            m_GetFilesForDecodeOffset();
        }
        public class FileDecodeOffset
        {
            public string m_Name { get; set; }
            public string m_Redion { get; set; }
            public int m_FirstOffset { get; set; }
            public int m_LastOffset { get; set; }

            public FileDecodeOffset(string Name,string region, int FirstOffset, int LastOffset)
            {
                m_Name = Name;
                m_Redion = region;
                m_FirstOffset = FirstOffset;
                m_LastOffset = LastOffset;
            }
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

        private void m_GetFilesForDecodeOffset()
        {
            string[] lines = null;
            foreach (string item in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory))
            {
                if(Path.GetFileName(item) == "FilesOffsetsForDecode.cfg")
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
                        return;
                    }

                    if (lines != null)
                    {
                        if (lines[lines.Length - 1] == "###" & lines[0] == "###FileName" & lines[1] == "###Region" & lines[2] == "###FirstOffset" & lines[3] == "###LastOffset")
                        {
                            m_FileDecodeOffsetToolStripComboBox.Items.Add("None");
                            string name;
                            string region;
                            int first;
                            int last;
                            for (int i = 4; i < lines.Length - 1; i += 4)
                            {
                                name = lines[i];
                                region = lines[i + 1];
                                try
                                {
                                    first = Convert.ToInt32(lines[i + 2], 16);
                                }
                                catch
                                {
                                    return;
                                }

                                try
                                {
                                    last = Convert.ToInt32(lines[i + 3], 16);
                                }
                                catch
                                {
                                    return;
                                }
                                if (!m_FilesDecodeOffsets.ContainsKey(name))
                                {
                                    m_FilesDecodeOffsets.Add(name, new FileDecodeOffset(name, region, first, last));
                                    m_FileDecodeOffsetToolStripComboBox.Items.Add($"{name} - {region}");
                                }
                            }
                        }
                    }
                }
            }
        }
        private void m_GetFilesForHexConverter()
        {
            string[] lines = null;
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
                        if (lines != null)
                        {
                            if (lines[lines.Length - 1] == "###" & lines[0] == "##-##input-output")
                            {
                                HexConverter hex = new HexConverter();
                                name = Path.GetFileNameWithoutExtension(item);
                                m_ConversionPatternToolStripComboBox.Items.Add(name);
                                foreach (string line in lines)
                                {
                                    if (line.Length == 5)
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
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.m_FileEdit)
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
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.m_FileEdit)
                    {
                        m_SaveFileDialog.FileName = editor.m_FileName;
                        if (m_SaveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            editor.m_SaveInFile(m_SaveFileDialog.FileName);
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
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    editor.m_CodePage = m_GetEncodingByName(m_TextEncodingToolStripComboBox.SelectedItem.ToString());
                    m_EncodingToolStripStatusLabel.Text = $"Encoding: {editor.m_CodePage.HeaderName}";
                    editor.m_DecodeFile();
                }
            }
        }
        private void m_ConversionPatternToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    editor.m_ConverterName = m_ConversionPatternToolStripComboBox.SelectedItem.ToString();
                    m_ConverterToolStripStatusLabel.Text = $"Converter: {editor.m_ConverterName}";

                    editor.m_EnableCheckboxesOnListView();
                    this.m_DeconvertToolStripMenuItem.Enabled = true;
                    this.m_ConvertToolStripMenuItem.Enabled = true;
                }
            }
        }
        private void m_FileOffsetToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    switch (m_FileOffsetToolStripComboBox.SelectedIndex)
                    {
                        case 0:
                            editor.m_AddressOffset = 0x1c5750; //ujl usa
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c5750";
                            break;
                        case 1:
                            editor.m_AddressOffset = 0x1c5110; //ujl jp
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c5110";
                            break;
                        case 2:
                            editor.m_AddressOffset = 0x1c4eb8; //ujl eur
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c4eb8";
                            break;
                        case 3:
                            editor.m_AddressOffset = 0x1c3870; //ptr usa
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1c3870";
                            break;
                        case 4:
                            editor.m_AddressOffset = 0x1cc21c; //ptr jp
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1cc21c";
                            break;
                        case 5:
                            editor.m_AddressOffset = 0x1c8af8; //ptr eur
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1c8af8";
                            break;
                    }
                    editor.m_DecodeFile();
                }
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
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    m_EncodingToolStripStatusLabel.Text = $"Encoding: {editor.m_CodePage.HeaderName}";
                    m_ConverterToolStripStatusLabel.Text = $"Converter: {editor.m_ConverterName}";
                    switch (editor.m_AddressOffset)
                    {
                        case 1857360:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-usa-0x1c5750";
                            m_FileOffsetToolStripComboBox.Text = "Ujl-usa-0x1c5750";
                            break;
                        case 1855760:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-jp-0x1c5110";
                            m_FileOffsetToolStripComboBox.Text = "Ujl-jp-0x1c5110";
                            break;
                        case 1855160:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ujl-eur-0x1c4eb8";
                            m_FileOffsetToolStripComboBox.Text = "Ujl-eur-0x1c4eb8";
                            break;
                        case 1849456:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-usa-0x1c3870";
                            m_FileOffsetToolStripComboBox.Text = "Ptr-usa-0x1c3870";
                            break;
                        case 1884700:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-jp-0x1cc21c";
                            m_FileOffsetToolStripComboBox.Text = "Ptr-jp-0x1cc21c";
                            break;
                        case 1870584:
                            m_OffsetToolStripStatusLabel.Text = "Offset: Ptr-eur-0x1c8af8";
                            m_FileOffsetToolStripComboBox.Text = "Ptr-eur-0x1c8af8";
                            break;
                    }

                    m_TextEncodingToolStripComboBox.Text = editor.m_CodePage.HeaderName;
                    m_ConversionPatternToolStripComboBox.Text = editor.m_ConverterName;
                    if(editor.m_ConverterName == "None")
                    {
                        m_ConvertToolStripMenuItem.Enabled = false;
                        m_DeconvertToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        m_ConvertToolStripMenuItem.Enabled = true;
                        m_DeconvertToolStripMenuItem.Enabled = true;
                    }
                }
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
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.m_ConverterName != "None")
                    {
                        editor.m_ConvertSelectedLines(m_HexsConverter[editor.m_ConverterName].m_Deconvert);
                    }
                }
            }
        }

        private void m_ConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.m_ConverterName != "None")
                    {
                        editor.m_ConvertSelectedLines(m_HexsConverter[editor.m_ConverterName].m_Convert);
                    }
                }
            }
        }

        private void m_TextPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    string[] text = new string[1] { "54-65-73-74" };
                    text = editor.m_GetAllHexText();

                    UjlTextPreview textPreview = new UjlTextPreview(text);
                    textPreview.MdiParent = this;
                    textPreview.Show();
                    textPreview.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                string[] text = new string[1] { "54-65-73-74" };
                UjlTextPreview textPreview = new UjlTextPreview(text);
                textPreview.MdiParent = this;
                textPreview.Show();
                textPreview.WindowState = FormWindowState.Normal;
            }
        }

        private void m_FileDecodeOffsetToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    FileDecodeOffset file = null;
                    if (m_FilesDecodeOffsets.TryGetValue(m_FileDecodeOffsetToolStripComboBox.SelectedItem.ToString().Split('-')[0].Replace(" ", ""), out file))
                    {
                        editor.m_DecodeFile(file.m_FirstOffset, file.m_LastOffset);
                    }
                    else if(m_FileDecodeOffsetToolStripComboBox.SelectedItem.ToString() == "None")
                    {
                        editor.m_DecodeFile();
                    }
                }
            }
        }
    }
}
