namespace GraphExamples.Views
{
    partial class FrmBresenhamCircle
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
            this.blradio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lbPoints = new System.Windows.Forms.ListBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.FlatAppearance.BorderSize = 0;
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderSize = 0;
            // 
            // blradio
            // 
            this.blradio.AutoSize = true;
            this.blradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blradio.Location = new System.Drawing.Point(34, 152);
            this.blradio.Name = "blradio";
            this.blradio.Size = new System.Drawing.Size(68, 25);
            this.blradio.TabIndex = 8;
            this.blradio.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(125, 155);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(77, 22);
            this.txtRadio.TabIndex = 9;
            // 
            // lbPoints
            // 
            this.lbPoints.FormattingEnabled = true;
            this.lbPoints.ItemHeight = 16;
            this.lbPoints.Location = new System.Drawing.Point(39, 238);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(214, 148);
            this.lbPoints.TabIndex = 10;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(156, 442);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(77, 22);
            this.txtPoints.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "N of Points";
            // 
            // FrmBresenhamCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 576);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.blradio);
            this.Name = "FrmBresenhamCircle";
            this.Text = "FrmBresenhamCircle";
            this.Controls.SetChildIndex(this.blradio, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnPlot, 0);
            this.Controls.SetChildIndex(this.btnReload, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRadio, 0);
            this.Controls.SetChildIndex(this.lbPoints, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPoints, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blradio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.ListBox lbPoints;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label2;
    }
}