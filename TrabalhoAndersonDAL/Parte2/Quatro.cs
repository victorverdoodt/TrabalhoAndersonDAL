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
    public partial class Quatro : Form
    {
        public Quatro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstTry = float.TryParse(textBox1.Text, out float result);
            if (firstTry)
            {
                string textResult = "Nota inválida.";
                if(result >= 0 && result <= 10)
                {
                    if(result == 10)
                    {
                        textResult = "Excelente";
                    }else if (result < 10 && result >= 8)
                    {
                        textResult = "Muito bom";
                    }else if (result < 8 && result >= 7)
                    {
                        textResult = "bom";
                    }
                    else if (result <= 7)
                    {
                        textResult = "insatisfatório";
                    }
                }

                MessageBox.Show(textResult);
            }
        }
    }
}
