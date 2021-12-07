using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            Random rn = new Random();
            int cisla;
            
            for (int i = 0; i < n; i++)
            {
                cisla = rn.Next(1, 50);
                pole[i] = cisla;
            }
            foreach (int k in pole)
            {
                listBox1.Items.Add(k.ToString());
            }

            Array.Sort(pole);

            if (radioButton2.Checked)
            {
                Array.Reverse(pole);
            }
            foreach (int k in pole)
            {
                listBox2.Items.Add(k.ToString());
            }
        }
    }
}
