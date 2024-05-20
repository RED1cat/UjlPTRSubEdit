using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace ujlptr_subedit
{
    public partial class Editor : Form
    {
        public TextPreview.TextPreview TextPreview;
        public bool AdvancedMode = false;
        public string FileName;
        public string FilePath;
        public byte[] File;
        public int SelectedItem = -1;
        public Encoding CodePage = Encoding.Default;
        public int AddressOffset = 0x1c5750; //ujlusa - 0x1c5750 ujljp - 0x1c5110 ujleur - 0x1c4eb8
        private ToolStripProgressBar ProgressBar;
        public bool FileEdit = false;
        public string ConverterName = "None";
        private bool DoCopy = false;
        private int FirstSelectedElement = 0;
        private bool SelectionStarted = false;

        public List<Group> Groups = new List<Group>();

        public Editor(ToolStripProgressBar progressBar)
        {
            ProgressBar = progressBar;
            InitializeComponent();
            Panel.AutoScroll = true;
            Panel.HorizontalScroll.Enabled = false;
            Panel.HorizontalScroll.Visible = false;

        }
        // 12 - 6C 8E 1D 80 87 00 00 00 DA 00 00 00
        // 4  - 6C 8E 1D 80
        // 6C 8E 1D - address
        // 80 - pointer
        // 87 - time
        // DA 00 - switching time
        public void DecodeFile(int firstOffset = 0, int lastOffset = 0)
        {
            if (this.FilePath != null)
            {
                int first = 0;
                int last = this.File.Length;
                if(firstOffset != 0 & lastOffset != 0)
                {
                    first = firstOffset;
                    last = lastOffset;
                }
                
                ListView.Items.Clear();
                Groups.Clear();

                int maxid = 0;
                ProgressBar.Visible = true;

                List<int> allPointsLocations = new List<int>();

                for (int i = first; i < last; i++)
                {
                    if (this.File[i] == 0x80)
                    {
                        if (this.File[i + 2] == 0 & this.File[i + 3] == 0 & this.File[i + 4] == 0 & this.File[i + 7] == 0 & this.File[i + 8] == 0 || this.File[i - 1] != 0 & this.File[i - 2] != 0 & this.File[i - 3] != 0)
                        {
                            if (this.File[i + 12] == 0x80 | this.File[i - 12] == 0x80)
                            {
                                maxid++;
                                allPointsLocations.Add(i - 3);
                            }
                            else if (this.File[i + 4] == 0x80 | this.File[i - 4] == 0x80)
                            {
                                maxid++;
                                allPointsLocations.Add(i - 3);
                            }
                        }
                    }
                }
                ProgressBar.Maximum = maxid;
                ProgressBar.Value = 0;

                List<int> pointersLocation = new List<int>();
                List<byte[]> pointers = new List<byte[]>();
                List<string> texts = new List<string>();

                foreach (int point in allPointsLocations)
                {
                    byte[] address = new byte[3] { this.File[point + 2], this.File[point + 1], this.File[point] };
                    int textAddressInFile = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16) - AddressOffset;
                    if(textAddressInFile < 0 || textAddressInFile > this.File.Length)
                    {
                        continue;
                    }
                    string text = textAddressInFile.GetTextFromAddress(File, CodePage);

                    if (this.File[(point + 3) + 4] == 0x80 | this.File[(point + 3) - 4] == 0x80) //4
                    {
                        pointersLocation.Add(point);
                        pointers.Add(new byte[3] { this.File[point + 2], this.File[point + 1], this.File[point] });
                        texts.Add(text);

                        if (this.File[(point + 3) + 4] != 0x80 & this.File[(point + 3) - 4] == 0x80) //end
                        {
                            int firstAdd = Convert.ToInt32(BitConverter.ToString(pointers.First(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                            int lastAdd = (Convert.ToInt32(BitConverter.ToString(pointers.Last(), 0, 3).Replace("-", ""), 16) - AddressOffset);
                            lastAdd = lastAdd + lastAdd.GetTextFromAddress(File, CodePage).Length;

                            if ((lastAdd - firstAdd) - texts.Count < 0)
                            {
                                lastAdd = Convert.ToInt32(BitConverter.ToString(pointers.First(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                                lastAdd = lastAdd + lastAdd.GetTextFromAddress(File, CodePage).Length;

                                firstAdd = Convert.ToInt32(BitConverter.ToString(pointers.Last(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                            }

                            if ((lastAdd - firstAdd) - texts.Count > 0)
                            {
                                Groups.Add(new Group(pointersLocation, pointers, texts, firstAdd, (lastAdd - firstAdd) - texts.Count));
                            }

                            pointersLocation.Clear();
                            pointers.Clear();
                            texts.Clear();
                        }
                    }
                    else if (this.File[(point + 3) + 12] == 0x80 | this.File[(point + 3) - 12] == 0x80) //12
                    {
                        pointersLocation.Add(point);
                        pointers.Add(new byte[6] { this.File[point + 2], this.File[point + 1], this.File[point], this.File[point + 4], this.File[point + 8], this.File[point + 9] });
                        texts.Add(text);

                        if (this.File[(point + 3) + 12] != 0x80 & this.File[(point + 3) - 12] == 0x80) //end
                        {
                            int firstAdd = Convert.ToInt32(BitConverter.ToString(pointers.First(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                            int lastAdd = (Convert.ToInt32(BitConverter.ToString(pointers.Last(), 0, 3).Replace("-", ""), 16) - AddressOffset);
                            lastAdd = lastAdd + lastAdd.GetTextFromAddress(File, CodePage).Length;


                            if ((lastAdd - firstAdd) - texts.Count < 0)
                            {
                                lastAdd = Convert.ToInt32(BitConverter.ToString(pointers.First(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                                lastAdd = lastAdd + lastAdd.GetTextFromAddress(File, CodePage).Length;

                                firstAdd = Convert.ToInt32(BitConverter.ToString(pointers.Last(), 0, 3).Replace("-", ""), 16) - AddressOffset;
                            }

                            if((lastAdd - firstAdd) - texts.Count > 0)
                            {
                                Groups.Add(new Group(pointersLocation, pointers, texts, firstAdd, (lastAdd - firstAdd) - texts.Count));
                            }

                            pointersLocation.Clear();
                            pointers.Clear();
                            texts.Clear();
                        }
                    }

                    ProgressBar.Value++;
                }
                ProgressBar.Visible = false;
                FillListView();
                ListView.Items[0].Selected = true;
            }
        }
        private void FillListView()
        {
            for (int group = 0; group < Groups.Count; group++)
            {
                for (int line = 0; line < Groups[group].Lines.Count; line++)
                {
                    ListViewItem tmpItem = ListView.Items.Add((group + 1).ToString()); //Group
                    tmpItem.SubItems.Add((line + 1).ToString()); //id
                    tmpItem.SubItems.Add(Convert.ToString(Groups[group].Lines[line].PointerLocation, 16)); //pointerLocation
                    tmpItem.SubItems.Add(Groups[group].MaxChars.ToString()); //maxlength
                    tmpItem.SubItems.Add(Groups[group].Lines[line].Text.Replace("\0", "").Length.ToString()); //curlength
                    tmpItem.SubItems.Add(Groups[group].Lines[line].Text); //text
                    tmpItem.SubItems.Add(Groups[group].Lines[line].Time); //time
                    tmpItem.SubItems.Add(Groups[group].Lines[line].SwitchingTime); //switchingtime
                }
            }
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(SelectedItem != e.ItemIndex)
            {
                EditButton.Enabled = true;
                TextBox.Enabled = true;

                TextBox.Text = e.Item.SubItems[5].Text.Replace("\n", "\r\n");

                if(e.Item.SubItems[6].Text != "")
                {
                    TimeTextBox.Enabled = true;
                    TimeTextBox.Text = e.Item.SubItems[6].Text;
                }
                else
                {
                    TimeTextBox.Text = "";
                    TimeTextBox.Enabled = false;
                }
                if(e.Item.SubItems[7].Text != "")
                {
                    SwitchingTimeTextBox.Enabled = true;
                    SwitchingTimeTextBox.Text = e.Item.SubItems[7].Text;
                }
                else
                {
                    SwitchingTimeTextBox.Text = "";
                    SwitchingTimeTextBox.Enabled = false;
                }

                MaxLengthLabel.Text = $"Max:{e.Item.SubItems[3].Text}";
                IdLabel.Text = $"Id:{e.Item.SubItems[1].Text}";
                AllLengthLabel.Text = $"CurAll:{Groups[int.Parse(e.Item.SubItems[0].Text) - 1].UpdateCurChars()}";
                GroupIdLabel.Text = $"Group:{e.Item.SubItems[0].Text}";

                SelectedItem = e.ItemIndex;

                if (TextPreview != null)
                {
                    TextPreview.TextRender.CurrentTextIndex = ListView.SelectedItems[0].Index;
                    TextPreview.TextRender.MaxTextIndex = ListView.Items.Count;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int groupId = int.Parse(ListView.SelectedItems[0].SubItems[0].Text) - 1;
            int lineId = int.Parse(ListView.SelectedItems[0].SubItems[1].Text) - 1;

            Groups[groupId].Lines[lineId].Text = TextBox.Text.Replace("\r", "");

            int cur = Groups[groupId].Lines[lineId].Text.Length;
            int curAll = Groups[groupId].UpdateCurChars();

            LengthLabel.Text = $"Cur:{cur}";
            AllLengthLabel.Text = $"CurAll:{curAll}";

            if (curAll > Groups[groupId].MaxChars && TextBox.Text.Length > 0)
            {
                int needToDell = TextBox.Text.Length - (curAll - Groups[groupId].MaxChars);
                if(needToDell < 0)
                {
                    TextBox.Text = TextBox.Text.Remove(0);
                }
                else
                {
                    TextBox.Text = TextBox.Text.Remove(needToDell);
                }
                TextBox.SelectionStart = TextBox.Text.Length;
                SystemSounds.Exclamation.Play();
            }



            if (DoCopy && TextBox.Text.Length > 0)
            {
                if(TextBox.Text[TextBox.Text.Length - 1] == '\n' && TextBox.Text[TextBox.Text.Length - 2] == '\r')
                {
                    TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 2);
                    TextBox.SelectionStart = TextBox.Text.Length;
                    DoCopy = false;
                }
            }

            if(TextPreview != null)
            {
                TextPreview.TextRender.Hex = TextBox.Text.ConvertTextToHex(codePage: CodePage);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int groupId = int.Parse(ListView.SelectedItems[0].SubItems[0].Text) - 1;
            int lineId = int.Parse(ListView.SelectedItems[0].SubItems[1].Text) - 1;

            Groups[groupId].UpdateCurChars();

            Groups[groupId].Lines[lineId].Text = TextBox.Text.Replace("\r", "");
            ListView.SelectedItems[0].SubItems[5].Text = TextBox.Text.Replace("\r", "");
            ListView.SelectedItems[0].SubItems[4].Text = TextBox.Text.Replace("\r", "").Length.ToString();

            if (SwitchingTimeTextBox.Text.Length == 4)
            {
                Groups[groupId].Lines[lineId].SwitchingTime = SwitchingTimeTextBox.Text;
                ListView.SelectedItems[0].SubItems[7].Text = SwitchingTimeTextBox.Text;
            }
            if (TimeTextBox.Text.Length == 2)
            {
                Groups[groupId].Lines[lineId].Time = TimeTextBox.Text;
                ListView.SelectedItems[0].SubItems[6].Text = TimeTextBox.Text;
            }

            Groups[groupId].Edit = true;
            FileEdit = true;

            foreach(ListViewItem line in ListView.Items)
            {
                if (line.SubItems[0].Text == (groupId + 1).ToString())
                {
                    line.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
        public void SaveInFile(string filePath = "")
        {
            if (ListView.Items.Count > 0 & FileEdit)
            {
                if(filePath == "")
                {
                    filePath = FilePath;
                }
                int count = 0;

                foreach(Group group in Groups) 
                {
                    if (group.Edit)
                    {
                        count += group.Lines.Count;
                    }
                }
                ProgressBar.Maximum = (count * 2) + 1;
                ProgressBar.Visible = true;
                ProgressBar.Value = 0;

                foreach(Group group in Groups)
                {
                    if (group.Edit)
                    {
                        int textLocation = group.TextLocation;
                        int maxChar = group.MaxChars + group.Lines.Count;
                        
                        for(int i = textLocation; i < textLocation + maxChar; i++)
                        {
                            File[i] = 0x00;
                        }

                        foreach(Line line in group.Lines)
                        {
                            Array.Copy(CodePage.GetBytes(line.Text), 0, File, textLocation, line.Text.Length); //text

                            byte[] addressInGame = BitConverter.GetBytes(textLocation + AddressOffset); //textaddress
                            File[line.PointerLocation] = addressInGame[0]; 
                            File[line.PointerLocation + 1] = addressInGame[1];
                            File[line.PointerLocation + 2] = addressInGame[2];

                            textLocation += line.Text.Length + 1;

                            if(line.Time != "" && line.Time != null)
                            {
                                File[line.PointerLocation + 4] = Convert.ToByte(Convert.ToInt32(line.Time, 16)); //time
                            }
                            if(line.SwitchingTime != ""  && line.SwitchingTime != null)
                            {
                                File[line.PointerLocation + 8] = Convert.ToByte(Convert.ToInt32(line.SwitchingTime.Remove(2), 16)); //switchtime
                                File[line.PointerLocation + 9] = Convert.ToByte(Convert.ToInt32(line.SwitchingTime.Remove(0, 2), 16));
                            }
                            ProgressBar.Value++;
                        }
                    }
                }

                try
                {
                    System.IO.File.WriteAllBytes(filePath, File);
                    ProgressBar.Value++;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    foreach (ListViewItem item in ListView.Items)
                    {
                        if (item.Font.Bold)
                        {
                            item.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                            ProgressBar.Value++;
                        }
                    }
                    FilePath = filePath;
                    ProgressBar.Visible = false;
                    FileEdit = false;
                    MessageBox.Show("Save complete",
                        FileName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        public void FindText(string text)
        {
            foreach(ListViewItem line in ListView.Items)
            {
                if (line.SubItems[5].Text.Contains(text))
                {
                    line.Selected = true;
                    line.EnsureVisible();
                    SystemSounds.Exclamation.Play();
                    return;
                }
            }
            MessageBox.Show("The specified text could not be found",
                text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ConvertSelectedLines(Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                foreach (ListViewItem item in ListView.Items)
                {
                    if(item.Checked == true)
                    {
                        if (item.SubItems[5].Text.Replace("\0", "").Length > 0)
                        {
                            item.SubItems[5].Text = item.SubItems[5].Text.ConvertTextFromPattern(CodePage, hexConverter);
                            item.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                            this.FileEdit = true;
                        }
                    }
                }
            }
        }
        public void EnableCheckboxesOnListView()
        {
            ListView.CheckBoxes = true;
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileEdit)
            {
                SystemSounds.Exclamation.Play();
                DialogResult result = MessageBox.Show("The current file has changed. Do you want to close it?",
                    FileName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Groups.Clear();
                    Array.Clear(File, 0, File.Length);
                    GC.Collect();
                    this.Dispose();
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
         {
            if(e.KeyChar == '\u0016')
            {
                DoCopy = true;
            }
        }


        private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                if (e.Item.Checked && !SelectionStarted)
                {
                    int id = 0;
                    if (Int32.TryParse(e.Item.Text, out id) && id > 0)
                    {
                        if (FirstSelectedElement == 0)
                        {
                            FirstSelectedElement = id;
                        }
                        else if (FirstSelectedElement != id && FirstSelectedElement > 0)
                        {
                            SelectionStarted = true;
                            int count = id - FirstSelectedElement;
                            for (int i = count; i >= 0; i--)
                            {
                                ListView.Items[(i + FirstSelectedElement) - 1].Checked = true;
                            }
                            FirstSelectedElement = 0;
                            SelectionStarted = false;
                        }
                    }
                }
            }
            //if(Keyboard.GetKeyStates(Key.LeftShift) == KeyStates.Down)
            //{
            //    if(FirstSelectedElement == 0)
            //    {
            //        FirstSelectedElement = Int32.Parse(e.Item.Text);
            //    }
            //}
        }

        public void ChangeMode()
        {
            if (!AdvancedMode)
            {
                IdLabel.Visible = true;
                GroupIdLabel.Visible = true;
                AllLengthLabel.Visible = true;
                MaxLengthLabel.Visible = true;
                LengthLabel.Visible = true;
                TimeLabel.Visible = true;
                SwitchingTimeLabel.Visible = true;
                SwitchingTimeTextBox.Visible = true;
                TimeTextBox.Visible = true;
                
                AdvancedMode = true;
            }
            else
            {
                IdLabel.Visible = false;
                GroupIdLabel.Visible = false;
                AllLengthLabel.Visible = false;
                MaxLengthLabel.Visible = false;
                LengthLabel.Visible = false;
                TimeLabel.Visible = false;
                SwitchingTimeLabel.Visible = false;
                SwitchingTimeTextBox.Visible = false;
                TimeTextBox.Visible = false;

                AdvancedMode = false;
            }
        }
    }
}
