using FontAwesome.Sharp;
using System.Windows.Forms;

namespace GraphExamples.Views.shared
{
    partial class BaseFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.btnPlot = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-5, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 79);
            this.panel2.TabIndex = 2;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Gold;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnConfig.IconColor = System.Drawing.Color.Black;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.Location = new System.Drawing.Point(830, 19);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(53, 52);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 32;
            this.btnBack.Location = new System.Drawing.Point(54, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(152, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Grapher App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.canvas);
            this.panel1.Location = new System.Drawing.Point(269, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 396);
            this.panel1.TabIndex = 6;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(3, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(577, 389);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Gold;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 24;
            this.btnReload.Location = new System.Drawing.Point(285, 502);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(95, 40);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Restart";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.Color.Gold;
            this.btnPlot.FlatAppearance.BorderSize = 0;
            this.btnPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlot.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnPlot.IconColor = System.Drawing.Color.Black;
            this.btnPlot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlot.IconSize = 24;
            this.btnPlot.Location = new System.Drawing.Point(740, 502);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(95, 40);
            this.btnPlot.TabIndex = 4;
            this.btnPlot.Text = "PLOT";
            this.btnPlot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlot.UseVisualStyleBackColor = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(905, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
            this.Load += new System.EventHandler(this.BaseFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblTitle;
        public FontAwesome.Sharp.IconButton btnBack;
        public System.Windows.Forms.PictureBox canvas;
        public FontAwesome.Sharp.IconButton btnPlot;
        public FontAwesome.Sharp.IconButton btnReload;
        public Panel panel1;
        public Label label1;
        public IconButton btnConfig;
    }
}