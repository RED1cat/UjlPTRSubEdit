using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;

namespace ujl_subedit
{
    public partial class Open_File : Form
    {
        public Open_File()
        {
            InitializeComponent();
        }
        public class OpenFile
        {
            public static string FilePath;
            public static string FileName;
            public static int Filelength;
            public static byte[] hex2byte(string hex)
            {
                hex = hex.Replace("-", "");
                byte[] raw = new byte[hex.Length / 2];
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                return raw;
            }
            public static byte[] hex2byte2save(string hex, int num)
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
        }

        private void button1_Click(object sender, EventArgs e)
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
                        if (OpenFile.FileName == "COMOD11.SNG" || OpenFile.FileName == "COMOD0.MEN" || OpenFile.FileName == "COMOD6.SNG" || OpenFile.FileName == "COMOD16.SNG" || OpenFile.FileName == "COMOD16.CMP" || OpenFile.FileName == "COMOD6.CMP")
                        {
                            Editor editor = new Editor();
                            editor.Owner = this;
                            editor.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Wrong file");
                        }

                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Open_File_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("There is no help");
        }
    }
}
