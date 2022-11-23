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
    public partial class Quatro : Form
    {
        public Quatro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tryYear = int.TryParse(textBox1.Text, out var year);
            if (tryYear)
            {
                var isBis = DateTime.IsLeapYear(year);
                MessageBox.Show(isBis ? "é bissexto" : "não é bissexto");
            }
        }
    }
}
