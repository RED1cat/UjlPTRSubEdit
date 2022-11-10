
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
                    hex = "63";
                    break;
                case "C1": //Б
                    hex = "42";
                    break;
                case "E1": //б
                    hex = "62";
                    break;
                case "C2": //В
                    hex = "45";
                    break;
                case "E2": //в
                    hex = "65";
                    break;
                case "C3": //Г
                    hex = "47";
                    break;
                case "E3": //г
                    hex = "69";
                    break;
                case "C4": //Д
                    hex = "EB";
                    break;
                case "E4": //д
                    hex = "6B";
                    break;
                case "C5": //E
                    hex = "43";
                    break;
                case "E5": //е
                    hex = "68";
                    break;
                case "A8": //Ё
                    hex = "44";
                    break;
                case "B8": //ё
                    hex = "6A";
                    break;
                case "C6": //Ж
                    hex = "57";
                    break;
                case "E6": //ж
                    hex = "64";
                    break;
                case "C7": //З
                    hex = "E7";
                    break;
                case "E7": //з
                    hex = "6E";
                    break;
                case "C8": //И
                    hex = "49";
                    break;
                case "E8": //и
                    hex = "6F";
                    break;
                case "C9": //Й
                    hex = "4A";
                    break;
                case "E9": //й
                    hex = "78";
                    break;
                case "CA": //К
                    hex = "4E";
                    break;
                case "EA": //к
                    hex = "70";
                    break;
                case "CB": //Л
                    hex = "F6";
                    break;
                case "EB": //л
                    hex = "71";
                    break;
                case "CC": //М
                    hex = "50";
                    break;
                case "EC": //м
                    hex = "79";
                    break;
                case "CD": //Н
                    hex = "56";
                    break;
                case "ED": //н
                    hex = "72";
                    break;
                case "CE": //О
                    hex = "53";
                    break;
                case "EE": //о
                    hex = "73";
                    break;
                case "CF": //П
                    hex = "55";
                    break;
                case "EF": //п
                    hex = "74";
                    break;
                case "D0": //Р
                    hex = "52";
                    break;
                case "F0": //р
                    hex = "75";
                    break;
                case "D1": //С
                    hex = "FA";
                    break;
                case "F1": //с
                    hex = "76";
                    break;
                case "D2": //Т
                    hex = "F4";
                    break;
                case "F2": //т
                    hex = "6C";
                    break;
                case "D3": //У
                    hex = "EE";
                    break;
                case "F3": //у
                    hex = "4C";
                    break;
                case "D4": //Ф
                    hex = "46";
                    break;
                case "F4": //ф
                    hex = "E0";
                    break;
                case "D5": //Х
                    hex = "EA";
                    break;
                case "F5": //х
                    hex = "ED";
                    break;
                case "D6": //Ц
                    hex = "E8";
                    break;
                case "F6": //ц
                    hex = "59";
                    break;
                case "D7": //Ч
                    hex = "E9";
                    break;
                case "F7": //ч
                    hex = "61";
                    break;
                case "D8": //Ш
                    hex = "4D";
                    break;
                case "F8": //ш
                    hex = "77";
                    break;
                case "D9": //Щ
                    hex = "9C";
                    break;
                case "F9": //щ
                    hex = "6D";
                    break;
                case "DA": //Ъ
                    hex = "EF";
                    break;
                case "FA": //ъ
                    hex = "67";
                    break;
                case "DB": //Ы
                    hex = "DF";
                    break;
                case "FB": //ы
                    hex = "5A";
                    break;
                case "DC": //Ь
                    hex = "F3";
                    break;
                case "FC": //ь
                    hex = "7A";
                    break;
                case "DD": //Э
                    hex = "F2";
                    break;
                case "FD": //э
                    hex = "E1";
                    break;
                case "DE": //Ю
                    hex = "C0";
                    break;
                case "FE": //ю
                    hex = "F9";
                    break;
                case "DF": //Я
                    hex = "EC";
                    break;
                case "FF": //я
                    hex = "54";
                    break;
            }
            return hex;
        }
        public static string RusToHex(string hex)
        {
            switch (hex)
            {
                case "41": //А
                    hex = "C0";
                    break;
                case "63": //а
                    hex = "E0";
                    break;
                case "42": //Б
                    hex = "C1";
                    break;
                case "62": //б
                    hex = "E1";
                    break;
                case "45": //В
                    hex = "C2";
                    break;
                case "65": //в
                    hex = "E2";
                    break;
                case "47": //Г
                    hex = "C3";
                    break;
                case "69": //г
                    hex = "E3";
                    break;
                case "EB": //Д
                    hex = "C4";
                    break;
                case "6B": //д
                    hex = "E4";
                    break;
                case "43": //E
                    hex = "C5";
                    break;
                case "68": //е
                    hex = "E5";
                    break;
                case "44": //Ё
                    hex = "A8";
                    break;
                case "6A": //ё
                    hex = "B8";
                    break;
                case "57": //Ж
                    hex = "C6";
                    break;
                case "64": //ж
                    hex = "E6";
                    break;
                case "E7": //З
                    hex = "C7";
                    break;
                case "6E": //з
                    hex = "E7";
                    break;
                case "49": //И
                    hex = "C8";
                    break;
                case "6F": //и
                    hex = "E8";
                    break;
                case "4A": //Й
                    hex = "C9";
                    break;
                case "78": //й
                    hex = "E9";
                    break;
                case "4E": //К
                    hex = "CA";
                    break;
                case "70": //к
                    hex = "EA";
                    break;
                case "F6": //Л
                    hex = "CB";
                    break;
                case "71": //л
                    hex = "EB";
                    break;
                case "50": //М
                    hex = "CC";
                    break;
                case "79": //м
                    hex = "EC";
                    break;
                case "56": //Н
                    hex = "CD";
                    break;
                case "72": //н
                    hex = "ED";
                    break;
                case "53": //О
                    hex = "CE";
                    break;
                case "73": //о
                    hex = "EE";
                    break;
                case "55": //П
                    hex = "CF";
                    break;
                case "74": //п
                    hex = "EF";
                    break;
                case "52": //Р
                    hex = "D0";
                    break;
                case "75": //р
                    hex = "F0";
                    break;
                case "FA": //С
                    hex = "D1";
                    break;
                case "76": //с
                    hex = "F1";
                    break;
                case "F4": //Т
                    hex = "D2";
                    break;
                case "6C": //т
                    hex = "F2";
                    break;
                case "EE": //У
                    hex = "D3";
                    break;
                case "4C": //у
                    hex = "F3";
                    break;
                case "46": //Ф
                    hex = "D4";
                    break;
                case "E0": //ф
                    hex = "F4";
                    break;
                case "EA": //Х
                    hex = "D5";
                    break;
                case "ED": //х
                    hex = "F5";
                    break;
                case "E8": //Ц
                    hex = "D6";
                    break;
                case "59": //ц
                    hex = "F6";
                    break;
                case "E9": //Ч
                    hex = "D7";
                    break;
                case "61": //ч
                    hex = "F7";
                    break;
                case "4D": //Ш
                    hex = "D8";
                    break;
                case "77": //ш
                    hex = "F8";
                    break;
                case "9C": //Щ
                    hex = "D9";
                    break;
                case "6D": //щ
                    hex = "F9";
                    break;
                case "EF": //Ъ
                    hex = "DA";
                    break;
                case "67": //ъ
                    hex = "FA";
                    break;
                case "DF": //Ы
                    hex = "DB";
                    break;
                case "5A": //ы
                    hex = "FB";
                    break;
                case "F3": //Ь
                    hex = "DC";
                    break;
                case "7A": //ь
                    hex = "FC";
                    break;
                case "F2": //Э
                    hex = "DD";
                    break;
                case "E1": //э
                    hex = "FD";
                    break;
                case "C0": //Ю
                    hex = "DE";
                    break;
                case "F9": //ю
                    hex = "FE";
                    break;
                case "EC": //Я
                    hex = "DF";
                    break;
                case "54": //я
                    hex = "FF";
                    break;
            }
            return hex;
        }
    }
}
