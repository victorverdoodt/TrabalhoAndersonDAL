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
    public partial class Dois : Form
    {
        public Dois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FristTry = int.TryParse(textBox1.Text.Trim(), out int FirstResult);
            var SecTry = int.TryParse(textBox2.Text.Trim(), out int SecondResult);
            var listPar = new List<int>();
            if(FristTry && SecTry)
            {
                if(FirstResult < SecondResult && FirstResult != SecondResult)
                {
                    for(int i = FirstResult; i <= SecondResult; i++)
                    {
                        if(i%2 == 0)
                        {
                            listPar.Add(i);
                        }
                    }
                }
                MessageBox.Show(string.Join(", ", listPar));
            }


        }
    }
}
