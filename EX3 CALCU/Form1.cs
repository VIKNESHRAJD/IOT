using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add any initialization logic here if needed.
        }

        private void button1_Click(object sender, EventArgs e) // Add Button
        {
            try
            {
                var a = Convert.ToInt32(textBox1.Text);
                var b = Convert.ToInt32(textBox2.Text);
                var c = a + b;
                textBox3.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Subtract Button
        {
            try
            {
                var a = Convert.ToInt32(textBox1.Text);
                var b = Convert.ToInt32(textBox2.Text);
                var c = a - b;
                textBox3.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Multiply Button
        {
            try
            {
                var a = Convert.ToInt32(textBox1.Text);
                var b = Convert.ToInt32(textBox2.Text);
                var c = a * b;
                textBox3.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Divide Button
        {
            try
            {
                var a = Convert.ToInt32(textBox1.Text);
                var b = Convert.ToInt32(textBox2.Text);

                if (b == 0)
                {
                    MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "Error";
                }
                else
                {
                    var c = a / b;
                    textBox3.Text = c.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
