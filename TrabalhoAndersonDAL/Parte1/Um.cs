using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TrabalhoAndersonDAL.Parte1
{
    public partial class Um : Form
    {
        public Um()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textResult;
            if(double.TryParse(textBox1.Text, out double result))
            {
                TimeSpan time = TimeSpan.FromSeconds(result);
                textResult = $"{time:hh\\:mm\\:ss}";
            }
            else
            {
                textResult = "Falha ao validar valor do textbox";
            }
           
            MessageBox.Show(textResult);
        }
    }
}
