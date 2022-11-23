using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAndersonDAL.Parte3
{
    public partial class Tres : Form
    {
        public Tres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = 0;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length == 1)
            {
                foreach (char c in textBox1.Text)
                {
                    if (c == textBox2.Text[0])
                    {
                        count++;
                    }
                }
                MessageBox.Show(count.ToString());
            }
            else
            {
                MessageBox.Show("Invalido");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
