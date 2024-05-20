using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Forms.Controls;

namespace ujlptr_subedit.TextPreview
{
    public class TextPreviewRender : MonoGameControl
    {
        public bool init = false;
        public string Hex = "54-65-73-74";
        public int BgIndex = 0;
        public int FontIndex = 0;
        public int CurrentTextIndex = 0;
        public int MaxTextIndex = 0;
        Texture2D GameFont;
        Texture2D FontBg;
        SpriteFont SpriteFont;
        Texture2D Bg;

        protected override void Initialize()
        {
            base.Initialize();
            init = true;

            SwitchFont(0);

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

            Editor.spriteBatch.Draw(Bg, new Vector2(0, 0), new Rectangle(320 * BgIndex, 0, 320, 240), Color.White);

            Editor.spriteBatch.Draw(FontBg, new Vector2(0, 0), new Rectangle(0, 0, 126, 18), Color.White);
            Editor.spriteBatch.DrawString(SpriteFont, $"{CurrentTextIndex + 1}of{MaxTextIndex}; bg{BgIndex + 1}", new Vector2(0, 0), Color.White);

            LetterDraw(Editor.spriteBatch);

            Editor.spriteBatch.End();
        }
        public void SwitchFont(int fontIndex)
        {
            if(CustomFont.Fonts.Count > 0 && File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}/Content/{CustomFont.Fonts[fontIndex].Name}.png"))
            {
                using(FileStream fs = new FileStream($"{AppDomain.CurrentDomain.BaseDirectory}/Content/{CustomFont.Fonts[fontIndex].Name}.png", FileMode.Open))
                {
                    GameFont = Texture2D.FromStream(GraphicsDevice, fs);
                    FontIndex = fontIndex;
                }
            }
        }


        void LetterDraw(SpriteBatch sprite)
        {
            string hex = Hex.Replace("-", "");

            List<CustomFont.Letter> letters = new List<CustomFont.Letter>();
            List<int> linesLength = new List<int>();
            int lineLength = 0;
            for (int i = 0; i < hex.Length / 2; i++)
            {
                if (CustomFont.Fonts[FontIndex].Letters.TryGetValue(hex.Substring(i * 2, 2), out CustomFont.Letter letter))
                {
                    letters.Add(letter);

                    lineLength += letter.LetterRectangle.Width;

                    if (letter.CharType == CustomFont.CharType.newline)
                    {
                        linesLength.Add(lineLength);
                        lineLength = 0;
                    }
                }
            }
            linesLength.Add(lineLength);

            if (linesLength.Count > 0) 
            {
                int line = 0;
                int yOffset = 193;
                int xOffset = 160 - (linesLength[line] / 2);
                foreach (CustomFont.Letter letter in letters)
                {
                    switch (letter.CharType)
                    {
                        case CustomFont.CharType.upper:
                            sprite.Draw(GameFont, new Vector2(xOffset - letter.LetterOffset, yOffset), letter.LetterRectangle, Color.White);
                            xOffset += letter.LetterRectangle.Width - letter.LetterOffset;
                            break;
                        case CustomFont.CharType.lower:
                            sprite.Draw(GameFont, new Vector2(xOffset - letter.LetterOffset, yOffset + 1), letter.LetterRectangle, Color.White);
                            xOffset += letter.LetterRectangle.Width - letter.LetterOffset;
                            break;
                        case CustomFont.CharType.newline:
                            sprite.Draw(GameFont, new Vector2(xOffset - letter.LetterOffset, yOffset), letter.LetterRectangle, Color.White);
                            line++;
                            if(line + 1 <= linesLength.Count)
                            {
                                xOffset = 160 - (linesLength[line] / 2);
                                yOffset += 15;
                            }
                            break;
                        case CustomFont.CharType.space:
                            sprite.Draw(GameFont, new Vector2(xOffset - letter.LetterOffset, yOffset), letter.LetterRectangle, Color.White);
                            xOffset += letter.LetterRectangle.Width - letter.LetterOffset;
                            break;
                    }
                }
            }
        }
    }
}