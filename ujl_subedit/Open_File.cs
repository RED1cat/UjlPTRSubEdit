using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Xml;

namespace ujl_subedit
{
    public partial class Open_File : Form
    {
        public Open_File()
        {
            InitializeComponent();
            xDocInit();
            fontinit();
            dragAndDropInit();
        }

        public class OpenFile
        {
            public static bool debug = false;
            public static XmlDocument xDoc = new XmlDocument();
            public static PrivateFontCollection DomFont = new PrivateFontCollection();
            public static string FilePath;
            public static string FileName;
            public static int Filelength;
            public static bool Torus;
            public static bool Decryptrus;
            public static bool SymbolConverter;
            public static string Decrypt(string hex)
            {
                if (hex.Length > 1)
                {
                    hex = hex.Replace("46", "C0").Replace("4F", "C1").Replace("44", "C2").Replace("55", "C3").Replace("4C", "C4").Replace("54", "C5").Replace("51", "C6").Replace("50", "C7").Replace("42", "C8").Replace("52", "CA").Replace("56", "CC").Replace("59", "CD").Replace("4A", "CE").Replace("47", "CF").Replace("48", "D0").Replace("43", "D1").Replace("4E", "D2").Replace("45", "D3").Replace("41", "D4").Replace("2A", "D5").Replace("57", "D6").Replace("58", "D7").Replace("49", "D8").Replace("49", "D9").Replace("73", "DB").Replace("53", "DD").Replace("4D", "DE").Replace("5A", "DF").Replace("66", "E0").Replace("6F", "E1").Replace("75", "E3").Replace("6C", "E4").Replace("74", "E5").Replace("71", "E6").Replace("70", "E7").Replace("76", "EC").Replace("79", "ED").Replace("6A", "EE").Replace("67", "EF").Replace("68", "F0").Replace("63", "F1").Replace("6E", "F2").Replace("65", "F3").Replace("61", "F4").Replace("2A", "F5").Replace("77", "F6").Replace("78", "F7").Replace("49", "F8").Replace("49", "F9").Replace("E9", "FA").Replace("73", "FB").Replace("6D", "FC").Replace("53", "FD").Replace("4D", "FE").Replace("7A", "FF").Replace("E2", "DC").Replace("E9", "DA").Replace("EB", "B8").Replace("64", "E2").Replace("EA", "E9").Replace("72", "EA").Replace("6B", "EB").Replace("E8", "C9").Replace("62", "E8").Replace("CB", "A8").Replace("4B", "CB");
                    //hex = hex.Replace("46","C0").Replace( "4F","C1").Replace("44","C2").Replace("55","C3").Replace("4C","C4").Replace("54","C5").Replace("51","C6").Replace("50","C7").Replace("42","C8").Replace("52","CA").Replace("56","CC").Replace("59","CD").Replace("4A","CE").Replace("47","CF").Replace("48","D0").Replace("43","D1").Replace("4E","D2").Replace("45","D3").Replace("41","D4").Replace("2A","D5").Replace("57","D6").Replace("58","D7").Replace("49","D8").Replace("49","D9").Replace("73","DB").Replace("53","DD").Replace("4D","DE").Replace("5A","DF").Replace("66","E0").Replace("6F","E1").Replace("75","E3").Replace("6C","E4").Replace("74","E5").Replace("71","E6").Replace("70","E7").Replace("76","EC").Replace("79","ED").Replace("6A","EE").Replace("67","EF").Replace("68","F0").Replace("63","F1").Replace("6E","F2").Replace("65","F3").Replace("61","F4").Replace("2A","F5").Replace("77","F6").Replace("78","F7").Replace("49","F8").Replace("49","F9").Replace("E9","FA").Replace("73","FB").Replace("6D","FC").Replace("53","FD").Replace("4D","FE").Replace("7A","FF").Replace("E2","DC").Replace("E9","DA").Replace("EB","B8").Replace("64", "E2").Replace("EA", "E9").Replace("72", "EA").Replace("6B", "EB").Replace("E8", "C9").Replace("62", "E8").Replace("CB", "A8").Replace("4B", "CB");
                }
                return hex;
            }
            public static byte[] hex2byte(string hex)
            {
                
                try
                {
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
            public static byte[] hex2byte2save(string hex, int num)
            {
                if (Torus == true & hex.Length > 1)
                {
                    hex = hex.Replace("C0", "46").Replace("C1", "4F").Replace("C2", "44").Replace("C3", "55").Replace("C4", "4C").Replace("C5", "54").Replace("C6", "51").Replace("C7", "50").Replace("C8", "42").Replace("CA", "52").Replace("CB", "4B").Replace("CC", "56").Replace("CD", "59").Replace("CE", "4A").Replace("CF", "47").Replace("D0", "48").Replace("D1", "43").Replace("D2", "4E").Replace("D3", "45").Replace("D4", "41").Replace("D5", "2A").Replace("D6", "57").Replace("D7", "58").Replace("D8", "49").Replace("D9", "49").Replace("DB", "73").Replace("DD", "53").Replace("DE", "4D").Replace("DF", "5A").Replace("E0", "66").Replace("E1", "6F").Replace("E2", "64").Replace("E3", "75").Replace("E4", "6C").Replace("E5", "74").Replace("E6", "71").Replace("E7", "70").Replace("E8", "62").Replace("EA", "72").Replace("E9", "EA").Replace("EB", "6B").Replace("EC", "76").Replace("ED", "79").Replace("EE", "6A").Replace("EF", "67").Replace("F0", "68").Replace("F1", "63").Replace("F2", "6E").Replace("F3", "65").Replace("F4", "61").Replace("F5", "2A").Replace("F6", "77").Replace("F7", "78").Replace("F8", "49").Replace("F9", "49").Replace("FA", "E9").Replace("FB", "73").Replace("FC", "6D").Replace("FD", "53").Replace("FE", "4D").Replace("FF", "7A").Replace("A8", "CB").Replace("C9", "E8").Replace("DC", "E2").Replace("DA", "E9").Replace("B8", "EB");

                }

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
        }

        private void fontinit()
        {
            if (File.Exists("SysFile//DomBold.ttf") == true && File.Exists("SysFile//DomCasual.ttf") == true)
            {
                OpenFile.DomFont.AddFontFile("SysFile//DomBold.ttf"); //dom.families[0]
                OpenFile.DomFont.AddFontFile("SysFile//DomCasual.ttf"); //dom.families[1]
                label1.Font = new Font(OpenFile.DomFont.Families[1], 12);
                label2.Font = new Font(OpenFile.DomFont.Families[1], 12);
                symbleConverter.Font = new Font(OpenFile.DomFont.Families[0], 12);
            }
            else
            {
                MessageBox.Show("fonts not found");
            }
        }
        private void xDocInit()
        {
            if(File.Exists("SysFile//subtitle.xml") == true)
            {
                OpenFile.xDoc.Load("SysFile//subtitle.xml");
            }
            else
            {
                MessageBox.Show("'subtitle.xml' not found");
                this.Close();
            }
        }

        //openFile
        private void button1_Click(object sender, EventArgs e)
        {
            if(OpenFile.debug == true)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    OpenFile.Decryptrus = true;
                }
                else
                {
                    OpenFile.Decryptrus = false;
                }
            }

            if (symbleConverter.Checked == true)
            {
                OpenFile.SymbolConverter = true;
            }
            else
            {
                OpenFile.SymbolConverter = false;
            }

            openFileDialog();
        }
        private void openFileDialog(string arg = null)
        {
            if (arg == null)
            {
                openFileDialog1.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu File (*.MEN)|*.MEN|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        OpenFile.FilePath = openFileDialog1.FileName;
                        using (Stream str = openFileDialog1.OpenFile())
                        {
                            OpenFile.FileName = openFileDialog1.SafeFileName;
                            str.Close();
                            openEditorDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return;
                    }
                }
            }
            else if (arg != null)
            {
                OpenFile.FilePath = arg;
                OpenFile.FileName = System.IO.Path.GetFileName(arg);
                openEditorDialog();
            }
        }
        private void openEditorDialog()
        {
            bool include = false;
            int count = OpenFile.xDoc.SelectSingleNode("/subtitle").ChildNodes.Count;

            for (int i = 1; i <= count; i++)
            {
                if (OpenFile.xDoc.SelectSingleNode("/subtitle/file[" + i + "][@name='" + OpenFile.FileName + "']") != null)
                {
                    include = true;
                }
            }
            if (include == true)
            {
                Editor editor = new Editor();
                editor.Owner = this;
                editor.ShowDialog();

            }
            else
            {
                MessageBox.Show("File not support");
                return;
            }
        }

        //helpButton
        private void button2_Click(object sender, EventArgs e)
        {
            if(OpenFile.debug == true)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    addFile addFile = new addFile();
                    addFile.Owner = this;
                    addFile.ShowDialog();
                }
            }
            else
            {
                System.Diagnostics.Process.Start("https://github.com/RED1cat/UjlSubEdit/blob/master/README.md");
            }
        }

        //drag and drop
        private void dragAndDropInit()
        {
            this.DragEnter += eventDragEnter;
            this.DragDrop += eventDragDrop;
        }
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
            foreach(string file in files)
            {
                openFileDialog(file);
                return;
            }
        }

    }
}
