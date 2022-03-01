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
    public partial class Editor : Form
    {
        public class COMOD11_SNG_info //lines 91
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

            public const int Hex34_address = 115115;
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

            public const int Hex43_address = 115488;
            public const int Hex43_length = 39;

            public const int Hex44_address = 115528;
            public const int Hex44_length = 43;

            public const int Hex45_address = 115572;
            public const int Hex45_length = 43;

            public const int Hex46_address = 115616;
            public const int Hex46_length = 11;

            public const int Hex47_address = 115628;
            public const int Hex47_length = 11;

            public const int Hex48_address = 115640;
            public const int Hex48_length = 11;

            public const int Hex49_address = 115652;
            public const int Hex49_length = 11;

            public const int Hex50_address = 115664;
            public const int Hex50_length = 11;

            public const int Hex51_address = 115676;
            public const int Hex51_length = 11;

            public const int Hex52_address = 115688;
            public const int Hex52_length = 11;

            public const int Hex53_address = 115700;
            public const int Hex53_length = 11;

            public const int Hex54_address = 115712;
            public const int Hex54_length = 15;

            public const int Hex55_address = 115728;
            public const int Hex55_length = 15;

            public const int Hex56_address = 115744;
            public const int Hex56_length = 43;

            public const int Hex57_address = 115788;
            public const int Hex57_length = 43;

            public const int Hex58_address = 115832;
            public const int Hex58_length = 35;

            public const int Hex59_address = 115868;
            public const int Hex59_length = 35;

            public const int Hex60_address = 115904;
            public const int Hex60_length = 43;

            public const int Hex61_address = 115948;
            public const int Hex61_length = 43;

            public const int Hex62_address = 115992;
            public const int Hex62_length = 43;

            public const int Hex63_address = 116036;
            public const int Hex63_length = 43;

            public const int Hex64_address = 116080;
            public const int Hex64_length = 7;

            public const int Hex65_address = 116088;
            public const int Hex65_length = 11;

            public const int Hex66_address = 116100;
            public const int Hex66_length = 7;

            public const int Hex67_address = 116108;
            public const int Hex67_length = 11;

            public const int Hex68_address = 116120;
            public const int Hex68_length = 15;

            public const int Hex69_address = 116136;
            public const int Hex69_length = 15;

            public const int Hex70_address = 116152;
            public const int Hex70_length = 15;

            public const int Hex71_address = 116168;
            public const int Hex71_length = 15;

            public const int Hex72_address = 116184;
            public const int Hex72_length = 15;

            public const int Hex73_address = 116200;
            public const int Hex73_length = 23;

            public const int Hex74_address = 116224;
            public const int Hex74_length = 15;

            public const int Hex75_address = 116240;
            public const int Hex75_length = 15;

            public const int Hex76_address = 116256;
            public const int Hex76_length = 19;

            public const int Hex77_address = 116276;
            public const int Hex77_length = 15;

            public const int Hex78_address = 116292;
            public const int Hex78_length = 35;

            public const int Hex79_address = 116328;
            public const int Hex79_length = 27;

            //катсцена
            public const int Hex80_address = 117148;
            public const int Hex80_length = 7;

            public const int Hex81_address = 117156;
            public const int Hex81_length = 31;

            public const int Hex82_address = 117224;
            public const int Hex82_length = 51;

            public const int Hex83_address = 117276;
            public const int Hex83_length = 51;

            public const int Hex84_address = 117328;
            public const int Hex84_length = 31;

            public const int Hex85_address = 117408;
            public const int Hex85_length = 27;

            public const int Hex86_address = 117436;
            public const int Hex86_length = 35;

            public const int Hex87_address = 117472;
            public const int Hex87_length = 27;

            public const int Hex88_address = 117548;
            public const int Hex88_length = 23;

            public const int Hex89_address = 117572;
            public const int Hex89_length = 23;

            public const int Hex90_address = 117632;
            public const int Hex90_length = 27;

            public const int Hex91_address = 117660;
            public const int Hex91_length = 35;

        }
        public class COMOD0_MEN_info //lines 52
        {
            public const int length = 225544;

            //меню
            public const int Hex1_address = 792;
            public const int Hex1_length = 11;

            public const int Hex2_address = 804;
            public const int Hex2_length = 11;

            public const int Hex3_address = 816;
            public const int Hex3_length = 7;

            public const int Hex4_address = 824;
            public const int Hex4_length = 11;

            public const int Hex5_address = 836;
            public const int Hex5_length = 11;

            public const int Hex6_address = 848;
            public const int Hex6_length = 7;

            public const int Hex7_address = 856;
            public const int Hex7_length = 15;

            public const int Hex8_address = 872;
            public const int Hex8_length = 11;

            public const int Hex9_address = 1616;
            public const int Hex9_length = 43;

            public const int Hex10_address = 1660;
            public const int Hex10_length = 43;

            public const int Hex11_address = 1704;
            public const int Hex11_length = 47;

            public const int Hex12_address = 1752;
            public const int Hex12_length = 23;

            public const int Hex13_address = 1776;
            public const int Hex13_length = 47;

            public const int Hex14_address = 1824;
            public const int Hex14_length = 43;

            public const int Hex15_address = 1868;
            public const int Hex15_length = 91;

            public const int Hex16_address = 1960;
            public const int Hex16_length = 35;

            public const int Hex17_address = 1996;
            public const int Hex17_length = 23;

            public const int Hex18_address = 2020;
            public const int Hex18_length = 11;

            public const int Hex19_address = 2032;
            public const int Hex19_length = 11;

            public const int Hex20_address = 2044;
            public const int Hex20_length = 23;

            public const int Hex21_address = 2348;
            public const int Hex21_length = 3;

            public const int Hex22_address = 2352;
            public const int Hex22_length = 5;

            public const int Hex23_address = 76296;
            public const int Hex23_length = 43;

            public const int Hex24_address = 76340;
            public const int Hex24_length = 11;

            public const int Hex25_address = 76352;
            public const int Hex25_length = 19;

            public const int Hex26_address = 76372;
            public const int Hex26_length = 51;

            public const int Hex27_address = 76424;
            public const int Hex27_length = 31;

            public const int Hex28_address = 76456;
            public const int Hex28_length = 47;

            public const int Hex29_address = 76504;
            public const int Hex29_length = 15;

            public const int Hex30_address = 76520;
            public const int Hex30_length = 35;

            public const int Hex31_address = 76556;
            public const int Hex31_length = 31;

            public const int Hex32_address = 76588;
            public const int Hex32_length = 35;

            public const int Hex33_address = 76624;
            public const int Hex33_length = 31;

            public const int Hex34_address = 76656;
            public const int Hex34_length = 47;

            public const int Hex35_address = 76704;
            public const int Hex35_length = 31;

            public const int Hex36_address = 76736;
            public const int Hex36_length = 7;

            public const int Hex37_address = 76744;
            public const int Hex37_length = 27;

            public const int Hex38_address = 76772;
            public const int Hex38_length = 35;

            public const int Hex39_address = 76808;
            public const int Hex39_length = 35;

            public const int Hex40_address = 76844;
            public const int Hex40_length = 63;

            public const int Hex41_address = 76908;
            public const int Hex41_length = 35;

            public const int Hex42_address = 76944;
            public const int Hex42_length = 7;

            public const int Hex43_address = 76952;
            public const int Hex43_length = 7;

            public const int Hex44_address = 76960;
            public const int Hex44_length = 35;

            public const int Hex45_address = 76996;
            public const int Hex45_length = 39;

            public const int Hex46_address = 77036;
            public const int Hex46_length = 7;

            public const int Hex47_address = 77044;
            public const int Hex47_length = 39;

            public const int Hex48_address = 77084;
            public const int Hex48_length = 43;

            public const int Hex49_address = 77128;
            public const int Hex49_length = 7;

            public const int Hex50_address = 77136;
            public const int Hex50_length = 19;

            public const int Hex51_address = 77156;
            public const int Hex51_length = 15;

            public const int Hex52_address = 77172;
            public const int Hex52_length = 35;
        }
        public class COMOD6_SNG_info //lines 94
        {
            public const int length = 192960;

            //катсцена
            public const int Hex1_address = 84960;
            public const int Hex1_length = 11;

            public const int Hex2_address = 84972;
            public const int Hex2_length = 27;

            public const int Hex3_address = 85000;
            public const int Hex3_length = 19;

            public const int Hex4_address = 85020;
            public const int Hex4_length = 43;

            public const int Hex5_address = 85064;
            public const int Hex5_length = 15;

            public const int Hex6_address = 85080;
            public const int Hex6_length = 15;

            public const int Hex7_address = 85096;
            public const int Hex7_length = 7;

            public const int Hex8_address = 85104;
            public const int Hex8_length = 7;

            public const int Hex9_address = 85112;
            public const int Hex9_length = 7;

            public const int Hex10_address = 85120;
            public const int Hex10_length = 23;

            public const int Hex11_address = 85144;
            public const int Hex11_length = 39;

            public const int Hex12_address = 85184;
            public const int Hex12_length = 27;

            public const int Hex13_address = 85212;
            public const int Hex13_length = 27;

            //геймплей
            public const int Hex14_address = 87476;
            public const int Hex14_length = 35;

            public const int Hex15_address = 87512;
            public const int Hex15_length = 47;

            public const int Hex16_address = 87560;
            public const int Hex16_length = 35;

            public const int Hex17_address = 87596;
            public const int Hex17_length = 47;

            public const int Hex18_address = 87644;
            public const int Hex18_length = 39;

            public const int Hex19_address = 87684;
            public const int Hex19_length = 43;

            public const int Hex20_address = 87728;
            public const int Hex20_length = 39;

            public const int Hex21_address = 87768;
            public const int Hex21_length = 43;

            public const int Hex22_address = 87812;
            public const int Hex22_length = 35;

            public const int Hex23_address = 87848;
            public const int Hex23_length = 47;

            public const int Hex24_address = 87896;
            public const int Hex24_length = 35;

            public const int Hex25_address = 87932;
            public const int Hex25_length = 47;

            public const int Hex26_address = 87980;
            public const int Hex26_length = 39;

            public const int Hex27_address = 88020;
            public const int Hex27_length = 47;

            public const int Hex28_address = 88068;
            public const int Hex28_length = 39;

            public const int Hex29_address = 88108;
            public const int Hex29_length = 47;

            public const int Hex30_address = 88156;
            public const int Hex30_length = 35;

            public const int Hex31_address = 88192;
            public const int Hex31_length = 39;

            public const int Hex32_address = 88232;
            public const int Hex32_length = 35;

            public const int Hex33_address = 88268;
            public const int Hex33_length = 39;

            public const int Hex34_address = 88308;
            public const int Hex34_length = 35;

            public const int Hex35_address = 88344;
            public const int Hex35_length = 43;

            public const int Hex36_address = 88388;
            public const int Hex36_length = 35;

            public const int Hex37_address = 88424;
            public const int Hex37_length = 43;

            public const int Hex38_address = 88468;
            public const int Hex38_length = 35;

            public const int Hex39_address = 88504;
            public const int Hex39_length = 35;

            public const int Hex40_address = 88540;
            public const int Hex40_length = 35;

            public const int Hex41_address = 88576;
            public const int Hex41_length = 35;

            public const int Hex42_address = 88612;
            public const int Hex42_length = 35;

            public const int Hex43_address = 88648;
            public const int Hex43_length = 39;

            public const int Hex44_address = 88688;
            public const int Hex44_length = 35;

            public const int Hex45_address = 88724;
            public const int Hex45_length = 39;

            public const int Hex46_address = 88764;
            public const int Hex46_length = 35;

            public const int Hex47_address = 88800;
            public const int Hex47_length = 47;

            public const int Hex48_address = 88848;
            public const int Hex48_length = 35;

            public const int Hex49_address = 88884;
            public const int Hex49_length = 47;

            public const int Hex50_address = 88932;
            public const int Hex50_length = 39;

            public const int Hex51_address = 88972;
            public const int Hex51_length = 47;

            public const int Hex52_address = 89020;
            public const int Hex52_length = 39;

            public const int Hex53_address = 89060;
            public const int Hex53_length = 47;

            public const int Hex54_address = 89108;
            public const int Hex54_length = 35;

            public const int Hex55_address = 89144;
            public const int Hex55_length = 39;

            public const int Hex56_address = 89184;
            public const int Hex56_length = 35;

            public const int Hex57_address = 89220;
            public const int Hex57_length = 39;

            public const int Hex58_address = 89260;
            public const int Hex58_length = 35;

            public const int Hex59_address = 89296;
            public const int Hex59_length = 43;

            public const int Hex60_address = 89340;
            public const int Hex60_length = 35;

            public const int Hex61_address = 89376;
            public const int Hex61_length = 43;

            public const int Hex62_address = 89420;
            public const int Hex62_length = 35;

            public const int Hex63_address = 89456;
            public const int Hex63_length = 35;

            public const int Hex64_address = 89492;
            public const int Hex64_length = 35;

            public const int Hex65_address = 89528;
            public const int Hex65_length = 35;

            public const int Hex66_address = 89564;
            public const int Hex66_length = 35;

            public const int Hex67_address = 89600;
            public const int Hex67_length = 39;

            public const int Hex68_address = 89640;
            public const int Hex68_length = 35;

            public const int Hex69_address = 89676;
            public const int Hex69_length = 39;

            public const int Hex70_address = 89716;
            public const int Hex70_length = 39;

            public const int Hex71_address = 89756;
            public const int Hex71_length = 39;

            public const int Hex72_address = 89796;
            public const int Hex72_length = 35;

            public const int Hex73_address = 89832;
            public const int Hex73_length = 35;

            public const int Hex74_address = 89868;
            public const int Hex74_length = 27;

            public const int Hex75_address = 89896;
            public const int Hex75_length = 27;

            public const int Hex76_address = 89924;
            public const int Hex76_length = 31;

            public const int Hex77_address = 89956;
            public const int Hex77_length = 31;

            public const int Hex78_address = 89988;
            public const int Hex78_length = 27;

            public const int Hex79_address = 90016;
            public const int Hex79_length = 27;

            public const int Hex80_address = 90044;
            public const int Hex80_length = 27;

            public const int Hex81_address = 90072;
            public const int Hex81_length = 31;

            //катсцена
            public const int Hex82_address = 90932;
            public const int Hex82_length = 19;

            public const int Hex83_address = 90952;
            public const int Hex83_length = 39;

            public const int Hex84_address = 90992;
            public const int Hex84_length = 35;

            public const int Hex85_address = 91076;
            public const int Hex85_length = 31;

            public const int Hex86_address = 91108;
            public const int Hex86_length = 15;

            public const int Hex87_address = 91124;
            public const int Hex87_length = 39;

            public const int Hex88_address = 91212;
            public const int Hex88_length = 43;

            public const int Hex89_address = 91256;
            public const int Hex89_length = 19;

            public const int Hex90_address = 91276;
            public const int Hex90_length = 39;

            public const int Hex91_address = 91364;
            public const int Hex91_length = 23;

            public const int Hex92_address = 91388;
            public const int Hex92_length = 39;

            public const int Hex93_address = 91460;
            public const int Hex93_length = 39;

            public const int Hex94_address = 91500;
            public const int Hex94_length = 47;
        }
        public class COMOD16_SNG_info // lines 73
        {
            public const int length = 192564;

            //катсцена
            public const int Hex1_address = 88488;
            public const int Hex1_length = 11;

            public const int Hex2_address = 88500;
            public const int Hex2_length = 31;

            public const int Hex3_address = 88532;
            public const int Hex3_length = 11;

            public const int Hex4_address = 88544;
            public const int Hex4_length = 7;

            public const int Hex5_address = 88552;
            public const int Hex5_length = 31;

            public const int Hex6_address = 88584;
            public const int Hex6_length = 11;

            public const int Hex7_address = 88596;
            public const int Hex7_length = 11;

            public const int Hex8_address = 88608;
            public const int Hex8_length = 11;

            public const int Hex9_address = 88620;
            public const int Hex9_length = 7;

            public const int Hex10_address = 88628;
            public const int Hex10_length = 47;

            public const int Hex11_address = 88676;
            public const int Hex11_length = 23;

            public const int Hex12_address = 88700;
            public const int Hex12_length = 7;

            public const int Hex13_address = 88708;
            public const int Hex13_length = 47;

            public const int Hex14_address = 88756;
            public const int Hex14_length = 47;

            public const int Hex15_address = 88804;
            public const int Hex15_length = 27;

            public const int Hex16_address = 88832;
            public const int Hex16_length = 55;

            public const int Hex17_address = 88888;
            public const int Hex17_length = 23;

            public const int Hex18_address = 88912;
            public const int Hex18_length = 23;

            public const int Hex19_address = 88936;
            public const int Hex19_length = 51;

            public const int Hex20_address = 88988;
            public const int Hex20_length = 31;

            public const int Hex21_address = 89020;
            public const int Hex21_length = 39;

            public const int Hex22_address = 89060;
            public const int Hex22_length = 47;

            public const int Hex23_address = 89108;
            public const int Hex23_length = 19;

            public const int Hex24_address = 89128;
            public const int Hex24_length = 23;

            public const int Hex25_address = 89152;
            public const int Hex25_length = 31;

            //геймплей
            public const int Hex26_address = 93796;
            public const int Hex26_length = 23;

            public const int Hex27_address = 93820;
            public const int Hex27_length = 19;

            public const int Hex28_address = 93840;
            public const int Hex28_length = 31;

            public const int Hex29_address = 93872;
            public const int Hex29_length = 39;

            public const int Hex30_address = 93912;
            public const int Hex30_length = 39;

            public const int Hex31_address = 93952;
            public const int Hex31_length = 51;

            public const int Hex32_address = 94004;
            public const int Hex32_length = 47;

            public const int Hex33_address = 94052;
            public const int Hex33_length = 43;

            public const int Hex34_address = 94096;
            public const int Hex34_length = 31;

            public const int Hex35_address = 94128;
            public const int Hex35_length = 51;

            public const int Hex36_address = 94180;
            public const int Hex36_length = 27;

            public const int Hex37_address = 94208;
            public const int Hex37_length = 51;

            public const int Hex38_address = 94260;
            public const int Hex38_length = 39;

            public const int Hex39_address = 94300;
            public const int Hex39_length = 51;

            public const int Hex40_address = 94352;
            public const int Hex40_length = 39;

            public const int Hex41_address = 94392;
            public const int Hex41_length = 47;

            public const int Hex42_address = 94440;
            public const int Hex42_length = 43;

            public const int Hex43_address = 94484;
            public const int Hex43_length = 43;

            public const int Hex44_address = 94528;
            public const int Hex44_length = 43;

            public const int Hex45_address = 94572;
            public const int Hex45_length = 39;

            public const int Hex46_address = 94612;
            public const int Hex46_length = 31;

            public const int Hex47_address = 94644;
            public const int Hex47_length = 51;

            public const int Hex48_address = 94696;
            public const int Hex48_length = 27;

            public const int Hex49_address = 94724;
            public const int Hex49_length = 51;

            public const int Hex50_address = 94776;
            public const int Hex50_length = 39;

            public const int Hex51_address = 94816;
            public const int Hex51_length = 51;

            public const int Hex52_address = 94868;
            public const int Hex52_length = 39;

            public const int Hex53_address = 94908;
            public const int Hex53_length = 47;

            public const int Hex54_address = 94956;
            public const int Hex54_length = 43;

            public const int Hex55_address = 95000;
            public const int Hex55_length = 43;

            public const int Hex56_address = 95044;
            public const int Hex56_length = 31;

            public const int Hex57_address = 95076;
            public const int Hex57_length = 35;

            public const int Hex58_address = 95112;
            public const int Hex58_length = 19;

            public const int Hex59_address = 95132;
            public const int Hex59_length = 23;

            //катсцена
            public const int Hex60_address = 95576;
            public const int Hex60_length = 19;

            public const int Hex61_address = 95596;
            public const int Hex61_length = 39;

            public const int Hex62_address = 95636;
            public const int Hex62_length = 19;

            public const int Hex63_address = 95656;
            public const int Hex63_length = 23;

            public const int Hex64_address = 95740;
            public const int Hex64_length = 31;

            public const int Hex65_address = 95772;
            public const int Hex65_length = 15;

            public const int Hex66_address = 95788;
            public const int Hex66_length = 35;

            public const int Hex67_address = 95872;
            public const int Hex67_length = 43;

            public const int Hex68_address = 95916;
            public const int Hex68_length = 19;

            public const int Hex69_address = 95936;
            public const int Hex69_length = 35;

            public const int Hex70_address = 96020;
            public const int Hex70_length = 23;

            public const int Hex71_address = 96044;
            public const int Hex71_length = 39;

            public const int Hex72_address = 96116;
            public const int Hex72_length = 39;

            public const int Hex73_address = 96156;
            public const int Hex73_length = 47;
        }
        public class COMOD16_CMP_info // lines 72
        {
            public const int length = 208620;

            //геймплей
            public const int Hex1_address = 97844;
            public const int Hex1_length = 23;

            public const int Hex2_address = 97868;
            public const int Hex2_length = 19;

            public const int Hex3_address = 97888;
            public const int Hex3_length = 31;

            public const int Hex4_address = 97920;
            public const int Hex4_length = 39;

            public const int Hex5_address = 97960;
            public const int Hex5_length = 39;

            public const int Hex6_address = 98000;
            public const int Hex6_length = 51;

            public const int Hex7_address = 98052;
            public const int Hex7_length = 47;

            public const int Hex8_address = 98100;
            public const int Hex8_length = 43;

            public const int Hex9_address = 98144;
            public const int Hex9_length = 31;

            public const int Hex10_address = 98176;
            public const int Hex10_length = 51;

            public const int Hex11_address = 98228;
            public const int Hex11_length = 27;

            public const int Hex12_address = 98256;
            public const int Hex12_length = 51;

            public const int Hex13_address = 98308;
            public const int Hex13_length = 39;

            public const int Hex14_address = 98348;
            public const int Hex14_length = 51;

            public const int Hex15_address = 98400;
            public const int Hex15_length = 39;

            public const int Hex16_address = 98440;
            public const int Hex16_length = 47;

            public const int Hex17_address = 98488;
            public const int Hex17_length = 43;

            public const int Hex18_address = 98532;
            public const int Hex18_length = 43;

            public const int Hex19_address = 98576;
            public const int Hex19_length = 43;

            public const int Hex20_address = 98620;
            public const int Hex20_length = 39;

            public const int Hex21_address = 98660;
            public const int Hex21_length = 31;

            public const int Hex22_address = 98692;
            public const int Hex22_length = 51;

            public const int Hex23_address = 98744;
            public const int Hex23_length = 27;

            public const int Hex24_address = 98772;
            public const int Hex24_length = 51;

            public const int Hex25_address = 98824;
            public const int Hex25_length = 39;

            public const int Hex26_address = 98864;
            public const int Hex26_length = 51;

            public const int Hex27_address = 98916;
            public const int Hex27_length = 39;

            public const int Hex28_address = 98956;
            public const int Hex28_length = 47;

            public const int Hex29_address = 99004;
            public const int Hex29_length = 43;

            public const int Hex30_address = 99048;
            public const int Hex30_length = 43;

            public const int Hex31_address = 99092;
            public const int Hex31_length = 31;

            public const int Hex32_address = 99124;
            public const int Hex32_length = 35;

            public const int Hex33_address = 99160;
            public const int Hex33_length = 19;

            public const int Hex34_address = 99180;
            public const int Hex34_length = 23;

            //катсцена
            public const int Hex35_address = 99624;
            public const int Hex35_length = 19;

            public const int Hex36_address = 99644;
            public const int Hex36_length = 39;

            public const int Hex37_address = 99684;
            public const int Hex37_length = 19;

            public const int Hex38_address = 99704;
            public const int Hex38_length = 31;

            public const int Hex39_address = 99796;
            public const int Hex39_length = 31;

            public const int Hex40_address = 99828;
            public const int Hex40_length = 15;

            public const int Hex41_address = 99844;
            public const int Hex41_length = 11;

            public const int Hex42_address = 99856;
            public const int Hex42_length = 19;

            public const int Hex43_address = 99936;
            public const int Hex43_length = 43;

            public const int Hex44_address = 99980;
            public const int Hex44_length = 19;

            public const int Hex45_address = 100000;
            public const int Hex45_length = 19;

            public const int Hex46_address = 100020;
            public const int Hex46_length = 19;

            public const int Hex47_address = 100100;
            public const int Hex47_length = 23;

            public const int Hex48_address = 100124;
            public const int Hex48_length = 39;

            public const int Hex49_address = 100196;
            public const int Hex49_length = 39;

            public const int Hex50_address = 100236;
            public const int Hex50_length = 47;

            public const int Hex51_address = 100332;
            public const int Hex51_length = 19;

            public const int Hex52_address = 100352;
            public const int Hex52_length = 27;

            public const int Hex53_address = 100380;
            public const int Hex53_length = 43;

            public const int Hex54_address = 100424;
            public const int Hex54_length = 47;

            public const int Hex55_address = 100532;
            public const int Hex55_length = 19;

            public const int Hex56_address = 100552;
            public const int Hex56_length = 27;

            public const int Hex57_address = 100580;
            public const int Hex57_length = 27;

            public const int Hex58_address = 100608;
            public const int Hex58_length = 15;

            public const int Hex59_address = 100624;
            public const int Hex59_length = 11;

            public const int Hex60_address = 100708;
            public const int Hex60_length = 19;

            public const int Hex61_address = 100728;
            public const int Hex61_length = 27;

            public const int Hex62_address = 100756;
            public const int Hex62_length = 43;

            public const int Hex63_address = 100800;
            public const int Hex63_length = 47;

            public const int Hex64_address = 100908;
            public const int Hex64_length = 19;

            public const int Hex65_address = 100928;
            public const int Hex65_length = 27;

            public const int Hex66_address = 100956;
            public const int Hex66_length = 27;

            public const int Hex67_address = 100984;
            public const int Hex67_length = 15;

            public const int Hex68_address = 101000;
            public const int Hex68_length = 11;

            public const int Hex69_address = 101084;
            public const int Hex69_length = 19;

            public const int Hex70_address = 101104;
            public const int Hex70_length = 43;

            public const int Hex71_address = 101184;
            public const int Hex71_length = 19;

            public const int Hex72_address = 101204;
            public const int Hex72_length = 43;
        }
        public class COMOD6_CMP_info //lines 90
        {
            public const int length = 214324;

            //геймплей
            public const int Hex1_address = 100392;
            public const int Hex1_length = 23;

            public const int Hex2_address = 100416;
            public const int Hex2_length = 19;

            public const int Hex3_address = 100436;
            public const int Hex3_length = 39;

            public const int Hex4_address = 100476;
            public const int Hex4_length = 43;

            public const int Hex5_address = 100520;
            public const int Hex5_length = 39;

            public const int Hex6_address = 100560;
            public const int Hex6_length = 43;

            public const int Hex7_address = 100604;
            public const int Hex7_length = 39;

            public const int Hex8_address = 100644;
            public const int Hex8_length = 51;

            public const int Hex9_address = 100696;
            public const int Hex9_length = 39;

            public const int Hex10_address = 100736;
            public const int Hex10_length = 47;

            public const int Hex11_address = 100784;
            public const int Hex11_length = 39;

            public const int Hex12_address = 100824;
            public const int Hex12_length = 47;

            public const int Hex13_address = 100872;
            public const int Hex13_length = 31;

            public const int Hex14_address = 100904;
            public const int Hex14_length = 51;

            public const int Hex15_address = 100956;
            public const int Hex15_length = 35;

            public const int Hex16_address = 100992;
            public const int Hex16_length = 43;

            public const int Hex17_address = 101036;
            public const int Hex17_length = 35;

            public const int Hex18_address = 101072;
            public const int Hex18_length = 43;

            public const int Hex19_address = 101116;
            public const int Hex19_length = 39;

            public const int Hex20_address = 101156;
            public const int Hex20_length = 51;

            public const int Hex21_address = 101208;
            public const int Hex21_length = 35;

            public const int Hex22_address = 101244;
            public const int Hex22_length = 39;

            public const int Hex23_address = 101284;
            public const int Hex23_length = 35;

            public const int Hex24_address = 101320;
            public const int Hex24_length = 39;

            public const int Hex25_address = 101360;
            public const int Hex25_length = 43;

            public const int Hex26_address = 101404;
            public const int Hex26_length = 43;

            public const int Hex27_address = 101448;
            public const int Hex27_length = 39;

            public const int Hex28_address = 101488;
            public const int Hex28_length = 47;

            public const int Hex29_address = 101536;
            public const int Hex29_length = 39;

            public const int Hex30_address = 101576;
            public const int Hex30_length = 47;

            public const int Hex31_address = 101624;
            public const int Hex31_length = 31;

            public const int Hex32_address = 101656;
            public const int Hex32_length = 51;

            public const int Hex33_address = 101708;
            public const int Hex33_length = 35;

            public const int Hex34_address = 101744;
            public const int Hex34_length = 43;

            public const int Hex35_address = 101788;
            public const int Hex35_length = 35;

            public const int Hex36_address = 101824;
            public const int Hex36_length = 43;

            public const int Hex37_address = 101868;
            public const int Hex37_length = 39;

            public const int Hex38_address = 101908;
            public const int Hex38_length = 51;

            public const int Hex39_address = 101960;
            public const int Hex39_length = 35;

            public const int Hex40_address = 101996;
            public const int Hex40_length = 39;

            public const int Hex41_address = 102036;
            public const int Hex41_length = 35;

            public const int Hex42_address = 102072;
            public const int Hex42_length = 39;

            public const int Hex43_address = 102112;
            public const int Hex43_length = 43;

            public const int Hex44_address = 102156;
            public const int Hex44_length = 35;

            public const int Hex45_address = 102192;
            public const int Hex45_length = 35;

            public const int Hex46_address = 102228;
            public const int Hex46_length = 31;

            public const int Hex47_address = 102260;
            public const int Hex47_length = 31;

            public const int Hex48_address = 102292;
            public const int Hex48_length = 31;

            public const int Hex49_address = 102324;
            public const int Hex49_length = 19;

            public const int Hex50_address = 102344;
            public const int Hex50_length = 27;

            public const int Hex51_address = 102372;
            public const int Hex51_length = 31;

            //катсцена
            public const int Hex52_address = 103028;
            public const int Hex52_length = 19;

            public const int Hex53_address = 103048;
            public const int Hex53_length = 39;

            public const int Hex54_address = 103088;
            public const int Hex54_length = 39;

            public const int Hex55_address = 103128;
            public const int Hex55_length = 35;

            public const int Hex56_address = 103224;
            public const int Hex56_length = 31;

            public const int Hex57_address = 103256;
            public const int Hex57_length = 15;

            public const int Hex58_address = 103272;
            public const int Hex58_length = 7;

            public const int Hex59_address = 103280;
            public const int Hex59_length = 23;

            public const int Hex60_address = 103364;
            public const int Hex60_length = 43;

            public const int Hex61_address = 103408;
            public const int Hex61_length = 19;

            public const int Hex62_address = 103428;
            public const int Hex62_length = 19;

            public const int Hex63_address = 103448;
            public const int Hex63_length = 19;

            public const int Hex64_address = 103528;
            public const int Hex64_length = 23;

            public const int Hex65_address = 103552;
            public const int Hex65_length = 39;

            public const int Hex66_address = 103624;
            public const int Hex66_length = 39;

            public const int Hex67_address = 103664;
            public const int Hex67_length = 47;

            public const int Hex68_address = 103760;
            public const int Hex68_length = 19;

            public const int Hex69_address = 103808;
            public const int Hex69_length = 43;

            public const int Hex70_address = 103852;
            public const int Hex70_length = 43;

            public const int Hex71_address = 103896;
            public const int Hex71_length = 19;

            public const int Hex72_address = 103988;
            public const int Hex72_length = 19;

            public const int Hex73_address = 104008;
            public const int Hex73_length = 27;

            public const int Hex74_address = 104036;
            public const int Hex74_length = 39;

            public const int Hex75_address = 104076;
            public const int Hex75_length = 15;

            public const int Hex76_address = 104092;
            public const int Hex76_length = 15;

            public const int Hex77_address = 104180;
            public const int Hex77_length = 19;

            public const int Hex78_address = 104200;
            public const int Hex78_length = 27;

            public const int Hex79_address = 104228;
            public const int Hex79_length = 43;

            public const int Hex80_address = 104272;
            public const int Hex80_length = 43;

            public const int Hex81_address = 104316;
            public const int Hex81_length = 19;

            public const int Hex82_address = 104408;
            public const int Hex82_length = 19;

            public const int Hex83_address = 104428;
            public const int Hex83_length = 27;

            public const int Hex84_address = 104456;
            public const int Hex84_length = 39;

            public const int Hex85_address = 104496;
            public const int Hex85_length = 15;

            public const int Hex86_address = 104512;
            public const int Hex86_length = 15;

            public const int Hex87_address = 104600;
            public const int Hex87_length = 19;

            public const int Hex88_address = 104620;
            public const int Hex88_length = 43;

            public const int Hex89_address = 104700;
            public const int Hex89_length = 19;

            public const int Hex90_address = 104720;
            public const int Hex90_length = 43;
        }
        public class COMOD6_COP_info //lines 97
        {
            public const int length = 213964;

            //катсцена
            public const int Hex1_address = 97880;
            public const int Hex1_length = 11;

            public const int Hex2_address = 97892;
            public const int Hex2_length = 31;

            public const int Hex3_address = 97924;
            public const int Hex3_length = 11;

            public const int Hex4_address = 97936;
            public const int Hex4_length = 7;

            public const int Hex5_address = 97944;
            public const int Hex5_length = 31;

            public const int Hex6_address = 97976;
            public const int Hex6_length = 11;

            public const int Hex7_address = 97988;
            public const int Hex7_length = 11;

            public const int Hex8_address = 98000;
            public const int Hex8_length = 11;

            public const int Hex9_address = 98012;
            public const int Hex9_length = 7;

            public const int Hex10_address = 98020;
            public const int Hex10_length = 47;

            public const int Hex11_address = 98068;
            public const int Hex11_length = 23;

            public const int Hex12_address = 98092;
            public const int Hex12_length = 7;

            public const int Hex13_address = 98100;
            public const int Hex13_length = 47;

            public const int Hex14_address = 98148;
            public const int Hex14_length = 47;

            public const int Hex15_address = 98196;
            public const int Hex15_length = 27;

            public const int Hex16_address = 98224;
            public const int Hex16_length = 55;

            public const int Hex17_address = 98280;
            public const int Hex17_length = 23;

            public const int Hex18_address = 98304;
            public const int Hex18_length = 23;

            public const int Hex19_address = 98328;
            public const int Hex19_length = 51;

            public const int Hex20_address = 98380;
            public const int Hex20_length = 31;

            public const int Hex21_address = 98412;
            public const int Hex21_length = 39;

            public const int Hex22_address = 98452;
            public const int Hex22_length = 47;

            public const int Hex23_address = 98500;
            public const int Hex23_length = 19;

            public const int Hex24_address = 98520;
            public const int Hex24_length = 23;

            public const int Hex25_address = 98544;
            public const int Hex25_length = 31;

            //геймплей
            public const int Hex26_address = 103188;
            public const int Hex26_length = 23;

            public const int Hex27_address = 103212;
            public const int Hex27_length = 19;

            public const int Hex28_address = 103232;
            public const int Hex28_length = 31;

            public const int Hex29_address = 103264;
            public const int Hex29_length = 39;

            public const int Hex30_address = 103304;
            public const int Hex30_length = 39;

            public const int Hex31_address = 103344;
            public const int Hex31_length = 51;

            public const int Hex32_address = 103396;
            public const int Hex32_length = 47;

            public const int Hex33_address = 103444;
            public const int Hex33_length = 43;

            public const int Hex34_address = 103488;
            public const int Hex34_length = 31;

            public const int Hex35_address = 103520;
            public const int Hex35_length = 51;

            public const int Hex36_address = 103572;
            public const int Hex36_length = 27;

            public const int Hex37_address = 103600;
            public const int Hex37_length = 51;

            public const int Hex38_address = 103652;
            public const int Hex38_length = 39;

            public const int Hex39_address = 103692;
            public const int Hex39_length = 51;

            public const int Hex40_address = 103744;
            public const int Hex40_length = 39;

            public const int Hex41_address = 103784;
            public const int Hex41_length = 47;

            public const int Hex42_address = 103832;
            public const int Hex42_length = 43;

            public const int Hex43_address = 103876;
            public const int Hex43_length = 43;

            public const int Hex44_address = 103920;
            public const int Hex44_length = 43;

            public const int Hex45_address = 103964;
            public const int Hex45_length = 39;

            public const int Hex46_address = 104004;
            public const int Hex46_length = 31;

            public const int Hex47_address = 104036;
            public const int Hex47_length = 51;

            public const int Hex48_address = 104088;
            public const int Hex48_length = 27;

            public const int Hex49_address = 104116;
            public const int Hex49_length = 51;

            public const int Hex50_address = 104168;
            public const int Hex50_length = 39;

            public const int Hex51_address = 104208;
            public const int Hex51_length = 51;

            public const int Hex52_address = 104260;
            public const int Hex52_length = 39;

            public const int Hex53_address = 104300;
            public const int Hex53_length = 47;

            public const int Hex54_address = 104348;
            public const int Hex54_length = 43;

            public const int Hex55_address = 104392;
            public const int Hex55_length = 43;

            public const int Hex56_address = 104436;
            public const int Hex56_length = 31;

            public const int Hex57_address = 104468;
            public const int Hex57_length = 35;

            public const int Hex58_address = 104504;
            public const int Hex58_length = 19;

            public const int Hex59_address = 104524;
            public const int Hex59_length = 23;

            //катсцена
            public const int Hex60_address = 104968;
            public const int Hex60_length = 19;

            public const int Hex61_address = 104988;
            public const int Hex61_length = 39;

            public const int Hex62_address = 105028;
            public const int Hex62_length = 19;

            public const int Hex63_address = 105048;
            public const int Hex63_length = 31;

            public const int Hex64_address = 105140;
            public const int Hex64_length = 31;

            public const int Hex65_address = 105172;
            public const int Hex65_length = 15;

            public const int Hex66_address = 105188;
            public const int Hex66_length = 11;

            public const int Hex67_address = 105200;
            public const int Hex67_length = 19;

            public const int Hex68_address = 105280;
            public const int Hex68_length = 43;

            public const int Hex69_address = 105324;
            public const int Hex69_length = 19;

            public const int Hex70_address = 105344;
            public const int Hex70_length = 19;

            public const int Hex71_address = 105364;
            public const int Hex71_length = 19;

            public const int Hex72_address = 105444;
            public const int Hex72_length = 23;

            public const int Hex73_address = 105468;
            public const int Hex73_length = 39;

            public const int Hex74_address = 105540;
            public const int Hex74_length = 39;

            public const int Hex75_address = 105580;
            public const int Hex75_length = 47;

            public const int Hex76_address = 105676;
            public const int Hex76_length = 19;

            public const int Hex77_address = 105696;
            public const int Hex77_length = 27;

            public const int Hex78_address = 105724;
            public const int Hex78_length = 43;

            public const int Hex79_address = 105768;
            public const int Hex79_length = 47;

            public const int Hex80_address = 105876;
            public const int Hex80_length = 19;

            public const int Hex81_address = 105896;
            public const int Hex81_length = 27;

            public const int Hex82_address = 105924;
            public const int Hex82_length = 27;

            public const int Hex83_address = 105952;
            public const int Hex83_length = 15;

            public const int Hex84_address = 105968;
            public const int Hex84_length = 11;

            public const int Hex85_address = 106052;
            public const int Hex85_length = 19;

            public const int Hex86_address = 106072;
            public const int Hex86_length = 27;

            public const int Hex87_address = 106100;
            public const int Hex87_length = 43;

            public const int Hex88_address = 106144;
            public const int Hex88_length = 47;

            public const int Hex89_address = 106252;
            public const int Hex89_length = 19;

            public const int Hex90_address = 106272;
            public const int Hex90_length = 27;

            public const int Hex91_address = 106300;
            public const int Hex91_length = 27;

            public const int Hex92_address = 106328;
            public const int Hex92_length = 15;

            public const int Hex93_address = 106344;
            public const int Hex93_length = 11;

            public const int Hex94_address = 106428;
            public const int Hex94_length = 19;

            public const int Hex95_address = 106448;
            public const int Hex95_length = 43;

            public const int Hex96_address = 106528;
            public const int Hex96_length = 19;

            public const int Hex97_address = 106548;
            public const int Hex97_length = 43;
        }
        public class COMOD16_COP_info // lines 104
        {
            public const int length = 216836;

            //катсцена
            public const int Hex1_address = 100388;
            public const int Hex1_length = 11;

            public const int Hex2_address = 100400;
            public const int Hex2_length = 27;

            public const int Hex3_address = 100428;
            public const int Hex3_length = 19;

            public const int Hex4_address = 100448;
            public const int Hex4_length = 43;

            public const int Hex5_address = 100492;
            public const int Hex5_length = 15;

            public const int Hex6_address = 100508;
            public const int Hex6_length = 15;

            public const int Hex7_address = 100524;
            public const int Hex7_length = 7;

            public const int Hex8_address = 100532;
            public const int Hex8_length = 7;

            public const int Hex9_address = 100540;
            public const int Hex9_length = 7;

            public const int Hex10_address = 100548;
            public const int Hex10_length = 23;

            public const int Hex11_address = 100572;
            public const int Hex11_length = 39;

            public const int Hex12_address = 100612;
            public const int Hex12_length = 27;

            public const int Hex13_address = 100640;
            public const int Hex13_length = 27;

            //геймплей
            public const int Hex14_address = 102904;
            public const int Hex14_length = 23;

            public const int Hex15_address = 102928;
            public const int Hex15_length = 19;

            public const int Hex16_address = 102948;
            public const int Hex16_length = 39;

            public const int Hex17_address = 102988;
            public const int Hex17_length = 43;

            public const int Hex18_address = 103032;
            public const int Hex18_length = 39;

            public const int Hex19_address = 103072;
            public const int Hex19_length = 43;

            public const int Hex20_address = 103116;
            public const int Hex20_length = 39;

            public const int Hex21_address = 103156;
            public const int Hex21_length = 51;

            public const int Hex22_address = 103208;
            public const int Hex22_length = 39;

            public const int Hex23_address = 103248;
            public const int Hex23_length = 47;

            public const int Hex24_address = 103296;
            public const int Hex24_length = 39;

            public const int Hex25_address = 103336;
            public const int Hex25_length = 47;

            public const int Hex26_address = 103384;
            public const int Hex26_length = 31;

            public const int Hex27_address = 103416;
            public const int Hex27_length = 51;

            public const int Hex28_address = 103468;
            public const int Hex28_length = 35;

            public const int Hex29_address = 103504;
            public const int Hex29_length = 43;

            public const int Hex30_address = 103548;
            public const int Hex30_length = 35;

            public const int Hex31_address = 103584;
            public const int Hex31_length = 43;

            public const int Hex32_address = 103628;
            public const int Hex32_length = 39;

            public const int Hex33_address = 103668;
            public const int Hex33_length = 51;

            public const int Hex34_address = 103720;
            public const int Hex34_length = 35;

            public const int Hex35_address = 103756;
            public const int Hex35_length = 39;

            public const int Hex36_address = 103796;
            public const int Hex36_length = 35;

            public const int Hex37_address = 103832;
            public const int Hex37_length = 39;

            public const int Hex38_address = 103872;
            public const int Hex38_length = 43;

            public const int Hex39_address = 103916;
            public const int Hex39_length = 43;

            public const int Hex40_address = 103960;
            public const int Hex40_length = 39;

            public const int Hex41_address = 104000;
            public const int Hex41_length = 47;

            public const int Hex42_address = 104048;
            public const int Hex42_length = 39;

            public const int Hex43_address = 104088;
            public const int Hex43_length = 47;

            public const int Hex44_address = 104136;
            public const int Hex44_length = 31;

            public const int Hex45_address = 104168;
            public const int Hex45_length = 51;

            public const int Hex46_address = 104220;
            public const int Hex46_length = 35;

            public const int Hex47_address = 104256;
            public const int Hex47_length = 43;

            public const int Hex48_address = 104300;
            public const int Hex48_length = 35;

            public const int Hex49_address = 104336;
            public const int Hex49_length = 43;

            public const int Hex50_address = 104380;
            public const int Hex50_length = 39;

            public const int Hex51_address = 104420;
            public const int Hex51_length = 51;

            public const int Hex52_address = 104472;
            public const int Hex52_length = 35;

            public const int Hex53_address = 104508;
            public const int Hex53_length = 39;

            public const int Hex54_address = 104548;
            public const int Hex54_length = 35;

            public const int Hex55_address = 104584;
            public const int Hex55_length = 39;

            public const int Hex56_address = 104624;
            public const int Hex56_length = 43;

            public const int Hex57_address = 104668;
            public const int Hex57_length = 35;

            public const int Hex58_address = 104704;
            public const int Hex58_length = 35;

            public const int Hex59_address = 104740;
            public const int Hex59_length = 31;

            public const int Hex60_address = 104772;
            public const int Hex60_length = 31;

            public const int Hex61_address = 104804;
            public const int Hex61_length = 31;

            public const int Hex62_address = 104836;
            public const int Hex62_length = 19;

            public const int Hex63_address = 104856;
            public const int Hex63_length = 27;

            public const int Hex64_address = 104884;
            public const int Hex64_length = 31;

            //катсцена
            public const int Hex65_address = 105540;
            public const int Hex65_length = 19;

            public const int Hex66_address = 105560;
            public const int Hex66_length = 39;

            public const int Hex67_address = 105600;
            public const int Hex67_length = 39;

            public const int Hex68_address = 105640;
            public const int Hex68_length = 35;

            public const int Hex69_address = 105736;
            public const int Hex69_length = 31;

            public const int Hex70_address = 105768;
            public const int Hex70_length = 15;

            public const int Hex71_address = 105784;
            public const int Hex71_length = 7;

            public const int Hex72_address = 105792;
            public const int Hex72_length = 23;

            public const int Hex73_address = 105876;
            public const int Hex73_length = 43;

            public const int Hex74_address = 105920;
            public const int Hex74_length = 19;

            public const int Hex75_address = 105940;
            public const int Hex75_length = 19;

            public const int Hex76_address = 105960;
            public const int Hex76_length = 19;

            public const int Hex77_address = 106040;
            public const int Hex77_length = 23;

            public const int Hex78_address = 106064;
            public const int Hex78_length = 39;

            public const int Hex79_address = 106136;
            public const int Hex79_length = 39;

            public const int Hex80_address = 106176;
            public const int Hex80_length = 47;

            public const int Hex81_address = 106272;
            public const int Hex81_length = 19;

            public const int Hex82_address = 106292;
            public const int Hex82_length = 27;

            public const int Hex83_address = 106320;
            public const int Hex83_length = 43;

            public const int Hex84_address = 106364;
            public const int Hex84_length = 43;

            public const int Hex85_address = 106408;
            public const int Hex85_length = 19;

            public const int Hex86_address = 106500;
            public const int Hex86_length = 19;

            public const int Hex87_address = 106520;
            public const int Hex87_length = 27;

            public const int Hex88_address = 106548;
            public const int Hex88_length = 39;

            public const int Hex89_address = 106588;
            public const int Hex89_length = 15;

            public const int Hex90_address = 106604;
            public const int Hex90_length = 15;

            public const int Hex91_address = 106692;
            public const int Hex91_length = 19;

            public const int Hex92_address = 106712;
            public const int Hex92_length = 27;

            public const int Hex93_address = 106740;
            public const int Hex93_length = 43;

            public const int Hex94_address = 106784;
            public const int Hex94_length = 43;

            public const int Hex95_address = 106828;
            public const int Hex95_length = 19;

            public const int Hex96_address = 106920;
            public const int Hex96_length = 19;

            public const int Hex97_address = 106940;
            public const int Hex97_length = 27;

            public const int Hex98_address = 106968;
            public const int Hex98_length = 39;

            public const int Hex99_address = 107008;
            public const int Hex99_length = 15;

            public const int Hex100_address = 107024;
            public const int Hex100_length = 15;

            public const int Hex101_address = 107112;
            public const int Hex101_length = 19;

            public const int Hex102_address = 107132;
            public const int Hex102_length = 43;

            public const int Hex103_address = 107212;
            public const int Hex103_length = 19;

            public const int Hex104_address = 107232;
            public const int Hex104_length = 43;
        }
        public class COMOD17_SNG_info // lines 119
        {
            public const int length = 211908;

            //катсцена
            public const int Hex1_address = 101408;
            public const int Hex1_length = 19;

            public const int Hex2_address = 101428;
            public const int Hex2_length = 11;

            public const int Hex3_address = 101440;
            public const int Hex3_length = 47;

            public const int Hex4_address = 101488;
            public const int Hex4_length = 51;

            public const int Hex5_address = 101540;
            public const int Hex5_length = 15;

            public const int Hex6_address = 101556;
            public const int Hex6_length = 23;

            public const int Hex7_address = 101580;
            public const int Hex7_length = 35;

            public const int Hex8_address = 101616;
            public const int Hex8_length = 19;

            public const int Hex9_address = 101636;
            public const int Hex9_length = 51;

            public const int Hex10_address = 101688;
            public const int Hex10_length = 43;

            public const int Hex11_address = 101732;
            public const int Hex11_length = 19;

            public const int Hex12_address = 101752;
            public const int Hex12_length = 11;

            public const int Hex13_address = 101764;
            public const int Hex13_length = 39;

            public const int Hex14_address = 101804;
            public const int Hex14_length = 51;

            public const int Hex15_address = 101856;
            public const int Hex15_length = 27;

            public const int Hex16_address = 101884;
            public const int Hex16_length = 7;

            public const int Hex17_address = 101892;
            public const int Hex17_length = 51;

            public const int Hex18_address = 101944;
            public const int Hex18_length = 11;

            public const int Hex19_address = 101956;
            public const int Hex19_length = 19;

            public const int Hex20_address = 101976;
            public const int Hex20_length = 47;

            public const int Hex21_address = 102024;
            public const int Hex21_length = 51;

            public const int Hex22_address = 102076;
            public const int Hex22_length = 19;

            public const int Hex23_address = 102096;
            public const int Hex23_length = 15;

            public const int Hex24_address = 102112;
            public const int Hex24_length = 39;

            public const int Hex25_address = 102152;
            public const int Hex25_length = 15;

            public const int Hex26_address = 102168;
            public const int Hex26_length = 39;

            public const int Hex27_address = 102208;
            public const int Hex27_length = 31;

            public const int Hex28_address = 102240;
            public const int Hex28_length = 15;

            public const int Hex29_address = 102256;
            public const int Hex29_length = 19;

            public const int Hex30_address = 102276;
            public const int Hex30_length = 35;

            public const int Hex31_address = 102312;
            public const int Hex31_length = 39;

            public const int Hex32_address = 102352;
            public const int Hex32_length = 47;

            public const int Hex33_address = 102400;
            public const int Hex33_length = 15;

            public const int Hex34_address = 102416;
            public const int Hex34_length = 43;

            public const int Hex35_address = 102460;
            public const int Hex35_length = 31;

            public const int Hex36_address = 102492;
            public const int Hex36_length = 59;

            public const int Hex37_address = 102552;
            public const int Hex37_length = 27;

            public const int Hex38_address = 102580;
            public const int Hex38_length = 39;

            public const int Hex39_address = 102620;
            public const int Hex39_length = 31;

            //геймплей
            public const int Hex40_address = 109436;
            public const int Hex40_length = 19;

            public const int Hex41_address = 109456;
            public const int Hex41_length = 23;

            public const int Hex42_address = 109480;
            public const int Hex42_length = 19;

            public const int Hex43_address = 109500;
            public const int Hex43_length = 19;

            public const int Hex44_address = 109520;
            public const int Hex44_length = 19;

            public const int Hex45_address = 109540;
            public const int Hex45_length = 11;

            public const int Hex46_address = 109552;
            public const int Hex46_length = 31;

            public const int Hex47_address = 109584;
            public const int Hex47_length = 23;

            public const int Hex48_address = 109608;
            public const int Hex48_length = 39;

            public const int Hex49_address = 109648;
            public const int Hex49_length = 39;

            public const int Hex50_address = 109688;
            public const int Hex50_length = 31;

            public const int Hex51_address = 109720;
            public const int Hex51_length = 27;

            public const int Hex52_address = 109748;
            public const int Hex52_length = 23;

            public const int Hex53_address = 109772;
            public const int Hex53_length = 23;

            public const int Hex54_address = 109796;
            public const int Hex54_length = 27;

            public const int Hex55_address = 109824;
            public const int Hex55_length = 31;

            public const int Hex56_address = 109856;
            public const int Hex56_length = 19;

            public const int Hex57_address = 109876;
            public const int Hex57_length = 19;

            public const int Hex58_address = 109896;
            public const int Hex58_length = 23;

            public const int Hex59_address = 109920;
            public const int Hex59_length = 19;

            public const int Hex60_address = 109940;
            public const int Hex60_length = 19;

            public const int Hex61_address = 109960;
            public const int Hex61_length = 19;

            public const int Hex62_address = 109980;
            public const int Hex62_length = 19;

            public const int Hex63_address = 110000;
            public const int Hex63_length = 19;

            public const int Hex64_address = 110020;
            public const int Hex64_length = 11;

            public const int Hex65_address = 110032;
            public const int Hex65_length = 15;

            public const int Hex66_address = 110048;
            public const int Hex66_length = 15;

            public const int Hex67_address = 110064;
            public const int Hex67_length = 19;

            public const int Hex68_address = 110084;
            public const int Hex68_length = 15;

            public const int Hex69_address = 110100;
            public const int Hex69_length = 19;

            public const int Hex70_address = 110120;
            public const int Hex70_length = 23;

            public const int Hex71_address = 110144;
            public const int Hex71_length = 43;

            public const int Hex72_address = 110188;
            public const int Hex72_length = 47;

            public const int Hex73_address = 110236;
            public const int Hex73_length = 31;

            public const int Hex74_address = 110268;
            public const int Hex74_length = 27;

            public const int Hex75_address = 110296;
            public const int Hex75_length = 31;

            public const int Hex76_address = 110328;
            public const int Hex76_length = 27;

            public const int Hex77_address = 110356;
            public const int Hex77_length = 27;

            public const int Hex78_address = 110384;
            public const int Hex78_length = 31;

            public const int Hex79_address = 110416;
            public const int Hex79_length = 19;

            public const int Hex80_address = 110436;
            public const int Hex80_length = 19;

            public const int Hex81_address = 110456;
            public const int Hex81_length = 23;

            public const int Hex82_address = 110480;
            public const int Hex82_length = 19;

            public const int Hex83_address = 110500;
            public const int Hex83_length = 19;

            public const int Hex84_address = 110520;
            public const int Hex84_length = 19;

            public const int Hex85_address = 110540;
            public const int Hex85_length = 19;

            public const int Hex86_address = 110560;
            public const int Hex86_length = 19;

            public const int Hex87_address = 110580;
            public const int Hex87_length = 11;

            public const int Hex88_address = 110592;
            public const int Hex88_length = 15;

            public const int Hex89_address = 110608;
            public const int Hex89_length = 15;

            public const int Hex90_address = 110624;
            public const int Hex90_length = 19;

            public const int Hex91_address = 110644;
            public const int Hex91_length = 15;

            public const int Hex92_address = 110660;
            public const int Hex92_length = 19;

            public const int Hex93_address = 110680;
            public const int Hex93_length = 19;

            public const int Hex94_address = 110700;
            public const int Hex94_length = 23;

            public const int Hex95_address = 110724;
            public const int Hex95_length = 11;

            public const int Hex96_address = 110736;
            public const int Hex96_length = 23;

            public const int Hex97_address = 110760;
            public const int Hex97_length = 19;

            public const int Hex98_address = 110780;
            public const int Hex98_length = 35;

            public const int Hex99_address = 111536;
            public const int Hex99_length = 43;

            public const int Hex100_address = 111580;
            public const int Hex100_length = 43;

            public const int Hex101_address = 111624;
            public const int Hex101_length = 23;

            public const int Hex102_address = 111696;
            public const int Hex102_length = 19;

            public const int Hex103_address = 111716;
            public const int Hex103_length = 19;

            public const int Hex104_address = 111736;
            public const int Hex104_length = 23;

            public const int Hex105_address = 111760;
            public const int Hex105_length = 11;

            public const int Hex106_address = 111772;
            public const int Hex106_length = 23;

            public const int Hex107_address = 111796;
            public const int Hex107_length = 19;

            public const int Hex108_address = 111816;
            public const int Hex108_length = 35;

            public const int Hex109_address = 111948;
            public const int Hex109_length = 19;

            public const int Hex110_address = 111968;
            public const int Hex110_length = 19;

            public const int Hex111_address = 111988;
            public const int Hex111_length = 23;

            public const int Hex112_address = 112012;
            public const int Hex112_length = 31;

            public const int Hex113_address = 112044;
            public const int Hex113_length = 35;

            public const int Hex114_address = 112080;
            public const int Hex114_length = 27;

            public const int Hex115_address = 112108;
            public const int Hex115_length = 7;

            public const int Hex116_address = 112116;
            public const int Hex116_length = 39;

            public const int Hex117_address = 112264;
            public const int Hex117_length = 43;

            public const int Hex118_address = 112328;
            public const int Hex118_length = 31;

            public const int Hex119_address = 112360;
            public const int Hex119_length = 27;
        }

        public Editor()
        {
            InitializeComponent();
            start_file();
            using (FileStream fstream = File.OpenRead(Open_File.OpenFile.FilePath))
            {
                //file2byte
                byte[] bitarray = new byte[fstream.Length];
                fstream.Read(bitarray, 0, bitarray.Length);
                file.save = bitarray;
                fstream.Close();
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

                //hex15
                Hex15.MaxLength = file.hex15_length * 2 + (file.hex15_length - 1);
                Text15.MaxLength = file.hex15_length;

                Hex15.Text = BitConverter.ToString(bitarray, file.hex15_address, file.hex15_length);
                Text15.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex15.Text));

                file.L15Length = Text15.Text.Length;
                Length15.Text = file.L15Length.ToString();
                file.L15Last = file.hex15_length - file.L15Length;
                Last15.Text = file.L15Last.ToString();
                file.hex15 = Hex15.Text;

                //hex16
                Hex16.MaxLength = file.hex16_length * 2 + (file.hex16_length - 1);
                Text16.MaxLength = file.hex16_length;

                Hex16.Text = BitConverter.ToString(bitarray, file.hex16_address, file.hex16_length);
                Text16.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex16.Text));

                file.L16Length = Text16.Text.Length;
                Length16.Text = file.L16Length.ToString();
                file.L16Last = file.hex16_length - file.L16Length;
                Last16.Text = file.L16Last.ToString();
                file.hex16 = Hex16.Text;

                //hex17
                Hex17.MaxLength = file.hex17_length * 2 + (file.hex17_length - 1);
                Text17.MaxLength = file.hex17_length;

                Hex17.Text = BitConverter.ToString(bitarray, file.hex17_address, file.hex17_length);
                Text17.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex17.Text));

                file.L17Length = Text17.Text.Length;
                Length17.Text = file.L17Length.ToString();
                file.L17Last = file.hex17_length - file.L17Length;
                Last17.Text = file.L17Last.ToString();
                file.hex17 = Hex17.Text;

                //hex18
                Hex18.MaxLength = file.hex18_length * 2 + (file.hex18_length - 1);
                Text18.MaxLength = file.hex18_length;

                Hex18.Text = BitConverter.ToString(bitarray, file.hex18_address, file.hex18_length);
                Text18.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex18.Text));

                file.L18Length = Text18.Text.Length;
                Length18.Text = file.L18Length.ToString();
                file.L18Last = file.hex18_length - file.L18Length;
                Last18.Text = file.L18Last.ToString();
                file.hex18 = Hex18.Text;

                //hex19
                Hex19.MaxLength = file.hex19_length * 2 + (file.hex19_length - 1);
                Text19.MaxLength = file.hex19_length;

                Hex19.Text = BitConverter.ToString(bitarray, file.hex19_address, file.hex19_length);
                Text19.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex19.Text));

                file.L19Length = Text19.Text.Length;
                Length19.Text = file.L19Length.ToString();
                file.L19Last = file.hex19_length - file.L19Length;
                Last19.Text = file.L19Last.ToString();
                file.hex19 = Hex19.Text;

                //hex20
                Hex20.MaxLength = file.hex20_length * 2 + (file.hex20_length - 1);
                Text20.MaxLength = file.hex20_length;

                Hex20.Text = BitConverter.ToString(bitarray, file.hex20_address, file.hex20_length);
                Text20.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex20.Text));

                file.L20Length = Text20.Text.Length;
                Length20.Text = file.L20Length.ToString();
                file.L20Last = file.hex20_length - file.L20Length;
                Last20.Text = file.L20Last.ToString();
                file.hex20 = Hex20.Text;

                //hex21
                Hex21.MaxLength = file.hex21_length * 2 + (file.hex21_length - 1);
                Text21.MaxLength = file.hex21_length;

                Hex21.Text = BitConverter.ToString(bitarray, file.hex21_address, file.hex21_length);
                Text21.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex21.Text));

                file.L21Length = Text21.Text.Length;
                Length21.Text = file.L21Length.ToString();
                file.L21Last = file.hex21_length - file.L21Length;
                Last21.Text = file.L21Last.ToString();
                file.hex21 = Hex21.Text;

                //hex22
                Hex22.MaxLength = file.hex22_length * 2 + (file.hex22_length - 1);
                Text22.MaxLength = file.hex22_length;

                Hex22.Text = BitConverter.ToString(bitarray, file.hex22_address, file.hex22_length);
                Text22.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex22.Text));

                file.L22Length = Text22.Text.Length;
                Length22.Text = file.L22Length.ToString();
                file.L22Last = file.hex22_length - file.L22Length;
                Last22.Text = file.L22Last.ToString();
                file.hex22 = Hex22.Text;

                //hex23
                Hex23.MaxLength = file.hex23_length * 2 + (file.hex23_length - 1);
                Text23.MaxLength = file.hex23_length;

                Hex23.Text = BitConverter.ToString(bitarray, file.hex23_address, file.hex23_length);
                Text23.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex23.Text));

                file.L23Length = Text23.Text.Length;
                Length23.Text = file.L23Length.ToString();
                file.L23Last = file.hex23_length - file.L23Length;
                Last23.Text = file.L23Last.ToString();
                file.hex23 = Hex23.Text;

                //hex24
                Hex24.MaxLength = file.hex24_length * 2 + (file.hex24_length - 1);
                Text24.MaxLength = file.hex24_length;

                Hex24.Text = BitConverter.ToString(bitarray, file.hex24_address, file.hex24_length);
                Text24.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex24.Text));

                file.L24Length = Text24.Text.Length;
                Length24.Text = file.L24Length.ToString();
                file.L24Last = file.hex24_length - file.L24Length;
                Last24.Text = file.L24Last.ToString();
                file.hex24 = Hex24.Text;

                //hex25
                Hex25.MaxLength = file.hex25_length * 2 + (file.hex25_length - 1);
                Text25.MaxLength = file.hex25_length;

                Hex25.Text = BitConverter.ToString(bitarray, file.hex25_address, file.hex25_length);
                Text25.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex25.Text));

                file.L25Length = Text25.Text.Length;
                Length25.Text = file.L25Length.ToString();
                file.L25Last = file.hex25_length - file.L25Length;
                Last25.Text = file.L25Last.ToString();
                file.hex25 = Hex25.Text;

                //hex26
                Hex26.MaxLength = file.hex26_length * 2 + (file.hex26_length - 1);
                Text26.MaxLength = file.hex26_length;

                Hex26.Text = BitConverter.ToString(bitarray, file.hex26_address, file.hex26_length);
                Text26.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex26.Text));

                file.L26Length = Text26.Text.Length;
                Length26.Text = file.L26Length.ToString();
                file.L26Last = file.hex26_length - file.L26Length;
                Last26.Text = file.L26Last.ToString();
                file.hex26 = Hex26.Text;

                //hex27
                Hex27.MaxLength = file.hex27_length * 2 + (file.hex27_length - 1);
                Text27.MaxLength = file.hex27_length;

                Hex27.Text = BitConverter.ToString(bitarray, file.hex27_address, file.hex27_length);
                Text27.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex27.Text));

                file.L27Length = Text27.Text.Length;
                Length27.Text = file.L27Length.ToString();
                file.L27Last = file.hex27_length - file.L27Length;
                Last27.Text = file.L27Last.ToString();
                file.hex27 = Hex27.Text;

                //hex28
                Hex28.MaxLength = file.hex28_length * 2 + (file.hex28_length - 1);
                Text28.MaxLength = file.hex28_length;

                Hex28.Text = BitConverter.ToString(bitarray, file.hex28_address, file.hex28_length);
                Text28.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex28.Text));

                file.L28Length = Text28.Text.Length;
                Length28.Text = file.L28Length.ToString();
                file.L28Last = file.hex28_length - file.L28Length;
                Last28.Text = file.L28Last.ToString();
                file.hex28 = Hex28.Text;

                //hex29
                Hex29.MaxLength = file.hex29_length * 2 + (file.hex29_length - 1);
                Text29.MaxLength = file.hex29_length;

                Hex29.Text = BitConverter.ToString(bitarray, file.hex29_address, file.hex29_length);
                Text29.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex29.Text));

                file.L29Length = Text29.Text.Length;
                Length29.Text = file.L29Length.ToString();
                file.L29Last = file.hex29_length - file.L29Length;
                Last29.Text = file.L29Last.ToString();
                file.hex29 = Hex29.Text;

                //hex30
                Hex30.MaxLength = file.hex30_length * 2 + (file.hex30_length - 1);
                Text30.MaxLength = file.hex30_length;

                Hex30.Text = BitConverter.ToString(bitarray, file.hex30_address, file.hex30_length);
                Text30.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex30.Text));

                file.L30Length = Text30.Text.Length;
                Length30.Text = file.L30Length.ToString();
                file.L30Last = file.hex30_length - file.L30Length;
                Last30.Text = file.L30Last.ToString();
                file.hex30 = Hex30.Text;

                //hex31
                Hex31.MaxLength = file.hex31_length * 2 + (file.hex31_length - 1);
                Text31.MaxLength = file.hex31_length;

                Hex31.Text = BitConverter.ToString(bitarray, file.hex31_address, file.hex31_length);
                Text31.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex31.Text));

                file.L31Length = Text31.Text.Length;
                Length31.Text = file.L31Length.ToString();
                file.L31Last = file.hex31_length - file.L31Length;
                Last31.Text = file.L31Last.ToString();
                file.hex31 = Hex31.Text;

                //hex32
                Hex32.MaxLength = file.hex32_length * 2 + (file.hex32_length - 1);
                Text32.MaxLength = file.hex32_length;

                Hex32.Text = BitConverter.ToString(bitarray, file.hex32_address, file.hex32_length);
                Text32.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex32.Text));

                file.L32Length = Text32.Text.Length;
                Length32.Text = file.L32Length.ToString();
                file.L32Last = file.hex32_length - file.L32Length;
                Last32.Text = file.L32Last.ToString();
                file.hex32 = Hex32.Text;

                //hex33
                Hex33.MaxLength = file.hex33_length * 2 + (file.hex33_length - 1);
                Text33.MaxLength = file.hex33_length;

                Hex33.Text = BitConverter.ToString(bitarray, file.hex33_address, file.hex33_length);
                Text33.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex33.Text));

                file.L33Length = Text33.Text.Length;
                Length33.Text = file.L33Length.ToString();
                file.L33Last = file.hex33_length - file.L33Length;
                Last33.Text = file.L33Last.ToString();
                file.hex33 = Hex33.Text;

                //hex34
                Hex34.MaxLength = file.hex34_length * 2 + (file.hex34_length - 1);
                Text34.MaxLength = file.hex34_length;

                Hex34.Text = BitConverter.ToString(bitarray, file.hex34_address, file.hex34_length);
                Text34.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex34.Text));

                file.L34Length = Text34.Text.Length;
                Length34.Text = file.L34Length.ToString();
                file.L34Last = file.hex34_length - file.L34Length;
                Last34.Text = file.L34Last.ToString();
                file.hex34 = Hex34.Text;

                //hex35
                Hex35.MaxLength = file.hex35_length * 2 + (file.hex35_length - 1);
                Text35.MaxLength = file.hex35_length;

                Hex35.Text = BitConverter.ToString(bitarray, file.hex35_address, file.hex35_length);
                Text35.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex35.Text));

                file.L35Length = Text35.Text.Length;
                Length35.Text = file.L35Length.ToString();
                file.L35Last = file.hex35_length - file.L35Length;
                Last35.Text = file.L35Last.ToString();
                file.hex35 = Hex35.Text;

                //hex36
                Hex36.MaxLength = file.hex36_length * 2 + (file.hex36_length - 1);
                Text36.MaxLength = file.hex36_length;

                Hex36.Text = BitConverter.ToString(bitarray, file.hex36_address, file.hex36_length);
                Text36.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex36.Text));

                file.L36Length = Text36.Text.Length;
                Length36.Text = file.L36Length.ToString();
                file.L36Last = file.hex36_length - file.L36Length;
                Last36.Text = file.L36Last.ToString();
                file.hex36 = Hex36.Text;

                //hex37
                Hex37.MaxLength = file.hex37_length * 2 + (file.hex37_length - 1);
                Text37.MaxLength = file.hex37_length;

                Hex37.Text = BitConverter.ToString(bitarray, file.hex37_address, file.hex37_length);
                Text37.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex37.Text));

                file.L37Length = Text37.Text.Length;
                Length37.Text = file.L37Length.ToString();
                file.L37Last = file.hex37_length - file.L37Length;
                Last37.Text = file.L37Last.ToString();
                file.hex37 = Hex37.Text;

                //hex38
                Hex38.MaxLength = file.hex38_length * 2 + (file.hex38_length - 1);
                Text38.MaxLength = file.hex38_length;

                Hex38.Text = BitConverter.ToString(bitarray, file.hex38_address, file.hex38_length);
                Text38.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex38.Text));

                file.L38Length = Text38.Text.Length;
                Length38.Text = file.L38Length.ToString();
                file.L38Last = file.hex38_length - file.L38Length;
                Last38.Text = file.L38Last.ToString();
                file.hex38 = Hex38.Text;

                //hex39
                Hex39.MaxLength = file.hex39_length * 2 + (file.hex39_length - 1);
                Text39.MaxLength = file.hex39_length;

                Hex39.Text = BitConverter.ToString(bitarray, file.hex39_address, file.hex39_length);
                Text39.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex39.Text));

                file.L39Length = Text39.Text.Length;
                Length39.Text = file.L39Length.ToString();
                file.L39Last = file.hex39_length - file.L39Length;
                Last39.Text = file.L39Last.ToString();
                file.hex39 = Hex39.Text;

                //hex40
                Hex40.MaxLength = file.hex40_length * 2 + (file.hex40_length - 1);
                Text40.MaxLength = file.hex40_length;

                Hex40.Text = BitConverter.ToString(bitarray, file.hex40_address, file.hex40_length);
                Text40.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex40.Text));

                file.L40Length = Text40.Text.Length;
                Length40.Text = file.L40Length.ToString();
                file.L40Last = file.hex40_length - file.L40Length;
                Last40.Text = file.L40Last.ToString();
                file.hex40 = Hex40.Text;

                //hex41
                Hex41.MaxLength = file.hex41_length * 2 + (file.hex41_length - 1);
                Text41.MaxLength = file.hex41_length;

                Hex41.Text = BitConverter.ToString(bitarray, file.hex41_address, file.hex41_length);
                Text41.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex41.Text));

                file.L41Length = Text41.Text.Length;
                Length41.Text = file.L41Length.ToString();
                file.L41Last = file.hex41_length - file.L41Length;
                Last41.Text = file.L41Last.ToString();
                file.hex41 = Hex41.Text;

                //hex42
                Hex42.MaxLength = file.hex42_length * 2 + (file.hex42_length - 1);
                Text42.MaxLength = file.hex42_length;

                Hex42.Text = BitConverter.ToString(bitarray, file.hex42_address, file.hex42_length);
                Text42.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex42.Text));

                file.L42Length = Text42.Text.Length;
                Length42.Text = file.L42Length.ToString();
                file.L42Last = file.hex42_length - file.L42Length;
                Last42.Text = file.L42Last.ToString();
                file.hex42 = Hex42.Text;

                //hex43
                Hex43.MaxLength = file.hex43_length * 2 + (file.hex43_length - 1);
                Text43.MaxLength = file.hex43_length;

                Hex43.Text = BitConverter.ToString(bitarray, file.hex43_address, file.hex43_length);
                Text43.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex43.Text));

                file.L43Length = Text43.Text.Length;
                Length43.Text = file.L43Length.ToString();
                file.L43Last = file.hex43_length - file.L43Length;
                Last43.Text = file.L43Last.ToString();
                file.hex43 = Hex43.Text;

                //hex44
                Hex44.MaxLength = file.hex44_length * 2 + (file.hex44_length - 1);
                Text44.MaxLength = file.hex44_length;

                Hex44.Text = BitConverter.ToString(bitarray, file.hex44_address, file.hex44_length);
                Text44.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex44.Text));

                file.L44Length = Text44.Text.Length;
                Length44.Text = file.L44Length.ToString();
                file.L44Last = file.hex44_length - file.L44Length;
                Last44.Text = file.L44Last.ToString();
                file.hex44 = Hex44.Text;

                //hex45
                Hex45.MaxLength = file.hex45_length * 2 + (file.hex45_length - 1);
                Text45.MaxLength = file.hex45_length;

                Hex45.Text = BitConverter.ToString(bitarray, file.hex45_address, file.hex45_length);
                Text45.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex45.Text));

                file.L45Length = Text45.Text.Length;
                Length45.Text = file.L45Length.ToString();
                file.L45Last = file.hex45_length - file.L45Length;
                Last45.Text = file.L45Last.ToString();
                file.hex45 = Hex45.Text;

                //hex46
                Hex46.MaxLength = file.hex46_length * 2 + (file.hex46_length - 1);
                Text46.MaxLength = file.hex46_length;

                Hex46.Text = BitConverter.ToString(bitarray, file.hex46_address, file.hex46_length);
                Text46.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex46.Text));

                file.L46Length = Text46.Text.Length;
                Length46.Text = file.L46Length.ToString();
                file.L46Last = file.hex46_length - file.L46Length;
                Last46.Text = file.L46Last.ToString();
                file.hex46 = Hex46.Text;

                //hex47
                Hex47.MaxLength = file.hex47_length * 2 + (file.hex47_length - 1);
                Text47.MaxLength = file.hex47_length;

                Hex47.Text = BitConverter.ToString(bitarray, file.hex47_address, file.hex47_length);
                Text47.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex47.Text));

                file.L47Length = Text47.Text.Length;
                Length47.Text = file.L47Length.ToString();
                file.L47Last = file.hex47_length - file.L47Length;
                Last47.Text = file.L47Last.ToString();
                file.hex47 = Hex47.Text;

                //hex48
                Hex48.MaxLength = file.hex48_length * 2 + (file.hex48_length - 1);
                Text48.MaxLength = file.hex48_length;

                Hex48.Text = BitConverter.ToString(bitarray, file.hex48_address, file.hex48_length);
                Text48.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex48.Text));

                file.L48Length = Text48.Text.Length;
                Length48.Text = file.L48Length.ToString();
                file.L48Last = file.hex48_length - file.L48Length;
                Last48.Text = file.L48Last.ToString();
                file.hex48 = Hex48.Text;

                //hex49
                Hex49.MaxLength = file.hex49_length * 2 + (file.hex49_length - 1);
                Text49.MaxLength = file.hex49_length;

                Hex49.Text = BitConverter.ToString(bitarray, file.hex49_address, file.hex49_length);
                Text49.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex49.Text));

                file.L49Length = Text49.Text.Length;
                Length49.Text = file.L49Length.ToString();
                file.L49Last = file.hex49_length - file.L49Length;
                Last49.Text = file.L49Last.ToString();
                file.hex49 = Hex49.Text;

                //hex50
                Hex50.MaxLength = file.hex50_length * 2 + (file.hex50_length - 1);
                Text50.MaxLength = file.hex50_length;

                Hex50.Text = BitConverter.ToString(bitarray, file.hex50_address, file.hex50_length);
                Text50.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex50.Text));

                file.L50Length = Text50.Text.Length;
                Length50.Text = file.L50Length.ToString();
                file.L50Last = file.hex50_length - file.L50Length;
                Last50.Text = file.L50Last.ToString();
                file.hex50 = Hex50.Text;

                //hex51
                Hex51.MaxLength = file.hex51_length * 2 + (file.hex51_length - 1);
                Text51.MaxLength = file.hex51_length;

                Hex51.Text = BitConverter.ToString(bitarray, file.hex51_address, file.hex51_length);
                Text51.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex51.Text));

                file.L51Length = Text51.Text.Length;
                Length51.Text = file.L51Length.ToString();
                file.L51Last = file.hex51_length - file.L51Length;
                Last51.Text = file.L51Last.ToString();
                file.hex51 = Hex51.Text;

                //hex52
                Hex52.MaxLength = file.hex52_length * 2 + (file.hex52_length - 1);
                Text52.MaxLength = file.hex52_length;

                Hex52.Text = BitConverter.ToString(bitarray, file.hex52_address, file.hex52_length);
                Text52.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex52.Text));

                file.L52Length = Text52.Text.Length;
                Length52.Text = file.L52Length.ToString();
                file.L52Last = file.hex52_length - file.L52Length;
                Last52.Text = file.L52Last.ToString();
                file.hex52 = Hex52.Text;

                //hex53
                Hex53.MaxLength = file.hex53_length * 2 + (file.hex53_length - 1);
                Text53.MaxLength = file.hex53_length;

                Hex53.Text = BitConverter.ToString(bitarray, file.hex53_address, file.hex53_length);
                Text53.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex53.Text));

                file.L53Length = Text53.Text.Length;
                Length53.Text = file.L53Length.ToString();
                file.L53Last = file.hex53_length - file.L53Length;
                Last53.Text = file.L53Last.ToString();
                file.hex53 = Hex53.Text;

                //hex54
                Hex54.MaxLength = file.hex54_length * 2 + (file.hex54_length - 1);
                Text54.MaxLength = file.hex54_length;

                Hex54.Text = BitConverter.ToString(bitarray, file.hex54_address, file.hex54_length);
                Text54.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex54.Text));

                file.L54Length = Text54.Text.Length;
                Length54.Text = file.L54Length.ToString();
                file.L54Last = file.hex54_length - file.L54Length;
                Last54.Text = file.L54Last.ToString();
                file.hex54 = Hex54.Text;

                //hex55
                Hex55.MaxLength = file.hex55_length * 2 + (file.hex55_length - 1);
                Text55.MaxLength = file.hex55_length;

                Hex55.Text = BitConverter.ToString(bitarray, file.hex55_address, file.hex55_length);
                Text55.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex55.Text));

                file.L55Length = Text55.Text.Length;
                Length55.Text = file.L55Length.ToString();
                file.L55Last = file.hex55_length - file.L55Length;
                Last55.Text = file.L55Last.ToString();
                file.hex55 = Hex55.Text;

                //hex56
                Hex56.MaxLength = file.hex56_length * 2 + (file.hex56_length - 1);
                Text56.MaxLength = file.hex56_length;

                Hex56.Text = BitConverter.ToString(bitarray, file.hex56_address, file.hex56_length);
                Text56.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex56.Text));

                file.L56Length = Text56.Text.Length;
                Length56.Text = file.L56Length.ToString();
                file.L56Last = file.hex56_length - file.L56Length;
                Last56.Text = file.L56Last.ToString();
                file.hex56 = Hex56.Text;

                //hex57
                Hex57.MaxLength = file.hex57_length * 2 + (file.hex57_length - 1);
                Text57.MaxLength = file.hex57_length;

                Hex57.Text = BitConverter.ToString(bitarray, file.hex57_address, file.hex57_length);
                Text57.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex57.Text));

                file.L57Length = Text57.Text.Length;
                Length57.Text = file.L57Length.ToString();
                file.L57Last = file.hex57_length - file.L57Length;
                Last57.Text = file.L57Last.ToString();
                file.hex57 = Hex57.Text;

                //hex58
                Hex58.MaxLength = file.hex58_length * 2 + (file.hex58_length - 1);
                Text58.MaxLength = file.hex58_length;

                Hex58.Text = BitConverter.ToString(bitarray, file.hex58_address, file.hex58_length);
                Text58.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex58.Text));

                file.L58Length = Text58.Text.Length;
                Length58.Text = file.L58Length.ToString();
                file.L58Last = file.hex58_length - file.L58Length;
                Last58.Text = file.L58Last.ToString();
                file.hex58 = Hex58.Text;

                //hex59
                Hex59.MaxLength = file.hex59_length * 2 + (file.hex59_length - 1);
                Text59.MaxLength = file.hex59_length;

                Hex59.Text = BitConverter.ToString(bitarray, file.hex59_address, file.hex59_length);
                Text59.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex59.Text));

                file.L59Length = Text59.Text.Length;
                Length59.Text = file.L59Length.ToString();
                file.L59Last = file.hex59_length - file.L59Length;
                Last59.Text = file.L59Last.ToString();
                file.hex59 = Hex59.Text;

                //hex60
                Hex60.MaxLength = file.hex60_length * 2 + (file.hex60_length - 1);
                Text60.MaxLength = file.hex60_length;

                Hex60.Text = BitConverter.ToString(bitarray, file.hex60_address, file.hex60_length);
                Text60.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex60.Text));

                file.L60Length = Text60.Text.Length;
                Length60.Text = file.L60Length.ToString();
                file.L60Last = file.hex60_length - file.L60Length;
                Last60.Text = file.L60Last.ToString();
                file.hex60 = Hex60.Text;

                //hex61
                Hex61.MaxLength = file.hex61_length * 2 + (file.hex61_length - 1);
                Text61.MaxLength = file.hex61_length;

                Hex61.Text = BitConverter.ToString(bitarray, file.hex61_address, file.hex61_length);
                Text61.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex61.Text));

                file.L61Length = Text61.Text.Length;
                Length61.Text = file.L61Length.ToString();
                file.L61Last = file.hex61_length - file.L61Length;
                Last61.Text = file.L61Last.ToString();
                file.hex61 = Hex61.Text;

                //hex62
                Hex62.MaxLength = file.hex62_length * 2 + (file.hex62_length - 1);
                Text62.MaxLength = file.hex62_length;

                Hex62.Text = BitConverter.ToString(bitarray, file.hex62_address, file.hex62_length);
                Text62.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex62.Text));

                file.L62Length = Text62.Text.Length;
                Length62.Text = file.L62Length.ToString();
                file.L62Last = file.hex62_length - file.L62Length;
                Last62.Text = file.L62Last.ToString();
                file.hex62 = Hex62.Text;

                //hex63
                Hex63.MaxLength = file.hex63_length * 2 + (file.hex63_length - 1);
                Text63.MaxLength = file.hex63_length;

                Hex63.Text = BitConverter.ToString(bitarray, file.hex63_address, file.hex63_length);
                Text63.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex63.Text));

                file.L63Length = Text63.Text.Length;
                Length63.Text = file.L63Length.ToString();
                file.L63Last = file.hex63_length - file.L63Length;
                Last63.Text = file.L63Last.ToString();
                file.hex63 = Hex63.Text;

                //hex64
                Hex64.MaxLength = file.hex64_length * 2 + (file.hex64_length - 1);
                Text64.MaxLength = file.hex64_length;

                Hex64.Text = BitConverter.ToString(bitarray, file.hex64_address, file.hex64_length);
                Text64.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex64.Text));

                file.L64Length = Text64.Text.Length;
                Length64.Text = file.L64Length.ToString();
                file.L64Last = file.hex64_length - file.L64Length;
                Last64.Text = file.L64Last.ToString();
                file.hex64 = Hex64.Text;

                //hex65
                Hex65.MaxLength = file.hex65_length * 2 + (file.hex65_length - 1);
                Text65.MaxLength = file.hex65_length;

                Hex65.Text = BitConverter.ToString(bitarray, file.hex65_address, file.hex65_length);
                Text65.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex65.Text));

                file.L65Length = Text65.Text.Length;
                Length65.Text = file.L65Length.ToString();
                file.L65Last = file.hex65_length - file.L65Length;
                Last65.Text = file.L65Last.ToString();
                file.hex65 = Hex65.Text;

                //hex66
                Hex66.MaxLength = file.hex66_length * 2 + (file.hex66_length - 1);
                Text66.MaxLength = file.hex66_length;

                Hex66.Text = BitConverter.ToString(bitarray, file.hex66_address, file.hex66_length);
                Text66.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex66.Text));

                file.L66Length = Text66.Text.Length;
                Length66.Text = file.L66Length.ToString();
                file.L66Last = file.hex66_length - file.L66Length;
                Last66.Text = file.L66Last.ToString();
                file.hex66 = Hex66.Text;

                //hex67
                Hex67.MaxLength = file.hex67_length * 2 + (file.hex67_length - 1);
                Text67.MaxLength = file.hex67_length;

                Hex67.Text = BitConverter.ToString(bitarray, file.hex67_address, file.hex67_length);
                Text67.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex67.Text));

                file.L67Length = Text67.Text.Length;
                Length67.Text = file.L67Length.ToString();
                file.L67Last = file.hex67_length - file.L67Length;
                Last67.Text = file.L67Last.ToString();
                file.hex67 = Hex67.Text;

                //hex68
                Hex68.MaxLength = file.hex68_length * 2 + (file.hex68_length - 1);
                Text68.MaxLength = file.hex68_length;

                Hex68.Text = BitConverter.ToString(bitarray, file.hex68_address, file.hex68_length);
                Text68.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex68.Text));

                file.L68Length = Text68.Text.Length;
                Length68.Text = file.L68Length.ToString();
                file.L68Last = file.hex68_length - file.L68Length;
                Last68.Text = file.L68Last.ToString();
                file.hex68 = Hex68.Text;

                //hex69
                Hex69.MaxLength = file.hex69_length * 2 + (file.hex69_length - 1);
                Text69.MaxLength = file.hex69_length;

                Hex69.Text = BitConverter.ToString(bitarray, file.hex69_address, file.hex69_length);
                Text69.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex69.Text));

                file.L69Length = Text69.Text.Length;
                Length69.Text = file.L69Length.ToString();
                file.L69Last = file.hex69_length - file.L69Length;
                Last69.Text = file.L69Last.ToString();
                file.hex69 = Hex69.Text;

                //hex70
                Hex70.MaxLength = file.hex70_length * 2 + (file.hex70_length - 1);
                Text70.MaxLength = file.hex70_length;

                Hex70.Text = BitConverter.ToString(bitarray, file.hex70_address, file.hex70_length);
                Text70.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex70.Text));

                file.L70Length = Text70.Text.Length;
                Length70.Text = file.L70Length.ToString();
                file.L70Last = file.hex70_length - file.L70Length;
                Last70.Text = file.L70Last.ToString();
                file.hex70 = Hex70.Text;

                //hex71
                Hex71.MaxLength = file.hex71_length * 2 + (file.hex71_length - 1);
                Text71.MaxLength = file.hex71_length;

                Hex71.Text = BitConverter.ToString(bitarray, file.hex71_address, file.hex71_length);
                Text71.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex71.Text));

                file.L71Length = Text71.Text.Length;
                Length71.Text = file.L71Length.ToString();
                file.L71Last = file.hex71_length - file.L71Length;
                Last71.Text = file.L71Last.ToString();
                file.hex71 = Hex71.Text;

                //hex72
                Hex72.MaxLength = file.hex72_length * 2 + (file.hex72_length - 1);
                Text72.MaxLength = file.hex72_length;

                Hex72.Text = BitConverter.ToString(bitarray, file.hex72_address, file.hex72_length);
                Text72.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex72.Text));

                file.L72Length = Text72.Text.Length;
                Length72.Text = file.L72Length.ToString();
                file.L72Last = file.hex72_length - file.L72Length;
                Last72.Text = file.L72Last.ToString();
                file.hex72 = Hex72.Text;

                //hex73
                Hex73.MaxLength = file.hex73_length * 2 + (file.hex73_length - 1);
                Text73.MaxLength = file.hex73_length;

                Hex73.Text = BitConverter.ToString(bitarray, file.hex73_address, file.hex73_length);
                Text73.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex73.Text));

                file.L73Length = Text73.Text.Length;
                Length73.Text = file.L73Length.ToString();
                file.L73Last = file.hex73_length - file.L73Length;
                Last73.Text = file.L73Last.ToString();
                file.hex73 = Hex73.Text;

                //hex74
                Hex74.MaxLength = file.hex74_length * 2 + (file.hex74_length - 1);
                Text74.MaxLength = file.hex74_length;

                Hex74.Text = BitConverter.ToString(bitarray, file.hex74_address, file.hex74_length);
                Text74.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex74.Text));

                file.L74Length = Text74.Text.Length;
                Length74.Text = file.L74Length.ToString();
                file.L74Last = file.hex74_length - file.L74Length;
                Last74.Text = file.L74Last.ToString();
                file.hex74 = Hex74.Text;

                //hex75
                Hex75.MaxLength = file.hex75_length * 2 + (file.hex75_length - 1);
                Text75.MaxLength = file.hex75_length;

                Hex75.Text = BitConverter.ToString(bitarray, file.hex75_address, file.hex75_length);
                Text75.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex75.Text));

                file.L75Length = Text75.Text.Length;
                Length75.Text = file.L75Length.ToString();
                file.L75Last = file.hex75_length - file.L75Length;
                Last75.Text = file.L75Last.ToString();
                file.hex75 = Hex75.Text;

                //hex76
                Hex76.MaxLength = file.hex76_length * 2 + (file.hex76_length - 1);
                Text76.MaxLength = file.hex76_length;

                Hex76.Text = BitConverter.ToString(bitarray, file.hex76_address, file.hex76_length);
                Text76.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex76.Text));

                file.L76Length = Text76.Text.Length;
                Length76.Text = file.L76Length.ToString();
                file.L76Last = file.hex76_length - file.L76Length;
                Last76.Text = file.L76Last.ToString();
                file.hex76 = Hex76.Text;

                //hex77
                Hex77.MaxLength = file.hex77_length * 2 + (file.hex77_length - 1);
                Text77.MaxLength = file.hex77_length;

                Hex77.Text = BitConverter.ToString(bitarray, file.hex77_address, file.hex77_length);
                Text77.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex77.Text));

                file.L77Length = Text77.Text.Length;
                Length77.Text = file.L77Length.ToString();
                file.L77Last = file.hex77_length - file.L77Length;
                Last77.Text = file.L77Last.ToString();
                file.hex77 = Hex77.Text;

                //hex78
                Hex78.MaxLength = file.hex78_length * 2 + (file.hex78_length - 1);
                Text78.MaxLength = file.hex78_length;

                Hex78.Text = BitConverter.ToString(bitarray, file.hex78_address, file.hex78_length);
                Text78.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex78.Text));

                file.L78Length = Text78.Text.Length;
                Length78.Text = file.L78Length.ToString();
                file.L78Last = file.hex78_length - file.L78Length;
                Last78.Text = file.L78Last.ToString();
                file.hex78 = Hex78.Text;

                //hex79
                Hex79.MaxLength = file.hex79_length * 2 + (file.hex79_length - 1);
                Text79.MaxLength = file.hex79_length;

                Hex79.Text = BitConverter.ToString(bitarray, file.hex79_address, file.hex79_length);
                Text79.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex79.Text));

                file.L79Length = Text79.Text.Length;
                Length79.Text = file.L79Length.ToString();
                file.L79Last = file.hex79_length - file.L79Length;
                Last79.Text = file.L79Last.ToString();
                file.hex79 = Hex79.Text;

                //hex80
                Hex80.MaxLength = file.hex80_length * 2 + (file.hex80_length - 1);
                Text80.MaxLength = file.hex80_length;

                Hex80.Text = BitConverter.ToString(bitarray, file.hex80_address, file.hex80_length);
                Text80.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex80.Text));

                file.L80Length = Text80.Text.Length;
                Length80.Text = file.L80Length.ToString();
                file.L80Last = file.hex80_length - file.L80Length;
                Last80.Text = file.L80Last.ToString();
                file.hex80 = Hex80.Text;

                //hex81
                Hex81.MaxLength = file.hex81_length * 2 + (file.hex81_length - 1);
                Text81.MaxLength = file.hex81_length;

                Hex81.Text = BitConverter.ToString(bitarray, file.hex81_address, file.hex81_length);
                Text81.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex81.Text));

                file.L81Length = Text81.Text.Length;
                Length81.Text = file.L81Length.ToString();
                file.L81Last = file.hex81_length - file.L81Length;
                Last81.Text = file.L81Last.ToString();
                file.hex81 = Hex81.Text;

                //hex82
                Hex82.MaxLength = file.hex82_length * 2 + (file.hex82_length - 1);
                Text82.MaxLength = file.hex82_length;

                Hex82.Text = BitConverter.ToString(bitarray, file.hex82_address, file.hex82_length);
                Text82.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex82.Text));

                file.L82Length = Text82.Text.Length;
                Length82.Text = file.L82Length.ToString();
                file.L82Last = file.hex82_length - file.L82Length;
                Last82.Text = file.L82Last.ToString();
                file.hex82 = Hex82.Text;

                //hex83
                Hex83.MaxLength = file.hex83_length * 2 + (file.hex83_length - 1);
                Text83.MaxLength = file.hex83_length;

                Hex83.Text = BitConverter.ToString(bitarray, file.hex83_address, file.hex83_length);
                Text83.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex83.Text));

                file.L83Length = Text83.Text.Length;
                Length83.Text = file.L83Length.ToString();
                file.L83Last = file.hex83_length - file.L83Length;
                Last83.Text = file.L83Last.ToString();
                file.hex83 = Hex83.Text;

                //hex84
                Hex84.MaxLength = file.hex84_length * 2 + (file.hex84_length - 1);
                Text84.MaxLength = file.hex84_length;

                Hex84.Text = BitConverter.ToString(bitarray, file.hex84_address, file.hex84_length);
                Text84.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex84.Text));

                file.L84Length = Text84.Text.Length;
                Length84.Text = file.L84Length.ToString();
                file.L84Last = file.hex84_length - file.L84Length;
                Last84.Text = file.L84Last.ToString();
                file.hex84 = Hex84.Text;

                //hex85
                Hex85.MaxLength = file.hex85_length * 2 + (file.hex85_length - 1);
                Text85.MaxLength = file.hex85_length;

                Hex85.Text = BitConverter.ToString(bitarray, file.hex85_address, file.hex85_length);
                Text85.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex85.Text));

                file.L85Length = Text85.Text.Length;
                Length85.Text = file.L85Length.ToString();
                file.L85Last = file.hex85_length - file.L85Length;
                Last85.Text = file.L85Last.ToString();
                file.hex85 = Hex85.Text;

                //hex86
                Hex86.MaxLength = file.hex86_length * 2 + (file.hex86_length - 1);
                Text86.MaxLength = file.hex86_length;

                Hex86.Text = BitConverter.ToString(bitarray, file.hex86_address, file.hex86_length);
                Text86.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex86.Text));

                file.L86Length = Text86.Text.Length;
                Length86.Text = file.L86Length.ToString();
                file.L86Last = file.hex86_length - file.L86Length;
                Last86.Text = file.L86Last.ToString();
                file.hex86 = Hex86.Text;

                //hex87
                Hex87.MaxLength = file.hex87_length * 2 + (file.hex87_length - 1);
                Text87.MaxLength = file.hex87_length;

                Hex87.Text = BitConverter.ToString(bitarray, file.hex87_address, file.hex87_length);
                Text87.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex87.Text));

                file.L87Length = Text87.Text.Length;
                Length87.Text = file.L87Length.ToString();
                file.L87Last = file.hex87_length - file.L87Length;
                Last87.Text = file.L87Last.ToString();
                file.hex87 = Hex87.Text;

                //hex88
                Hex88.MaxLength = file.hex88_length * 2 + (file.hex88_length - 1);
                Text88.MaxLength = file.hex88_length;

                Hex88.Text = BitConverter.ToString(bitarray, file.hex88_address, file.hex88_length);
                Text88.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex88.Text));

                file.L88Length = Text88.Text.Length;
                Length88.Text = file.L88Length.ToString();
                file.L88Last = file.hex88_length - file.L88Length;
                Last88.Text = file.L88Last.ToString();
                file.hex88 = Hex88.Text;

                //hex89
                Hex89.MaxLength = file.hex89_length * 2 + (file.hex89_length - 1);
                Text89.MaxLength = file.hex89_length;

                Hex89.Text = BitConverter.ToString(bitarray, file.hex89_address, file.hex89_length);
                Text89.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex89.Text));

                file.L89Length = Text89.Text.Length;
                Length89.Text = file.L89Length.ToString();
                file.L89Last = file.hex89_length - file.L89Length;
                Last89.Text = file.L89Last.ToString();
                file.hex89 = Hex89.Text;

                //hex90
                Hex90.MaxLength = file.hex90_length * 2 + (file.hex90_length - 1);
                Text90.MaxLength = file.hex90_length;

                Hex90.Text = BitConverter.ToString(bitarray, file.hex90_address, file.hex90_length);
                Text90.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex90.Text));

                file.L90Length = Text90.Text.Length;
                Length90.Text = file.L90Length.ToString();
                file.L90Last = file.hex90_length - file.L90Length;
                Last90.Text = file.L90Last.ToString();
                file.hex90 = Hex90.Text;

                //hex91
                Hex91.MaxLength = file.hex91_length * 2 + (file.hex91_length - 1);
                Text91.MaxLength = file.hex91_length;

                Hex91.Text = BitConverter.ToString(bitarray, file.hex91_address, file.hex91_length);
                Text91.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex91.Text));

                file.L91Length = Text91.Text.Length;
                Length91.Text = file.L91Length.ToString();
                file.L91Last = file.hex91_length - file.L91Length;
                Last91.Text = file.L91Last.ToString();
                file.hex91 = Hex91.Text;

                //hex92
                Hex92.MaxLength = file.hex92_length * 2 + (file.hex92_length - 1);
                Text92.MaxLength = file.hex92_length;

                Hex92.Text = BitConverter.ToString(bitarray, file.hex92_address, file.hex92_length);
                Text92.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex92.Text));

                file.L92Length = Text92.Text.Length;
                Length92.Text = file.L92Length.ToString();
                file.L92Last = file.hex92_length - file.L92Length;
                Last92.Text = file.L92Last.ToString();
                file.hex92 = Hex92.Text;

                //hex93
                Hex93.MaxLength = file.hex93_length * 2 + (file.hex93_length - 1);
                Text93.MaxLength = file.hex93_length;

                Hex93.Text = BitConverter.ToString(bitarray, file.hex93_address, file.hex93_length);
                Text93.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex93.Text));

                file.L93Length = Text93.Text.Length;
                Length93.Text = file.L93Length.ToString();
                file.L93Last = file.hex93_length - file.L93Length;
                Last93.Text = file.L93Last.ToString();
                file.hex93 = Hex93.Text;

                //hex94
                Hex94.MaxLength = file.hex94_length * 2 + (file.hex94_length - 1);
                Text94.MaxLength = file.hex94_length;

                Hex94.Text = BitConverter.ToString(bitarray, file.hex94_address, file.hex94_length);
                Text94.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex94.Text));

                file.L94Length = Text94.Text.Length;
                Length94.Text = file.L94Length.ToString();
                file.L94Last = file.hex94_length - file.L94Length;
                Last94.Text = file.L94Last.ToString();
                file.hex94 = Hex94.Text;

                //hex95
                Hex95.MaxLength = file.hex95_length * 2 + (file.hex95_length - 1);
                Text95.MaxLength = file.hex95_length;

                Hex95.Text = BitConverter.ToString(bitarray, file.hex95_address, file.hex95_length);
                Text95.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex95.Text));

                file.L95Length = Text95.Text.Length;
                Length95.Text = file.L95Length.ToString();
                file.L95Last = file.hex95_length - file.L95Length;
                Last95.Text = file.L95Last.ToString();
                file.hex95 = Hex95.Text;

                //hex96
                Hex96.MaxLength = file.hex96_length * 2 + (file.hex96_length - 1);
                Text96.MaxLength = file.hex96_length;

                Hex96.Text = BitConverter.ToString(bitarray, file.hex96_address, file.hex96_length);
                Text96.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex96.Text));

                file.L96Length = Text96.Text.Length;
                Length96.Text = file.L96Length.ToString();
                file.L96Last = file.hex96_length - file.L96Length;
                Last96.Text = file.L96Last.ToString();
                file.hex96 = Hex96.Text;

                //hex97
                Hex97.MaxLength = file.hex97_length * 2 + (file.hex97_length - 1);
                Text97.MaxLength = file.hex97_length;

                Hex97.Text = BitConverter.ToString(bitarray, file.hex97_address, file.hex97_length);
                Text97.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex97.Text));

                file.L97Length = Text97.Text.Length;
                Length97.Text = file.L97Length.ToString();
                file.L97Last = file.hex97_length - file.L97Length;
                Last97.Text = file.L97Last.ToString();
                file.hex97 = Hex97.Text;

                //hex98
                Hex98.MaxLength = file.hex98_length * 2 + (file.hex98_length - 1);
                Text98.MaxLength = file.hex98_length;

                Hex98.Text = BitConverter.ToString(bitarray, file.hex98_address, file.hex98_length);
                Text98.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex98.Text));

                file.L98Length = Text98.Text.Length;
                Length98.Text = file.L98Length.ToString();
                file.L98Last = file.hex98_length - file.L98Length;
                Last98.Text = file.L98Last.ToString();
                file.hex98 = Hex98.Text;

                //hex99
                Hex99.MaxLength = file.hex99_length * 2 + (file.hex99_length - 1);
                Text99.MaxLength = file.hex99_length;

                Hex99.Text = BitConverter.ToString(bitarray, file.hex99_address, file.hex99_length);
                Text99.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex99.Text));

                file.L99Length = Text99.Text.Length;
                Length99.Text = file.L99Length.ToString();
                file.L99Last = file.hex99_length - file.L99Length;
                Last99.Text = file.L99Last.ToString();
                file.hex99 = Hex99.Text;

                //hex100
                Hex100.MaxLength = file.hex100_length * 2 + (file.hex100_length - 1);
                Text100.MaxLength = file.hex100_length;

                Hex100.Text = BitConverter.ToString(bitarray, file.hex100_address, file.hex100_length);
                Text100.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex100.Text));

                file.L100Length = Text100.Text.Length;
                Length100.Text = file.L100Length.ToString();
                file.L100Last = file.hex100_length - file.L100Length;
                Last100.Text = file.L100Last.ToString();
                file.hex100 = Hex100.Text;

                //hex101
                Hex101.MaxLength = file.hex101_length * 2 + (file.hex101_length - 1);
                Text101.MaxLength = file.hex101_length;

                Hex101.Text = BitConverter.ToString(bitarray, file.hex101_address, file.hex101_length);
                Text101.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex101.Text));

                file.L101Length = Text101.Text.Length;
                Length101.Text = file.L101Length.ToString();
                file.L101Last = file.hex101_length - file.L101Length;
                Last101.Text = file.L101Last.ToString();
                file.hex101 = Hex101.Text;

                //hex102
                Hex102.MaxLength = file.hex102_length * 2 + (file.hex102_length - 1);
                Text102.MaxLength = file.hex102_length;

                Hex102.Text = BitConverter.ToString(bitarray, file.hex102_address, file.hex102_length);
                Text102.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex102.Text));

                file.L102Length = Text102.Text.Length;
                Length102.Text = file.L102Length.ToString();
                file.L102Last = file.hex102_length - file.L102Length;
                Last102.Text = file.L102Last.ToString();
                file.hex102 = Hex102.Text;

                //hex103
                Hex103.MaxLength = file.hex103_length * 2 + (file.hex103_length - 1);
                Text103.MaxLength = file.hex103_length;

                Hex103.Text = BitConverter.ToString(bitarray, file.hex103_address, file.hex103_length);
                Text103.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex103.Text));

                file.L103Length = Text103.Text.Length;
                Length103.Text = file.L103Length.ToString();
                file.L103Last = file.hex103_length - file.L103Length;
                Last103.Text = file.L103Last.ToString();
                file.hex103 = Hex103.Text;

                //hex104
                Hex104.MaxLength = file.hex104_length * 2 + (file.hex104_length - 1);
                Text104.MaxLength = file.hex104_length;

                Hex104.Text = BitConverter.ToString(bitarray, file.hex104_address, file.hex104_length);
                Text104.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex104.Text));

                file.L104Length = Text104.Text.Length;
                Length104.Text = file.L104Length.ToString();
                file.L104Last = file.hex104_length - file.L104Length;
                Last104.Text = file.L104Last.ToString();
                file.hex104 = Hex104.Text;

                //hex105
                Hex105.MaxLength = file.hex105_length * 2 + (file.hex105_length - 1);
                Text105.MaxLength = file.hex105_length;

                Hex105.Text = BitConverter.ToString(bitarray, file.hex105_address, file.hex105_length);
                Text105.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex105.Text));

                file.L105Length = Text105.Text.Length;
                Length105.Text = file.L105Length.ToString();
                file.L105Last = file.hex105_length - file.L105Length;
                Last105.Text = file.L105Last.ToString();
                file.hex105 = Hex105.Text;

                //hex106
                Hex106.MaxLength = file.hex106_length * 2 + (file.hex106_length - 1);
                Text106.MaxLength = file.hex106_length;

                Hex106.Text = BitConverter.ToString(bitarray, file.hex106_address, file.hex106_length);
                Text106.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex106.Text));

                file.L106Length = Text106.Text.Length;
                Length106.Text = file.L106Length.ToString();
                file.L106Last = file.hex106_length - file.L106Length;
                Last106.Text = file.L106Last.ToString();
                file.hex106 = Hex106.Text;

                //hex107
                Hex107.MaxLength = file.hex107_length * 2 + (file.hex107_length - 1);
                Text107.MaxLength = file.hex107_length;

                Hex107.Text = BitConverter.ToString(bitarray, file.hex107_address, file.hex107_length);
                Text107.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex107.Text));

                file.L107Length = Text107.Text.Length;
                Length107.Text = file.L107Length.ToString();
                file.L107Last = file.hex107_length - file.L107Length;
                Last107.Text = file.L107Last.ToString();
                file.hex107 = Hex107.Text;

                //hex108
                Hex108.MaxLength = file.hex108_length * 2 + (file.hex108_length - 1);
                Text108.MaxLength = file.hex108_length;

                Hex108.Text = BitConverter.ToString(bitarray, file.hex108_address, file.hex108_length);
                Text108.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex108.Text));

                file.L108Length = Text108.Text.Length;
                Length108.Text = file.L108Length.ToString();
                file.L108Last = file.hex108_length - file.L108Length;
                Last108.Text = file.L108Last.ToString();
                file.hex108 = Hex108.Text;

                //hex109
                Hex109.MaxLength = file.hex109_length * 2 + (file.hex109_length - 1);
                Text109.MaxLength = file.hex109_length;

                Hex109.Text = BitConverter.ToString(bitarray, file.hex109_address, file.hex109_length);
                Text109.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex109.Text));

                file.L109Length = Text109.Text.Length;
                Length109.Text = file.L109Length.ToString();
                file.L109Last = file.hex109_length - file.L109Length;
                Last109.Text = file.L109Last.ToString();
                file.hex109 = Hex109.Text;

                //hex110
                Hex110.MaxLength = file.hex110_length * 2 + (file.hex110_length - 1);
                Text110.MaxLength = file.hex110_length;

                Hex110.Text = BitConverter.ToString(bitarray, file.hex110_address, file.hex110_length);
                Text110.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex110.Text));

                file.L110Length = Text110.Text.Length;
                Length110.Text = file.L110Length.ToString();
                file.L110Last = file.hex110_length - file.L110Length;
                Last110.Text = file.L110Last.ToString();
                file.hex110 = Hex110.Text;

                //hex111
                Hex111.MaxLength = file.hex111_length * 2 + (file.hex111_length - 1);
                Text111.MaxLength = file.hex111_length;

                Hex111.Text = BitConverter.ToString(bitarray, file.hex111_address, file.hex111_length);
                Text111.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex111.Text));

                file.L111Length = Text111.Text.Length;
                Length111.Text = file.L111Length.ToString();
                file.L111Last = file.hex111_length - file.L111Length;
                Last111.Text = file.L111Last.ToString();
                file.hex111 = Hex111.Text;

                //hex112
                Hex112.MaxLength = file.hex112_length * 2 + (file.hex112_length - 1);
                Text112.MaxLength = file.hex112_length;

                Hex112.Text = BitConverter.ToString(bitarray, file.hex112_address, file.hex112_length);
                Text112.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex112.Text));

                file.L112Length = Text112.Text.Length;
                Length112.Text = file.L112Length.ToString();
                file.L112Last = file.hex112_length - file.L112Length;
                Last112.Text = file.L112Last.ToString();
                file.hex112 = Hex112.Text;

                //hex113
                Hex113.MaxLength = file.hex113_length * 2 + (file.hex113_length - 1);
                Text113.MaxLength = file.hex113_length;

                Hex113.Text = BitConverter.ToString(bitarray, file.hex113_address, file.hex113_length);
                Text113.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex113.Text));

                file.L113Length = Text113.Text.Length;
                Length113.Text = file.L113Length.ToString();
                file.L113Last = file.hex113_length - file.L113Length;
                Last113.Text = file.L113Last.ToString();
                file.hex113 = Hex113.Text;

                //hex114
                Hex114.MaxLength = file.hex114_length * 2 + (file.hex114_length - 1);
                Text114.MaxLength = file.hex114_length;

                Hex114.Text = BitConverter.ToString(bitarray, file.hex114_address, file.hex114_length);
                Text114.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex114.Text));

                file.L114Length = Text114.Text.Length;
                Length114.Text = file.L114Length.ToString();
                file.L114Last = file.hex114_length - file.L114Length;
                Last114.Text = file.L114Last.ToString();
                file.hex114 = Hex114.Text;

                //hex115
                Hex115.MaxLength = file.hex115_length * 2 + (file.hex115_length - 1);
                Text115.MaxLength = file.hex115_length;

                Hex115.Text = BitConverter.ToString(bitarray, file.hex115_address, file.hex115_length);
                Text115.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex115.Text));

                file.L115Length = Text115.Text.Length;
                Length115.Text = file.L115Length.ToString();
                file.L115Last = file.hex115_length - file.L115Length;
                Last115.Text = file.L115Last.ToString();
                file.hex115 = Hex115.Text;

                //hex116
                Hex116.MaxLength = file.hex116_length * 2 + (file.hex116_length - 1);
                Text116.MaxLength = file.hex116_length;

                Hex116.Text = BitConverter.ToString(bitarray, file.hex116_address, file.hex116_length);
                Text116.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex116.Text));

                file.L116Length = Text116.Text.Length;
                Length116.Text = file.L116Length.ToString();
                file.L116Last = file.hex116_length - file.L116Length;
                Last116.Text = file.L116Last.ToString();
                file.hex116 = Hex116.Text;

                //hex117
                Hex117.MaxLength = file.hex117_length * 2 + (file.hex117_length - 1);
                Text117.MaxLength = file.hex117_length;

                Hex117.Text = BitConverter.ToString(bitarray, file.hex117_address, file.hex117_length);
                Text117.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex117.Text));

                file.L117Length = Text117.Text.Length;
                Length117.Text = file.L117Length.ToString();
                file.L117Last = file.hex117_length - file.L117Length;
                Last117.Text = file.L117Last.ToString();
                file.hex117 = Hex117.Text;

                //hex118
                Hex118.MaxLength = file.hex118_length * 2 + (file.hex118_length - 1);
                Text118.MaxLength = file.hex118_length;

                Hex118.Text = BitConverter.ToString(bitarray, file.hex118_address, file.hex118_length);
                Text118.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex118.Text));

                file.L118Length = Text118.Text.Length;
                Length118.Text = file.L118Length.ToString();
                file.L118Last = file.hex118_length - file.L118Length;
                Last118.Text = file.L118Last.ToString();
                file.hex118 = Hex118.Text;

                //hex119
                Hex119.MaxLength = file.hex119_length * 2 + (file.hex119_length - 1);
                Text119.MaxLength = file.hex119_length;

                Hex119.Text = BitConverter.ToString(bitarray, file.hex119_address, file.hex119_length);
                Text119.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex119.Text));

                file.L119Length = Text119.Text.Length;
                Length119.Text = file.L119Length.ToString();
                file.L119Last = file.hex119_length - file.L119Length;
                Last119.Text = file.L119Last.ToString();
                file.hex119 = Hex119.Text;

                if (Open_File.OpenFile.Decryptrus == true)
                {
                    Hex1.Text = Open_File.OpenFile.Decrypt(Hex1.Text);
                    Text1.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex1.Text));

                    Hex2.Text = Open_File.OpenFile.Decrypt(Hex2.Text);
                    Text2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex2.Text));

                    Hex3.Text = Open_File.OpenFile.Decrypt(Hex3.Text);
                    Text3.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex3.Text));

                    Hex4.Text = Open_File.OpenFile.Decrypt(Hex4.Text);
                    Text4.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex4.Text));

                    Hex5.Text = Open_File.OpenFile.Decrypt(Hex5.Text);
                    Text5.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex5.Text));

                    Hex6.Text = Open_File.OpenFile.Decrypt(Hex6.Text);
                    Text6.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex6.Text));

                    Hex7.Text = Open_File.OpenFile.Decrypt(Hex7.Text);
                    Text7.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex7.Text));

                    Hex8.Text = Open_File.OpenFile.Decrypt(Hex8.Text);
                    Text8.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex8.Text));

                    Hex9.Text = Open_File.OpenFile.Decrypt(Hex9.Text);
                    Text9.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex9.Text));

                    Hex10.Text = Open_File.OpenFile.Decrypt(Hex10.Text);
                    Text10.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex10.Text));

                    Hex11.Text = Open_File.OpenFile.Decrypt(Hex11.Text);
                    Text11.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex11.Text));

                    Hex12.Text = Open_File.OpenFile.Decrypt(Hex12.Text);
                    Text12.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex12.Text));

                    Hex13.Text = Open_File.OpenFile.Decrypt(Hex13.Text);
                    Text13.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex13.Text));

                    Hex14.Text = Open_File.OpenFile.Decrypt(Hex14.Text);
                    Text14.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex14.Text));

                    Hex15.Text = Open_File.OpenFile.Decrypt(Hex15.Text);
                    Text15.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex15.Text));

                    Hex16.Text = Open_File.OpenFile.Decrypt(Hex16.Text);
                    Text16.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex16.Text));

                    Hex17.Text = Open_File.OpenFile.Decrypt(Hex17.Text);
                    Text17.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex17.Text));

                    Hex18.Text = Open_File.OpenFile.Decrypt(Hex18.Text);
                    Text18.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex18.Text));

                    Hex19.Text = Open_File.OpenFile.Decrypt(Hex19.Text);
                    Text19.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex19.Text));

                    Hex20.Text = Open_File.OpenFile.Decrypt(Hex20.Text);
                    Text20.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex20.Text));

                    Hex21.Text = Open_File.OpenFile.Decrypt(Hex21.Text);
                    Text21.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex21.Text));

                    Hex22.Text = Open_File.OpenFile.Decrypt(Hex22.Text);
                    Text22.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex22.Text));

                    Hex23.Text = Open_File.OpenFile.Decrypt(Hex23.Text);
                    Text23.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex23.Text));

                    Hex24.Text = Open_File.OpenFile.Decrypt(Hex24.Text);
                    Text24.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex24.Text));

                    Hex25.Text = Open_File.OpenFile.Decrypt(Hex25.Text);
                    Text25.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex25.Text));

                    Hex26.Text = Open_File.OpenFile.Decrypt(Hex26.Text);
                    Text26.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex26.Text));

                    Hex27.Text = Open_File.OpenFile.Decrypt(Hex27.Text);
                    Text27.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex27.Text));

                    Hex28.Text = Open_File.OpenFile.Decrypt(Hex28.Text);
                    Text28.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex28.Text));

                    Hex29.Text = Open_File.OpenFile.Decrypt(Hex29.Text);
                    Text29.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex29.Text));

                    Hex30.Text = Open_File.OpenFile.Decrypt(Hex30.Text);
                    Text30.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex30.Text));

                    Hex31.Text = Open_File.OpenFile.Decrypt(Hex31.Text);
                    Text31.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex31.Text));

                    Hex32.Text = Open_File.OpenFile.Decrypt(Hex32.Text);
                    Text32.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex32.Text));

                    Hex33.Text = Open_File.OpenFile.Decrypt(Hex33.Text);
                    Text33.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex33.Text));

                    Hex34.Text = Open_File.OpenFile.Decrypt(Hex34.Text);
                    Text34.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex34.Text));

                    Hex35.Text = Open_File.OpenFile.Decrypt(Hex35.Text);
                    Text35.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex35.Text));

                    Hex36.Text = Open_File.OpenFile.Decrypt(Hex36.Text);
                    Text36.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex36.Text));

                    Hex37.Text = Open_File.OpenFile.Decrypt(Hex37.Text);
                    Text37.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex37.Text));

                    Hex38.Text = Open_File.OpenFile.Decrypt(Hex38.Text);
                    Text38.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex38.Text));

                    Hex39.Text = Open_File.OpenFile.Decrypt(Hex39.Text);
                    Text39.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex39.Text));

                    Hex40.Text = Open_File.OpenFile.Decrypt(Hex40.Text);
                    Text40.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex40.Text));

                    Hex41.Text = Open_File.OpenFile.Decrypt(Hex41.Text);
                    Text41.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex41.Text));

                    Hex42.Text = Open_File.OpenFile.Decrypt(Hex42.Text);
                    Text42.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex42.Text));

                    Hex43.Text = Open_File.OpenFile.Decrypt(Hex43.Text);
                    Text43.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex43.Text));

                    Hex44.Text = Open_File.OpenFile.Decrypt(Hex44.Text);
                    Text44.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex44.Text));

                    Hex45.Text = Open_File.OpenFile.Decrypt(Hex45.Text);
                    Text45.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex45.Text));

                    Hex46.Text = Open_File.OpenFile.Decrypt(Hex46.Text);
                    Text46.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex46.Text));

                    Hex47.Text = Open_File.OpenFile.Decrypt(Hex47.Text);
                    Text47.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex47.Text));

                    Hex48.Text = Open_File.OpenFile.Decrypt(Hex48.Text);
                    Text48.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex48.Text));

                    Hex49.Text = Open_File.OpenFile.Decrypt(Hex49.Text);
                    Text49.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex49.Text));

                    Hex50.Text = Open_File.OpenFile.Decrypt(Hex50.Text);
                    Text50.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex50.Text));

                    Hex51.Text = Open_File.OpenFile.Decrypt(Hex51.Text);
                    Text51.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex51.Text));

                    Hex52.Text = Open_File.OpenFile.Decrypt(Hex52.Text);
                    Text52.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex52.Text));

                    Hex53.Text = Open_File.OpenFile.Decrypt(Hex53.Text);
                    Text53.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex53.Text));

                    Hex54.Text = Open_File.OpenFile.Decrypt(Hex54.Text);
                    Text54.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex54.Text));

                    Hex55.Text = Open_File.OpenFile.Decrypt(Hex55.Text);
                    Text55.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex55.Text));

                    Hex56.Text = Open_File.OpenFile.Decrypt(Hex56.Text);
                    Text56.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex56.Text));

                    Hex57.Text = Open_File.OpenFile.Decrypt(Hex57.Text);
                    Text57.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex57.Text));

                    Hex58.Text = Open_File.OpenFile.Decrypt(Hex58.Text);
                    Text58.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex58.Text));

                    Hex59.Text = Open_File.OpenFile.Decrypt(Hex59.Text);
                    Text59.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex59.Text));

                    Hex60.Text = Open_File.OpenFile.Decrypt(Hex60.Text);
                    Text60.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex60.Text));

                    Hex61.Text = Open_File.OpenFile.Decrypt(Hex61.Text);
                    Text61.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex61.Text));

                    Hex62.Text = Open_File.OpenFile.Decrypt(Hex62.Text);
                    Text62.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex62.Text));

                    Hex63.Text = Open_File.OpenFile.Decrypt(Hex63.Text);
                    Text63.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex63.Text));

                    Hex64.Text = Open_File.OpenFile.Decrypt(Hex64.Text);
                    Text64.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex64.Text));

                    Hex65.Text = Open_File.OpenFile.Decrypt(Hex65.Text);
                    Text65.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex65.Text));

                    Hex66.Text = Open_File.OpenFile.Decrypt(Hex66.Text);
                    Text66.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex66.Text));

                    Hex67.Text = Open_File.OpenFile.Decrypt(Hex67.Text);
                    Text67.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex67.Text));

                    Hex68.Text = Open_File.OpenFile.Decrypt(Hex68.Text);
                    Text68.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex68.Text));

                    Hex69.Text = Open_File.OpenFile.Decrypt(Hex69.Text);
                    Text69.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex69.Text));

                    Hex70.Text = Open_File.OpenFile.Decrypt(Hex70.Text);
                    Text70.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex70.Text));

                    Hex71.Text = Open_File.OpenFile.Decrypt(Hex71.Text);
                    Text71.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex71.Text));

                    Hex72.Text = Open_File.OpenFile.Decrypt(Hex72.Text);
                    Text72.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex72.Text));

                    Hex73.Text = Open_File.OpenFile.Decrypt(Hex73.Text);
                    Text73.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex73.Text));

                    Hex74.Text = Open_File.OpenFile.Decrypt(Hex74.Text);
                    Text74.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex74.Text));

                    Hex75.Text = Open_File.OpenFile.Decrypt(Hex75.Text);
                    Text75.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex75.Text));

                    Hex76.Text = Open_File.OpenFile.Decrypt(Hex76.Text);
                    Text76.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex76.Text));

                    Hex77.Text = Open_File.OpenFile.Decrypt(Hex77.Text);
                    Text77.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex77.Text));

                    Hex78.Text = Open_File.OpenFile.Decrypt(Hex78.Text);
                    Text78.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex78.Text));

                    Hex79.Text = Open_File.OpenFile.Decrypt(Hex79.Text);
                    Text79.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex79.Text));

                    Hex80.Text = Open_File.OpenFile.Decrypt(Hex80.Text);
                    Text80.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex80.Text));

                    Hex81.Text = Open_File.OpenFile.Decrypt(Hex81.Text);
                    Text81.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex81.Text));

                    Hex82.Text = Open_File.OpenFile.Decrypt(Hex82.Text);
                    Text82.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex82.Text));

                    Hex83.Text = Open_File.OpenFile.Decrypt(Hex83.Text);
                    Text83.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex83.Text));

                    Hex84.Text = Open_File.OpenFile.Decrypt(Hex84.Text);
                    Text84.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex84.Text));

                    Hex85.Text = Open_File.OpenFile.Decrypt(Hex85.Text);
                    Text85.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex85.Text));

                    Hex86.Text = Open_File.OpenFile.Decrypt(Hex86.Text);
                    Text86.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex86.Text));

                    Hex87.Text = Open_File.OpenFile.Decrypt(Hex87.Text);
                    Text87.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex87.Text));

                    Hex88.Text = Open_File.OpenFile.Decrypt(Hex88.Text);
                    Text88.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex88.Text));

                    Hex89.Text = Open_File.OpenFile.Decrypt(Hex89.Text);
                    Text89.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex89.Text));

                    Hex90.Text = Open_File.OpenFile.Decrypt(Hex90.Text);
                    Text90.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex90.Text));

                    Hex91.Text = Open_File.OpenFile.Decrypt(Hex91.Text);
                    Text91.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex91.Text));

                    Hex92.Text = Open_File.OpenFile.Decrypt(Hex92.Text);
                    Text92.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex92.Text));

                    Hex93.Text = Open_File.OpenFile.Decrypt(Hex93.Text);
                    Text93.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex93.Text));

                    Hex94.Text = Open_File.OpenFile.Decrypt(Hex94.Text);
                    Text94.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex94.Text));

                    Hex95.Text = Open_File.OpenFile.Decrypt(Hex95.Text);
                    Text95.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex95.Text));

                    Hex96.Text = Open_File.OpenFile.Decrypt(Hex96.Text);
                    Text96.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex96.Text));

                    Hex97.Text = Open_File.OpenFile.Decrypt(Hex97.Text);
                    Text97.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex97.Text));

                    Hex98.Text = Open_File.OpenFile.Decrypt(Hex98.Text);
                    Text98.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex98.Text));

                    Hex99.Text = Open_File.OpenFile.Decrypt(Hex99.Text);
                    Text99.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex99.Text));

                    Hex100.Text = Open_File.OpenFile.Decrypt(Hex100.Text);
                    Text100.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex100.Text));

                    Hex101.Text = Open_File.OpenFile.Decrypt(Hex101.Text);
                    Text101.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex101.Text));

                    Hex102.Text = Open_File.OpenFile.Decrypt(Hex102.Text);
                    Text102.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex102.Text));

                    Hex103.Text = Open_File.OpenFile.Decrypt(Hex103.Text);
                    Text103.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex103.Text));

                    Hex104.Text = Open_File.OpenFile.Decrypt(Hex104.Text);
                    Text104.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex104.Text));

                    Hex105.Text = Open_File.OpenFile.Decrypt(Hex105.Text);
                    Text105.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex105.Text));

                    Hex106.Text = Open_File.OpenFile.Decrypt(Hex106.Text);
                    Text106.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex106.Text));

                    Hex107.Text = Open_File.OpenFile.Decrypt(Hex107.Text);
                    Text107.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex107.Text));

                    Hex108.Text = Open_File.OpenFile.Decrypt(Hex108.Text);
                    Text108.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex108.Text));

                    Hex109.Text = Open_File.OpenFile.Decrypt(Hex109.Text);
                    Text109.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex109.Text));

                    Hex110.Text = Open_File.OpenFile.Decrypt(Hex110.Text);
                    Text110.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex110.Text));

                    Hex111.Text = Open_File.OpenFile.Decrypt(Hex111.Text);
                    Text111.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex111.Text));

                    Hex112.Text = Open_File.OpenFile.Decrypt(Hex112.Text);
                    Text112.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex112.Text));

                    Hex113.Text = Open_File.OpenFile.Decrypt(Hex113.Text);
                    Text113.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex113.Text));

                    Hex114.Text = Open_File.OpenFile.Decrypt(Hex114.Text);
                    Text114.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex114.Text));

                    Hex115.Text = Open_File.OpenFile.Decrypt(Hex115.Text);
                    Text115.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex115.Text));

                    Hex116.Text = Open_File.OpenFile.Decrypt(Hex116.Text);
                    Text116.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex116.Text));

                    Hex117.Text = Open_File.OpenFile.Decrypt(Hex117.Text);
                    Text117.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex117.Text));

                    Hex118.Text = Open_File.OpenFile.Decrypt(Hex118.Text);
                    Text118.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex118.Text));

                    Hex119.Text = Open_File.OpenFile.Decrypt(Hex119.Text);
                    Text119.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex119.Text));

                    file.hex1 = Hex1.Text;
                    file.hex2 = Hex2.Text;
                    file.hex3 = Hex3.Text;
                    file.hex4 = Hex4.Text;
                    file.hex5 = Hex5.Text;
                    file.hex6 = Hex6.Text;
                    file.hex7 = Hex7.Text;
                    file.hex8 = Hex8.Text;
                    file.hex9 = Hex9.Text;
                    file.hex10 = Hex10.Text;
                    file.hex11 = Hex11.Text;
                    file.hex12 = Hex12.Text;
                    file.hex13 = Hex13.Text;
                    file.hex14 = Hex14.Text;
                    file.hex15 = Hex15.Text;
                    file.hex16 = Hex16.Text;
                    file.hex17 = Hex17.Text;
                    file.hex18 = Hex18.Text;
                    file.hex19 = Hex19.Text;
                    file.hex20 = Hex20.Text;
                    file.hex21 = Hex21.Text;
                    file.hex22 = Hex22.Text;
                    file.hex23 = Hex23.Text;
                    file.hex24 = Hex24.Text;
                    file.hex25 = Hex25.Text;
                    file.hex26 = Hex26.Text;
                    file.hex27 = Hex27.Text;
                    file.hex28 = Hex28.Text;
                    file.hex29 = Hex29.Text;
                    file.hex30 = Hex30.Text;
                    file.hex31 = Hex31.Text;
                    file.hex32 = Hex32.Text;
                    file.hex33 = Hex33.Text;
                    file.hex34 = Hex34.Text;
                    file.hex35 = Hex35.Text;
                    file.hex36 = Hex36.Text;
                    file.hex37 = Hex37.Text;
                    file.hex38 = Hex38.Text;
                    file.hex39 = Hex39.Text;
                    file.hex40 = Hex40.Text;
                    file.hex41 = Hex41.Text;
                    file.hex42 = Hex42.Text;
                    file.hex43 = Hex43.Text;
                    file.hex44 = Hex44.Text;
                    file.hex45 = Hex45.Text;
                    file.hex46 = Hex46.Text;
                    file.hex47 = Hex47.Text;
                    file.hex48 = Hex48.Text;
                    file.hex49 = Hex49.Text;
                    file.hex50 = Hex50.Text;
                    file.hex51 = Hex51.Text;
                    file.hex52 = Hex52.Text;
                    file.hex53 = Hex53.Text;
                    file.hex54 = Hex54.Text;
                    file.hex55 = Hex55.Text;
                    file.hex56 = Hex56.Text;
                    file.hex57 = Hex57.Text;
                    file.hex58 = Hex58.Text;
                    file.hex59 = Hex59.Text;
                    file.hex60 = Hex60.Text;
                    file.hex61 = Hex61.Text;
                    file.hex62 = Hex62.Text;
                    file.hex63 = Hex63.Text;
                    file.hex64 = Hex64.Text;
                    file.hex65 = Hex65.Text;
                    file.hex66 = Hex66.Text;
                    file.hex67 = Hex67.Text;
                    file.hex68 = Hex68.Text;
                    file.hex69 = Hex69.Text;
                    file.hex70 = Hex70.Text;
                    file.hex71 = Hex71.Text;
                    file.hex72 = Hex72.Text;
                    file.hex73 = Hex73.Text;
                    file.hex74 = Hex74.Text;
                    file.hex75 = Hex75.Text;
                    file.hex76 = Hex76.Text;
                    file.hex77 = Hex77.Text;
                    file.hex78 = Hex78.Text;
                    file.hex79 = Hex79.Text;
                    file.hex80 = Hex80.Text;
                    file.hex81 = Hex81.Text;
                    file.hex82 = Hex82.Text;
                    file.hex83 = Hex83.Text;
                    file.hex84 = Hex84.Text;
                    file.hex85 = Hex85.Text;
                    file.hex86 = Hex86.Text;
                    file.hex87 = Hex87.Text;
                    file.hex88 = Hex88.Text;
                    file.hex89 = Hex89.Text;
                    file.hex90 = Hex90.Text;
                    file.hex91 = Hex91.Text;
                    file.hex92 = Hex92.Text;
                    file.hex93 = Hex93.Text;
                    file.hex94 = Hex94.Text;
                    file.hex95 = Hex95.Text;
                    file.hex96 = Hex96.Text;
                    file.hex97 = Hex97.Text;
                    file.hex98 = Hex98.Text;
                    file.hex99 = Hex99.Text;
                    file.hex100 = Hex100.Text;
                    file.hex101 = Hex101.Text;
                    file.hex102 = Hex102.Text;
                    file.hex103 = Hex103.Text;
                    file.hex104 = Hex104.Text;
                    file.hex105 = Hex105.Text;
                    file.hex106 = Hex106.Text;
                    file.hex107 = Hex107.Text;
                    file.hex108 = Hex108.Text;
                    file.hex109 = Hex109.Text;
                    file.hex110 = Hex110.Text;
                    file.hex111 = Hex111.Text;
                    file.hex112 = Hex112.Text;
                    file.hex113 = Hex113.Text;
                    file.hex114 = Hex114.Text;
                    file.hex115 = Hex115.Text;
                    file.hex116 = Hex116.Text;
                    file.hex117 = Hex117.Text;
                    file.hex118 = Hex118.Text;
                    file.hex119 = Hex119.Text;
                }
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

            //text15
            public static string hex15;
            public static int L15Length;
            public static int L15Last;
            public static int hex15_address;
            public static int hex15_length;

            //text16
            public static string hex16;
            public static int L16Length;
            public static int L16Last;
            public static int hex16_address;
            public static int hex16_length;

            //text17
            public static string hex17;
            public static int L17Length;
            public static int L17Last;
            public static int hex17_address;
            public static int hex17_length;

            //text18
            public static string hex18;
            public static int L18Length;
            public static int L18Last;
            public static int hex18_address;
            public static int hex18_length;

            //text19
            public static string hex19;
            public static int L19Length;
            public static int L19Last;
            public static int hex19_address;
            public static int hex19_length;

            //text20
            public static string hex20;
            public static int L20Length;
            public static int L20Last;
            public static int hex20_address;
            public static int hex20_length;

            //text21
            public static string hex21;
            public static int L21Length;
            public static int L21Last;
            public static int hex21_address;
            public static int hex21_length;

            //text22
            public static string hex22;
            public static int L22Length;
            public static int L22Last;
            public static int hex22_address;
            public static int hex22_length;

            //text23
            public static string hex23;
            public static int L23Length;
            public static int L23Last;
            public static int hex23_address;
            public static int hex23_length;

            //text24
            public static string hex24;
            public static int L24Length;
            public static int L24Last;
            public static int hex24_address;
            public static int hex24_length;

            //text25
            public static string hex25;
            public static int L25Length;
            public static int L25Last;
            public static int hex25_address;
            public static int hex25_length;

            //text26
            public static string hex26;
            public static int L26Length;
            public static int L26Last;
            public static int hex26_address;
            public static int hex26_length;

            //text27
            public static string hex27;
            public static int L27Length;
            public static int L27Last;
            public static int hex27_address;
            public static int hex27_length;

            //text28
            public static string hex28;
            public static int L28Length;
            public static int L28Last;
            public static int hex28_address;
            public static int hex28_length;

            //text29
            public static string hex29;
            public static int L29Length;
            public static int L29Last;
            public static int hex29_address;
            public static int hex29_length;

            //text30
            public static string hex30;
            public static int L30Length;
            public static int L30Last;
            public static int hex30_address;
            public static int hex30_length;

            //text31
            public static string hex31;
            public static int L31Length;
            public static int L31Last;
            public static int hex31_address;
            public static int hex31_length;

            //text32
            public static string hex32;
            public static int L32Length;
            public static int L32Last;
            public static int hex32_address;
            public static int hex32_length;

            //text33
            public static string hex33;
            public static int L33Length;
            public static int L33Last;
            public static int hex33_address;
            public static int hex33_length;

            //text34
            public static string hex34;
            public static int L34Length;
            public static int L34Last;
            public static int hex34_address;
            public static int hex34_length;

            //text35
            public static string hex35;
            public static int L35Length;
            public static int L35Last;
            public static int hex35_address;
            public static int hex35_length;

            //text36
            public static string hex36;
            public static int L36Length;
            public static int L36Last;
            public static int hex36_address;
            public static int hex36_length;

            //text37
            public static string hex37;
            public static int L37Length;
            public static int L37Last;
            public static int hex37_address;
            public static int hex37_length;

            //text38
            public static string hex38;
            public static int L38Length;
            public static int L38Last;
            public static int hex38_address;
            public static int hex38_length;

            //text39
            public static string hex39;
            public static int L39Length;
            public static int L39Last;
            public static int hex39_address;
            public static int hex39_length;

            //text40
            public static string hex40;
            public static int L40Length;
            public static int L40Last;
            public static int hex40_address;
            public static int hex40_length;

            //text41
            public static string hex41;
            public static int L41Length;
            public static int L41Last;
            public static int hex41_address;
            public static int hex41_length;

            //text42
            public static string hex42;
            public static int L42Length;
            public static int L42Last;
            public static int hex42_address;
            public static int hex42_length;

            //text43
            public static string hex43;
            public static int L43Length;
            public static int L43Last;
            public static int hex43_address;
            public static int hex43_length;

            //text44
            public static string hex44;
            public static int L44Length;
            public static int L44Last;
            public static int hex44_address;
            public static int hex44_length;

            //text45
            public static string hex45;
            public static int L45Length;
            public static int L45Last;
            public static int hex45_address;
            public static int hex45_length;

            //text46
            public static string hex46;
            public static int L46Length;
            public static int L46Last;
            public static int hex46_address;
            public static int hex46_length;

            //text47
            public static string hex47;
            public static int L47Length;
            public static int L47Last;
            public static int hex47_address;
            public static int hex47_length;

            //text48
            public static string hex48;
            public static int L48Length;
            public static int L48Last;
            public static int hex48_address;
            public static int hex48_length;

            //text49
            public static string hex49;
            public static int L49Length;
            public static int L49Last;
            public static int hex49_address;
            public static int hex49_length;

            //text50
            public static string hex50;
            public static int L50Length;
            public static int L50Last;
            public static int hex50_address;
            public static int hex50_length;

            //text51
            public static string hex51;
            public static int L51Length;
            public static int L51Last;
            public static int hex51_address;
            public static int hex51_length;

            //text52
            public static string hex52;
            public static int L52Length;
            public static int L52Last;
            public static int hex52_address;
            public static int hex52_length;

            //text53
            public static string hex53;
            public static int L53Length;
            public static int L53Last;
            public static int hex53_address;
            public static int hex53_length;

            //text54
            public static string hex54;
            public static int L54Length;
            public static int L54Last;
            public static int hex54_address;
            public static int hex54_length;

            //text55
            public static string hex55;
            public static int L55Length;
            public static int L55Last;
            public static int hex55_address;
            public static int hex55_length;

            //text56
            public static string hex56;
            public static int L56Length;
            public static int L56Last;
            public static int hex56_address;
            public static int hex56_length;

            //text57
            public static string hex57;
            public static int L57Length;
            public static int L57Last;
            public static int hex57_address;
            public static int hex57_length;

            //text58
            public static string hex58;
            public static int L58Length;
            public static int L58Last;
            public static int hex58_address;
            public static int hex58_length;

            //text59
            public static string hex59;
            public static int L59Length;
            public static int L59Last;
            public static int hex59_address;
            public static int hex59_length;

            //text60
            public static string hex60;
            public static int L60Length;
            public static int L60Last;
            public static int hex60_address;
            public static int hex60_length;

            //text61
            public static string hex61;
            public static int L61Length;
            public static int L61Last;
            public static int hex61_address;
            public static int hex61_length;

            //text62
            public static string hex62;
            public static int L62Length;
            public static int L62Last;
            public static int hex62_address;
            public static int hex62_length;

            //text63
            public static string hex63;
            public static int L63Length;
            public static int L63Last;
            public static int hex63_address;
            public static int hex63_length;

            //text64
            public static string hex64;
            public static int L64Length;
            public static int L64Last;
            public static int hex64_address;
            public static int hex64_length;

            //text65
            public static string hex65;
            public static int L65Length;
            public static int L65Last;
            public static int hex65_address;
            public static int hex65_length;

            //text66
            public static string hex66;
            public static int L66Length;
            public static int L66Last;
            public static int hex66_address;
            public static int hex66_length;

            //text67
            public static string hex67;
            public static int L67Length;
            public static int L67Last;
            public static int hex67_address;
            public static int hex67_length;

            //text68
            public static string hex68;
            public static int L68Length;
            public static int L68Last;
            public static int hex68_address;
            public static int hex68_length;

            //text69
            public static string hex69;
            public static int L69Length;
            public static int L69Last;
            public static int hex69_address;
            public static int hex69_length;

            //text70
            public static string hex70;
            public static int L70Length;
            public static int L70Last;
            public static int hex70_address;
            public static int hex70_length;

            //text71
            public static string hex71;
            public static int L71Length;
            public static int L71Last;
            public static int hex71_address;
            public static int hex71_length;

            //text72
            public static string hex72;
            public static int L72Length;
            public static int L72Last;
            public static int hex72_address;
            public static int hex72_length;

            //text73
            public static string hex73;
            public static int L73Length;
            public static int L73Last;
            public static int hex73_address;
            public static int hex73_length;

            //text74
            public static string hex74;
            public static int L74Length;
            public static int L74Last;
            public static int hex74_address;
            public static int hex74_length;

            //text75
            public static string hex75;
            public static int L75Length;
            public static int L75Last;
            public static int hex75_address;
            public static int hex75_length;

            //text76
            public static string hex76;
            public static int L76Length;
            public static int L76Last;
            public static int hex76_address;
            public static int hex76_length;

            //text77
            public static string hex77;
            public static int L77Length;
            public static int L77Last;
            public static int hex77_address;
            public static int hex77_length;

            //text78
            public static string hex78;
            public static int L78Length;
            public static int L78Last;
            public static int hex78_address;
            public static int hex78_length;

            //text79
            public static string hex79;
            public static int L79Length;
            public static int L79Last;
            public static int hex79_address;
            public static int hex79_length;

            //text80
            public static string hex80;
            public static int L80Length;
            public static int L80Last;
            public static int hex80_address;
            public static int hex80_length;

            //text81
            public static string hex81;
            public static int L81Length;
            public static int L81Last;
            public static int hex81_address;
            public static int hex81_length;

            //text82
            public static string hex82;
            public static int L82Length;
            public static int L82Last;
            public static int hex82_address;
            public static int hex82_length;

            //text83
            public static string hex83;
            public static int L83Length;
            public static int L83Last;
            public static int hex83_address;
            public static int hex83_length;

            //text84
            public static string hex84;
            public static int L84Length;
            public static int L84Last;
            public static int hex84_address;
            public static int hex84_length;

            //text85
            public static string hex85;
            public static int L85Length;
            public static int L85Last;
            public static int hex85_address;
            public static int hex85_length;

            //text86
            public static string hex86;
            public static int L86Length;
            public static int L86Last;
            public static int hex86_address;
            public static int hex86_length;

            //text87
            public static string hex87;
            public static int L87Length;
            public static int L87Last;
            public static int hex87_address;
            public static int hex87_length;

            //text88
            public static string hex88;
            public static int L88Length;
            public static int L88Last;
            public static int hex88_address;
            public static int hex88_length;

            //text89
            public static string hex89;
            public static int L89Length;
            public static int L89Last;
            public static int hex89_address;
            public static int hex89_length;

            //text90
            public static string hex90;
            public static int L90Length;
            public static int L90Last;
            public static int hex90_address;
            public static int hex90_length;

            //text91
            public static string hex91;
            public static int L91Length;
            public static int L91Last;
            public static int hex91_address;
            public static int hex91_length;

            //text92
            public static string hex92;
            public static int L92Length;
            public static int L92Last;
            public static int hex92_address;
            public static int hex92_length;

            //text93
            public static string hex93;
            public static int L93Length;
            public static int L93Last;
            public static int hex93_address;
            public static int hex93_length;

            //text94
            public static string hex94;
            public static int L94Length;
            public static int L94Last;
            public static int hex94_address;
            public static int hex94_length;

            //text95
            public static string hex95;
            public static int L95Length;
            public static int L95Last;
            public static int hex95_address;
            public static int hex95_length;

            //text96
            public static string hex96;
            public static int L96Length;
            public static int L96Last;
            public static int hex96_address;
            public static int hex96_length;

            //text97
            public static string hex97;
            public static int L97Length;
            public static int L97Last;
            public static int hex97_address;
            public static int hex97_length;

            //text98
            public static string hex98;
            public static int L98Length;
            public static int L98Last;
            public static int hex98_address;
            public static int hex98_length;

            //text99
            public static string hex99;
            public static int L99Length;
            public static int L99Last;
            public static int hex99_address;
            public static int hex99_length;

            //text100
            public static string hex100;
            public static int L100Length;
            public static int L100Last;
            public static int hex100_address;
            public static int hex100_length;

            //text101
            public static string hex101;
            public static int L101Length;
            public static int L101Last;
            public static int hex101_address;
            public static int hex101_length;

            //text102
            public static string hex102;
            public static int L102Length;
            public static int L102Last;
            public static int hex102_address;
            public static int hex102_length;

            //text103
            public static string hex103;
            public static int L103Length;
            public static int L103Last;
            public static int hex103_address;
            public static int hex103_length;

            //text104
            public static string hex104;
            public static int L104Length;
            public static int L104Last;
            public static int hex104_address;
            public static int hex104_length;

            //text105
            public static string hex105;
            public static int L105Length;
            public static int L105Last;
            public static int hex105_address;
            public static int hex105_length;

            //text106
            public static string hex106;
            public static int L106Length;
            public static int L106Last;
            public static int hex106_address;
            public static int hex106_length;

            //text107
            public static string hex107;
            public static int L107Length;
            public static int L107Last;
            public static int hex107_address;
            public static int hex107_length;

            //text108
            public static string hex108;
            public static int L108Length;
            public static int L108Last;
            public static int hex108_address;
            public static int hex108_length;

            //text109
            public static string hex109;
            public static int L109Length;
            public static int L109Last;
            public static int hex109_address;
            public static int hex109_length;

            //text110
            public static string hex110;
            public static int L110Length;
            public static int L110Last;
            public static int hex110_address;
            public static int hex110_length;

            //text111
            public static string hex111;
            public static int L111Length;
            public static int L111Last;
            public static int hex111_address;
            public static int hex111_length;

            //text112
            public static string hex112;
            public static int L112Length;
            public static int L112Last;
            public static int hex112_address;
            public static int hex112_length;

            //text113
            public static string hex113;
            public static int L113Length;
            public static int L113Last;
            public static int hex113_address;
            public static int hex113_length;

            //text114
            public static string hex114;
            public static int L114Length;
            public static int L114Last;
            public static int hex114_address;
            public static int hex114_length;

            //text115
            public static string hex115;
            public static int L115Length;
            public static int L115Last;
            public static int hex115_address;
            public static int hex115_length;

            //text116
            public static string hex116;
            public static int L116Length;
            public static int L116Last;
            public static int hex116_address;
            public static int hex116_length;

            //text117
            public static string hex117;
            public static int L117Length;
            public static int L117Last;
            public static int hex117_address;
            public static int hex117_length;

            //text118
            public static string hex118;
            public static int L118Length;
            public static int L118Last;
            public static int hex118_address;
            public static int hex118_length;

            //text119
            public static string hex119;
            public static int L119Length;
            public static int L119Last;
            public static int hex119_address;
            public static int hex119_length;
        }
        

        void start_file()
        {
            if(Open_File.OpenFile.FileName == "COMOD11.SNG")
            {
                this.Text = "COMOD11.SNG - Level 1 Single Lammy - 91 lines";
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

                file.hex15_address = COMOD11_SNG_info.Hex15_address;
                file.hex15_length = COMOD11_SNG_info.Hex15_length;

                file.hex16_address = COMOD11_SNG_info.Hex16_address;
                file.hex16_length = COMOD11_SNG_info.Hex16_length;

                file.hex17_address = COMOD11_SNG_info.Hex17_address;
                file.hex17_length = COMOD11_SNG_info.Hex17_length;

                file.hex18_address = COMOD11_SNG_info.Hex18_address;
                file.hex18_length = COMOD11_SNG_info.Hex18_length;

                file.hex19_address = COMOD11_SNG_info.Hex19_address;
                file.hex19_length = COMOD11_SNG_info.Hex19_length;

                file.hex20_address = COMOD11_SNG_info.Hex20_address;
                file.hex20_length = COMOD11_SNG_info.Hex20_length;

                file.hex21_address = COMOD11_SNG_info.Hex21_address;
                file.hex21_length = COMOD11_SNG_info.Hex21_length;

                file.hex22_address = COMOD11_SNG_info.Hex22_address;
                file.hex22_length = COMOD11_SNG_info.Hex22_length;

                file.hex23_address = COMOD11_SNG_info.Hex23_address;
                file.hex23_length = COMOD11_SNG_info.Hex23_length;

                file.hex24_address = COMOD11_SNG_info.Hex24_address;
                file.hex24_length = COMOD11_SNG_info.Hex24_length;

                file.hex25_address = COMOD11_SNG_info.Hex25_address;
                file.hex25_length = COMOD11_SNG_info.Hex25_length;

                file.hex26_address = COMOD11_SNG_info.Hex26_address;
                file.hex26_length = COMOD11_SNG_info.Hex26_length;

                file.hex27_address = COMOD11_SNG_info.Hex27_address;
                file.hex27_length = COMOD11_SNG_info.Hex27_length;

                file.hex28_address = COMOD11_SNG_info.Hex28_address;
                file.hex28_length = COMOD11_SNG_info.Hex28_length;

                file.hex29_address = COMOD11_SNG_info.Hex29_address;
                file.hex29_length = COMOD11_SNG_info.Hex29_length;

                file.hex30_address = COMOD11_SNG_info.Hex30_address;
                file.hex30_length = COMOD11_SNG_info.Hex30_length;

                file.hex31_address = COMOD11_SNG_info.Hex31_address;
                file.hex31_length = COMOD11_SNG_info.Hex31_length;

                file.hex32_address = COMOD11_SNG_info.Hex32_address;
                file.hex32_length = COMOD11_SNG_info.Hex32_length;

                file.hex33_address = COMOD11_SNG_info.Hex33_address;
                file.hex33_length = COMOD11_SNG_info.Hex33_length;

                file.hex34_address = COMOD11_SNG_info.Hex34_address;
                file.hex34_length = COMOD11_SNG_info.Hex34_length;

                file.hex35_address = COMOD11_SNG_info.Hex35_address;
                file.hex35_length = COMOD11_SNG_info.Hex35_length;

                file.hex36_address = COMOD11_SNG_info.Hex36_address;
                file.hex36_length = COMOD11_SNG_info.Hex36_length;

                file.hex37_address = COMOD11_SNG_info.Hex37_address;
                file.hex37_length = COMOD11_SNG_info.Hex37_length;

                file.hex38_address = COMOD11_SNG_info.Hex38_address;
                file.hex38_length = COMOD11_SNG_info.Hex38_length;

                file.hex39_address = COMOD11_SNG_info.Hex39_address;
                file.hex39_length = COMOD11_SNG_info.Hex39_length;

                file.hex40_address = COMOD11_SNG_info.Hex40_address;
                file.hex40_length = COMOD11_SNG_info.Hex40_length;

                file.hex41_address = COMOD11_SNG_info.Hex41_address;
                file.hex41_length = COMOD11_SNG_info.Hex41_length;

                file.hex42_address = COMOD11_SNG_info.Hex42_address;
                file.hex42_length = COMOD11_SNG_info.Hex42_length;

                file.hex43_address = COMOD11_SNG_info.Hex43_address;
                file.hex43_length = COMOD11_SNG_info.Hex43_length;

                file.hex44_address = COMOD11_SNG_info.Hex44_address;
                file.hex44_length = COMOD11_SNG_info.Hex44_length;

                file.hex45_address = COMOD11_SNG_info.Hex45_address;
                file.hex45_length = COMOD11_SNG_info.Hex45_length;

                file.hex46_address = COMOD11_SNG_info.Hex46_address;
                file.hex46_length = COMOD11_SNG_info.Hex46_length;

                file.hex47_address = COMOD11_SNG_info.Hex47_address;
                file.hex47_length = COMOD11_SNG_info.Hex47_length;

                file.hex48_address = COMOD11_SNG_info.Hex48_address;
                file.hex48_length = COMOD11_SNG_info.Hex48_length;

                file.hex49_address = COMOD11_SNG_info.Hex49_address;
                file.hex49_length = COMOD11_SNG_info.Hex49_length;

                file.hex50_address = COMOD11_SNG_info.Hex50_address;
                file.hex50_length = COMOD11_SNG_info.Hex50_length;

                file.hex51_address = COMOD11_SNG_info.Hex51_address;
                file.hex51_length = COMOD11_SNG_info.Hex51_length;

                file.hex52_address = COMOD11_SNG_info.Hex52_address;
                file.hex52_length = COMOD11_SNG_info.Hex52_length;

                file.hex53_address = COMOD11_SNG_info.Hex53_address;
                file.hex53_length = COMOD11_SNG_info.Hex53_length;

                file.hex54_address = COMOD11_SNG_info.Hex54_address;
                file.hex54_length = COMOD11_SNG_info.Hex54_length;

                file.hex55_address = COMOD11_SNG_info.Hex55_address;
                file.hex55_length = COMOD11_SNG_info.Hex55_length;

                file.hex56_address = COMOD11_SNG_info.Hex56_address;
                file.hex56_length = COMOD11_SNG_info.Hex56_length;

                file.hex57_address = COMOD11_SNG_info.Hex57_address;
                file.hex57_length = COMOD11_SNG_info.Hex57_length;

                file.hex58_address = COMOD11_SNG_info.Hex58_address;
                file.hex58_length = COMOD11_SNG_info.Hex58_length;

                file.hex59_address = COMOD11_SNG_info.Hex59_address;
                file.hex59_length = COMOD11_SNG_info.Hex59_length;

                file.hex60_address = COMOD11_SNG_info.Hex60_address;
                file.hex60_length = COMOD11_SNG_info.Hex60_length;

                file.hex61_address = COMOD11_SNG_info.Hex61_address;
                file.hex61_length = COMOD11_SNG_info.Hex61_length;

                file.hex62_address = COMOD11_SNG_info.Hex62_address;
                file.hex62_length = COMOD11_SNG_info.Hex62_length;

                file.hex63_address = COMOD11_SNG_info.Hex63_address;
                file.hex63_length = COMOD11_SNG_info.Hex63_length;

                file.hex64_address = COMOD11_SNG_info.Hex64_address;
                file.hex64_length = COMOD11_SNG_info.Hex64_length;

                file.hex65_address = COMOD11_SNG_info.Hex65_address;
                file.hex65_length = COMOD11_SNG_info.Hex65_length;

                file.hex66_address = COMOD11_SNG_info.Hex66_address;
                file.hex66_length = COMOD11_SNG_info.Hex66_length;

                file.hex67_address = COMOD11_SNG_info.Hex67_address;
                file.hex67_length = COMOD11_SNG_info.Hex67_length;

                file.hex68_address = COMOD11_SNG_info.Hex68_address;
                file.hex68_length = COMOD11_SNG_info.Hex68_length;

                file.hex69_address = COMOD11_SNG_info.Hex69_address;
                file.hex69_length = COMOD11_SNG_info.Hex69_length;

                file.hex70_address = COMOD11_SNG_info.Hex70_address;
                file.hex70_length = COMOD11_SNG_info.Hex70_length;

                file.hex71_address = COMOD11_SNG_info.Hex71_address;
                file.hex71_length = COMOD11_SNG_info.Hex71_length;

                file.hex72_address = COMOD11_SNG_info.Hex72_address;
                file.hex72_length = COMOD11_SNG_info.Hex72_length;

                file.hex73_address = COMOD11_SNG_info.Hex73_address;
                file.hex73_length = COMOD11_SNG_info.Hex73_length;

                file.hex74_address = COMOD11_SNG_info.Hex74_address;
                file.hex74_length = COMOD11_SNG_info.Hex74_length;

                file.hex75_address = COMOD11_SNG_info.Hex75_address;
                file.hex75_length = COMOD11_SNG_info.Hex75_length;

                file.hex76_address = COMOD11_SNG_info.Hex76_address;
                file.hex76_length = COMOD11_SNG_info.Hex76_length;

                file.hex77_address = COMOD11_SNG_info.Hex77_address;
                file.hex77_length = COMOD11_SNG_info.Hex77_length;

                file.hex78_address = COMOD11_SNG_info.Hex78_address;
                file.hex78_length = COMOD11_SNG_info.Hex78_length;

                file.hex79_address = COMOD11_SNG_info.Hex79_address;
                file.hex79_length = COMOD11_SNG_info.Hex79_length;

                file.hex80_address = COMOD11_SNG_info.Hex80_address;
                file.hex80_length = COMOD11_SNG_info.Hex80_length;

                file.hex81_address = COMOD11_SNG_info.Hex81_address;
                file.hex81_length = COMOD11_SNG_info.Hex81_length;

                file.hex82_address = COMOD11_SNG_info.Hex82_address;
                file.hex82_length = COMOD11_SNG_info.Hex82_length;

                file.hex83_address = COMOD11_SNG_info.Hex83_address;
                file.hex83_length = COMOD11_SNG_info.Hex83_length;

                file.hex84_address = COMOD11_SNG_info.Hex84_address;
                file.hex84_length = COMOD11_SNG_info.Hex84_length;

                file.hex85_address = COMOD11_SNG_info.Hex85_address;
                file.hex85_length = COMOD11_SNG_info.Hex85_length;

                file.hex86_address = COMOD11_SNG_info.Hex86_address;
                file.hex86_length = COMOD11_SNG_info.Hex86_length;

                file.hex87_address = COMOD11_SNG_info.Hex87_address;
                file.hex87_length = COMOD11_SNG_info.Hex87_length;

                file.hex88_address = COMOD11_SNG_info.Hex88_address;
                file.hex88_length = COMOD11_SNG_info.Hex88_length;

                file.hex89_address = COMOD11_SNG_info.Hex89_address;
                file.hex89_length = COMOD11_SNG_info.Hex89_length;

                file.hex90_address = COMOD11_SNG_info.Hex90_address;
                file.hex90_length = COMOD11_SNG_info.Hex90_length;

                file.hex91_address = COMOD11_SNG_info.Hex91_address;
                file.hex91_length = COMOD11_SNG_info.Hex91_length;

                file.hex92_address = 0;
                file.hex92_length = 1;
                Hex92.Enabled = false;
                Text92.Enabled = false;

                file.hex93_address = 0;
                file.hex93_length = 1;
                Hex93.Enabled = false;
                Text93.Enabled = false;

                file.hex94_address = 0;
                file.hex94_length = 1;
                Hex94.Enabled = false;
                Text94.Enabled = false;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD0.MEN")
            {
                this.Text = "COMOD0.MEN - Intro and Menu - 52 lines";

                file.hex1_address = COMOD0_MEN_info.Hex1_address;
                file.hex1_length = COMOD0_MEN_info.Hex1_length;

                file.hex2_address = COMOD0_MEN_info.Hex2_address;
                file.hex2_length = COMOD0_MEN_info.Hex2_length;

                file.hex3_address = COMOD0_MEN_info.Hex3_address;
                file.hex3_length = COMOD0_MEN_info.Hex3_length;

                file.hex4_address = COMOD0_MEN_info.Hex4_address;
                file.hex4_length = COMOD0_MEN_info.Hex4_length;

                file.hex5_address = COMOD0_MEN_info.Hex5_address;
                file.hex5_length = COMOD0_MEN_info.Hex5_length;

                file.hex6_address = COMOD0_MEN_info.Hex6_address;
                file.hex6_length = COMOD0_MEN_info.Hex6_length;

                file.hex7_address = COMOD0_MEN_info.Hex7_address;
                file.hex7_length = COMOD0_MEN_info.Hex7_length;

                file.hex8_address = COMOD0_MEN_info.Hex8_address;
                file.hex8_length = COMOD0_MEN_info.Hex8_length;

                file.hex9_address = COMOD0_MEN_info.Hex9_address;
                file.hex9_length = COMOD0_MEN_info.Hex9_length;

                file.hex10_address = COMOD0_MEN_info.Hex10_address;
                file.hex10_length = COMOD0_MEN_info.Hex10_length;

                file.hex11_address = COMOD0_MEN_info.Hex11_address;
                file.hex11_length = COMOD0_MEN_info.Hex11_length;

                file.hex12_address = COMOD0_MEN_info.Hex12_address;
                file.hex12_length = COMOD0_MEN_info.Hex12_length;

                file.hex13_address = COMOD0_MEN_info.Hex13_address;
                file.hex13_length = COMOD0_MEN_info.Hex13_length;

                file.hex14_address = COMOD0_MEN_info.Hex14_address;
                file.hex14_length = COMOD0_MEN_info.Hex14_length;

                file.hex15_address = COMOD0_MEN_info.Hex15_address;
                file.hex15_length = COMOD0_MEN_info.Hex15_length;

                file.hex16_address = COMOD0_MEN_info.Hex16_address;
                file.hex16_length = COMOD0_MEN_info.Hex16_length;

                file.hex17_address = COMOD0_MEN_info.Hex17_address;
                file.hex17_length = COMOD0_MEN_info.Hex17_length;

                file.hex18_address = COMOD0_MEN_info.Hex18_address;
                file.hex18_length = COMOD0_MEN_info.Hex18_length;

                file.hex19_address = COMOD0_MEN_info.Hex19_address;
                file.hex19_length = COMOD0_MEN_info.Hex19_length;

                file.hex20_address = COMOD0_MEN_info.Hex20_address;
                file.hex20_length = COMOD0_MEN_info.Hex20_length;

                file.hex21_address = COMOD0_MEN_info.Hex21_address;
                file.hex21_length = COMOD0_MEN_info.Hex21_length;

                file.hex22_address = COMOD0_MEN_info.Hex22_address;
                file.hex22_length = COMOD0_MEN_info.Hex22_length;

                file.hex23_address = COMOD0_MEN_info.Hex23_address;
                file.hex23_length = COMOD0_MEN_info.Hex23_length;

                file.hex24_address = COMOD0_MEN_info.Hex24_address;
                file.hex24_length = COMOD0_MEN_info.Hex24_length;

                file.hex25_address = COMOD0_MEN_info.Hex25_address;
                file.hex25_length = COMOD0_MEN_info.Hex25_length;

                file.hex26_address = COMOD0_MEN_info.Hex26_address;
                file.hex26_length = COMOD0_MEN_info.Hex26_length;

                file.hex27_address = COMOD0_MEN_info.Hex27_address;
                file.hex27_length = COMOD0_MEN_info.Hex27_length;

                file.hex28_address = COMOD0_MEN_info.Hex28_address;
                file.hex28_length = COMOD0_MEN_info.Hex28_length;

                file.hex29_address = COMOD0_MEN_info.Hex29_address;
                file.hex29_length = COMOD0_MEN_info.Hex29_length;

                file.hex30_address = COMOD0_MEN_info.Hex30_address;
                file.hex30_length = COMOD0_MEN_info.Hex30_length;

                file.hex31_address = COMOD0_MEN_info.Hex31_address;
                file.hex31_length = COMOD0_MEN_info.Hex31_length;

                file.hex32_address = COMOD0_MEN_info.Hex32_address;
                file.hex32_length = COMOD0_MEN_info.Hex32_length;

                file.hex33_address = COMOD0_MEN_info.Hex33_address;
                file.hex33_length = COMOD0_MEN_info.Hex33_length;

                file.hex34_address = COMOD0_MEN_info.Hex34_address;
                file.hex34_length = COMOD0_MEN_info.Hex34_length;

                file.hex35_address = COMOD0_MEN_info.Hex35_address;
                file.hex35_length = COMOD0_MEN_info.Hex35_length;

                file.hex36_address = COMOD0_MEN_info.Hex36_address;
                file.hex36_length = COMOD0_MEN_info.Hex36_length;

                file.hex37_address = COMOD0_MEN_info.Hex37_address;
                file.hex37_length = COMOD0_MEN_info.Hex37_length;

                file.hex38_address = COMOD0_MEN_info.Hex38_address;
                file.hex38_length = COMOD0_MEN_info.Hex38_length;

                file.hex39_address = COMOD0_MEN_info.Hex39_address;
                file.hex39_length = COMOD0_MEN_info.Hex39_length;

                file.hex40_address = COMOD0_MEN_info.Hex40_address;
                file.hex40_length = COMOD0_MEN_info.Hex40_length;

                file.hex41_address = COMOD0_MEN_info.Hex41_address;
                file.hex41_length = COMOD0_MEN_info.Hex41_length;

                file.hex42_address = COMOD0_MEN_info.Hex42_address;
                file.hex42_length = COMOD0_MEN_info.Hex42_length;

                file.hex43_address = COMOD0_MEN_info.Hex43_address;
                file.hex43_length = COMOD0_MEN_info.Hex43_length;

                file.hex44_address = COMOD0_MEN_info.Hex44_address;
                file.hex44_length = COMOD0_MEN_info.Hex44_length;

                file.hex45_address = COMOD0_MEN_info.Hex45_address;
                file.hex45_length = COMOD0_MEN_info.Hex45_length;

                file.hex46_address = COMOD0_MEN_info.Hex46_address;
                file.hex46_length = COMOD0_MEN_info.Hex46_length;

                file.hex47_address = COMOD0_MEN_info.Hex47_address;
                file.hex47_length = COMOD0_MEN_info.Hex47_length;

                file.hex48_address = COMOD0_MEN_info.Hex48_address;
                file.hex48_length = COMOD0_MEN_info.Hex48_length;

                file.hex49_address = COMOD0_MEN_info.Hex49_address;
                file.hex49_length = COMOD0_MEN_info.Hex49_length;

                file.hex50_address = COMOD0_MEN_info.Hex50_address;
                file.hex50_length = COMOD0_MEN_info.Hex50_length;

                file.hex51_address = COMOD0_MEN_info.Hex51_address;
                file.hex51_length = COMOD0_MEN_info.Hex51_length;

                file.hex52_address = COMOD0_MEN_info.Hex52_address;
                file.hex52_length = COMOD0_MEN_info.Hex52_length;

                file.hex53_address = 0;
                file.hex53_length = 1;
                Hex53.Enabled = false;
                Text53.Enabled = false;

                file.hex54_address = 0;
                file.hex54_length = 1;
                Hex54.Enabled = false;
                Text54.Enabled = false;

                file.hex55_address = 0;
                file.hex55_length = 1;
                Hex55.Enabled = false;
                Text55.Enabled = false;

                file.hex56_address = 0;
                file.hex56_length = 1;
                Hex56.Enabled = false;
                Text56.Enabled = false;

                file.hex57_address = 0;
                file.hex57_length = 1;
                Hex57.Enabled = false;
                Text57.Enabled = false;

                file.hex58_address = 0;
                file.hex58_length = 1;
                Hex58.Enabled = false;
                Text58.Enabled = false;

                file.hex59_address = 0;
                file.hex59_length = 1;
                Hex59.Enabled = false;
                Text59.Enabled = false;

                file.hex60_address = 0;
                file.hex60_length = 1;
                Hex60.Enabled = false;
                Text60.Enabled = false;

                file.hex61_address = 0;
                file.hex61_length = 1;
                Hex61.Enabled = false;
                Text61.Enabled = false;

                file.hex62_address = 0;
                file.hex62_length = 1;
                Hex62.Enabled = false;
                Text62.Enabled = false;

                file.hex63_address = 0;
                file.hex63_length = 1;
                Hex63.Enabled = false;
                Text63.Enabled = false;

                file.hex64_address = 0;
                file.hex64_length = 1;
                Hex64.Enabled = false;
                Text64.Enabled = false;

                file.hex65_address = 0;
                file.hex65_length = 1;
                Hex65.Enabled = false;
                Text65.Enabled = false;

                file.hex66_address = 0;
                file.hex66_length = 1;
                Hex66.Enabled = false;
                Text66.Enabled = false;

                file.hex67_address = 0;
                file.hex67_length = 1;
                Hex67.Enabled = false;
                Text67.Enabled = false;

                file.hex68_address = 0;
                file.hex68_length = 1;
                Hex68.Enabled = false;
                Text68.Enabled = false;

                file.hex69_address = 0;
                file.hex69_length = 1;
                Hex69.Enabled = false;
                Text69.Enabled = false;

                file.hex70_address = 0;
                file.hex70_length = 1;
                Hex70.Enabled = false;
                Text70.Enabled = false;

                file.hex71_address = 0;
                file.hex71_length = 1;
                Hex71.Enabled = false;
                Text71.Enabled = false;

                file.hex72_address = 0;
                file.hex72_length = 1;
                Hex72.Enabled = false;
                Text72.Enabled = false;

                file.hex73_address = 0;
                file.hex73_length = 1;
                Hex73.Enabled = false;
                Text73.Enabled = false;

                file.hex74_address = 0;
                file.hex74_length = 1;
                Hex74.Enabled = false;
                Text74.Enabled = false;

                file.hex75_address = 0;
                file.hex75_length = 1;
                Hex75.Enabled = false;
                Text75.Enabled = false;

                file.hex76_address = 0;
                file.hex76_length = 1;
                Hex76.Enabled = false;
                Text76.Enabled = false;

                file.hex77_address = 0;
                file.hex77_length = 1;
                Hex77.Enabled = false;
                Text77.Enabled = false;

                file.hex78_address = 0;
                file.hex78_length = 1;
                Hex78.Enabled = false;
                Text78.Enabled = false;

                file.hex79_address = 0;
                file.hex79_length = 1;
                Hex79.Enabled = false;
                Text79.Enabled = false;

                file.hex80_address = 0;
                file.hex80_length = 1;
                Hex80.Enabled = false;
                Text80.Enabled = false;

                file.hex81_address = 0;
                file.hex81_length = 1;
                Hex81.Enabled = false;
                Text81.Enabled = false;

                file.hex82_address = 0;
                file.hex82_length = 1;
                Hex82.Enabled = false;
                Text82.Enabled = false;

                file.hex83_address = 0;
                file.hex83_length = 1;
                Hex83.Enabled = false;
                Text83.Enabled = false;

                file.hex84_address = 0;
                file.hex84_length = 1;
                Hex84.Enabled = false;
                Text84.Enabled = false;

                file.hex85_address = 0;
                file.hex85_length = 1;
                Hex85.Enabled = false;
                Text85.Enabled = false;

                file.hex86_address = 0;
                file.hex86_length = 1;
                Hex86.Enabled = false;
                Text86.Enabled = false;

                file.hex87_address = 0;
                file.hex87_length = 1;
                Hex87.Enabled = false;
                Text87.Enabled = false;

                file.hex88_address = 0;
                file.hex88_length = 1;
                Hex88.Enabled = false;
                Text88.Enabled = false;

                file.hex89_address = 0;
                file.hex89_length = 1;
                Hex89.Enabled = false;
                Text89.Enabled = false;

                file.hex90_address = 0;
                file.hex90_length = 1;
                Hex90.Enabled = false;
                Text90.Enabled = false;

                file.hex91_address = 0;
                file.hex91_length = 1;
                Hex91.Enabled = false;
                Text91.Enabled = false;

                file.hex92_address = 0;
                file.hex92_length = 1;
                Hex92.Enabled = false;
                Text92.Enabled = false;

                file.hex93_address = 0;
                file.hex93_length = 1;
                Hex93.Enabled = false;
                Text93.Enabled = false;

                file.hex94_address = 0;
                file.hex94_length = 1;
                Hex94.Enabled = false;
                Text94.Enabled = false;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD6.SNG")
            {
                this.Text = "COMOD6.SNG - Level 6 Single Parappa - 94 lines";
                file.hex1_address = COMOD6_SNG_info.Hex1_address;
                file.hex1_length = COMOD6_SNG_info.Hex1_length;

                file.hex2_address = COMOD6_SNG_info.Hex2_address;
                file.hex2_length = COMOD6_SNG_info.Hex2_length;

                file.hex3_address = COMOD6_SNG_info.Hex3_address;
                file.hex3_length = COMOD6_SNG_info.Hex3_length;

                file.hex4_address = COMOD6_SNG_info.Hex4_address;
                file.hex4_length = COMOD6_SNG_info.Hex4_length;

                file.hex5_address = COMOD6_SNG_info.Hex5_address;
                file.hex5_length = COMOD6_SNG_info.Hex5_length;

                file.hex6_address = COMOD6_SNG_info.Hex6_address;
                file.hex6_length = COMOD6_SNG_info.Hex6_length;

                file.hex7_address = COMOD6_SNG_info.Hex7_address;
                file.hex7_length = COMOD6_SNG_info.Hex7_length;

                file.hex8_address = COMOD6_SNG_info.Hex8_address;
                file.hex8_length = COMOD6_SNG_info.Hex8_length;

                file.hex9_address = COMOD6_SNG_info.Hex9_address;
                file.hex9_length = COMOD6_SNG_info.Hex9_length;

                file.hex10_address = COMOD6_SNG_info.Hex10_address;
                file.hex10_length = COMOD6_SNG_info.Hex10_length;

                file.hex11_address = COMOD6_SNG_info.Hex11_address;
                file.hex11_length = COMOD6_SNG_info.Hex11_length;

                file.hex12_address = COMOD6_SNG_info.Hex12_address;
                file.hex12_length = COMOD6_SNG_info.Hex12_length;

                file.hex13_address = COMOD6_SNG_info.Hex13_address;
                file.hex13_length = COMOD6_SNG_info.Hex13_length;

                file.hex14_address = COMOD6_SNG_info.Hex14_address;
                file.hex14_length = COMOD6_SNG_info.Hex14_length;

                file.hex15_address = COMOD6_SNG_info.Hex15_address;
                file.hex15_length = COMOD6_SNG_info.Hex15_length;

                file.hex16_address = COMOD6_SNG_info.Hex16_address;
                file.hex16_length = COMOD6_SNG_info.Hex16_length;

                file.hex17_address = COMOD6_SNG_info.Hex17_address;
                file.hex17_length = COMOD6_SNG_info.Hex17_length;

                file.hex18_address = COMOD6_SNG_info.Hex18_address;
                file.hex18_length = COMOD6_SNG_info.Hex18_length;

                file.hex19_address = COMOD6_SNG_info.Hex19_address;
                file.hex19_length = COMOD6_SNG_info.Hex19_length;

                file.hex20_address = COMOD6_SNG_info.Hex20_address;
                file.hex20_length = COMOD6_SNG_info.Hex20_length;

                file.hex21_address = COMOD6_SNG_info.Hex21_address;
                file.hex21_length = COMOD6_SNG_info.Hex21_length;

                file.hex22_address = COMOD6_SNG_info.Hex22_address;
                file.hex22_length = COMOD6_SNG_info.Hex22_length;

                file.hex23_address = COMOD6_SNG_info.Hex23_address;
                file.hex23_length = COMOD6_SNG_info.Hex23_length;

                file.hex24_address = COMOD6_SNG_info.Hex24_address;
                file.hex24_length = COMOD6_SNG_info.Hex24_length;

                file.hex25_address = COMOD6_SNG_info.Hex25_address;
                file.hex25_length = COMOD6_SNG_info.Hex25_length;

                file.hex26_address = COMOD6_SNG_info.Hex26_address;
                file.hex26_length = COMOD6_SNG_info.Hex26_length;

                file.hex27_address = COMOD6_SNG_info.Hex27_address;
                file.hex27_length = COMOD6_SNG_info.Hex27_length;

                file.hex28_address = COMOD6_SNG_info.Hex28_address;
                file.hex28_length = COMOD6_SNG_info.Hex28_length;

                file.hex29_address = COMOD6_SNG_info.Hex29_address;
                file.hex29_length = COMOD6_SNG_info.Hex29_length;

                file.hex30_address = COMOD6_SNG_info.Hex30_address;
                file.hex30_length = COMOD6_SNG_info.Hex30_length;

                file.hex31_address = COMOD6_SNG_info.Hex31_address;
                file.hex31_length = COMOD6_SNG_info.Hex31_length;

                file.hex32_address = COMOD6_SNG_info.Hex32_address;
                file.hex32_length = COMOD6_SNG_info.Hex32_length;

                file.hex33_address = COMOD6_SNG_info.Hex33_address;
                file.hex33_length = COMOD6_SNG_info.Hex33_length;

                file.hex34_address = COMOD6_SNG_info.Hex34_address;
                file.hex34_length = COMOD6_SNG_info.Hex34_length;

                file.hex35_address = COMOD6_SNG_info.Hex35_address;
                file.hex35_length = COMOD6_SNG_info.Hex35_length;

                file.hex36_address = COMOD6_SNG_info.Hex36_address;
                file.hex36_length = COMOD6_SNG_info.Hex36_length;

                file.hex37_address = COMOD6_SNG_info.Hex37_address;
                file.hex37_length = COMOD6_SNG_info.Hex37_length;

                file.hex38_address = COMOD6_SNG_info.Hex38_address;
                file.hex38_length = COMOD6_SNG_info.Hex38_length;

                file.hex39_address = COMOD6_SNG_info.Hex39_address;
                file.hex39_length = COMOD6_SNG_info.Hex39_length;

                file.hex40_address = COMOD6_SNG_info.Hex40_address;
                file.hex40_length = COMOD6_SNG_info.Hex40_length;

                file.hex41_address = COMOD6_SNG_info.Hex41_address;
                file.hex41_length = COMOD6_SNG_info.Hex41_length;

                file.hex42_address = COMOD6_SNG_info.Hex42_address;
                file.hex42_length = COMOD6_SNG_info.Hex42_length;

                file.hex43_address = COMOD6_SNG_info.Hex43_address;
                file.hex43_length = COMOD6_SNG_info.Hex43_length;

                file.hex44_address = COMOD6_SNG_info.Hex44_address;
                file.hex44_length = COMOD6_SNG_info.Hex44_length;

                file.hex45_address = COMOD6_SNG_info.Hex45_address;
                file.hex45_length = COMOD6_SNG_info.Hex45_length;

                file.hex46_address = COMOD6_SNG_info.Hex46_address;
                file.hex46_length = COMOD6_SNG_info.Hex46_length;

                file.hex47_address = COMOD6_SNG_info.Hex47_address;
                file.hex47_length = COMOD6_SNG_info.Hex47_length;

                file.hex48_address = COMOD6_SNG_info.Hex48_address;
                file.hex48_length = COMOD6_SNG_info.Hex48_length;

                file.hex49_address = COMOD6_SNG_info.Hex49_address;
                file.hex49_length = COMOD6_SNG_info.Hex49_length;

                file.hex50_address = COMOD6_SNG_info.Hex50_address;
                file.hex50_length = COMOD6_SNG_info.Hex50_length;

                file.hex51_address = COMOD6_SNG_info.Hex51_address;
                file.hex51_length = COMOD6_SNG_info.Hex51_length;

                file.hex52_address = COMOD6_SNG_info.Hex52_address;
                file.hex52_length = COMOD6_SNG_info.Hex52_length;

                file.hex53_address = COMOD6_SNG_info.Hex53_address;
                file.hex53_length = COMOD6_SNG_info.Hex53_length;

                file.hex54_address = COMOD6_SNG_info.Hex54_address;
                file.hex54_length = COMOD6_SNG_info.Hex54_length;

                file.hex55_address = COMOD6_SNG_info.Hex55_address;
                file.hex55_length = COMOD6_SNG_info.Hex55_length;

                file.hex56_address = COMOD6_SNG_info.Hex56_address;
                file.hex56_length = COMOD6_SNG_info.Hex56_length;

                file.hex57_address = COMOD6_SNG_info.Hex57_address;
                file.hex57_length = COMOD6_SNG_info.Hex57_length;

                file.hex58_address = COMOD6_SNG_info.Hex58_address;
                file.hex58_length = COMOD6_SNG_info.Hex58_length;

                file.hex59_address = COMOD6_SNG_info.Hex59_address;
                file.hex59_length = COMOD6_SNG_info.Hex59_length;

                file.hex60_address = COMOD6_SNG_info.Hex60_address;
                file.hex60_length = COMOD6_SNG_info.Hex60_length;

                file.hex61_address = COMOD6_SNG_info.Hex61_address;
                file.hex61_length = COMOD6_SNG_info.Hex61_length;

                file.hex62_address = COMOD6_SNG_info.Hex62_address;
                file.hex62_length = COMOD6_SNG_info.Hex62_length;

                file.hex63_address = COMOD6_SNG_info.Hex63_address;
                file.hex63_length = COMOD6_SNG_info.Hex63_length;

                file.hex64_address = COMOD6_SNG_info.Hex64_address;
                file.hex64_length = COMOD6_SNG_info.Hex64_length;

                file.hex65_address = COMOD6_SNG_info.Hex65_address;
                file.hex65_length = COMOD6_SNG_info.Hex65_length;

                file.hex66_address = COMOD6_SNG_info.Hex66_address;
                file.hex66_length = COMOD6_SNG_info.Hex66_length;

                file.hex67_address = COMOD6_SNG_info.Hex67_address;
                file.hex67_length = COMOD6_SNG_info.Hex67_length;

                file.hex68_address = COMOD6_SNG_info.Hex68_address;
                file.hex68_length = COMOD6_SNG_info.Hex68_length;

                file.hex69_address = COMOD6_SNG_info.Hex69_address;
                file.hex69_length = COMOD6_SNG_info.Hex69_length;

                file.hex70_address = COMOD6_SNG_info.Hex70_address;
                file.hex70_length = COMOD6_SNG_info.Hex70_length;

                file.hex71_address = COMOD6_SNG_info.Hex71_address;
                file.hex71_length = COMOD6_SNG_info.Hex71_length;

                file.hex72_address = COMOD6_SNG_info.Hex72_address;
                file.hex72_length = COMOD6_SNG_info.Hex72_length;

                file.hex73_address = COMOD6_SNG_info.Hex73_address;
                file.hex73_length = COMOD6_SNG_info.Hex73_length;

                file.hex74_address = COMOD6_SNG_info.Hex74_address;
                file.hex74_length = COMOD6_SNG_info.Hex74_length;

                file.hex75_address = COMOD6_SNG_info.Hex75_address;
                file.hex75_length = COMOD6_SNG_info.Hex75_length;

                file.hex76_address = COMOD6_SNG_info.Hex76_address;
                file.hex76_length = COMOD6_SNG_info.Hex76_length;

                file.hex77_address = COMOD6_SNG_info.Hex77_address;
                file.hex77_length = COMOD6_SNG_info.Hex77_length;

                file.hex78_address = COMOD6_SNG_info.Hex78_address;
                file.hex78_length = COMOD6_SNG_info.Hex78_length;

                file.hex79_address = COMOD6_SNG_info.Hex79_address;
                file.hex79_length = COMOD6_SNG_info.Hex79_length;

                file.hex80_address = COMOD6_SNG_info.Hex80_address;
                file.hex80_length = COMOD6_SNG_info.Hex80_length;

                file.hex81_address = COMOD6_SNG_info.Hex81_address;
                file.hex81_length = COMOD6_SNG_info.Hex81_length;

                file.hex82_address = COMOD6_SNG_info.Hex82_address;
                file.hex82_length = COMOD6_SNG_info.Hex82_length;

                file.hex83_address = COMOD6_SNG_info.Hex83_address;
                file.hex83_length = COMOD6_SNG_info.Hex83_length;

                file.hex84_address = COMOD6_SNG_info.Hex84_address;
                file.hex84_length = COMOD6_SNG_info.Hex84_length;

                file.hex85_address = COMOD6_SNG_info.Hex85_address;
                file.hex85_length = COMOD6_SNG_info.Hex85_length;

                file.hex86_address = COMOD6_SNG_info.Hex86_address;
                file.hex86_length = COMOD6_SNG_info.Hex86_length;

                file.hex87_address = COMOD6_SNG_info.Hex87_address;
                file.hex87_length = COMOD6_SNG_info.Hex87_length;

                file.hex88_address = COMOD6_SNG_info.Hex88_address;
                file.hex88_length = COMOD6_SNG_info.Hex88_length;

                file.hex89_address = COMOD6_SNG_info.Hex89_address;
                file.hex89_length = COMOD6_SNG_info.Hex89_length;

                file.hex90_address = COMOD6_SNG_info.Hex90_address;
                file.hex90_length = COMOD6_SNG_info.Hex90_length;

                file.hex91_address = COMOD6_SNG_info.Hex91_address;
                file.hex91_length = COMOD6_SNG_info.Hex91_length;

                file.hex92_address = COMOD6_SNG_info.Hex92_address;
                file.hex92_length = COMOD6_SNG_info.Hex92_length;

                file.hex93_address = COMOD6_SNG_info.Hex93_address;
                file.hex93_length = COMOD6_SNG_info.Hex93_length;

                file.hex94_address = COMOD6_SNG_info.Hex94_address;
                file.hex94_length = COMOD6_SNG_info.Hex94_length;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD16.SNG")
            {
                this.Text = "COMOD16.SNG - Level 6 Single Lammy - 73 lines";
                file.hex1_address = COMOD16_SNG_info.Hex1_address;
                file.hex1_length = COMOD16_SNG_info.Hex1_length;

                file.hex2_address = COMOD16_SNG_info.Hex2_address;
                file.hex2_length = COMOD16_SNG_info.Hex2_length;

                file.hex3_address = COMOD16_SNG_info.Hex3_address;
                file.hex3_length = COMOD16_SNG_info.Hex3_length;

                file.hex4_address = COMOD16_SNG_info.Hex4_address;
                file.hex4_length = COMOD16_SNG_info.Hex4_length;

                file.hex5_address = COMOD16_SNG_info.Hex5_address;
                file.hex5_length = COMOD16_SNG_info.Hex5_length;

                file.hex6_address = COMOD16_SNG_info.Hex6_address;
                file.hex6_length = COMOD16_SNG_info.Hex6_length;

                file.hex7_address = COMOD16_SNG_info.Hex7_address;
                file.hex7_length = COMOD16_SNG_info.Hex7_length;

                file.hex8_address = COMOD16_SNG_info.Hex8_address;
                file.hex8_length = COMOD16_SNG_info.Hex8_length;

                file.hex9_address = COMOD16_SNG_info.Hex9_address;
                file.hex9_length = COMOD16_SNG_info.Hex9_length;

                file.hex10_address = COMOD16_SNG_info.Hex10_address;
                file.hex10_length = COMOD16_SNG_info.Hex10_length;

                file.hex11_address = COMOD16_SNG_info.Hex11_address;
                file.hex11_length = COMOD16_SNG_info.Hex11_length;

                file.hex12_address = COMOD16_SNG_info.Hex12_address;
                file.hex12_length = COMOD16_SNG_info.Hex12_length;

                file.hex13_address = COMOD16_SNG_info.Hex13_address;
                file.hex13_length = COMOD16_SNG_info.Hex13_length;

                file.hex14_address = COMOD16_SNG_info.Hex14_address;
                file.hex14_length = COMOD16_SNG_info.Hex14_length;

                file.hex15_address = COMOD16_SNG_info.Hex15_address;
                file.hex15_length = COMOD16_SNG_info.Hex15_length;

                file.hex16_address = COMOD16_SNG_info.Hex16_address;
                file.hex16_length = COMOD16_SNG_info.Hex16_length;

                file.hex17_address = COMOD16_SNG_info.Hex17_address;
                file.hex17_length = COMOD16_SNG_info.Hex17_length;

                file.hex18_address = COMOD16_SNG_info.Hex18_address;
                file.hex18_length = COMOD16_SNG_info.Hex18_length;

                file.hex19_address = COMOD16_SNG_info.Hex19_address;
                file.hex19_length = COMOD16_SNG_info.Hex19_length;

                file.hex20_address = COMOD16_SNG_info.Hex20_address;
                file.hex20_length = COMOD16_SNG_info.Hex20_length;

                file.hex21_address = COMOD16_SNG_info.Hex21_address;
                file.hex21_length = COMOD16_SNG_info.Hex21_length;

                file.hex22_address = COMOD16_SNG_info.Hex22_address;
                file.hex22_length = COMOD16_SNG_info.Hex22_length;

                file.hex23_address = COMOD16_SNG_info.Hex23_address;
                file.hex23_length = COMOD16_SNG_info.Hex23_length;

                file.hex24_address = COMOD16_SNG_info.Hex24_address;
                file.hex24_length = COMOD16_SNG_info.Hex24_length;

                file.hex25_address = COMOD16_SNG_info.Hex25_address;
                file.hex25_length = COMOD16_SNG_info.Hex25_length;

                file.hex26_address = COMOD16_SNG_info.Hex26_address;
                file.hex26_length = COMOD16_SNG_info.Hex26_length;

                file.hex27_address = COMOD16_SNG_info.Hex27_address;
                file.hex27_length = COMOD16_SNG_info.Hex27_length;

                file.hex28_address = COMOD16_SNG_info.Hex28_address;
                file.hex28_length = COMOD16_SNG_info.Hex28_length;

                file.hex29_address = COMOD16_SNG_info.Hex29_address;
                file.hex29_length = COMOD16_SNG_info.Hex29_length;

                file.hex30_address = COMOD16_SNG_info.Hex30_address;
                file.hex30_length = COMOD16_SNG_info.Hex30_length;

                file.hex31_address = COMOD16_SNG_info.Hex31_address;
                file.hex31_length = COMOD16_SNG_info.Hex31_length;

                file.hex32_address = COMOD16_SNG_info.Hex32_address;
                file.hex32_length = COMOD16_SNG_info.Hex32_length;

                file.hex33_address = COMOD16_SNG_info.Hex33_address;
                file.hex33_length = COMOD16_SNG_info.Hex33_length;

                file.hex34_address = COMOD16_SNG_info.Hex34_address;
                file.hex34_length = COMOD16_SNG_info.Hex34_length;

                file.hex35_address = COMOD16_SNG_info.Hex35_address;
                file.hex35_length = COMOD16_SNG_info.Hex35_length;

                file.hex36_address = COMOD16_SNG_info.Hex36_address;
                file.hex36_length = COMOD16_SNG_info.Hex36_length;

                file.hex37_address = COMOD16_SNG_info.Hex37_address;
                file.hex37_length = COMOD16_SNG_info.Hex37_length;

                file.hex38_address = COMOD16_SNG_info.Hex38_address;
                file.hex38_length = COMOD16_SNG_info.Hex38_length;

                file.hex39_address = COMOD16_SNG_info.Hex39_address;
                file.hex39_length = COMOD16_SNG_info.Hex39_length;

                file.hex40_address = COMOD16_SNG_info.Hex40_address;
                file.hex40_length = COMOD16_SNG_info.Hex40_length;

                file.hex41_address = COMOD16_SNG_info.Hex41_address;
                file.hex41_length = COMOD16_SNG_info.Hex41_length;

                file.hex42_address = COMOD16_SNG_info.Hex42_address;
                file.hex42_length = COMOD16_SNG_info.Hex42_length;

                file.hex43_address = COMOD16_SNG_info.Hex43_address;
                file.hex43_length = COMOD16_SNG_info.Hex43_length;

                file.hex44_address = COMOD16_SNG_info.Hex44_address;
                file.hex44_length = COMOD16_SNG_info.Hex44_length;

                file.hex45_address = COMOD16_SNG_info.Hex45_address;
                file.hex45_length = COMOD16_SNG_info.Hex45_length;

                file.hex46_address = COMOD16_SNG_info.Hex46_address;
                file.hex46_length = COMOD16_SNG_info.Hex46_length;

                file.hex47_address = COMOD16_SNG_info.Hex47_address;
                file.hex47_length = COMOD16_SNG_info.Hex47_length;

                file.hex48_address = COMOD16_SNG_info.Hex48_address;
                file.hex48_length = COMOD16_SNG_info.Hex48_length;

                file.hex49_address = COMOD16_SNG_info.Hex49_address;
                file.hex49_length = COMOD16_SNG_info.Hex49_length;

                file.hex50_address = COMOD16_SNG_info.Hex50_address;
                file.hex50_length = COMOD16_SNG_info.Hex50_length;

                file.hex51_address = COMOD16_SNG_info.Hex51_address;
                file.hex51_length = COMOD16_SNG_info.Hex51_length;

                file.hex52_address = COMOD16_SNG_info.Hex52_address;
                file.hex52_length = COMOD16_SNG_info.Hex52_length;

                file.hex53_address = COMOD16_SNG_info.Hex53_address;
                file.hex53_length = COMOD16_SNG_info.Hex53_length;

                file.hex54_address = COMOD16_SNG_info.Hex54_address;
                file.hex54_length = COMOD16_SNG_info.Hex54_length;

                file.hex55_address = COMOD16_SNG_info.Hex55_address;
                file.hex55_length = COMOD16_SNG_info.Hex55_length;

                file.hex56_address = COMOD16_SNG_info.Hex56_address;
                file.hex56_length = COMOD16_SNG_info.Hex56_length;

                file.hex57_address = COMOD16_SNG_info.Hex57_address;
                file.hex57_length = COMOD16_SNG_info.Hex57_length;

                file.hex58_address = COMOD16_SNG_info.Hex58_address;
                file.hex58_length = COMOD16_SNG_info.Hex58_length;

                file.hex59_address = COMOD16_SNG_info.Hex59_address;
                file.hex59_length = COMOD16_SNG_info.Hex59_length;

                file.hex60_address = COMOD16_SNG_info.Hex60_address;
                file.hex60_length = COMOD16_SNG_info.Hex60_length;

                file.hex61_address = COMOD16_SNG_info.Hex61_address;
                file.hex61_length = COMOD16_SNG_info.Hex61_length;

                file.hex62_address = COMOD16_SNG_info.Hex62_address;
                file.hex62_length = COMOD16_SNG_info.Hex62_length;

                file.hex63_address = COMOD16_SNG_info.Hex63_address;
                file.hex63_length = COMOD16_SNG_info.Hex63_length;

                file.hex64_address = COMOD16_SNG_info.Hex64_address;
                file.hex64_length = COMOD16_SNG_info.Hex64_length;

                file.hex65_address = COMOD16_SNG_info.Hex65_address;
                file.hex65_length = COMOD16_SNG_info.Hex65_length;

                file.hex66_address = COMOD16_SNG_info.Hex66_address;
                file.hex66_length = COMOD16_SNG_info.Hex66_length;

                file.hex67_address = COMOD16_SNG_info.Hex67_address;
                file.hex67_length = COMOD16_SNG_info.Hex67_length;

                file.hex68_address = COMOD16_SNG_info.Hex68_address;
                file.hex68_length = COMOD16_SNG_info.Hex68_length;

                file.hex69_address = COMOD16_SNG_info.Hex69_address;
                file.hex69_length = COMOD16_SNG_info.Hex69_length;

                file.hex70_address = COMOD16_SNG_info.Hex70_address;
                file.hex70_length = COMOD16_SNG_info.Hex70_length;

                file.hex71_address = COMOD16_SNG_info.Hex71_address;
                file.hex71_length = COMOD16_SNG_info.Hex71_length;

                file.hex72_address = COMOD16_SNG_info.Hex72_address;
                file.hex72_length = COMOD16_SNG_info.Hex72_length;

                file.hex73_address = COMOD16_SNG_info.Hex73_address;
                file.hex73_length = COMOD16_SNG_info.Hex73_length;

                file.hex74_address = 0;
                file.hex74_length = 1;
                Hex74.Enabled = false;
                Text74.Enabled = false;

                file.hex75_address = 0;
                file.hex75_length = 1;
                Hex75.Enabled = false;
                Text75.Enabled = false;

                file.hex76_address = 0;
                file.hex76_length = 1;
                Hex76.Enabled = false;
                Text76.Enabled = false;

                file.hex77_address = 0;
                file.hex77_length = 1;
                Hex77.Enabled = false;
                Text77.Enabled = false;

                file.hex78_address = 0;
                file.hex78_length = 1;
                Hex78.Enabled = false;
                Text78.Enabled = false;

                file.hex79_address = 0;
                file.hex79_length = 1;
                Hex79.Enabled = false;
                Text79.Enabled = false;

                file.hex80_address = 0;
                file.hex80_length = 1;
                Hex80.Enabled = false;
                Text80.Enabled = false;

                file.hex81_address = 0;
                file.hex81_length = 1;
                Hex81.Enabled = false;
                Text81.Enabled = false;

                file.hex82_address = 0;
                file.hex82_length = 1;
                Hex82.Enabled = false;
                Text82.Enabled = false;

                file.hex83_address = 0;
                file.hex83_length = 1;
                Hex83.Enabled = false;
                Text83.Enabled = false;

                file.hex84_address = 0;
                file.hex84_length = 1;
                Hex84.Enabled = false;
                Text84.Enabled = false;

                file.hex85_address = 0;
                file.hex85_length = 1;
                Hex85.Enabled = false;
                Text85.Enabled = false;

                file.hex86_address = 0;
                file.hex86_length = 1;
                Hex86.Enabled = false;
                Text86.Enabled = false;

                file.hex87_address = 0;
                file.hex87_length = 1;
                Hex87.Enabled = false;
                Text87.Enabled = false;

                file.hex88_address = 0;
                file.hex88_length = 1;
                Hex88.Enabled = false;
                Text88.Enabled = false;

                file.hex89_address = 0;
                file.hex89_length = 1;
                Hex89.Enabled = false;
                Text89.Enabled = false;

                file.hex90_address = 0;
                file.hex90_length = 1;
                Hex90.Enabled = false;
                Text90.Enabled = false;

                file.hex91_address = 0;
                file.hex91_length = 1;
                Hex91.Enabled = false;
                Text91.Enabled = false;

                file.hex92_address = 0;
                file.hex92_length = 1;
                Hex92.Enabled = false;
                Text92.Enabled = false;

                file.hex93_address = 0;
                file.hex93_length = 1;
                Hex93.Enabled = false;
                Text93.Enabled = false;

                file.hex94_address = 0;
                file.hex94_length = 1;
                Hex94.Enabled = false;
                Text94.Enabled = false;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD16.CMP")
            {
                this.Text = "COMOD16.CMP - Level 6 Lammy Vs Rammy - 72 lines";
                file.hex1_address = COMOD16_CMP_info.Hex1_address;
                file.hex1_length = COMOD16_CMP_info.Hex1_length;

                file.hex2_address = COMOD16_CMP_info.Hex2_address;
                file.hex2_length = COMOD16_CMP_info.Hex2_length;

                file.hex3_address = COMOD16_CMP_info.Hex3_address;
                file.hex3_length = COMOD16_CMP_info.Hex3_length;

                file.hex4_address = COMOD16_CMP_info.Hex4_address;
                file.hex4_length = COMOD16_CMP_info.Hex4_length;

                file.hex5_address = COMOD16_CMP_info.Hex5_address;
                file.hex5_length = COMOD16_CMP_info.Hex5_length;

                file.hex6_address = COMOD16_CMP_info.Hex6_address;
                file.hex6_length = COMOD16_CMP_info.Hex6_length;

                file.hex7_address = COMOD16_CMP_info.Hex7_address;
                file.hex7_length = COMOD16_CMP_info.Hex7_length;

                file.hex8_address = COMOD16_CMP_info.Hex8_address;
                file.hex8_length = COMOD16_CMP_info.Hex8_length;

                file.hex9_address = COMOD16_CMP_info.Hex9_address;
                file.hex9_length = COMOD16_CMP_info.Hex9_length;

                file.hex10_address = COMOD16_CMP_info.Hex10_address;
                file.hex10_length = COMOD16_CMP_info.Hex10_length;

                file.hex11_address = COMOD16_CMP_info.Hex11_address;
                file.hex11_length = COMOD16_CMP_info.Hex11_length;

                file.hex12_address = COMOD16_CMP_info.Hex12_address;
                file.hex12_length = COMOD16_CMP_info.Hex12_length;

                file.hex13_address = COMOD16_CMP_info.Hex13_address;
                file.hex13_length = COMOD16_CMP_info.Hex13_length;

                file.hex14_address = COMOD16_CMP_info.Hex14_address;
                file.hex14_length = COMOD16_CMP_info.Hex14_length;

                file.hex15_address = COMOD16_CMP_info.Hex15_address;
                file.hex15_length = COMOD16_CMP_info.Hex15_length;

                file.hex16_address = COMOD16_CMP_info.Hex16_address;
                file.hex16_length = COMOD16_CMP_info.Hex16_length;

                file.hex17_address = COMOD16_CMP_info.Hex17_address;
                file.hex17_length = COMOD16_CMP_info.Hex17_length;

                file.hex18_address = COMOD16_CMP_info.Hex18_address;
                file.hex18_length = COMOD16_CMP_info.Hex18_length;

                file.hex19_address = COMOD16_CMP_info.Hex19_address;
                file.hex19_length = COMOD16_CMP_info.Hex19_length;

                file.hex20_address = COMOD16_CMP_info.Hex20_address;
                file.hex20_length = COMOD16_CMP_info.Hex20_length;

                file.hex21_address = COMOD16_CMP_info.Hex21_address;
                file.hex21_length = COMOD16_CMP_info.Hex21_length;

                file.hex22_address = COMOD16_CMP_info.Hex22_address;
                file.hex22_length = COMOD16_CMP_info.Hex22_length;

                file.hex23_address = COMOD16_CMP_info.Hex23_address;
                file.hex23_length = COMOD16_CMP_info.Hex23_length;

                file.hex24_address = COMOD16_CMP_info.Hex24_address;
                file.hex24_length = COMOD16_CMP_info.Hex24_length;

                file.hex25_address = COMOD16_CMP_info.Hex25_address;
                file.hex25_length = COMOD16_CMP_info.Hex25_length;

                file.hex26_address = COMOD16_CMP_info.Hex26_address;
                file.hex26_length = COMOD16_CMP_info.Hex26_length;

                file.hex27_address = COMOD16_CMP_info.Hex27_address;
                file.hex27_length = COMOD16_CMP_info.Hex27_length;

                file.hex28_address = COMOD16_CMP_info.Hex28_address;
                file.hex28_length = COMOD16_CMP_info.Hex28_length;

                file.hex29_address = COMOD16_CMP_info.Hex29_address;
                file.hex29_length = COMOD16_CMP_info.Hex29_length;

                file.hex30_address = COMOD16_CMP_info.Hex30_address;
                file.hex30_length = COMOD16_CMP_info.Hex30_length;

                file.hex31_address = COMOD16_CMP_info.Hex31_address;
                file.hex31_length = COMOD16_CMP_info.Hex31_length;

                file.hex32_address = COMOD16_CMP_info.Hex32_address;
                file.hex32_length = COMOD16_CMP_info.Hex32_length;

                file.hex33_address = COMOD16_CMP_info.Hex33_address;
                file.hex33_length = COMOD16_CMP_info.Hex33_length;

                file.hex34_address = COMOD16_CMP_info.Hex34_address;
                file.hex34_length = COMOD16_CMP_info.Hex34_length;

                file.hex35_address = COMOD16_CMP_info.Hex35_address;
                file.hex35_length = COMOD16_CMP_info.Hex35_length;

                file.hex36_address = COMOD16_CMP_info.Hex36_address;
                file.hex36_length = COMOD16_CMP_info.Hex36_length;

                file.hex37_address = COMOD16_CMP_info.Hex37_address;
                file.hex37_length = COMOD16_CMP_info.Hex37_length;

                file.hex38_address = COMOD16_CMP_info.Hex38_address;
                file.hex38_length = COMOD16_CMP_info.Hex38_length;

                file.hex39_address = COMOD16_CMP_info.Hex39_address;
                file.hex39_length = COMOD16_CMP_info.Hex39_length;

                file.hex40_address = COMOD16_CMP_info.Hex40_address;
                file.hex40_length = COMOD16_CMP_info.Hex40_length;

                file.hex41_address = COMOD16_CMP_info.Hex41_address;
                file.hex41_length = COMOD16_CMP_info.Hex41_length;

                file.hex42_address = COMOD16_CMP_info.Hex42_address;
                file.hex42_length = COMOD16_CMP_info.Hex42_length;

                file.hex43_address = COMOD16_CMP_info.Hex43_address;
                file.hex43_length = COMOD16_CMP_info.Hex43_length;

                file.hex44_address = COMOD16_CMP_info.Hex44_address;
                file.hex44_length = COMOD16_CMP_info.Hex44_length;

                file.hex45_address = COMOD16_CMP_info.Hex45_address;
                file.hex45_length = COMOD16_CMP_info.Hex45_length;

                file.hex46_address = COMOD16_CMP_info.Hex46_address;
                file.hex46_length = COMOD16_CMP_info.Hex46_length;

                file.hex47_address = COMOD16_CMP_info.Hex47_address;
                file.hex47_length = COMOD16_CMP_info.Hex47_length;

                file.hex48_address = COMOD16_CMP_info.Hex48_address;
                file.hex48_length = COMOD16_CMP_info.Hex48_length;

                file.hex49_address = COMOD16_CMP_info.Hex49_address;
                file.hex49_length = COMOD16_CMP_info.Hex49_length;

                file.hex50_address = COMOD16_CMP_info.Hex50_address;
                file.hex50_length = COMOD16_CMP_info.Hex50_length;

                file.hex51_address = COMOD16_CMP_info.Hex51_address;
                file.hex51_length = COMOD16_CMP_info.Hex51_length;

                file.hex52_address = COMOD16_CMP_info.Hex52_address;
                file.hex52_length = COMOD16_CMP_info.Hex52_length;

                file.hex53_address = COMOD16_CMP_info.Hex53_address;
                file.hex53_length = COMOD16_CMP_info.Hex53_length;

                file.hex54_address = COMOD16_CMP_info.Hex54_address;
                file.hex54_length = COMOD16_CMP_info.Hex54_length;

                file.hex55_address = COMOD16_CMP_info.Hex55_address;
                file.hex55_length = COMOD16_CMP_info.Hex55_length;

                file.hex56_address = COMOD16_CMP_info.Hex56_address;
                file.hex56_length = COMOD16_CMP_info.Hex56_length;

                file.hex57_address = COMOD16_CMP_info.Hex57_address;
                file.hex57_length = COMOD16_CMP_info.Hex57_length;

                file.hex58_address = COMOD16_CMP_info.Hex58_address;
                file.hex58_length = COMOD16_CMP_info.Hex58_length;

                file.hex59_address = COMOD16_CMP_info.Hex59_address;
                file.hex59_length = COMOD16_CMP_info.Hex59_length;

                file.hex60_address = COMOD16_CMP_info.Hex60_address;
                file.hex60_length = COMOD16_CMP_info.Hex60_length;

                file.hex61_address = COMOD16_CMP_info.Hex61_address;
                file.hex61_length = COMOD16_CMP_info.Hex61_length;

                file.hex62_address = COMOD16_CMP_info.Hex62_address;
                file.hex62_length = COMOD16_CMP_info.Hex62_length;

                file.hex63_address = COMOD16_CMP_info.Hex63_address;
                file.hex63_length = COMOD16_CMP_info.Hex63_length;

                file.hex64_address = COMOD16_CMP_info.Hex64_address;
                file.hex64_length = COMOD16_CMP_info.Hex64_length;

                file.hex65_address = COMOD16_CMP_info.Hex65_address;
                file.hex65_length = COMOD16_CMP_info.Hex65_length;

                file.hex66_address = COMOD16_CMP_info.Hex66_address;
                file.hex66_length = COMOD16_CMP_info.Hex66_length;

                file.hex67_address = COMOD16_CMP_info.Hex67_address;
                file.hex67_length = COMOD16_CMP_info.Hex67_length;

                file.hex68_address = COMOD16_CMP_info.Hex68_address;
                file.hex68_length = COMOD16_CMP_info.Hex68_length;

                file.hex69_address = COMOD16_CMP_info.Hex69_address;
                file.hex69_length = COMOD16_CMP_info.Hex69_length;

                file.hex70_address = COMOD16_CMP_info.Hex70_address;
                file.hex70_length = COMOD16_CMP_info.Hex70_length;

                file.hex71_address = COMOD16_CMP_info.Hex71_address;
                file.hex71_length = COMOD16_CMP_info.Hex71_length;

                file.hex72_address = COMOD16_CMP_info.Hex72_address;
                file.hex72_length = COMOD16_CMP_info.Hex72_length;

                file.hex73_address = 0;
                file.hex73_length = 1;
                Hex73.Enabled = false;
                Text73.Enabled = false;

                file.hex74_address = 0;
                file.hex74_length = 1;
                Hex74.Enabled = false;
                Text74.Enabled = false;

                file.hex75_address = 0;
                file.hex75_length = 1;
                Hex75.Enabled = false;
                Text75.Enabled = false;

                file.hex76_address = 0;
                file.hex76_length = 1;
                Hex76.Enabled = false;
                Text76.Enabled = false;

                file.hex77_address = 0;
                file.hex77_length = 1;
                Hex77.Enabled = false;
                Text77.Enabled = false;

                file.hex78_address = 0;
                file.hex78_length = 1;
                Hex78.Enabled = false;
                Text78.Enabled = false;

                file.hex79_address = 0;
                file.hex79_length = 1;
                Hex79.Enabled = false;
                Text79.Enabled = false;

                file.hex80_address = 0;
                file.hex80_length = 1;
                Hex80.Enabled = false;
                Text80.Enabled = false;

                file.hex81_address = 0;
                file.hex81_length = 1;
                Hex81.Enabled = false;
                Text81.Enabled = false;

                file.hex82_address = 0;
                file.hex82_length = 1;
                Hex82.Enabled = false;
                Text82.Enabled = false;

                file.hex83_address = 0;
                file.hex83_length = 1;
                Hex83.Enabled = false;
                Text83.Enabled = false;

                file.hex84_address = 0;
                file.hex84_length = 1;
                Hex84.Enabled = false;
                Text84.Enabled = false;

                file.hex85_address = 0;
                file.hex85_length = 1;
                Hex85.Enabled = false;
                Text85.Enabled = false;

                file.hex86_address = 0;
                file.hex86_length = 1;
                Hex86.Enabled = false;
                Text86.Enabled = false;

                file.hex87_address = 0;
                file.hex87_length = 1;
                Hex87.Enabled = false;
                Text87.Enabled = false;

                file.hex88_address = 0;
                file.hex88_length = 1;
                Hex88.Enabled = false;
                Text88.Enabled = false;

                file.hex89_address = 0;
                file.hex89_length = 1;
                Hex89.Enabled = false;
                Text89.Enabled = false;

                file.hex90_address = 0;
                file.hex90_length = 1;
                Hex90.Enabled = false;
                Text90.Enabled = false;

                file.hex91_address = 0;
                file.hex91_length = 1;
                Hex91.Enabled = false;
                Text91.Enabled = false;

                file.hex92_address = 0;
                file.hex92_length = 1;
                Hex92.Enabled = false;
                Text92.Enabled = false;

                file.hex93_address = 0;
                file.hex93_length = 1;
                Hex93.Enabled = false;
                Text93.Enabled = false;

                file.hex94_address = 0;
                file.hex94_length = 1;
                Hex94.Enabled = false;
                Text94.Enabled = false;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD6.CMP")
            {
                this.Text = "COMOD6.CMP - Level 6 Lammy Vs Parappa - 90 lines";
                file.hex1_address = COMOD6_CMP_info.Hex1_address;
                file.hex1_length = COMOD6_CMP_info.Hex1_length;

                file.hex2_address = COMOD6_CMP_info.Hex2_address;
                file.hex2_length = COMOD6_CMP_info.Hex2_length;

                file.hex3_address = COMOD6_CMP_info.Hex3_address;
                file.hex3_length = COMOD6_CMP_info.Hex3_length;

                file.hex4_address = COMOD6_CMP_info.Hex4_address;
                file.hex4_length = COMOD6_CMP_info.Hex4_length;

                file.hex5_address = COMOD6_CMP_info.Hex5_address;
                file.hex5_length = COMOD6_CMP_info.Hex5_length;

                file.hex6_address = COMOD6_CMP_info.Hex6_address;
                file.hex6_length = COMOD6_CMP_info.Hex6_length;

                file.hex7_address = COMOD6_CMP_info.Hex7_address;
                file.hex7_length = COMOD6_CMP_info.Hex7_length;

                file.hex8_address = COMOD6_CMP_info.Hex8_address;
                file.hex8_length = COMOD6_CMP_info.Hex8_length;

                file.hex9_address = COMOD6_CMP_info.Hex9_address;
                file.hex9_length = COMOD6_CMP_info.Hex9_length;

                file.hex10_address = COMOD6_CMP_info.Hex10_address;
                file.hex10_length = COMOD6_CMP_info.Hex10_length;

                file.hex11_address = COMOD6_CMP_info.Hex11_address;
                file.hex11_length = COMOD6_CMP_info.Hex11_length;

                file.hex12_address = COMOD6_CMP_info.Hex12_address;
                file.hex12_length = COMOD6_CMP_info.Hex12_length;

                file.hex13_address = COMOD6_CMP_info.Hex13_address;
                file.hex13_length = COMOD6_CMP_info.Hex13_length;

                file.hex14_address = COMOD6_CMP_info.Hex14_address;
                file.hex14_length = COMOD6_CMP_info.Hex14_length;

                file.hex15_address = COMOD6_CMP_info.Hex15_address;
                file.hex15_length = COMOD6_CMP_info.Hex15_length;

                file.hex16_address = COMOD6_CMP_info.Hex16_address;
                file.hex16_length = COMOD6_CMP_info.Hex16_length;

                file.hex17_address = COMOD6_CMP_info.Hex17_address;
                file.hex17_length = COMOD6_CMP_info.Hex17_length;

                file.hex18_address = COMOD6_CMP_info.Hex18_address;
                file.hex18_length = COMOD6_CMP_info.Hex18_length;

                file.hex19_address = COMOD6_CMP_info.Hex19_address;
                file.hex19_length = COMOD6_CMP_info.Hex19_length;

                file.hex20_address = COMOD6_CMP_info.Hex20_address;
                file.hex20_length = COMOD6_CMP_info.Hex20_length;

                file.hex21_address = COMOD6_CMP_info.Hex21_address;
                file.hex21_length = COMOD6_CMP_info.Hex21_length;

                file.hex22_address = COMOD6_CMP_info.Hex22_address;
                file.hex22_length = COMOD6_CMP_info.Hex22_length;

                file.hex23_address = COMOD6_CMP_info.Hex23_address;
                file.hex23_length = COMOD6_CMP_info.Hex23_length;

                file.hex24_address = COMOD6_CMP_info.Hex24_address;
                file.hex24_length = COMOD6_CMP_info.Hex24_length;

                file.hex25_address = COMOD6_CMP_info.Hex25_address;
                file.hex25_length = COMOD6_CMP_info.Hex25_length;

                file.hex26_address = COMOD6_CMP_info.Hex26_address;
                file.hex26_length = COMOD6_CMP_info.Hex26_length;

                file.hex27_address = COMOD6_CMP_info.Hex27_address;
                file.hex27_length = COMOD6_CMP_info.Hex27_length;

                file.hex28_address = COMOD6_CMP_info.Hex28_address;
                file.hex28_length = COMOD6_CMP_info.Hex28_length;

                file.hex29_address = COMOD6_CMP_info.Hex29_address;
                file.hex29_length = COMOD6_CMP_info.Hex29_length;

                file.hex30_address = COMOD6_CMP_info.Hex30_address;
                file.hex30_length = COMOD6_CMP_info.Hex30_length;

                file.hex31_address = COMOD6_CMP_info.Hex31_address;
                file.hex31_length = COMOD6_CMP_info.Hex31_length;

                file.hex32_address = COMOD6_CMP_info.Hex32_address;
                file.hex32_length = COMOD6_CMP_info.Hex32_length;

                file.hex33_address = COMOD6_CMP_info.Hex33_address;
                file.hex33_length = COMOD6_CMP_info.Hex33_length;

                file.hex34_address = COMOD6_CMP_info.Hex34_address;
                file.hex34_length = COMOD6_CMP_info.Hex34_length;

                file.hex35_address = COMOD6_CMP_info.Hex35_address;
                file.hex35_length = COMOD6_CMP_info.Hex35_length;

                file.hex36_address = COMOD6_CMP_info.Hex36_address;
                file.hex36_length = COMOD6_CMP_info.Hex36_length;

                file.hex37_address = COMOD6_CMP_info.Hex37_address;
                file.hex37_length = COMOD6_CMP_info.Hex37_length;

                file.hex38_address = COMOD6_CMP_info.Hex38_address;
                file.hex38_length = COMOD6_CMP_info.Hex38_length;

                file.hex39_address = COMOD6_CMP_info.Hex39_address;
                file.hex39_length = COMOD6_CMP_info.Hex39_length;

                file.hex40_address = COMOD6_CMP_info.Hex40_address;
                file.hex40_length = COMOD6_CMP_info.Hex40_length;

                file.hex41_address = COMOD6_CMP_info.Hex41_address;
                file.hex41_length = COMOD6_CMP_info.Hex41_length;

                file.hex42_address = COMOD6_CMP_info.Hex42_address;
                file.hex42_length = COMOD6_CMP_info.Hex42_length;

                file.hex43_address = COMOD6_CMP_info.Hex43_address;
                file.hex43_length = COMOD6_CMP_info.Hex43_length;

                file.hex44_address = COMOD6_CMP_info.Hex44_address;
                file.hex44_length = COMOD6_CMP_info.Hex44_length;

                file.hex45_address = COMOD6_CMP_info.Hex45_address;
                file.hex45_length = COMOD6_CMP_info.Hex45_length;

                file.hex46_address = COMOD6_CMP_info.Hex46_address;
                file.hex46_length = COMOD6_CMP_info.Hex46_length;

                file.hex47_address = COMOD6_CMP_info.Hex47_address;
                file.hex47_length = COMOD6_CMP_info.Hex47_length;

                file.hex48_address = COMOD6_CMP_info.Hex48_address;
                file.hex48_length = COMOD6_CMP_info.Hex48_length;

                file.hex49_address = COMOD6_CMP_info.Hex49_address;
                file.hex49_length = COMOD6_CMP_info.Hex49_length;

                file.hex50_address = COMOD6_CMP_info.Hex50_address;
                file.hex50_length = COMOD6_CMP_info.Hex50_length;

                file.hex51_address = COMOD6_CMP_info.Hex51_address;
                file.hex51_length = COMOD6_CMP_info.Hex51_length;

                file.hex52_address = COMOD6_CMP_info.Hex52_address;
                file.hex52_length = COMOD6_CMP_info.Hex52_length;

                file.hex53_address = COMOD6_CMP_info.Hex53_address;
                file.hex53_length = COMOD6_CMP_info.Hex53_length;

                file.hex54_address = COMOD6_CMP_info.Hex54_address;
                file.hex54_length = COMOD6_CMP_info.Hex54_length;

                file.hex55_address = COMOD6_CMP_info.Hex55_address;
                file.hex55_length = COMOD6_CMP_info.Hex55_length;

                file.hex56_address = COMOD6_CMP_info.Hex56_address;
                file.hex56_length = COMOD6_CMP_info.Hex56_length;

                file.hex57_address = COMOD6_CMP_info.Hex57_address;
                file.hex57_length = COMOD6_CMP_info.Hex57_length;

                file.hex58_address = COMOD6_CMP_info.Hex58_address;
                file.hex58_length = COMOD6_CMP_info.Hex58_length;

                file.hex59_address = COMOD6_CMP_info.Hex59_address;
                file.hex59_length = COMOD6_CMP_info.Hex59_length;

                file.hex60_address = COMOD6_CMP_info.Hex60_address;
                file.hex60_length = COMOD6_CMP_info.Hex60_length;

                file.hex61_address = COMOD6_CMP_info.Hex61_address;
                file.hex61_length = COMOD6_CMP_info.Hex61_length;

                file.hex62_address = COMOD6_CMP_info.Hex62_address;
                file.hex62_length = COMOD6_CMP_info.Hex62_length;

                file.hex63_address = COMOD6_CMP_info.Hex63_address;
                file.hex63_length = COMOD6_CMP_info.Hex63_length;

                file.hex64_address = COMOD6_CMP_info.Hex64_address;
                file.hex64_length = COMOD6_CMP_info.Hex64_length;

                file.hex65_address = COMOD6_CMP_info.Hex65_address;
                file.hex65_length = COMOD6_CMP_info.Hex65_length;

                file.hex66_address = COMOD6_CMP_info.Hex66_address;
                file.hex66_length = COMOD6_CMP_info.Hex66_length;

                file.hex67_address = COMOD6_CMP_info.Hex67_address;
                file.hex67_length = COMOD6_CMP_info.Hex67_length;

                file.hex68_address = COMOD6_CMP_info.Hex68_address;
                file.hex68_length = COMOD6_CMP_info.Hex68_length;

                file.hex69_address = COMOD6_CMP_info.Hex69_address;
                file.hex69_length = COMOD6_CMP_info.Hex69_length;

                file.hex70_address = COMOD6_CMP_info.Hex70_address;
                file.hex70_length = COMOD6_CMP_info.Hex70_length;

                file.hex71_address = COMOD6_CMP_info.Hex71_address;
                file.hex71_length = COMOD6_CMP_info.Hex71_length;

                file.hex72_address = COMOD6_CMP_info.Hex72_address;
                file.hex72_length = COMOD6_CMP_info.Hex72_length;

                file.hex73_address = COMOD6_CMP_info.Hex73_address;
                file.hex73_length = COMOD6_CMP_info.Hex73_length;

                file.hex74_address = COMOD6_CMP_info.Hex74_address;
                file.hex74_length = COMOD6_CMP_info.Hex74_length;

                file.hex75_address = COMOD6_CMP_info.Hex75_address;
                file.hex75_length = COMOD6_CMP_info.Hex75_length;

                file.hex76_address = COMOD6_CMP_info.Hex76_address;
                file.hex76_length = COMOD6_CMP_info.Hex76_length;

                file.hex77_address = COMOD6_CMP_info.Hex77_address;
                file.hex77_length = COMOD6_CMP_info.Hex77_length;

                file.hex78_address = COMOD6_CMP_info.Hex78_address;
                file.hex78_length = COMOD6_CMP_info.Hex78_length;

                file.hex79_address = COMOD6_CMP_info.Hex79_address;
                file.hex79_length = COMOD6_CMP_info.Hex79_length;

                file.hex80_address = COMOD6_CMP_info.Hex80_address;
                file.hex80_length = COMOD6_CMP_info.Hex80_length;

                file.hex81_address = COMOD6_CMP_info.Hex81_address;
                file.hex81_length = COMOD6_CMP_info.Hex81_length;

                file.hex82_address = COMOD6_CMP_info.Hex82_address;
                file.hex82_length = COMOD6_CMP_info.Hex82_length;

                file.hex83_address = COMOD6_CMP_info.Hex83_address;
                file.hex83_length = COMOD6_CMP_info.Hex83_length;

                file.hex84_address = COMOD6_CMP_info.Hex84_address;
                file.hex84_length = COMOD6_CMP_info.Hex84_length;

                file.hex85_address = COMOD6_CMP_info.Hex85_address;
                file.hex85_length = COMOD6_CMP_info.Hex85_length;

                file.hex86_address = COMOD6_CMP_info.Hex86_address;
                file.hex86_length = COMOD6_CMP_info.Hex86_length;

                file.hex87_address = COMOD6_CMP_info.Hex87_address;
                file.hex87_length = COMOD6_CMP_info.Hex87_length;

                file.hex88_address = COMOD6_CMP_info.Hex88_address;
                file.hex88_length = COMOD6_CMP_info.Hex88_length;

                file.hex89_address = COMOD6_CMP_info.Hex89_address;
                file.hex89_length = COMOD6_CMP_info.Hex89_length;

                file.hex90_address = COMOD6_CMP_info.Hex90_address;
                file.hex90_length = COMOD6_CMP_info.Hex90_length;

                file.hex91_address = 0;
                file.hex91_length = 1;
                Hex91.Enabled = false;
                Text91.Enabled = false;

                file.hex92_address = 0;
                file.hex92_length = 1;
                Hex92.Enabled = false;
                Text92.Enabled = false;

                file.hex93_address = 0;
                file.hex93_length = 1;
                Hex93.Enabled = false;
                Text93.Enabled = false;

                file.hex94_address = 0;
                file.hex94_length = 1;
                Hex94.Enabled = false;
                Text94.Enabled = false;

                file.hex95_address = 0;
                file.hex95_length = 1;
                Hex95.Enabled = false;
                Text95.Enabled = false;

                file.hex96_address = 0;
                file.hex96_length = 1;
                Hex96.Enabled = false;
                Text96.Enabled = false;

                file.hex97_address = 0;
                file.hex97_length = 1;
                Hex97.Enabled = false;
                Text97.Enabled = false;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD6.COP")
            {
                this.Text = "COMOD6.COP - Level 6 Co-op Lammy - 97 lines";
                file.hex1_address = COMOD6_COP_info.Hex1_address;
                file.hex1_length = COMOD6_COP_info.Hex1_length;

                file.hex2_address = COMOD6_COP_info.Hex2_address;
                file.hex2_length = COMOD6_COP_info.Hex2_length;

                file.hex3_address = COMOD6_COP_info.Hex3_address;
                file.hex3_length = COMOD6_COP_info.Hex3_length;

                file.hex4_address = COMOD6_COP_info.Hex4_address;
                file.hex4_length = COMOD6_COP_info.Hex4_length;

                file.hex5_address = COMOD6_COP_info.Hex5_address;
                file.hex5_length = COMOD6_COP_info.Hex5_length;

                file.hex6_address = COMOD6_COP_info.Hex6_address;
                file.hex6_length = COMOD6_COP_info.Hex6_length;

                file.hex7_address = COMOD6_COP_info.Hex7_address;
                file.hex7_length = COMOD6_COP_info.Hex7_length;

                file.hex8_address = COMOD6_COP_info.Hex8_address;
                file.hex8_length = COMOD6_COP_info.Hex8_length;

                file.hex9_address = COMOD6_COP_info.Hex9_address;
                file.hex9_length = COMOD6_COP_info.Hex9_length;

                file.hex10_address = COMOD6_COP_info.Hex10_address;
                file.hex10_length = COMOD6_COP_info.Hex10_length;

                file.hex11_address = COMOD6_COP_info.Hex11_address;
                file.hex11_length = COMOD6_COP_info.Hex11_length;

                file.hex12_address = COMOD6_COP_info.Hex12_address;
                file.hex12_length = COMOD6_COP_info.Hex12_length;

                file.hex13_address = COMOD6_COP_info.Hex13_address;
                file.hex13_length = COMOD6_COP_info.Hex13_length;

                file.hex14_address = COMOD6_COP_info.Hex14_address;
                file.hex14_length = COMOD6_COP_info.Hex14_length;

                file.hex15_address = COMOD6_COP_info.Hex15_address;
                file.hex15_length = COMOD6_COP_info.Hex15_length;

                file.hex16_address = COMOD6_COP_info.Hex16_address;
                file.hex16_length = COMOD6_COP_info.Hex16_length;

                file.hex17_address = COMOD6_COP_info.Hex17_address;
                file.hex17_length = COMOD6_COP_info.Hex17_length;

                file.hex18_address = COMOD6_COP_info.Hex18_address;
                file.hex18_length = COMOD6_COP_info.Hex18_length;

                file.hex19_address = COMOD6_COP_info.Hex19_address;
                file.hex19_length = COMOD6_COP_info.Hex19_length;

                file.hex20_address = COMOD6_COP_info.Hex20_address;
                file.hex20_length = COMOD6_COP_info.Hex20_length;

                file.hex21_address = COMOD6_COP_info.Hex21_address;
                file.hex21_length = COMOD6_COP_info.Hex21_length;

                file.hex22_address = COMOD6_COP_info.Hex22_address;
                file.hex22_length = COMOD6_COP_info.Hex22_length;

                file.hex23_address = COMOD6_COP_info.Hex23_address;
                file.hex23_length = COMOD6_COP_info.Hex23_length;

                file.hex24_address = COMOD6_COP_info.Hex24_address;
                file.hex24_length = COMOD6_COP_info.Hex24_length;

                file.hex25_address = COMOD6_COP_info.Hex25_address;
                file.hex25_length = COMOD6_COP_info.Hex25_length;

                file.hex26_address = COMOD6_COP_info.Hex26_address;
                file.hex26_length = COMOD6_COP_info.Hex26_length;

                file.hex27_address = COMOD6_COP_info.Hex27_address;
                file.hex27_length = COMOD6_COP_info.Hex27_length;

                file.hex28_address = COMOD6_COP_info.Hex28_address;
                file.hex28_length = COMOD6_COP_info.Hex28_length;

                file.hex29_address = COMOD6_COP_info.Hex29_address;
                file.hex29_length = COMOD6_COP_info.Hex29_length;

                file.hex30_address = COMOD6_COP_info.Hex30_address;
                file.hex30_length = COMOD6_COP_info.Hex30_length;

                file.hex31_address = COMOD6_COP_info.Hex31_address;
                file.hex31_length = COMOD6_COP_info.Hex31_length;

                file.hex32_address = COMOD6_COP_info.Hex32_address;
                file.hex32_length = COMOD6_COP_info.Hex32_length;

                file.hex33_address = COMOD6_COP_info.Hex33_address;
                file.hex33_length = COMOD6_COP_info.Hex33_length;

                file.hex34_address = COMOD6_COP_info.Hex34_address;
                file.hex34_length = COMOD6_COP_info.Hex34_length;

                file.hex35_address = COMOD6_COP_info.Hex35_address;
                file.hex35_length = COMOD6_COP_info.Hex35_length;

                file.hex36_address = COMOD6_COP_info.Hex36_address;
                file.hex36_length = COMOD6_COP_info.Hex36_length;

                file.hex37_address = COMOD6_COP_info.Hex37_address;
                file.hex37_length = COMOD6_COP_info.Hex37_length;

                file.hex38_address = COMOD6_COP_info.Hex38_address;
                file.hex38_length = COMOD6_COP_info.Hex38_length;

                file.hex39_address = COMOD6_COP_info.Hex39_address;
                file.hex39_length = COMOD6_COP_info.Hex39_length;

                file.hex40_address = COMOD6_COP_info.Hex40_address;
                file.hex40_length = COMOD6_COP_info.Hex40_length;

                file.hex41_address = COMOD6_COP_info.Hex41_address;
                file.hex41_length = COMOD6_COP_info.Hex41_length;

                file.hex42_address = COMOD6_COP_info.Hex42_address;
                file.hex42_length = COMOD6_COP_info.Hex42_length;

                file.hex43_address = COMOD6_COP_info.Hex43_address;
                file.hex43_length = COMOD6_COP_info.Hex43_length;

                file.hex44_address = COMOD6_COP_info.Hex44_address;
                file.hex44_length = COMOD6_COP_info.Hex44_length;

                file.hex45_address = COMOD6_COP_info.Hex45_address;
                file.hex45_length = COMOD6_COP_info.Hex45_length;

                file.hex46_address = COMOD6_COP_info.Hex46_address;
                file.hex46_length = COMOD6_COP_info.Hex46_length;

                file.hex47_address = COMOD6_COP_info.Hex47_address;
                file.hex47_length = COMOD6_COP_info.Hex47_length;

                file.hex48_address = COMOD6_COP_info.Hex48_address;
                file.hex48_length = COMOD6_COP_info.Hex48_length;

                file.hex49_address = COMOD6_COP_info.Hex49_address;
                file.hex49_length = COMOD6_COP_info.Hex49_length;

                file.hex50_address = COMOD6_COP_info.Hex50_address;
                file.hex50_length = COMOD6_COP_info.Hex50_length;

                file.hex51_address = COMOD6_COP_info.Hex51_address;
                file.hex51_length = COMOD6_COP_info.Hex51_length;

                file.hex52_address = COMOD6_COP_info.Hex52_address;
                file.hex52_length = COMOD6_COP_info.Hex52_length;

                file.hex53_address = COMOD6_COP_info.Hex53_address;
                file.hex53_length = COMOD6_COP_info.Hex53_length;

                file.hex54_address = COMOD6_COP_info.Hex54_address;
                file.hex54_length = COMOD6_COP_info.Hex54_length;

                file.hex55_address = COMOD6_COP_info.Hex55_address;
                file.hex55_length = COMOD6_COP_info.Hex55_length;

                file.hex56_address = COMOD6_COP_info.Hex56_address;
                file.hex56_length = COMOD6_COP_info.Hex56_length;

                file.hex57_address = COMOD6_COP_info.Hex57_address;
                file.hex57_length = COMOD6_COP_info.Hex57_length;

                file.hex58_address = COMOD6_COP_info.Hex58_address;
                file.hex58_length = COMOD6_COP_info.Hex58_length;

                file.hex59_address = COMOD6_COP_info.Hex59_address;
                file.hex59_length = COMOD6_COP_info.Hex59_length;

                file.hex60_address = COMOD6_COP_info.Hex60_address;
                file.hex60_length = COMOD6_COP_info.Hex60_length;

                file.hex61_address = COMOD6_COP_info.Hex61_address;
                file.hex61_length = COMOD6_COP_info.Hex61_length;

                file.hex62_address = COMOD6_COP_info.Hex62_address;
                file.hex62_length = COMOD6_COP_info.Hex62_length;

                file.hex63_address = COMOD6_COP_info.Hex63_address;
                file.hex63_length = COMOD6_COP_info.Hex63_length;

                file.hex64_address = COMOD6_COP_info.Hex64_address;
                file.hex64_length = COMOD6_COP_info.Hex64_length;

                file.hex65_address = COMOD6_COP_info.Hex65_address;
                file.hex65_length = COMOD6_COP_info.Hex65_length;

                file.hex66_address = COMOD6_COP_info.Hex66_address;
                file.hex66_length = COMOD6_COP_info.Hex66_length;

                file.hex67_address = COMOD6_COP_info.Hex67_address;
                file.hex67_length = COMOD6_COP_info.Hex67_length;

                file.hex68_address = COMOD6_COP_info.Hex68_address;
                file.hex68_length = COMOD6_COP_info.Hex68_length;

                file.hex69_address = COMOD6_COP_info.Hex69_address;
                file.hex69_length = COMOD6_COP_info.Hex69_length;

                file.hex70_address = COMOD6_COP_info.Hex70_address;
                file.hex70_length = COMOD6_COP_info.Hex70_length;

                file.hex71_address = COMOD6_COP_info.Hex71_address;
                file.hex71_length = COMOD6_COP_info.Hex71_length;

                file.hex72_address = COMOD6_COP_info.Hex72_address;
                file.hex72_length = COMOD6_COP_info.Hex72_length;

                file.hex73_address = COMOD6_COP_info.Hex73_address;
                file.hex73_length = COMOD6_COP_info.Hex73_length;

                file.hex74_address = COMOD6_COP_info.Hex74_address;
                file.hex74_length = COMOD6_COP_info.Hex74_length;

                file.hex75_address = COMOD6_COP_info.Hex75_address;
                file.hex75_length = COMOD6_COP_info.Hex75_length;

                file.hex76_address = COMOD6_COP_info.Hex76_address;
                file.hex76_length = COMOD6_COP_info.Hex76_length;

                file.hex77_address = COMOD6_COP_info.Hex77_address;
                file.hex77_length = COMOD6_COP_info.Hex77_length;

                file.hex78_address = COMOD6_COP_info.Hex78_address;
                file.hex78_length = COMOD6_COP_info.Hex78_length;

                file.hex79_address = COMOD6_COP_info.Hex79_address;
                file.hex79_length = COMOD6_COP_info.Hex79_length;

                file.hex80_address = COMOD6_COP_info.Hex80_address;
                file.hex80_length = COMOD6_COP_info.Hex80_length;

                file.hex81_address = COMOD6_COP_info.Hex81_address;
                file.hex81_length = COMOD6_COP_info.Hex81_length;

                file.hex82_address = COMOD6_COP_info.Hex82_address;
                file.hex82_length = COMOD6_COP_info.Hex82_length;

                file.hex83_address = COMOD6_COP_info.Hex83_address;
                file.hex83_length = COMOD6_COP_info.Hex83_length;

                file.hex84_address = COMOD6_COP_info.Hex84_address;
                file.hex84_length = COMOD6_COP_info.Hex84_length;

                file.hex85_address = COMOD6_COP_info.Hex85_address;
                file.hex85_length = COMOD6_COP_info.Hex85_length;

                file.hex86_address = COMOD6_COP_info.Hex86_address;
                file.hex86_length = COMOD6_COP_info.Hex86_length;

                file.hex87_address = COMOD6_COP_info.Hex87_address;
                file.hex87_length = COMOD6_COP_info.Hex87_length;

                file.hex88_address = COMOD6_COP_info.Hex88_address;
                file.hex88_length = COMOD6_COP_info.Hex88_length;

                file.hex89_address = COMOD6_COP_info.Hex89_address;
                file.hex89_length = COMOD6_COP_info.Hex89_length;

                file.hex90_address = COMOD6_COP_info.Hex90_address;
                file.hex90_length = COMOD6_COP_info.Hex90_length;

                file.hex91_address = COMOD6_COP_info.Hex91_address;
                file.hex91_length = COMOD6_COP_info.Hex91_length;

                file.hex92_address = COMOD6_COP_info.Hex92_address;
                file.hex92_length = COMOD6_COP_info.Hex92_length;

                file.hex93_address = COMOD6_COP_info.Hex93_address;
                file.hex93_length = COMOD6_COP_info.Hex93_length;

                file.hex94_address = COMOD6_COP_info.Hex94_address;
                file.hex94_length = COMOD6_COP_info.Hex94_length;

                file.hex95_address = COMOD6_COP_info.Hex95_address;
                file.hex95_length = COMOD6_COP_info.Hex95_length;

                file.hex96_address = COMOD6_COP_info.Hex96_address;
                file.hex96_length = COMOD6_COP_info.Hex96_length;

                file.hex97_address = COMOD6_COP_info.Hex97_address;
                file.hex97_length = COMOD6_COP_info.Hex97_length;

                file.hex98_address = 0;
                file.hex98_length = 1;
                Hex98.Enabled = false;
                Text98.Enabled = false;

                file.hex99_address = 0;
                file.hex99_length = 1;
                Hex99.Enabled = false;
                Text99.Enabled = false;

                file.hex100_address = 0;
                file.hex100_length = 1;
                Hex100.Enabled = false;
                Text100.Enabled = false;

                file.hex101_address = 0;
                file.hex101_length = 1;
                Hex101.Enabled = false;
                Text101.Enabled = false;

                file.hex102_address = 0;
                file.hex102_length = 1;
                Hex102.Enabled = false;
                Text102.Enabled = false;

                file.hex103_address = 0;
                file.hex103_length = 1;
                Hex103.Enabled = false;
                Text103.Enabled = false;

                file.hex104_address = 0;
                file.hex104_length = 1;
                Hex104.Enabled = false;
                Text104.Enabled = false;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if(Open_File.OpenFile.FileName == "COMOD16.COP")
            {
                this.Text = "COMOD16.COP - Level 6 Co-op Parappa - 104 lines";
                file.hex1_address = COMOD16_COP_info.Hex1_address;
                file.hex1_length = COMOD16_COP_info.Hex1_length;

                file.hex2_address = COMOD16_COP_info.Hex2_address;
                file.hex2_length = COMOD16_COP_info.Hex2_length;

                file.hex3_address = COMOD16_COP_info.Hex3_address;
                file.hex3_length = COMOD16_COP_info.Hex3_length;

                file.hex4_address = COMOD16_COP_info.Hex4_address;
                file.hex4_length = COMOD16_COP_info.Hex4_length;

                file.hex5_address = COMOD16_COP_info.Hex5_address;
                file.hex5_length = COMOD16_COP_info.Hex5_length;

                file.hex6_address = COMOD16_COP_info.Hex6_address;
                file.hex6_length = COMOD16_COP_info.Hex6_length;

                file.hex7_address = COMOD16_COP_info.Hex7_address;
                file.hex7_length = COMOD16_COP_info.Hex7_length;

                file.hex8_address = COMOD16_COP_info.Hex8_address;
                file.hex8_length = COMOD16_COP_info.Hex8_length;

                file.hex9_address = COMOD16_COP_info.Hex9_address;
                file.hex9_length = COMOD16_COP_info.Hex9_length;

                file.hex10_address = COMOD16_COP_info.Hex10_address;
                file.hex10_length = COMOD16_COP_info.Hex10_length;

                file.hex11_address = COMOD16_COP_info.Hex11_address;
                file.hex11_length = COMOD16_COP_info.Hex11_length;

                file.hex12_address = COMOD16_COP_info.Hex12_address;
                file.hex12_length = COMOD16_COP_info.Hex12_length;

                file.hex13_address = COMOD16_COP_info.Hex13_address;
                file.hex13_length = COMOD16_COP_info.Hex13_length;

                file.hex14_address = COMOD16_COP_info.Hex14_address;
                file.hex14_length = COMOD16_COP_info.Hex14_length;

                file.hex15_address = COMOD16_COP_info.Hex15_address;
                file.hex15_length = COMOD16_COP_info.Hex15_length;

                file.hex16_address = COMOD16_COP_info.Hex16_address;
                file.hex16_length = COMOD16_COP_info.Hex16_length;

                file.hex17_address = COMOD16_COP_info.Hex17_address;
                file.hex17_length = COMOD16_COP_info.Hex17_length;

                file.hex18_address = COMOD16_COP_info.Hex18_address;
                file.hex18_length = COMOD16_COP_info.Hex18_length;

                file.hex19_address = COMOD16_COP_info.Hex19_address;
                file.hex19_length = COMOD16_COP_info.Hex19_length;

                file.hex20_address = COMOD16_COP_info.Hex20_address;
                file.hex20_length = COMOD16_COP_info.Hex20_length;

                file.hex21_address = COMOD16_COP_info.Hex21_address;
                file.hex21_length = COMOD16_COP_info.Hex21_length;

                file.hex22_address = COMOD16_COP_info.Hex22_address;
                file.hex22_length = COMOD16_COP_info.Hex22_length;

                file.hex23_address = COMOD16_COP_info.Hex23_address;
                file.hex23_length = COMOD16_COP_info.Hex23_length;

                file.hex24_address = COMOD16_COP_info.Hex24_address;
                file.hex24_length = COMOD16_COP_info.Hex24_length;

                file.hex25_address = COMOD16_COP_info.Hex25_address;
                file.hex25_length = COMOD16_COP_info.Hex25_length;

                file.hex26_address = COMOD16_COP_info.Hex26_address;
                file.hex26_length = COMOD16_COP_info.Hex26_length;

                file.hex27_address = COMOD16_COP_info.Hex27_address;
                file.hex27_length = COMOD16_COP_info.Hex27_length;

                file.hex28_address = COMOD16_COP_info.Hex28_address;
                file.hex28_length = COMOD16_COP_info.Hex28_length;

                file.hex29_address = COMOD16_COP_info.Hex29_address;
                file.hex29_length = COMOD16_COP_info.Hex29_length;

                file.hex30_address = COMOD16_COP_info.Hex30_address;
                file.hex30_length = COMOD16_COP_info.Hex30_length;

                file.hex31_address = COMOD16_COP_info.Hex31_address;
                file.hex31_length = COMOD16_COP_info.Hex31_length;

                file.hex32_address = COMOD16_COP_info.Hex32_address;
                file.hex32_length = COMOD16_COP_info.Hex32_length;

                file.hex33_address = COMOD16_COP_info.Hex33_address;
                file.hex33_length = COMOD16_COP_info.Hex33_length;

                file.hex34_address = COMOD16_COP_info.Hex34_address;
                file.hex34_length = COMOD16_COP_info.Hex34_length;

                file.hex35_address = COMOD16_COP_info.Hex35_address;
                file.hex35_length = COMOD16_COP_info.Hex35_length;

                file.hex36_address = COMOD16_COP_info.Hex36_address;
                file.hex36_length = COMOD16_COP_info.Hex36_length;

                file.hex37_address = COMOD16_COP_info.Hex37_address;
                file.hex37_length = COMOD16_COP_info.Hex37_length;

                file.hex38_address = COMOD16_COP_info.Hex38_address;
                file.hex38_length = COMOD16_COP_info.Hex38_length;

                file.hex39_address = COMOD16_COP_info.Hex39_address;
                file.hex39_length = COMOD16_COP_info.Hex39_length;

                file.hex40_address = COMOD16_COP_info.Hex40_address;
                file.hex40_length = COMOD16_COP_info.Hex40_length;

                file.hex41_address = COMOD16_COP_info.Hex41_address;
                file.hex41_length = COMOD16_COP_info.Hex41_length;

                file.hex42_address = COMOD16_COP_info.Hex42_address;
                file.hex42_length = COMOD16_COP_info.Hex42_length;

                file.hex43_address = COMOD16_COP_info.Hex43_address;
                file.hex43_length = COMOD16_COP_info.Hex43_length;

                file.hex44_address = COMOD16_COP_info.Hex44_address;
                file.hex44_length = COMOD16_COP_info.Hex44_length;

                file.hex45_address = COMOD16_COP_info.Hex45_address;
                file.hex45_length = COMOD16_COP_info.Hex45_length;

                file.hex46_address = COMOD16_COP_info.Hex46_address;
                file.hex46_length = COMOD16_COP_info.Hex46_length;

                file.hex47_address = COMOD16_COP_info.Hex47_address;
                file.hex47_length = COMOD16_COP_info.Hex47_length;

                file.hex48_address = COMOD16_COP_info.Hex48_address;
                file.hex48_length = COMOD16_COP_info.Hex48_length;

                file.hex49_address = COMOD16_COP_info.Hex49_address;
                file.hex49_length = COMOD16_COP_info.Hex49_length;

                file.hex50_address = COMOD16_COP_info.Hex50_address;
                file.hex50_length = COMOD16_COP_info.Hex50_length;

                file.hex51_address = COMOD16_COP_info.Hex51_address;
                file.hex51_length = COMOD16_COP_info.Hex51_length;

                file.hex52_address = COMOD16_COP_info.Hex52_address;
                file.hex52_length = COMOD16_COP_info.Hex52_length;

                file.hex53_address = COMOD16_COP_info.Hex53_address;
                file.hex53_length = COMOD16_COP_info.Hex53_length;

                file.hex54_address = COMOD16_COP_info.Hex54_address;
                file.hex54_length = COMOD16_COP_info.Hex54_length;

                file.hex55_address = COMOD16_COP_info.Hex55_address;
                file.hex55_length = COMOD16_COP_info.Hex55_length;

                file.hex56_address = COMOD16_COP_info.Hex56_address;
                file.hex56_length = COMOD16_COP_info.Hex56_length;

                file.hex57_address = COMOD16_COP_info.Hex57_address;
                file.hex57_length = COMOD16_COP_info.Hex57_length;

                file.hex58_address = COMOD16_COP_info.Hex58_address;
                file.hex58_length = COMOD16_COP_info.Hex58_length;

                file.hex59_address = COMOD16_COP_info.Hex59_address;
                file.hex59_length = COMOD16_COP_info.Hex59_length;

                file.hex60_address = COMOD16_COP_info.Hex60_address;
                file.hex60_length = COMOD16_COP_info.Hex60_length;

                file.hex61_address = COMOD16_COP_info.Hex61_address;
                file.hex61_length = COMOD16_COP_info.Hex61_length;

                file.hex62_address = COMOD16_COP_info.Hex62_address;
                file.hex62_length = COMOD16_COP_info.Hex62_length;

                file.hex63_address = COMOD16_COP_info.Hex63_address;
                file.hex63_length = COMOD16_COP_info.Hex63_length;

                file.hex64_address = COMOD16_COP_info.Hex64_address;
                file.hex64_length = COMOD16_COP_info.Hex64_length;

                file.hex65_address = COMOD16_COP_info.Hex65_address;
                file.hex65_length = COMOD16_COP_info.Hex65_length;

                file.hex66_address = COMOD16_COP_info.Hex66_address;
                file.hex66_length = COMOD16_COP_info.Hex66_length;

                file.hex67_address = COMOD16_COP_info.Hex67_address;
                file.hex67_length = COMOD16_COP_info.Hex67_length;

                file.hex68_address = COMOD16_COP_info.Hex68_address;
                file.hex68_length = COMOD16_COP_info.Hex68_length;

                file.hex69_address = COMOD16_COP_info.Hex69_address;
                file.hex69_length = COMOD16_COP_info.Hex69_length;

                file.hex70_address = COMOD16_COP_info.Hex70_address;
                file.hex70_length = COMOD16_COP_info.Hex70_length;

                file.hex71_address = COMOD16_COP_info.Hex71_address;
                file.hex71_length = COMOD16_COP_info.Hex71_length;

                file.hex72_address = COMOD16_COP_info.Hex72_address;
                file.hex72_length = COMOD16_COP_info.Hex72_length;

                file.hex73_address = COMOD16_COP_info.Hex73_address;
                file.hex73_length = COMOD16_COP_info.Hex73_length;

                file.hex74_address = COMOD16_COP_info.Hex74_address;
                file.hex74_length = COMOD16_COP_info.Hex74_length;

                file.hex75_address = COMOD16_COP_info.Hex75_address;
                file.hex75_length = COMOD16_COP_info.Hex75_length;

                file.hex76_address = COMOD16_COP_info.Hex76_address;
                file.hex76_length = COMOD16_COP_info.Hex76_length;

                file.hex77_address = COMOD16_COP_info.Hex77_address;
                file.hex77_length = COMOD16_COP_info.Hex77_length;

                file.hex78_address = COMOD16_COP_info.Hex78_address;
                file.hex78_length = COMOD16_COP_info.Hex78_length;

                file.hex79_address = COMOD16_COP_info.Hex79_address;
                file.hex79_length = COMOD16_COP_info.Hex79_length;

                file.hex80_address = COMOD16_COP_info.Hex80_address;
                file.hex80_length = COMOD16_COP_info.Hex80_length;

                file.hex81_address = COMOD16_COP_info.Hex81_address;
                file.hex81_length = COMOD16_COP_info.Hex81_length;

                file.hex82_address = COMOD16_COP_info.Hex82_address;
                file.hex82_length = COMOD16_COP_info.Hex82_length;

                file.hex83_address = COMOD16_COP_info.Hex83_address;
                file.hex83_length = COMOD16_COP_info.Hex83_length;

                file.hex84_address = COMOD16_COP_info.Hex84_address;
                file.hex84_length = COMOD16_COP_info.Hex84_length;

                file.hex85_address = COMOD16_COP_info.Hex85_address;
                file.hex85_length = COMOD16_COP_info.Hex85_length;

                file.hex86_address = COMOD16_COP_info.Hex86_address;
                file.hex86_length = COMOD16_COP_info.Hex86_length;

                file.hex87_address = COMOD16_COP_info.Hex87_address;
                file.hex87_length = COMOD16_COP_info.Hex87_length;

                file.hex88_address = COMOD16_COP_info.Hex88_address;
                file.hex88_length = COMOD16_COP_info.Hex88_length;

                file.hex89_address = COMOD16_COP_info.Hex89_address;
                file.hex89_length = COMOD16_COP_info.Hex89_length;

                file.hex90_address = COMOD16_COP_info.Hex90_address;
                file.hex90_length = COMOD16_COP_info.Hex90_length;

                file.hex91_address = COMOD16_COP_info.Hex91_address;
                file.hex91_length = COMOD16_COP_info.Hex91_length;

                file.hex92_address = COMOD16_COP_info.Hex92_address;
                file.hex92_length = COMOD16_COP_info.Hex92_length;

                file.hex93_address = COMOD16_COP_info.Hex93_address;
                file.hex93_length = COMOD16_COP_info.Hex93_length;

                file.hex94_address = COMOD16_COP_info.Hex94_address;
                file.hex94_length = COMOD16_COP_info.Hex94_length;

                file.hex95_address = COMOD16_COP_info.Hex95_address;
                file.hex95_length = COMOD16_COP_info.Hex95_length;

                file.hex96_address = COMOD16_COP_info.Hex96_address;
                file.hex96_length = COMOD16_COP_info.Hex96_length;

                file.hex97_address = COMOD16_COP_info.Hex97_address;
                file.hex97_length = COMOD16_COP_info.Hex97_length;

                file.hex98_address = COMOD16_COP_info.Hex98_address;
                file.hex98_length = COMOD16_COP_info.Hex98_length;

                file.hex99_address = COMOD16_COP_info.Hex99_address;
                file.hex99_length = COMOD16_COP_info.Hex99_length;

                file.hex100_address = COMOD16_COP_info.Hex100_address;
                file.hex100_length = COMOD16_COP_info.Hex100_length;

                file.hex101_address = COMOD16_COP_info.Hex101_address;
                file.hex101_length = COMOD16_COP_info.Hex101_length;

                file.hex102_address = COMOD16_COP_info.Hex102_address;
                file.hex102_length = COMOD16_COP_info.Hex102_length;

                file.hex103_address = COMOD16_COP_info.Hex103_address;
                file.hex103_length = COMOD16_COP_info.Hex103_length;

                file.hex104_address = COMOD16_COP_info.Hex104_address;
                file.hex104_length = COMOD16_COP_info.Hex104_length;

                file.hex105_address = 0;
                file.hex105_length = 1;
                Hex105.Enabled = false;
                Text105.Enabled = false;

                file.hex106_address = 0;
                file.hex106_length = 1;
                Hex106.Enabled = false;
                Text106.Enabled = false;

                file.hex107_address = 0;
                file.hex107_length = 1;
                Hex107.Enabled = false;
                Text107.Enabled = false;

                file.hex108_address = 0;
                file.hex108_length = 1;
                Hex108.Enabled = false;
                Text108.Enabled = false;

                file.hex109_address = 0;
                file.hex109_length = 1;
                Hex109.Enabled = false;
                Text109.Enabled = false;

                file.hex110_address = 0;
                file.hex110_length = 1;
                Hex110.Enabled = false;
                Text110.Enabled = false;

                file.hex111_address = 0;
                file.hex111_length = 1;
                Hex111.Enabled = false;
                Text111.Enabled = false;

                file.hex112_address = 0;
                file.hex112_length = 1;
                Hex112.Enabled = false;
                Text112.Enabled = false;

                file.hex113_address = 0;
                file.hex113_length = 1;
                Hex113.Enabled = false;
                Text113.Enabled = false;

                file.hex114_address = 0;
                file.hex114_length = 1;
                Hex114.Enabled = false;
                Text114.Enabled = false;

                file.hex115_address = 0;
                file.hex115_length = 1;
                Hex115.Enabled = false;
                Text115.Enabled = false;

                file.hex116_address = 0;
                file.hex116_length = 1;
                Hex116.Enabled = false;
                Text116.Enabled = false;

                file.hex117_address = 0;
                file.hex117_length = 1;
                Hex117.Enabled = false;
                Text117.Enabled = false;

                file.hex118_address = 0;
                file.hex118_length = 1;
                Hex118.Enabled = false;
                Text118.Enabled = false;

                file.hex119_address = 0;
                file.hex119_length = 1;
                Hex119.Enabled = false;
                Text119.Enabled = false;
            }

            if (Open_File.OpenFile.FileName == "COMOD17.SNG")
            {
                this.Text = "COMOD17.SNG - Level 7 Single Lammy - 119 lines";
                file.hex1_address = COMOD17_SNG_info.Hex1_address;
                file.hex1_length = COMOD17_SNG_info.Hex1_length;

                file.hex2_address = COMOD17_SNG_info.Hex2_address;
                file.hex2_length = COMOD17_SNG_info.Hex2_length;

                file.hex3_address = COMOD17_SNG_info.Hex3_address;
                file.hex3_length = COMOD17_SNG_info.Hex3_length;

                file.hex4_address = COMOD17_SNG_info.Hex4_address;
                file.hex4_length = COMOD17_SNG_info.Hex4_length;

                file.hex5_address = COMOD17_SNG_info.Hex5_address;
                file.hex5_length = COMOD17_SNG_info.Hex5_length;

                file.hex6_address = COMOD17_SNG_info.Hex6_address;
                file.hex6_length = COMOD17_SNG_info.Hex6_length;

                file.hex7_address = COMOD17_SNG_info.Hex7_address;
                file.hex7_length = COMOD17_SNG_info.Hex7_length;

                file.hex8_address = COMOD17_SNG_info.Hex8_address;
                file.hex8_length = COMOD17_SNG_info.Hex8_length;

                file.hex9_address = COMOD17_SNG_info.Hex9_address;
                file.hex9_length = COMOD17_SNG_info.Hex9_length;

                file.hex10_address = COMOD17_SNG_info.Hex10_address;
                file.hex10_length = COMOD17_SNG_info.Hex10_length;

                file.hex11_address = COMOD17_SNG_info.Hex11_address;
                file.hex11_length = COMOD17_SNG_info.Hex11_length;

                file.hex12_address = COMOD17_SNG_info.Hex12_address;
                file.hex12_length = COMOD17_SNG_info.Hex12_length;

                file.hex13_address = COMOD17_SNG_info.Hex13_address;
                file.hex13_length = COMOD17_SNG_info.Hex13_length;

                file.hex14_address = COMOD17_SNG_info.Hex14_address;
                file.hex14_length = COMOD17_SNG_info.Hex14_length;

                file.hex15_address = COMOD17_SNG_info.Hex15_address;
                file.hex15_length = COMOD17_SNG_info.Hex15_length;

                file.hex16_address = COMOD17_SNG_info.Hex16_address;
                file.hex16_length = COMOD17_SNG_info.Hex16_length;

                file.hex17_address = COMOD17_SNG_info.Hex17_address;
                file.hex17_length = COMOD17_SNG_info.Hex17_length;

                file.hex18_address = COMOD17_SNG_info.Hex18_address;
                file.hex18_length = COMOD17_SNG_info.Hex18_length;

                file.hex19_address = COMOD17_SNG_info.Hex19_address;
                file.hex19_length = COMOD17_SNG_info.Hex19_length;

                file.hex20_address = COMOD17_SNG_info.Hex20_address;
                file.hex20_length = COMOD17_SNG_info.Hex20_length;

                file.hex21_address = COMOD17_SNG_info.Hex21_address;
                file.hex21_length = COMOD17_SNG_info.Hex21_length;

                file.hex22_address = COMOD17_SNG_info.Hex22_address;
                file.hex22_length = COMOD17_SNG_info.Hex22_length;

                file.hex23_address = COMOD17_SNG_info.Hex23_address;
                file.hex23_length = COMOD17_SNG_info.Hex23_length;

                file.hex24_address = COMOD17_SNG_info.Hex24_address;
                file.hex24_length = COMOD17_SNG_info.Hex24_length;

                file.hex25_address = COMOD17_SNG_info.Hex25_address;
                file.hex25_length = COMOD17_SNG_info.Hex25_length;

                file.hex26_address = COMOD17_SNG_info.Hex26_address;
                file.hex26_length = COMOD17_SNG_info.Hex26_length;

                file.hex27_address = COMOD17_SNG_info.Hex27_address;
                file.hex27_length = COMOD17_SNG_info.Hex27_length;

                file.hex28_address = COMOD17_SNG_info.Hex28_address;
                file.hex28_length = COMOD17_SNG_info.Hex28_length;

                file.hex29_address = COMOD17_SNG_info.Hex29_address;
                file.hex29_length = COMOD17_SNG_info.Hex29_length;

                file.hex30_address = COMOD17_SNG_info.Hex30_address;
                file.hex30_length = COMOD17_SNG_info.Hex30_length;

                file.hex31_address = COMOD17_SNG_info.Hex31_address;
                file.hex31_length = COMOD17_SNG_info.Hex31_length;

                file.hex32_address = COMOD17_SNG_info.Hex32_address;
                file.hex32_length = COMOD17_SNG_info.Hex32_length;

                file.hex33_address = COMOD17_SNG_info.Hex33_address;
                file.hex33_length = COMOD17_SNG_info.Hex33_length;

                file.hex34_address = COMOD17_SNG_info.Hex34_address;
                file.hex34_length = COMOD17_SNG_info.Hex34_length;

                file.hex35_address = COMOD17_SNG_info.Hex35_address;
                file.hex35_length = COMOD17_SNG_info.Hex35_length;

                file.hex36_address = COMOD17_SNG_info.Hex36_address;
                file.hex36_length = COMOD17_SNG_info.Hex36_length;

                file.hex37_address = COMOD17_SNG_info.Hex37_address;
                file.hex37_length = COMOD17_SNG_info.Hex37_length;

                file.hex38_address = COMOD17_SNG_info.Hex38_address;
                file.hex38_length = COMOD17_SNG_info.Hex38_length;

                file.hex39_address = COMOD17_SNG_info.Hex39_address;
                file.hex39_length = COMOD17_SNG_info.Hex39_length;

                file.hex40_address = COMOD17_SNG_info.Hex40_address;
                file.hex40_length = COMOD17_SNG_info.Hex40_length;

                file.hex41_address = COMOD17_SNG_info.Hex41_address;
                file.hex41_length = COMOD17_SNG_info.Hex41_length;

                file.hex42_address = COMOD17_SNG_info.Hex42_address;
                file.hex42_length = COMOD17_SNG_info.Hex42_length;

                file.hex43_address = COMOD17_SNG_info.Hex43_address;
                file.hex43_length = COMOD17_SNG_info.Hex43_length;

                file.hex44_address = COMOD17_SNG_info.Hex44_address;
                file.hex44_length = COMOD17_SNG_info.Hex44_length;

                file.hex45_address = COMOD17_SNG_info.Hex45_address;
                file.hex45_length = COMOD17_SNG_info.Hex45_length;

                file.hex46_address = COMOD17_SNG_info.Hex46_address;
                file.hex46_length = COMOD17_SNG_info.Hex46_length;

                file.hex47_address = COMOD17_SNG_info.Hex47_address;
                file.hex47_length = COMOD17_SNG_info.Hex47_length;

                file.hex48_address = COMOD17_SNG_info.Hex48_address;
                file.hex48_length = COMOD17_SNG_info.Hex48_length;

                file.hex49_address = COMOD17_SNG_info.Hex49_address;
                file.hex49_length = COMOD17_SNG_info.Hex49_length;

                file.hex50_address = COMOD17_SNG_info.Hex50_address;
                file.hex50_length = COMOD17_SNG_info.Hex50_length;

                file.hex51_address = COMOD17_SNG_info.Hex51_address;
                file.hex51_length = COMOD17_SNG_info.Hex51_length;

                file.hex52_address = COMOD17_SNG_info.Hex52_address;
                file.hex52_length = COMOD17_SNG_info.Hex52_length;

                file.hex53_address = COMOD17_SNG_info.Hex53_address;
                file.hex53_length = COMOD17_SNG_info.Hex53_length;

                file.hex54_address = COMOD17_SNG_info.Hex54_address;
                file.hex54_length = COMOD17_SNG_info.Hex54_length;

                file.hex55_address = COMOD17_SNG_info.Hex55_address;
                file.hex55_length = COMOD17_SNG_info.Hex55_length;

                file.hex56_address = COMOD17_SNG_info.Hex56_address;
                file.hex56_length = COMOD17_SNG_info.Hex56_length;

                file.hex57_address = COMOD17_SNG_info.Hex57_address;
                file.hex57_length = COMOD17_SNG_info.Hex57_length;

                file.hex58_address = COMOD17_SNG_info.Hex58_address;
                file.hex58_length = COMOD17_SNG_info.Hex58_length;

                file.hex59_address = COMOD17_SNG_info.Hex59_address;
                file.hex59_length = COMOD17_SNG_info.Hex59_length;

                file.hex60_address = COMOD17_SNG_info.Hex60_address;
                file.hex60_length = COMOD17_SNG_info.Hex60_length;

                file.hex61_address = COMOD17_SNG_info.Hex61_address;
                file.hex61_length = COMOD17_SNG_info.Hex61_length;

                file.hex62_address = COMOD17_SNG_info.Hex62_address;
                file.hex62_length = COMOD17_SNG_info.Hex62_length;

                file.hex63_address = COMOD17_SNG_info.Hex63_address;
                file.hex63_length = COMOD17_SNG_info.Hex63_length;

                file.hex64_address = COMOD17_SNG_info.Hex64_address;
                file.hex64_length = COMOD17_SNG_info.Hex64_length;

                file.hex65_address = COMOD17_SNG_info.Hex65_address;
                file.hex65_length = COMOD17_SNG_info.Hex65_length;

                file.hex66_address = COMOD17_SNG_info.Hex66_address;
                file.hex66_length = COMOD17_SNG_info.Hex66_length;

                file.hex67_address = COMOD17_SNG_info.Hex67_address;
                file.hex67_length = COMOD17_SNG_info.Hex67_length;

                file.hex68_address = COMOD17_SNG_info.Hex68_address;
                file.hex68_length = COMOD17_SNG_info.Hex68_length;

                file.hex69_address = COMOD17_SNG_info.Hex69_address;
                file.hex69_length = COMOD17_SNG_info.Hex69_length;

                file.hex70_address = COMOD17_SNG_info.Hex70_address;
                file.hex70_length = COMOD17_SNG_info.Hex70_length;

                file.hex71_address = COMOD17_SNG_info.Hex71_address;
                file.hex71_length = COMOD17_SNG_info.Hex71_length;

                file.hex72_address = COMOD17_SNG_info.Hex72_address;
                file.hex72_length = COMOD17_SNG_info.Hex72_length;

                file.hex73_address = COMOD17_SNG_info.Hex73_address;
                file.hex73_length = COMOD17_SNG_info.Hex73_length;

                file.hex74_address = COMOD17_SNG_info.Hex74_address;
                file.hex74_length = COMOD17_SNG_info.Hex74_length;

                file.hex75_address = COMOD17_SNG_info.Hex75_address;
                file.hex75_length = COMOD17_SNG_info.Hex75_length;

                file.hex76_address = COMOD17_SNG_info.Hex76_address;
                file.hex76_length = COMOD17_SNG_info.Hex76_length;

                file.hex77_address = COMOD17_SNG_info.Hex77_address;
                file.hex77_length = COMOD17_SNG_info.Hex77_length;

                file.hex78_address = COMOD17_SNG_info.Hex78_address;
                file.hex78_length = COMOD17_SNG_info.Hex78_length;

                file.hex79_address = COMOD17_SNG_info.Hex79_address;
                file.hex79_length = COMOD17_SNG_info.Hex79_length;

                file.hex80_address = COMOD17_SNG_info.Hex80_address;
                file.hex80_length = COMOD17_SNG_info.Hex80_length;

                file.hex81_address = COMOD17_SNG_info.Hex81_address;
                file.hex81_length = COMOD17_SNG_info.Hex81_length;

                file.hex82_address = COMOD17_SNG_info.Hex82_address;
                file.hex82_length = COMOD17_SNG_info.Hex82_length;

                file.hex83_address = COMOD17_SNG_info.Hex83_address;
                file.hex83_length = COMOD17_SNG_info.Hex83_length;

                file.hex84_address = COMOD17_SNG_info.Hex84_address;
                file.hex84_length = COMOD17_SNG_info.Hex84_length;

                file.hex85_address = COMOD17_SNG_info.Hex85_address;
                file.hex85_length = COMOD17_SNG_info.Hex85_length;

                file.hex86_address = COMOD17_SNG_info.Hex86_address;
                file.hex86_length = COMOD17_SNG_info.Hex86_length;

                file.hex87_address = COMOD17_SNG_info.Hex87_address;
                file.hex87_length = COMOD17_SNG_info.Hex87_length;

                file.hex88_address = COMOD17_SNG_info.Hex88_address;
                file.hex88_length = COMOD17_SNG_info.Hex88_length;

                file.hex89_address = COMOD17_SNG_info.Hex89_address;
                file.hex89_length = COMOD17_SNG_info.Hex89_length;

                file.hex90_address = COMOD17_SNG_info.Hex90_address;
                file.hex90_length = COMOD17_SNG_info.Hex90_length;

                file.hex91_address = COMOD17_SNG_info.Hex91_address;
                file.hex91_length = COMOD17_SNG_info.Hex91_length;

                file.hex92_address = COMOD17_SNG_info.Hex92_address;
                file.hex92_length = COMOD17_SNG_info.Hex92_length;

                file.hex93_address = COMOD17_SNG_info.Hex93_address;
                file.hex93_length = COMOD17_SNG_info.Hex93_length;

                file.hex94_address = COMOD17_SNG_info.Hex94_address;
                file.hex94_length = COMOD17_SNG_info.Hex94_length;

                file.hex95_address = COMOD17_SNG_info.Hex95_address;
                file.hex95_length = COMOD17_SNG_info.Hex95_length;

                file.hex96_address = COMOD17_SNG_info.Hex96_address;
                file.hex96_length = COMOD17_SNG_info.Hex96_length;

                file.hex97_address = COMOD17_SNG_info.Hex97_address;
                file.hex97_length = COMOD17_SNG_info.Hex97_length;

                file.hex98_address = COMOD17_SNG_info.Hex98_address;
                file.hex98_length = COMOD17_SNG_info.Hex98_length;

                file.hex99_address = COMOD17_SNG_info.Hex99_address;
                file.hex99_length = COMOD17_SNG_info.Hex99_length;

                file.hex100_address = COMOD17_SNG_info.Hex100_address;
                file.hex100_length = COMOD17_SNG_info.Hex100_length;

                file.hex101_address = COMOD17_SNG_info.Hex101_address;
                file.hex101_length = COMOD17_SNG_info.Hex101_length;

                file.hex102_address = COMOD17_SNG_info.Hex102_address;
                file.hex102_length = COMOD17_SNG_info.Hex102_length;

                file.hex103_address = COMOD17_SNG_info.Hex103_address;
                file.hex103_length = COMOD17_SNG_info.Hex103_length;

                file.hex104_address = COMOD17_SNG_info.Hex104_address;
                file.hex104_length = COMOD17_SNG_info.Hex104_length;

                file.hex105_address = COMOD17_SNG_info.Hex105_address;
                file.hex105_length = COMOD17_SNG_info.Hex105_length;

                file.hex106_address = COMOD17_SNG_info.Hex106_address;
                file.hex106_length = COMOD17_SNG_info.Hex106_length;

                file.hex107_address = COMOD17_SNG_info.Hex107_address;
                file.hex107_length = COMOD17_SNG_info.Hex107_length;

                file.hex108_address = COMOD17_SNG_info.Hex108_address;
                file.hex108_length = COMOD17_SNG_info.Hex108_length;

                file.hex109_address = COMOD17_SNG_info.Hex109_address;
                file.hex109_length = COMOD17_SNG_info.Hex109_length;

                file.hex110_address = COMOD17_SNG_info.Hex110_address;
                file.hex110_length = COMOD17_SNG_info.Hex110_length;

                file.hex111_address = COMOD17_SNG_info.Hex111_address;
                file.hex111_length = COMOD17_SNG_info.Hex111_length;

                file.hex112_address = COMOD17_SNG_info.Hex112_address;
                file.hex112_length = COMOD17_SNG_info.Hex112_length;

                file.hex113_address = COMOD17_SNG_info.Hex113_address;
                file.hex113_length = COMOD17_SNG_info.Hex113_length;

                file.hex114_address = COMOD17_SNG_info.Hex114_address;
                file.hex114_length = COMOD17_SNG_info.Hex114_length;

                file.hex115_address = COMOD17_SNG_info.Hex115_address;
                file.hex115_length = COMOD17_SNG_info.Hex115_length;

                file.hex116_address = COMOD17_SNG_info.Hex116_address;
                file.hex116_length = COMOD17_SNG_info.Hex116_length;

                file.hex117_address = COMOD17_SNG_info.Hex117_address;
                file.hex117_length = COMOD17_SNG_info.Hex117_length;

                file.hex118_address = COMOD17_SNG_info.Hex118_address;
                file.hex118_length = COMOD17_SNG_info.Hex118_length;

                file.hex119_address = COMOD17_SNG_info.Hex119_address;
                file.hex119_length = COMOD17_SNG_info.Hex119_length;
            }
        }


        private void Save_as_Click(object sender, EventArgs e)
        {
            if(To_rus.Checked == true)
            {
                Open_File.OpenFile.Torus = true;
            }
            else
            {
                Open_File.OpenFile.Torus = false;
            }
            
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Open_File.OpenFile.FileName;
            saveFileDialog1.Filter = "Compatibility files(*.SNG;*.CMP;*.COP;*.MEN)|*.SNG;*.CMP;*.COP;*.MEN|Single Mode File (*.SNG)|*.SNG|Co-op Mode File(*.COP)|*.COP|VS Mode File(*.CMP)|*.CMP|Menu File (*.MEN)|*.MEN|All files (*.*)|*.*";
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
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex15, file.hex15_length), 0, file.save, file.hex15_address, file.hex15_length); //hex15
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex16, file.hex16_length), 0, file.save, file.hex16_address, file.hex16_length); //hex16
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex17, file.hex17_length), 0, file.save, file.hex17_address, file.hex17_length); //hex17
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex18, file.hex18_length), 0, file.save, file.hex18_address, file.hex18_length); //hex18
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex19, file.hex19_length), 0, file.save, file.hex19_address, file.hex19_length); //hex19
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex20, file.hex20_length), 0, file.save, file.hex20_address, file.hex20_length); //hex20
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex21, file.hex21_length), 0, file.save, file.hex21_address, file.hex21_length); //hex21
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex22, file.hex22_length), 0, file.save, file.hex22_address, file.hex22_length); //hex22
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex23, file.hex23_length), 0, file.save, file.hex23_address, file.hex23_length); //hex23
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex24, file.hex24_length), 0, file.save, file.hex24_address, file.hex24_length); //hex24
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex25, file.hex25_length), 0, file.save, file.hex25_address, file.hex25_length); //hex25
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex26, file.hex26_length), 0, file.save, file.hex26_address, file.hex26_length); //hex26
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex27, file.hex27_length), 0, file.save, file.hex27_address, file.hex27_length); //hex27
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex28, file.hex28_length), 0, file.save, file.hex28_address, file.hex28_length); //hex28
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex29, file.hex29_length), 0, file.save, file.hex29_address, file.hex29_length); //hex29
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex30, file.hex30_length), 0, file.save, file.hex30_address, file.hex30_length); //hex30
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex31, file.hex31_length), 0, file.save, file.hex31_address, file.hex31_length); //hex31
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex32, file.hex32_length), 0, file.save, file.hex32_address, file.hex32_length); //hex32
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex33, file.hex33_length), 0, file.save, file.hex33_address, file.hex33_length); //hex33
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex34, file.hex34_length), 0, file.save, file.hex34_address, file.hex34_length); //hex34
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex35, file.hex35_length), 0, file.save, file.hex35_address, file.hex35_length); //hex35
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex36, file.hex36_length), 0, file.save, file.hex36_address, file.hex36_length); //hex36
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex37, file.hex37_length), 0, file.save, file.hex37_address, file.hex37_length); //hex37
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex38, file.hex38_length), 0, file.save, file.hex38_address, file.hex38_length); //hex38
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex39, file.hex39_length), 0, file.save, file.hex39_address, file.hex39_length); //hex39
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex40, file.hex40_length), 0, file.save, file.hex40_address, file.hex40_length); //hex40
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex41, file.hex41_length), 0, file.save, file.hex41_address, file.hex41_length); //hex41
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex42, file.hex42_length), 0, file.save, file.hex42_address, file.hex42_length); //hex42
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex43, file.hex43_length), 0, file.save, file.hex43_address, file.hex43_length); //hex43
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex44, file.hex44_length), 0, file.save, file.hex44_address, file.hex44_length); //hex44
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex45, file.hex45_length), 0, file.save, file.hex45_address, file.hex45_length); //hex45
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex46, file.hex46_length), 0, file.save, file.hex46_address, file.hex46_length); //hex46
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex47, file.hex47_length), 0, file.save, file.hex47_address, file.hex47_length); //hex47
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex48, file.hex48_length), 0, file.save, file.hex48_address, file.hex48_length); //hex48
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex49, file.hex49_length), 0, file.save, file.hex49_address, file.hex49_length); //hex49
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex50, file.hex50_length), 0, file.save, file.hex50_address, file.hex50_length); //hex50
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex51, file.hex51_length), 0, file.save, file.hex51_address, file.hex51_length); //hex51
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex52, file.hex52_length), 0, file.save, file.hex52_address, file.hex52_length); //hex52
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex53, file.hex53_length), 0, file.save, file.hex53_address, file.hex53_length); //hex53
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex54, file.hex54_length), 0, file.save, file.hex54_address, file.hex54_length); //hex54
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex55, file.hex55_length), 0, file.save, file.hex55_address, file.hex55_length); //hex55
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex56, file.hex56_length), 0, file.save, file.hex56_address, file.hex56_length); //hex56
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex57, file.hex57_length), 0, file.save, file.hex57_address, file.hex57_length); //hex57
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex58, file.hex58_length), 0, file.save, file.hex58_address, file.hex58_length); //hex58
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex59, file.hex59_length), 0, file.save, file.hex59_address, file.hex59_length); //hex59
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex60, file.hex60_length), 0, file.save, file.hex60_address, file.hex60_length); //hex60
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex61, file.hex61_length), 0, file.save, file.hex61_address, file.hex61_length); //hex61
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex62, file.hex62_length), 0, file.save, file.hex62_address, file.hex62_length); //hex62
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex63, file.hex63_length), 0, file.save, file.hex63_address, file.hex63_length); //hex63
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex64, file.hex64_length), 0, file.save, file.hex64_address, file.hex64_length); //hex64
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex65, file.hex65_length), 0, file.save, file.hex65_address, file.hex65_length); //hex65
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex66, file.hex66_length), 0, file.save, file.hex66_address, file.hex66_length); //hex66
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex67, file.hex67_length), 0, file.save, file.hex67_address, file.hex67_length); //hex67
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex68, file.hex68_length), 0, file.save, file.hex68_address, file.hex68_length); //hex68
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex69, file.hex69_length), 0, file.save, file.hex69_address, file.hex69_length); //hex69
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex70, file.hex70_length), 0, file.save, file.hex70_address, file.hex70_length); //hex70
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex71, file.hex71_length), 0, file.save, file.hex71_address, file.hex71_length); //hex71
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex72, file.hex72_length), 0, file.save, file.hex72_address, file.hex72_length); //hex72
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex73, file.hex73_length), 0, file.save, file.hex73_address, file.hex73_length); //hex73
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex74, file.hex74_length), 0, file.save, file.hex74_address, file.hex74_length); //hex74
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex75, file.hex75_length), 0, file.save, file.hex75_address, file.hex75_length); //hex75
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex76, file.hex76_length), 0, file.save, file.hex76_address, file.hex76_length); //hex76
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex77, file.hex77_length), 0, file.save, file.hex77_address, file.hex77_length); //hex77
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex78, file.hex78_length), 0, file.save, file.hex78_address, file.hex78_length); //hex78
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex79, file.hex79_length), 0, file.save, file.hex79_address, file.hex79_length); //hex79
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex80, file.hex80_length), 0, file.save, file.hex80_address, file.hex80_length); //hex80
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex81, file.hex81_length), 0, file.save, file.hex81_address, file.hex81_length); //hex81
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex82, file.hex82_length), 0, file.save, file.hex82_address, file.hex82_length); //hex82
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex83, file.hex83_length), 0, file.save, file.hex83_address, file.hex83_length); //hex83
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex84, file.hex84_length), 0, file.save, file.hex84_address, file.hex84_length); //hex84
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex85, file.hex85_length), 0, file.save, file.hex85_address, file.hex85_length); //hex85
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex86, file.hex86_length), 0, file.save, file.hex86_address, file.hex86_length); //hex86
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex87, file.hex87_length), 0, file.save, file.hex87_address, file.hex87_length); //hex87
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex88, file.hex88_length), 0, file.save, file.hex88_address, file.hex88_length); //hex88
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex89, file.hex89_length), 0, file.save, file.hex89_address, file.hex89_length); //hex89
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex90, file.hex90_length), 0, file.save, file.hex90_address, file.hex90_length); //hex90
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex91, file.hex91_length), 0, file.save, file.hex91_address, file.hex91_length); //hex91
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex92, file.hex92_length), 0, file.save, file.hex92_address, file.hex92_length); //hex92
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex93, file.hex93_length), 0, file.save, file.hex93_address, file.hex93_length); //hex93
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex94, file.hex94_length), 0, file.save, file.hex94_address, file.hex94_length); //hex94
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex95, file.hex95_length), 0, file.save, file.hex95_address, file.hex95_length); //hex95
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex96, file.hex96_length), 0, file.save, file.hex96_address, file.hex96_length); //hex96
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex97, file.hex97_length), 0, file.save, file.hex97_address, file.hex97_length); //hex97
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex98, file.hex98_length), 0, file.save, file.hex98_address, file.hex98_length); //hex98
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex99, file.hex99_length), 0, file.save, file.hex99_address, file.hex99_length); //hex99
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex100, file.hex100_length), 0, file.save, file.hex100_address, file.hex100_length); //hex100
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex101, file.hex101_length), 0, file.save, file.hex101_address, file.hex101_length); //hex101
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex102, file.hex102_length), 0, file.save, file.hex102_address, file.hex102_length); //hex102
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex103, file.hex103_length), 0, file.save, file.hex103_address, file.hex103_length); //hex103
                    Array.Copy(Open_File.OpenFile.hex2byte2save(file.hex104, file.hex104_length), 0, file.save, file.hex104_address, file.hex104_length); //hex104

                    myStream.Write(file.save, 0, file.save.Length);
                    myStream.Close();

                }
            }
        }


        private void Hex1_TextChanged(object sender, EventArgs e) //hex1
        {
            if (Hex1.ContainsFocus == true)
            {
                Text1.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex1.Text));

                file.L1Length = Text1.Text.Length;
                Length1.Text = file.L1Length.ToString();
                file.L1Last = file.hex1_length - file.L1Length;
                Last1.Text = file.L1Last.ToString();
                file.hex1 = Hex1.Text;
            }
        }
        private void Text1_TextChanged(object sender, EventArgs e) //encode1
        {
            if (Text1.ContainsFocus == true)
            {
                Hex1.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text1.Text));

                file.L1Length = Text1.Text.Length;
                Length1.Text = file.L1Length.ToString();
                file.L1Last = file.hex1_length - file.L1Length;
                Last1.Text = file.L1Last.ToString();
                file.hex1 = Hex1.Text;
            }
        }

        private void Hex2_TextChanged(object sender, EventArgs e) //hex2
        {
            if(Hex2.ContainsFocus == true)
            {
                Text2.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex2.Text));

                file.L2Length = Text2.Text.Length;
                Length2.Text = file.L2Length.ToString();
                file.L2Last = file.hex2_length - file.L2Length;
                Last2.Text = file.L2Last.ToString();
                file.hex2 = Hex2.Text;
            }
        }
        private void Text2_TextChanged(object sender, EventArgs e) //encode2
        {
            if (Text2.ContainsFocus == true)
            {
                Hex2.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text2.Text));

                file.L2Length = Text2.Text.Length;
                Length2.Text = file.L2Length.ToString();
                file.L2Last = file.hex2_length - file.L2Length;
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
                file.L3Last = file.hex3_length - file.L3Length;
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
                file.L3Last = file.hex3_length - file.L3Length;
                Last3.Text = file.L3Last.ToString();
                file.hex3 = Hex3.Text;
            }
        }

        private void Hex4_TextChanged(object sender, EventArgs e) //hex4
        {
            if (Hex4.ContainsFocus == true)
            {
                Text4.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex4.Text));

                file.L4Length = Text4.Text.Length;
                Length4.Text = file.L4Length.ToString();
                file.L4Last = file.hex4_length - file.L4Length;
                Last4.Text = file.L4Last.ToString();
                file.hex4 = Hex4.Text;
            }
        }
        private void Text4_TextChanged(object sender, EventArgs e) //encode4
        {
            if (Text4.ContainsFocus == true)
            {
                Hex4.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text4.Text));

                file.L4Length = Text4.Text.Length;
                Length4.Text = file.L4Length.ToString();
                file.L4Last = file.hex4_length - file.L4Length;
                Last4.Text = file.L4Last.ToString();
                file.hex4 = Hex4.Text;
            }
        }

        private void Hex5_TextChanged_1(object sender, EventArgs e) //hex5
        {
            if (Hex5.ContainsFocus == true)
            {
                Text5.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex5.Text));

                file.L5Length = Text5.Text.Length;
                Length5.Text = file.L5Length.ToString();
                file.L5Last = file.hex5_length - file.L5Length;
                Last5.Text = file.L5Last.ToString();
                file.hex5 = Hex5.Text;
            }
        }
        private void Text5_TextChanged_1(object sender, EventArgs e) //encode5
        {
            if (Text5.ContainsFocus == true)
            {
                Hex5.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text5.Text));

                file.L5Length = Text5.Text.Length;
                Length5.Text = file.L5Length.ToString();
                file.L5Last = file.hex5_length - file.L5Length;
                Last5.Text = file.L5Last.ToString();
                file.hex5 = Hex5.Text;
            }
        }

        private void Hex6_TextChanged_1(object sender, EventArgs e) //hex6
        {
            if (Hex6.ContainsFocus == true)
            {
                Text6.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex6.Text));

                file.L6Length = Text6.Text.Length;
                Length6.Text = file.L6Length.ToString();
                file.L6Last = file.hex6_length - file.L6Length;
                Last6.Text = file.L6Last.ToString();
                file.hex6 = Hex6.Text;
            }
        }
        private void Text6_TextChanged_1(object sender, EventArgs e) //encode6
        {
            if (Text6.ContainsFocus == true)
            {
                Hex6.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text6.Text));

                file.L6Length = Text6.Text.Length;
                Length6.Text = file.L6Length.ToString();
                file.L6Last = file.hex6_length - file.L6Length;
                Last6.Text = file.L6Last.ToString();
                file.hex6 = Hex6.Text;
            }
        }

        private void Hex7_TextChanged(object sender, EventArgs e) //hex7
        {
            if (Hex7.ContainsFocus == true)
            {
                Text7.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex7.Text));

                file.L7Length = Text7.Text.Length;
                Length7.Text = file.L7Length.ToString();
                file.L7Last = file.hex7_length - file.L7Length;
                Last7.Text = file.L7Last.ToString();
                file.hex7 = Hex7.Text;
            }
        }
        private void Text7_TextChanged(object sender, EventArgs e) //encode7
        {
            if (Text7.ContainsFocus == true)
            {
                Hex7.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text7.Text));

                file.L7Length = Text7.Text.Length;
                Length7.Text = file.L7Length.ToString();
                file.L7Last = file.hex7_length - file.L7Length;
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
                file.L8Last = file.hex8_length - file.L8Length;
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
                file.L8Last = file.hex8_length - file.L8Length;
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
                file.L9Last = file.hex9_length - file.L9Length;
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
                file.L9Last = file.hex9_length - file.L9Length;
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
                file.L10Last = file.hex10_length - file.L10Length;
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
                file.L10Last = file.hex10_length - file.L10Length;
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
                file.L11Last = file.hex11_length - file.L11Length;
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
                file.L11Last = file.hex11_length - file.L11Length;
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
                file.L12Last = file.hex12_length - file.L12Length;
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
                file.L12Last = file.hex12_length - file.L12Length;
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
                file.L13Last = file.hex13_length - file.L13Length;
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
                file.L13Last = file.hex13_length - file.L13Length;
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
                file.L14Last = file.hex14_length - file.L14Length;
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
                file.L14Last = file.hex14_length - file.L14Length;
                Last14.Text = file.L14Last.ToString();
                file.hex14 = Hex14.Text;
            }
        }

        private void Hex15_TextChanged(object sender, EventArgs e) //hex15
        {
            if (Hex15.ContainsFocus == true)
            {
                Text15.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex15.Text));

                file.L15Length = Text15.Text.Length;
                Length15.Text = file.L15Length.ToString();
                file.L15Last = file.hex15_length - file.L15Length;
                Last15.Text = file.L15Last.ToString();
                file.hex15 = Hex15.Text;
            }
        }
        private void Text15_TextChanged(object sender, EventArgs e) //encode15
        {
            if (Text15.ContainsFocus == true)
            {
                Hex15.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text15.Text));

                file.L15Length = Text15.Text.Length;
                Length15.Text = file.L15Length.ToString();
                file.L15Last = file.hex15_length - file.L15Length;
                Last15.Text = file.L15Last.ToString();
                file.hex15 = Hex15.Text;
            }
        }

        private void Hex16_TextChanged(object sender, EventArgs e) //hex16
        {
            if (Hex16.ContainsFocus == true)
            {
                Text16.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex16.Text));

                file.L16Length = Text16.Text.Length;
                Length16.Text = file.L16Length.ToString();
                file.L16Last = file.hex16_length - file.L16Length;
                Last16.Text = file.L16Last.ToString();
                file.hex16 = Hex16.Text;
            }
        }
        private void Text16_TextChanged(object sender, EventArgs e) //encode16
        {
            if (Text16.ContainsFocus == true)
            {
                Hex16.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text16.Text));

                file.L16Length = Text16.Text.Length;
                Length16.Text = file.L16Length.ToString();
                file.L16Last = file.hex16_length - file.L16Length;
                Last16.Text = file.L16Last.ToString();
                file.hex16 = Hex16.Text;
            }
        }

        private void Hex17_TextChanged(object sender, EventArgs e) //hex17
        {
            if (Hex17.ContainsFocus == true)
            {
                Text17.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex17.Text));

                file.L17Length = Text17.Text.Length;
                Length17.Text = file.L17Length.ToString();
                file.L17Last = file.hex17_length - file.L17Length;
                Last17.Text = file.L17Last.ToString();
                file.hex17 = Hex17.Text;
            }
        }
        private void Text17_TextChanged(object sender, EventArgs e) //encode17
        {
            if (Text17.ContainsFocus == true)
            {
                Hex17.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text17.Text));

                file.L17Length = Text17.Text.Length;
                Length17.Text = file.L17Length.ToString();
                file.L17Last = file.hex17_length - file.L17Length;
                Last17.Text = file.L17Last.ToString();
                file.hex17 = Hex17.Text;
            }
        }

        private void Hex18_TextChanged(object sender, EventArgs e) //hex18
        {
            if (Hex18.ContainsFocus == true)
            {
                Text18.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex18.Text));

                file.L18Length = Text18.Text.Length;
                Length18.Text = file.L18Length.ToString();
                file.L18Last = file.hex18_length - file.L18Length;
                Last18.Text = file.L18Last.ToString();
                file.hex18 = Hex18.Text;
            }
        }
        private void Text18_TextChanged(object sender, EventArgs e) //encode18
        {
            if (Text18.ContainsFocus == true)
            {
                Hex18.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text18.Text));

                file.L18Length = Text18.Text.Length;
                Length18.Text = file.L18Length.ToString();
                file.L18Last = file.hex18_length - file.L18Length;
                Last18.Text = file.L18Last.ToString();
                file.hex18 = Hex18.Text;
            }
        }

        private void Hex19_TextChanged(object sender, EventArgs e) //hex19
        {
            if (Hex19.ContainsFocus == true)
            {
                Text19.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex19.Text));

                file.L19Length = Text19.Text.Length;
                Length19.Text = file.L19Length.ToString();
                file.L19Last = file.hex19_length - file.L19Length;
                Last19.Text = file.L19Last.ToString();
                file.hex19 = Hex19.Text;
            }
        }
        private void Text19_TextChanged(object sender, EventArgs e) //encode19
        {
            if (Text19.ContainsFocus == true)
            {
                Hex19.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text19.Text));

                file.L19Length = Text19.Text.Length;
                Length19.Text = file.L19Length.ToString();
                file.L19Last = file.hex19_length - file.L19Length;
                Last19.Text = file.L19Last.ToString();
                file.hex19 = Hex19.Text;
            }
        }

        private void Hex20_TextChanged(object sender, EventArgs e) //hex20
        {
            if (Hex20.ContainsFocus == true)
            {
                Text20.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex20.Text));

                file.L20Length = Text20.Text.Length;
                Length20.Text = file.L20Length.ToString();
                file.L20Last = file.hex20_length - file.L20Length;
                Last20.Text = file.L20Last.ToString();
                file.hex20 = Hex20.Text;
            }
        }
        private void Text20_TextChanged(object sender, EventArgs e) //encode20
        {
            if (Text20.ContainsFocus == true)
            {
                Hex20.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text20.Text));

                file.L20Length = Text20.Text.Length;
                Length20.Text = file.L20Length.ToString();
                file.L20Last = file.hex20_length - file.L20Length;
                Last20.Text = file.L20Last.ToString();
                file.hex20 = Hex20.Text;
            }
        }

        private void Hex21_TextChanged(object sender, EventArgs e) //hex21
        {
            if (Hex21.ContainsFocus == true)
            {
                Text21.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex21.Text));

                file.L21Length = Text21.Text.Length;
                Length21.Text = file.L21Length.ToString();
                file.L21Last = file.hex21_length - file.L21Length;
                Last21.Text = file.L21Last.ToString();
                file.hex21 = Hex21.Text;
            }
        }
        private void Text21_TextChanged(object sender, EventArgs e) //encode21
        {
            if (Text21.ContainsFocus == true)
            {
                Hex21.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text21.Text));

                file.L21Length = Text21.Text.Length;
                Length21.Text = file.L21Length.ToString();
                file.L21Last = file.hex21_length - file.L21Length;
                Last21.Text = file.L21Last.ToString();
                file.hex21 = Hex21.Text;
            }
        }

        private void Hex22_TextChanged(object sender, EventArgs e) //hex22
        {
            if (Hex22.ContainsFocus == true)
            {
                Text22.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex22.Text));

                file.L22Length = Text22.Text.Length;
                Length22.Text = file.L22Length.ToString();
                file.L22Last = file.hex22_length - file.L22Length;
                Last22.Text = file.L22Last.ToString();
                file.hex22 = Hex22.Text;
            }
        }
        private void Text22_TextChanged(object sender, EventArgs e) //encode22
        {
            if (Text22.ContainsFocus == true)
            {
                Hex22.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text22.Text));

                file.L22Length = Text22.Text.Length;
                Length22.Text = file.L22Length.ToString();
                file.L22Last = file.hex22_length - file.L22Length;
                Last22.Text = file.L22Last.ToString();
                file.hex22 = Hex22.Text;
            }
        }

        private void Hex23_TextChanged(object sender, EventArgs e) //hex23
        {
            if (Hex23.ContainsFocus == true)
            {
                Text23.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex23.Text));

                file.L23Length = Text23.Text.Length;
                Length23.Text = file.L23Length.ToString();
                file.L23Last = file.hex23_length - file.L23Length;
                Last23.Text = file.L23Last.ToString();
                file.hex23 = Hex23.Text;
            }
        }
        private void Text23_TextChanged(object sender, EventArgs e) //encode23
        {
            if (Text23.ContainsFocus == true)
            {
                Hex23.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text23.Text));

                file.L23Length = Text23.Text.Length;
                Length23.Text = file.L23Length.ToString();
                file.L23Last = file.hex23_length - file.L23Length;
                Last23.Text = file.L23Last.ToString();
                file.hex23 = Hex23.Text;
            }
        }

        private void Hex24_TextChanged(object sender, EventArgs e) //hex24
        {
            if (Hex24.ContainsFocus == true)
            {
                Text24.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex24.Text));

                file.L24Length = Text24.Text.Length;
                Length24.Text = file.L24Length.ToString();
                file.L24Last = file.hex24_length - file.L24Length;
                Last24.Text = file.L24Last.ToString();
                file.hex24 = Hex24.Text;
            }
        }
        private void Text24_TextChanged(object sender, EventArgs e) //encode24
        {
            if (Text24.ContainsFocus == true)
            {
                Hex24.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text24.Text));

                file.L24Length = Text24.Text.Length;
                Length24.Text = file.L24Length.ToString();
                file.L24Last = file.hex24_length - file.L24Length;
                Last24.Text = file.L24Last.ToString();
                file.hex24 = Hex24.Text;
            }
        }

        private void Hex25_TextChanged(object sender, EventArgs e) //hex25
        {
            if (Hex25.ContainsFocus == true)
            {
                Text25.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex25.Text));

                file.L25Length = Text25.Text.Length;
                Length25.Text = file.L25Length.ToString();
                file.L25Last = file.hex25_length - file.L25Length;
                Last25.Text = file.L25Last.ToString();
                file.hex25 = Hex25.Text;
            }
        }
        private void Text25_TextChanged(object sender, EventArgs e) //encode25
        {
            if (Text25.ContainsFocus == true)
            {
                Hex25.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text25.Text));

                file.L25Length = Text25.Text.Length;
                Length25.Text = file.L25Length.ToString();
                file.L25Last = file.hex25_length - file.L25Length;
                Last25.Text = file.L25Last.ToString();
                file.hex25 = Hex25.Text;
            }
        }

        private void Hex26_TextChanged(object sender, EventArgs e) //hex26
        {
            if (Hex26.ContainsFocus == true)
            {
                Text26.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex26.Text));

                file.L26Length = Text26.Text.Length;
                Length26.Text = file.L26Length.ToString();
                file.L26Last = file.hex26_length - file.L26Length;
                Last26.Text = file.L26Last.ToString();
                file.hex26 = Hex26.Text;
            }
        }
        private void Text26_TextChanged(object sender, EventArgs e) //encode26
        {
            if (Text26.ContainsFocus == true)
            {
                Hex26.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text26.Text));

                file.L26Length = Text26.Text.Length;
                Length26.Text = file.L26Length.ToString();
                file.L26Last = file.hex26_length - file.L26Length;
                Last26.Text = file.L26Last.ToString();
                file.hex26 = Hex26.Text;
            }
        }

        private void Hex27_TextChanged(object sender, EventArgs e) //hex27
        {
            if (Hex27.ContainsFocus == true)
            {
                Text27.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex27.Text));

                file.L27Length = Text27.Text.Length;
                Length27.Text = file.L27Length.ToString();
                file.L27Last = file.hex27_length - file.L27Length;
                Last27.Text = file.L27Last.ToString();
                file.hex27 = Hex27.Text;
            }
        }
        private void Text27_TextChanged(object sender, EventArgs e) //encode27
        {
            if (Text27.ContainsFocus == true)
            {
                Hex27.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text27.Text));

                file.L27Length = Text27.Text.Length;
                Length27.Text = file.L27Length.ToString();
                file.L27Last = file.hex27_length - file.L27Length;
                Last27.Text = file.L27Last.ToString();
                file.hex27 = Hex27.Text;
            }
        }

        private void Hex28_TextChanged(object sender, EventArgs e) //hex28
        {
            if (Hex28.ContainsFocus == true)
            {
                Text28.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex28.Text));

                file.L28Length = Text28.Text.Length;
                Length28.Text = file.L28Length.ToString();
                file.L28Last = file.hex28_length - file.L28Length;
                Last28.Text = file.L28Last.ToString();
                file.hex28 = Hex28.Text;
            }
        }
        private void Text28_TextChanged(object sender, EventArgs e) //encode28
        {
            if (Text28.ContainsFocus == true)
            {
                Hex28.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text28.Text));

                file.L28Length = Text28.Text.Length;
                Length28.Text = file.L28Length.ToString();
                file.L28Last = file.hex28_length - file.L28Length;
                Last28.Text = file.L28Last.ToString();
                file.hex28 = Hex28.Text;
            }
        }

        private void Hex29_TextChanged(object sender, EventArgs e) //hex29
        {
            if (Hex29.ContainsFocus == true)
            {
                Text29.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex29.Text));

                file.L29Length = Text29.Text.Length;
                Length29.Text = file.L29Length.ToString();
                file.L29Last = file.hex29_length - file.L29Length;
                Last29.Text = file.L29Last.ToString();
                file.hex29 = Hex29.Text;
            }
        }
        private void Text29_TextChanged(object sender, EventArgs e) //encode29
        {
            if (Text29.ContainsFocus == true)
            {
                Hex29.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text29.Text));

                file.L29Length = Text29.Text.Length;
                Length29.Text = file.L29Length.ToString();
                file.L29Last = file.hex29_length - file.L29Length;
                Last29.Text = file.L29Last.ToString();
                file.hex29 = Hex29.Text;
            }
        }

        private void Hex30_TextChanged(object sender, EventArgs e) //hex30
        {
            if (Hex30.ContainsFocus == true)
            {
                Text30.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex30.Text));

                file.L30Length = Text30.Text.Length;
                Length30.Text = file.L30Length.ToString();
                file.L30Last = file.hex30_length - file.L30Length;
                Last30.Text = file.L30Last.ToString();
                file.hex30 = Hex30.Text;
            }
        }
        private void Text30_TextChanged(object sender, EventArgs e) //encode30
        {
            if (Text30.ContainsFocus == true)
            {
                Hex30.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text30.Text));

                file.L30Length = Text30.Text.Length;
                Length30.Text = file.L30Length.ToString();
                file.L30Last = file.hex30_length - file.L30Length;
                Last30.Text = file.L30Last.ToString();
                file.hex30 = Hex30.Text;
            }
        }

        private void Hex31_TextChanged(object sender, EventArgs e) //hex31
        {
            if (Hex31.ContainsFocus == true)
            {
                Text31.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex31.Text));

                file.L31Length = Text31.Text.Length;
                Length31.Text = file.L31Length.ToString();
                file.L31Last = file.hex31_length - file.L31Length;
                Last31.Text = file.L31Last.ToString();
                file.hex31 = Hex31.Text;
            }
        }
        private void Text31_TextChanged(object sender, EventArgs e) //encode31
        {
            if (Text31.ContainsFocus == true)
            {
                Hex31.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text31.Text));

                file.L31Length = Text31.Text.Length;
                Length31.Text = file.L31Length.ToString();
                file.L31Last = file.hex31_length - file.L31Length;
                Last31.Text = file.L31Last.ToString();
                file.hex31 = Hex31.Text;
            }
        }

        private void Hex32_TextChanged(object sender, EventArgs e) //hex32
        {
            if (Hex32.ContainsFocus == true)
            {
                Text32.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex32.Text));

                file.L32Length = Text32.Text.Length;
                Length32.Text = file.L32Length.ToString();
                file.L32Last = file.hex32_length - file.L32Length;
                Last32.Text = file.L32Last.ToString();
                file.hex32 = Hex32.Text;
            }
        }
        private void Text32_TextChanged(object sender, EventArgs e) //encode32
        {
            if (Text32.ContainsFocus == true)
            {
                Hex32.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text32.Text));

                file.L32Length = Text32.Text.Length;
                Length32.Text = file.L32Length.ToString();
                file.L32Last = file.hex32_length - file.L32Length;
                Last32.Text = file.L32Last.ToString();
                file.hex32 = Hex32.Text;
            }
        }

        private void Hex33_TextChanged(object sender, EventArgs e) //hex33
        {
            if (Hex33.ContainsFocus == true)
            {
                Text33.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex33.Text));

                file.L33Length = Text33.Text.Length;
                Length33.Text = file.L33Length.ToString();
                file.L33Last = file.hex33_length - file.L33Length;
                Last33.Text = file.L33Last.ToString();
                file.hex33 = Hex33.Text;
            }
        }
        private void Text33_TextChanged(object sender, EventArgs e) //encode33
        {
            if (Text33.ContainsFocus == true)
            {
                Hex33.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text33.Text));

                file.L33Length = Text33.Text.Length;
                Length33.Text = file.L33Length.ToString();
                file.L33Last = file.hex33_length - file.L33Length;
                Last33.Text = file.L33Last.ToString();
                file.hex33 = Hex33.Text;
            }
        }

        private void Hex34_TextChanged(object sender, EventArgs e) //hex34
        {
            if (Hex34.ContainsFocus == true)
            {
                Text34.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex34.Text));

                file.L34Length = Text34.Text.Length;
                Length34.Text = file.L34Length.ToString();
                file.L34Last = file.hex34_length - file.L34Length;
                Last34.Text = file.L34Last.ToString();
                file.hex34 = Hex34.Text;
            }
        }
        private void Text34_TextChanged(object sender, EventArgs e) //encode34
        {
            if (Text34.ContainsFocus == true)
            {
                Hex34.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text34.Text));

                file.L34Length = Text34.Text.Length;
                Length34.Text = file.L34Length.ToString();
                file.L34Last = file.hex34_length - file.L34Length;
                Last34.Text = file.L34Last.ToString();
                file.hex34 = Hex34.Text;
            }
        }

        private void Hex35_TextChanged(object sender, EventArgs e) //hex35
        {
            if (Hex35.ContainsFocus == true)
            {
                Text35.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex35.Text));

                file.L35Length = Text35.Text.Length;
                Length35.Text = file.L35Length.ToString();
                file.L35Last = file.hex35_length - file.L35Length;
                Last35.Text = file.L35Last.ToString();
                file.hex35 = Hex35.Text;
            }
        }
        private void Text35_TextChanged(object sender, EventArgs e) //encode35
        {
            if (Text35.ContainsFocus == true)
            {
                Hex35.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text35.Text));

                file.L35Length = Text35.Text.Length;
                Length35.Text = file.L35Length.ToString();
                file.L35Last = file.hex35_length - file.L35Length;
                Last35.Text = file.L35Last.ToString();
                file.hex35 = Hex35.Text;
            }
        }

        private void Hex36_TextChanged(object sender, EventArgs e) //hex36
        {
            if (Hex36.ContainsFocus == true)
            {
                Text36.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex36.Text));

                file.L36Length = Text36.Text.Length;
                Length36.Text = file.L36Length.ToString();
                file.L36Last = file.hex36_length - file.L36Length;
                Last36.Text = file.L36Last.ToString();
                file.hex36 = Hex36.Text;
            }
        }
        private void Text36_TextChanged(object sender, EventArgs e) //encode36
        {
            if (Text36.ContainsFocus == true)
            {
                Hex36.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text36.Text));

                file.L36Length = Text36.Text.Length;
                Length36.Text = file.L36Length.ToString();
                file.L36Last = file.hex36_length - file.L36Length;
                Last36.Text = file.L36Last.ToString();
                file.hex36 = Hex36.Text;
            }
        }

        private void Hex37_TextChanged(object sender, EventArgs e) //hex37
        {
            if (Hex37.ContainsFocus == true)
            {
                Text37.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex37.Text));

                file.L37Length = Text37.Text.Length;
                Length37.Text = file.L37Length.ToString();
                file.L37Last = file.hex37_length - file.L37Length;
                Last37.Text = file.L37Last.ToString();
                file.hex37 = Hex37.Text;
            }
        }
        private void Text37_TextChanged(object sender, EventArgs e) //encode37
        {
            if (Text37.ContainsFocus == true)
            {
                Hex37.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text37.Text));

                file.L37Length = Text37.Text.Length;
                Length37.Text = file.L37Length.ToString();
                file.L37Last = file.hex37_length - file.L37Length;
                Last37.Text = file.L37Last.ToString();
                file.hex37 = Hex37.Text;
            }
        }

        private void Hex38_TextChanged(object sender, EventArgs e) //hex38
        {
            if (Hex38.ContainsFocus == true)
            {
                Text38.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex38.Text));

                file.L38Length = Text38.Text.Length;
                Length38.Text = file.L38Length.ToString();
                file.L38Last = file.hex38_length - file.L38Length;
                Last38.Text = file.L38Last.ToString();
                file.hex38 = Hex38.Text;
            }
        }
        private void Text38_TextChanged(object sender, EventArgs e) //encode38
        {
            if (Text38.ContainsFocus == true)
            {
                Hex38.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text38.Text));

                file.L38Length = Text38.Text.Length;
                Length38.Text = file.L38Length.ToString();
                file.L38Last = file.hex38_length - file.L38Length;
                Last38.Text = file.L38Last.ToString();
                file.hex38 = Hex38.Text;
            }
        }

        private void Hex39_TextChanged(object sender, EventArgs e) //hex39
        {
            if (Hex39.ContainsFocus == true)
            {
                Text39.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex39.Text));

                file.L39Length = Text39.Text.Length;
                Length39.Text = file.L39Length.ToString();
                file.L39Last = file.hex39_length - file.L39Length;
                Last39.Text = file.L39Last.ToString();
                file.hex39 = Hex39.Text;
            }
        }
        private void Text39_TextChanged(object sender, EventArgs e) //encode39
        {
            if (Text39.ContainsFocus == true)
            {
                Hex39.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text39.Text));

                file.L39Length = Text39.Text.Length;
                Length39.Text = file.L39Length.ToString();
                file.L39Last = file.hex39_length - file.L39Length;
                Last39.Text = file.L39Last.ToString();
                file.hex39 = Hex39.Text;
            }
        }

        private void Hex40_TextChanged(object sender, EventArgs e) //hex40
        {
            if (Hex40.ContainsFocus == true)
            {
                Text40.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex40.Text));

                file.L40Length = Text40.Text.Length;
                Length40.Text = file.L40Length.ToString();
                file.L40Last = file.hex40_length - file.L40Length;
                Last40.Text = file.L40Last.ToString();
                file.hex40 = Hex40.Text;
            }
        }
        private void Text40_TextChanged(object sender, EventArgs e) //encode40
        {
            if (Text40.ContainsFocus == true)
            {
                Hex40.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text40.Text));

                file.L40Length = Text40.Text.Length;
                Length40.Text = file.L40Length.ToString();
                file.L40Last = file.hex40_length - file.L40Length;
                Last40.Text = file.L40Last.ToString();
                file.hex40 = Hex40.Text;
            }
        }

        private void Hex41_TextChanged(object sender, EventArgs e) //hex41
        {
            if (Hex41.ContainsFocus == true)
            {
                Text41.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex41.Text));

                file.L41Length = Text41.Text.Length;
                Length41.Text = file.L41Length.ToString();
                file.L41Last = file.hex41_length - file.L41Length;
                Last41.Text = file.L41Last.ToString();
                file.hex41 = Hex41.Text;
            }
        }
        private void Text41_TextChanged(object sender, EventArgs e) //encode41
        {
            if (Text41.ContainsFocus == true)
            {
                Hex41.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text41.Text));

                file.L41Length = Text41.Text.Length;
                Length41.Text = file.L41Length.ToString();
                file.L41Last = file.hex41_length - file.L41Length;
                Last41.Text = file.L41Last.ToString();
                file.hex41 = Hex41.Text;
            }
        }

        private void Hex42_TextChanged(object sender, EventArgs e) //hex42
        {
            if (Hex42.ContainsFocus == true)
            {
                Text42.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex42.Text));

                file.L42Length = Text42.Text.Length;
                Length42.Text = file.L42Length.ToString();
                file.L42Last = file.hex42_length - file.L42Length;
                Last42.Text = file.L42Last.ToString();
                file.hex42 = Hex42.Text;
            }
        }
        private void Text42_TextChanged(object sender, EventArgs e) //encode42
        {
            if (Text42.ContainsFocus == true)
            {
                Hex42.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text42.Text));

                file.L42Length = Text42.Text.Length;
                Length42.Text = file.L42Length.ToString();
                file.L42Last = file.hex42_length - file.L42Length;
                Last42.Text = file.L42Last.ToString();
                file.hex42 = Hex42.Text;
            }
        }

        private void Hex43_TextChanged(object sender, EventArgs e) //hex43
        {
            if (Hex43.ContainsFocus == true)
            {
                Text43.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex43.Text));

                file.L43Length = Text43.Text.Length;
                Length43.Text = file.L43Length.ToString();
                file.L43Last = file.hex43_length - file.L43Length;
                Last43.Text = file.L43Last.ToString();
                file.hex43 = Hex43.Text;
            }
        }
        private void Text43_TextChanged(object sender, EventArgs e) //encode43
        {
            if (Text43.ContainsFocus == true)
            {
                Hex43.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text43.Text));

                file.L43Length = Text43.Text.Length;
                Length43.Text = file.L43Length.ToString();
                file.L43Last = file.hex43_length - file.L43Length;
                Last43.Text = file.L43Last.ToString();
                file.hex43 = Hex43.Text;
            }
        }

        private void Hex44_TextChanged(object sender, EventArgs e) //hex44
        {
            if (Hex44.ContainsFocus == true)
            {
                Text44.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex44.Text));

                file.L44Length = Text44.Text.Length;
                Length44.Text = file.L44Length.ToString();
                file.L44Last = file.hex44_length - file.L44Length;
                Last44.Text = file.L44Last.ToString();
                file.hex44 = Hex44.Text;
            }
        }
        private void Text44_TextChanged(object sender, EventArgs e) //encode44
        {
            if (Text44.ContainsFocus == true)
            {
                Hex44.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text44.Text));

                file.L44Length = Text44.Text.Length;
                Length44.Text = file.L44Length.ToString();
                file.L44Last = file.hex44_length - file.L44Length;
                Last44.Text = file.L44Last.ToString();
                file.hex44 = Hex44.Text;
            }
        }

        private void Hex45_TextChanged(object sender, EventArgs e) //hex45
        {
            if (Hex45.ContainsFocus == true)
            {
                Text45.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex45.Text));

                file.L45Length = Text45.Text.Length;
                Length45.Text = file.L45Length.ToString();
                file.L45Last = file.hex45_length - file.L45Length;
                Last45.Text = file.L45Last.ToString();
                file.hex45 = Hex45.Text;
            }
        }
        private void Text45_TextChanged(object sender, EventArgs e) //encode45
        {
            if (Text45.ContainsFocus == true)
            {
                Hex45.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text45.Text));

                file.L45Length = Text45.Text.Length;
                Length45.Text = file.L45Length.ToString();
                file.L45Last = file.hex45_length - file.L45Length;
                Last45.Text = file.L45Last.ToString();
                file.hex45 = Hex45.Text;
            }
        }

        private void Hex46_TextChanged(object sender, EventArgs e) //hex46
        {
            if (Hex46.ContainsFocus == true)
            {
                Text46.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex46.Text));

                file.L46Length = Text46.Text.Length;
                Length46.Text = file.L46Length.ToString();
                file.L46Last = file.hex46_length - file.L46Length;
                Last46.Text = file.L46Last.ToString();
                file.hex46 = Hex46.Text;
            }
        }
        private void Text46_TextChanged(object sender, EventArgs e) //encode46
        {
            if (Text46.ContainsFocus == true)
            {
                Hex46.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text46.Text));

                file.L46Length = Text46.Text.Length;
                Length46.Text = file.L46Length.ToString();
                file.L46Last = file.hex46_length - file.L46Length;
                Last46.Text = file.L46Last.ToString();
                file.hex46 = Hex46.Text;
            }
        }

        private void Hex47_TextChanged(object sender, EventArgs e) //hex47
        {
            if (Hex47.ContainsFocus == true)
            {
                Text47.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex47.Text));

                file.L47Length = Text47.Text.Length;
                Length47.Text = file.L47Length.ToString();
                file.L47Last = file.hex47_length - file.L47Length;
                Last47.Text = file.L47Last.ToString();
                file.hex47 = Hex47.Text;
            }
        }
        private void Text47_TextChanged(object sender, EventArgs e) //encode47
        {
            if (Text47.ContainsFocus == true)
            {
                Hex47.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text47.Text));

                file.L47Length = Text47.Text.Length;
                Length47.Text = file.L47Length.ToString();
                file.L47Last = file.hex47_length - file.L47Length;
                Last47.Text = file.L47Last.ToString();
                file.hex47 = Hex47.Text;
            }
        }

        private void Hex48_TextChanged(object sender, EventArgs e) //hex48
        {
            if (Hex48.ContainsFocus == true)
            {
                Text48.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex48.Text));

                file.L48Length = Text48.Text.Length;
                Length48.Text = file.L48Length.ToString();
                file.L48Last = file.hex48_length - file.L48Length;
                Last48.Text = file.L48Last.ToString();
                file.hex48 = Hex48.Text;
            }
        }
        private void Text48_TextChanged(object sender, EventArgs e) //encode48
        {
            if (Text48.ContainsFocus == true)
            {
                Hex48.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text48.Text));

                file.L48Length = Text48.Text.Length;
                Length48.Text = file.L48Length.ToString();
                file.L48Last = file.hex48_length - file.L48Length;
                Last48.Text = file.L48Last.ToString();
                file.hex48 = Hex48.Text;
            }
        }

        private void Hex49_TextChanged(object sender, EventArgs e) //hex49
        {
            if (Hex49.ContainsFocus == true)
            {
                Text49.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex49.Text));

                file.L49Length = Text49.Text.Length;
                Length49.Text = file.L49Length.ToString();
                file.L49Last = file.hex49_length - file.L49Length;
                Last49.Text = file.L49Last.ToString();
                file.hex49 = Hex49.Text;
            }
        }
        private void Text49_TextChanged(object sender, EventArgs e) //encode49
        {
            if (Text49.ContainsFocus == true)
            {
                Hex49.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text49.Text));

                file.L49Length = Text49.Text.Length;
                Length49.Text = file.L49Length.ToString();
                file.L49Last = file.hex49_length - file.L49Length;
                Last49.Text = file.L49Last.ToString();
                file.hex49 = Hex49.Text;
            }
        }

        private void Hex50_TextChanged(object sender, EventArgs e) //hex50
        {
            if (Hex50.ContainsFocus == true)
            {
                Text50.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex50.Text));

                file.L50Length = Text50.Text.Length;
                Length50.Text = file.L50Length.ToString();
                file.L50Last = file.hex50_length - file.L50Length;
                Last50.Text = file.L50Last.ToString();
                file.hex50 = Hex50.Text;
            }
        }
        private void Text50_TextChanged(object sender, EventArgs e) //encode50
        {
            if (Text50.ContainsFocus == true)
            {
                Hex50.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text50.Text));

                file.L50Length = Text50.Text.Length;
                Length50.Text = file.L50Length.ToString();
                file.L50Last = file.hex50_length - file.L50Length;
                Last50.Text = file.L50Last.ToString();
                file.hex50 = Hex50.Text;
            }
        }

        private void Hex51_TextChanged(object sender, EventArgs e) //hex51
        {
            if (Hex51.ContainsFocus == true)
            {
                Text51.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex51.Text));

                file.L51Length = Text51.Text.Length;
                Length51.Text = file.L51Length.ToString();
                file.L51Last = file.hex51_length - file.L51Length;
                Last51.Text = file.L51Last.ToString();
                file.hex51 = Hex51.Text;
            }
        }
        private void Text51_TextChanged(object sender, EventArgs e) //encode51
        {
            if (Text51.ContainsFocus == true)
            {
                Hex51.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text51.Text));

                file.L51Length = Text51.Text.Length;
                Length51.Text = file.L51Length.ToString();
                file.L51Last = file.hex51_length - file.L51Length;
                Last51.Text = file.L51Last.ToString();
                file.hex51 = Hex51.Text;
            }
        }

        private void Hex52_TextChanged(object sender, EventArgs e) //hex52
        {
            if (Hex52.ContainsFocus == true)
            {
                Text52.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex52.Text));

                file.L52Length = Text52.Text.Length;
                Length52.Text = file.L52Length.ToString();
                file.L52Last = file.hex52_length - file.L52Length;
                Last52.Text = file.L52Last.ToString();
                file.hex52 = Hex52.Text;
            }
        }
        private void Text52_TextChanged(object sender, EventArgs e) //encode52
        {
            if (Text52.ContainsFocus == true)
            {
                Hex52.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text52.Text));

                file.L52Length = Text52.Text.Length;
                Length52.Text = file.L52Length.ToString();
                file.L52Last = file.hex52_length - file.L52Length;
                Last52.Text = file.L52Last.ToString();
                file.hex52 = Hex52.Text;
            }
        }

        private void Hex53_TextChanged(object sender, EventArgs e) //hex53
        {
            if (Hex53.ContainsFocus == true)
            {
                Text53.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex53.Text));

                file.L53Length = Text53.Text.Length;
                Length53.Text = file.L53Length.ToString();
                file.L53Last = file.hex53_length - file.L53Length;
                Last53.Text = file.L53Last.ToString();
                file.hex53 = Hex53.Text;
            }
        }
        private void Text53_TextChanged(object sender, EventArgs e) //encode53
        {
            if (Text53.ContainsFocus == true)
            {
                Hex53.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text53.Text));

                file.L53Length = Text53.Text.Length;
                Length53.Text = file.L53Length.ToString();
                file.L53Last = file.hex53_length - file.L53Length;
                Last53.Text = file.L53Last.ToString();
                file.hex53 = Hex53.Text;
            }
        }

        private void Hex54_TextChanged(object sender, EventArgs e) //hex54
        {
            if (Hex54.ContainsFocus == true)
            {
                Text54.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex54.Text));

                file.L54Length = Text54.Text.Length;
                Length54.Text = file.L54Length.ToString();
                file.L54Last = file.hex54_length - file.L54Length;
                Last54.Text = file.L54Last.ToString();
                file.hex54 = Hex54.Text;
            }
        }
        private void Text54_TextChanged(object sender, EventArgs e) //encode54
        {
            if (Text54.ContainsFocus == true)
            {
                Hex54.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text54.Text));

                file.L54Length = Text54.Text.Length;
                Length54.Text = file.L54Length.ToString();
                file.L54Last = file.hex54_length - file.L54Length;
                Last54.Text = file.L54Last.ToString();
                file.hex54 = Hex54.Text;
            }
        }

        private void Hex55_TextChanged(object sender, EventArgs e) //hex55
        {
            if (Hex55.ContainsFocus == true)
            {
                Text55.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex55.Text));

                file.L55Length = Text55.Text.Length;
                Length55.Text = file.L55Length.ToString();
                file.L55Last = file.hex55_length - file.L55Length;
                Last55.Text = file.L55Last.ToString();
                file.hex55 = Hex55.Text;
            }
        }
        private void Text55_TextChanged(object sender, EventArgs e) //encode55
        {
            if (Text55.ContainsFocus == true)
            {
                Hex55.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text55.Text));

                file.L55Length = Text55.Text.Length;
                Length55.Text = file.L55Length.ToString();
                file.L55Last = file.hex55_length - file.L55Length;
                Last55.Text = file.L55Last.ToString();
                file.hex55 = Hex55.Text;
            }
        }

        private void Hex56_TextChanged(object sender, EventArgs e) //hex56
        {
            if (Hex56.ContainsFocus == true)
            {
                Text56.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex56.Text));

                file.L56Length = Text56.Text.Length;
                Length56.Text = file.L56Length.ToString();
                file.L56Last = file.hex56_length - file.L56Length;
                Last56.Text = file.L56Last.ToString();
                file.hex56 = Hex56.Text;
            }
        }
        private void Text56_TextChanged(object sender, EventArgs e) //encode56
        {
            if (Text56.ContainsFocus == true)
            {
                Hex56.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text56.Text));

                file.L56Length = Text56.Text.Length;
                Length56.Text = file.L56Length.ToString();
                file.L56Last = file.hex56_length - file.L56Length;
                Last56.Text = file.L56Last.ToString();
                file.hex56 = Hex56.Text;
            }
        }

        private void Hex57_TextChanged(object sender, EventArgs e) //hex57
        {
            if (Hex57.ContainsFocus == true)
            {
                Text57.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex57.Text));

                file.L57Length = Text57.Text.Length;
                Length57.Text = file.L57Length.ToString();
                file.L57Last = file.hex57_length - file.L57Length;
                Last57.Text = file.L57Last.ToString();
                file.hex57 = Hex57.Text;
            }
        }
        private void Text57_TextChanged(object sender, EventArgs e) //encode57
        {
            if (Text57.ContainsFocus == true)
            {
                Hex57.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text57.Text));

                file.L57Length = Text57.Text.Length;
                Length57.Text = file.L57Length.ToString();
                file.L57Last = file.hex57_length - file.L57Length;
                Last57.Text = file.L57Last.ToString();
                file.hex57 = Hex57.Text;
            }
        }

        private void Hex58_TextChanged(object sender, EventArgs e) //hex58
        {
            if (Hex58.ContainsFocus == true)
            {
                Text58.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex58.Text));

                file.L58Length = Text58.Text.Length;
                Length58.Text = file.L58Length.ToString();
                file.L58Last = file.hex58_length - file.L58Length;
                Last58.Text = file.L58Last.ToString();
                file.hex58 = Hex58.Text;
            }
        }
        private void Text58_TextChanged(object sender, EventArgs e) //encode58
        {
            if (Text58.ContainsFocus == true)
            {
                Hex58.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text58.Text));

                file.L58Length = Text58.Text.Length;
                Length58.Text = file.L58Length.ToString();
                file.L58Last = file.hex58_length - file.L58Length;
                Last58.Text = file.L58Last.ToString();
                file.hex58 = Hex58.Text;
            }
        }

        private void Hex59_TextChanged(object sender, EventArgs e) //hex59
        {
            if (Hex59.ContainsFocus == true)
            {
                Text59.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex59.Text));

                file.L59Length = Text59.Text.Length;
                Length59.Text = file.L59Length.ToString();
                file.L59Last = file.hex59_length - file.L59Length;
                Last59.Text = file.L59Last.ToString();
                file.hex59 = Hex59.Text;
            }
        }
        private void Text59_TextChanged(object sender, EventArgs e) //encode59
        {
            if (Text59.ContainsFocus == true)
            {
                Hex59.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text59.Text));

                file.L59Length = Text59.Text.Length;
                Length59.Text = file.L59Length.ToString();
                file.L59Last = file.hex59_length - file.L59Length;
                Last59.Text = file.L59Last.ToString();
                file.hex59 = Hex59.Text;
            }
        }

        private void Hex60_TextChanged(object sender, EventArgs e) //hex60
        {
            if (Hex60.ContainsFocus == true)
            {
                Text60.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex60.Text));

                file.L60Length = Text60.Text.Length;
                Length60.Text = file.L60Length.ToString();
                file.L60Last = file.hex60_length - file.L60Length;
                Last60.Text = file.L60Last.ToString();
                file.hex60 = Hex60.Text;
            }
        }
        private void Text60_TextChanged(object sender, EventArgs e) //encode60
        {
            if (Text60.ContainsFocus == true)
            {
                Hex60.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text60.Text));

                file.L60Length = Text60.Text.Length;
                Length60.Text = file.L60Length.ToString();
                file.L60Last = file.hex60_length - file.L60Length;
                Last60.Text = file.L60Last.ToString();
                file.hex60 = Hex60.Text;
            }
        }

        private void Hex61_TextChanged(object sender, EventArgs e) //hex61
        {
            if (Hex61.ContainsFocus == true)
            {
                Text61.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex61.Text));

                file.L61Length = Text61.Text.Length;
                Length61.Text = file.L61Length.ToString();
                file.L61Last = file.hex61_length - file.L61Length;
                Last61.Text = file.L61Last.ToString();
                file.hex61 = Hex61.Text;
            }
        }
        private void Text61_TextChanged(object sender, EventArgs e) //encode61
        {
            if (Text61.ContainsFocus == true)
            {
                Hex61.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text61.Text));

                file.L61Length = Text61.Text.Length;
                Length61.Text = file.L61Length.ToString();
                file.L61Last = file.hex61_length - file.L61Length;
                Last61.Text = file.L61Last.ToString();
                file.hex61 = Hex61.Text;
            }
        }

        private void Hex62_TextChanged(object sender, EventArgs e) //hex62
        {
            if (Hex62.ContainsFocus == true)
            {
                Text62.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex62.Text));

                file.L62Length = Text62.Text.Length;
                Length62.Text = file.L62Length.ToString();
                file.L62Last = file.hex62_length - file.L62Length;
                Last62.Text = file.L62Last.ToString();
                file.hex62 = Hex62.Text;
            }
        }
        private void Text62_TextChanged(object sender, EventArgs e) //encode62
        {
            if (Text62.ContainsFocus == true)
            {
                Hex62.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text62.Text));

                file.L62Length = Text62.Text.Length;
                Length62.Text = file.L62Length.ToString();
                file.L62Last = file.hex62_length - file.L62Length;
                Last62.Text = file.L62Last.ToString();
                file.hex62 = Hex62.Text;
            }
        }

        private void Hex63_TextChanged(object sender, EventArgs e) //hex63
        {
            if (Hex63.ContainsFocus == true)
            {
                Text63.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex63.Text));

                file.L63Length = Text63.Text.Length;
                Length63.Text = file.L63Length.ToString();
                file.L63Last = file.hex63_length - file.L63Length;
                Last63.Text = file.L63Last.ToString();
                file.hex63 = Hex63.Text;
            }
        }
        private void Text63_TextChanged(object sender, EventArgs e) //encode63
        {
            if (Text63.ContainsFocus == true)
            {
                Hex63.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text63.Text));

                file.L63Length = Text63.Text.Length;
                Length63.Text = file.L63Length.ToString();
                file.L63Last = file.hex63_length - file.L63Length;
                Last63.Text = file.L63Last.ToString();
                file.hex63 = Hex63.Text;
            }
        }

        private void Hex64_TextChanged(object sender, EventArgs e) //hex64
        {
            if (Hex64.ContainsFocus == true)
            {
                Text64.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex64.Text));

                file.L64Length = Text64.Text.Length;
                Length64.Text = file.L64Length.ToString();
                file.L64Last = file.hex64_length - file.L64Length;
                Last64.Text = file.L64Last.ToString();
                file.hex64 = Hex64.Text;
            }
        }
        private void Text64_TextChanged(object sender, EventArgs e) //encode64
        {
            if (Text64.ContainsFocus == true)
            {
                Hex64.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text64.Text));

                file.L64Length = Text64.Text.Length;
                Length64.Text = file.L64Length.ToString();
                file.L64Last = file.hex64_length - file.L64Length;
                Last64.Text = file.L64Last.ToString();
                file.hex64 = Hex64.Text;
            }
        }

        private void Hex65_TextChanged(object sender, EventArgs e) //hex65
        {
            if (Hex65.ContainsFocus == true)
            {
                Text65.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex65.Text));

                file.L65Length = Text65.Text.Length;
                Length65.Text = file.L65Length.ToString();
                file.L65Last = file.hex65_length - file.L65Length;
                Last65.Text = file.L65Last.ToString();
                file.hex65 = Hex65.Text;
            }
        }
        private void Text65_TextChanged(object sender, EventArgs e) //encode65
        {
            if (Text65.ContainsFocus == true)
            {
                Hex65.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text65.Text));

                file.L65Length = Text65.Text.Length;
                Length65.Text = file.L65Length.ToString();
                file.L65Last = file.hex65_length - file.L65Length;
                Last65.Text = file.L65Last.ToString();
                file.hex65 = Hex65.Text;
            }
        }

        private void Hex66_TextChanged(object sender, EventArgs e) //hex66
        {
            if (Hex66.ContainsFocus == true)
            {
                Text66.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex66.Text));

                file.L66Length = Text66.Text.Length;
                Length66.Text = file.L66Length.ToString();
                file.L66Last = file.hex66_length - file.L66Length;
                Last66.Text = file.L66Last.ToString();
                file.hex66 = Hex66.Text;
            }
        }
        private void Text66_TextChanged(object sender, EventArgs e) //encode66
        {
            if (Text66.ContainsFocus == true)
            {
                Hex66.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text66.Text));

                file.L66Length = Text66.Text.Length;
                Length66.Text = file.L66Length.ToString();
                file.L66Last = file.hex66_length - file.L66Length;
                Last66.Text = file.L66Last.ToString();
                file.hex66 = Hex66.Text;
            }
        }

        private void Hex67_TextChanged(object sender, EventArgs e) //hex67
        {
            if (Hex67.ContainsFocus == true)
            {
                Text67.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex67.Text));

                file.L67Length = Text67.Text.Length;
                Length67.Text = file.L67Length.ToString();
                file.L67Last = file.hex67_length - file.L67Length;
                Last67.Text = file.L67Last.ToString();
                file.hex67 = Hex67.Text;
            }
        }
        private void Text67_TextChanged(object sender, EventArgs e) //encode67
        {
            if (Text67.ContainsFocus == true)
            {
                Hex67.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text67.Text));

                file.L67Length = Text67.Text.Length;
                Length67.Text = file.L67Length.ToString();
                file.L67Last = file.hex67_length - file.L67Length;
                Last67.Text = file.L67Last.ToString();
                file.hex67 = Hex67.Text;
            }
        }

        private void Hex68_TextChanged(object sender, EventArgs e) //hex68
        {
            if (Hex68.ContainsFocus == true)
            {
                Text68.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex68.Text));

                file.L68Length = Text68.Text.Length;
                Length68.Text = file.L68Length.ToString();
                file.L68Last = file.hex68_length - file.L68Length;
                Last68.Text = file.L68Last.ToString();
                file.hex68 = Hex68.Text;
            }
        }
        private void Text68_TextChanged(object sender, EventArgs e) //encode68
        {
            if (Text68.ContainsFocus == true)
            {
                Hex68.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text68.Text));

                file.L68Length = Text68.Text.Length;
                Length68.Text = file.L68Length.ToString();
                file.L68Last = file.hex68_length - file.L68Length;
                Last68.Text = file.L68Last.ToString();
                file.hex68 = Hex68.Text;
            }
        }

        private void Hex69_TextChanged(object sender, EventArgs e) //hex69
        {
            if (Hex69.ContainsFocus == true)
            {
                Text69.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex69.Text));

                file.L69Length = Text69.Text.Length;
                Length69.Text = file.L69Length.ToString();
                file.L69Last = file.hex69_length - file.L69Length;
                Last69.Text = file.L69Last.ToString();
                file.hex69 = Hex69.Text;
            }
        }
        private void Text69_TextChanged(object sender, EventArgs e) //encode69
        {
            if (Text69.ContainsFocus == true)
            {
                Hex69.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text69.Text));

                file.L69Length = Text69.Text.Length;
                Length69.Text = file.L69Length.ToString();
                file.L69Last = file.hex69_length - file.L69Length;
                Last69.Text = file.L69Last.ToString();
                file.hex69 = Hex69.Text;
            }
        }

        private void Hex70_TextChanged(object sender, EventArgs e) //hex70
        {
            if (Hex70.ContainsFocus == true)
            {
                Text70.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex70.Text));

                file.L70Length = Text70.Text.Length;
                Length70.Text = file.L70Length.ToString();
                file.L70Last = file.hex70_length - file.L70Length;
                Last70.Text = file.L70Last.ToString();
                file.hex70 = Hex70.Text;
            }
        }
        private void Text70_TextChanged(object sender, EventArgs e) //encode70
        {
            if (Text70.ContainsFocus == true)
            {
                Hex70.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text70.Text));

                file.L70Length = Text70.Text.Length;
                Length70.Text = file.L70Length.ToString();
                file.L70Last = file.hex70_length - file.L70Length;
                Last70.Text = file.L70Last.ToString();
                file.hex70 = Hex70.Text;
            }
        }

        private void Hex71_TextChanged(object sender, EventArgs e) //hex71
        {
            if (Hex71.ContainsFocus == true)
            {
                Text71.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex71.Text));

                file.L71Length = Text71.Text.Length;
                Length71.Text = file.L71Length.ToString();
                file.L71Last = file.hex71_length - file.L71Length;
                Last71.Text = file.L71Last.ToString();
                file.hex71 = Hex71.Text;
            }
        }
        private void Text71_TextChanged(object sender, EventArgs e) //encode71
        {
            if (Text71.ContainsFocus == true)
            {
                Hex71.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text71.Text));

                file.L71Length = Text71.Text.Length;
                Length71.Text = file.L71Length.ToString();
                file.L71Last = file.hex71_length - file.L71Length;
                Last71.Text = file.L71Last.ToString();
                file.hex71 = Hex71.Text;
            }
        }

        private void Hex72_TextChanged(object sender, EventArgs e) //hex72
        {
            if (Hex72.ContainsFocus == true)
            {
                Text72.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex72.Text));

                file.L72Length = Text72.Text.Length;
                Length72.Text = file.L72Length.ToString();
                file.L72Last = file.hex72_length - file.L72Length;
                Last72.Text = file.L72Last.ToString();
                file.hex72 = Hex72.Text;
            }
        }
        private void Text72_TextChanged(object sender, EventArgs e) //encode72
        {
            if (Text72.ContainsFocus == true)
            {
                Hex72.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text72.Text));

                file.L72Length = Text72.Text.Length;
                Length72.Text = file.L72Length.ToString();
                file.L72Last = file.hex72_length - file.L72Length;
                Last72.Text = file.L72Last.ToString();
                file.hex72 = Hex72.Text;
            }
        }

        private void Hex73_TextChanged(object sender, EventArgs e) //hex73
        {
            if (Hex73.ContainsFocus == true)
            {
                Text73.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex73.Text));

                file.L73Length = Text73.Text.Length;
                Length73.Text = file.L73Length.ToString();
                file.L73Last = file.hex73_length - file.L73Length;
                Last73.Text = file.L73Last.ToString();
                file.hex73 = Hex73.Text;
            }
        }
        private void Text73_TextChanged(object sender, EventArgs e) //encode73
        {
            if (Text73.ContainsFocus == true)
            {
                Hex73.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text73.Text));

                file.L73Length = Text73.Text.Length;
                Length73.Text = file.L73Length.ToString();
                file.L73Last = file.hex73_length - file.L73Length;
                Last73.Text = file.L73Last.ToString();
                file.hex73 = Hex73.Text;
            }
        }

        private void Hex74_TextChanged(object sender, EventArgs e) //hex74
        {
            if (Hex74.ContainsFocus == true)
            {
                Text74.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex74.Text));

                file.L74Length = Text74.Text.Length;
                Length74.Text = file.L74Length.ToString();
                file.L74Last = file.hex74_length - file.L74Length;
                Last74.Text = file.L74Last.ToString();
                file.hex74 = Hex74.Text;
            }
        }
        private void Text74_TextChanged(object sender, EventArgs e) //encode74
        {
            if (Text74.ContainsFocus == true)
            {
                Hex74.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text74.Text));

                file.L74Length = Text74.Text.Length;
                Length74.Text = file.L74Length.ToString();
                file.L74Last = file.hex74_length - file.L74Length;
                Last74.Text = file.L74Last.ToString();
                file.hex74 = Hex74.Text;
            }
        }

        private void Hex75_TextChanged(object sender, EventArgs e) //hex75
        {
            if (Hex75.ContainsFocus == true)
            {
                Text75.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex75.Text));

                file.L75Length = Text75.Text.Length;
                Length75.Text = file.L75Length.ToString();
                file.L75Last = file.hex75_length - file.L75Length;
                Last75.Text = file.L75Last.ToString();
                file.hex75 = Hex75.Text;
            }
        }
        private void Text75_TextChanged(object sender, EventArgs e) //encode75
        {
            if (Text75.ContainsFocus == true)
            {
                Hex75.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text75.Text));

                file.L75Length = Text75.Text.Length;
                Length75.Text = file.L75Length.ToString();
                file.L75Last = file.hex75_length - file.L75Length;
                Last75.Text = file.L75Last.ToString();
                file.hex75 = Hex75.Text;
            }
        }

        private void Hex76_TextChanged(object sender, EventArgs e) //hex76
        {
            if (Hex76.ContainsFocus == true)
            {
                Text76.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex76.Text));

                file.L76Length = Text76.Text.Length;
                Length76.Text = file.L76Length.ToString();
                file.L76Last = file.hex76_length - file.L76Length;
                Last76.Text = file.L76Last.ToString();
                file.hex76 = Hex76.Text;
            }
        }
        private void Text76_TextChanged(object sender, EventArgs e) //encode76
        {
            if (Text76.ContainsFocus == true)
            {
                Hex76.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text76.Text));

                file.L76Length = Text76.Text.Length;
                Length76.Text = file.L76Length.ToString();
                file.L76Last = file.hex76_length - file.L76Length;
                Last76.Text = file.L76Last.ToString();
                file.hex76 = Hex76.Text;
            }
        }

        private void Hex77_TextChanged(object sender, EventArgs e) //hex77
        {
            if (Hex77.ContainsFocus == true)
            {
                Text77.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex77.Text));

                file.L77Length = Text77.Text.Length;
                Length77.Text = file.L77Length.ToString();
                file.L77Last = file.hex77_length - file.L77Length;
                Last77.Text = file.L77Last.ToString();
                file.hex77 = Hex77.Text;
            }
        }
        private void Text77_TextChanged(object sender, EventArgs e) //encode77
        {
            if (Text77.ContainsFocus == true)
            {
                Hex77.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text77.Text));

                file.L77Length = Text77.Text.Length;
                Length77.Text = file.L77Length.ToString();
                file.L77Last = file.hex77_length - file.L77Length;
                Last77.Text = file.L77Last.ToString();
                file.hex77 = Hex77.Text;
            }
        }

        private void Hex78_TextChanged(object sender, EventArgs e) //hex78
        {
            if (Hex78.ContainsFocus == true)
            {
                Text78.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex78.Text));

                file.L78Length = Text78.Text.Length;
                Length78.Text = file.L78Length.ToString();
                file.L78Last = file.hex78_length - file.L78Length;
                Last78.Text = file.L78Last.ToString();
                file.hex78 = Hex78.Text;
            }
        }
        private void Text78_TextChanged(object sender, EventArgs e) //encode78
        {
            if (Text78.ContainsFocus == true)
            {
                Hex78.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text78.Text));

                file.L78Length = Text78.Text.Length;
                Length78.Text = file.L78Length.ToString();
                file.L78Last = file.hex78_length - file.L78Length;
                Last78.Text = file.L78Last.ToString();
                file.hex78 = Hex78.Text;
            }
        }

        private void Hex79_TextChanged(object sender, EventArgs e) //hex79
        {
            if (Hex79.ContainsFocus == true)
            {
                Text79.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex79.Text));

                file.L79Length = Text79.Text.Length;
                Length79.Text = file.L79Length.ToString();
                file.L79Last = file.hex79_length - file.L79Length;
                Last79.Text = file.L79Last.ToString();
                file.hex79 = Hex79.Text;
            }
        }
        private void Text79_TextChanged(object sender, EventArgs e) //encode79
        {
            if (Text79.ContainsFocus == true)
            {
                Hex79.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text79.Text));

                file.L79Length = Text79.Text.Length;
                Length79.Text = file.L79Length.ToString();
                file.L79Last = file.hex79_length - file.L79Length;
                Last79.Text = file.L79Last.ToString();
                file.hex79 = Hex79.Text;
            }
        }

        private void Hex80_TextChanged(object sender, EventArgs e) //hex80
        {
            if (Hex80.ContainsFocus == true)
            {
                Text80.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex80.Text));

                file.L80Length = Text80.Text.Length;
                Length80.Text = file.L80Length.ToString();
                file.L80Last = file.hex80_length - file.L80Length;
                Last80.Text = file.L80Last.ToString();
                file.hex80 = Hex80.Text;
            }
        }
        private void Text80_TextChanged(object sender, EventArgs e) //encode80
        {
            if (Text80.ContainsFocus == true)
            {
                Hex80.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text80.Text));

                file.L80Length = Text80.Text.Length;
                Length80.Text = file.L80Length.ToString();
                file.L80Last = file.hex80_length - file.L80Length;
                Last80.Text = file.L80Last.ToString();
                file.hex80 = Hex80.Text;
            }
        }

        private void Hex81_TextChanged(object sender, EventArgs e) //hex81
        {
            if (Hex81.ContainsFocus == true)
            {
                Text81.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex81.Text));

                file.L81Length = Text81.Text.Length;
                Length81.Text = file.L81Length.ToString();
                file.L81Last = file.hex81_length - file.L81Length;
                Last81.Text = file.L81Last.ToString();
                file.hex81 = Hex81.Text;
            }
        }
        private void Text81_TextChanged(object sender, EventArgs e) //encode81
        {
            if (Text81.ContainsFocus == true)
            {
                Hex81.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text81.Text));

                file.L81Length = Text81.Text.Length;
                Length81.Text = file.L81Length.ToString();
                file.L81Last = file.hex81_length - file.L81Length;
                Last81.Text = file.L81Last.ToString();
                file.hex81 = Hex81.Text;
            }
        }

        private void Hex82_TextChanged(object sender, EventArgs e) //hex82
        {
            if (Hex82.ContainsFocus == true)
            {
                Text82.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex82.Text));

                file.L82Length = Text82.Text.Length;
                Length82.Text = file.L82Length.ToString();
                file.L82Last = file.hex82_length - file.L82Length;
                Last82.Text = file.L82Last.ToString();
                file.hex82 = Hex82.Text;
            }
        }
        private void Text82_TextChanged(object sender, EventArgs e) //encode82
        {
            if (Text82.ContainsFocus == true)
            {
                Hex82.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text82.Text));

                file.L82Length = Text82.Text.Length;
                Length82.Text = file.L82Length.ToString();
                file.L82Last = file.hex82_length - file.L82Length;
                Last82.Text = file.L82Last.ToString();
                file.hex82 = Hex82.Text;
            }
        }

        private void Hex83_TextChanged(object sender, EventArgs e) //hex83
        {
            if (Hex83.ContainsFocus == true)
            {
                Text83.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex83.Text));

                file.L83Length = Text83.Text.Length;
                Length83.Text = file.L83Length.ToString();
                file.L83Last = file.hex83_length - file.L83Length;
                Last83.Text = file.L83Last.ToString();
                file.hex83 = Hex83.Text;
            }
        }
        private void Text83_TextChanged(object sender, EventArgs e) //encode83
        {
            if (Text83.ContainsFocus == true)
            {
                Hex83.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text83.Text));

                file.L83Length = Text83.Text.Length;
                Length83.Text = file.L83Length.ToString();
                file.L83Last = file.hex83_length - file.L83Length;
                Last83.Text = file.L83Last.ToString();
                file.hex83 = Hex83.Text;
            }
        }

        private void Hex84_TextChanged(object sender, EventArgs e) //hex84
        {
            if (Hex84.ContainsFocus == true)
            {
                Text84.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex84.Text));

                file.L84Length = Text84.Text.Length;
                Length84.Text = file.L84Length.ToString();
                file.L84Last = file.hex84_length - file.L84Length;
                Last84.Text = file.L84Last.ToString();
                file.hex84 = Hex84.Text;
            }
        }
        private void Text84_TextChanged(object sender, EventArgs e) //encode84
        {
            if (Text84.ContainsFocus == true)
            {
                Hex84.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text84.Text));

                file.L84Length = Text84.Text.Length;
                Length84.Text = file.L84Length.ToString();
                file.L84Last = file.hex84_length - file.L84Length;
                Last84.Text = file.L84Last.ToString();
                file.hex84 = Hex84.Text;
            }
        }

        private void Hex85_TextChanged(object sender, EventArgs e) //hex85
        {
            if (Hex85.ContainsFocus == true)
            {
                Text85.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex85.Text));

                file.L85Length = Text85.Text.Length;
                Length85.Text = file.L85Length.ToString();
                file.L85Last = file.hex85_length - file.L85Length;
                Last85.Text = file.L85Last.ToString();
                file.hex85 = Hex85.Text;
            }
        }
        private void Text85_TextChanged(object sender, EventArgs e) //encode85
        {
            if (Text85.ContainsFocus == true)
            {
                Hex85.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text85.Text));

                file.L85Length = Text85.Text.Length;
                Length85.Text = file.L85Length.ToString();
                file.L85Last = file.hex85_length - file.L85Length;
                Last85.Text = file.L85Last.ToString();
                file.hex85 = Hex85.Text;
            }
        }

        private void Hex86_TextChanged(object sender, EventArgs e) //hex86
        {
            if (Hex86.ContainsFocus == true)
            {
                Text86.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex86.Text));

                file.L86Length = Text86.Text.Length;
                Length86.Text = file.L86Length.ToString();
                file.L86Last = file.hex86_length - file.L86Length;
                Last86.Text = file.L86Last.ToString();
                file.hex86 = Hex86.Text;
            }
        }
        private void Text86_TextChanged(object sender, EventArgs e) //encode86
        {
            if (Text86.ContainsFocus == true)
            {
                Hex86.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text86.Text));

                file.L86Length = Text86.Text.Length;
                Length86.Text = file.L86Length.ToString();
                file.L86Last = file.hex86_length - file.L86Length;
                Last86.Text = file.L86Last.ToString();
                file.hex86 = Hex86.Text;
            }
        }

        private void Hex87_TextChanged(object sender, EventArgs e) //hex87
        {
            if (Hex87.ContainsFocus == true)
            {
                Text87.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex87.Text));

                file.L87Length = Text87.Text.Length;
                Length87.Text = file.L87Length.ToString();
                file.L87Last = file.hex87_length - file.L87Length;
                Last87.Text = file.L87Last.ToString();
                file.hex87 = Hex87.Text;
            }
        }
        private void Text87_TextChanged(object sender, EventArgs e) //encode87
        {
            if (Text87.ContainsFocus == true)
            {
                Hex87.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text87.Text));

                file.L87Length = Text87.Text.Length;
                Length87.Text = file.L87Length.ToString();
                file.L87Last = file.hex87_length - file.L87Length;
                Last87.Text = file.L87Last.ToString();
                file.hex87 = Hex87.Text;
            }
        }

        private void Hex88_TextChanged(object sender, EventArgs e) //hex88
        {
            if (Hex88.ContainsFocus == true)
            {
                Text88.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex88.Text));

                file.L88Length = Text88.Text.Length;
                Length88.Text = file.L88Length.ToString();
                file.L88Last = file.hex88_length - file.L88Length;
                Last88.Text = file.L88Last.ToString();
                file.hex88 = Hex88.Text;
            }
        }
        private void Text88_TextChanged(object sender, EventArgs e) //encode88
        {
            if (Text88.ContainsFocus == true)
            {
                Hex88.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text88.Text));

                file.L88Length = Text88.Text.Length;
                Length88.Text = file.L88Length.ToString();
                file.L88Last = file.hex88_length - file.L88Length;
                Last88.Text = file.L88Last.ToString();
                file.hex88 = Hex88.Text;
            }
        }

        private void Hex89_TextChanged(object sender, EventArgs e) //hex89
        {
            if (Hex89.ContainsFocus == true)
            {
                Text89.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex89.Text));

                file.L89Length = Text89.Text.Length;
                Length89.Text = file.L89Length.ToString();
                file.L89Last = file.hex89_length - file.L89Length;
                Last89.Text = file.L89Last.ToString();
                file.hex89 = Hex89.Text;
            }
        }
        private void Text89_TextChanged(object sender, EventArgs e) //encode89
        {
            if (Text89.ContainsFocus == true)
            {
                Hex89.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text89.Text));

                file.L89Length = Text89.Text.Length;
                Length89.Text = file.L89Length.ToString();
                file.L89Last = file.hex89_length - file.L89Length;
                Last89.Text = file.L89Last.ToString();
                file.hex89 = Hex89.Text;
            }
        }

        private void Hex90_TextChanged(object sender, EventArgs e) //hex90
        {
            if (Hex90.ContainsFocus == true)
            {
                Text90.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex90.Text));

                file.L90Length = Text90.Text.Length;
                Length90.Text = file.L90Length.ToString();
                file.L90Last = file.hex90_length - file.L90Length;
                Last90.Text = file.L90Last.ToString();
                file.hex90 = Hex90.Text;
            }
        }
        private void Text90_TextChanged(object sender, EventArgs e) //encode90
        {
            if (Text90.ContainsFocus == true)
            {
                Hex90.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text90.Text));

                file.L90Length = Text90.Text.Length;
                Length90.Text = file.L90Length.ToString();
                file.L90Last = file.hex90_length - file.L90Length;
                Last90.Text = file.L90Last.ToString();
                file.hex90 = Hex90.Text;
            }
        }

        private void Hex91_TextChanged(object sender, EventArgs e) //hex91
        {
            if (Hex91.ContainsFocus == true)
            {
                Text91.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex91.Text));

                file.L91Length = Text91.Text.Length;
                Length91.Text = file.L91Length.ToString();
                file.L91Last = file.hex91_length - file.L91Length;
                Last91.Text = file.L91Last.ToString();
                file.hex91 = Hex91.Text;
            }
        }
        private void Text91_TextChanged(object sender, EventArgs e) //encode91
        {
            if (Text91.ContainsFocus == true)
            {
                Hex91.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text91.Text));

                file.L91Length = Text91.Text.Length;
                Length91.Text = file.L91Length.ToString();
                file.L91Last = file.hex91_length - file.L91Length;
                Last91.Text = file.L91Last.ToString();
                file.hex91 = Hex91.Text;
            }
        }

        private void Hex92_TextChanged(object sender, EventArgs e) //hex92
        {
            if (Hex92.ContainsFocus == true)
            {
                Text92.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex92.Text));
                
                file.L92Length = Text92.Text.Length;
                Length92.Text = file.L92Length.ToString();
                file.L92Last = file.hex92_length - file.L92Length;
                Last92.Text = file.L92Last.ToString();
                file.hex92 = Hex92.Text;
            }
        }
        private void Text92_TextChanged(object sender, EventArgs e) //encode92
        {
            if (Text92.ContainsFocus == true)
            {
                Hex92.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text92.Text));

                file.L92Length = Text92.Text.Length;
                Length92.Text = file.L92Length.ToString();
                file.L92Last = file.hex92_length - file.L92Length;
                Last92.Text = file.L92Last.ToString();
                file.hex92 = Hex92.Text;
            }
        }

        private void Hex93_TextChanged(object sender, EventArgs e) //hex93
        {
            if (Hex93.ContainsFocus == true)
            {
                Text93.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex93.Text));

                file.L93Length = Text93.Text.Length;
                Length93.Text = file.L93Length.ToString();
                file.L93Last = file.hex93_length - file.L93Length;
                Last93.Text = file.L93Last.ToString();
                file.hex93 = Hex93.Text;
            }
        }
        private void Text93_TextChanged(object sender, EventArgs e) //encode93
        {
            if (Text93.ContainsFocus == true)
            {
                Hex93.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text93.Text));

                file.L93Length = Text93.Text.Length;
                Length93.Text = file.L93Length.ToString();
                file.L93Last = file.hex93_length - file.L93Length;
                Last93.Text = file.L93Last.ToString();
                file.hex93 = Hex93.Text;
            }
        }

        private void Hex94_TextChanged(object sender, EventArgs e) //hex94
        {
            if (Hex94.ContainsFocus == true)
            {
                Text94.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex94.Text));

                file.L94Length = Text94.Text.Length;
                Length94.Text = file.L94Length.ToString();
                file.L94Last = file.hex94_length - file.L94Length;
                Last94.Text = file.L94Last.ToString();
                file.hex94 = Hex94.Text;
            }
        }
        private void Text94_TextChanged(object sender, EventArgs e) //encode94
        {
            if (Text94.ContainsFocus == true)
            {
                Hex94.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text94.Text));

                file.L94Length = Text94.Text.Length;
                Length94.Text = file.L94Length.ToString();
                file.L94Last = file.hex94_length - file.L94Length;
                Last94.Text = file.L94Last.ToString();
                file.hex94 = Hex94.Text;
            }
        }

        private void Hex95_TextChanged(object sender, EventArgs e) //hex95
        {
            if (Hex95.ContainsFocus == true)
            {
                Text95.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex95.Text));

                file.L95Length = Text95.Text.Length;
                Length95.Text = file.L95Length.ToString();
                file.L95Last = file.hex95_length - file.L95Length;
                Last95.Text = file.L95Last.ToString();
                file.hex95 = Hex95.Text;
            }
        }
        private void Text95_TextChanged(object sender, EventArgs e) //encode95
        {
            if (Text95.ContainsFocus == true)
            {
                Hex95.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text95.Text));

                file.L95Length = Text95.Text.Length;
                Length95.Text = file.L95Length.ToString();
                file.L95Last = file.hex95_length - file.L95Length;
                Last95.Text = file.L95Last.ToString();
                file.hex95 = Hex95.Text;
            }
        }

        private void Hex96_TextChanged(object sender, EventArgs e) //hex96
        {
            if (Hex96.ContainsFocus == true)
            {
                Text96.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex96.Text));

                file.L96Length = Text96.Text.Length;
                Length96.Text = file.L96Length.ToString();
                file.L96Last = file.hex96_length - file.L96Length;
                Last96.Text = file.L96Last.ToString();
                file.hex96 = Hex96.Text;
            }
        }
        private void Text96_TextChanged(object sender, EventArgs e) //encode96
        {
            if (Text96.ContainsFocus == true)
            {
                Hex96.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text96.Text));

                file.L96Length = Text96.Text.Length;
                Length96.Text = file.L96Length.ToString();
                file.L96Last = file.hex96_length - file.L96Length;
                Last96.Text = file.L96Last.ToString();
                file.hex96 = Hex96.Text;
            }
        }

        private void Hex97_TextChanged(object sender, EventArgs e) //hex97
        {
            if (Hex97.ContainsFocus == true)
            {
                Text97.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex97.Text));

                file.L97Length = Text97.Text.Length;
                Length97.Text = file.L97Length.ToString();
                file.L97Last = file.hex97_length - file.L97Length;
                Last97.Text = file.L97Last.ToString();
                file.hex97 = Hex97.Text;
            }
        }
        private void Text97_TextChanged(object sender, EventArgs e) //encode97
        {
            if (Text97.ContainsFocus == true)
            {
                Hex97.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text97.Text));

                file.L97Length = Text97.Text.Length;
                Length97.Text = file.L97Length.ToString();
                file.L97Last = file.hex97_length - file.L97Length;
                Last97.Text = file.L97Last.ToString();
                file.hex97 = Hex97.Text;
            }
        }
        private void Hex98_TextChanged(object sender, EventArgs e) //hex98
        {
            if (Hex98.ContainsFocus == true)
            {
                Text98.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex98.Text));

                file.L98Length = Text98.Text.Length;
                Length98.Text = file.L98Length.ToString();
                file.L98Last = file.hex98_length - file.L98Length;
                Last98.Text = file.L98Last.ToString();
                file.hex98 = Hex98.Text;
            }
        }
        private void Text98_TextChanged(object sender, EventArgs e) //encode98
        {
            if (Text98.ContainsFocus == true)
            {
                Hex98.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text98.Text));

                file.L98Length = Text98.Text.Length;
                Length98.Text = file.L98Length.ToString();
                file.L98Last = file.hex98_length - file.L98Length;
                Last98.Text = file.L98Last.ToString();
                file.hex98 = Hex98.Text;
            }
        }
        private void Hex99_TextChanged(object sender, EventArgs e) //hex99
        {
            if (Hex99.ContainsFocus == true)
            {
                Text99.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex99.Text));

                file.L99Length = Text99.Text.Length;
                Length99.Text = file.L99Length.ToString();
                file.L99Last = file.hex99_length - file.L99Length;
                Last99.Text = file.L99Last.ToString();
                file.hex99 = Hex99.Text;
            }
        }
        private void Text99_TextChanged(object sender, EventArgs e) //encode99
        {
            if (Text99.ContainsFocus == true)
            {
                Hex99.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text99.Text));

                file.L99Length = Text99.Text.Length;
                Length99.Text = file.L99Length.ToString();
                file.L99Last = file.hex99_length - file.L99Length;
                Last99.Text = file.L99Last.ToString();
                file.hex99 = Hex99.Text;
            }
        }
        private void Hex100_TextChanged(object sender, EventArgs e) //hex100
        {
            if (Hex100.ContainsFocus == true)
            {
                Text100.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex100.Text));

                file.L100Length = Text100.Text.Length;
                Length100.Text = file.L100Length.ToString();
                file.L100Last = file.hex100_length - file.L100Length;
                Last100.Text = file.L100Last.ToString();
                file.hex100 = Hex100.Text;
            }
        }
        private void Text100_TextChanged(object sender, EventArgs e) //encode100
        {
            if (Text100.ContainsFocus == true)
            {
                Hex100.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text100.Text));

                file.L100Length = Text100.Text.Length;
                Length100.Text = file.L100Length.ToString();
                file.L100Last = file.hex100_length - file.L100Length;
                Last100.Text = file.L100Last.ToString();
                file.hex100 = Hex100.Text;
            }
        }
        private void Hex101_TextChanged(object sender, EventArgs e) //hex101
        {
            if (Hex101.ContainsFocus == true)
            {
                Text101.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex101.Text));

                file.L101Length = Text101.Text.Length;
                Length101.Text = file.L101Length.ToString();
                file.L101Last = file.hex101_length - file.L101Length;
                Last101.Text = file.L101Last.ToString();
                file.hex101 = Hex101.Text;
            }
        }
        private void Text101_TextChanged(object sender, EventArgs e) //encode101
        {
            if (Text101.ContainsFocus == true)
            {
                Hex101.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text101.Text));

                file.L101Length = Text101.Text.Length;
                Length101.Text = file.L101Length.ToString();
                file.L101Last = file.hex101_length - file.L101Length;
                Last101.Text = file.L101Last.ToString();
                file.hex101 = Hex101.Text;
            }
        }
        private void Hex102_TextChanged(object sender, EventArgs e) //hex102
        {
            if (Hex102.ContainsFocus == true)
            {
                Text102.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex102.Text));

                file.L102Length = Text102.Text.Length;
                Length102.Text = file.L102Length.ToString();
                file.L102Last = file.hex102_length - file.L102Length;
                Last102.Text = file.L102Last.ToString();
                file.hex102 = Hex102.Text;
            }
        }
        private void Text102_TextChanged(object sender, EventArgs e) //encode102
        {
            if (Text102.ContainsFocus == true)
            {
                Hex102.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text102.Text));

                file.L102Length = Text102.Text.Length;
                Length102.Text = file.L102Length.ToString();
                file.L102Last = file.hex102_length - file.L102Length;
                Last102.Text = file.L102Last.ToString();
                file.hex102 = Hex102.Text;
            }
        }
        private void Hex103_TextChanged(object sender, EventArgs e) //hex103
        {
            if (Hex103.ContainsFocus == true)
            {
                Text103.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex103.Text));

                file.L103Length = Text103.Text.Length;
                Length103.Text = file.L103Length.ToString();
                file.L103Last = file.hex103_length - file.L103Length;
                Last103.Text = file.L103Last.ToString();
                file.hex103 = Hex103.Text;
            }
        }
        private void Text103_TextChanged(object sender, EventArgs e) //encode103
        {
            if (Text103.ContainsFocus == true)
            {
                Hex103.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text103.Text));

                file.L103Length = Text103.Text.Length;
                Length103.Text = file.L103Length.ToString();
                file.L103Last = file.hex103_length - file.L103Length;
                Last103.Text = file.L103Last.ToString();
                file.hex103 = Hex103.Text;
            }
        }
        private void Hex104_TextChanged(object sender, EventArgs e) //hex104
        {
            if (Hex104.ContainsFocus == true)
            {
                Text104.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex104.Text));

                file.L104Length = Text104.Text.Length;
                Length104.Text = file.L104Length.ToString();
                file.L104Last = file.hex104_length - file.L104Length;
                Last104.Text = file.L104Last.ToString();
                file.hex104 = Hex104.Text;
            }
        }
        private void Text104_TextChanged(object sender, EventArgs e) //encode104
        {
            if (Text104.ContainsFocus == true)
            {
                Hex104.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text104.Text));

                file.L104Length = Text104.Text.Length;
                Length104.Text = file.L104Length.ToString();
                file.L104Last = file.hex104_length - file.L104Length;
                Last104.Text = file.L104Last.ToString();
                file.hex104 = Hex104.Text;
            }
        }

        private void Hex105_TextChanged(object sender, EventArgs e) //hex105
        {
            if (Hex105.ContainsFocus == true)
            {
                Text105.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex105.Text));

                file.L105Length = Text105.Text.Length;
                Length105.Text = file.L105Length.ToString();
                file.L105Last = file.hex105_length - file.L105Length;
                Last105.Text = file.L105Last.ToString();
                file.hex105 = Hex105.Text;
            }
        }
        private void Text105_TextChanged(object sender, EventArgs e) //encode105
        {
            if (Text105.ContainsFocus == true)
            {
                Hex105.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text105.Text));

                file.L105Length = Text105.Text.Length;
                Length105.Text = file.L105Length.ToString();
                file.L105Last = file.hex105_length - file.L105Length;
                Last105.Text = file.L105Last.ToString();
                file.hex105 = Hex105.Text;
            }
        }

        private void Hex106_TextChanged(object sender, EventArgs e) //hex106
        {
            if (Hex106.ContainsFocus == true)
            {
                Text106.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex106.Text));

                file.L106Length = Text106.Text.Length;
                Length106.Text = file.L106Length.ToString();
                file.L106Last = file.hex106_length - file.L106Length;
                Last106.Text = file.L106Last.ToString();
                file.hex106 = Hex106.Text;
            }
        }
        private void Text106_TextChanged(object sender, EventArgs e) //encode106
        {
            if (Text106.ContainsFocus == true)
            {
                Hex106.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text106.Text));

                file.L106Length = Text106.Text.Length;
                Length106.Text = file.L106Length.ToString();
                file.L106Last = file.hex106_length - file.L106Length;
                Last106.Text = file.L106Last.ToString();
                file.hex106 = Hex106.Text;
            }
        }

        private void Hex107_TextChanged(object sender, EventArgs e) //hex107
        {
            if (Hex107.ContainsFocus == true)
            {
                Text107.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex107.Text));

                file.L107Length = Text107.Text.Length;
                Length107.Text = file.L107Length.ToString();
                file.L107Last = file.hex107_length - file.L107Length;
                Last107.Text = file.L107Last.ToString();
                file.hex107 = Hex107.Text;
            }
        }
        private void Text107_TextChanged(object sender, EventArgs e) //encode107
        {
            if (Text107.ContainsFocus == true)
            {
                Hex107.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text107.Text));

                file.L107Length = Text107.Text.Length;
                Length107.Text = file.L107Length.ToString();
                file.L107Last = file.hex107_length - file.L107Length;
                Last107.Text = file.L107Last.ToString();
                file.hex107 = Hex107.Text;
            }
        }

        private void Hex108_TextChanged(object sender, EventArgs e) //hex108
        {
            if (Hex108.ContainsFocus == true)
            {
                Text108.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex108.Text));

                file.L108Length = Text108.Text.Length;
                Length108.Text = file.L108Length.ToString();
                file.L108Last = file.hex108_length - file.L108Length;
                Last108.Text = file.L108Last.ToString();
                file.hex108 = Hex108.Text;
            }
        }
        private void Text108_TextChanged(object sender, EventArgs e) //encode108
        {
            if (Text108.ContainsFocus == true)
            {
                Hex108.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text108.Text));

                file.L108Length = Text108.Text.Length;
                Length108.Text = file.L108Length.ToString();
                file.L108Last = file.hex108_length - file.L108Length;
                Last108.Text = file.L108Last.ToString();
                file.hex108 = Hex108.Text;
            }
        }

        private void Hex109_TextChanged(object sender, EventArgs e) //hex109
        {
            if (Hex109.ContainsFocus == true)
            {
                Text109.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex109.Text));

                file.L109Length = Text109.Text.Length;
                Length109.Text = file.L109Length.ToString();
                file.L109Last = file.hex109_length - file.L109Length;
                Last109.Text = file.L109Last.ToString();
                file.hex109 = Hex109.Text;
            }
        }
        private void Text109_TextChanged(object sender, EventArgs e) //encode109
        {
            if (Text109.ContainsFocus == true)
            {
                Hex109.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text109.Text));

                file.L109Length = Text109.Text.Length;
                Length109.Text = file.L109Length.ToString();
                file.L109Last = file.hex109_length - file.L109Length;
                Last109.Text = file.L109Last.ToString();
                file.hex109 = Hex109.Text;
            }
        }

        private void Hex110_TextChanged(object sender, EventArgs e) //hex110
        {
            if (Hex110.ContainsFocus == true)
            {
                Text110.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex110.Text));

                file.L110Length = Text110.Text.Length;
                Length110.Text = file.L110Length.ToString();
                file.L110Last = file.hex110_length - file.L110Length;
                Last110.Text = file.L110Last.ToString();
                file.hex110 = Hex110.Text;
            }
        }
        private void Text110_TextChanged(object sender, EventArgs e) //encode110
        {
            if (Text110.ContainsFocus == true)
            {
                Hex110.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text110.Text));

                file.L110Length = Text110.Text.Length;
                Length110.Text = file.L110Length.ToString();
                file.L110Last = file.hex110_length - file.L110Length;
                Last110.Text = file.L110Last.ToString();
                file.hex110 = Hex110.Text;
            }
        }

        private void Hex111_TextChanged(object sender, EventArgs e) //hex111
        {
            if (Hex111.ContainsFocus == true)
            {
                Text111.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex111.Text));

                file.L111Length = Text111.Text.Length;
                Length111.Text = file.L111Length.ToString();
                file.L111Last = file.hex111_length - file.L111Length;
                Last111.Text = file.L111Last.ToString();
                file.hex111 = Hex111.Text;
            }
        }
        private void Text111_TextChanged(object sender, EventArgs e) //encode111
        {
            if (Text111.ContainsFocus == true)
            {
                Hex111.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text111.Text));

                file.L111Length = Text111.Text.Length;
                Length111.Text = file.L111Length.ToString();
                file.L111Last = file.hex111_length - file.L111Length;
                Last111.Text = file.L111Last.ToString();
                file.hex111 = Hex111.Text;
            }
        }

        private void Hex112_TextChanged(object sender, EventArgs e) //hex112
        {
            if (Hex112.ContainsFocus == true)
            {
                Text112.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex112.Text));

                file.L112Length = Text112.Text.Length;
                Length112.Text = file.L112Length.ToString();
                file.L112Last = file.hex112_length - file.L112Length;
                Last112.Text = file.L112Last.ToString();
                file.hex112 = Hex112.Text;
            }
        }
        private void Text112_TextChanged(object sender, EventArgs e) //encode112
        {
            if (Text112.ContainsFocus == true)
            {
                Hex112.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text112.Text));

                file.L112Length = Text112.Text.Length;
                Length112.Text = file.L112Length.ToString();
                file.L112Last = file.hex112_length - file.L112Length;
                Last112.Text = file.L112Last.ToString();
                file.hex112 = Hex112.Text;
            }
        }

        private void Hex113_TextChanged(object sender, EventArgs e) //hex113
        {
            if (Hex113.ContainsFocus == true)
            {
                Text113.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex113.Text));

                file.L113Length = Text113.Text.Length;
                Length113.Text = file.L113Length.ToString();
                file.L113Last = file.hex113_length - file.L113Length;
                Last113.Text = file.L113Last.ToString();
                file.hex113 = Hex113.Text;
            }
        }
        private void Text113_TextChanged(object sender, EventArgs e) //encode113
        {
            if (Text113.ContainsFocus == true)
            {
                Hex113.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text113.Text));

                file.L113Length = Text113.Text.Length;
                Length113.Text = file.L113Length.ToString();
                file.L113Last = file.hex113_length - file.L113Length;
                Last113.Text = file.L113Last.ToString();
                file.hex113 = Hex113.Text;
            }
        }

        private void Hex114_TextChanged(object sender, EventArgs e) //hex114
        {
            if (Hex114.ContainsFocus == true)
            {
                Text114.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex114.Text));

                file.L114Length = Text114.Text.Length;
                Length114.Text = file.L114Length.ToString();
                file.L114Last = file.hex114_length - file.L114Length;
                Last114.Text = file.L114Last.ToString();
                file.hex114 = Hex114.Text;
            }
        }
        private void Text114_TextChanged(object sender, EventArgs e) //encode114
        {
            if (Text114.ContainsFocus == true)
            {
                Hex114.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text114.Text));

                file.L114Length = Text114.Text.Length;
                Length114.Text = file.L114Length.ToString();
                file.L114Last = file.hex114_length - file.L114Length;
                Last114.Text = file.L114Last.ToString();
                file.hex114 = Hex114.Text;
            }
        }

        private void Hex115_TextChanged(object sender, EventArgs e) //hex115
        {
            if (Hex115.ContainsFocus == true)
            {
                Text115.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex115.Text));

                file.L115Length = Text115.Text.Length;
                Length115.Text = file.L115Length.ToString();
                file.L115Last = file.hex115_length - file.L115Length;
                Last115.Text = file.L115Last.ToString();
                file.hex115 = Hex115.Text;
            }
        }
        private void Text115_TextChanged(object sender, EventArgs e) //encode115
        {
            if (Text115.ContainsFocus == true)
            {
                Hex115.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text115.Text));

                file.L115Length = Text115.Text.Length;
                Length115.Text = file.L115Length.ToString();
                file.L115Last = file.hex115_length - file.L115Length;
                Last115.Text = file.L115Last.ToString();
                file.hex115 = Hex115.Text;
            }
        }

        private void Hex116_TextChanged(object sender, EventArgs e) //hex116
        {
            if (Hex116.ContainsFocus == true)
            {
                Text116.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex116.Text));

                file.L116Length = Text116.Text.Length;
                Length116.Text = file.L116Length.ToString();
                file.L116Last = file.hex116_length - file.L116Length;
                Last116.Text = file.L116Last.ToString();
                file.hex116 = Hex116.Text;
            }
        }
        private void Text116_TextChanged(object sender, EventArgs e) //encode116
        {
            if (Text116.ContainsFocus == true)
            {
                Hex116.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text116.Text));

                file.L116Length = Text116.Text.Length;
                Length116.Text = file.L116Length.ToString();
                file.L116Last = file.hex116_length - file.L116Length;
                Last116.Text = file.L116Last.ToString();
                file.hex116 = Hex116.Text;
            }
        }

        private void Hex117_TextChanged(object sender, EventArgs e) //hex117
        {
            if (Hex117.ContainsFocus == true)
            {
                Text117.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex117.Text));

                file.L117Length = Text117.Text.Length;
                Length117.Text = file.L117Length.ToString();
                file.L117Last = file.hex117_length - file.L117Length;
                Last117.Text = file.L117Last.ToString();
                file.hex117 = Hex117.Text;
            }
        }
        private void Text117_TextChanged(object sender, EventArgs e) //encode117
        {
            if (Text117.ContainsFocus == true)
            {
                Hex117.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text117.Text));

                file.L117Length = Text117.Text.Length;
                Length117.Text = file.L117Length.ToString();
                file.L117Last = file.hex117_length - file.L117Length;
                Last117.Text = file.L117Last.ToString();
                file.hex117 = Hex117.Text;
            }
        }

        private void Hex118_TextChanged(object sender, EventArgs e) //hex118
        {
            if (Hex118.ContainsFocus == true)
            {
                Text118.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex118.Text));

                file.L118Length = Text118.Text.Length;
                Length118.Text = file.L118Length.ToString();
                file.L118Last = file.hex118_length - file.L118Length;
                Last118.Text = file.L118Last.ToString();
                file.hex118 = Hex118.Text;
            }
        }
        private void Text118_TextChanged(object sender, EventArgs e) //encode118
        {
            if (Text118.ContainsFocus == true)
            {
                Hex118.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text118.Text));

                file.L118Length = Text118.Text.Length;
                Length118.Text = file.L118Length.ToString();
                file.L118Last = file.hex118_length - file.L118Length;
                Last118.Text = file.L118Last.ToString();
                file.hex118 = Hex118.Text;
            }
        }

        private void Hex119_TextChanged(object sender, EventArgs e) //hex119
        {
            if (Hex119.ContainsFocus == true)
            {
                Text119.Text = System.Text.Encoding.Default.GetString(Open_File.OpenFile.hex2byte(Hex119.Text));

                file.L119Length = Text119.Text.Length;
                Length119.Text = file.L119Length.ToString();
                file.L119Last = file.hex119_length - file.L119Length;
                Last119.Text = file.L119Last.ToString();
                file.hex119 = Hex119.Text;
            }
        }
        private void Text119_TextChanged(object sender, EventArgs e) //encode119
        {
            if (Text119.ContainsFocus == true)
            {
                Hex119.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(Text119.Text));

                file.L119Length = Text119.Text.Length;
                Length119.Text = file.L119Length.ToString();
                file.L119Last = file.hex119_length - file.L119Length;
                Last119.Text = file.L119Last.ToString();
                file.hex119 = Hex119.Text;
            }
        }
    }
}
