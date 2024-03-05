using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;

namespace ujlptr_subedit
{
    public class UjlTextPreviewRender : MonoGameControl
    {
        struct Letter
        {
            private Rectangle ujlRectangle;
            private Rectangle ptrRectangle;
            private int ujlOffset;
            private int ptrOffset;
            private int specialChar;

            public Rectangle GetUjlRectangle
            {
                get { return ujlRectangle; }
            }
            public Rectangle GetPtrRectangle
            {
                get { return ptrRectangle; }
            }
            public int GetUjlOffset
            {
                get { return ujlOffset; }
            }
            public int GetPtrOffset
            {
                get { return ptrOffset; }
            }
            public int GetSpecialChar
            {
                get { return specialChar; }
            }
            public Letter(int specialChar, Rectangle ujlRectangle = new Rectangle(), int ujlOffset = 0, Rectangle ptrRectangle = new Rectangle(), int ptrOffset = 0)
            {
                this.ujlRectangle = ujlRectangle;
                this.ptrRectangle = ptrRectangle;

                this.ujlOffset = ujlOffset;
                this.ptrOffset = ptrOffset;

                this.specialChar = specialChar;
            }
        }
        Dictionary<string, Letter> Letters = new Dictionary<string, Letter>();
        public string Hex = "54-65-73-74";
        public int IndexBg = 1;
        public int CurrentTextIndex = 0;
        public int MaxTextIndex = 0;
        Texture2D UjlFont;
        Texture2D PtrFont;
        Texture2D FontBg;
        SpriteFont SpriteFont;
        Texture2D Bg;
        public bool SwitchFonts = false;

        protected override void Initialize()
        {
            base.Initialize();

            LetterInit();
            UjlFont = Editor.Content.Load<Texture2D>("UJLFont");
            PtrFont = Editor.Content.Load<Texture2D>("PTRFont");
            FontBg = Editor.Content.Load<Texture2D>("FontBg");
            Bg = Editor.Content.Load<Texture2D>("BG");
            SpriteFont = Editor.Content.Load<SpriteFont>("Font");
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.Draw(Bg, new Vector2(0, 0), new Rectangle(320 * (IndexBg - 1), 0, 320, 240), Color.White);

            Editor.spriteBatch.Draw(FontBg, new Vector2(0, 0), new Rectangle(0, 0, 126, 18), Color.White);
            Editor.spriteBatch.DrawString(SpriteFont, $"{CurrentTextIndex + 1}of{MaxTextIndex}; bg{ IndexBg}", new Vector2(0, 0), Color.White);

            LetterDraw(Editor.spriteBatch);

            Editor.spriteBatch.End();
        }
        void LetterDraw(SpriteBatch sprite)
        {
            int yOffset = 193;

            List<int> totalLenght = new List<int>();
            List<Letter> letterList = new List<Letter>();
            if (CurrentTextIndex >= 0)
            {
                string hexId = Hex.Replace("-", "");
                int count = 0;
                int lenght = 0;
                for (int i = 0; i < hexId.Length / 2; i++)
                {
                    Letter let;
                    if (Letters.TryGetValue(hexId.Substring(i * 2, 2), out let))
                    {
                        switch (let.GetSpecialChar)
                        {
                            case 0 | 1:
                                lenght += let.GetPtrRectangle.Width - let.GetUjlOffset;
                                break;
                            case 2:
                                totalLenght.Add(lenght);
                                lenght = 0;
                                count = 0;
                                break;
                            case 3:
                                lenght += 8;
                                break;
                        }
                        letterList.Add(let);
                        count++;
                    }
                }
                totalLenght.Add(lenght);
            }


            int startPosition = 160 - (totalLenght[0] / 2);
            int line = 1;
            foreach (Letter letter in letterList)
            {
                switch (letter.GetSpecialChar)
                {
                    case 0:
                        if (!SwitchFonts) //ujl
                        {
                            sprite.Draw(UjlFont, new Vector2(startPosition - letter.GetUjlOffset, yOffset), letter.GetUjlRectangle, Color.White);

                            startPosition += letter.GetUjlRectangle.Width - letter.GetUjlOffset;
                        }
                        else //ptr
                        {
                            sprite.Draw(PtrFont, new Vector2(startPosition - letter.GetPtrOffset, yOffset), letter.GetPtrRectangle, Color.White);

                            startPosition += letter.GetPtrRectangle.Width - letter.GetPtrOffset;
                        }
                        break;
                    case 1:
                        if (!SwitchFonts) //ujl
                        {
                            sprite.Draw(UjlFont, new Vector2(startPosition - letter.GetUjlOffset, yOffset + 1), letter.GetUjlRectangle, Color.White);

                            startPosition += letter.GetUjlRectangle.Width - letter.GetUjlOffset;
                        }
                        else //ptr
                        {
                            sprite.Draw(PtrFont, new Vector2(startPosition - letter.GetPtrOffset, yOffset + 1), letter.GetPtrRectangle, Color.White);

                            startPosition += letter.GetPtrRectangle.Width - letter.GetPtrOffset;
                        }
                        break;
                    case 2:
                        startPosition = 160 - (totalLenght[0 + line] / 2);
                        line++;
                        yOffset += 15;
                        break;
                    case 3:
                        startPosition += 8;
                        break;
                }
            }
        }
        private void LetterInit()
        {
            Letters.Add("0A", new Letter(2)); //\n
            Letters.Add("20", new Letter(3)); // 

            Letters.Add("2C", new Letter(0, new Rectangle(7, 0, 7, 15), 0, new Rectangle(9, 0, 4, 15))); //,
            Letters.Add("2E", new Letter(0, new Rectangle(14, 0, 6, 15), 0, new Rectangle(16, 0, 4, 15))); //.
            Letters.Add("3F", new Letter(0, new Rectangle(26, 0, 10, 15), 0, new Rectangle(28, 0, 7, 15))); //?
            Letters.Add("21", new Letter(0, new Rectangle(36, 0, 8, 15), 0, new Rectangle(36, 0, 4, 15))); //!
            Letters.Add("5E", new Letter(0, new Rectangle(44, 0, 10, 15), 2, new Rectangle(40, 0, 7, 15))); //^
            Letters.Add("28", new Letter(0, new Rectangle(52, 0, 11, 15), 2, new Rectangle(49, 0, 6, 15))); //(
            Letters.Add("29", new Letter(0, new Rectangle(63, 0, 10, 15), 0, new Rectangle(56, 0, 5, 15))); //)
            Letters.Add("27", new Letter(0, new Rectangle(73, 0, 4, 15), 0, new Rectangle(62, 0, 4, 15))); //'
            Letters.Add("22", new Letter(0, new Rectangle(77, 0, 7, 15), 0, new Rectangle(67, 0, 7, 15))); //"
            Letters.Add("2D", new Letter(0, new Rectangle(84, 0, 7, 15), 0, new Rectangle(75, 0, 5, 15))); //-
            Letters.Add("24", new Letter(0, new Rectangle(91, 0, 9, 15), 0, new Rectangle(81, 0, 8, 15))); //$
            Letters.Add("25", new Letter(0, new Rectangle(100, 0, 11, 15), 0, new Rectangle(89, 0, 12, 15))); //%
            Letters.Add("23", new Letter(0, new Rectangle(111, 0, 13, 15), 0, new Rectangle(101, 0, 11, 15))); //#
            Letters.Add("26", new Letter(0, new Rectangle(124, 0, 11, 15), 0, new Rectangle(112, 0, 9, 15))); //&
            Letters.Add("2A", new Letter(0, new Rectangle(135, 0, 10, 15), 0, new Rectangle(123, 0, 9, 15))); //*
            Letters.Add("40", new Letter(0, new Rectangle(0, 75, 13, 15), 0, new Rectangle(238, 45, 11, 15))); //@
            Letters.Add("3B", new Letter(0, new Rectangle(18, 75, 9, 15), 0, new Rectangle(1, 60, 3, 15))); //;
            Letters.Add("3A", new Letter(0, new Rectangle(27, 75, 7, 15), 0, new Rectangle(6, 60, 3, 15))); //:

            Letters.Add("30", new Letter(0, new Rectangle(145, 0, 10, 15), 0, new Rectangle(132, 0, 8, 15))); //0
            Letters.Add("31", new Letter(0, new Rectangle(155, 0, 6, 15), 0, new Rectangle(142, 0, 3, 15))); //1
            Letters.Add("32", new Letter(0, new Rectangle(161, 0, 9, 15), 2, new Rectangle(147, 0, 6, 15))); //2
            Letters.Add("33", new Letter(0, new Rectangle(170, 0, 9, 15), 0, new Rectangle(153, 0, 8, 15))); //3
            Letters.Add("34", new Letter(0, new Rectangle(179, 0, 9, 15), 0, new Rectangle(161, 0, 8, 15))); //4
            Letters.Add("35", new Letter(0, new Rectangle(188, 0, 10, 15), 0, new Rectangle(169, 0, 8, 15))); //5
            Letters.Add("36", new Letter(0, new Rectangle(198, 0, 10, 15), 0, new Rectangle(177, 0, 8, 15))); //6
            Letters.Add("37", new Letter(0, new Rectangle(208, 0, 9, 15), 0, new Rectangle(185, 0, 8, 15))); //7
            Letters.Add("38", new Letter(0, new Rectangle(217, 0, 10, 15), 0, new Rectangle(193, 0, 9, 15))); //8
            Letters.Add("39", new Letter(0, new Rectangle(227, 0, 8, 15), 0, new Rectangle(202, 0, 7, 15))); //9

            Letters.Add("E1", new Letter(0, new Rectangle(229, 30, 9, 15))); //э
            Letters.Add("E0", new Letter(0, new Rectangle(238, 30, 10, 15))); //ф
            Letters.Add("E9", new Letter(0, new Rectangle(19, 45, 9, 15))); //Ч
            Letters.Add("E8", new Letter(0, new Rectangle(28, 45, 9, 15))); //Ц
            Letters.Add("EA", new Letter(0, new Rectangle(38, 45, 10, 15))); //Х
            Letters.Add("EB", new Letter(0, new Rectangle(48, 45, 11, 15))); //Д
            Letters.Add("ED", new Letter(0, new Rectangle(59, 45, 7, 15))); //х
            Letters.Add("EC", new Letter(0, new Rectangle(66, 45, 9, 15))); //Я
            Letters.Add("EE", new Letter(0, new Rectangle(75, 45, 9, 15))); //У
            Letters.Add("EF", new Letter(0, new Rectangle(84, 45, 9, 15))); //Ъ
            Letters.Add("F3", new Letter(0, new Rectangle(93, 45, 8, 15))); //Ь
            Letters.Add("F2", new Letter(0, new Rectangle(101, 45, 10, 15))); //Э
            Letters.Add("F4", new Letter(0, new Rectangle(111, 45, 9, 15))); //Т
            Letters.Add("F6", new Letter(0, new Rectangle(120, 45, 10, 15))); //Л
            Letters.Add("FA", new Letter(0, new Rectangle(130, 45, 9, 15))); //С
            Letters.Add("F9", new Letter(0, new Rectangle(139, 45, 10, 15))); //ю
            Letters.Add("E7", new Letter(0, new Rectangle(179, 45, 9, 15))); //З
            Letters.Add("DF", new Letter(0, new Rectangle(213, 45, 12, 15))); //Ы
            Letters.Add("9C", new Letter(0, new Rectangle(225, 45, 13, 15))); //Щ
            Letters.Add("C0", new Letter(0, new Rectangle(28, 60, 12, 15))); //Ю

            Letters.Add("41", new Letter(0, new Rectangle(236, 0, 10, 15), 0, new Rectangle(209, 0, 8, 15))); //A
            Letters.Add("61", new Letter(1, new Rectangle(245, 15, 9, 15), 1, new Rectangle(162, 15, 8, 15))); //a
            Letters.Add("42", new Letter(0, new Rectangle(245, 0, 9, 15), 1, new Rectangle(217, 0, 9, 15))); //B
            Letters.Add("62", new Letter(1, new Rectangle(0, 30, 9, 15), 0, new Rectangle(170, 15, 8, 15))); //b
            Letters.Add("43", new Letter(0, new Rectangle(0, 15, 9, 15), 0, new Rectangle(226, 0, 7, 15))); //C
            Letters.Add("63", new Letter(1, new Rectangle(8, 30, 9, 15), 1, new Rectangle(178, 15, 7, 15))); //c
            Letters.Add("44", new Letter(0, new Rectangle(8, 15, 10, 15), 1, new Rectangle(233, 0, 7, 15))); //D
            Letters.Add("64", new Letter(1, new Rectangle(17, 30, 11, 15), 0, new Rectangle(185, 15, 8, 15))); //d
            Letters.Add("45", new Letter(0, new Rectangle(18, 15, 10, 15), 1, new Rectangle(240, 0, 6, 15))); //E
            Letters.Add("65", new Letter(1, new Rectangle(28, 30, 8, 15), 1, new Rectangle(193, 15, 7, 15))); //e
            Letters.Add("46", new Letter(0, new Rectangle(28, 15, 12, 15), 1, new Rectangle(246, 0, 8, 15))); //F
            Letters.Add("66", new Letter(1, new Rectangle(36, 30, 10, 15), 0, new Rectangle(200, 15, 7, 15))); //f
            Letters.Add("47", new Letter(0, new Rectangle(40, 15, 9, 15), 2, new Rectangle(0, 15, 8, 15))); //G
            Letters.Add("67", new Letter(1, new Rectangle(46, 30, 9, 15), 2, new Rectangle(207, 15, 7, 15))); //g
            Letters.Add("48", new Letter(0, new Rectangle(49, 15, 11, 15), 1, new Rectangle(8, 15, 7, 15))); //H
            Letters.Add("68", new Letter(1, new Rectangle(55, 30, 8, 15), 2, new Rectangle(214, 15, 8, 15))); //h
            Letters.Add("49", new Letter(0, new Rectangle(60, 15, 10, 15), 1, new Rectangle(15, 15, 7, 15))); //I
            Letters.Add("69", new Letter(1, new Rectangle(63, 30, 7, 15), 0, new Rectangle(223, 15, 3, 15))); //i
            Letters.Add("4A", new Letter(0, new Rectangle(70, 15, 10, 15), 1, new Rectangle(22, 15, 7, 15))); //J
            Letters.Add("6A", new Letter(1, new Rectangle(70, 30, 8, 15), 1, new Rectangle(227, 15, 5, 15))); //j
            Letters.Add("4B", new Letter(0, new Rectangle(80, 15, 10, 15), 1, new Rectangle(29, 15, 7, 15))); //K
            Letters.Add("6B", new Letter(1, new Rectangle(78, 30, 9, 15), 0, new Rectangle(233, 15, 6, 15))); //k
            Letters.Add("4C", new Letter(0, new Rectangle(90, 15, 8, 15), 1, new Rectangle(37, 15, 7, 15))); //L
            Letters.Add("6C", new Letter(1, new Rectangle(87, 30, 7, 15), 1, new Rectangle(239, 15, 3, 15))); //l
            Letters.Add("4D", new Letter(0, new Rectangle(98, 15, 13, 15), 0, new Rectangle(44, 15, 11, 15))); //M
            Letters.Add("6D", new Letter(1, new Rectangle(94, 30, 11, 15), 1, new Rectangle(243, 15, 8, 15))); //m
            Letters.Add("4E", new Letter(0, new Rectangle(112, 15, 10, 15), 1, new Rectangle(55, 15, 8, 15))); //N
            Letters.Add("6E", new Letter(1, new Rectangle(105, 30, 8, 15), 0, new Rectangle(0, 30, 7, 15))); //n
            Letters.Add("4F", new Letter(0, new Rectangle(122, 15, 10, 15), 1, new Rectangle(63, 15, 8, 15))); //O
            Letters.Add("6F", new Letter(1, new Rectangle(113, 30, 8, 15), 0, new Rectangle(7, 30, 7, 15))); //o
            Letters.Add("50", new Letter(0, new Rectangle(132, 15, 11, 15), 1, new Rectangle(71, 15, 8, 15))); //P
            Letters.Add("70", new Letter(1, new Rectangle(121, 30, 9, 15), 0, new Rectangle(14, 30, 7, 15))); //p
            Letters.Add("51", new Letter(0, new Rectangle(143, 15, 11, 15), 1, new Rectangle(79, 15, 9, 15))); //Q
            Letters.Add("71", new Letter(1, new Rectangle(130, 30, 8, 15), 0, new Rectangle(21, 30, 7, 15))); //q
            Letters.Add("52", new Letter(0, new Rectangle(154, 15, 9, 15), 1, new Rectangle(88, 15, 8, 15))); //R
            Letters.Add("72", new Letter(1, new Rectangle(138, 30, 8, 15), 0, new Rectangle(28, 30, 7, 15))); //r
            Letters.Add("53", new Letter(0, new Rectangle(163, 15, 9, 15), 1, new Rectangle(96, 15, 7, 15))); //S
            Letters.Add("73", new Letter(1, new Rectangle(146, 30, 8, 15), 0, new Rectangle(35, 30, 8, 15))); //s
            Letters.Add("54", new Letter(0, new Rectangle(172, 15, 9, 15), 1, new Rectangle(103, 15, 7, 15))); //T
            Letters.Add("74", new Letter(1, new Rectangle(154, 30, 8, 15), 0, new Rectangle(43, 30, 7, 15))); //t
            Letters.Add("55", new Letter(0, new Rectangle(181, 15, 10, 15), 2, new Rectangle(110, 15, 7, 15))); //U
            Letters.Add("75", new Letter(1, new Rectangle(162, 30, 8, 15), 1, new Rectangle(50, 30, 8, 15))); //u
            Letters.Add("56", new Letter(0, new Rectangle(191, 15, 10, 15), 1, new Rectangle(117, 15, 9, 15))); //V
            Letters.Add("76", new Letter(1, new Rectangle(170, 30, 8, 15), 0, new Rectangle(58, 30, 8, 15))); //v
            Letters.Add("57", new Letter(0, new Rectangle(201, 15, 13, 15), 0, new Rectangle(126, 15, 11, 15))); //W
            Letters.Add("77", new Letter(1, new Rectangle(178, 30, 11, 15), 0, new Rectangle(66, 30, 9, 15))); //w
            Letters.Add("58", new Letter(0, new Rectangle(214, 15, 11, 15), 2, new Rectangle(137, 15, 8, 15))); //X
            Letters.Add("78", new Letter(1, new Rectangle(189, 30, 9, 15), 0, new Rectangle(75, 30, 7, 15))); //x
            Letters.Add("59", new Letter(0, new Rectangle(225, 15, 9, 15), 1, new Rectangle(145, 15, 9, 15))); //Y
            Letters.Add("79", new Letter(1, new Rectangle(198, 30, 10, 15), 0, new Rectangle(82, 30, 8, 15))); //y
            Letters.Add("5A", new Letter(0, new Rectangle(234, 15, 11, 15), 1, new Rectangle(154, 15, 8, 15))); //Z
            Letters.Add("7A", new Letter(1, new Rectangle(208, 30, 9, 15), 0, new Rectangle(90, 30, 9, 15))); //z
        }
    }
}
