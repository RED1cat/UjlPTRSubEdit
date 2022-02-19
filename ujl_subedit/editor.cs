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
    public partial class editor : Form
    {
        public class COMOD11_SNG_info
        {
            public const int length = 143968;

            //катсцена
            public const int Hex1_address = 111744; //text1 адресс-111744 длина-35
            public const int Hex1_length = 35;

            public const int Hex2_address = 111780; //text2 адресс-111780 длина-27
            public const int Hex2_length = 27;

            public const int Hex3_address = 111808; //text3 адресс-111808 длина-51
            public const int Hex3_length = 51;

            public const int Hex4_address = 111860; //text4 адресс-111860 длина-51
            public const int Hex4_length = 51;

            public const int Hex5_address = 111912; //text5 адресс-111912 длина-39
            public const int Hex5_length = 39;

            public const int Hex6_address = 111952; //text6 адресс-111952 длина-43
            public const int Hex6_length = 43;

            public const int Hex7_address = 111996; //text7 адресс-111996 длина-15
            public const int Hex7_length = 15;

            public const int Hex8_address = 112012; //text8 адресс-112012 длина-19
            public const int Hex8_length = 19;

            public const int Hex9_address = 112032; //text9 адресс-112032 длина-19
            public const int Hex9_length = 19;

            public const int Hex10_address = 112052; //text10 адресс-112052 длина-31
            public const int Hex10_length = 31;

            public const int Hex11_address = 112084; //text11 адресс-112084 длина-27
            public const int Hex11_length = 27;

            public const int Hex12_address = 112112; //text12 адресс-112112 длина-19
            public const int Hex12_length = 19;

            public const int Hex13_address = 112132; //text13 адресс-112132 длина-15
            public const int Hex13_length = 15;

            public const int Hex14_address = 112148; //text14 адресс-112148 длина-23
            public const int Hex14_length = 23;

            //геймплей
            public const int Hex15_address = 114708; //text15 адресс-114708 длина-31
            public const int Hex15_length = 31;

            public const int Hex16_address = 114740;
            public const int Hex16_length = 35;

            public const int Hex17_address = 114776;
            public const int Hex17_length = 39;

            public const int Hex18_address = 114816;
            public const int Hex18_length = 35;

            public const int Hex19_address = 114852;
            public const int Hex19_length = 7;

            public const int Hex20_address = 114860;
            public const int Hex20_length = 7;

            public const int Hex21_address = 114868;
            public const int Hex21_length = 7;

            public const int Hex22_address = 114876;
            public const int Hex22_length = 11;

            public const int Hex23_address = 114888;
            public const int Hex23_length = 11;

            public const int Hex24_address = 114900;
            public const int Hex24_length = 11;

            public const int Hex25_address = 114912;
            public const int Hex25_length = 7;

            public const int Hex26_address = 114920;
            public const int Hex26_length = 7;

            public const int Hex27_address = 114928;
            public const int Hex27_length = 7;

            public const int Hex28_address = 114936;
            public const int Hex28_length = 11;

            public const int Hex29_address = 114948;
            public const int Hex29_length = 11;

            public const int Hex30_address = 114960;
            public const int Hex30_length = 35;

            public const int Hex31_address = 114996;
            public const int Hex31_length = 35;

            public const int Hex32_address = 115032;
            public const int Hex32_length = 35;

            public const int Hex33_address = 115068;
            public const int Hex33_length = 35;

            public const int Hex34_address = 115104;
            public const int Hex34_length = 47;

            public const int Hex35_address = 115152;
            public const int Hex35_length = 47;

            public const int Hex36_address = 115200;
            public const int Hex36_length = 43;

            public const int Hex37_address = 115244;
            public const int Hex37_length = 43;

            public const int Hex38_address = 115288;
            public const int Hex38_length = 47;

            public const int Hex39_address = 115336;
            public const int Hex39_length = 47;

            public const int Hex40_address = 115384;
            public const int Hex40_length = 31;

            public const int Hex41_address = 115416;
            public const int Hex41_length = 31;

            public const int Hex42_address = 115448;
            public const int Hex42_length = 39;

            public const int Hex43_address = 115528;
            public const int Hex43_length = 43;

            public const int Hex44_address = 115572;
            public const int Hex44_length = 43;

            public const int Hex45_address = 115616;
            public const int Hex45_length = 11;

            public const int Hex46_address = 115628;
            public const int Hex46_length = 11;

            public const int Hex47_address = 115640;
            public const int Hex47_length = 11;

            public const int Hex48_address = 115652;
            public const int Hex48_length = 11;

            public const int Hex49_address = 115664;
            public const int Hex49_length = 11;

            public const int Hex50_address = 115676;
            public const int Hex50_length = 11;

            public const int Hex51_address = 115688;
            public const int Hex51_length = 11;

            public const int Hex52_address = 115700;
            public const int Hex52_length = 11;

            public const int Hex53_address = 115712;
            public const int Hex53_length = 15;

            public const int Hex54_address = 115728;
            public const int Hex54_length = 15;

            public const int Hex55_address = 115744;
            public const int Hex55_length = 43;

            public const int Hex56_address = 115788;
            public const int Hex56_length = 43;

            public const int Hex57_address = 115832;
            public const int Hex57_length = 35;

            public const int Hex58_address = 115868;
            public const int Hex58_length = 35;

            public const int Hex59_address = 115904;
            public const int Hex59_length = 43;

            public const int Hex60_address = 115948;
            public const int Hex60_length = 43;

            public const int Hex61_address = 115992;
            public const int Hex61_length = 43;

            public const int Hex62_address = 116036;
            public const int Hex62_length = 43;

            public const int Hex63_address = 116080;
            public const int Hex63_length = 7;

            public const int Hex64_address = 116088;
            public const int Hex64_length = 11;

            public const int Hex65_address = 116100;
            public const int Hex65_length = 7;

            public const int Hex66_address = 116108;
            public const int Hex66_length = 11;

            public const int Hex67_address = 116120;
            public const int Hex67_length = 15;

            public const int Hex68_address = 116136;
            public const int Hex68_length = 15;

            public const int Hex69_address = 116152;
            public const int Hex69_length = 15;

            public const int Hex70_address = 116168;
            public const int Hex70_length = 15;

            public const int Hex71_address = 116184;
            public const int Hex71_length = 15;

            public const int Hex72_address = 116200;
            public const int Hex72_length = 23;

            public const int Hex73_address = 116224;
            public const int Hex73_length = 15;

            public const int Hex74_address = 116240;
            public const int Hex74_length = 15;

            public const int Hex75_address = 116256;
            public const int Hex75_length = 19;

            public const int Hex76_address = 116276;
            public const int Hex76_length = 15;

            public const int Hex77_address = 116292;
            public const int Hex77_length = 35;

            public const int Hex78_address = 116328;
            public const int Hex78_length = 27;

            //катсцена
            public const int Hex79_address = 117148;
            public const int Hex79_length = 7;

            public const int Hex80_address = 117156;
            public const int Hex80_length = 31;

            public const int Hex81_address = 117224;
            public const int Hex81_length = 51;

            public const int Hex82_address = 117276;
            public const int Hex82_length = 51;

            public const int Hex83_address = 117328;
            public const int Hex83_length = 31;

            public const int Hex84_address = 117408;
            public const int Hex84_length = 27;

            public const int Hex85_address = 117436;
            public const int Hex85_length = 35;

            public const int Hex86_address = 117472;
            public const int Hex86_length = 27;

            public const int Hex87_address = 117548;
            public const int Hex87_length = 23;

            public const int Hex88_address = 117572;
            public const int Hex88_length = 23;

            public const int Hex89_address = 117632;
            public const int Hex89_length = 27;

            public const int Hex90_address = 117660;
            public const int Hex90_length = 35;

        }
        public editor()
        {
            InitializeComponent();
            start_file();
            using (FileStream fstream = File.OpenRead(Open_File.OpenFile.FilePath))
            {
                //file2byte
                byte[] bitarray = new byte[fstream.Length];
                fstream.Read(bitarray, 0, bitarray.Length);
                file.save = bitarray;

                //hex1
                Hex1.MaxLength = file.hex1_length*2+(file.hex1_length - 1);
                Text1.MaxLength = file.hex1_length;

                Hex1.Text = BitConverter.ToString(bitarray, file.hex1_address, file.hex1_length);
                Text1.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex1.Text));
                
                file.L1Length = Text1.Text.Length;
                Length1.Text = file.L1Length.ToString();
                file.L1Last = file.hex1_length - file.L1Length;
                Last1.Text = file.L1Last.ToString();
                file.hex1 = Hex1.Text;

                //hex2
                Hex2.MaxLength = file.hex2_length * 2+(file.hex2_length - 1);
                Text2.MaxLength = file.hex2_length;

                Hex2.Text = BitConverter.ToString(bitarray, file.hex2_address, file.hex2_length);
                Text2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex2.Text));

                file.L2Length = Text2.Text.Length;
                Length2.Text = file.L2Length.ToString();
                file.L2Last = file.hex2_length - file.L2Length;
                Last2.Text = file.L2Last.ToString();
                file.hex2 = Hex2.Text;

                //hex3
                Hex3.MaxLength = file.hex3_length * 2+(file.hex3_length - 1);
                Text3.MaxLength = file.hex3_length;

                Hex3.Text = BitConverter.ToString(bitarray, file.hex3_address, file.hex3_length);
                Text3.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex3.Text));

                file.L3Length = Text3.Text.Length;
                Length3.Text = file.L3Length.ToString();
                file.L3Last = file.hex3_length - file.L3Length;
                Last3.Text = file.L3Last.ToString();
                file.hex3 = Hex3.Text;

                //hex4
                Hex4.MaxLength = file.hex4_length * 2+(file.hex4_length - 1);
                Text4.MaxLength = file.hex4_length;

                Hex4.Text = BitConverter.ToString(bitarray, file.hex4_address, file.hex4_length);
                Text4.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex4.Text));

                file.L4Length = Text4.Text.Length;
                Length4.Text = file.L4Length.ToString();
                file.L4Last = file.hex4_length - file.L4Length;
                Last4.Text = file.L4Last.ToString();
                file.hex4 = Hex4.Text;

                //hex5
                Hex5.MaxLength = file.hex5_length * 2+(file.hex5_length - 1);
                Text5.MaxLength = file.hex5_length;

                Hex5.Text = BitConverter.ToString(bitarray, file.hex5_address, file.hex5_length);
                Text5.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex5.Text));

                file.L5Length = Text5.Text.Length;
                Length5.Text = file.L5Length.ToString();
                file.L5Last = file.hex5_length - file.L5Length;
                Last5.Text = file.L5Last.ToString();
                file.hex5 = Hex5.Text;

                //hex6
                Hex6.MaxLength = file.hex6_length * 2 + (file.hex6_length - 1);
                Text6.MaxLength = file.hex6_length;

                Hex6.Text = BitConverter.ToString(bitarray, file.hex6_address, file.hex6_length);
                Text6.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex6.Text));

                file.L6Length = Text6.Text.Length;
                Length6.Text = file.L6Length.ToString();
                file.L6Last = file.hex6_length - file.L6Length;
                Last6.Text = file.L6Last.ToString();
                file.hex6 = Hex6.Text;

                //hex7
                Hex7.MaxLength = file.hex7_length * 2 + (file.hex7_length - 1);
                Text7.MaxLength = file.hex7_length;

                Hex7.Text = BitConverter.ToString(bitarray, file.hex7_address, file.hex7_length);
                Text7.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex7.Text));

                file.L7Length = Text7.Text.Length;
                Length7.Text = file.L7Length.ToString();
                file.L7Last = file.hex7_length - file.L7Length;
                Last7.Text = file.L7Last.ToString();
                file.hex7 = Hex7.Text;

                //hex8
                Hex8.MaxLength = file.hex8_length * 2 + (file.hex8_length - 1);
                Text8.MaxLength = file.hex8_length;

                Hex8.Text = BitConverter.ToString(bitarray, file.hex8_address, file.hex8_length);
                Text8.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex8.Text));

                file.L8Length = Text8.Text.Length;
                Length8.Text = file.L8Length.ToString();
                file.L8Last = file.hex8_length - file.L8Length;
                Last8.Text = file.L8Last.ToString();
                file.hex8 = Hex8.Text;

                //hex9
                Hex9.MaxLength = file.hex9_length * 2 + (file.hex9_length - 1);
                Text9.MaxLength = file.hex9_length;

                Hex9.Text = BitConverter.ToString(bitarray, file.hex9_address, file.hex9_length);
                Text9.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex9.Text));

                file.L9Length = Text9.Text.Length;
                Length9.Text = file.L9Length.ToString();
                file.L9Last = file.hex9_length - file.L9Length;
                Last9.Text = file.L9Last.ToString();
                file.hex9 = Hex9.Text;

                //hex10
                Hex10.MaxLength = file.hex10_length * 2 + (file.hex10_length - 1);
                Text10.MaxLength = file.hex10_length;

                Hex10.Text = BitConverter.ToString(bitarray, file.hex10_address, file.hex10_length);
                Text10.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex10.Text));

                file.L10Length = Text10.Text.Length;
                Length10.Text = file.L10Length.ToString();
                file.L10Last = file.hex10_length - file.L10Length;
                Last10.Text = file.L10Last.ToString();
                file.hex10 = Hex10.Text;

                //hex11
                Hex11.MaxLength = file.hex11_length * 2 + (file.hex11_length - 1);
                Text11.MaxLength = file.hex11_length;

                Hex11.Text = BitConverter.ToString(bitarray, file.hex11_address, file.hex11_length);
                Text11.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex11.Text));

                file.L11Length = Text11.Text.Length;
                Length11.Text = file.L11Length.ToString();
                file.L11Last = file.hex11_length - file.L11Length;
                Last11.Text = file.L11Last.ToString();
                file.hex11 = Hex11.Text;

                //hex12
                Hex12.MaxLength = file.hex12_length * 2 + (file.hex12_length - 1);
                Text12.MaxLength = file.hex12_length;

                Hex12.Text = BitConverter.ToString(bitarray, file.hex12_address, file.hex12_length);
                Text12.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex12.Text));

                file.L12Length = Text12.Text.Length;
                Length12.Text = file.L12Length.ToString();
                file.L12Last = file.hex12_length - file.L12Length;
                Last12.Text = file.L12Last.ToString();
                file.hex12 = Hex12.Text;

                //hex13
                Hex13.MaxLength = file.hex13_length * 2 + (file.hex13_length - 1);
                Text13.MaxLength = file.hex13_length;

                Hex13.Text = BitConverter.ToString(bitarray, file.hex13_address, file.hex13_length);
                Text13.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex13.Text));

                file.L13Length = Text13.Text.Length;
                Length13.Text = file.L13Length.ToString();
                file.L13Last = file.hex13_length - file.L13Length;
                Last13.Text = file.L13Last.ToString();
                file.hex13 = Hex13.Text;

                //hex14
                Hex14.MaxLength = file.hex14_length * 2 + (file.hex14_length - 1);
                Text14.MaxLength = file.hex14_length;

                Hex14.Text = BitConverter.ToString(bitarray, file.hex14_address, file.hex14_length);
                Text14.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex14.Text));

                file.L14Length = Text14.Text.Length;
                Length14.Text = file.L14Length.ToString();
                file.L14Last = file.hex14_length - file.L14Length;
                Last14.Text = file.L14Last.ToString();
                file.hex14 = Hex14.Text;

            }
        }

        class file
        {
            public static byte[] save = new byte[143968];
            //text1
            public static string hex1;
            public static int L1Length;
            public static int L1Last;
            public static int hex1_address;
            public static int hex1_length;

            //text2
            public static string hex2;
            public static int L2Length;
            public static int L2Last;
            public static int hex2_address;
            public static int hex2_length;

            //text3
            public static string hex3;
            public static int L3Length;
            public static int L3Last;
            public static int hex3_address;
            public static int hex3_length;

            //text4
            public static string hex4;
            public static int L4Length;
            public static int L4Last;
            public static int hex4_address;
            public static int hex4_length;

            //text5
            public static string hex5;
            public static int L5Length;
            public static int L5Last;
            public static int hex5_address;
            public static int hex5_length;

            //text6
            public static string hex6;
            public static int L6Length;
            public static int L6Last;
            public static int hex6_address;
            public static int hex6_length;

            //text7
            public static string hex7;
            public static int L7Length;
            public static int L7Last;
            public static int hex7_address;
            public static int hex7_length;

            //text8
            public static string hex8;
            public static int L8Length;
            public static int L8Last;
            public static int hex8_address;
            public static int hex8_length;

            //text9
            public static string hex9;
            public static int L9Length;
            public static int L9Last;
            public static int hex9_address;
            public static int hex9_length;

            //text10
            public static string hex10;
            public static int L10Length;
            public static int L10Last;
            public static int hex10_address;
            public static int hex10_length;

            //text11
            public static string hex11;
            public static int L11Length;
            public static int L11Last;
            public static int hex11_address;
            public static int hex11_length;

            //text12
            public static string hex12;
            public static int L12Length;
            public static int L12Last;
            public static int hex12_address;
            public static int hex12_length;

            //text13
            public static string hex13;
            public static int L13Length;
            public static int L13Last;
            public static int hex13_address;
            public static int hex13_length;

            //text14
            public static string hex14;
            public static int L14Length;
            public static int L14Last;
            public static int hex14_address;
            public static int hex14_length;
        }
        

        void start_file()
        {
            if(Open_File.OpenFile.FileName == "COMOD11.SNG")
            {
                this.Text = "COMOD11.SNG - Level 1 Single Lammy";
                file.hex1_address = COMOD11_SNG_info.Hex1_address;
                file.hex1_length = COMOD11_SNG_info.Hex1_length;

                file.hex2_address = COMOD11_SNG_info.Hex2_address;
                file.hex2_length = COMOD11_SNG_info.Hex2_length;

                file.hex3_address = COMOD11_SNG_info.Hex3_address;
                file.hex3_length = COMOD11_SNG_info.Hex3_length;

                file.hex4_address = COMOD11_SNG_info.Hex4_address;
                file.hex4_length = COMOD11_SNG_info.Hex4_length;

                file.hex5_address = COMOD11_SNG_info.Hex5_address;
                file.hex5_length = COMOD11_SNG_info.Hex5_length;

                file.hex6_address = COMOD11_SNG_info.Hex6_address;
                file.hex6_length = COMOD11_SNG_info.Hex6_length;

                file.hex7_address = COMOD11_SNG_info.Hex7_address;
                file.hex7_length = COMOD11_SNG_info.Hex7_length;

                file.hex8_address = COMOD11_SNG_info.Hex8_address;
                file.hex8_length = COMOD11_SNG_info.Hex8_length;

                file.hex9_address = COMOD11_SNG_info.Hex9_address;
                file.hex9_length = COMOD11_SNG_info.Hex9_length;

                file.hex10_address = COMOD11_SNG_info.Hex10_address;
                file.hex10_length = COMOD11_SNG_info.Hex10_length;

                file.hex11_address = COMOD11_SNG_info.Hex11_address;
                file.hex11_length = COMOD11_SNG_info.Hex11_length;

                file.hex12_address = COMOD11_SNG_info.Hex12_address;
                file.hex12_length = COMOD11_SNG_info.Hex12_length;

                file.hex13_address = COMOD11_SNG_info.Hex13_address;
                file.hex13_length = COMOD11_SNG_info.Hex13_length;

                file.hex14_address = COMOD11_SNG_info.Hex14_address;
                file.hex14_length = COMOD11_SNG_info.Hex14_length;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) //hex1
        {
            if (Hex1.ContainsFocus == true)
            {
                Text1.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex1.Text));
                
                file.L1Length = Text1.Text.Length;
                Length1.Text = file.L1Length.ToString();
                file.L1Last = 35 - file.L1Length;
                Last1.Text = file.L1Last.ToString();
                file.hex1 = Hex1.Text;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e) //encode1
        {
            if (Text1.ContainsFocus == true)
            {
                Hex1.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text1.Text));
                
                file.L1Length = Text1.Text.Length;
                Length1.Text = file.L1Length.ToString();
                file.L1Last = 35 - file.L1Length;
                Last1.Text = file.L1Last.ToString();
                file.hex1 = Hex1.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //hex2
        {
            if(Hex2.ContainsFocus == true)
            {
                Text2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex2.Text));

                file.L2Length = Text2.Text.Length;
                Length2.Text = file.L2Length.ToString();
                file.L2Last = 27 - file.L2Length;
                Last2.Text = file.L2Last.ToString();
                file.hex2 = Hex2.Text;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e) //encode2
        {
            if (Text2.ContainsFocus == true)
            {
                Hex2.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text2.Text));

                file.L2Length = Text2.Text.Length;
                Length2.Text = file.L2Length.ToString();
                file.L2Last = 27 - file.L2Length;
                Last2.Text = file.L2Last.ToString();
                file.hex2 = Hex2.Text;
            }
        }

        private void Hex3_TextChanged(object sender, EventArgs e) //hex3
        {
            if(Hex3.ContainsFocus == true)
            {
                Text3.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex3.Text));

                file.L3Length = Text3.Text.Length;
                Length3.Text = file.L3Length.ToString();
                file.L3Last = 51 - file.L3Length;
                Last3.Text = file.L3Last.ToString();
                file.hex3 = Hex3.Text;
            }
        }
        private void Text3_TextChanged(object sender, EventArgs e) //encode3
        {
            if(Text3.ContainsFocus == true)
            {
                Hex3.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text3.Text));

                file.L3Length = Text3.Text.Length;
                Length3.Text = file.L3Length.ToString();
                file.L3Last = 51 - file.L3Length;
                Last3.Text = file.L3Last.ToString();
                file.hex3 = Hex3.Text;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e) //hex4
        {
            if (Hex4.ContainsFocus == true)
            {
                Text4.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex4.Text));

                file.L4Length = Text4.Text.Length;
                Length4.Text = file.L4Length.ToString();
                file.L4Last = 51 - file.L4Length;
                Last4.Text = file.L4Last.ToString();
                file.hex4 = Hex4.Text;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e) //encode4
        {
            if (Text4.ContainsFocus == true)
            {
                Hex4.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text4.Text));

                file.L4Length = Text4.Text.Length;
                Length4.Text = file.L4Length.ToString();
                file.L4Last = 51 - file.L4Length;
                Last4.Text = file.L4Last.ToString();
                file.hex4 = Hex4.Text;
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e) //hex5
        {
            if (Hex5.ContainsFocus == true)
            {
                Text5.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex5.Text));

                file.L5Length = Text5.Text.Length;
                Length5.Text = file.L5Length.ToString();
                file.L5Last = 39 - file.L5Length;
                Last5.Text = file.L5Last.ToString();
                file.hex5 = Hex5.Text;
            }
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e) //encode5
        {
            if (Text5.ContainsFocus == true)
            {
                Hex5.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text5.Text));

                file.L5Length = Text5.Text.Length;
                Length5.Text = file.L5Length.ToString();
                file.L5Last = 39 - file.L5Length;
                Last5.Text = file.L5Last.ToString();
                file.hex5 = Hex5.Text;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) //hex6
        {
            if (Hex6.ContainsFocus == true)
            {
                Text6.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex6.Text));

                file.L6Length = Text6.Text.Length;
                Length6.Text = file.L6Length.ToString();
                file.L6Last = 43 - file.L6Length;
                Last6.Text = file.L6Last.ToString();
                file.hex6 = Hex6.Text;
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e) //encode6
        {
            if (Text6.ContainsFocus == true)
            {
                Hex6.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text6.Text));

                file.L6Length = Text6.Text.Length;
                Length6.Text = file.L6Length.ToString();
                file.L6Last = 43 - file.L6Length;
                Last6.Text = file.L6Last.ToString();
                file.hex6 = Hex6.Text;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e) //hex7
        {
            if (Hex7.ContainsFocus == true)
            {
                Text7.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex7.Text));

                file.L7Length = Text7.Text.Length;
                Length7.Text = file.L7Length.ToString();
                file.L7Last = 15 - file.L7Length;
                Last7.Text = file.L7Last.ToString();
                file.hex7 = Hex7.Text;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e) //encode7
        {
            if (Text7.ContainsFocus == true)
            {
                Hex7.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text7.Text));

                file.L7Length = Text7.Text.Length;
                Length7.Text = file.L7Length.ToString();
                file.L7Last = 15 - file.L7Length;
                Last7.Text = file.L7Last.ToString();
                file.hex7 = Hex7.Text;
            }
        }

        private void Hex8_TextChanged(object sender, EventArgs e) //hex8
        {
            if (Hex8.ContainsFocus == true)
            {
                Text8.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex8.Text));

                file.L8Length = Text8.Text.Length;
                Length8.Text = file.L8Length.ToString();
                file.L8Last = 19 - file.L8Length;
                Last8.Text = file.L8Last.ToString();
                file.hex8 = Hex8.Text;
            }
        }
        private void Text8_TextChanged(object sender, EventArgs e) //encode8
        {
            if (Text8.ContainsFocus == true)
            {
                Hex8.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text8.Text));

                file.L8Length = Text8.Text.Length;
                Length8.Text = file.L8Length.ToString();
                file.L8Last = 19 - file.L8Length;
                Last8.Text = file.L8Last.ToString();
                file.hex8 = Hex8.Text;
            }
        }

        private void Hex9_TextChanged(object sender, EventArgs e) //hex9
        {
            if (Hex9.ContainsFocus == true)
            {
                Text9.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex9.Text));

                file.L9Length = Text9.Text.Length;
                Length9.Text = file.L9Length.ToString();
                file.L9Last = 19 - file.L9Length;
                Last9.Text = file.L9Last.ToString();
                file.hex9 = Hex9.Text;
            }
        }
        private void Text9_TextChanged(object sender, EventArgs e) //encode9
        {
            if (Text9.ContainsFocus == true)
            {
                Hex9.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text9.Text));

                file.L9Length = Text9.Text.Length;
                Length9.Text = file.L9Length.ToString();
                file.L9Last = 19 - file.L9Length;
                Last9.Text = file.L9Last.ToString();
                file.hex9 = Hex9.Text;
            }
        }

        private void Hex10_TextChanged(object sender, EventArgs e) //hex10
        {
            if (Hex10.ContainsFocus == true)
            {
                Text10.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex10.Text));

                file.L10Length = Text10.Text.Length;
                Length10.Text = file.L10Length.ToString();
                file.L10Last = 31 - file.L10Length;
                Last10.Text = file.L10Last.ToString();
                file.hex10 = Hex10.Text;
            }
        }
        private void Text10_TextChanged(object sender, EventArgs e) //encode10
        {
            if (Text10.ContainsFocus == true)
            {
                Hex10.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text10.Text));

                file.L10Length = Text10.Text.Length;
                Length10.Text = file.L10Length.ToString();
                file.L10Last = 31 - file.L10Length;
                Last10.Text = file.L10Last.ToString();
                file.hex10 = Hex10.Text;
            }
        }

        private void Hex11_TextChanged(object sender, EventArgs e) //hex11
        {
            if (Hex11.ContainsFocus == true)
            {
                Text11.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex11.Text));

                file.L11Length = Text11.Text.Length;
                Length11.Text = file.L11Length.ToString();
                file.L11Last = 27 - file.L11Length;
                Last11.Text = file.L11Last.ToString();
                file.hex11 = Hex11.Text;
            }
        }
        private void Text11_TextChanged(object sender, EventArgs e) //encode11
        {
            if (Text11.ContainsFocus == true)
            {
                Hex11.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text11.Text));

                file.L11Length = Text11.Text.Length;
                Length11.Text = file.L11Length.ToString();
                file.L11Last = 27 - file.L11Length;
                Last11.Text = file.L11Last.ToString();
                file.hex11 = Hex11.Text;
            }
        }

        private void Hex12_TextChanged(object sender, EventArgs e) //hex12
        {
            if (Hex12.ContainsFocus == true)
            {
                Text12.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex12.Text));

                file.L12Length = Text12.Text.Length;
                Length12.Text = file.L12Length.ToString();
                file.L12Last = 19 - file.L12Length;
                Last12.Text = file.L12Last.ToString();
                file.hex12 = Hex12.Text;
            }
        }
        private void Text12_TextChanged(object sender, EventArgs e) //encode12
        {
            if (Text12.ContainsFocus == true)
            {
                Hex12.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text12.Text));

                file.L12Length = Text12.Text.Length;
                Length12.Text = file.L12Length.ToString();
                file.L12Last = 19 - file.L12Length;
                Last12.Text = file.L12Last.ToString();
                file.hex12 = Hex12.Text;
            }
        }

        private void Hex13_TextChanged(object sender, EventArgs e) //hex13
        {
            if (Hex13.ContainsFocus == true)
            {
                Text13.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex13.Text));

                file.L13Length = Text13.Text.Length;
                Length13.Text = file.L13Length.ToString();
                file.L13Last = 15 - file.L13Length;
                Last13.Text = file.L13Last.ToString();
                file.hex13 = Hex13.Text;
            }
        }
        private void Text13_TextChanged(object sender, EventArgs e) //encode13
        {
            if (Text13.ContainsFocus == true)
            {
                Hex13.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text13.Text));

                file.L13Length = Text13.Text.Length;
                Length13.Text = file.L13Length.ToString();
                file.L13Last = 15 - file.L13Length;
                Last13.Text = file.L13Last.ToString();
                file.hex13 = Hex13.Text;
            }
        }

        private void Hex14_TextChanged(object sender, EventArgs e) //hex14
        {
            if (Hex14.ContainsFocus == true)
            {
                Text14.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex14.Text));

                file.L14Length = Text14.Text.Length;
                Length14.Text = file.L14Length.ToString();
                file.L14Last = 23 - file.L14Length;
                Last14.Text = file.L14Last.ToString();
                file.hex14 = Hex14.Text;
            }
        }
        private void Text14_TextChanged(object sender, EventArgs e) //encode14
        {
            if (Text14.ContainsFocus == true)
            {
                Hex14.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text14.Text));

                file.L14Length = Text14.Text.Length;
                Length14.Text = file.L14Length.ToString();
                file.L14Last = 23 - file.L14Length;
                Last14.Text = file.L14Last.ToString();
                file.hex14 = Hex14.Text;
            }
        }


        private void Save_as_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex1, file.hex1_length), 0, file.save, file.hex1_address, file.hex1_length); //hex1
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex2, file.hex2_length), 0, file.save, file.hex2_address, file.hex2_length); //hex2
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex3, file.hex3_length), 0, file.save, file.hex3_address, file.hex3_length); //hex3
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex4, file.hex4_length), 0, file.save, file.hex4_address, file.hex4_length); //hex4
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex5, file.hex5_length), 0, file.save, file.hex5_address, file.hex5_length); //hex5
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex6, file.hex6_length), 0, file.save, file.hex6_address, file.hex6_length); //hex6
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex7, file.hex7_length), 0, file.save, file.hex7_address, file.hex7_length); //hex7
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex8, file.hex8_length), 0, file.save, file.hex8_address, file.hex8_length); //hex8
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex9, file.hex9_length), 0, file.save, file.hex9_address, file.hex9_length); //hex9
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex10, file.hex10_length), 0, file.save, file.hex10_address, file.hex10_length); //hex10
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex11, file.hex11_length), 0, file.save, file.hex11_address, file.hex11_length); //hex11
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex12, file.hex12_length), 0, file.save, file.hex12_address, file.hex12_length); //hex12
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex13, file.hex13_length), 0, file.save, file.hex13_address, file.hex13_length); //hex13
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex14, file.hex14_length), 0, file.save, file.hex14_address, file.hex14_length); //hex14

                    myStream.Write(file.save, 0, file.save.Length);
                    myStream.Close();

                }
            }
        }

    
        private void COMOD11_SNG_Load(object sender, EventArgs e)
        {

        }                                               

    }
}
