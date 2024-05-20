using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace ujlptr_subedit.TextPreview
{
    public partial class FontConstructor : Form
    {
        public FontConstructor()
        {
            InitializeComponent();

            ReloadUI();
        }
        private void ReloadUI()
        {
            Font_listView.Items.Clear();
            Font_comboBox.Items.Clear();

            Name_textBox.Text = "";
            Font_comboBox.Text = "";
            Hex_textBox.Text = "";
            Offset_textBox.Text = "";
            X_textBox.Text = "";
            Y_textBox.Text = "";
            Width_textBox.Text = "";
            Hex_textBox.Text = "";
            CharType_comboBox.Text = "";

            Modify_button.Enabled = false;
            SaveFont_button.Enabled = false;

            CustomFont.ReloadFonts();

            foreach (CustomFont.CFont font in CustomFont.Fonts)
            {
                Font_comboBox.Items.Add(font.Name);
            }
        }

        private void Font_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Font_listView.SelectedItems.Count > 0 && Font_listView.SelectedItems[0] != null)
            {
                Modify_button.Enabled = true;

                ListViewItem item = Font_listView.SelectedItems[0];

                Hex_textBox.Text = item.SubItems[1].Text;
                Offset_textBox.Text = item.SubItems[2].Text;
                X_textBox.Text = item.SubItems[3].Text;
                Y_textBox.Text = item.SubItems[4].Text;
                Width_textBox.Text = item.SubItems[5].Text;
                Height_textBox.Text = item.SubItems[6].Text;

                CustomFont.CharType chartype;

                Enum.TryParse(item.SubItems[7].Text, out chartype);

                CharType_comboBox.SelectedIndex = (int)chartype;
            }
            else
            {
                Modify_button.Enabled = false;
            }
        }

        private void Font_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Font_comboBox.Items.Count > 0 && CustomFont.Fonts.Count > 0)
            {
                foreach(CustomFont.CFont font in CustomFont.Fonts)
                {
                    if(font.Name == Font_comboBox.SelectedItem.ToString())
                    {
                        SaveFont_button.Enabled = true;
                        Font_listView.Items.Clear();
                        int id = 1;
                        foreach(var letter in font.Letters)
                        {
                            ListViewItem item = new ListViewItem();

                            item.Text = id.ToString();
                            item.SubItems.Add(letter.Value.LetterHex);
                            item.SubItems.Add(letter.Value.LetterOffset.ToString());
                            item.SubItems.Add(letter.Value.LetterRectangle.X.ToString());
                            item.SubItems.Add(letter.Value.LetterRectangle.Y.ToString());
                            item.SubItems.Add(letter.Value.LetterRectangle.Width.ToString());
                            item.SubItems.Add(letter.Value.LetterRectangle.Height.ToString());
                            item.SubItems.Add(letter.Value.CharType.ToString());

                            Font_listView.Items.Add(item);
                            id++;
                        }
                    }
                }
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if(int.TryParse(Offset_textBox.Text, out int offset) && int.TryParse(X_textBox.Text, out int x) && int.TryParse(Y_textBox.Text, out int y) && int.TryParse(Width_textBox.Text, out int width) && int.TryParse(Height_textBox.Text, out int height) && CharType_comboBox.SelectedIndex != -1)
            {
                foreach(ListViewItem letter in Font_listView.Items)
                {
                    if(letter.SubItems[1].Text == Hex_textBox.Text)
                    {
                        Hex_textBox.Select();
                        Hex_textBox.SelectAll();
                        SystemSounds.Exclamation.Play();
                        return;
                    }
                }
                
                ListViewItem item = new ListViewItem();

                item.Text = (Font_listView.Items.Count + 1).ToString();
                item.SubItems.Add(Hex_textBox.Text);
                item.SubItems.Add(offset.ToString());
                item.SubItems.Add(x.ToString());
                item.SubItems.Add(y.ToString());
                item.SubItems.Add(width.ToString());
                item.SubItems.Add(height.ToString());
                item.SubItems.Add(CharType_comboBox.Text);

                Font_listView.Items.Add(item);

                Font_listView.Items[Font_listView.Items.Count - 1].Selected = true;
                Font_listView.Items[Font_listView.Items.Count - 1].EnsureVisible();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            if (Font_listView.SelectedItems.Count > 0 && Font_listView.SelectedItems[0] != null && int.TryParse(Offset_textBox.Text, out int offset) && int.TryParse(X_textBox.Text, out int x) && int.TryParse(Y_textBox.Text, out int y) && int.TryParse(Width_textBox.Text, out int width) && int.TryParse(Height_textBox.Text, out int height) && CharType_comboBox.SelectedIndex != -1)
            {
                ListViewItem item = Font_listView.SelectedItems[0];

                item.SubItems[1].Text = Hex_textBox.Text;
                item.SubItems[2].Text = offset.ToString();
                item.SubItems[3].Text = x.ToString();
                item.SubItems[4].Text = y.ToString();
                item.SubItems[5].Text = width.ToString();
                item.SubItems[6].Text = height.ToString();
                item.SubItems[7].Text = CharType_comboBox.Text;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if(Name_textBox.Text.Length > 0)
            {
                string name = Name_textBox.Text;
                Dictionary<string, CustomFont.Letter> letters = new Dictionary<string, CustomFont.Letter>()
                {
                    {"0A", new CustomFont.Letter(CustomFont.CharType.newline, "0A")},
                    {"20", new CustomFont.Letter(CustomFont.CharType.space, "20", new Microsoft.Xna.Framework.Rectangle(0, 0, 8, 0))}
                };

                CustomFont.Save(new CustomFont.CFont(name, letters));

                ReloadUI();

                foreach (var font in Font_comboBox.Items)
                {
                    if(font.ToString() == name)
                    {
                        Font_comboBox.SelectedItem = font;
                    }
                }
            }
        }

        private void SaveFont_button_Click(object sender, EventArgs e)
        {
            foreach (CustomFont.CFont cFont in CustomFont.Fonts)
            {
                if(cFont.Name == Font_comboBox.SelectedItem.ToString())
                {
                    cFont.Letters.Clear();
                    foreach (ListViewItem letter in Font_listView.Items)
                    {
                        if (int.TryParse(letter.SubItems[2].Text, out int offset) && int.TryParse(letter.SubItems[3].Text, out int x) && int.TryParse(letter.SubItems[4].Text, out int y) && int.TryParse(letter.SubItems[5].Text, out int width) && int.TryParse(letter.SubItems[6].Text, out int height) && Enum.TryParse(letter.SubItems[7].Text, out CustomFont.CharType charType))
                        {
                            cFont.Letters.Add(letter.SubItems[1].Text, new CustomFont.Letter(charType, letter.SubItems[1].Text, new Microsoft.Xna.Framework.Rectangle(x, y, width, height), offset));
                        }
                    }
                    CustomFont.Save(cFont);

                    SystemSounds.Exclamation.Play();
                    MessageBox.Show
                        (
                        "Save complete",
                        "Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }
    }
}
