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
            ((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
            this.SuspendLayout();
            // 
            // _chart
            // 
            this._chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chart.Location = new System.Drawing.Point(0, 0);
            this._chart.Name = "_chart";
            this._chart.Size = new System.Drawing.Size(579, 403);
            this._chart.TabIndex = 0;
            this._chart.TabStop = false;
            this._chart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 403);
            this.Controls.Add(this._chart);
            this.Name = "ChartForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _chart;
    }
}

