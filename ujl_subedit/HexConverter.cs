using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ujl_subedit
{
    class HexConverter
    {
        public static string HexToRus(string hex)
        {
            switch (hex)
            {
                case "C0": //А
                    hex = "41";
                    break;
                case "E0": //а
                    hex = "41";
                    break;
                case "C1": //Б
                    hex = "42";
                    break;
                case "E1": //б
                    hex = "42";
                    break;
                case "C2": //В
                    hex = "45";
                    break;
                case "E2": //в
                    hex = "45";
                    break;
                case "c3": //Г
                    hex = "47";
                    break;
                case "E3": //г
                    hex = "47";
                    break;
                case "C4": //Д
                    hex = "EB";
                    break;
                case "E4": //д
                    hex = "EB";
                    break;
                case "C5": //E
                    hex = "43";
                    break;
                case "E5": //е
                    hex = "43";
                    break;
                case "A8": //Ё
                    hex = "44";
                    break;
                case "B8": //ё
                    hex = "44";
                    break;
                case "C6": //Ж
                    hex = "57";
                    break;
                case "E6": //ж
                    hex = "57";
                    break;
                case "C7": //З
                    hex = "E7";
                    break;
                case "E7": //з
                    hex = "E7";
                    break;
                case "C8": //И
                    hex = "49";
                    break;
                case "E8": //и
                    hex = "49";
                    break;
                case "C9": //Й
                    hex = "4A";
                    break;
                case "E9": //й
                    hex = "4A";
                    break;
                case "CA": //К
                    hex = "4E";
                    break;
                case "EA": //к
                    hex = "4E";
                    break;
                case "CB": //Л
                    hex = "F6";
                    break;
                case "EB": //л
                    hex = "F6";
                    break;
                case "CC": //М
                    hex = "50";
                    break;
                case "EC": //м
                    hex = "50";
                    break;
                case "CD": //Н
                    hex = "56";
                    break;
                case "ED": //н
                    hex = "56";
                    break;
                case "CE": //О
                    hex = "53";
                    break;
                case "EE": //о
                    hex = "53";
                    break;
                case "CF": //П
                    hex = "55";
                    break;
                case "EF": //п
                    hex = "55";
                    break;
                case "D0": //Р
                    hex = "52";
                    break;
                case "F0": //р
                    hex = "52";
                    break;
                case "D1": //С
                    hex = "FA";
                    break;
                case "F1": //с
                    hex = "FA";
                    break;
                case "D2": //Т
                    hex = "F4";
                    break;
                case "F2": //т
                    hex = "F4";
                    break;
                case "D3": //У
                    hex = "EE";
                    break;
                case "F3": //у
                    hex = "EE";
                    break;
                case "D4": //Ф
                    hex = "46";
                    break;
                case "F4": //ф
                    hex = "46";
                    break;
                case "D5": //Х
                    hex = "EA";
                    break;
                case "F5": //х
                    hex = "EA";
                    break;
                case "D6": //Ц
                    hex = "E8";
                    break;
                case "F6": //ц
                    hex = "E8";
                    break;
                case "D7": //Ч
                    hex = "E9";
                    break;
                case "F7": //ч
                    hex = "E9";
                    break;
                case "D8": //Ш
                    hex = "4D";
                    break;
                case "F8": //ш
                    hex = "4D";
                    break;
                case "D9": //Щ
                    hex = "9C";
                    break;
                case "F9": //щ
                    hex = "9C";
                    break;
                case "DA": //Ъ
                    hex = "EF";
                    break;
                case "FA": //ъ
                    hex = "EF";
                    break;
                case "DB": //Ы
                    hex = "DF";
                    break;
                case "FB": //ы
                    hex = "DF";
                    break;
                case "DC": //Ь
                    hex = "F3";
                    break;
                case "FC": //ь
                    hex = "F3";
                    break;
                case "DD": //Э
                    hex = "F2";
                    break;
                case "FD": //э
                    hex = "F2";
                    break;
                case "DE": //Ю
                    hex = "C0";
                    break;
                case "FE": //ю
                    hex = "C0";
                    break;
                case "DF": //Я
                    hex = "EC";
                    break;
                case "FF": //я
                    hex = "EC";
                    break;
            }
            return hex;
        }
    }
}
