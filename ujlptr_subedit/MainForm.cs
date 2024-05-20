using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class MainForm : Form
    {
        Dictionary<string, HexConverter> HexsConverter = new Dictionary<string, HexConverter>();
        Dictionary<string, FileDecodeOffset> FilesDecodeOffsets = new Dictionary<string, FileDecodeOffset>();
        public MainForm()
        {
            InitializeComponent();
            GetFilesForHexConverter();
            GetFilesForDecodeOffset();
        }
        public class FileDecodeOffset
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public int FirstOffset { get; set; }
            public int LastOffset { get; set; }

            public FileDecodeOffset(string Name,string region, int FirstOffset, int LastOffset)
            {
                this.Name = Name;
                this.Region = region;
                this.FirstOffset = FirstOffset;
                this.LastOffset = LastOffset;
            }
        }
        private class HexConverter
        {
            public Dictionary<string, string> Convert = new Dictionary<string, string>();
            public Dictionary<string, string> Deconvert = new Dictionary<string, string>();
        }
        public static Encoding GetEncodingByName(string name)
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

        private void GetFilesForDecodeOffset()
        {
            string[] lines = null;
            string cfg = $"{AppDomain.CurrentDomain.BaseDirectory}/Content/FilesOffsetsForDecode.cfg";
            if (File.Exists(cfg))
            {
                try
                {
                    lines = File.ReadAllLines(cfg);
                }
                catch (Exception e)
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
                        FileDecodeOffsetToolStripComboBox.Items.Add("None");
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
                            if (!FilesDecodeOffsets.ContainsKey(name))
                            {
                                FilesDecodeOffsets.Add(name, new FileDecodeOffset(name, region, first, last));
                                FileDecodeOffsetToolStripComboBox.Items.Add($"{name} - {region}");
                            }
                        }
                    }
                }
            }
        }
        private void GetFilesForHexConverter()
        {
            string[] lines = null;
            string name = "";
            foreach (string item in Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}/Content"))
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
                                ConversionPatternToolStripComboBox.Items.Add(name);
                                foreach (string line in lines)
                                {
                                    if (line.Length == 5)
                                    {
                                        string a = line.Remove(2);
                                        string b = line.Remove(0, 3);
                                        if (!hex.Convert.ContainsKey(a))
                                        {
                                            hex.Convert.Add(a, b);
                                        }
                                        if (!hex.Deconvert.ContainsKey(b))
                                        {
                                            hex.Deconvert.Add(b, a);
                                        }
                                    }
                                }
                                HexsConverter.Add(name, hex);
                            }
                        }
                    }
                }
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OpenFileDialog.FileNames)
                {
                    OpenFile(file);
                }
            }
        }
        private void OpenFile(string file)
        {
            Editor editor = new Editor(ProgressBar);
            try
            {
                editor.File = File.ReadAllBytes(file);
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
            editor.FileName = Path.GetFileName(file);
            editor.Text = editor.FileName;
            editor.FilePath = file;
            editor.WindowState = FormWindowState.Maximized;
            editor.CodePage = GetEncodingByName(TextEncodingToolStripComboBox.Text);
            editor.Show();
            editor.DecodeFile();
            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.FileEdit)
                    {
                        editor.SaveInFile();
                    }
                }
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.FileEdit)
                    {
                        SaveFileDialog.FileName = editor.FileName;
                        if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            editor.SaveInFile(SaveFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void TextEncodingToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    editor.CodePage = GetEncodingByName(TextEncodingToolStripComboBox.SelectedItem.ToString());
                    EncodingToolStripStatusLabel.Text = $"Encoding: {editor.CodePage.HeaderName}";
                    editor.DecodeFile();
                }
            }
        }
        private void ConversionPatternToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    editor.ConverterName = ConversionPatternToolStripComboBox.SelectedItem.ToString();
                    ConverterToolStripStatusLabel.Text = $"Converter: {editor.ConverterName}";

                    editor.EnableCheckboxesOnListView();
                    this.DeconvertToolStripMenuItem.Enabled = true;
                    this.ConvertToolStripMenuItem.Enabled = true;
                }
            }
        }
        private void FileOffsetToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    switch (FileOffsetToolStripComboBox.SelectedIndex)
                    {
                        case 0:
                            editor.AddressOffset = 0x1c5750; //ujl usa
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c5750";
                            break;
                        case 1:
                            editor.AddressOffset = 0x1c5110; //ujl jp
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c5110";
                            break;
                        case 2:
                            editor.AddressOffset = 0x1c4eb8; //ujl eur
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-0x1c4eb8";
                            break;
                        case 3:
                            editor.AddressOffset = 0x1c3870; //ptr usa
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1c3870";
                            break;
                        case 4:
                            editor.AddressOffset = 0x1cc21c; //ptr jp
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1cc21c";
                            break;
                        case 5:
                            editor.AddressOffset = 0x1c8af8; //ptr eur
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-0x1c8af8";
                            break;
                    }
                    editor.DecodeFile();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    SaveToolStripMenuItem.Enabled = true;
                    SaveAsToolStripMenuItem.Enabled = true;
                    EncodingToolStripMenuItem.Enabled = true;
                    FileOffsetToolStripMenuItem.Enabled = true;
                    ConverterToolStripMenuItem.Enabled = true;
                    TextPreviewToolStripMenuItem.Enabled = true;
                    CascadeToolStripMenuItem.Enabled = true;
                    TileHorizontalToolStripMenuItem.Enabled = true;
                    TileVerticalToolStripMenuItem.Enabled = true;
                    SearchToolStripMenuItem.Enabled = true;
                    AdvancedModeToolStripMenuItem.Enabled = true;

                    Editor editor = ((Editor)this.ActiveMdiChild);
                    EncodingToolStripStatusLabel.Text = $"Encoding: {editor.CodePage.HeaderName}";
                    ConverterToolStripStatusLabel.Text = $"Converter: {editor.ConverterName}";
                    switch (editor.AddressOffset)
                    {
                        case 1857360:
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-usa-0x1c5750";
                            FileOffsetToolStripComboBox.Text = "Ujl-usa-0x1c5750";
                            break;
                        case 1855760:
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-jp-0x1c5110";
                            FileOffsetToolStripComboBox.Text = "Ujl-jp-0x1c5110";
                            break;
                        case 1855160:
                            OffsetToolStripStatusLabel.Text = "Offset: Ujl-eur-0x1c4eb8";
                            FileOffsetToolStripComboBox.Text = "Ujl-eur-0x1c4eb8";
                            break;
                        case 1849456:
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-usa-0x1c3870";
                            FileOffsetToolStripComboBox.Text = "Ptr-usa-0x1c3870";
                            break;
                        case 1884700:
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-jp-0x1cc21c";
                            FileOffsetToolStripComboBox.Text = "Ptr-jp-0x1cc21c";
                            break;
                        case 1870584:
                            OffsetToolStripStatusLabel.Text = "Offset: Ptr-eur-0x1c8af8";
                            FileOffsetToolStripComboBox.Text = "Ptr-eur-0x1c8af8";
                            break;
                    }

                    TextEncodingToolStripComboBox.Text = editor.CodePage.HeaderName;
                    ConversionPatternToolStripComboBox.Text = editor.ConverterName;
                    if(editor.ConverterName == "None")
                    {
                        ConvertToolStripMenuItem.Enabled = false;
                        DeconvertToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        ConvertToolStripMenuItem.Enabled = true;
                        DeconvertToolStripMenuItem.Enabled = true;
                    }
                    if (editor.AdvancedMode)
                    {
                        AdvancedModeToolStripMenuItem.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        AdvancedModeToolStripMenuItem.CheckState = CheckState.Unchecked;
                    }
                }
            }
            else
            {
                EncodingToolStripStatusLabel.Text = "Encoding";
                OffsetToolStripStatusLabel.Text = "Offset";
                ConverterToolStripStatusLabel.Text = "Converter";
                SaveToolStripMenuItem.Enabled = false;
                SaveAsToolStripMenuItem.Enabled = false;
                EncodingToolStripMenuItem.Enabled = false;
                FileOffsetToolStripMenuItem.Enabled = false;
                ConverterToolStripMenuItem.Enabled = false;
                TextPreviewToolStripMenuItem.Enabled = false;
                CascadeToolStripMenuItem.Enabled = false;
                TileHorizontalToolStripMenuItem.Enabled = false;
                TileVerticalToolStripMenuItem.Enabled = false;
                SearchToolStripMenuItem.Enabled = false;
                AdvancedModeToolStripMenuItem.Enabled = false;
                AdvancedModeToolStripMenuItem.CheckState = CheckState.Unchecked;
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
                OpenFile(file);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void DeconvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.ConverterName != "None")
                    {
                        editor.ConvertSelectedLines(HexsConverter[editor.ConverterName].Deconvert);
                    }
                }
            }
        }

        private void ConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    if (editor.ConverterName != "None")
                    {
                        editor.ConvertSelectedLines(HexsConverter[editor.ConverterName].Convert);
                    }
                }
            }
        }

        private void TextPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    editor.TextPreview = new TextPreview.TextPreview();
                    editor.TextPreview.Text = editor.FileName;
                    editor.TextPreview.MdiParent = this;
                    editor.TextPreview.Show();
                    editor.TextPreview.WindowState = FormWindowState.Normal;

                }
            }
        }

        private void FileDecodeOffsetToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);
                    FileDecodeOffset file = null;
                    if (FilesDecodeOffsets.TryGetValue(FileDecodeOffsetToolStripComboBox.SelectedItem.ToString().Split('-')[0].Replace(" ", ""), out file))
                    {
                        editor.DecodeFile(file.FirstOffset, file.LastOffset);
                    }
                    else if(FileDecodeOffsetToolStripComboBox.SelectedItem.ToString() == "None")
                    {
                        editor.DecodeFile();
                    }
                }
            }
        }

        private void AdvancedModeToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if(sender != null)
            {
                if(sender.GetType().Name == "ToolStripMenuItem")
                {
                    if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
                    {
                        if (this.ActiveMdiChild.Name == "Editor")
                        {
                            Editor editor = ((Editor)this.ActiveMdiChild);
                            editor.ChangeMode();
                        }
                    }
                }
            }

        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 & this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "Editor")
                {
                    Editor editor = ((Editor)this.ActiveMdiChild);

                    TextSearch textSearch = new TextSearch(editor);
                    textSearch.Text = editor.FileName;
                    textSearch.MdiParent = this;
                    textSearch.Show();
                    textSearch.WindowState = FormWindowState.Normal;

                }
            }
        }

        private void FontConstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextPreview.FontConstructor fontConstructor = new TextPreview.FontConstructor();
            fontConstructor.MdiParent = this;
            fontConstructor.Show();
            fontConstructor.WindowState = FormWindowState.Normal;
        }
    }
}
