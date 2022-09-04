using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;


namespace ujl_subedit
{
    public partial class Editor : Form
    {
        Dictionary<string, FileInfo> m_FileInfo = new Dictionary<string, FileInfo>();
        public static string m_TempFile = Path.GetTempPath() + "UJL_SubEdit";
        public static bool m_SymbolConverter = false;
        public static bool m_ToRus = false;
        public static bool m_ToRus2 = false;
        public static Encoding m_CodePage = Encoding.Default; //UTF-7 65000 1252 Encoding.GetEncoding(1252)
        private static string m_XmlDocPath = "subtitle.xml"; //C:\\Users\\wwwsa\\source\\repos\\ujl_subedit\\ujl_subedit\\bin\\subtitle.xml
        public static XmlDocument m_XDocUjlUsa = new XmlDocument().LoadXmlDoc(Encoding.UTF8.GetString(Convert.FromBase64String(Base64File.base64_XmlUjlUsa)));
        public static XmlDocument m_XDocUjlEurope = new XmlDocument();//.OpenXmlDoc(m_XmlDocPath);
        public static PrivateFontCollection m_DomFont = new PrivateFontCollection().LoadFontFromBase64(Base64File.base64_DomBold, "domBold.ttf").LoadFontFromBase64(Base64File.base64_DomCasual, "domCasual.ttf");

        public Editor()
        {
            InitializeComponent();
        }


        //get vocused item
        private TabPage GetTabVocus(bool getTabInTab = false)
        {
            foreach (Control tab in tabControl1.Controls)
            {
                if (tab.CanFocus && tab is TabPage)
                {
                    if(getTabInTab == true)
                    {
                        foreach (Control tab1 in tab.Controls)
                        {
                            if (tab1 is TabControl)
                            {
                                foreach (Control tab2 in tab1.Controls)
                                {
                                    if (tab2.CanFocus && tab2 is TabPage)
                                    {
                                        TabPage Tab1 = (TabPage)tab2;
                                        return Tab1;
                                    }
                                }
                            }
                        }
                    }
                    TabPage Tab = (TabPage)tab;
                    return Tab;
                }
            }
            return null;
        }
        private TextBox GetTextBoxVocus()
        {
            if (GetTabVocus(true) != null)
            {
                TabPage Tab = GetTabVocus(true);

                foreach (Control textBox in Tab.Controls)
                {
                    if (textBox.Focused)
                    {
                        TextBox box = (TextBox)textBox; 
                        return box;
                    }
                }
                return null;
            }
            return null;
        }

        //initializationWindow
        private void CreateBoxAndLable(string fileName, string fileKey, string region)
        {
            TabPage Tab = new TabPage().CreateTabPage(fileKey, fileName: fileName, region: region);
            tabControl1.TabPages.Add(Tab);


            if (region == "europe")
            {
                TabControl eurTabControl = new TabControl();
                eurTabControl.Dock = DockStyle.Fill;
                Tab.Controls.Add(eurTabControl);

                TabPage Tab1 = new TabPage().CreateTabPage(fileKey + 1.ToString(), "English");
                CreatLogoAndLabel(Tab1, region);
                eurTabControl.TabPages.Add(Tab1);

                TabPage Tab2 = new TabPage().CreateTabPage(fileKey + 2.ToString(), "German");
                CreatLogoAndLabel(Tab2, region);
                eurTabControl.TabPages.Add(Tab2);

                TabPage Tab3 = new TabPage().CreateTabPage(fileKey + 3.ToString(), "French");
                CreatLogoAndLabel(Tab3, region);
                eurTabControl.TabPages.Add(Tab3);

                TabPage Tab4 = new TabPage().CreateTabPage(fileKey + 4.ToString(), "Italian");
                CreatLogoAndLabel(Tab4, region);
                eurTabControl.TabPages.Add(Tab4);

                TabPage Tab5 = new TabPage().CreateTabPage(fileKey + 5.ToString(), "Spanish");
                CreatLogoAndLabel(Tab5, region);
                eurTabControl.TabPages.Add(Tab5);


                saveProgress.Visible = true;
                saveProgress.Value = 0;
                saveProgress.Maximum = m_FileInfo[fileKey].FileSubLengthEuropeAll;

                int index = 0;
                foreach (Control _tab in eurTabControl.Controls)
                {
                    TabPage tab = (TabPage)_tab;
                    CreatLineOnTab(tab, m_FileInfo[fileKey].FileSubLengthEurope[index]);
                    index++;
                }

                ReadFile(fileName, fileKey, region, m_FileInfo[fileKey].FileSubLengthEuropeAll, Tab, eurTabControl);
                return;
            }
            else if(region == "usa")
            {
                CreatLogoAndLabel(Tab, region);

                //progressbar
                saveProgress.Visible = true;
                saveProgress.Value = 0;
                saveProgress.Maximum = m_FileInfo[fileKey].FileSubLengthUsa * 2;
                for (int i = 1; i <= m_FileInfo[fileKey].FileSubLengthUsa; i++)
                {
                    CreatLine(Tab, i);
                    saveProgress.PerformStep();
                }
                ReadFile(fileName, fileKey, region, m_FileInfo[fileKey].FileSubLengthUsa, Tab);
            }
        }
        private void CreatLineOnTab(TabPage tab, int length)
        {
            for (int i = 1; i <= length; i++)
            {
                CreatLine(tab, i);
                saveProgress.PerformStep();
            }
        }
        private void CreatLine(TabPage Tab, int i)
        {
            //hex
            TextBox Hex = new TextBox();
            Hex.Name = "Hex" + i.ToString();
            Hex.Size = new Size(399, 60);
            Hex.Location = new Point(38, 20 + (66 * i));
            Hex.Multiline = true;
            Hex.ContextMenuStrip = HexContextMenu;
            Hex.Font = new Font("Courier New", 12);
            Tab.Controls.Add(Hex);
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
            Tab.Controls.Add(Text);
            Text.BringToFront();
            Text.TextChanged += textBox_Changed;

            //label length
            Label Length = new Label();
            Length.Name = "Length" + i.ToString();
            Length.AutoSize = true;
            Length.Location = new Point(4, 26 + (66 * i));
            Length.Font = new Font("Courier New", 12);
            Length.BackColor = Color.FromArgb(217, 219, 214);
            Length.Visible = true;
            Tab.Controls.Add(Length);
            Length.BringToFront();

            //label last
            Label Last = new Label();
            Last.Name = "Last" + i.ToString();
            Last.AutoSize = true;
            Last.Location = new Point(848, 26 + (66 * i));
            Last.Font = new Font("Courier New", 12);
            Last.BackColor = Color.FromArgb(217, 219, 214);
            Last.Visible = true;
            Tab.Controls.Add(Last);
            Last.BringToFront();

            //label number line
            Label n = new Label();
            n.Name = "n" + i.ToString();
            n.AutoSize = true;
            n.Location = new Point(12, 44 + (66 * i));
            n.Font = new Font(m_DomFont.Families[1], 12);
            n.BackColor = Color.FromArgb(217, 219, 214);
            n.Visible = true;
            n.Text = i.ToString();
            Tab.Controls.Add(n);
            n.BringToFront();
        }
        private void CreatLogoAndLabel(TabPage Tab, string region)
        {
            Label last = new Label();
            last.Font = new Font(m_DomFont.Families[1], 12);
            last.Text = "Left";
            last.Location = new Point(837, 63);
            last.Size = new Size(28, 20);
            Tab.Controls.Add(last);


            Label length = new Label();
            length.Font = new Font(m_DomFont.Families[1], 12);
            length.Text = "Length  and №";
            length.Location = new Point(3, 63);
            length.Size = new Size(83, 20);
            Tab.Controls.Add(length);


            PictureBox ujlLogo = new PictureBox();
            if(region == "usa" || region == "europe")
            {
                ujlLogo.Image = Base64File.base64_UjlUsaLogo.LoadImageFromBase64();
            }
            ujlLogo.Location = new Point(-1, -20);
            ujlLogo.Size = new Size(878, 190);
            Tab.Controls.Add(ujlLogo);
        }
        private void OpenFile(string filePath, string fileName)
        {
            string region = choiceRegion();

            if(region == null)
            {
                return;
            }

            if(checkingFileCompatibility(fileName, region) == false)
            {
                MessageBox.Show(
                    "File is not supported",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }


            string fileKey;
            try
            {
                using (FileStream fstream = System.IO.File.OpenRead(filePath))
                {
                    //file2byte
                    byte[] bitarray = new byte[fstream.Length];
                    fstream.Read(bitarray, 0, bitarray.Length);

                    fileKey = "Tab" + (tabControl1.TabPages.Count + 1).ToString() + "-" + fileName + "-" + region;

                    m_FileInfo.Add(fileKey, new FileInfo(name: fileName, region: region));
                    m_FileInfo[fileKey].FileBytes = bitarray;
                    fstream.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
            CreateBoxAndLable(fileName, fileKey, region);
        }
        private void ReadFile(string fileName, string fileKey, string region, int subLength, TabPage tab, TabControl tabControl = null)
        {
            
            if(region == "europe")
            {
                int index = 1;
                int addressEur;
                int lengthEur;
                foreach (int subId in m_FileInfo[fileKey].FileSubLengthEurope)
                {
                    for (int i = 1; i <= subId; i++)
                    {
                        addressEur = Int32.Parse(m_XDocUjlEurope.GetXmlNode(fileName, region, "GetaddressNodeEur", i, index).InnerText);
                        lengthEur = Int32.Parse(m_XDocUjlEurope.GetXmlNode(fileName, region, "GetlengthNodeEur", i, index).InnerText);

                        TextBox hex = (TextBox)tabControl.TabPages[index - 1].GetTextBoxById(i, "Hex");
                        hex.MaxLength = lengthEur * 2 + (lengthEur - 1);

                        if (m_SymbolConverter == true)
                        {
                            hex.Text = BitConverter.ToString(m_FileInfo[fileKey].FileBytes, addressEur, lengthEur).Replace("00", "2F").Replace("0A", "23");
                        }
                        else
                        {
                            hex.Text = BitConverter.ToString(m_FileInfo[fileKey].FileBytes, addressEur, lengthEur);
                        }

                        TextBox text = (TextBox)tabControl.TabPages[index - 1].GetTextBoxById(i, "Text");
                        text.MaxLength = lengthEur;
                        text.Text = m_CodePage.GetString(hex.Text.Hex2byte());

                        Label lableLength = (Label)tabControl.TabPages[index - 1].GetLabelById(i, "Length");
                        lableLength.Text = text.Text.Length.ToString();

                        Label lableLast = (Label)tabControl.TabPages[index - 1].GetLabelById(i, "Last");
                        lableLast.Text = (lengthEur - Int32.Parse(lableLength.Text)).ToString();

                        saveProgress.PerformStep();
                    }
                    index++;
                }
                saveProgress.Value = 0;
                saveProgress.Visible = false;

            }
            else if(region == "usa")
            {
                int address;
                int length;

                for (int i = 1; i <= subLength; i++)
                {
                    address = Int32.Parse(m_XDocUjlUsa.GetXmlNode(fileName, region, "GetaddressNodeUsa", i).InnerText);
                    length = Int32.Parse(m_XDocUjlUsa.GetXmlNode(fileName, region, "GetlengthNodeUsa", i).InnerText);

                    TextBox hex = (TextBox)tab.GetTextBoxById(i, "Hex");
                    hex.MaxLength = length * 2 + (length - 1);
                    if (m_SymbolConverter == true)
                    {
                        hex.Text = BitConverter.ToString(m_FileInfo[fileKey].FileBytes, address, length).Replace("00", "2F").Replace("0A", "23");
                    }
                    else
                    {
                        hex.Text = BitConverter.ToString(m_FileInfo[fileKey].FileBytes, address, length);
                    }

                    TextBox text = (TextBox)tab.GetTextBoxById(i, "Text");
                    text.MaxLength = length;
                    text.Text = m_CodePage.GetString(hex.Text.Hex2byte());

                    Label lableLength = (Label)tab.GetLabelById(i, "Length");
                    lableLength.Text = text.Text.Length.ToString();

                    Label lableLast = (Label)tab.GetLabelById(i, "Last");
                    lableLast.Text = (length - Int32.Parse(lableLength.Text)).ToString();
                    saveProgress.PerformStep();
                }
                saveProgress.Value = 0;
                saveProgress.Visible = false;
            }
        }
        private bool checkingFileCompatibility(string fileName, string region)
        {
            if ((m_XDocUjlUsa.GetXmlNode(fileName, region, "GetsubTitleNode") == null && region == "usa") || (m_XDocUjlEurope.GetXmlNode(fileName, region, "GetsubTitleNode") == null && region == "europe"))
            {

                return false;
            }
            return true;
        }
        private string choiceRegion()
        {
#if DEBUG
            DialogResult result = MessageBox.Show(
                "select the file region:\n'Yes' - is Usa region,\n'No' - is Europe region",
                "Region",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return "usa";
            else if (result == DialogResult.No)
                return "europe";
            else if (result == DialogResult.Cancel)
                return null;

            return null;
#else
            return "usa";
#endif
        }

        //saveFile
        private void SaveFileDialog(string parametеr)
        {
            
            TabPage Tab = GetTabVocus();

            string fileName = Tab.Text.Split('-')[0].Replace(" ", "");

            string region = Tab.Text.Split('-')[3].Replace(" ", "").Replace("*", "");

            string fileKey = Tab.Name;

            if (parametеr == "Save as")
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu File (*.MEN)|*.MEN|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = saveFileDialog1.OpenFile()) != null)
                        {
                            string filePath = saveFileDialog1.FileName;

                            if(m_FileInfo[fileKey].FilePathToSave != null)
                            {
                                m_FileInfo[fileKey].FilePathToSave = filePath;
                            }
                            else
                            {
                                m_FileInfo[fileKey].FilePathToSave = filePath;
                            }

                            SaveFunction(fileKey, fileName, region, Tab);
                            myStream.Write(m_FileInfo[fileKey].FileBytes, 0, m_FileInfo[fileKey].FileBytes.Length);
                            myStream.Close();

                            //Tab.Text = Tab.Text.Replace(" *", "");
                            //foreach(Control tabControl in Tab.Controls)
                            //{
                            //    if(tabControl is TabControl)
                            //    {
                            //        foreach (Control tab in tabControl.Controls)
                            //        {
                            //            if(tab is TabPage)
                            //            {
                            //                tab.Text = tab.Text.Replace(" *", "");
                            //            }
                            //        }
                            //    }
                            //}
                            FileHasEdit(false);

                            saveProgress.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: this file is busy. {ex.Message}");
                    }
                }
            }
            else if (parametеr == "Save")
            {
                try
                {
                    Stream myStream;
                    myStream = System.IO.File.Open(m_FileInfo[fileKey].FilePathToSave, FileMode.Create);
                    SaveFunction(fileKey, fileName, region, Tab);
                    myStream.Write(m_FileInfo[fileKey].FileBytes, 0, m_FileInfo[fileKey].FileBytes.Length);
                    myStream.Close();

                    Tab.Text = Tab.Text.Replace(" *", "");
                    foreach (Control tabControl in Tab.Controls)
                    {
                        if (tabControl is TabControl)
                        {
                            foreach (Control tab in tabControl.Controls)
                            {
                                if (tab is TabPage)
                                {
                                    tab.Text = tab.Text.Replace(" *", "");
                                }
                            }
                        }
                    }

                    saveProgress.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: this file is busy. {ex.Message}");
                }
            }
        }
        private void SaveFunction(string fileKey, string fileName, string region, TabPage tab)
        {
            if(region == "europe")
            {
                TabControl tabControlEur = null;
                foreach(Control tabControl in tab.Controls)
                {
                    if(tabControl is TabControl)
                    {
                        TabControl _tabControlEur = (TabControl)tabControl;
                        tabControlEur = _tabControlEur;
                    }
                }

                int addressEur;
                int lengthEur;
                for (int tabId = 1; tabId <= 5; tabId++)
                {
                    TabPage tabEur = tabControlEur.TabPages[tabId - 1]; 
                    for (int subId = 1; subId <= m_FileInfo[fileKey].FileSubLengthEurope[tabId - 1]; subId++)
                    {
                        addressEur = Int32.Parse(m_XDocUjlEurope.GetXmlNode(fileName, region, "GetaddressNodeEur", subId, tabId).InnerText);
                        lengthEur = Int32.Parse(m_XDocUjlEurope.GetXmlNode(fileName, region, "GetlengthNodeEur", subId, tabId).InnerText);


                        if (m_SymbolConverter == true)
                        {
                            Array.Copy(tabEur.GetTextBoxById(subId, "Hex").Text.Replace("23", "0A").Replace("2F", "00").Hex2byte(m_ToRus, lengthEur), 0, m_FileInfo[fileKey].FileBytes, addressEur, lengthEur);
                        }
                        else
                        {
                            Array.Copy(tabEur.GetTextBoxById(subId, "Hex").Text.Hex2byte(m_ToRus, lengthEur), 0, m_FileInfo[fileKey].FileBytes, addressEur, lengthEur);
                        }
                        saveProgress.PerformStep();
                    }
                }

                MessageBox.Show(
                    "Save Complete",
                    "Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;

            }
            else if(region == "usa")
            {
                //int subLength = File.xDoc.GetXmlNode(fileName, region, "GetsubTitleNode").ChildNodes.Count;
                saveProgress.Maximum = m_FileInfo[fileKey].FileSubLengthUsa;
                saveProgress.Visible = true;
                int address;
                int length;
                string name;
                int id;
                for (int i = 1; i <= m_FileInfo[fileKey].FileSubLengthUsa; i++)
                {
                    foreach (Control ctr in tab.Controls)
                    {
                        name = new string(ctr.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                        if (name == "Hex" && ctr.Visible == true)
                        {
                            id = Int32.Parse(ctr.Name.Replace("Hex", ""));
                            address = Int32.Parse(m_XDocUjlUsa.GetXmlNode(fileName, region, "GetaddressNodeUsa", id).InnerText);
                            length = Int32.Parse(m_XDocUjlUsa.GetXmlNode(fileName, region, "GetlengthNodeUsa", id).InnerText);
                            if (m_SymbolConverter == true)
                            {
                                Array.Copy(ctr.Text.Replace("23", "0A").Replace("2F", "00").Hex2byte(m_ToRus, length), 0, m_FileInfo[fileKey].FileBytes, address, length);
                            }
                            else
                            {
                                Array.Copy(ctr.Text.Hex2byte(m_ToRus, length), 0, m_FileInfo[fileKey].FileBytes, address, length);
                            }
                        }
                    }
                    saveProgress.PerformStep();
                }
                MessageBox.Show(
                    "Save Complete",
                    "Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //menuStrip
        private void CreateMenuStripItem()
        {
            
            //fileItem
            ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");

            ToolStripMenuItem openFile = new ToolStripMenuItem("Open file");
            openFile.Click += openFile_Click;
            openFile.ShortcutKeys = Keys.Control | Keys.O;
            openFileDialog1.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu File (*.MEN)|*.MEN|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            fileItem.DropDownItems.Add(openFile);

            ToolStripSeparator separator1 = new ToolStripSeparator();
            fileItem.DropDownItems.Add(separator1);

            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            saveItem.Click += saveItem_Click;
            saveItem.ShortcutKeys = Keys.Control | Keys.S;
            fileItem.DropDownItems.Add(saveItem);

            ToolStripMenuItem saveAsItem = new ToolStripMenuItem("Save as");
            saveAsItem.Click += saveItem_Click;
            saveAsItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            fileItem.DropDownItems.Add(saveAsItem);

            ToolStripSeparator separator2 = new ToolStripSeparator();
            fileItem.DropDownItems.Add(separator2);

            ToolStripMenuItem closeItem = new ToolStripMenuItem("Close file");
            closeItem.Click += closeItem_Click;
            closeItem.ShortcutKeys = Keys.Control | Keys.F4;
            fileItem.DropDownItems.Add(closeItem);

            ToolStripMenuItem closeAllItem = new ToolStripMenuItem("Close all files");
            closeAllItem.Click += closeItem_Click;
            closeAllItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F4;
            fileItem.DropDownItems.Add(closeAllItem);

            ToolStripSeparator separator3 = new ToolStripSeparator();
            fileItem.DropDownItems.Add(separator3);

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += exitItem_Click;
            exitItem.ShortcutKeys = Keys.Alt | Keys.F4;
            fileItem.DropDownItems.Add(exitItem);

            ToolStripMenuItem about = new ToolStripMenuItem("&About");
            about.Click += about_Click;

            
            //optionItem
            ToolStripMenuItem optionItem = new ToolStripMenuItem("&Options");
#if DEBUG
            ToolStripMenuItem addFile = new ToolStripMenuItem("Add file");
            addFile.Click += addFile_Click;
            optionItem.DropDownItems.Add(addFile);

            ToolStripMenuItem decryptRus = new ToolStripMenuItem("Decrypt rus");
            decryptRus.Click += decryptRus_Click;
            optionItem.DropDownItems.Add(decryptRus);

            ToolStripMenuItem toRusItem = new ToolStripMenuItem("To rus") { Checked = false, CheckOnClick = true };
            toRusItem.Click += toRusItem_Click;
            optionItem.DropDownItems.Add(toRusItem);

            ToolStripMenuItem toRusItem2 = new ToolStripMenuItem("To rus2") { Checked = false, CheckOnClick = true };
            toRusItem2.Click += toRusItem2_Click;
            optionItem.DropDownItems.Add(toRusItem2);

            ToolStripMenuItem sharping = new ToolStripMenuItem("Sharping");
            sharping.Click += sharping_Click;
            optionItem.DropDownItems.Add(sharping);

            ToolStripMenuItem symbolConverter = new ToolStripMenuItem("Symbol converter") { Checked = false, CheckOnClick = true };
            symbolConverter.Click += symbolConverter_Click;
            optionItem.DropDownItems.Add(symbolConverter);

            ToolStripTextBox codePage = new ToolStripTextBox();
            menuStrip1.Items.Add(codePage);
            codePage.TextChanged += codePage_Changed;


#else

            ToolStripMenuItem symbolConverter = new ToolStripMenuItem("Symbol converter") { Checked = false, CheckOnClick = true };
            symbolConverter.Click += symbolConverter_Click;
            optionItem.DropDownItems.Add(symbolConverter);
#endif



            menuStrip1.Items.Add(fileItem);
            menuStrip1.Items.Add(optionItem);
            menuStrip1.Items.Add(about);
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath;
                string fileName;
                try
                {
                    filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        fileName = openFileDialog1.SafeFileName;
                        str.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
                OpenFile(filePath, fileName);
            }
        }
        private void saveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetTabVocus() != null)
                {
                    TabPage Tab = GetTabVocus();

                    if (sender.ToString() == "Save" && m_FileInfo[Tab.Name].FilePathToSave == null) //saveAs
                    {
                        SaveFileDialog("Save as");
                    }
                    else if (sender.ToString() == "Save" && m_FileInfo[Tab.Name].FilePathToSave != null) //save
                    {
                        SaveFileDialog("Save");
                    }
                    else if (sender.ToString() == "Save as") //saveAs
                    {
                        SaveFileDialog("Save as");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void decryptRus_Click(object sender, EventArgs e)
        {
            foreach (Control tab in tabControl1.Controls)
            {
                if (tab.CanFocus == true)
                {
                    TabPage Tab = (TabPage)tab;

                    foreach (Control ctr in Tab.Controls)
                    {
                        var da = ctr.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                        if (new string(da) == "Hex")
                        {
                            ctr.Text = ctr.Text.Decrypt();
                            foreach (Control ctr2 in Tab.Controls)
                            {
                                var da2 = ctr2.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                                if (new string(da2) == "Text")
                                {
                                    if (ctr.Name.Replace("Hex", "") == ctr2.Name.Replace("Text", ""))
                                    {
                                        ctr2.Text = m_CodePage.GetString(ctr.Text.Hex2byte());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void toRusItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toRusItem = sender as ToolStripMenuItem;
            if (toRusItem.CheckState == CheckState.Checked)
                m_ToRus = true;
            else if (toRusItem.CheckState == CheckState.Unchecked)
                m_ToRus = false;
        }
        private void toRusItem2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toRusItem2 = sender as ToolStripMenuItem;
            if (toRusItem2.CheckState == CheckState.Checked)
                m_ToRus2 = true;
            else if (toRusItem2.CheckState == CheckState.Unchecked)
                m_ToRus2 = false;
        }
        private void closeItem_Click(object sender, EventArgs e)
        {
            if(sender.ToString() == "Close file")
            {
                if (GetTabVocus() != null)
                {
                    TabPage Tab = GetTabVocus();

                    if (m_FileInfo[Tab.Name].FileHasEdited == true && CloseResult(Tab.Name) == DialogResult.No)
                    {
                        return;
                    }

                    Tab.Controls.Clear();

                    m_FileInfo.Remove(Tab.Name);

                    tabControl1.TabPages.Remove(Tab);
                }
            }
            else if(sender.ToString() == "Close all files")
            {
                for (int i = tabControl1.TabPages.Count - 1; i >= 0; i--)
                {
                    TabPage Tab = tabControl1.TabPages[i];

                    if((m_FileInfo[Tab.Name].FileHasEdited == true && CloseResult(Tab.Name) == DialogResult.Yes) || m_FileInfo[Tab.Name].FileHasEdited == false)
                    {
                        Tab.Controls.Clear();

                        m_FileInfo.Remove(Tab.Name);

                        tabControl1.TabPages.RemoveAt(i);
                    }
                }
            }
        }
        private void exitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sharping_Click(object sender, EventArgs e)
        {
            if (GetTabVocus() != null)
            {
                TabPage Tab = GetTabVocus(true);

                foreach (Control hex in Tab.Controls)
                {
                    string nameHex = new string(hex.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                    if (nameHex == "Hex")
                    {
                        foreach (Control text in Tab.Controls)
                        {
                            string nameText = new string(hex.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                            if (hex.Name.Replace("Hex", "") == text.Name.Replace("Text", ""))
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
        }
        private void symbolConverter_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem symbolConverter = sender as ToolStripMenuItem;

            if(symbolConverter.CheckState == CheckState.Checked)
            {
                m_SymbolConverter = true;
                if(GetTabVocus() != null)
                {
                    for (int i = tabControl1.TabPages.Count - 1; i >= 0; i--)
                    {
                        TabPage tab = tabControl1.TabPages[i];

                        int subLength = int.Parse(tab.Text.Split('-')[2].Replace(" ", "").Replace("lines", ""));
                        string region = tab.Text.Split('-')[3].Replace(" ", "").Replace("*", "");

                        if(region == "europe")
                        {
                            foreach (Control _tabControl in tab.Controls)
                            {
                                if (_tabControl is TabControl)
                                {
                                    TabControl tabControl = (TabControl)_tabControl;

                                    for (int j = tabControl.TabPages.Count - 1; j >= 0; j--)
                                    {
                                        for (int subId = 1; subId <= subLength / 5; subId++)
                                        {
                                            TextBox hex = (TextBox)tabControl.TabPages[j].GetTextBoxById(subId, "Hex");
                                            hex.Text = hex.Text.Replace("00", "2F").Replace("0A", "23");

                                            TextBox text = (TextBox)tabControl.TabPages[j].GetTextBoxById(subId, "Text");
                                            text.Text = m_CodePage.GetString(hex.Text.Hex2byte());
                                        }
                                    }
                                }
                            }
                        }
                        else if(region == "usa")
                        {
                            for (int subId = 1; subId <= subLength; subId++)
                            {
                                TextBox hex = (TextBox)tab.GetTextBoxById(subId, "Hex");
                                hex.Text = hex.Text.Replace("00", "2F").Replace("0A", "23");

                                TextBox text = (TextBox)tab.GetTextBoxById(subId, "Text");
                                text.Text = m_CodePage.GetString(hex.Text.Hex2byte());
                            }
                        }
                    }
                }
            }
            else if(symbolConverter.CheckState == CheckState.Unchecked)
            {
                m_SymbolConverter = false;
                if (GetTabVocus() != null)
                {
                    for (int i = tabControl1.TabPages.Count - 1; i >= 0; i--)
                    {
                        TabPage tab = tabControl1.TabPages[i];

                        int subLength = int.Parse(tab.Text.Split('-')[2].Replace(" ", "").Replace("lines", ""));
                        string region = tab.Text.Split('-')[3].Replace(" ", "").Replace("*", "");

                        if (region == "europe")
                        {
                            foreach (Control _tabControl in tab.Controls)
                            {
                                if (_tabControl is TabControl)
                                {
                                    TabControl tabControl = (TabControl)_tabControl;

                                    for (int j = tabControl.TabPages.Count - 1; j >= 0; j--)
                                    {
                                        for (int subId = 1; subId <= subLength / 5; subId++)
                                        {
                                            TextBox hex = (TextBox)tabControl.TabPages[j].GetTextBoxById(subId, "Hex");
                                            hex.Text = hex.Text.Replace("2F", "00").Replace("23", "0A");

                                            TextBox text = (TextBox)tabControl.TabPages[j].GetTextBoxById(subId, "Text");
                                            text.Text = m_CodePage.GetString(hex.Text.Hex2byte());
                                        }
                                    }
                                }
                            }
                        }
                        else if (region == "usa")
                        {
                            for (int subId = 1; subId <= subLength; subId++)
                            {
                                TextBox hex = (TextBox)tab.GetTextBoxById(subId, "Hex");
                                hex.Text = hex.Text.Replace("2F", "00").Replace("23", "0A");

                                TextBox text = (TextBox)tab.GetTextBoxById(subId, "Text");
                                text.Text = m_CodePage.GetString(hex.Text.Hex2byte());
                            }
                        }
                    }
                }
            }
        }
        private void about_Click(object sender, EventArgs e)
        {
            About();
        }
        private void addFile_Click(object sender, EventArgs e)
        {
            addFile add = new addFile();
            add.Owner = this;
            add.Show();
        }
        private void codePage_Changed(object sender, EventArgs e)
        {
            ToolStripTextBox codePage = (ToolStripTextBox)sender;
            try
            {
                m_CodePage = Encoding.GetEncoding(int.Parse(codePage.Text));
            }
            catch
            {
                codePage.Text = "";
                return;
            }
        }

        //contextMenuStrip
        private void СreateContextMenuStripItem()
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
            
            if (GetTextBoxVocus() != null)
            {
                TextBox textbox = (TextBox)GetTextBoxVocus();

                textbox.Text = textbox.Text.Replace("23", "0A");
                textbox.Modified = true;
            }
            
        }
        private void textCopy_Click(object sender, EventArgs e)
        {
            if (GetTextBoxVocus() != null)
            {
                TextBox textbox = GetTextBoxVocus();

                if(textbox.SelectedText != "")
                {
                    Clipboard.SetText(textbox.SelectedText);
                }
            }
        }
        private void textPaste_Click(object sender, EventArgs e)
        {
            if (GetTextBoxVocus() != null)
            {
                TextBox textbox = GetTextBoxVocus();

                textbox.Paste(Clipboard.GetText());
            }
        }

        //updataTextbox
        private void textBox_Changed(object sender, EventArgs e)
        {
            TabPage Tab = GetTabVocus(true);
            TabPage Tab1 = GetTabVocus();

            TextBox box = (TextBox)sender;
            if(box.Focused == true)
            {
                //if (Tab.Text.Replace(" *", "") == Tab.Text)
                //{
                //    Tab.Text = Tab.Text + " *";
                //}
                //if (Tab1.Text.Replace(" *", "") == Tab1.Text)
                //{
                //    Tab1.Text = Tab1.Text + " *";
                //}
                FileHasEdit(true);

                string boxName = new string(box.Name.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
                if(boxName == "Hex")
                {
                    int id = int.Parse(box.Name.Replace("Hex", ""));
                    TextBox text = Tab.GetTextBoxById(id, "Text");
                    Label lenght = Tab.GetLabelById(id, "Length");
                    Label last = Tab.GetLabelById(id, "Last");

                    text.Text = m_CodePage.GetString(box.Text.Hex2byte());
                    lenght.Text = text.Text.Length.ToString();
                    last.Text = (text.MaxLength - Int32.Parse(lenght.Text)).ToString();
                }
                else if(boxName == "Text")
                {
                    int id = int.Parse(box.Name.Replace("Text", ""));
                    TextBox hex = Tab.GetTextBoxById(id, "Hex");
                    Label lenght = Tab.GetLabelById(id, "Length");
                    Label last = Tab.GetLabelById(id, "Last");

                    hex.Text = BitConverter.ToString(m_CodePage.GetBytes(box.Text));
                    lenght.Text = box.Text.Length.ToString();
                    last.Text = (box.MaxLength - Int32.Parse(lenght.Text)).ToString();
                }
            }
        }

        //drag and drop
        private void eventDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void eventDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string filePath = file;
                string fileName = System.IO.Path.GetFileName(file);
                OpenFile(filePath, fileName);
            }
        }

        //about
        private void Editor_Load(object sender, EventArgs e)
        {
            CreateMenuStripItem();
            СreateContextMenuStripItem();

            downPanel.Controls.Add(saveProgress);
            saveProgress.Visible = false;

            tabControl1.DragEnter += eventDragEnter;
            tabControl1.DragDrop += eventDragDrop;

            About();
        }
        private void About()
        {
            About about = new About();
            about.Owner = this;
            about.ShowDialog();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var item in m_FileInfo.Values)
            {
                if(item.FileHasEdited == true)
                {
                    DialogResult result = CloseResult(item.FileInformation);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            
                            break;

                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }
        private DialogResult CloseResult(string fileName)
        {
            DialogResult result = MessageBox.Show("The current file has changed. Do you want to close it?",
                    fileName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            return result;
        }

        private void FileHasEdit(bool edit)
        {
            TabPage tabInTab = GetTabVocus(true);
            TabPage tab = GetTabVocus();

            if (edit == true)
            {
                m_FileInfo[tab.Name].FileHasEdited = edit;

                if (tabInTab.Text.Replace(" *", "") == tabInTab.Text)
                {
                    tabInTab.Text = tabInTab.Text + " *";
                }
                if (tab.Text.Replace(" *", "") == tab.Text)
                {
                    tab.Text = tab.Text + " *";
                }
            }
            else if (edit == false)
            {
                m_FileInfo[tab.Name].FileHasEdited = edit;

                tab.Text = tab.Text.Replace(" *", "");
                foreach (Control tabControl in tab.Controls)
                {
                    if (tabControl is TabControl)
                    {
                        foreach (Control ctr in tabControl.Controls)
                        {
                            if (ctr is TabPage)
                            {
                                ctr.Text = ctr.Text.Replace(" *", "");
                            }
                        }
                    }
                }
            }
        }
    }
}
