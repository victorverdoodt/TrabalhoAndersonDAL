using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAndersonDAL;

namespace TrabalhoAndersonDAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void segundoHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teste = new Parte1.Um();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var teste = new Parte1.Dois();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var teste = new Parte1.Tres();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var teste = new Parte1.Quatro();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var teste = new Parte1.Cinco();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var teste = new Parte2.Um();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var teste = new Parte2.Dois();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            var teste = new Parte2.Tres();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            var teste = new Parte2.Quatro();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            var teste = new Parte2.Cinco();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var teste = new Parte3.Um();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var teste = new Parte3.Dois();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            var teste = new Parte3.Tres();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            var teste = new Parte3.Quatro();
            teste.MdiParent = this;
            teste.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            var teste = new Parte4.Um();
            teste.MdiParent = this;
            teste.Show();
        }
    }
}
