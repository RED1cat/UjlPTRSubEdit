using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ujl_subedit
{
    public partial class Editor : Form
    {
        public string m_FileName;
        public string m_FilePath;
        public byte[] m_File;
        public int m_selectedItem;
        private ToolStripProgressBar m_progressBar;
        
        public Editor(ToolStripProgressBar progressBar)
        {
            m_progressBar = progressBar;
            InitializeComponent();
            m_Panel.AutoScroll = true;
            m_Panel.HorizontalScroll.Enabled = false;
            m_Panel.HorizontalScroll.Visible = false;
        }

        public void m_DecodeFile()
        {
            if (this.m_FilePath != null)
            {
                this.Text = m_FileName;
                int id = 1;
                int maxid = 0;
                m_progressBar.Visible = true;

                for (int i = 0; i < this.m_File.Length; i++)
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
                m_progressBar.Maximum = maxid;
                m_progressBar.Value = 0;

                for (int i = 0; i < this.m_File.Length; i++)
                {
                    if (this.m_File[i] == 0x80)
                    {
                        if (this.m_File[i + 2] == 0 & this.m_File[i + 3] == 0 & this.m_File[i + 4] == 0 & this.m_File[i + 7] == 0 & this.m_File[i + 8] == 0 || this.m_File[i - 1] != 0 & this.m_File[i - 2] != 0 & this.m_File[i - 3] != 0)
                        {
                            byte[] address = new byte[3] { this.m_File[i - 1], this.m_File[i - 2], this.m_File[i - 3]};
                            int textaddressInFile = Convert.ToInt32(BitConverter.ToString(address, 0, 3).Replace("-", ""), 16) - 1857360;
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

                                if(this.m_File[i + 4] == 0x80 | this.m_File[i - 4] == 0x80)
                                {
                                    m_AddLineToListView(id, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, Encoding.Default.GetString(this.m_File, textaddressInFile, count));
                                    id++;
                                    m_progressBar.Value++;
                                }
                                else if(this.m_File[i + 12] == 0x80 | this.m_File[i - 12] == 0x80)
                                {
                                    m_AddLineToListView(id, Convert.ToString(i - 3, 16), Convert.ToString(textaddressInGame, 16), Convert.ToString(textaddressInFile, 16), count, Encoding.Default.GetString(this.m_File, textaddressInFile, count), BitConverter.ToString(this.m_File, i + 1, 1), BitConverter.ToString(this.m_File, i + 5, 2).Replace("-", ""));
                                    id++;
                                    m_progressBar.Value++;
                                }
                            }
                        }
                    }
                }
                m_progressBar.Visible = false;
            }
        }
        public void m_AddLineToListView(int id, string pointLocation, string textLocationInGame , string textLocationInFile,  int maxTextLength, string text, string time = "", string switchingTime = "")
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
        }

        private void m_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(m_selectedItem != e.ItemIndex)
            {
                m_EditButton.Enabled = true;
                m_TextBox.Enabled = true;
                m_TextBox.Text = e.Item.SubItems[4].Text.Replace("\n", "\r\n");
                m_MaxLengthLabel.Text = $"Max:{e.Item.SubItems[2].Text}";
                m_IdLabel.Text = $"Id:{e.Item.SubItems[0].Text}";
                m_PointerLocationLabel.Text = $"Pointer:{e.Item.SubItems[1].Text}";
                m_selectedItem = e.ItemIndex;
            }
        }

        private void m_TextBox_TextChanged(object sender, EventArgs e)
        {
            int length = m_TextBox.Text.Replace("\r", "").Length;
            int maxLenght = int.Parse(m_ListView.SelectedItems[0].SubItems[2].Text);
            if (length > maxLenght)
            {
                m_TextBox.Text = m_TextBox.Text.Remove(maxLenght);
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
            m_ListView.SelectedItems[0].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }
        public void m_SaveInFile(string filePath)
        {
            if (m_ListView.Items.Count > 0)
            {
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
                            while(text.Length != maxLengthText)
                            {
                                text = text.Insert(text.Length, "\0");
                            }
                        }
                        Array.Copy(Encoding.Default.GetBytes(text), 0, m_File, textAddress, maxLengthText); //text
                        if (item.SubItems[7].Text != "" & item.SubItems[8].Text != "")
                        {
                            m_File[pointAddress + 4] = Convert.ToByte(Convert.ToInt32(item.SubItems[7].Text, 16)); //time

                            m_File[pointAddress + 8] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(2), 16)); //switchtime
                            m_File[pointAddress + 9] = Convert.ToByte(Convert.ToInt32(item.SubItems[8].Text.Remove(0, 2), 16));
                        }
                    }
                }
                File.WriteAllBytes(filePath, m_File);
            }
        }
    }
}
