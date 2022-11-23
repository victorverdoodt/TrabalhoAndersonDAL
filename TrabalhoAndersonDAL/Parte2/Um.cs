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
    public partial class Um : Form
    {
        public Um()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstTry = int.TryParse(textBox1.Text, out int result);
            if (firstTry)
            {
                string textResult;
                if (result % 2 == 0)
                {
                    textResult = $"{result*2}";
                }
                else
                {
                    textResult = $"{result/2}";
                }
                MessageBox.Show(textResult);
            }
        }
    }
}
