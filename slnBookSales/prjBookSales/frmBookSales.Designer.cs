namespace prjBookSales
{
    partial class frmBookSales
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSavingsDisplay = new System.Windows.Forms.Label();
            this.lblDiscountDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Button();
            this.lblDollar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(32, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(32, 81);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(48, 13);
            this.lblSavings.TabIndex = 3;
            this.lblSavings.Text = "Savings:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(32, 129);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Discounted Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(139, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblSavingsDisplay
            // 
            this.lblSavingsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSavingsDisplay.Location = new System.Drawing.Point(139, 71);
            this.lblSavingsDisplay.Name = "lblSavingsDisplay";
            this.lblSavingsDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblSavingsDisplay.TabIndex = 5;
            this.lblSavingsDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblDiscountDisplay
            // 
            this.lblDiscountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscountDisplay.Location = new System.Drawing.Point(139, 119);
            this.lblDiscountDisplay.Name = "lblDiscountDisplay";
            this.lblDiscountDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDiscountDisplay.TabIndex = 8;
            this.lblDiscountDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(57, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblClear
            // 
            this.lblClear.Location = new System.Drawing.Point(153, 172);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(75, 23);
            this.lblClear.TabIndex = 10;
            this.lblClear.Text = "&Clear";
            this.lblClear.UseVisualStyleBackColor = true;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // lblExit
            // 
            this.lblExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lblExit.Location = new System.Drawing.Point(103, 212);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(75, 23);
            this.lblExit.TabIndex = 11;
            this.lblExit.Text = "&Exit";
            this.lblExit.UseVisualStyleBackColor = true;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblDollar1
            // 
            this.lblDollar1.AutoSize = true;
            this.lblDollar1.Location = new System.Drawing.Point(125, 26);
            this.lblDollar1.Name = "lblDollar1";
            this.lblDollar1.Size = new System.Drawing.Size(13, 13);
            this.lblDollar1.TabIndex = 1;
            this.lblDollar1.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // frmBookSales
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDollar1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDiscountDisplay);
            this.Controls.Add(this.lblSavingsDisplay);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblTotal);
            this.Name = "frmBookSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FVTC Book Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSavingsDisplay;
        private System.Windows.Forms.Label lblDiscountDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button lblClear;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.Label lblDollar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

