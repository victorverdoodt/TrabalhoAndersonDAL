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
    public partial class Cinco : Form
    {
        public Cinco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NiverToData(dateTimePicker1.Value).ToString());
        }

        private static int NiverToData(DateTime data)
        {
            int idade = 0;
            idade = DateTime.Now.Year - data.Year;
            if (DateTime.Now.DayOfYear < data.DayOfYear)
                idade = idade - 1;

            return idade;
        }
    }
}
