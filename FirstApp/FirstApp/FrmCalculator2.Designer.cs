namespace FirstApp
{
    partial class FrmCalculator2
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
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdbtnAdd = new System.Windows.Forms.RadioButton();
            this.rdbtnSustract = new System.Windows.Forms.RadioButton();
            this.rdbtnDivide = new System.Windows.Forms.RadioButton();
            this.rdbtnMulti = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Location = new System.Drawing.Point(586, 177);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(72, 16);
            this.lblResultLabel.TabIndex = 21;
            this.lblResultLabel.Text = "Resultado:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(583, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 20;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(259, 233);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(71, 16);
            this.lblNum2.TabIndex = 15;
            this.lblNum2.Text = "Operando:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(256, 178);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(71, 16);
            this.lblNum1.TabIndex = 14;
            this.lblNum1.Text = "Operando:";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(349, 233);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 13;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(349, 175);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(296, 96);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 32);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Calculadora";
            // 
            // rdbtnAdd
            // 
            this.rdbtnAdd.AutoSize = true;
            this.rdbtnAdd.Location = new System.Drawing.Point(226, 324);
            this.rdbtnAdd.Name = "rdbtnAdd";
            this.rdbtnAdd.Size = new System.Drawing.Size(67, 20);
            this.rdbtnAdd.TabIndex = 22;
            this.rdbtnAdd.TabStop = true;
            this.rdbtnAdd.Text = "Sumar";
            this.rdbtnAdd.UseVisualStyleBackColor = true;
            this.rdbtnAdd.CheckedChanged += new System.EventHandler(this.rdbtnAdd_CheckedChanged);
            // 
            // rdbtnSustract
            // 
            this.rdbtnSustract.AutoSize = true;
            this.rdbtnSustract.Location = new System.Drawing.Point(325, 324);
            this.rdbtnSustract.Name = "rdbtnSustract";
            this.rdbtnSustract.Size = new System.Drawing.Size(68, 20);
            this.rdbtnSustract.TabIndex = 23;
            this.rdbtnSustract.TabStop = true;
            this.rdbtnSustract.Text = "Restar";
            this.rdbtnSustract.UseVisualStyleBackColor = true;
            this.rdbtnSustract.CheckedChanged += new System.EventHandler(this.rdbtnSustract_CheckedChanged);
            // 
            // rdbtnDivide
            // 
            this.rdbtnDivide.AutoSize = true;
            this.rdbtnDivide.Location = new System.Drawing.Point(412, 324);
            this.rdbtnDivide.Name = "rdbtnDivide";
            this.rdbtnDivide.Size = new System.Drawing.Size(66, 20);
            this.rdbtnDivide.TabIndex = 24;
            this.rdbtnDivide.TabStop = true;
            this.rdbtnDivide.Text = "Dividir";
            this.rdbtnDivide.UseVisualStyleBackColor = true;
            this.rdbtnDivide.CheckedChanged += new System.EventHandler(this.rdbtnDivide_CheckedChanged);
            // 
            // rdbtnMulti
            // 
            this.rdbtnMulti.AutoSize = true;
            this.rdbtnMulti.Location = new System.Drawing.Point(495, 324);
            this.rdbtnMulti.Name = "rdbtnMulti";
            this.rdbtnMulti.Size = new System.Drawing.Size(88, 20);
            this.rdbtnMulti.TabIndex = 25;
            this.rdbtnMulti.TabStop = true;
            this.rdbtnMulti.Text = "Multiplicar";
            this.rdbtnMulti.UseVisualStyleBackColor = true;
            this.rdbtnMulti.CheckedChanged += new System.EventHandler(this.rdbtnMulti_CheckedChanged);
            // 
            // FrmCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbtnMulti);
            this.Controls.Add(this.rdbtnDivide);
            this.Controls.Add(this.rdbtnSustract);
            this.Controls.Add(this.rdbtnAdd);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCalculator2";
            this.Text = "FrmCalculator2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdbtnAdd;
        private System.Windows.Forms.RadioButton rdbtnSustract;
        private System.Windows.Forms.RadioButton rdbtnDivide;
        private System.Windows.Forms.RadioButton rdbtnMulti;
    }
}