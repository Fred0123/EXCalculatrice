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
            Resultat.Text += ",";
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            if(Resultat.Text == "")
            {
                MessageBox.Show("Aucun operation en cour", "Erreur de calcule", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (label1.Text == "+")
            {
                valeur += Convert.ToDouble(Resultat.Text);
                solution.Text = valeur.ToString();
                Resultat.Text = "";
            }
            else if (label1.Text == "-")
            {
                valeur -= Convert.ToDouble(Resultat.Text);
                solution.Text = valeur.ToString();
                Resultat.Text = "";
            }
            else if (label1.Text == "*")
            {
                valeur *= Convert.ToDouble(Resultat.Text);
                solution.Text = valeur.ToString();
                Resultat.Text = "";
            }
            else if (label1.Text == "/")
            {
                if (Resultat.Text == "0" && cpt_operateur == 1)
                {
                    MessageBox.Show(
                "Division par zero impossible",
                "Error division",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                    valeur /= Convert.ToDouble(Resultat.Text);
                    solution.Text = valeur.ToString();
                    Resultat.Text = "";
                }
            }
        }

        private void Clear_click(object sender, EventArgs e)
        {
            Resultat.Text = string.Empty;
            label1.Text = string.Empty;
            solution.Text = string.Empty;
            valeur = 0;
        }

        private void Resultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)8)
                {
                e.Handled = true;
            }
        }

        private void Valeur_click(object sender, EventArgs e)
        {
            Button Valeur = (Button)sender;
            switch (Valeur.Text)
            {
                case "0":
                    Resultat.Text += "0";
                    break;
                case "1":
                    Resultat.Text += "1";
                    break;
                case "2":
                    Resultat.Text += "2";
                    break;
                case "3":
                    Resultat.Text += "3";
                    break;
                case "4":
                    Resultat.Text += "4";
                    break;
                case "5":
                    Resultat.Text += "5";
                    break;
                case "6":
                    Resultat.Text += "6";
                    break;
                case "7":
                    Resultat.Text += "7";
                    break;
                case "8":
                    Resultat.Text += "8";
                    break;
                case "9":
                    Resultat.Text += "9";
                    break;
                default:
                    MessageBox.Show("Erreur chiffrement","Valeur inconnue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        double valeur;
        int cpt_operateur = 0;
        private void Operateur_click(object sender, EventArgs e)
        {
            Button Operateurs = (Button)sender;
            switch (Operateurs.Text)
            {
                // Operateur d'addiction +
                case "+":
                    if ((Resultat.Text == "" && cpt_operateur == 0) || Resultat.Text == "+" 
                        || Resultat.Text == "-")
                    {
                        MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Resultat.Text = "";
                    }
                    else if(cpt_operateur == 0 && Resultat.Text != "")
                    {
                        valeur =Convert.ToDouble(Resultat.Text);
                        cpt_operateur = 1;
                        label1.Text = "+";
                        solution.Text = Resultat.Text;
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 1 && Resultat.Text == "")
                    {
                        Resultat.Text = "";
                        label1.Text = "+";
                    }
                    else
                    {
                        valeur += Convert.ToDouble(Resultat.Text);
                        solution.Text = valeur.ToString();
                        Resultat.Text = "";
                    }
                    break;
                    // Operateur de soubstraction -
                case "-":
                    if ((Resultat.Text == "" && cpt_operateur == 0) || Resultat.Text == "+"
                        || Resultat.Text == "-")
                    {
                        MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 0 && Resultat.Text != "")
                    {
                        valeur = Convert.ToDouble(Resultat.Text);
                        cpt_operateur = 1;
                        label1.Text = "-";
                        solution.Text = Resultat.Text;
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 1 && Resultat.Text == "")
                    {
                        Resultat.Text = "";
                        label1.Text = "-";
                    }
                    else
                    {
                        valeur -= Convert.ToDouble(Resultat.Text);
                        solution.Text = valeur.ToString();
                        Resultat.Text = "";
                    }
                    break;
                // Operateur de muliplication *
                case "*":
                    if ((Resultat.Text == "" && cpt_operateur == 0) || Resultat.Text == "+"
                        || Resultat.Text == "-")
                    {
                        MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 0 && Resultat.Text != "")
                    {
                        valeur = Convert.ToDouble(Resultat.Text);
                        cpt_operateur = 1;
                        label1.Text = "*";
                        solution.Text = Resultat.Text;
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 1 && Resultat.Text == "")
                    {
                        Resultat.Text = "";
                        label1.Text = "*";
                    }
                    else
                    {
                        valeur *= Convert.ToDouble(Resultat.Text);
                        solution.Text = valeur.ToString();
                        Resultat.Text = "";
                    }
                    break;
                // Operateur de division /
                case "/":
                    if ((Resultat.Text == "" && cpt_operateur == 0) || Resultat.Text == "+"
                        || Resultat.Text == "-")
                    {
                        MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 0 && Resultat.Text != "")
                    {
                        valeur = Convert.ToDouble(Resultat.Text);
                        cpt_operateur = 1;
                        label1.Text = "/";
                        solution.Text = Resultat.Text;
                        Resultat.Text = "";
                    }
                    else if (cpt_operateur == 1 && Resultat.Text == "")
                    {
                        label1.Text = "/";
                        Resultat.Text = "";
                    }
                    else
                    {
                        if (Resultat.Text == "0" && cpt_operateur == 1)
                        {
                            MessageBox.Show(
                        "Division par zero impossible",
                        "Error division",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        }
                        else
                        {
                        valeur /= Convert.ToDouble(Resultat.Text);
                        solution.Text = valeur.ToString();
                        Resultat.Text = "";
                        }   
                    }
                    break;
                default:
                    MessageBox.Show("Erreur operateur inconue", 
                        "Operateur inconnues", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }
        }

        private void solution_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
