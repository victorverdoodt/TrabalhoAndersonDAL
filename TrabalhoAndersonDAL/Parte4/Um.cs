using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAndersonDAL.Parte4
{
    public partial class Um : Form
    {
        public Um()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[8] {1, 7, 9, 8, 5 ,6 , 2, 3 };
            int soma = vetor.Sum(x => x);
            string textResult = "";
            for(int i = 0; i < 8; i++)
            {
                int v = soma * i;
                textResult += $" {i}:{v}\n";
            }

           MessageBox.Show(textResult);
        }
    }
}
