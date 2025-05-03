using System;
using System.Windows.Forms;

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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gInput = new System.Windows.Forms.GroupBox();
            this.txtField4 = new System.Windows.Forms.TextBox();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.lblField4 = new System.Windows.Forms.Label();
            this.lblField3 = new System.Windows.Forms.Label();
            this.lblField2 = new System.Windows.Forms.Label();
            this.lblField1 = new System.Windows.Forms.Label();
            this.gOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.Graph = new System.Windows.Forms.GroupBox();
            this.pBGraph = new System.Windows.Forms.PictureBox();
            this.btnPlot = new System.Windows.Forms.Button();
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
            this.containerTitle.Controls.Add(this.btnClear);
            this.containerTitle.Controls.Add(this.btnBack);
            this.containerTitle.Controls.Add(this.lblTitle);
            this.containerTitle.Location = new System.Drawing.Point(-2, 0);
            this.containerTitle.Name = "containerTitle";
            this.containerTitle.Size = new System.Drawing.Size(803, 64);
            this.containerTitle.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(681, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 49);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.gInput.Controls.Add(this.txtField4);
            this.gInput.Controls.Add(this.txtField3);
            this.gInput.Controls.Add(this.txtField2);
            this.gInput.Controls.Add(this.txtField1);
            this.gInput.Controls.Add(this.lblField4);
            this.gInput.Controls.Add(this.lblField3);
            this.gInput.Controls.Add(this.lblField2);
            this.gInput.Controls.Add(this.lblField1);
            this.gInput.Location = new System.Drawing.Point(26, 19);
            this.gInput.Name = "gInput";
            this.gInput.Size = new System.Drawing.Size(232, 140);
            this.gInput.TabIndex = 4;
            this.gInput.TabStop = false;
            this.gInput.Text = "Inputs";
            // 
            // txtField4
            // 
            this.txtField4.BackColor = System.Drawing.Color.Snow;
            this.txtField4.Location = new System.Drawing.Point(77, 112);
            this.txtField4.Name = "txtField4";
            this.txtField4.Size = new System.Drawing.Size(149, 22);
            this.txtField4.TabIndex = 7;
            // 
            // txtField3
            // 
            this.txtField3.BackColor = System.Drawing.Color.Snow;
            this.txtField3.Location = new System.Drawing.Point(77, 82);
            this.txtField3.Name = "txtField3";
            this.txtField3.Size = new System.Drawing.Size(149, 22);
            this.txtField3.TabIndex = 6;
            // 
            // txtField2
            // 
            this.txtField2.BackColor = System.Drawing.Color.Snow;
            this.txtField2.Location = new System.Drawing.Point(77, 54);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(149, 22);
            this.txtField2.TabIndex = 5;
            // 
            // txtField1
            // 
            this.txtField1.BackColor = System.Drawing.Color.Snow;
            this.txtField1.Location = new System.Drawing.Point(77, 24);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(149, 22);
            this.txtField1.TabIndex = 4;
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblField4.Location = new System.Drawing.Point(6, 110);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(44, 16);
            this.lblField4.TabIndex = 3;
            this.lblField4.Text = "label1";
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblField3.Location = new System.Drawing.Point(6, 82);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(44, 16);
            this.lblField3.TabIndex = 2;
            this.lblField3.Text = "label1";
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblField2.Location = new System.Drawing.Point(6, 54);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(44, 16);
            this.lblField2.TabIndex = 1;
            this.lblField2.Text = "label1";
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblField1.Location = new System.Drawing.Point(6, 27);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(44, 16);
            this.lblField1.TabIndex = 0;
            this.lblField1.Text = "label1";
            // 
            // gOutputs
            // 
            this.gOutputs.Controls.Add(this.txtArea);
            this.gOutputs.Controls.Add(this.txtPerimeter);
            this.gOutputs.Controls.Add(this.lblArea);
            this.gOutputs.Controls.Add(this.lblPerimeter);
            this.gOutputs.Location = new System.Drawing.Point(26, 165);
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
            this.Graph.Size = new System.Drawing.Size(385, 343);
            this.Graph.TabIndex = 7;
            this.Graph.TabStop = false;
            this.Graph.Text = "Graph:";
            // 
            // pBGraph
            // 
            this.pBGraph.Location = new System.Drawing.Point(16, 32);
            this.pBGraph.Name = "pBGraph";
            this.pBGraph.Size = new System.Drawing.Size(352, 289);
            this.pBGraph.TabIndex = 0;
            this.pBGraph.TabStop = false;
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.ForeColor = System.Drawing.Color.White;
            this.btnPlot.Location = new System.Drawing.Point(47, 391);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(119, 49);
            this.btnPlot.TabIndex = 10;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = false;
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(803, 452);
            this.Controls.Add(this.btnPlot);
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

            labels = new Label[] { lblField1, lblField2, lblField3, lblField4 };
            textBoxes = new TextBox[] { txtField1, txtField2, txtField3, txtField4 };

        }

        #endregion

        public System.Windows.Forms.Panel containerTitle;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.GroupBox gInput;
        public System.Windows.Forms.GroupBox gOutputs;
        public System.Windows.Forms.Panel pData;
        public System.Windows.Forms.Label lblPerimeter;
        public System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.GroupBox Graph;
        public System.Windows.Forms.PictureBox pBGraph;
        public System.Windows.Forms.TextBox txtPerimeter;
        public System.Windows.Forms.TextBox txtArea;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnBack;


        public void SetFormTitle(string title) {
            lblTitle.Text = title;
        }
        private Label[] labels;
        private TextBox[] textBoxes;
        public void SetFieldLabel(int fieldNumber, string label)
        {
            if (fieldNumber < 0 || fieldNumber >= labels.Length)
            {
                throw new System.ArgumentOutOfRangeException(nameof(fieldNumber), "Field number is out of range.");
            }
            labels[fieldNumber].Text = label;
        }

        public void setFieldVisibility(int position, bool visibility) {
            if (position < 0 || position >= textBoxes.Length)
            {
                throw new System.ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }
            
            textBoxes[position].Visible = visibility;
        }

        public void setNumberOfFields(int number) {
            if (number > 4 || number < 0) {
                throw new System.ArgumentOutOfRangeException(nameof(number), "Number of fields is out of range.");
            }
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = i < number;
                textBoxes[i].Visible = i < number;
            }
        }

        public void setClearButtonClickEvent(EventHandler eventHandler)
        {
            btnClear.Click += eventHandler;
        }

        public void setPlotButtonClickEvent(EventHandler eventHandler)
        {
            btnPlot.Click += eventHandler;
        }



        public System.Windows.Forms.TextBox txtField2 ;
        public System.Windows.Forms.TextBox txtField1;
        public System.Windows.Forms.Label lblField4;
        public System.Windows.Forms.Label lblField3;
        public System.Windows.Forms.Label lblField2;
        public System.Windows.Forms.Label lblField1;
        public System.Windows.Forms.TextBox txtField4;
        public System.Windows.Forms.TextBox txtField3;
        public Button btnPlot;
    }

}