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
    public partial class Form2 : Form
    {
        public Form2(int[] a)
        {
            InitializeComponent();
            this.arr = a;
        }
        int[] arr;

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    label1.Text += ((i + 1) + ", ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
