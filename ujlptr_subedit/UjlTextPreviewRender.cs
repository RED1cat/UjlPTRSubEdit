using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;

namespace ujlptr_subedit
{
    internal class UjlTextPreviewRender : MonoGameControl
    {
        class Letter
        {
            private Rectangle rectangle = Rectangle.Empty;
            private int offset = 0;
            private int specialChar;

            public Rectangle L_Rectangle
            {
                get { return rectangle; }
            }
            public int L_Offset
            {
                get { return offset; }
            }
            public int L_SpecialChar
            {
                get { return specialChar; }
            }
            public Letter(int specialChar, Rectangle rectangle = new Rectangle(), int offset = 0)
            {
                this.rectangle = rectangle;
                this.offset = offset;
                this.specialChar = specialChar;
            }
        }
        Dictionary<string, Letter> m_Letters = new Dictionary<string, Letter>();
        public string[] m_Hex = new string[2] { "54-65-73-74", "54-65-73-74" };
        int m_IndexBg = 1;
        public int m_TextIndex = 0;
        bool m_KeySpaceIsPressed = false;
        bool m_KeyLeftIsPressed = false;
        bool m_KeyRightIsPressed = false;
        Texture2D m_AlfaFont;
        Texture2D m_FontBg;
        SpriteFont m_SpriteFont;
        Texture2D m_Bg1;
        Texture2D m_Bg2;
        Texture2D m_Bg3;

        protected override void Initialize()
        {
            base.Initialize();

            LetterInit();
            m_AlfaFont = Editor.Content.Load<Texture2D>("alfa-font");
            m_FontBg = Editor.Content.Load<Texture2D>("fontBg");
            m_Bg1 = Editor.Content.Load<Texture2D>("bg1");
            m_Bg2 = Editor.Content.Load<Texture2D>("bg2");
            m_Bg3 = Editor.Content.Load<Texture2D>("bg3");
            m_SpriteFont = Editor.Content.Load<SpriteFont>("File");
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && m_KeySpaceIsPressed == false)
            {
                if (m_IndexBg == 3)
                {
                    m_IndexBg = 1;
                }
                else
                {
                    m_IndexBg++;
                }
                m_KeySpaceIsPressed = true;
            }
            else if (Keyboard.GetState().IsKeyUp(Keys.Space))
            {
                m_KeySpaceIsPressed = false;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left) && m_KeyLeftIsPressed == false && m_TextIndex != -1)
            {
                m_KeyLeftIsPressed = true;
                if (m_TextIndex == 0)
                {
                    m_TextIndex = m_Hex.Length - 1;
                }
                else
                {
                    m_TextIndex--;
                }
            }
            else if (Keyboard.GetState().IsKeyUp(Keys.Left) && m_TextIndex != -1)
            {
                m_KeyLeftIsPressed = false;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right) && m_KeyRightIsPressed == false && m_TextIndex != -1)
            {
                m_KeyRightIsPressed = true;
                if (m_TextIndex == m_Hex.Length - 1)
                {
                    m_TextIndex = 0;
                }
                else
                {
                    m_TextIndex++;
                }
            }
            else if (Keyboard.GetState().IsKeyUp(Keys.Right) && m_TextIndex != -1)
            {
                m_KeyRightIsPressed = false;
            }
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            switch (m_IndexBg)
            {
                case 1:
                    Editor.spriteBatch.Draw(m_Bg1, new Vector2(0, 0), Color.White);
                    break;
                case 2:
                    Editor.spriteBatch.Draw(m_Bg2, new Vector2(0, 0), Color.White);
                    break;
                case 3:
                    Editor.spriteBatch.Draw(m_Bg3, new Vector2(0, 0), Color.White);
                    break;
            }

            Editor.spriteBatch.Draw(m_FontBg, new Vector2(0, 0), new Rectangle(0, 0, 126, 18), Color.White);
            Editor.spriteBatch.DrawString(m_SpriteFont, (m_TextIndex + 1).ToString() + "of" + m_Hex.Length.ToString() + "; bg" + m_IndexBg.ToString(), new Vector2(0, 0), Color.White);

            LetterDraw(Editor.spriteBatch);

            Editor.spriteBatch.End();
        }
        void LetterDraw(SpriteBatch sprite)
        {
            int yOffset = 193;

            List<int> totalLenght = new List<int>();
            List<Letter> letterList = new List<Letter>();
            if (m_TextIndex >= 0)
            {
                string hexId = m_Hex[m_TextIndex].Replace("-", "");
                int count = 0;
                int lenght = 0;
                for (int i = 0; i < hexId.Length / 2; i++)
                {
                    Letter let;
                    if (m_Letters.TryGetValue(hexId.Substring(i * 2, 2), out let))
                    {
                        switch (let.L_SpecialChar)
                        {
                            case 0 | 1:
                                lenght += let.L_Rectangle.Width - let.L_Offset;
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
                switch (letter.L_SpecialChar)
                {
                    case 0:
                        sprite.Draw(m_AlfaFont, new Vector2(startPosition - letter.L_Offset, yOffset), letter.L_Rectangle, Color.White);

                        startPosition += letter.L_Rectangle.Width - letter.L_Offset;
                        break;
                    case 1:
                        sprite.Draw(m_AlfaFont, new Vector2(startPosition - letter.L_Offset, yOffset + 1), letter.L_Rectangle, Color.White);

                        startPosition += letter.L_Rectangle.Width - letter.L_Offset;
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
            m_Letters.Add("0A", new Letter(2));
            m_Letters.Add("20", new Letter(3));

            m_Letters.Add("2C", new Letter(0, new Rectangle(7, 0, 7, 15))); //,
            m_Letters.Add("2E", new Letter(0, new Rectangle(14, 0, 6, 15))); //.
            m_Letters.Add("3F", new Letter(0, new Rectangle(26, 0, 10, 15))); //?
            m_Letters.Add("21", new Letter(0, new Rectangle(36, 0, 8, 15))); //!
            m_Letters.Add("5E", new Letter(0, new Rectangle(44, 0, 10, 15), 2)); //^
            m_Letters.Add("28", new Letter(0, new Rectangle(52, 0, 11, 15), 2)); //(
            m_Letters.Add("29", new Letter(0, new Rectangle(63, 0, 10, 15))); //)
            m_Letters.Add("27", new Letter(0, new Rectangle(73, 0, 4, 15))); //'
            m_Letters.Add("22", new Letter(0, new Rectangle(77, 0, 7, 15))); //"
            m_Letters.Add("2D", new Letter(0, new Rectangle(84, 0, 7, 15))); //-
            m_Letters.Add("24", new Letter(0, new Rectangle(91, 0, 9, 15))); //$
            m_Letters.Add("25", new Letter(0, new Rectangle(100, 0, 11, 15))); //%
            m_Letters.Add("23", new Letter(0, new Rectangle(111, 0, 13, 15))); //#
            m_Letters.Add("26", new Letter(0, new Rectangle(124, 0, 11, 15))); //&
            m_Letters.Add("2A", new Letter(0, new Rectangle(135, 0, 10, 15))); //*
            m_Letters.Add("40", new Letter(0, new Rectangle(0, 75, 13, 15))); //@
            m_Letters.Add("3B", new Letter(0, new Rectangle(18, 75, 9, 15))); //;
            m_Letters.Add("3A", new Letter(0, new Rectangle(27, 75, 7, 15))); //:

            m_Letters.Add("30", new Letter(0, new Rectangle(145, 0, 10, 15))); //0
            m_Letters.Add("31", new Letter(0, new Rectangle(155, 0, 6, 15))); //1
            m_Letters.Add("32", new Letter(0, new Rectangle(161, 0, 9, 15), 2)); //2
            m_Letters.Add("33", new Letter(0, new Rectangle(170, 0, 9, 15))); //3
            m_Letters.Add("34", new Letter(0, new Rectangle(179, 0, 9, 15))); //4
            m_Letters.Add("35", new Letter(0, new Rectangle(188, 0, 10, 15))); //5
            m_Letters.Add("36", new Letter(0, new Rectangle(198, 0, 10, 15))); //6
            m_Letters.Add("37", new Letter(0, new Rectangle(208, 0, 9, 15))); //7
            m_Letters.Add("38", new Letter(0, new Rectangle(217, 0, 10, 15))); //8
            m_Letters.Add("39", new Letter(0, new Rectangle(227, 0, 8, 15))); //9

            m_Letters.Add("E1", new Letter(0, new Rectangle(229, 30, 9, 15))); //э
            m_Letters.Add("E0", new Letter(0, new Rectangle(238, 30, 10, 15))); //ф
            m_Letters.Add("E9", new Letter(0, new Rectangle(19, 45, 9, 15))); //Ч
            m_Letters.Add("E8", new Letter(0, new Rectangle(28, 45, 9, 15))); //Ц
            m_Letters.Add("EA", new Letter(0, new Rectangle(38, 45, 10, 15))); //Х
            m_Letters.Add("EB", new Letter(0, new Rectangle(48, 45, 11, 15))); //Д
            m_Letters.Add("ED", new Letter(0, new Rectangle(59, 45, 7, 15))); //х
            m_Letters.Add("EC", new Letter(0, new Rectangle(66, 45, 9, 15))); //Я
            m_Letters.Add("EE", new Letter(0, new Rectangle(75, 45, 9, 15))); //У
            m_Letters.Add("EF", new Letter(0, new Rectangle(84, 45, 9, 15))); //Ъ
            m_Letters.Add("F3", new Letter(0, new Rectangle(93, 45, 8, 15))); //Ь
            m_Letters.Add("F2", new Letter(0, new Rectangle(101, 45, 10, 15))); //Э
            m_Letters.Add("F4", new Letter(0, new Rectangle(111, 45, 9, 15))); //Т
            m_Letters.Add("F6", new Letter(0, new Rectangle(120, 45, 10, 15))); //Л
            m_Letters.Add("FA", new Letter(0, new Rectangle(130, 45, 9, 15))); //С
            m_Letters.Add("F9", new Letter(0, new Rectangle(139, 45, 10, 15))); //ю
            m_Letters.Add("E7", new Letter(0, new Rectangle(179, 45, 9, 15))); //З
            m_Letters.Add("DF", new Letter(0, new Rectangle(213, 45, 12, 15))); //Ы
            m_Letters.Add("9C", new Letter(0, new Rectangle(225, 45, 13, 15))); //Щ
            m_Letters.Add("C0", new Letter(0, new Rectangle(28, 60, 12, 15))); //Ю

            m_Letters.Add("41", new Letter(0, new Rectangle(236, 0, 10, 15))); //A
            m_Letters.Add("61", new Letter(1, new Rectangle(245, 15, 9, 15), 1)); //a
            m_Letters.Add("42", new Letter(0, new Rectangle(245, 0, 9, 15), 1)); //B
            m_Letters.Add("62", new Letter(1, new Rectangle(0, 30, 9, 15))); //b
            m_Letters.Add("43", new Letter(0, new Rectangle(0, 15, 9, 15))); //C
            m_Letters.Add("63", new Letter(1, new Rectangle(8, 30, 9, 15), 1)); //c
            m_Letters.Add("44", new Letter(0, new Rectangle(8, 15, 10, 15), 1)); //D
            m_Letters.Add("64", new Letter(1, new Rectangle(17, 30, 11, 15))); //d
            m_Letters.Add("45", new Letter(0, new Rectangle(18, 15, 10, 15), 1)); //E
            m_Letters.Add("65", new Letter(1, new Rectangle(28, 30, 8, 15), 1)); //e
            m_Letters.Add("46", new Letter(0, new Rectangle(28, 15, 12, 15), 1)); //F
            m_Letters.Add("66", new Letter(1, new Rectangle(36, 30, 10, 15))); //f
            m_Letters.Add("47", new Letter(0, new Rectangle(40, 15, 9, 15), 2)); //G
            m_Letters.Add("67", new Letter(1, new Rectangle(46, 30, 9, 15), 2)); //g
            m_Letters.Add("48", new Letter(0, new Rectangle(49, 15, 11, 15), 1)); //H
            m_Letters.Add("68", new Letter(1, new Rectangle(55, 30, 8, 15), 2)); //h
            m_Letters.Add("49", new Letter(0, new Rectangle(60, 15, 10, 15), 1)); //I
            m_Letters.Add("69", new Letter(1, new Rectangle(63, 30, 7, 15))); //i
            m_Letters.Add("4A", new Letter(0, new Rectangle(70, 15, 10, 15), 1)); //J
            m_Letters.Add("6A", new Letter(1, new Rectangle(70, 30, 8, 15), 1)); //j
            m_Letters.Add("4B", new Letter(0, new Rectangle(80, 15, 10, 15), 1)); //K
            m_Letters.Add("6B", new Letter(1, new Rectangle(78, 30, 9, 15))); //k
            m_Letters.Add("4C", new Letter(0, new Rectangle(90, 15, 8, 15), 1)); //L
            m_Letters.Add("6C", new Letter(1, new Rectangle(87, 30, 7, 15), 1)); //l
            m_Letters.Add("4D", new Letter(0, new Rectangle(98, 15, 13, 15))); //M
            m_Letters.Add("6D", new Letter(1, new Rectangle(94, 30, 11, 15), 1)); //m
            m_Letters.Add("4E", new Letter(0, new Rectangle(112, 15, 10, 15), 1)); //N
            m_Letters.Add("6E", new Letter(1, new Rectangle(105, 30, 8, 15))); //n
            m_Letters.Add("4F", new Letter(0, new Rectangle(122, 15, 10, 15), 1)); //O
            m_Letters.Add("6F", new Letter(1, new Rectangle(113, 30, 8, 15))); //o
            m_Letters.Add("50", new Letter(0, new Rectangle(132, 15, 11, 15), 1)); //P
            m_Letters.Add("70", new Letter(1, new Rectangle(121, 30, 9, 15))); //p
            m_Letters.Add("51", new Letter(0, new Rectangle(143, 15, 11, 15), 1)); //Q
            m_Letters.Add("71", new Letter(1, new Rectangle(130, 30, 8, 15))); //q
            m_Letters.Add("52", new Letter(0, new Rectangle(154, 15, 9, 15), 1)); //R
            m_Letters.Add("72", new Letter(1, new Rectangle(138, 30, 8, 15))); //r
            m_Letters.Add("53", new Letter(0, new Rectangle(163, 15, 9, 15), 1)); //S
            m_Letters.Add("73", new Letter(1, new Rectangle(146, 30, 8, 15))); //s
            m_Letters.Add("54", new Letter(0, new Rectangle(172, 15, 9, 15), 1)); //T
            m_Letters.Add("74", new Letter(1, new Rectangle(154, 30, 8, 15))); //t
            m_Letters.Add("55", new Letter(0, new Rectangle(181, 15, 10, 15), 2)); //U
            m_Letters.Add("75", new Letter(1, new Rectangle(162, 30, 8, 15), 1)); //u
            m_Letters.Add("56", new Letter(0, new Rectangle(191, 15, 10, 15), 1)); //V
            m_Letters.Add("76", new Letter(1, new Rectangle(170, 30, 8, 15))); //v
            m_Letters.Add("57", new Letter(0, new Rectangle(201, 15, 13, 15))); //W
            m_Letters.Add("77", new Letter(1, new Rectangle(178, 30, 11, 15))); //w
            m_Letters.Add("58", new Letter(0, new Rectangle(214, 15, 11, 15), 2)); //X
            m_Letters.Add("78", new Letter(1, new Rectangle(189, 30, 9, 15))); //x
            m_Letters.Add("59", new Letter(0, new Rectangle(225, 15, 9, 15), 1)); //Y
            m_Letters.Add("79", new Letter(1, new Rectangle(198, 30, 10, 15))); //y
            m_Letters.Add("5A", new Letter(0, new Rectangle(234, 15, 11, 15), 1)); //Z
            m_Letters.Add("7A", new Letter(1, new Rectangle(208, 30, 9, 15))); //z
        }
    }
}
