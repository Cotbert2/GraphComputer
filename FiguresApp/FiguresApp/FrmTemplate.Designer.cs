namespace FiguresApp
{
    partial class FrmTemplate
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
            this.containerTitle = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gInput = new System.Windows.Forms.GroupBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.gOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.Graph = new System.Windows.Forms.GroupBox();
            this.pBGraph = new System.Windows.Forms.PictureBox();
            this.containerTitle.SuspendLayout();
            this.gInput.SuspendLayout();
            this.gOutputs.SuspendLayout();
            this.pData.SuspendLayout();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // containerTitle
            // 
            this.containerTitle.BackColor = System.Drawing.Color.Salmon;
            this.containerTitle.Controls.Add(this.pnlHeader);
            this.containerTitle.Controls.Add(this.btnBack);
            this.containerTitle.Controls.Add(this.lblTitle);
            this.containerTitle.Location = new System.Drawing.Point(-2, 0);
            this.containerTitle.Name = "containerTitle";
            this.containerTitle.Size = new System.Drawing.Size(803, 64);
            this.containerTitle.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.IndianRed;
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(681, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(119, 49);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.Text = "Clear";
            this.pnlHeader.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 49);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(343, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "My View Title";
            // 
            // gInput
            // 
            this.gInput.Controls.Add(this.lblSide);
            this.gInput.Location = new System.Drawing.Point(26, 19);
            this.gInput.Name = "gInput";
            this.gInput.Size = new System.Drawing.Size(232, 104);
            this.gInput.TabIndex = 4;
            this.gInput.TabStop = false;
            this.gInput.Text = "Inputs";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSide.Location = new System.Drawing.Point(6, 40);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(38, 16);
            this.lblSide.TabIndex = 4;
            this.lblSide.Text = "Side:";
            // 
            // gOutputs
            // 
            this.gOutputs.Controls.Add(this.txtArea);
            this.gOutputs.Controls.Add(this.txtPerimeter);
            this.gOutputs.Controls.Add(this.lblArea);
            this.gOutputs.Controls.Add(this.lblPerimeter);
            this.gOutputs.Location = new System.Drawing.Point(26, 141);
            this.gOutputs.Name = "gOutputs";
            this.gOutputs.Size = new System.Drawing.Size(232, 104);
            this.gOutputs.TabIndex = 5;
            this.gOutputs.TabStop = false;
            this.gOutputs.Text = "Outputs";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.Snow;
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(77, 68);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(149, 22);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.Color.Snow;
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(77, 29);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(149, 22);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(6, 74);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerimeter.Location = new System.Drawing.Point(6, 32);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(68, 16);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            // pData
            // 
            this.pData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.pData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pData.Controls.Add(this.gInput);
            this.pData.Controls.Add(this.gOutputs);
            this.pData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pData.Location = new System.Drawing.Point(47, 97);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(284, 284);
            this.pData.TabIndex = 6;
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.Graph.Controls.Add(this.pBGraph);
            this.Graph.Location = new System.Drawing.Point(406, 97);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(318, 284);
            this.Graph.TabIndex = 7;
            this.Graph.TabStop = false;
            this.Graph.Text = "Graph:";
            // 
            // pBGraph
            // 
            this.pBGraph.Location = new System.Drawing.Point(16, 32);
            this.pBGraph.Name = "pBGraph";
            this.pBGraph.Size = new System.Drawing.Size(281, 227);
            this.pBGraph.TabIndex = 0;
            this.pBGraph.TabStop = false;
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(803, 452);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.containerTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTemplate";
            this.Text = "FrmTriangle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
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

        private System.Windows.Forms.Panel containerTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gInput;
        private System.Windows.Forms.GroupBox gOutputs;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox Graph;
        private System.Windows.Forms.PictureBox pBGraph;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button pnlHeader;
        private System.Windows.Forms.Button btnBack;


        public void SetFormTitle(string title) {
            lblTitle.Text = title;
        }
    }

}