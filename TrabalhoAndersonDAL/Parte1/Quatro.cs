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
    public partial class Quatro : Form
    {
        public Quatro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstTry = int.TryParse(textBox1.Text, out int result);
            if (firstTry)
            {
                string textResult;
                if(result%3 == 0)
                {
                    textResult = $"{result} é divisvel por 3";
                }
                else
                {
                    textResult = $"{result} não é divisvel por 3";
                }
                MessageBox.Show(textResult);
            }
        }
    }
}
