namespace prjStateCapitals
{
    partial class frmStateCapitals
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
            this.btnWisconsin = new System.Windows.Forms.Button();
            this.btnGeorgia = new System.Windows.Forms.Button();
            this.btnColorado = new System.Windows.Forms.Button();
            this.btnCalifornia = new System.Windows.Forms.Button();
            this.btnNewYork = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCapitalOf = new System.Windows.Forms.Label();
            this.lblIs = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWisconsin
            // 
            this.btnWisconsin.Location = new System.Drawing.Point(54, 65);
            this.btnWisconsin.Name = "btnWisconsin";
            this.btnWisconsin.Size = new System.Drawing.Size(99, 40);
            this.btnWisconsin.TabIndex = 0;
            this.btnWisconsin.Text = "Wisconsin";
            this.btnWisconsin.UseVisualStyleBackColor = true;
            this.btnWisconsin.Click += new System.EventHandler(this.btnWisconsin_Click);
            // 
            // btnGeorgia
            // 
            this.btnGeorgia.Location = new System.Drawing.Point(54, 122);
            this.btnGeorgia.Name = "btnGeorgia";
            this.btnGeorgia.Size = new System.Drawing.Size(99, 40);
            this.btnGeorgia.TabIndex = 1;
            this.btnGeorgia.Text = "Georgia";
            this.btnGeorgia.UseVisualStyleBackColor = true;
            this.btnGeorgia.Click += new System.EventHandler(this.btnGeorgia_Click);
            // 
            // btnColorado
            // 
            this.btnColorado.Location = new System.Drawing.Point(54, 179);
            this.btnColorado.Name = "btnColorado";
            this.btnColorado.Size = new System.Drawing.Size(99, 40);
            this.btnColorado.TabIndex = 2;
            this.btnColorado.Text = "Colorado";
            this.btnColorado.UseVisualStyleBackColor = true;
            this.btnColorado.Click += new System.EventHandler(this.btnColorado_Click);
            // 
            // btnCalifornia
            // 
            this.btnCalifornia.Location = new System.Drawing.Point(54, 237);
            this.btnCalifornia.Name = "btnCalifornia";
            this.btnCalifornia.Size = new System.Drawing.Size(99, 40);
            this.btnCalifornia.TabIndex = 3;
            this.btnCalifornia.Text = "California";
            this.btnCalifornia.UseVisualStyleBackColor = true;
            this.btnCalifornia.Click += new System.EventHandler(this.btnCalifornia_Click);
            // 
            // btnNewYork
            // 
            this.btnNewYork.Location = new System.Drawing.Point(54, 293);
            this.btnNewYork.Name = "btnNewYork";
            this.btnNewYork.Size = new System.Drawing.Size(99, 40);
            this.btnNewYork.TabIndex = 4;
            this.btnNewYork.Text = "New York";
            this.btnNewYork.UseVisualStyleBackColor = true;
            this.btnNewYork.Click += new System.EventHandler(this.btnNewYork_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(315, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCapitalOf
            // 
            this.lblCapitalOf.AutoSize = true;
            this.lblCapitalOf.Location = new System.Drawing.Point(247, 65);
            this.lblCapitalOf.Name = "lblCapitalOf";
            this.lblCapitalOf.Size = new System.Drawing.Size(72, 13);
            this.lblCapitalOf.TabIndex = 7;
            this.lblCapitalOf.Text = "The capital of";
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Location = new System.Drawing.Point(247, 158);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(14, 13);
            this.lblIs.TabIndex = 8;
            this.lblIs.Text = "is";
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(275, 92);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(100, 23);
            this.lblState.TabIndex = 9;
            // 
            // lblCapital
            // 
            this.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCapital.Location = new System.Drawing.Point(275, 192);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(100, 23);
            this.lblCapital.TabIndex = 10;
            // 
            // frmStateCapitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 385);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblIs);
            this.Controls.Add(this.lblCapitalOf);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNewYork);
            this.Controls.Add(this.btnCalifornia);
            this.Controls.Add(this.btnColorado);
            this.Controls.Add(this.btnGeorgia);
            this.Controls.Add(this.btnWisconsin);
            this.Name = "frmStateCapitals";
            this.Text = "State Capitals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWisconsin;
        private System.Windows.Forms.Button btnGeorgia;
        private System.Windows.Forms.Button btnColorado;
        private System.Windows.Forms.Button btnCalifornia;
        private System.Windows.Forms.Button btnNewYork;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCapitalOf;
        private System.Windows.Forms.Label lblIs;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCapital;
    }
}

