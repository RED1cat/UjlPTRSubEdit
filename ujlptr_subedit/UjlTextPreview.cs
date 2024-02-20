using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ujlptr_subedit
{
    public partial class UjlTextPreview : Form
    {
        public UjlTextPreview()
        {
            InitializeComponent();
            this.Size = new Size(336, 279);
        }

        private void UjlTextPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            UjlTextRender.Dispose();
            GC.Collect();
            this.Dispose();
        }

        private void FontsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "FontsRadioButton1":
                    UjlTextRender.SwitchFonts = false;
                    break;
                case "FontsRadioButton2":
                    UjlTextRender.SwitchFonts = true;
                    break;
            }
        }

        private void BackgroundsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "BackgroundsRadioButton1":
                    UjlTextRender.IndexBg = 1;
                    break;
                case "BackgroundsRadioButton2":
                    UjlTextRender.IndexBg = 2;
                    break;
                case "BackgroundsRadioButton3":
                    UjlTextRender.IndexBg = 3;
                    break;
                case "BackgroundsRadioButton4":
                    UjlTextRender.IndexBg = 4;
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
    }
}
