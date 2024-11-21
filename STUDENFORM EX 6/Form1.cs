using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentFormApp
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Downloads\StudentForm1.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) // Insert
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO SF (NAME, AGE) VALUES (?, ?)", conn))
                    {
                        cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                        cmd.Parameters.AddWithValue("@AGE", Convert.ToInt32(textBox2.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button2_Click(object sender, EventArgs e) // Delete
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the name to delete.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM SF WHERE NAME = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Record deleted successfully." : "Record not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button3_Click(object sender, EventArgs e) // Update
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE SF SET AGE = ? WHERE NAME = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@AGE", Convert.ToInt32(textBox2.Text));
                        cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Record updated successfully." : "Record not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button4_Click(object sender, EventArgs e) // View All
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM SF", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                MessageBox.Show("Records loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button5_Click(object sender, EventArgs e) // Search
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the name to search.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM SF WHERE NAME = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            if (dt.Rows.Count == 0)
                                MessageBox.Show("Record not found.");
                        }
                    }
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
