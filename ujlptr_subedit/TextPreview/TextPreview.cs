using System;
using System.Drawing;
using System.Windows.Forms;

namespace ujlptr_subedit.TextPreview
{
    public partial class TextPreview : Form
    {
        public TextPreview()
        {
            InitializeComponent();
            this.Size = new Size(336, 279);

            CustomFont.ReloadFonts();

            foreach (CustomFont.CFont font in CustomFont.Fonts) 
            {
                Font_comboBox.Items.Add(font.Name);
            }
            if(Font_comboBox.Items.Count > 0)
            {
                Font_comboBox.SelectedIndex = 0;
            }
        }

        private void UjlTextPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextRender.Dispose();
            GC.Collect();
            this.Dispose();
        }


        private void BackgroundsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "Backgrounds_radioButton1":
                    TextRender.BgIndex = 0;
                    break;
                case "Backgrounds_radioButton2":
                    TextRender.BgIndex = 1;
                    break;
                case "Backgrounds_radioButton3":
                    TextRender.BgIndex = 2;
                    break;
                case "Backgrounds_radioButton4":
                    TextRender.BgIndex = 3;
                    break;
            }
        }

        private void AdvanceModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked == true)
            {
                this.Size = new Size(439, 279);
            }
            else
            {
                this.Size = new Size(336, 279);
            }
        }

        private void Font_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Font_comboBox.SelectedIndex != -1 && TextRender.init == true)
            {
                TextRender.SwitchFont(Font_comboBox.SelectedIndex);
            }
        }
    }
}
