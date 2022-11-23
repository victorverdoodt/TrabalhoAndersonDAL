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
    public partial class Um : Form
    {
        public List<int> UmList = new List<int>();
        public Um()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstTry = int.TryParse(textBox1.Text.Trim(), out int result);
            if (firstTry)
            {
                if (result >= 0 && result <= 100)
                {
                    UmList.Add(result);
                    listBox1.Items.Add(result);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            foreach(var item in UmList)
            {
                if(item >= 0 && item <= 25)
                {
                    a++;
                }else if (item >= 25 && item < 50)
                {
                    b++;
                }
                else if (item >= 51 && item < 75)
                {
                    c++;
                }
                else if (item >= 76 && item < 100)
                {
                    d++;
                }
            }

            MessageBox.Show($"De 0 a 25: {a}\n De 25 a 50: {b}\n De 51 a 75: {c}\n De 76 a 100: {d}");
        }
    }
}
