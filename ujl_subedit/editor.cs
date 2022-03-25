using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace ujl_subedit
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            file.filePath = null;
            createMenuStripItem();
            createContextMenuStripItem();
            createBoxAndLable();
            openFile();
            windowName();
            readFile();
            decryptRus();
        }



        class file
        {
            public static byte[] save;
            public static int subLength;
            public static string filePath = null;

            public static bool toRus = false;
        }

        //initializationWindow
        void createBoxAndLable()
        {
            length.Font = new Font(Open_File.OpenFile.DomFont.Families[1], 12);
            last.Font = new Font(Open_File.OpenFile.DomFont.Families[1], 12);

            int countSubTitle = Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/subTitle").ChildNodes.Count;

            panel.Controls.Add(length);
            panel.Controls.Add(last);
            panel.Controls.Add(ujlLogo);
            ujlLogo.SendToBack();

            downPanel.Controls.Add(saveProgress);
            saveProgress.Visible = false;

            for (int i = 1; i <= countSubTitle; i++)
            {
                //hex
                TextBox Hex = new TextBox();
                Hex.Name = "Hex" + i.ToString();
                Hex.Size = new Size(399, 60);
                Hex.Location = new Point(38, 20 + (66 * i));
                Hex.Multiline = true;
                Hex.ContextMenuStrip = HexContextMenu;
                Hex.Font = new Font("Courier New", 12);
                panel.Controls.Add(Hex);
                Hex.BringToFront();
                Hex.TextChanged += textBox_Changed;
                Hex.CharacterCasing = CharacterCasing.Upper;

                //text
                TextBox Text = new TextBox();
                Text.Name = "Text" + i.ToString();
                Text.Size = new Size(399, 60);
                Text.Location = new Point(443, 20 + (66 * i));
                Text.Multiline = true;
                Text.ContextMenuStrip = TextContextMenu;
                Text.Font = new Font("Courier New", 12);
                panel.Controls.Add(Text);
                Text.BringToFront();
                Text.TextChanged += textBox_Changed;

                //label length
                Label Length = new Label();
                Length.Name = "Length" + i.ToString();
                Length.AutoSize = true;
                Length.Location = new Point(4, 26 + (66 * i));
                Length.Font = new Font("Courier New", 12);
                Length.BackColor =  Color.FromArgb(217, 219, 214);
                Length.Visible = true;
                panel.Controls.Add(Length);
                Length.BringToFront();

                //label last
                Label Last = new Label();
                Last.Name = "Last" + i.ToString();
                Last.AutoSize = true;
                Last.Location = new Point(848, 26 + (66 * i));
                Last.Font = new Font("Courier New", 12);
                Last.BackColor = Color.FromArgb(217, 219, 214);
                Last.Visible = true;
                panel.Controls.Add(Last);
                Last.BringToFront();

                //label number line
                Label n = new Label();
                n.Name = "n" + i.ToString();
                n.AutoSize = true;
                n.Location = new Point(12, 44 + (66 * i));
                n.Font = new Font(Open_File.OpenFile.DomFont.Families[1], 12);
                n.BackColor = Color.FromArgb(217, 219, 214);
                n.Visible = true;
                n.Text = i.ToString();
                panel.Controls.Add(n);
                n.BringToFront();
            }
        }
        void windowName()
        {
            if(Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/fileInfo") != null)
            {
                this.Text = Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/fileInfo").InnerText;
            }
            else
            {
                this.Text = "Editor";
            }
        }
        void openFile()
        {
            try
            {
                using (FileStream fstream = File.OpenRead(Open_File.OpenFile.FilePath))
                {
                    //file2byte
                    byte[] bitarray = new byte[fstream.Length];
                    fstream.Read(bitarray, 0, bitarray.Length);
                    file.save = bitarray;
                    fstream.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        void decryptRus()
        {
            if (Open_File.OpenFile.Decryptrus == true)
            {
                foreach(Control ctr in panel.Controls)
                {
                    var da = ctr.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                    if (new string(da) == "Hex")
                    {
                        ctr.Text = Open_File.OpenFile.Decrypt(ctr.Text);
                        foreach(Control ctr2 in panel.Controls)
                        {
                            var da2 = ctr2.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                            if(new string(da2) == "Text")
                            {
                                if(ctr.Name.Replace("Hex", "") == ctr2.Name.Replace("Text", ""))
                                {
                                    ctr2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(ctr.Text));
                                }
                            }
                        }
                    }
                }
            }
        }
        void readFile()
        {
            XmlElement xRoot = Open_File.OpenFile.xDoc.DocumentElement;

            file.subLength = Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='"+Open_File.OpenFile.FileName+"']/subTitle").ChildNodes.Count;
            int address;
            int length;
            for (int i = 1; i <= file.subLength; i++)
            {
                address = Int32.Parse(Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/subTitle/sub[" + i + "]/address").InnerText);
                length = Int32.Parse(Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/subTitle/sub[" + i + "]/length").InnerText);
                foreach(Control hex in panel.Controls)
                {
                    if (hex.Name.Replace("Hex", "") == i.ToString())
                    {
                        TextBox Hex = (TextBox)panel.Controls[panel.Controls.IndexOf(hex)];
                        Hex.Visible = true;
                        Hex.MaxLength = length * 2 + (length - 1);
                        if (Open_File.OpenFile.SymbolConverter == true)
                        {
                            Hex.Text = BitConverter.ToString(file.save, address, length).Replace("00", "2F").Replace("0A", "23");
                        }
                        else
                        {
                            Hex.Text = BitConverter.ToString(file.save, address, length);
                        }
                        
                        foreach (Control text in panel.Controls)
                        {
                            if (text.Name.Replace("Text", "") == i.ToString())
                            {
                                TextBox Text = (TextBox)panel.Controls[panel.Controls.IndexOf(text)];
                                Text.Visible = true;
                                Text.MaxLength = length;
                                Text.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex.Text));

                                foreach(Control lableLength in panel.Controls)
                                {
                                    if(lableLength.Name.Replace("Length", "") == i.ToString())
                                    {
                                        lableLength.Text = text.Text.Length.ToString();
                                        lableLength.Visible = true;

                                        foreach(Control lableLast in panel.Controls)
                                        {
                                            if(lableLast.Name.Replace("Last", "") == i.ToString())
                                            {
                                                lableLast.Text = (length - Int32.Parse(lableLength.Text)).ToString();
                                                lableLast.Visible = true;
                                            }
                                            if(lableLast.Name.Replace("n", "") == i.ToString())
                                            {
                                                lableLast.Visible = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        //saveFile
        void saveFileDialog(string parametеr)
        {
            if (file.toRus == true)
            {
                Open_File.OpenFile.Torus = true;
            }
            else
            {
                Open_File.OpenFile.Torus = false;
            }
            
            if (parametеr == "Save As")
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = Open_File.OpenFile.FileName;
                saveFileDialog1.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu File (*.MEN)|*.MEN|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = saveFileDialog1.OpenFile()) != null)
                        {
                            file.filePath = saveFileDialog1.FileName;
                            saveFunction();
                            myStream.Write(file.save, 0, file.save.Length);
                            myStream.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: this file is busy. {ex.Message}");
                    }
                }
            }
            else if(parametеr == "Save")
            {
                Stream myStream;
                myStream = File.Open(file.filePath, FileMode.Create);
                saveFunction();
                myStream.Write(file.save, 0, file.save.Length);
                myStream.Close();
            }
            this.Text = this.Text.Replace(" *", "");
            saveProgress.Visible = false;
        }
        void saveFunction()
        {
            saveProgress.Maximum = file.subLength;
            saveProgress.Visible = true;
            XmlElement xRoot = Open_File.OpenFile.xDoc.DocumentElement;
            int address;
            int length;
            string name;
            int id;
            for (int i = 0; i < file.subLength; i++)
            {
                //saveProgress.Value = i+1;
                saveProgress.PerformStep();
                foreach (Control ctr in panel.Controls)
                {
                    name = new string(ctr.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                    if (name == "Hex" && ctr.Visible == true)
                    {
                        id = Int32.Parse(ctr.Name.Replace("Hex", ""));
                        address = Int32.Parse(Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/subTitle/sub[" + id.ToString() + "]/address").InnerText);
                        length = Int32.Parse(Open_File.OpenFile.xDoc.SelectSingleNode("/subtitle/file[@name='" + Open_File.OpenFile.FileName + "']/subTitle/sub[" + id.ToString() + "]/length").InnerText);
                        if (Open_File.OpenFile.SymbolConverter == true)
                        {
                            Array.Copy(Open_File.OpenFile.hex2byte2save(ctr.Text.Replace("23", "0A").Replace("2F", "00"), length), 0, file.save, address, length);
                        }
                        else
                        {
                            Array.Copy(Open_File.OpenFile.hex2byte2save(ctr.Text, length), 0, file.save, address, length);
                        }
                    }
                }
            }
        }
        
        //menuStrip
        private void createMenuStripItem()
        {
            
            //fileItem
            ToolStripMenuItem fileItem = new ToolStripMenuItem("File");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            saveItem.Click += saveItem_Click;
            saveItem.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem saveAsItem = new ToolStripMenuItem("Save As");
            saveAsItem.Click += saveItem_Click;
            saveAsItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItem closeItem = new ToolStripMenuItem("Close");
            closeItem.Click += closeItem_Click;
            fileItem.DropDownItems.Add(saveItem);
            fileItem.DropDownItems.Add(saveAsItem);
            fileItem.DropDownItems.Add(closeItem);
            menuStrip1.Items.Add(fileItem);

            //optionItem
            ToolStripMenuItem optionItem = new ToolStripMenuItem("Option");
            if(Open_File.OpenFile.debug == true)
            {
                ToolStripMenuItem toRusItem = new ToolStripMenuItem("To rus") { Checked = false, CheckOnClick = true };
                toRusItem.Click += toRusItem_Click;
                optionItem.DropDownItems.Add(toRusItem);

                ToolStripMenuItem sharping = new ToolStripMenuItem("sharping");
                sharping.Click += sharping_Click;
                optionItem.DropDownItems.Add(sharping);
            }
            else
            {
                ToolStripMenuItem noOption = new ToolStripMenuItem("There no option");
                optionItem.DropDownItems.Add(noOption);
            }
            menuStrip1.Items.Add(optionItem);
        }
        private void saveItem_Click(object sender, EventArgs e)
        {
            if(sender.ToString() == "Save" && file.filePath == null) //saveAs
            {
                saveFileDialog("Save As");
            }
            else if(sender.ToString() == "Save" && file.filePath != null) //save
            {
                saveFileDialog("Save");
            }
            else if(sender.ToString() == "Save As") //saveAs
            {
                saveFileDialog("Save As");
            }
        }
        private void toRusItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem.CheckState == CheckState.Checked)
                file.toRus = true;
            else if (menuItem.CheckState == CheckState.Unchecked)
                file.toRus = false;
        }
        private void closeItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sharping_Click(object sender, EventArgs e)
        {
            foreach(Control hex in panel.Controls)
            {
                string nameHex = new string(hex.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                if (nameHex == "Hex")
                {
                    foreach(Control text in panel.Controls)
                    {
                        string nameText = new string(hex.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                        if(hex.Name.Replace("Hex", "") == text.Name.Replace("Text", ""))
                        {
                            TextBox textBox = (TextBox)text;
                            TextBox hexbox = (TextBox)hex;
                            int countText = textBox.MaxLength;
                            textBox.Text = "";
                            hex.Text = "";
                            for (int i = 1; i <= countText; i++)
                            {
                                textBox.Paste("#");
                                hexbox.Paste("23");
                                hexbox.Paste("-");
                            }
                        }
                    }
                }
            }
        }

        //contextMenuStrip
        private int GetIndexFocusedControl()
        {
            foreach (Control ctr in panel.Controls)
            {
                if (ctr.Focused)
                {
                    return panel.Controls.IndexOf(ctr);
                }
            }
            return -1;
        }
        private void createContextMenuStripItem()
        {
            //copy paste
            ToolStripMenuItem hexTextCopy = new ToolStripMenuItem("Copy");
            hexTextCopy.Click += textCopy_Click;
            ToolStripMenuItem hexTextPaste = new ToolStripMenuItem("Paste");
            hexTextPaste.Click += textPaste_Click;

            ToolStripMenuItem textTextCopy = new ToolStripMenuItem("Copy");
            textTextCopy.Click += textCopy_Click;
            ToolStripMenuItem textTextPaste = new ToolStripMenuItem("Paste");
            textTextPaste.Click += textPaste_Click;

            //hex
            ToolStripMenuItem sharpToLineBreak = new ToolStripMenuItem("23 to 0A");
            sharpToLineBreak.Click += sharpToLineBreak_Click;
            HexContextMenu.Items.Add(sharpToLineBreak);
            HexContextMenu.Items.Add(hexTextCopy);
            HexContextMenu.Items.Add(hexTextPaste);

            //text
            TextContextMenu.Items.Add(textTextCopy);
            TextContextMenu.Items.Add(textTextPaste);
        }
        private void sharpToLineBreak_Click(object sender, EventArgs e)
        {
            int indexFocused = GetIndexFocusedControl();
            if (indexFocused == -1)
            {
                return;
            }
            panel.Controls[indexFocused].Text = panel.Controls[indexFocused].Text.Replace("23", "0A");
            TextBox VotOn = (TextBox)panel.Controls[indexFocused];
            VotOn.Modified = true;
        }
        private void textCopy_Click(object sender, EventArgs e)
        {
            int indexFocused = GetIndexFocusedControl();
            if(indexFocused == -1)
            {
                return;
            }
            TextBox VotOn = (TextBox)panel.Controls[indexFocused];
            if(VotOn.SelectedText != "")
            {
                Clipboard.SetText(VotOn.SelectedText);
            }
        }
        private void textPaste_Click(object sender, EventArgs e)
        {
            int indexFocused = GetIndexFocusedControl();
            if(indexFocused == -1)
            {
                return;
            }
            TextBox VotOn = (TextBox)panel.Controls[indexFocused];
            VotOn.Paste(Clipboard.GetText());
        }

        //updataTextbox
        private void textBox_Changed(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Focused == true)
            {
                if(this.Text.Replace(" *", "") == this.Text)
                {
                    this.Text = this.Text + " *";
                }     
                string boxName = new string(box.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                if(boxName == "Hex")
                {
                    foreach (Control text in panel.Controls)
                    { 
                        if (text.Name.Replace("Text", "") == box.Name.Replace("Hex", ""))
                        {
                            TextBox box2 = (TextBox)panel.Controls[panel.Controls.IndexOf(text)];
                            box2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(box.Text));

                            foreach (Control lableLength in panel.Controls)
                            {
                                if (lableLength.Name.Replace("Length", "") == box.Name.Replace("Hex", ""))
                                {
                                    lableLength.Text = text.Text.Length.ToString();

                                    foreach (Control lableLast in panel.Controls)
                                    {
                                        if (lableLast.Name.Replace("Last", "") == box.Name.Replace("Hex", ""))
                                        {
                                            lableLast.Text = (box2.MaxLength - Int32.Parse(lableLength.Text)).ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if(boxName == "Text")
                {
                    foreach (Control hex in panel.Controls)
                    {
                        if (hex.Name.Replace("Hex", "") == box.Name.Replace("Text", ""))
                        {
                            hex.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(box.Text));
                            foreach (Control lableLength in panel.Controls)
                            {
                                if (lableLength.Name.Replace("Length", "") == hex.Name.Replace("Hex", ""))
                                {
                                    lableLength.Text = box.Text.Length.ToString();

                                    foreach (Control lableLast in panel.Controls)
                                    {
                                        if (lableLast.Name.Replace("Last", "") == hex.Name.Replace("Hex", ""))
                                        {
                                            lableLast.Text = (box.MaxLength - Int32.Parse(lableLength.Text)).ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
