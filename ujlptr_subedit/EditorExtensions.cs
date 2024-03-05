using System;
using System.Collections.Generic;
using System.Text;

namespace ujlptr_subedit
{
    static class EditorExtensions
    {
        public static string ConvertTextToHex(this string text, Encoding codePage, Dictionary<string, string> hexConverter = null)
        {
            string hex = BitConverter.ToString(codePage.GetBytes(text)).Replace("-", "");
            string outHex = "";

            for (int i = 0; i < hex.Length / 2; i++)
            {
                if (hexConverter != null)
                {
                    if (hexConverter.ContainsKey(hex.Substring(i * 2, 2)))
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

        public static string ConvertHexToText(this string text, Encoding codePage)
        {
            byte[] raw = new byte[text.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return codePage.GetString(raw);
        }

        public static string ConvertTextFromPattern(this string text, Encoding codePage, Dictionary<string, string> hexConverter)
        {
            if (hexConverter != null)
            {
                return text.ConvertTextToHex(codePage, hexConverter).ConvertHexToText(codePage);
            }
            return text;
        }

        public static string GetTextFromAddress(this int address, byte[] file, Encoding codePage)
        {
            int count = 0;
            bool StopFlag = false;
            while (true)
            {
                if (address + count == file.Length)
                {
                    break;
                }
                if (file[address + count] == 0x00)
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

            return codePage.GetString(file, address, count);
        }
        public static int GetTextLegthFromAddress(this int address, byte[] file)
        {
            int count = 0;
            bool StopFlag = false;
            while (true)
            {
                if (address + count == file.Length)
                {
                    break;
                }
                if (file[address + count] == 0x00)
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

            return count;
        }
    }
}
