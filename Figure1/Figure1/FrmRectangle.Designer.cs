namespace Figure1
{
    partial class FrmRectangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtPaerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnClearClick = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rectangle";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(42, 104);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(42, 156);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 2;
            // 
            // txtPaerimeter
            // 
            this.txtPaerimeter.Enabled = false;
            this.txtPaerimeter.Location = new System.Drawing.Point(219, 104);
            this.txtPaerimeter.Name = "txtPaerimeter";
            this.txtPaerimeter.Size = new System.Drawing.Size(100, 22);
            this.txtPaerimeter.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(219, 156);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 4;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(57, 75);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 16);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(219, 74);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(65, 16);
            this.lblPerimeter.TabIndex = 6;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(60, 134);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeight.Size = new System.Drawing.Size(49, 16);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(219, 134);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(133, 255);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 9;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(426, 93);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(314, 248);
            this.canvas.TabIndex = 10;
            this.canvas.TabStop = false;
            // 
            // btnClearClick
            // 
            this.btnClearClick.Location = new System.Drawing.Point(244, 255);
            this.btnClearClick.Name = "btnClearClick";
            this.btnClearClick.Size = new System.Drawing.Size(75, 23);
            this.btnClearClick.TabIndex = 11;
            this.btnClearClick.Text = "Clear";
            this.btnClearClick.UseVisualStyleBackColor = true;
            this.btnClearClick.Click += new System.EventHandler(this.btnClear);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(754, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearClick);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPaerimeter);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label1);
            this.Name = "FrmRectangle";
            this.Text = "FrmRectangle";
            this.Load += new System.EventHandler(this.FrmRectangleLoad);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtPaerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnClearClick;
        private System.Windows.Forms.Button btnExit;
    }
}