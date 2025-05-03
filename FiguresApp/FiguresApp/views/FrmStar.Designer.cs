namespace FiguresApp
{
    partial class FrmStar : FrmTemplate
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
            this.containerTitle.SuspendLayout();
            this.gInput.SuspendLayout();
            this.gOutputs.SuspendLayout();
            this.pData.SuspendLayout();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // FrmStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(803, 452);
            this.Name = "FrmStar";
            this.Load += new System.EventHandler(this.FrmStar_Load);
            this.containerTitle.ResumeLayout(false);
            this.containerTitle.PerformLayout();
            this.gInput.ResumeLayout(false);
            this.gInput.PerformLayout();
            this.gOutputs.ResumeLayout(false);
            this.gOutputs.PerformLayout();
            this.pData.ResumeLayout(false);
            this.Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}