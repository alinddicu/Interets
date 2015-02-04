namespace Interets.New.Chart
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._chart = new System.Windows.Forms.PictureBox();
            this.panelDataInput = new System.Windows.Forms.Panel();
            this.textBoxCotisation = new System.Windows.Forms.TextBox();
            this.labelCotisation = new System.Windows.Forms.Label();
            this.textBoxGainNet = new System.Windows.Forms.TextBox();
            this.labelGainNet = new System.Windows.Forms.Label();
            this.textBoxFraisGlobaux = new System.Windows.Forms.TextBox();
            this.labelFraisGlobaux = new System.Windows.Forms.Label();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.labelDuree = new System.Windows.Forms.Label();
            this.textBoxPrimeMensuelle = new System.Windows.Forms.TextBox();
            this.labelPrimeMensuelle = new System.Windows.Forms.Label();
            this.textBoxTaux = new System.Windows.Forms.TextBox();
            this.labelTaux = new System.Windows.Forms.Label();
            this.labelGainBrut = new System.Windows.Forms.Label();
            this.textBoxGainBrut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
            this.panelDataInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // _chart
            // 
            this._chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._chart.Location = new System.Drawing.Point(0, 105);
            this._chart.Name = "_chart";
            this._chart.Size = new System.Drawing.Size(573, 346);
            this._chart.TabIndex = 0;
            this._chart.TabStop = false;
            // 
            // panelDataInput
            // 
            this.panelDataInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataInput.Controls.Add(this.textBoxGainBrut);
            this.panelDataInput.Controls.Add(this.labelGainBrut);
            this.panelDataInput.Controls.Add(this.textBoxCotisation);
            this.panelDataInput.Controls.Add(this.labelCotisation);
            this.panelDataInput.Controls.Add(this.textBoxGainNet);
            this.panelDataInput.Controls.Add(this.labelGainNet);
            this.panelDataInput.Controls.Add(this.textBoxFraisGlobaux);
            this.panelDataInput.Controls.Add(this.labelFraisGlobaux);
            this.panelDataInput.Controls.Add(this.buttonCalculer);
            this.panelDataInput.Controls.Add(this.textBoxDuree);
            this.panelDataInput.Controls.Add(this.labelDuree);
            this.panelDataInput.Controls.Add(this.textBoxPrimeMensuelle);
            this.panelDataInput.Controls.Add(this.labelPrimeMensuelle);
            this.panelDataInput.Controls.Add(this.textBoxTaux);
            this.panelDataInput.Controls.Add(this.labelTaux);
            this.panelDataInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataInput.Location = new System.Drawing.Point(0, 0);
            this.panelDataInput.Name = "panelDataInput";
            this.panelDataInput.Size = new System.Drawing.Size(573, 99);
            this.panelDataInput.TabIndex = 1;
            // 
            // textBoxCotisation
            // 
            this.textBoxCotisation.Location = new System.Drawing.Point(455, 68);
            this.textBoxCotisation.Name = "textBoxCotisation";
            this.textBoxCotisation.ReadOnly = true;
            this.textBoxCotisation.Size = new System.Drawing.Size(100, 20);
            this.textBoxCotisation.TabIndex = 12;
            // 
            // labelCotisation
            // 
            this.labelCotisation.AutoSize = true;
            this.labelCotisation.Location = new System.Drawing.Point(393, 71);
            this.labelCotisation.Name = "labelCotisation";
            this.labelCotisation.Size = new System.Drawing.Size(53, 13);
            this.labelCotisation.TabIndex = 11;
            this.labelCotisation.Text = "Cotisation";
            // 
            // textBoxGainNet
            // 
            this.textBoxGainNet.Location = new System.Drawing.Point(455, 11);
            this.textBoxGainNet.Name = "textBoxGainNet";
            this.textBoxGainNet.ReadOnly = true;
            this.textBoxGainNet.Size = new System.Drawing.Size(100, 20);
            this.textBoxGainNet.TabIndex = 10;
            // 
            // labelGainNet
            // 
            this.labelGainNet.AutoSize = true;
            this.labelGainNet.Location = new System.Drawing.Point(393, 18);
            this.labelGainNet.Name = "labelGainNet";
            this.labelGainNet.Size = new System.Drawing.Size(47, 13);
            this.labelGainNet.TabIndex = 9;
            this.labelGainNet.Text = "Gain net";
            // 
            // textBoxFraisGlobaux
            // 
            this.textBoxFraisGlobaux.Location = new System.Drawing.Point(287, 15);
            this.textBoxFraisGlobaux.Name = "textBoxFraisGlobaux";
            this.textBoxFraisGlobaux.Size = new System.Drawing.Size(100, 20);
            this.textBoxFraisGlobaux.TabIndex = 8;
            this.textBoxFraisGlobaux.Text = "2200";
            // 
            // labelFraisGlobaux
            // 
            this.labelFraisGlobaux.AutoSize = true;
            this.labelFraisGlobaux.Location = new System.Drawing.Point(212, 18);
            this.labelFraisGlobaux.Name = "labelFraisGlobaux";
            this.labelFraisGlobaux.Size = new System.Drawing.Size(69, 13);
            this.labelFraisGlobaux.TabIndex = 7;
            this.labelFraisGlobaux.Text = "Frais globaux";
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Location = new System.Drawing.Point(312, 66);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculer.TabIndex = 6;
            this.buttonCalculer.Text = "TracerChart";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Location = new System.Drawing.Point(106, 68);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuree.TabIndex = 5;
            this.textBoxDuree.Text = "8";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(13, 71);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(36, 13);
            this.labelDuree.TabIndex = 4;
            this.labelDuree.Text = "Durée";
            // 
            // textBoxPrimeMensuelle
            // 
            this.textBoxPrimeMensuelle.Location = new System.Drawing.Point(106, 42);
            this.textBoxPrimeMensuelle.Name = "textBoxPrimeMensuelle";
            this.textBoxPrimeMensuelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimeMensuelle.TabIndex = 3;
            this.textBoxPrimeMensuelle.Text = "180";
            // 
            // labelPrimeMensuelle
            // 
            this.labelPrimeMensuelle.AutoSize = true;
            this.labelPrimeMensuelle.Location = new System.Drawing.Point(13, 45);
            this.labelPrimeMensuelle.Name = "labelPrimeMensuelle";
            this.labelPrimeMensuelle.Size = new System.Drawing.Size(83, 13);
            this.labelPrimeMensuelle.TabIndex = 2;
            this.labelPrimeMensuelle.Text = "Prime mensuelle";
            // 
            // textBoxTaux
            // 
            this.textBoxTaux.Location = new System.Drawing.Point(106, 15);
            this.textBoxTaux.Name = "textBoxTaux";
            this.textBoxTaux.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaux.TabIndex = 1;
            this.textBoxTaux.Text = "3";
            // 
            // labelTaux
            // 
            this.labelTaux.AutoSize = true;
            this.labelTaux.Location = new System.Drawing.Point(13, 18);
            this.labelTaux.Name = "labelTaux";
            this.labelTaux.Size = new System.Drawing.Size(49, 13);
            this.labelTaux.TabIndex = 0;
            this.labelTaux.Text = "Taux net";
            // 
            // labelGainBrut
            // 
            this.labelGainBrut.AutoSize = true;
            this.labelGainBrut.Location = new System.Drawing.Point(393, 45);
            this.labelGainBrut.Name = "labelGainBrut";
            this.labelGainBrut.Size = new System.Drawing.Size(50, 13);
            this.labelGainBrut.TabIndex = 13;
            this.labelGainBrut.Text = "Gain brut";
            // 
            // textBoxGainBrut
            // 
            this.textBoxGainBrut.Location = new System.Drawing.Point(455, 42);
            this.textBoxGainBrut.Name = "textBoxGainBrut";
            this.textBoxGainBrut.ReadOnly = true;
            this.textBoxGainBrut.Size = new System.Drawing.Size(100, 20);
            this.textBoxGainBrut.TabIndex = 14;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 451);
            this.Controls.Add(this.panelDataInput);
            this.Controls.Add(this._chart);
            this.Name = "ChartForm";
            this.Text = "Gain assurance vie";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
            this.panelDataInput.ResumeLayout(false);
            this.panelDataInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _chart;
        private System.Windows.Forms.Panel panelDataInput;
        private System.Windows.Forms.TextBox textBoxPrimeMensuelle;
        private System.Windows.Forms.Label labelPrimeMensuelle;
        private System.Windows.Forms.TextBox textBoxTaux;
        private System.Windows.Forms.Label labelTaux;
        private System.Windows.Forms.Button buttonCalculer;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.TextBox textBoxFraisGlobaux;
        private System.Windows.Forms.Label labelFraisGlobaux;
        private System.Windows.Forms.Label labelGainNet;
        private System.Windows.Forms.TextBox textBoxCotisation;
        private System.Windows.Forms.Label labelCotisation;
        private System.Windows.Forms.TextBox textBoxGainNet;
        private System.Windows.Forms.TextBox textBoxGainBrut;
        private System.Windows.Forms.Label labelGainBrut;
    }
}

