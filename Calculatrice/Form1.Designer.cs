﻿namespace Calculatrice
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resultat = new System.Windows.Forms.TextBox();
            this.PlusMoin = new System.Windows.Forms.Button();
            this.Valeur = new System.Windows.Forms.Button();
            this.Separa = new System.Windows.Forms.Button();
            this.Egal = new System.Windows.Forms.Button();
            this.Un = new System.Windows.Forms.Button();
            this.Deux = new System.Windows.Forms.Button();
            this.Trois = new System.Windows.Forms.Button();
            this.Addict = new System.Windows.Forms.Button();
            this.Quatre = new System.Windows.Forms.Button();
            this.Cinq = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Soustr = new System.Windows.Forms.Button();
            this.Sept = new System.Windows.Forms.Button();
            this.Huit = new System.Windows.Forms.Button();
            this.Neuf = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.Divis = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Resultat
            // 
            this.Resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat.Location = new System.Drawing.Point(2, 1);
            this.Resultat.Multiline = true;
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(335, 111);
            this.Resultat.TabIndex = 0;
            this.Resultat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Resultat_KeyPress);
            // 
            // PlusMoin
            // 
            this.PlusMoin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlusMoin.Location = new System.Drawing.Point(3, 340);
            this.PlusMoin.Name = "PlusMoin";
            this.PlusMoin.Size = new System.Drawing.Size(92, 48);
            this.PlusMoin.TabIndex = 1;
            this.PlusMoin.Text = "+/-";
            this.PlusMoin.UseVisualStyleBackColor = false;
            this.PlusMoin.Click += new System.EventHandler(this.PlusMoin_Click);
            // 
            // Valeur
            // 
            this.Valeur.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Valeur.Location = new System.Drawing.Point(84, 340);
            this.Valeur.Name = "Valeur";
            this.Valeur.Size = new System.Drawing.Size(92, 48);
            this.Valeur.TabIndex = 2;
            this.Valeur.Text = "0";
            this.Valeur.UseVisualStyleBackColor = false;
            this.Valeur.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Separa
            // 
            this.Separa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Separa.Location = new System.Drawing.Point(165, 340);
            this.Separa.Name = "Separa";
            this.Separa.Size = new System.Drawing.Size(92, 48);
            this.Separa.TabIndex = 3;
            this.Separa.Text = ",";
            this.Separa.UseVisualStyleBackColor = false;
            this.Separa.Click += new System.EventHandler(this.Separa_Click);
            // 
            // Egal
            // 
            this.Egal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Egal.Location = new System.Drawing.Point(246, 340);
            this.Egal.Name = "Egal";
            this.Egal.Size = new System.Drawing.Size(92, 48);
            this.Egal.TabIndex = 4;
            this.Egal.Text = "=";
            this.Egal.UseVisualStyleBackColor = false;
            this.Egal.Click += new System.EventHandler(this.Egal_Click);
            // 
            // Un
            // 
            this.Un.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Un.Location = new System.Drawing.Point(3, 294);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(92, 48);
            this.Un.TabIndex = 5;
            this.Un.Text = "1";
            this.Un.UseVisualStyleBackColor = false;
            this.Un.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Deux
            // 
            this.Deux.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Deux.Location = new System.Drawing.Point(84, 294);
            this.Deux.Name = "Deux";
            this.Deux.Size = new System.Drawing.Size(92, 48);
            this.Deux.TabIndex = 6;
            this.Deux.Text = "2";
            this.Deux.UseVisualStyleBackColor = false;
            this.Deux.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Trois
            // 
            this.Trois.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Trois.Location = new System.Drawing.Point(165, 294);
            this.Trois.Name = "Trois";
            this.Trois.Size = new System.Drawing.Size(92, 50);
            this.Trois.TabIndex = 7;
            this.Trois.Text = "3";
            this.Trois.UseVisualStyleBackColor = false;
            this.Trois.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Addict
            // 
            this.Addict.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Addict.Location = new System.Drawing.Point(246, 294);
            this.Addict.Name = "Addict";
            this.Addict.Size = new System.Drawing.Size(92, 50);
            this.Addict.TabIndex = 8;
            this.Addict.Text = "+";
            this.Addict.UseVisualStyleBackColor = false;
            this.Addict.Click += new System.EventHandler(this.Operateur_click);
            // 
            // Quatre
            // 
            this.Quatre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Quatre.Location = new System.Drawing.Point(3, 248);
            this.Quatre.Name = "Quatre";
            this.Quatre.Size = new System.Drawing.Size(92, 48);
            this.Quatre.TabIndex = 9;
            this.Quatre.Text = "4";
            this.Quatre.UseVisualStyleBackColor = false;
            this.Quatre.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Cinq
            // 
            this.Cinq.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cinq.Location = new System.Drawing.Point(84, 248);
            this.Cinq.Name = "Cinq";
            this.Cinq.Size = new System.Drawing.Size(92, 48);
            this.Cinq.TabIndex = 10;
            this.Cinq.Text = "5";
            this.Cinq.UseVisualStyleBackColor = false;
            this.Cinq.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Six.Location = new System.Drawing.Point(165, 248);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(92, 48);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Soustr
            // 
            this.Soustr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Soustr.Location = new System.Drawing.Point(246, 248);
            this.Soustr.Name = "Soustr";
            this.Soustr.Size = new System.Drawing.Size(92, 48);
            this.Soustr.TabIndex = 12;
            this.Soustr.Text = "-";
            this.Soustr.UseVisualStyleBackColor = false;
            this.Soustr.Click += new System.EventHandler(this.Operateur_click);
            // 
            // Sept
            // 
            this.Sept.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sept.Location = new System.Drawing.Point(3, 202);
            this.Sept.Name = "Sept";
            this.Sept.Size = new System.Drawing.Size(92, 50);
            this.Sept.TabIndex = 13;
            this.Sept.Text = "7";
            this.Sept.UseVisualStyleBackColor = false;
            this.Sept.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Huit
            // 
            this.Huit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Huit.Location = new System.Drawing.Point(84, 202);
            this.Huit.Name = "Huit";
            this.Huit.Size = new System.Drawing.Size(92, 50);
            this.Huit.TabIndex = 14;
            this.Huit.Text = "8";
            this.Huit.UseVisualStyleBackColor = false;
            this.Huit.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Neuf
            // 
            this.Neuf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Neuf.Location = new System.Drawing.Point(165, 202);
            this.Neuf.Name = "Neuf";
            this.Neuf.Size = new System.Drawing.Size(92, 50);
            this.Neuf.TabIndex = 15;
            this.Neuf.Text = "9";
            this.Neuf.UseVisualStyleBackColor = false;
            this.Neuf.Click += new System.EventHandler(this.Valeur_click);
            // 
            // Multi
            // 
            this.Multi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Multi.Location = new System.Drawing.Point(246, 202);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(92, 50);
            this.Multi.TabIndex = 16;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = false;
            this.Multi.Click += new System.EventHandler(this.Operateur_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button17.Location = new System.Drawing.Point(3, 156);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(92, 50);
            this.button17.TabIndex = 17;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button18.Location = new System.Drawing.Point(84, 156);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(92, 50);
            this.button18.TabIndex = 18;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button19.Location = new System.Drawing.Point(165, 156);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(92, 50);
            this.button19.TabIndex = 19;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // Divis
            // 
            this.Divis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Divis.Location = new System.Drawing.Point(246, 156);
            this.Divis.Name = "Divis";
            this.Divis.Size = new System.Drawing.Size(92, 50);
            this.Divis.TabIndex = 20;
            this.Divis.Text = "/";
            this.Divis.UseVisualStyleBackColor = false;
            this.Divis.Click += new System.EventHandler(this.Operateur_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button21.Location = new System.Drawing.Point(3, 111);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(92, 50);
            this.button21.TabIndex = 21;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button22.Location = new System.Drawing.Point(84, 111);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(92, 50);
            this.button22.TabIndex = 22;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button23.Location = new System.Drawing.Point(165, 111);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(92, 50);
            this.button23.TabIndex = 23;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Clear.Location = new System.Drawing.Point(246, 111);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 50);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 1);
            this.label1.MaximumSize = new System.Drawing.Size(500, 300);
            this.label1.MinimumSize = new System.Drawing.Size(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 85);
            this.label1.TabIndex = 25;
            this.label1.Text = "Signe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solution
            // 
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution.ForeColor = System.Drawing.Color.Red;
            this.solution.Location = new System.Drawing.Point(4, 81);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(334, 31);
            this.solution.TabIndex = 26;
            this.solution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.solution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solution_KeyPress);
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 386);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Divis);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Neuf);
            this.Controls.Add(this.Huit);
            this.Controls.Add(this.Sept);
            this.Controls.Add(this.Soustr);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Cinq);
            this.Controls.Add(this.Quatre);
            this.Controls.Add(this.Addict);
            this.Controls.Add(this.Trois);
            this.Controls.Add(this.Deux);
            this.Controls.Add(this.Un);
            this.Controls.Add(this.Egal);
            this.Controls.Add(this.Separa);
            this.Controls.Add(this.Valeur);
            this.Controls.Add(this.PlusMoin);
            this.Controls.Add(this.Resultat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.Click += new System.EventHandler(this.Valeur_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resultat;
        private System.Windows.Forms.Button PlusMoin;
        private System.Windows.Forms.Button Valeur;
        private System.Windows.Forms.Button Separa;
        private System.Windows.Forms.Button Egal;
        private System.Windows.Forms.Button Un;
        private System.Windows.Forms.Button Deux;
        private System.Windows.Forms.Button Trois;
        private System.Windows.Forms.Button Addict;
        private System.Windows.Forms.Button Quatre;
        private System.Windows.Forms.Button Cinq;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Soustr;
        private System.Windows.Forms.Button Sept;
        private System.Windows.Forms.Button Huit;
        private System.Windows.Forms.Button Neuf;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button Divis;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox solution;
    }
}

