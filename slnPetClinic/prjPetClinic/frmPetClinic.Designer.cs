namespace prjPetClinic
{
    partial class frmPetClinic
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
            this.chkService1 = new System.Windows.Forms.CheckBox();
            this.chkService2 = new System.Windows.Forms.CheckBox();
            this.chkService3 = new System.Windows.Forms.CheckBox();
            this.chkService4 = new System.Windows.Forms.CheckBox();
            this.chkService5 = new System.Windows.Forms.CheckBox();
            this.chkService6 = new System.Windows.Forms.CheckBox();
            this.chkService7 = new System.Windows.Forms.CheckBox();
            this.chkService8 = new System.Windows.Forms.CheckBox();
            this.lblCost1 = new System.Windows.Forms.Label();
            this.lblCost2 = new System.Windows.Forms.Label();
            this.lblCost3 = new System.Windows.Forms.Label();
            this.lblCost4 = new System.Windows.Forms.Label();
            this.lblCost5 = new System.Windows.Forms.Label();
            this.lblCost6 = new System.Windows.Forms.Label();
            this.lblCost7 = new System.Windows.Forms.Label();
            this.lblCost8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkService1
            // 
            this.chkService1.AutoSize = true;
            this.chkService1.Location = new System.Drawing.Point(45, 28);
            this.chkService1.Name = "chkService1";
            this.chkService1.Size = new System.Drawing.Size(118, 17);
            this.chkService1.TabIndex = 0;
            this.chkService1.Text = "Small Pet Grooming";
            this.chkService1.UseVisualStyleBackColor = true;
            this.chkService1.CheckedChanged += new System.EventHandler(this.chkService1_CheckedChanged);
            // 
            // chkService2
            // 
            this.chkService2.AutoSize = true;
            this.chkService2.Location = new System.Drawing.Point(45, 65);
            this.chkService2.Name = "chkService2";
            this.chkService2.Size = new System.Drawing.Size(120, 17);
            this.chkService2.TabIndex = 2;
            this.chkService2.Text = "Large Pet Grooming";
            this.chkService2.UseVisualStyleBackColor = true;
            this.chkService2.CheckedChanged += new System.EventHandler(this.chkService2_CheckedChanged);
            // 
            // chkService3
            // 
            this.chkService3.AutoSize = true;
            this.chkService3.Location = new System.Drawing.Point(45, 102);
            this.chkService3.Name = "chkService3";
            this.chkService3.Size = new System.Drawing.Size(82, 17);
            this.chkService3.TabIndex = 4;
            this.chkService3.Text = "Vaccination";
            this.chkService3.UseVisualStyleBackColor = true;
            this.chkService3.CheckedChanged += new System.EventHandler(this.chkService3_CheckedChanged);
            // 
            // chkService4
            // 
            this.chkService4.AutoSize = true;
            this.chkService4.Location = new System.Drawing.Point(45, 139);
            this.chkService4.Name = "chkService4";
            this.chkService4.Size = new System.Drawing.Size(74, 17);
            this.chkService4.TabIndex = 6;
            this.chkService4.Text = "Check Up";
            this.chkService4.UseVisualStyleBackColor = true;
            this.chkService4.CheckedChanged += new System.EventHandler(this.chkService4_CheckedChanged);
            // 
            // chkService5
            // 
            this.chkService5.AutoSize = true;
            this.chkService5.Location = new System.Drawing.Point(45, 176);
            this.chkService5.Name = "chkService5";
            this.chkService5.Size = new System.Drawing.Size(57, 17);
            this.chkService5.TabIndex = 8;
            this.chkService5.Text = "Dental";
            this.chkService5.UseVisualStyleBackColor = true;
            this.chkService5.CheckedChanged += new System.EventHandler(this.chkService5_CheckedChanged);
            // 
            // chkService6
            // 
            this.chkService6.AutoSize = true;
            this.chkService6.Location = new System.Drawing.Point(45, 213);
            this.chkService6.Name = "chkService6";
            this.chkService6.Size = new System.Drawing.Size(62, 17);
            this.chkService6.TabIndex = 10;
            this.chkService6.Text = "Surgery";
            this.chkService6.UseVisualStyleBackColor = true;
            this.chkService6.CheckedChanged += new System.EventHandler(this.chkService6_CheckedChanged);
            // 
            // chkService7
            // 
            this.chkService7.AutoSize = true;
            this.chkService7.Location = new System.Drawing.Point(45, 250);
            this.chkService7.Name = "chkService7";
            this.chkService7.Size = new System.Drawing.Size(96, 17);
            this.chkService7.TabIndex = 12;
            this.chkService7.Text = "Boarding - Day";
            this.chkService7.UseVisualStyleBackColor = true;
            this.chkService7.CheckedChanged += new System.EventHandler(this.chkService7_CheckedChanged);
            // 
            // chkService8
            // 
            this.chkService8.AutoSize = true;
            this.chkService8.Location = new System.Drawing.Point(45, 287);
            this.chkService8.Name = "chkService8";
            this.chkService8.Size = new System.Drawing.Size(106, 17);
            this.chkService8.TabIndex = 14;
            this.chkService8.Text = "Boarding - Week";
            this.chkService8.UseVisualStyleBackColor = true;
            this.chkService8.CheckedChanged += new System.EventHandler(this.chkService8_CheckedChanged);
            // 
            // lblCost1
            // 
            this.lblCost1.AutoSize = true;
            this.lblCost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCost1.Location = new System.Drawing.Point(221, 32);
            this.lblCost1.Name = "lblCost1";
            this.lblCost1.Size = new System.Drawing.Size(46, 13);
            this.lblCost1.TabIndex = 1;
            this.lblCost1.Text = "$10.00";
            this.lblCost1.Visible = false;
            // 
            // lblCost2
            // 
            this.lblCost2.AutoSize = true;
            this.lblCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCost2.Location = new System.Drawing.Point(221, 69);
            this.lblCost2.Name = "lblCost2";
            this.lblCost2.Size = new System.Drawing.Size(46, 13);
            this.lblCost2.TabIndex = 3;
            this.lblCost2.Text = "$15.00";
            this.lblCost2.Visible = false;
            // 
            // lblCost3
            // 
            this.lblCost3.AutoSize = true;
            this.lblCost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost3.Location = new System.Drawing.Point(221, 106);
            this.lblCost3.Name = "lblCost3";
            this.lblCost3.Size = new System.Drawing.Size(46, 13);
            this.lblCost3.TabIndex = 5;
            this.lblCost3.Text = "$25.00";
            this.lblCost3.Visible = false;
            // 
            // lblCost4
            // 
            this.lblCost4.AutoSize = true;
            this.lblCost4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost4.Location = new System.Drawing.Point(221, 143);
            this.lblCost4.Name = "lblCost4";
            this.lblCost4.Size = new System.Drawing.Size(46, 13);
            this.lblCost4.TabIndex = 7;
            this.lblCost4.Text = "$50.00";
            this.lblCost4.Visible = false;
            // 
            // lblCost5
            // 
            this.lblCost5.AutoSize = true;
            this.lblCost5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost5.Location = new System.Drawing.Point(221, 180);
            this.lblCost5.Name = "lblCost5";
            this.lblCost5.Size = new System.Drawing.Size(46, 13);
            this.lblCost5.TabIndex = 9;
            this.lblCost5.Text = "$45.00";
            this.lblCost5.Visible = false;
            // 
            // lblCost6
            // 
            this.lblCost6.AutoSize = true;
            this.lblCost6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost6.Location = new System.Drawing.Point(221, 217);
            this.lblCost6.Name = "lblCost6";
            this.lblCost6.Size = new System.Drawing.Size(53, 13);
            this.lblCost6.TabIndex = 11;
            this.lblCost6.Text = "$100.00";
            this.lblCost6.Visible = false;
            // 
            // lblCost7
            // 
            this.lblCost7.AutoSize = true;
            this.lblCost7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost7.Location = new System.Drawing.Point(221, 254);
            this.lblCost7.Name = "lblCost7";
            this.lblCost7.Size = new System.Drawing.Size(46, 13);
            this.lblCost7.TabIndex = 13;
            this.lblCost7.Text = "$40.00";
            this.lblCost7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCost7.Visible = false;
            // 
            // lblCost8
            // 
            this.lblCost8.AutoSize = true;
            this.lblCost8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost8.Location = new System.Drawing.Point(221, 291);
            this.lblCost8.Name = "lblCost8";
            this.lblCost8.Size = new System.Drawing.Size(53, 13);
            this.lblCost8.TabIndex = 15;
            this.lblCost8.Text = "$200.00";
            this.lblCost8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCost8.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(88, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(92, 325);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(40, 13);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Total:";
            // 
            // lblSubtotalDisplay
            // 
            this.lblSubtotalDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSubtotalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalDisplay.Location = new System.Drawing.Point(174, 316);
            this.lblSubtotalDisplay.Name = "lblSubtotalDisplay";
            this.lblSubtotalDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalDisplay.TabIndex = 17;
            this.lblSubtotalDisplay.Text = "0";
            this.lblSubtotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(352, 437);
            this.Controls.Add(this.lblSubtotalDisplay);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCost8);
            this.Controls.Add(this.lblCost7);
            this.Controls.Add(this.lblCost6);
            this.Controls.Add(this.lblCost5);
            this.Controls.Add(this.lblCost4);
            this.Controls.Add(this.lblCost3);
            this.Controls.Add(this.lblCost2);
            this.Controls.Add(this.lblCost1);
            this.Controls.Add(this.chkService8);
            this.Controls.Add(this.chkService7);
            this.Controls.Add(this.chkService6);
            this.Controls.Add(this.chkService5);
            this.Controls.Add(this.chkService4);
            this.Controls.Add(this.chkService3);
            this.Controls.Add(this.chkService2);
            this.Controls.Add(this.chkService1);
            this.Name = "frmPetClinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lions, Tigers and Bears Pet Clinic Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkService1;
        private System.Windows.Forms.CheckBox chkService2;
        private System.Windows.Forms.CheckBox chkService3;
        private System.Windows.Forms.CheckBox chkService4;
        private System.Windows.Forms.CheckBox chkService5;
        private System.Windows.Forms.CheckBox chkService6;
        private System.Windows.Forms.CheckBox chkService7;
        private System.Windows.Forms.CheckBox chkService8;
        private System.Windows.Forms.Label lblCost1;
        private System.Windows.Forms.Label lblCost2;
        private System.Windows.Forms.Label lblCost3;
        private System.Windows.Forms.Label lblCost4;
        private System.Windows.Forms.Label lblCost5;
        private System.Windows.Forms.Label lblCost6;
        private System.Windows.Forms.Label lblCost7;
        private System.Windows.Forms.Label lblCost8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalDisplay;
    }
}

