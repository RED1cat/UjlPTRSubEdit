using System;
using System.Xml;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace ujl_subedit
{
    public static class FuncExtension
    {
        public static XmlDocument LoadXmlDoc(this XmlDocument xDoc, string xml)
        {
            xDoc.LoadXml(xml);
            return xDoc;
        }
        public static Image LoadImageFromBase64(this string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
        public static PrivateFontCollection LoadFontFromBase64(this PrivateFontCollection font, string base64, string name)
        {
            try
            {
                if (Directory.Exists(Editor.m_TempFile) == false)
                {
                    Directory.CreateDirectory(Editor.m_TempFile);
                }
                if (System.IO.File.Exists(Editor.m_TempFile + "\\" + name) == true)
                {
                    font.AddFontFile(Editor.m_TempFile + "\\" + name);
                }
                else
                {
                    using (FileStream dom = System.IO.File.Create(Editor.m_TempFile + "\\" + name))
                    {
                        byte[] bytes = Convert.FromBase64String(base64);
                        dom.Write(bytes, 0, bytes.Length);
                        dom.Close();
                    }
                    font.AddFontFile(Editor.m_TempFile + "\\" + name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return font;
        }
        public static string Decrypt(this string hex)
        {
            if (hex.Length > 1)
            {
                hex = hex.Replace("46", "C0").Replace("4F", "C1").Replace("44", "C2").Replace("55", "C3").Replace("4C", "C4").Replace("54", "C5").Replace("51", "C6").Replace("50", "C7").Replace("42", "C8").Replace("52", "CA").Replace("56", "CC").Replace("59", "CD").Replace("4A", "CE").Replace("47", "CF").Replace("48", "D0").Replace("43", "D1").Replace("4E", "D2").Replace("45", "D3").Replace("41", "D4").Replace("2A", "D5").Replace("57", "D6").Replace("58", "D7").Replace("49", "D8").Replace("49", "D9").Replace("73", "DB").Replace("53", "DD").Replace("4D", "DE").Replace("5A", "DF").Replace("66", "E0").Replace("6F", "E1").Replace("75", "E3").Replace("6C", "E4").Replace("74", "E5").Replace("71", "E6").Replace("70", "E7").Replace("76", "EC").Replace("79", "ED").Replace("6A", "EE").Replace("67", "EF").Replace("68", "F0").Replace("63", "F1").Replace("6E", "F2").Replace("65", "F3").Replace("61", "F4").Replace("2A", "F5").Replace("77", "F6").Replace("78", "F7").Replace("49", "F8").Replace("49", "F9").Replace("E9", "FA").Replace("73", "FB").Replace("6D", "FC").Replace("53", "FD").Replace("4D", "FE").Replace("7A", "FF").Replace("E2", "DC").Replace("E9", "DA").Replace("EB", "B8").Replace("64", "E2").Replace("EA", "E9").Replace("72", "EA").Replace("6B", "EB").Replace("E8", "C9").Replace("62", "E8").Replace("CB", "A8").Replace("4B", "CB");
                //hex = hex.Replace("46","C0").Replace( "4F","C1").Replace("44","C2").Replace("55","C3").Replace("4C","C4").Replace("54","C5").Replace("51","C6").Replace("50","C7").Replace("42","C8").Replace("52","CA").Replace("56","CC").Replace("59","CD").Replace("4A","CE").Replace("47","CF").Replace("48","D0").Replace("43","D1").Replace("4E","D2").Replace("45","D3").Replace("41","D4").Replace("2A","D5").Replace("57","D6").Replace("58","D7").Replace("49","D8").Replace("49","D9").Replace("73","DB").Replace("53","DD").Replace("4D","DE").Replace("5A","DF").Replace("66","E0").Replace("6F","E1").Replace("75","E3").Replace("6C","E4").Replace("74","E5").Replace("71","E6").Replace("70","E7").Replace("76","EC").Replace("79","ED").Replace("6A","EE").Replace("67","EF").Replace("68","F0").Replace("63","F1").Replace("6E","F2").Replace("65","F3").Replace("61","F4").Replace("2A","F5").Replace("77","F6").Replace("78","F7").Replace("49","F8").Replace("49","F9").Replace("E9","FA").Replace("73","FB").Replace("6D","FC").Replace("53","FD").Replace("4D","FE").Replace("7A","FF").Replace("E2","DC").Replace("E9","DA").Replace("EB","B8").Replace("64", "E2").Replace("EA", "E9").Replace("72", "EA").Replace("6B", "EB").Replace("E8", "C9").Replace("62", "E8").Replace("CB", "A8").Replace("4B", "CB");
            }
            return hex;
        }
        public static byte[] Hex2byte(this string hex,  bool toRus = false, int num = 0)
        {
            if (toRus == true & hex.Length > 1)
            {
                hex = hex.Replace("C0", "46").Replace("C1", "4F").Replace("C2", "44").Replace("C3", "55").Replace("C4", "4C").Replace("C5", "54").Replace("C6", "51").Replace("C7", "50").Replace("C8", "42").Replace("CA", "52").Replace("CB", "4B").Replace("CC", "56").Replace("CD", "59").Replace("CE", "4A").Replace("CF", "47").Replace("D0", "48").Replace("D1", "43").Replace("D2", "4E").Replace("D3", "45").Replace("D4", "41").Replace("D5", "2A").Replace("D6", "57").Replace("D7", "58").Replace("D8", "49").Replace("D9", "49").Replace("DB", "73").Replace("DD", "53").Replace("DE", "4D").Replace("DF", "5A").Replace("E0", "66").Replace("E1", "6F").Replace("E2", "64").Replace("E3", "75").Replace("E4", "6C").Replace("E5", "74").Replace("E6", "71").Replace("E7", "70").Replace("E8", "62").Replace("EA", "72").Replace("E9", "EA").Replace("EB", "6B").Replace("EC", "76").Replace("ED", "79").Replace("EE", "6A").Replace("EF", "67").Replace("F0", "68").Replace("F1", "63").Replace("F2", "6E").Replace("F3", "65").Replace("F4", "61").Replace("F5", "2A").Replace("F6", "77").Replace("F7", "78").Replace("F8", "49").Replace("F9", "49").Replace("FA", "E9").Replace("FB", "73").Replace("FC", "6D").Replace("FD", "53").Replace("FE", "4D").Replace("FF", "7A").Replace("A8", "CB").Replace("C9", "E8").Replace("DC", "E2").Replace("DA", "E9").Replace("B8", "EB");

            }

            try
            {
                hex = hex.Replace("-", "");
                byte[] raw = new byte[hex.Length / 2];
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                if (raw.Length < num)
                {
                    Array.Resize(ref raw, num);
                }
                return raw;
            }
            catch
            {
                return new byte[1];
            }
            
        }
        public static XmlDocument OpenXmlDoc(this XmlDocument xDoc, string docPath)
        {
            if(System.IO.File.Exists(docPath) == true)
            {
                xDoc.Load(docPath);
            }
            else
            {
                throw new Exception($"Xml file not found '{docPath}'");
            }
            return xDoc;
        }
        public static XmlNode GetXmlNode(this XmlDocument xDoc, string fileName, string region, string parametr, int subId = 0, int langId = 0, int id = 0)
        {
            if (parametr == "GetsubTitleNodeById")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle[" + id + "]");
            }
            else if (parametr == "GetsubTitleNode")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle");
            }
            else if (parametr == "GetfileInfoNode")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/fileInfo");
            }
            else if (parametr == "GetaddressNodeUsa")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle/sub[" + subId + "]/address");
            }
            else if (parametr == "GetlengthNodeUsa")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle/sub[" + subId + "]/length");
            }
            else if (parametr == "GetaddressNodeEur")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle[" + langId + "]/sub[" + subId + "]/address");
            }
            else if (parametr == "GetlengthNodeEur")
            {
                return xDoc.SelectSingleNode("/subtitle/file[@name='" + fileName + "'][@region='" + region + "']/subTitle[" + langId + "]/sub[" + subId + "]/length");
            }
            else
            {
                throw new Exception("Error: no 'parametr' for 'GetXmlNode' function");
            }
        }
        public static TextBox GetTextBoxById(this TabPage tab, int i, string parametr)
        {
            if (parametr == "Hex")
            {
                foreach (Control hex in tab.Controls)
                {
                    if (hex is TextBox && hex.Name.Replace("Hex", "") == i.ToString())
                    {
                        TextBox _hex = (TextBox)hex;
                        return _hex;
                    }
                }
            }
            else if (parametr == "Text")
            {
                foreach (Control text in tab.Controls)
                {
                    if (text is TextBox && text.Name.Replace("Text", "") == i.ToString())
                    {
                        TextBox _text = (TextBox)text;
                        return _text;
                    }
                }
            }
            return null;
        }
        public static Label GetLabelById(this TabPage tab, int i, string parametr)
        {
            if(parametr == "Length")
            {
                foreach(Control length in tab.Controls)
                {
                    if(length is Label && length.Name.Replace("Length", "") == i.ToString())
                    {
                        Label _length = (Label)length;
                        return _length;
                    }
                }
            }
            if(parametr == "Last")
            {
                foreach(Control last in tab.Controls)
                {
                    if(last is Label && last.Name.Replace("Last", "") == i.ToString())
                    {
                        Label _last = (Label)last;
                        return _last;
                    }
                }
            }
            return null;
        }
        public static TabPage CreateTabPage(this TabPage tab, string name, string text = null, string fileName = null, string region = null)
        {
            tab.Name = name;
            tab.BackColor = Color.FromArgb(217, 219, 214);
            tab.AutoScroll = true;
            if (fileName != null && region != null)
            {
                if (Editor.m_XDocUjlUsa.GetXmlNode(fileName, region, "GetfileInfoNode") != null)
                {
                    tab.Text = Editor.m_XDocUjlUsa.GetXmlNode(fileName, region, "GetfileInfoNode").InnerText + " - " + region;
                }
                else if(Editor.m_XDocUjlEurope.GetXmlNode(fileName, region, "GetfileInfoNode") != null)
                {
                    tab.Text = Editor.m_XDocUjlEurope.GetXmlNode(fileName, region, "GetfileInfoNode").InnerText + " - " + region;
                }
                else
                {
                    tab.Text = "Editor";
                }
            }
            else if (text != null)
            {
                tab.Text = text;
            }
            return tab;
        }

    }
}
