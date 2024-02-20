using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace ujlptr_subedit
{
    public partial class Editor : Form
    {
        public UjlTextPreview TextPreview;
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

        public Editor(ToolStripProgressBar progressBar)
        {
            ProgressBar = progressBar;
            InitializeComponent();
            Panel.AutoScroll = true;
            Panel.HorizontalScroll.Enabled = false;
            Panel.HorizontalScroll.Visible = false;
            
        }

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
                //this.Text = FileName;
                int id = 1;
                int group = 1;
                int maxid = 0;
                ProgressBar.Visible = true;

                for (int i = first; i < last; i++)
                {
                    if (this.File[i] == 0x80)
                    {
                        if (this.File[i + 2] == 0 & this.File[i + 3] == 0 & this.File[i + 4] == 0 & this.File[i + 7] == 0 & this.File[i + 8] == 0 || this.File[i - 1] != 0 & this.File[i - 2] != 0 & this.File[i - 3] != 0)
                        {
                            if (this.File[i + 12] == 0x80 | this.File[i - 12] == 0x80)
                            {
                                maxid++;
                            }
                            else if (this.File[i + 4] == 0x80 | this.File[i - 4] == 0x80)
                            {
                                maxid++;
                            }
                        }
                    }
                }
                ProgressBar.Maximum = maxid;
                ProgressBar.Value = 0;

                for (int i = first; i < last; i++)
                {
                    if (this.File[i] == 0x80)
                    {
                        if (this.File[i + 2] == 0 & this.File[i + 3] == 0 & this.File[i + 4] == 0 & this.File[i + 7] == 0 & this.File[i + 8] == 0 || this.File[i - 1] != 0 & this.File[i - 2] != 0 & this.File[i - 3] != 0)
                        {
                            byte[] address = new byte[3] { this.File[i - 1], this.File[i - 2], this.File[i - 3]};
                            int textaddressInFile = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16) - AddressOffset;
                            int textaddressInGame = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16);
                            if (textaddressInFile > 0 & textaddressInFile < this.File.Length)
                            {
                                int count = 0;
                                bool StopFlag = false;
                                while (true)
                                {
                                    if(textaddressInFile + count == this.File.Length)
                                    {
                                        break;
                                    }
                                    if (this.File[textaddressInFile + count] == 0x00)
                                    {
                                        StopFlag = true;
                                    }
                                    else if (StopFlag)
                                    {
                                        break;
                                    }
                                    count++;
                                }
                                if (count > 0)
                                {
                                    count--;
                                }
                                string text = CodePage.GetString(this.File, textaddressInFile, count);

                                if (this.File[i + 4] == 0x80 | this.File[i - 4] == 0x80) //4
                                {
                                    AddLineToListView(id, group, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, text);
                                    id++;
                                    ProgressBar.Value++;

                                    if (this.File[i + 4] != 0x80 & this.File[i - 4] == 0x80)
                                    {
                                        group++;
                                    }
                                }
                                else if (this.File[i + 12] == 0x80 | this.File[i - 12] == 0x80) //12
                                {
                                    AddLineToListView(id, group, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, text, BitConverter.ToString(this.File, i + 1, 1), BitConverter.ToString(this.File, i + 5, 2).Replace("-", ""));
                                    id++;
                                    ProgressBar.Value++;

                                    if (this.File[i + 12] != 0x80 & this.File[i - 12] == 0x80)
                                    {
                                        group++;
                                    }
                                }
                            }
                        }
                    }
                }
                ProgressBar.Visible = false;
                ListView.Items[0].Selected = true;
            }
        }
        public void AddLineToListView(int id, int group, string pointLocation, string textLocationInGame , string textLocationInFile,  int maxTextLength, string text, string time = "", string switchingTime = "")
        {
            ListViewItem tmpItem = ListView.Items.Add(id.ToString());
            tmpItem.SubItems.Add(pointLocation.ToString()); //pointlocation
            tmpItem.SubItems.Add(maxTextLength.ToString()); //maxlength
            tmpItem.SubItems.Add(text.Replace("\0", "").Length.ToString()); //curlength
            tmpItem.SubItems.Add(text); //text
            tmpItem.SubItems.Add(textLocationInGame); //textlocationingame
            tmpItem.SubItems.Add(textLocationInFile); //textlocationinfile
            tmpItem.SubItems.Add(time); //time
            tmpItem.SubItems.Add(switchingTime); //switchingtime
            tmpItem.SubItems.Add(group.ToString());
        }
        private void ChangeMaxSymbolOnLineButton_Click(object sender, EventArgs e)
        {
            int count = 1;
            int.TryParse(NumberSymbolsToChangeTextBox.Text, out count);
            if(((Button)sender).Name == "ReduceMaxSymbolOnLineButton")
            {
                int group = int.Parse(ListView.SelectedItems[0].SubItems[9].Text);
                int nextid = int.Parse(ListView.SelectedItems[0].SubItems[0].Text);
                if (group == int.Parse(ListView.Items[nextid].SubItems[9].Text))
                {
                    int maxLength = int.Parse(ListView.SelectedItems[0].SubItems[2].Text) - count;
                    if(maxLength > 0)
                    {
                        ListView.SelectedItems[0].SubItems[2].Text = maxLength.ToString();

                        if (ListView.SelectedItems[0].SubItems[4].Text.Length > maxLength)
                        {
                            ListView.SelectedItems[0].SubItems[4].Text = ListView.SelectedItems[0].SubItems[4].Text.Remove(maxLength);
                            ListView.SelectedItems[0].SubItems[3].Text = ListView.SelectedItems[0].SubItems[4].Text.Replace("\0", "").Length.ToString();
                        }
                        ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        ListView.Items[nextid].SubItems[2].Text = (int.Parse(ListView.Items[nextid].SubItems[2].Text) + count).ToString();
                        ListView.Items[nextid].SubItems[6].Text = Convert.ToString(Convert.ToInt32(ListView.Items[nextid].SubItems[6].Text, 16) - count, 16);
                        ListView.Items[nextid].SubItems[5].Text = Convert.ToString(Convert.ToInt32(ListView.Items[nextid].SubItems[5].Text, 16) - count, 16);

                        ListView.Items[nextid].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        ListView_ItemSelectionChanged(sender, new ListViewItemSelectionChangedEventArgs(ListView.SelectedItems[0], nextid - 1, true));
                        FileEdit = true;
                    }
                }
            }
            else if((((Button)sender).Name == "IncreaseMaxSymbolOnLineButton"))
            {
                int group = int.Parse(ListView.SelectedItems[0].SubItems[9].Text);
                int nextid = int.Parse(ListView.SelectedItems[0].SubItems[0].Text);
                if (group == int.Parse(ListView.Items[nextid].SubItems[9].Text))
                {
                    int maxLength = int.Parse(ListView.Items[nextid].SubItems[2].Text) - count; //next
                    if (int.Parse(ListView.Items[nextid].SubItems[2].Text) - count > 0)
                    {
                        ListView.Items[nextid].SubItems[2].Text = maxLength.ToString(); 

                        if (ListView.Items[nextid].SubItems[4].Text.Length > maxLength)
                        {
                            ListView.Items[nextid].SubItems[4].Text = ListView.Items[nextid].SubItems[4].Text.Remove(maxLength);
                            ListView.Items[nextid].SubItems[3].Text = ListView.Items[nextid].SubItems[4].Text.Replace("\0", "").Length.ToString();
                        }
                        ListView.Items[nextid].SubItems[6].Text = Convert.ToString(Convert.ToInt32(ListView.Items[nextid].SubItems[6].Text, 16) + count, 16);
                        ListView.Items[nextid].SubItems[5].Text = Convert.ToString(Convert.ToInt32(ListView.Items[nextid].SubItems[5].Text, 16) + count, 16);
                        ListView.Items[nextid].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        ListView.SelectedItems[0].SubItems[2].Text = (int.Parse(ListView.SelectedItems[0].SubItems[2].Text) + count).ToString();
                        ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        ListView_ItemSelectionChanged(sender, new ListViewItemSelectionChangedEventArgs(ListView.SelectedItems[0], nextid - 1, true));
                        FileEdit = true;
                    }
                }

            }

        }
        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(SelectedItem != e.ItemIndex | sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                EditButton.Enabled = true;
                TextBox.Enabled = true;
                IncreaseMaxSymbolOnLineButton.Enabled = true;
                ReduceMaxSymbolOnLineButton.Enabled = true;
                NumberSymbolsToChangeTextBox.Enabled = true;

                TextBox.Text = e.Item.SubItems[4].Text.Replace("\n", "\r\n");

                if(e.Item.SubItems[7].Text != "")
                {
                    TimeTextBox.Enabled = true;
                    TimeTextBox.Text = e.Item.SubItems[7].Text;
                }
                else
                {
                    TimeTextBox.Text = "";
                    TimeTextBox.Enabled = false;
                }
                if(e.Item.SubItems[8].Text != "")
                {
                    SwitchingTimeTextBox.Enabled = true;
                    SwitchingTimeTextBox.Text = e.Item.SubItems[8].Text;
                }
                else
                {
                    SwitchingTimeTextBox.Text = "";
                    SwitchingTimeTextBox.Enabled = false;
                }

                MaxLengthLabel.Text = $"Max:{e.Item.SubItems[2].Text}";
                IdLabel.Text = $"Id:{e.Item.SubItems[0].Text}";
                PointerLocationLabel.Text = $"Pointer:{e.Item.SubItems[1].Text}";
                GroupIdLabel.Text = $"Group:{e.Item.SubItems[9].Text}";

                SelectedItem = e.ItemIndex;

                if (TextPreview != null)
                {
                    TextPreview.UjlTextRender.CurrentTextIndex = int.Parse(e.Item.SubItems[0].Text);
                    TextPreview.UjlTextRender.MaxTextIndex = ListView.Items.Count;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int length = TextBox.Text.Replace("\r", "").Length;
            int maxLenght = int.Parse(ListView.SelectedItems[0].SubItems[2].Text);

            LengthLabel.Text = $"Cur:{length}";

            if (length > maxLenght)
            {
                TextBox.Text = TextBox.Text.Remove(maxLenght);
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
                TextPreview.UjlTextRender.Hex = ConvertTextToHex(TextBox.Text);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedItems[0].SubItems[4].Text = TextBox.Text.Replace("\r", "");
            ListView.SelectedItems[0].SubItems[3].Text = TextBox.Text.Replace("\r", "").Length.ToString();
            ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);
            if(SwitchingTimeTextBox.Text.Length == 4)
            {
                ListView.SelectedItems[0].SubItems[8].Text = SwitchingTimeTextBox.Text;
            }
            if(TimeTextBox.Text.Length == 2)
            {
                ListView.SelectedItems[0].SubItems[7].Text = TimeTextBox.Text;
            }
            FileEdit = true;
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
                foreach (ListViewItem item in ListView.Items)
                {
                    if (item.Font.Bold)
                    {
                        count++;
                    }
                }
                ProgressBar.Maximum = count + count + 1;
                ProgressBar.Visible = true;
                ProgressBar.Value = 0;
                foreach (ListViewItem item in ListView.Items)
                {
                    if (item.Font.Bold)
                    {
                        int maxLengthText = int.Parse(item.SubItems[2].Text);
                        string text = item.SubItems[4].Text;
                        int textAddress = Convert.ToInt32(item.SubItems[6].Text, 16);
                        int pointAddress = Convert.ToInt32(item.SubItems[1].Text, 16);
                        if (text.Length < maxLengthText)
                        {
                            while (text.Length != maxLengthText)
                            {
                                text = text.Insert(text.Length, "\0");
                            }
                        }
                        text = text.Insert(text.Length, "\0");

                        Array.Copy(CodePage.GetBytes(text), 0, File, textAddress, maxLengthText + 1); //text

                        File[pointAddress] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(0, 4), 16)); //textaddress
                        File[pointAddress + 1] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(0, 2).Remove(2), 16));
                        File[pointAddress + 2] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(2), 16));
                        if (item.SubItems[7].Text != "" & item.SubItems[8].Text != "")
                        {
                            File[pointAddress + 4] = Convert.ToByte(Convert.ToInt32(item.SubItems[7].Text, 16)); //time

                            File[pointAddress + 8] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(2), 16)); //switchtime
                            File[pointAddress + 9] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(0, 2), 16));
                        }
                        ProgressBar.Value++;
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
        public void ConvertSelectedLines(Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                foreach (ListViewItem item in ListView.Items)
                {
                    if(item.Checked == true)
                    {
                        if (item.SubItems[4].Text.Replace("\0", "").Length > 0)
                        {
                            item.SubItems[4].Text = ConvertTextFromPattern(item.SubItems[4].Text, hexConverter);
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
        private string ConvertTextFromPattern(string text, Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                return ConvertHexToText(ConvertTextToHex(text, hexConverter));
            }
            return text;
        }
        private string ConvertHexToText(string text)
        {
            byte[] raw = new byte[text.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return CodePage.GetString(raw);
        }
        private string ConvertTextToHex(string text, Dictionary<string, string> hexConverter = null) 
        {
            string hex = BitConverter.ToString(CodePage.GetBytes(text)).Replace("-", "");
            string outHex = "";

            for (int i = 0; i < hex.Length / 2; i++)
            {
                if (hexConverter != null)
                {
                    if(hexConverter.ContainsKey(hex.Substring(i * 2, 2)))
                    {
                        outHex += hexConverter[hex.Substring(i * 2, 2)];
                    }
                    else
                    {
                        outHex += hex.Substring(i * 2, 2);
                    }
                }
                else
                {
                    outHex += hex.Substring(i * 2, 2);
                }
            }
            return outHex;
        }

        public string[] GetAllHexText()
        {
            if(ListView.Items.Count > 0)
            {
                List<string> hexs = new List<string>();
                foreach (ListViewItem item in ListView.Items)
                {
                    hexs.Add(ConvertTextToHex(item.SubItems[4].Text.Replace("\0", "")));
                }
                return hexs.ToArray();
            }
            return new string[1] { "54-65-73-74" };
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

        private void Editor_SizeChanged(object sender, EventArgs e)
        {

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
                PointerLocationLabel.Visible = true;
                MaxLengthLabel.Visible = true;
                LengthLabel.Visible = true;
                IncreaseMaxSymbolOnLineButton.Visible = true;
                ReduceMaxSymbolOnLineButton.Visible = true;
                NumberSymbolsToChangeTextBox.Visible = true;
                TimeLabel.Visible = true;
                SwitchingTimeLabel.Visible = true;
                SwitchingTimeTextBox.Visible = true;
                TimeTextBox.Visible = true;
                EditButton.Location = new Point(965, 23);
                
                AdvancedMode = true;
            }
            else
            {
                IdLabel.Visible = false;
                GroupIdLabel.Visible = false;
                PointerLocationLabel.Visible = false;
                MaxLengthLabel.Visible = false;
                LengthLabel.Visible = false;
                IncreaseMaxSymbolOnLineButton.Visible = false;
                ReduceMaxSymbolOnLineButton.Visible = false;
                NumberSymbolsToChangeTextBox.Visible = false;
                TimeLabel.Visible = false;
                SwitchingTimeLabel.Visible = false;
                SwitchingTimeTextBox.Visible = false;
                TimeTextBox.Visible = false;
                EditButton.Location = new Point(799, 23);

                AdvancedMode = false;
            }
        }
    }
}
