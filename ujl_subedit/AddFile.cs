using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ujl_subedit
{
    public partial class addFile : Form
    {
        public addFile()
        {
            InitializeComponent();
        }
        public class file
        {
            public static string FileName;
            public static string FileInfo;
            public static byte[] filebyte;
            public static string add;
            public static byte[] hex2byte(string hex)
            {

                try
                {
                    hex = hex.Replace("00", "2F").Replace("0A", "23");
                    hex = hex.Replace("-", "");
                    byte[] raw = new byte[hex.Length / 2];
                    for (int i = 0; i < raw.Length; i++)
                    {
                        raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                    }
                    return raw;
                }
                catch
                {
                    MessageBox.Show("Error");
                    return new byte[1];
                }
            }
        }
        private void AddFile_Load(object sender, EventArgs e)
        {
            Start.Enabled = false;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using(Stream str = openFileDialog1.OpenFile())
                    {
                        file.FileName = openFileDialog1.SafeFileName;
                        byte[] bitarray = new byte[str.Length];
                        str.Read(bitarray, 0, bitarray.Length);
                        file.filebyte = bitarray;
                        str.Close();
                        Open.Enabled = false;
                        Start.Enabled = true;
                        encodeText.Enabled  = false;
                        this.Text = file.FileName;
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void getFileInfo()
        {
            GetFileInfo get = new GetFileInfo();
            get.Owner = this;
            get.ShowDialog();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            int startAddress = 1;
            int countSymbol = 0;
            bool da = true;
            int nullSymbol = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("subtitle.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement File = xDoc.CreateElement("file");
            XmlAttribute fileName = xDoc.CreateAttribute("name");
            XmlElement fileInfo = xDoc.CreateElement("fileInfo");
            XmlElement subTitle = xDoc.CreateElement("subTitle");

            //string amogus = xDoc.SelectSingleNode("count(/subtitle/file[@name='" + file.FileName + "'])").Value;
            if (xDoc.SelectSingleNode("/subtitle/file[@name='"+ file.FileName + "']") == null)
            {
                XmlText fileNameText = xDoc.CreateTextNode(file.FileName);
                getFileInfo();
                XmlText fileInfoText = xDoc.CreateTextNode(file.FileInfo);
                fileName.AppendChild(fileNameText);
                fileInfo.AppendChild(fileInfoText);
                File.Attributes.Append(fileName);
                File.AppendChild(fileInfo);
                File.AppendChild(subTitle);
                numberLines.Text = 0.ToString();
            }
            else
            {
                numberLines.Text = xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/subTitle").ChildNodes.Count.ToString();
                xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText = xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText.Replace(numberLines.Text, "");
                xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText = xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText.Replace(" -  lines", "");
            }
            try
            {
                startAddress = Int32.Parse(FirstAddress.Text);
            }
            catch
            {
                MessageBox.Show("Only number");
                return;
            }
            for (int i = startAddress; i < file.filebyte.Length; i++)
            {
                if(file.filebyte[i] != 0)
                {
                    countSymbol++;
                }
                if(file.filebyte[i] == 0 && da == true)
                {
                    da = false;
                    while (file.filebyte[i + nullSymbol + 1] == 0)
                    {
                        nullSymbol++;
                    }
                    countSymbol = countSymbol + nullSymbol;
                    LengthLine.Text = countSymbol.ToString();
                    encodeText.Text = System.Text.Encoding.Default.GetString(file.hex2byte(BitConverter.ToString(file.filebyte, i - countSymbol + nullSymbol, countSymbol)));
                    FirstAddress.Text = (i - countSymbol + nullSymbol).ToString();

                    Choice choice = new Choice();
                    choice.Owner = this;
                    choice.ShowDialog();
                    if(file.add == "true")
                    {
                        XmlText addressText = xDoc.CreateTextNode((i - countSymbol + nullSymbol).ToString());
                        XmlText lengthText = xDoc.CreateTextNode(countSymbol.ToString());

                        

                        if(xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']") != null)
                        {
                            int count = xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/subTitle").ChildNodes.Count;
                            bool include = false;
                            for (int j = 1; j <= count; j++)
                            {
                                if (Int32.Parse(xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/subTitle/sub[" + j + "]/address").InnerText) == Int32.Parse(addressText.InnerText))
                                {
                                    include = true;
                                }
                            }
                            if(include == false) 
                            {
                                XmlElement sub = xDoc.CreateElement("sub");
                                XmlElement address = xDoc.CreateElement("address");
                                XmlElement length = xDoc.CreateElement("length");
                                subTitle.AppendChild(sub);
                                address.AppendChild(addressText);
                                length.AppendChild(lengthText);
                                xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/subTitle").AppendChild(sub);
                                sub.AppendChild(address);
                                sub.AppendChild(length);
                                numberLines.Text = (Int32.Parse(numberLines.Text) + 1).ToString();
                            }
                        }
                        else
                        {
                            XmlElement sub = xDoc.CreateElement("sub");
                            XmlElement address = xDoc.CreateElement("address");
                            XmlElement length = xDoc.CreateElement("length");
                            subTitle.AppendChild(sub);
                            address.AppendChild(addressText);
                            length.AppendChild(lengthText);
                            subTitle.AppendChild(sub);
                            sub.AppendChild(address);
                            sub.AppendChild(length);
                            numberLines.Text = (Int32.Parse(numberLines.Text) + 1).ToString();
                        }
                        da = true;
                        i = i + nullSymbol;
                        countSymbol = 0;
                        nullSymbol = 0;
                    }
                    else if(file.add == "false")
                    {
                        da = true;
                        i = i + nullSymbol;
                        countSymbol = 0;
                        nullSymbol = 0;
                    }
                    else if (file.add == "stop")
                    {
                        i = file.filebyte.Length;
                        if (xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo") != null)
                        {
                            xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText = xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']/fileInfo").InnerText + " - " + numberLines.Text + " lines";
                        }
                    }
                    
                }

            }
            if (xDoc.SelectSingleNode("/subtitle/file[@name='" + file.FileName + "']") == null)
            {
                xRoot?.AppendChild(File);
            }
            xDoc.Save("subtitle.xml");
        }

    }
}
