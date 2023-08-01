using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class Editor : Form
    {
        public string m_FileName;
        public string m_FilePath;
        public byte[] m_File;
        public int m_SelectedItem;
        public Encoding m_CodePage = Encoding.Default;
        public int m_AddressOffset = 0x1c5750; //ujlusa - 0x1c5750 ujljp - 0x1c5110 ujleur - 0x1c4eb8
        private ToolStripProgressBar m_ProgressBar;
        public bool m_FileEdit = false;
        public string m_ConverterName = "None";
        
        public Editor(ToolStripProgressBar progressBar)
        {
            m_ProgressBar = progressBar;
            InitializeComponent();
            m_Panel.AutoScroll = true;
            m_Panel.HorizontalScroll.Enabled = false;
            m_Panel.HorizontalScroll.Visible = false;
            
        }

        public void m_DecodeFile(int firstOffset = 0, int lastOffset = 0)
        {
            if (this.m_FilePath != null)
            {
                int first = 0;
                int last = this.m_File.Length;
                if(firstOffset != 0 & lastOffset != 0)
                {
                    first = firstOffset;
                    last = lastOffset;
                }
                
                m_ListView.Items.Clear();
                this.Text = m_FileName;
                int id = 1;
                int group = 1;
                int maxid = 0;
                m_ProgressBar.Visible = true;

                for (int i = first; i < last; i++)
                {
                    if (this.m_File[i] == 0x80)
                    {
                        if (this.m_File[i + 2] == 0 & this.m_File[i + 3] == 0 & this.m_File[i + 4] == 0 & this.m_File[i + 7] == 0 & this.m_File[i + 8] == 0 || this.m_File[i - 1] != 0 & this.m_File[i - 2] != 0 & this.m_File[i - 3] != 0)
                        {
                            if (this.m_File[i + 12] == 0x80 | this.m_File[i - 12] == 0x80)
                            {
                                maxid++;
                            }
                            else if (this.m_File[i + 4] == 0x80 | this.m_File[i - 4] == 0x80)
                            {
                                maxid++;
                            }
                        }
                    }
                }
                m_ProgressBar.Maximum = maxid;
                m_ProgressBar.Value = 0;

                for (int i = first; i < last; i++)
                {
                    if (this.m_File[i] == 0x80)
                    {
                        if (this.m_File[i + 2] == 0 & this.m_File[i + 3] == 0 & this.m_File[i + 4] == 0 & this.m_File[i + 7] == 0 & this.m_File[i + 8] == 0 || this.m_File[i - 1] != 0 & this.m_File[i - 2] != 0 & this.m_File[i - 3] != 0)
                        {
                            byte[] address = new byte[3] { this.m_File[i - 1], this.m_File[i - 2], this.m_File[i - 3]};
                            int textaddressInFile = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16) - m_AddressOffset;
                            int textaddressInGame = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16);
                            if (textaddressInFile > 0 & textaddressInFile < this.m_File.Length)
                            {
                                int count = 0;
                                bool StopFlag = false;
                                while (true)
                                {
                                    if(textaddressInFile + count == this.m_File.Length)
                                    {
                                        break;
                                    }
                                    if (this.m_File[textaddressInFile + count] == 0x00)
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
                                string text = m_CodePage.GetString(this.m_File, textaddressInFile, count);

                                if (this.m_File[i + 4] == 0x80 | this.m_File[i - 4] == 0x80) //4
                                {
                                    m_AddLineToListView(id, group, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, text);
                                    id++;
                                    m_ProgressBar.Value++;

                                    if (this.m_File[i + 4] != 0x80 & this.m_File[i - 4] == 0x80)
                                    {
                                        group++;
                                    }
                                }
                                else if (this.m_File[i + 12] == 0x80 | this.m_File[i - 12] == 0x80) //12
                                {
                                    m_AddLineToListView(id, group, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, text, BitConverter.ToString(this.m_File, i + 1, 1), BitConverter.ToString(this.m_File, i + 5, 2).Replace("-", ""));
                                    id++;
                                    m_ProgressBar.Value++;

                                    if (this.m_File[i + 12] != 0x80 & this.m_File[i - 12] == 0x80)
                                    {
                                        group++;
                                    }
                                }
                            }
                        }
                    }
                }
                m_ProgressBar.Visible = false;
            }
        }
        public void m_AddLineToListView(int id, int group, string pointLocation, string textLocationInGame , string textLocationInFile,  int maxTextLength, string text, string time = "", string switchingTime = "")
        {
            ListViewItem tmpItem = m_ListView.Items.Add(id.ToString());
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
        private void m_ChangeMaxSymbolOnLineButton_Click(object sender, EventArgs e)
        {
            int count = 1;
            int.TryParse(m_NumberSymbolsToChangeTextBox.Text, out count);
            if(((Button)sender).Name == "m_ReduceMaxSymbolOnLineButton")
            {
                int group = int.Parse(m_ListView.SelectedItems[0].SubItems[9].Text);
                int nextid = int.Parse(m_ListView.SelectedItems[0].SubItems[0].Text);
                if (group == int.Parse(m_ListView.Items[nextid].SubItems[9].Text))
                {
                    int maxLength = int.Parse(m_ListView.SelectedItems[0].SubItems[2].Text) - count;
                    if(maxLength > 0)
                    {
                        m_ListView.SelectedItems[0].SubItems[2].Text = maxLength.ToString();

                        if (m_ListView.SelectedItems[0].SubItems[4].Text.Length > maxLength)
                        {
                            m_ListView.SelectedItems[0].SubItems[4].Text = m_ListView.SelectedItems[0].SubItems[4].Text.Remove(maxLength);
                            m_ListView.SelectedItems[0].SubItems[3].Text = m_ListView.SelectedItems[0].SubItems[4].Text.Replace("\0", "").Length.ToString();
                        }
                        m_ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        m_ListView.Items[nextid].SubItems[2].Text = (int.Parse(m_ListView.Items[nextid].SubItems[2].Text) + count).ToString();
                        m_ListView.Items[nextid].SubItems[6].Text = Convert.ToString(Convert.ToInt32(m_ListView.Items[nextid].SubItems[6].Text, 16) - count, 16);
                        m_ListView.Items[nextid].SubItems[5].Text = Convert.ToString(Convert.ToInt32(m_ListView.Items[nextid].SubItems[5].Text, 16) - count, 16);

                        m_ListView.Items[nextid].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        m_ListView_ItemSelectionChanged(sender, new ListViewItemSelectionChangedEventArgs(m_ListView.SelectedItems[0], nextid - 1, true));
                        m_FileEdit = true;
                    }
                }
            }
            else if((((Button)sender).Name == "m_IncreaseMaxSymbolOnLineButton"))
            {
                int group = int.Parse(m_ListView.SelectedItems[0].SubItems[9].Text);
                int nextid = int.Parse(m_ListView.SelectedItems[0].SubItems[0].Text);
                if (group == int.Parse(m_ListView.Items[nextid].SubItems[9].Text))
                {
                    int maxLength = int.Parse(m_ListView.Items[nextid].SubItems[2].Text) - count; //next
                    if (int.Parse(m_ListView.Items[nextid].SubItems[2].Text) - count > 0)
                    {
                        m_ListView.Items[nextid].SubItems[2].Text = maxLength.ToString(); 

                        if (m_ListView.Items[nextid].SubItems[4].Text.Length > maxLength)
                        {
                            m_ListView.Items[nextid].SubItems[4].Text = m_ListView.Items[nextid].SubItems[4].Text.Remove(maxLength);
                            m_ListView.Items[nextid].SubItems[3].Text = m_ListView.Items[nextid].SubItems[4].Text.Replace("\0", "").Length.ToString();
                        }
                        m_ListView.Items[nextid].SubItems[6].Text = Convert.ToString(Convert.ToInt32(m_ListView.Items[nextid].SubItems[6].Text, 16) + count, 16);
                        m_ListView.Items[nextid].SubItems[5].Text = Convert.ToString(Convert.ToInt32(m_ListView.Items[nextid].SubItems[5].Text, 16) + count, 16);
                        m_ListView.Items[nextid].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        m_ListView.SelectedItems[0].SubItems[2].Text = (int.Parse(m_ListView.SelectedItems[0].SubItems[2].Text) + count).ToString();
                        m_ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                        m_ListView_ItemSelectionChanged(sender, new ListViewItemSelectionChangedEventArgs(m_ListView.SelectedItems[0], nextid - 1, true));
                        m_FileEdit = true;
                    }
                }

            }

        }
        private void m_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(m_SelectedItem != e.ItemIndex | sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                m_EditButton.Enabled = true;
                m_TextBox.Enabled = true;
                m_IncreaseMaxSymbolOnLineButton.Enabled = true;
                m_ReduceMaxSymbolOnLineButton.Enabled = true;
                m_NumberSymbolsToChangeTextBox.Enabled = true;

                m_TextBox.Text = e.Item.SubItems[4].Text.Replace("\n", "\r\n");

                if(e.Item.SubItems[7].Text != "")
                {
                    m_TimeTextBox.Enabled = true;
                    m_TimeTextBox.Text = e.Item.SubItems[7].Text;
                }
                else
                {
                    m_TimeTextBox.Text = "";
                    m_TimeTextBox.Enabled = false;
                }
                if(e.Item.SubItems[8].Text != "")
                {
                    m_SwitchingTimeTextBox.Enabled = true;
                    m_SwitchingTimeTextBox.Text = e.Item.SubItems[8].Text;
                }
                else
                {
                    m_SwitchingTimeTextBox.Text = "";
                    m_SwitchingTimeTextBox.Enabled = false;
                }

                m_MaxLengthLabel.Text = $"Max:{e.Item.SubItems[2].Text}";
                m_IdLabel.Text = $"Id:{e.Item.SubItems[0].Text}";
                m_PointerLocationLabel.Text = $"Pointer:{e.Item.SubItems[1].Text}";
                m_GroupIdLabel.Text = $"Group:{e.Item.SubItems[9].Text}";

                m_SelectedItem = e.ItemIndex;
            }
        }

        private void m_TextBox_TextChanged(object sender, EventArgs e)
        {
            int length = m_TextBox.Text.Replace("\r", "").Length;
            int maxLenght = int.Parse(m_ListView.SelectedItems[0].SubItems[2].Text);
            if (length > maxLenght)
            {
                m_TextBox.Text = m_TextBox.Text.Remove(maxLenght);
                m_TextBox.SelectionStart = m_TextBox.Text.Length;
            }

            if (((TextBox)sender).Text.Contains('\r'))
            {
                m_LengthLabel.Text = $"Cur:{length}";
            }
            else
            {
                m_LengthLabel.Text = $"Cur:{m_TextBox.Text.Length}";
            }
        }

        private void m_EditButton_Click(object sender, EventArgs e)
        {
            m_ListView.SelectedItems[0].SubItems[4].Text = m_TextBox.Text.Replace("\r", "");
            m_ListView.SelectedItems[0].SubItems[3].Text = m_TextBox.Text.Replace("\r", "").Length.ToString();
            m_ListView.SelectedItems[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);
            if(m_SwitchingTimeTextBox.Text.Length == 4)
            {
                m_ListView.SelectedItems[0].SubItems[8].Text = m_SwitchingTimeTextBox.Text;
            }
            if(m_TimeTextBox.Text.Length == 2)
            {
                m_ListView.SelectedItems[0].SubItems[7].Text = m_TimeTextBox.Text;
            }
            m_FileEdit = true;
        }
        public void m_SaveInFile(string filePath = "")
        {
            if (m_ListView.Items.Count > 0 & m_FileEdit)
            {
                if(filePath == "")
                {
                    filePath = m_FilePath;
                }
                int count = 0;
                foreach (ListViewItem item in m_ListView.Items)
                {
                    if (item.Font.Bold)
                    {
                        count++;
                    }
                }
                m_ProgressBar.Maximum = count + count + 1;
                m_ProgressBar.Visible = true;
                m_ProgressBar.Value = 0;
                foreach (ListViewItem item in m_ListView.Items)
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

                        Array.Copy(m_CodePage.GetBytes(text), 0, m_File, textAddress, maxLengthText + 1); //text

                        m_File[pointAddress] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(0, 4), 16)); //textaddress
                        m_File[pointAddress + 1] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(0, 2).Remove(2), 16));
                        m_File[pointAddress + 2] = Convert.ToByte(Convert.ToInt32(item.SubItems[5].Text.Remove(2), 16));
                        if (item.SubItems[7].Text != "" & item.SubItems[8].Text != "")
                        {
                            m_File[pointAddress + 4] = Convert.ToByte(Convert.ToInt32(item.SubItems[7].Text, 16)); //time

                            m_File[pointAddress + 8] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(2), 16)); //switchtime
                            m_File[pointAddress + 9] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(0, 2), 16));
                        }
                        m_ProgressBar.Value++;
                    }
                }
                try
                {
                    File.WriteAllBytes(filePath, m_File);
                    m_ProgressBar.Value++;
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
                    foreach (ListViewItem item in m_ListView.Items)
                    {
                        if (item.Font.Bold)
                        {
                            item.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                            m_ProgressBar.Value++;
                        }
                    }
                    m_FilePath = filePath;
                    m_ProgressBar.Visible = false;
                    m_FileEdit = false;
                    MessageBox.Show("Save complete",
                        m_FileName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                
            }
        }
        public void m_ConvertSelectedLines(Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                foreach (ListViewItem item in m_ListView.Items)
                {
                    if(item.Checked == true)
                    {
                        if (item.SubItems[4].Text.Replace("\0", "").Length > 0)
                        {
                            item.SubItems[4].Text = m_ConvertTextFromPattern(item.SubItems[4].Text, hexConverter);
                            item.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                            this.m_FileEdit = true;
                        }
                    }
                }
            }
        }
        public void m_EnableCheckboxesOnListView()
        {
            m_ListView.CheckBoxes = true;
        }
        private string m_ConvertTextFromPattern(string text, Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                return m_ConvertHexToText(m_ConvertTextToHex(text, hexConverter));
            }
            return text;
        }
        private string m_ConvertHexToText(string text)
        {
            byte[] raw = new byte[text.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return m_CodePage.GetString(raw);
        }
        private string m_ConvertTextToHex(string text, Dictionary<string, string> hexConverter = null) 
        {
            string hex = BitConverter.ToString(m_CodePage.GetBytes(text)).Replace("-", "");
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

        public string[] m_GetAllHexText()
        {
            if(m_ListView.Items.Count > 0)
            {
                List<string> hexs = new List<string>();
                foreach (ListViewItem item in m_ListView.Items)
                {
                    hexs.Add(m_ConvertTextToHex(item.SubItems[4].Text.Replace("\0", "")));
                }
                return hexs.ToArray();
            }
            return new string[1] { "54-65-73-74" };
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_FileEdit)
            {
                DialogResult result = MessageBox.Show("The current file has changed. Do you want to close it?",
                    m_FileName,
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
    }
}
