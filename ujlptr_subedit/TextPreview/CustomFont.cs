using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.IO;

namespace ujlptr_subedit.TextPreview
{
    public static class CustomFont
    {
        public static List<CFont> Fonts = new List<CFont>();

        public enum CharType
        {
            upper,
            lower,
            newline,
            space
        }
        public struct CFont
        {
            public string Name;
            public Dictionary<string, Letter> Letters;

            public CFont(string Name, Dictionary<string, Letter> Letters)
            {
                this.Name = Name;
                this.Letters = Letters;
            }
        }
        public class Letter
        {
            public Rectangle LetterRectangle;
            public int LetterOffset;
            public CharType CharType;
            public string LetterHex;

            public Letter() { }
            public Letter(CharType charType, string letterHex, Rectangle letterRectangle = new Rectangle(), int letterOffset = 0)
            {
                LetterRectangle = letterRectangle;

                LetterOffset = letterOffset;

                CharType = charType;

                LetterHex = letterHex;
            }
        }

        public static void ReloadFonts()
        {
            Fonts.Clear();
            XmlSerializer serializer =  new XmlSerializer(typeof(List<Letter>));

            foreach (string file in Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}/Content"))
            {
                if (Path.GetExtension(file).ToLower().Contains("xml"))
                {
                    List<Letter> lettersList = new List<Letter>();

                    try
                    {
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            lettersList = serializer.Deserialize(fs) as List<Letter>;
                        }
                    }
                    finally
                    {
                        Dictionary<string, Letter> dicLetters = new Dictionary<string, Letter>();
                        foreach (Letter letter in lettersList)
                        {
                            dicLetters.Add(letter.LetterHex, letter);
                        }
                        Fonts.Add(new CFont(Path.GetFileNameWithoutExtension(file), dicLetters));
                    }
                }
            }
        }
        public static void Save(CFont cFont)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Letter>));

            using (FileStream fs = new FileStream($"{AppDomain.CurrentDomain.BaseDirectory}/Content/{cFont.Name}.xml", FileMode.Create))
            {
                serializer.Serialize(fs, cFont.Letters.Values.ToList());
            }
        }
    }
}
