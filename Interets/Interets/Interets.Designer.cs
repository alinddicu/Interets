namespace Interets
{
    partial class Interets
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCotisation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTauxAnnuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPeriodeCalcul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFraisInit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCumulSurPeriode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCotisationRecalc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxRendementGlobal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxRendAnnuelGlob = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEvolTemps = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvolTemps)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cotisation mensuelle";
            // 
            // textBoxCotisation
            // 
            this.textBoxCotisation.Location = new System.Drawing.Point(149, 52);
            this.textBoxCotisation.Name = "textBoxCotisation";
            this.textBoxCotisation.Size = new System.Drawing.Size(110, 20);
            this.textBoxCotisation.TabIndex = 4;
            this.textBoxCotisation.Text = "180";
            this.textBoxCotisation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taux annuel";
            // 
            // textBoxTauxAnnuel
            // 
            this.textBoxTauxAnnuel.Location = new System.Drawing.Point(149, 80);
            this.textBoxTauxAnnuel.Name = "textBoxTauxAnnuel";
            this.textBoxTauxAnnuel.Size = new System.Drawing.Size(110, 20);
            this.textBoxTauxAnnuel.TabIndex = 6;
            this.textBoxTauxAnnuel.Text = "4";
            this.textBoxTauxAnnuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Période de calcul";
            // 
            // textBoxPeriodeCalcul
            // 
            this.textBoxPeriodeCalcul.Location = new System.Drawing.Point(149, 108);
            this.textBoxPeriodeCalcul.Name = "textBoxPeriodeCalcul";
            this.textBoxPeriodeCalcul.Size = new System.Drawing.Size(110, 20);
            this.textBoxPeriodeCalcul.TabIndex = 8;
            this.textBoxPeriodeCalcul.Text = "15";
            this.textBoxPeriodeCalcul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Frais début";
            // 
            // textBoxFraisInit
            // 
            this.textBoxFraisInit.Location = new System.Drawing.Point(149, 25);
            this.textBoxFraisInit.Name = "textBoxFraisInit";
            this.textBoxFraisInit.Size = new System.Drawing.Size(110, 20);
            this.textBoxFraisInit.TabIndex = 2;
            this.textBoxFraisInit.Text = "2205";
            this.textBoxFraisInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gain (cumul - frais)";
            // 
            // textBoxGain
            // 
            this.textBoxGain.Location = new System.Drawing.Point(167, 22);
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.ReadOnly = true;
            this.textBoxGain.Size = new System.Drawing.Size(110, 20);
            this.textBoxGain.TabIndex = 10;
            this.textBoxGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Location = new System.Drawing.Point(583, 469);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculer.TabIndex = 13;
            this.buttonCalculer.Text = "Calculer";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cumul sur période";
            // 
            // textBoxCumulSurPeriode
            // 
            this.textBoxCumulSurPeriode.Location = new System.Drawing.Point(167, 49);
            this.textBoxCumulSurPeriode.Name = "textBoxCumulSurPeriode";
            this.textBoxCumulSurPeriode.ReadOnly = true;
            this.textBoxCumulSurPeriode.Size = new System.Drawing.Size(110, 20);
            this.textBoxCumulSurPeriode.TabIndex = 12;
            this.textBoxCumulSurPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "ans";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "€";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Cotisation finale";
            // 
            // textBoxCotisationRecalc
            // 
            this.textBoxCotisationRecalc.Location = new System.Drawing.Point(167, 77);
            this.textBoxCotisationRecalc.Name = "textBoxCotisationRecalc";
            this.textBoxCotisationRecalc.ReadOnly = true;
            this.textBoxCotisationRecalc.Size = new System.Drawing.Size(110, 20);
            this.textBoxCotisationRecalc.TabIndex = 14;
            this.textBoxCotisationRecalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Rendement global";
            // 
            // textBoxRendementGlobal
            // 
            this.textBoxRendementGlobal.Location = new System.Drawing.Point(167, 105);
            this.textBoxRendementGlobal.Name = "textBoxRendementGlobal";
            this.textBoxRendementGlobal.ReadOnly = true;
            this.textBoxRendementGlobal.Size = new System.Drawing.Size(110, 20);
            this.textBoxRendementGlobal.TabIndex = 20;
            this.textBoxRendementGlobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(285, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "€";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Rendement annuel final";
            // 
            // textBoxRendAnnuelGlob
            // 
            this.textBoxRendAnnuelGlob.Location = new System.Drawing.Point(167, 133);
            this.textBoxRendAnnuelGlob.Name = "textBoxRendAnnuelGlob";
            this.textBoxRendAnnuelGlob.ReadOnly = true;
            this.textBoxRendAnnuelGlob.Size = new System.Drawing.Size(110, 20);
            this.textBoxRendAnnuelGlob.TabIndex = 24;
            this.textBoxRendAnnuelGlob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(285, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPeriodeCalcul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCotisation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTauxAnnuel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFraisInit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 165);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données d\'entrée";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxGain);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxRendAnnuelGlob);
            this.groupBox2.Controls.Add(this.textBoxCumulSurPeriode);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxRendementGlobal);
            this.groupBox2.Controls.Add(this.textBoxCotisationRecalc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 165);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultats";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxEvolTemps);
            this.groupBox3.Location = new System.Drawing.Point(13, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 279);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evolution dans le temps";
            // 
            // pictureBoxEvolTemps
            // 
            this.pictureBoxEvolTemps.Location = new System.Drawing.Point(13, 19);
            this.pictureBoxEvolTemps.Name = "pictureBoxEvolTemps";
            this.pictureBoxEvolTemps.Size = new System.Drawing.Size(624, 254);
            this.pictureBoxEvolTemps.TabIndex = 0;
            this.pictureBoxEvolTemps.TabStop = false;
            // 
            // Interets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 504);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalculer);
            this.Name = "Interets";
            this.Text = "Rendement assurance vie";
            this.Load += new System.EventHandler(this.Interets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvolTemps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCotisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTauxAnnuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPeriodeCalcul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFraisInit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGain;
        private System.Windows.Forms.Button buttonCalculer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCumulSurPeriode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCotisationRecalc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxRendementGlobal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxRendAnnuelGlob;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxEvolTemps;
    }
}

