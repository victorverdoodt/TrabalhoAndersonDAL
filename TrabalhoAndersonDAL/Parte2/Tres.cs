using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAndersonDAL.Parte2
{
    public partial class Tres : Form
    {
        public Tres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FristTry = double.TryParse(textBox1.Text.Trim(), out double FirstResult);
            var SecTry = double.TryParse(textBox2.Text.Trim(), out double SecondResult);
            if (FristTry && SecTry)
            {
                MessageBox.Show(CalculaIMC(FirstResult, SecondResult).ToString());
            }
        }

        public double CalculaIMC(double peso, double altura)
        {
            return (peso / (altura * altura));
        }
    }
}
