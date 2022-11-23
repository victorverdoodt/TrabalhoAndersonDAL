using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAndersonDAL.Parte1
{
    public partial class Tres : Form
    {
        public Tres()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tryC = double.TryParse(textBox1.Text, out double result);
            string textResult = "Falha";
            if (tryC) {
                if (radioButton1.Checked)
                {
                    textResult = CelsiusKelvin(result).ToString();
                }
                else if (radioButton2.Checked)
                {
                    textResult = CelsiusFahrenheit(result).ToString();
                }
            }

            MessageBox.Show(textResult);
        }

        public double CelsiusKelvin(double C)
        {
            return (C + 273.15);
        }

        public double CelsiusFahrenheit(double C)
        {
            return (C * 9) / 5 + 32;
        }

    }
}
