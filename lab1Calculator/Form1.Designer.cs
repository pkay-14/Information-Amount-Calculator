namespace lab1Calculator
{
    partial class Form1
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
            this.labelPx = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDispersion = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblDeviation = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtDeviation = new System.Windows.Forms.TextBox();
            this.txtDispersion = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.flowLayoutPanelPx = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message amount Calculator";
            // 
            // labelPx
            // 
            this.labelPx.AutoSize = true;
            this.labelPx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPx.ForeColor = System.Drawing.Color.White;
            this.labelPx.Location = new System.Drawing.Point(12, 121);
            this.labelPx.Name = "labelPx";
            this.labelPx.Size = new System.Drawing.Size(194, 19);
            this.labelPx.TabIndex = 1;
            this.labelPx.Text = "Enter appropriate P(x)";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(12, 90);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(217, 19);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Enter number of X results";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(247, 92);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(45, 20);
            this.txtX.TabIndex = 3;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(12, 210);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(196, 19);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount of Information";
            // 
            // lblDispersion
            // 
            this.lblDispersion.AutoSize = true;
            this.lblDispersion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispersion.ForeColor = System.Drawing.Color.White;
            this.lblDispersion.Location = new System.Drawing.Point(243, 352);
            this.lblDispersion.Name = "lblDispersion";
            this.lblDispersion.Size = new System.Drawing.Size(260, 19);
            this.lblDispersion.TabIndex = 6;
            this.lblDispersion.Text = "Dispersion of Random Variable";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.ForeColor = System.Drawing.Color.White;
            this.lblAvg.Location = new System.Drawing.Point(243, 230);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(109, 19);
            this.lblAvg.TabIndex = 7;
            this.lblAvg.Text = "Avg Amount";
            // 
            // lblDeviation
            // 
            this.lblDeviation.AutoSize = true;
            this.lblDeviation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviation.ForeColor = System.Drawing.Color.White;
            this.lblDeviation.Location = new System.Drawing.Point(243, 284);
            this.lblDeviation.Name = "lblDeviation";
            this.lblDeviation.Size = new System.Drawing.Size(87, 19);
            this.lblDeviation.TabIndex = 8;
            this.lblDeviation.Text = "Deviation";
            // 
            // txtAvg
            // 
            this.txtAvg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvg.ForeColor = System.Drawing.Color.Black;
            this.txtAvg.Location = new System.Drawing.Point(375, 232);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(167, 20);
            this.txtAvg.TabIndex = 10;
            // 
            // txtDeviation
            // 
            this.txtDeviation.Location = new System.Drawing.Point(375, 284);
            this.txtDeviation.Name = "txtDeviation";
            this.txtDeviation.ReadOnly = true;
            this.txtDeviation.Size = new System.Drawing.Size(167, 20);
            this.txtDeviation.TabIndex = 11;
            // 
            // txtDispersion
            // 
            this.txtDispersion.Location = new System.Drawing.Point(509, 352);
            this.txtDispersion.Name = "txtDispersion";
            this.txtDispersion.ReadOnly = true;
            this.txtDispersion.Size = new System.Drawing.Size(162, 20);
            this.txtDispersion.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(44, 456);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(131, 44);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(311, 456);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 44);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(298, 92);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 23);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flowLayoutPanelPx
            // 
            this.flowLayoutPanelPx.Location = new System.Drawing.Point(212, 121);
            this.flowLayoutPanelPx.Name = "flowLayoutPanelPx";
            this.flowLayoutPanelPx.Size = new System.Drawing.Size(459, 22);
            this.flowLayoutPanelPx.TabIndex = 36;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(28, 232);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAmount.Size = new System.Drawing.Size(162, 209);
            this.txtAmount.TabIndex = 37;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(683, 556);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.flowLayoutPanelPx);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDispersion);
            this.Controls.Add(this.txtDeviation);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.lblDeviation);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblDispersion);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelPx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPx;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDispersion;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblDeviation;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtDeviation;
        private System.Windows.Forms.TextBox txtDispersion;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPx;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

