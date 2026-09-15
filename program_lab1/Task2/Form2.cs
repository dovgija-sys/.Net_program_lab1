using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace program_lab1.Task2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Exit_button_Form2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int m = Convert.ToInt32(textBox2.Text);
                Array2 array = new(n, m);
                DataGridViewTextBoxColumn column;
                for(int i = 0; i < m; i++)
                {
                    column = new()
                    {
                        Width = 40
                    };
                    dataGridView1.Columns.Add(column);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = array.Xlength;
                dataGridView1.ColumnCount = array.Ylength;
                for(int i = 0; i < array.Xlength; i++)
                {
                    for(int j = 0; j < array.Ylength; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString();
                    }
                }
                var count = array.Count();
                label3.Text = $"The number of positive elements of this array located above the left diagonal: {count}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
