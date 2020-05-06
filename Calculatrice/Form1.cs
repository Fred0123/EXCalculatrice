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

        string operateur;
        private void Zero_Click(object sender, EventArgs e)
        {
            Resultat.Text += "0";
        }

        private void Un_Click(object sender, EventArgs e)
        {
            Resultat.Text += "1";
        }

        private void Deux_Click(object sender, EventArgs e)
        {
            Resultat.Text += "2";
        }

        private void Trois_Click(object sender, EventArgs e)
        {
            Resultat.Text += "3";
        }

        private void Quatre_Click(object sender, EventArgs e)
        {
            Resultat.Text += "4";
        }

        private void Cinq_Click(object sender, EventArgs e)
        {
            Resultat.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Resultat.Text += "6";
        }

        private void Sept_Click(object sender, EventArgs e)
        {
            Resultat.Text += "7";
        }

        private void Huit_Click(object sender, EventArgs e)
        {
            Resultat.Text += "8";
        }

        private void Neuf_Click(object sender, EventArgs e)
        {
            Resultat.Text += "9";
        }
        int cpt = 0;
        private void PlusMoin_Click(object sender, EventArgs e)
        {
            
            if(cpt == 0)
            {
                Resultat.Text += "-";
                cpt = 1;
            }
            else if (cpt == 1)
            {
                Resultat.Text += "+";
                cpt = 0;
            }
        }

        private void Separa_Click(object sender, EventArgs e)
        {
            Resultat.Text += ".";
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                string[] chaine = Resultat.Text.Split('+');
                Resultat.Text += Environment.NewLine + (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString();
            }
            if (operateur == "-")
            {
                string[] chaine = Resultat.Text.Split('-');
                Resultat.Text += Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();
            }
            if (operateur == "*")
            {
                string[] chaine = Resultat.Text.Split('*');
                Resultat.Text += Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
            }
            if (operateur == "/")
            { 
                string[] chaine = Resultat.Text.Split('/');
                if(double.Parse(chaine[1]) != 0)
                {
                    Resultat.Text += Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();
                }
                else
                {
                    MessageBox.Show(
                        "Division par zero impossible",
                        "Error division",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                
            }
        }

        private void Addict_Click(object sender, EventArgs e)
        {
            Resultat.Text += "+";
            operateur = "+";
        }

        private void Soustr_Click(object sender, EventArgs e)
        {
            Resultat.Text += "-";
            operateur = "-";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Resultat.Text += "*";
            operateur = "*";
        }

        private void Divis_Click(object sender, EventArgs e)
        {
            Resultat.Text += "/";
            operateur = "/";
        }

        private void Resultat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }
        private void Clear_click(object sender, EventArgs e)
        {
            Resultat.Text = string.Empty;
        }

        private void Resultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) != false && e.KeyChar != (char)8)
                {
                e.Handled = true;
            }
        }
    }
}
