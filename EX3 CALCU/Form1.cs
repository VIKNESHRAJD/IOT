using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelFontStyle();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelFontStyle();
        }

        private void UpdateLabelFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (checkBox1.Checked)
                style |= FontStyle.Bold;
            if (checkBox2.Checked)
                style |= FontStyle.Italic;

            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, style);
        }
    }
}
