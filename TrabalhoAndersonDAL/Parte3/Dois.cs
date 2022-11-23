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
    public partial class Dois : Form
    {
        public Dois()
        {
            InitializeComponent();
        }

        int[] um = new int[5] { 1, 2, 3, 4, 5 };
        int[] dois = new int[5] { 7, 2, 6, 4, 5 };

        private void button1_Click(object sender, EventArgs e)
        {
            var result = string.Join(",", um.Intersect(dois));

            MessageBox.Show(result);
        }

        private void Dois_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(um.Cast<object>().ToArray());
            listBox2.Items.AddRange(dois.Cast<object>().ToArray());
        }
    }
}
