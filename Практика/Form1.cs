using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form1 : Form
    {
        private List<double> X, Y;

        private double Summ_xy, Summ_xx, 
        Summ_x, Summ_y, Summ, m, n;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            X = new List<double>();

            Y = new List<double>();

            dataGridView1.ColumnCount = 2;

            label1.Text = null;

            textBox1.Text = "0";
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)

            {

                X.Add((double)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));

                Y.Add((double)Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));

            }

            for (int i = 0; i < X.Count; i++)

            {

                Summ_x += X[i];

                Summ_y += Y[i];

                Summ_xy += X[i] * Y[i];

                Summ_xx += X[i] * X[i];

            }

            m = (double)(X.Count * Summ_xy - Summ_x * Summ_y) / (double)(X.Count * Summ_xx - Summ_x * Summ_x);

            n = (double)(Summ_y - m * Summ_x) / (double)X.Count;

            for (int i = 0; i < X.Count; i++)

            {

                Summ += ((Y[i] - (m * X[i] + n)) * (Y[i] - (m * X[i] + n)));

            }

            textBox1.Text = Convert.ToString(Summ);

            label1.Text = "y = " + m + "x + " + n;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            X.Clear(); Y.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 2;

            label1.Text = null;
        }
    }
}
