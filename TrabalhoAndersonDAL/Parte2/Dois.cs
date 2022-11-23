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
            string textResult;
            if (FristTry && SecTry)
            {
                if (FirstResult >= SecondResult)
                {
                    textResult = $"{FirstResult-SecondResult}";
                }
                else
                {
                    textResult = $"{SecondResult - FirstResult}";
                }
                MessageBox.Show(textResult);
            }
        }
    }
}
