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
    public partial class Cinco : Form
    {
        public Cinco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan time = dateTimePicker1.Value - dateTimePicker2.Value;

            MessageBox.Show(time.TotalDays.ToString());
        }
    }
}
