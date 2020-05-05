using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Int32 zero = 0;
            Resultat.Text = zero.ToString();
        }

        private void Un_Click(object sender, EventArgs e)
        {
            Int32 un = 1;
            Resultat.Text = un.ToString();
        }

        private void Deux_Click(object sender, EventArgs e)
        {
            Int32 deux = 2;
            Resultat.Text = deux.ToString();
        }

        private void Trois_Click(object sender, EventArgs e)
        {
            Int32 trois = 3;
            Resultat.Text = trois.ToString();
        }

        private void Quatre_Click(object sender, EventArgs e)
        {
            Int32 quatre = 4;
            Resultat.Text = quatre.ToString();
        }

        private void Cinq_Click(object sender, EventArgs e)
        {
            Int32 cinq = 5;
            Resultat.Text = cinq.ToString();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Int32 six = 6;
            Resultat.Text = six.ToString();
        }

        private void Sept_Click(object sender, EventArgs e)
        {
            Int32 sept = 7;
            Resultat.Text = sept.ToString();
        }

        private void Huit_Click(object sender, EventArgs e)
        {
            Int32 huit = 8;
            Resultat.Text = huit.ToString();
        }

        private void Neuf_Click(object sender, EventArgs e)
        {
            Int32 neuf = 9;
            Resultat.Text = neuf.ToString();
        }

        private void PlusMoin_Click(object sender, EventArgs e)
        {

        }

        private void Separa_Click(object sender, EventArgs e)
        {

        }

        private void Egal_Click(object sender, EventArgs e)
        {

        }

        private void Addict_Click(object sender, EventArgs e)
        {
            Int32 adi;
        }

        private void Soustr_Click(object sender, EventArgs e)
        {

        }

        private void Multi_Click(object sender, EventArgs e)
        {

        }

        private void Divis_Click(object sender, EventArgs e)
        {

        }

        private void Resultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }
    }
}
