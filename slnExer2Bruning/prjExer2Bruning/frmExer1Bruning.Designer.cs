namespace prjExer2Bruning
{
    partial class frmExer1Bruning
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
            this.lblBooks = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.Location = new System.Drawing.Point(51, 45);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(119, 38);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "Enter the number of books that are overdue";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(199, 54);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(100, 20);
            this.txtBooks.TabIndex = 1;
            this.txtBooks.TextChanged += new System.EventHandler(this.txtBooks_TextChanged);
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(51, 97);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(119, 38);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Enter the number of days overdue";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(199, 106);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 3;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(65, 165);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(251, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFine
            // 
            this.lblFine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(116, 213);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(54, 24);
            this.lblFine.TabIndex = 7;
            this.lblFine.Text = "Fine";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(196, 213);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 24);
            this.lblAmount.TabIndex = 8;
            // 
            // frmExer1Bruning
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lblBooks);
            this.Name = "frmExer1Bruning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 2 ~ Library Fine Calculator";
            this.Load += new System.EventHandler(this.frmExer1Bruning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblAmount;
    }
}

