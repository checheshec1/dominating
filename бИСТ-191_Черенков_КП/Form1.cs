using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бИСТ_191_Черенков_КП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(numericUpDown1.Value);
            for(int i = 1; i < N; i++)
            {
                dataGridView1.Rows.Add();
            }
            for(int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = ("Вариант №" + (i + 1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(numericUpDown1.Value);
            int b, c, d, f;
            double a;
            KSA[] Arr = new KSA[N];
            for(int i = 0; i < N; i++)
            {
                a = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                b = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                c = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                d = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                f = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                Arr[i] = new KSA(a, b, c, d, f);
            }
            int[] massiv = new int[N];
            KSA.Pareto(N, Arr, ref massiv);
            Form f2 = new Form2(massiv);
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
