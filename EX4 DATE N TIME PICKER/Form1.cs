using System;
using System.Windows.Forms;

namespace EX4_DATE_N_TIME_PICKER
{
    public partial class Form1 : Form
    {
        private DateTimePicker timePicker;

        public Form1()
        {
            InitializeComponent();

            // Initialize the timePicker control
            timePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Location = new System.Drawing.Point(50, 50), // Adjust position as needed
                Width = 100
            };

            // Add the timePicker to the form's controls
            Controls.Add(timePicker);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add logic that runs when the form loads
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Handle the timePicker's ValueChanged event (if needed)
            MessageBox.Show("Selected time: " + timePicker.Value.ToShortTimeString());
        }
    }
}
