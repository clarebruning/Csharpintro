namespace prjPopulation
{
    partial class frmPopulation
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
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtEndPop = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStartPop = new System.Windows.Forms.Label();
            this.lblEndPop = new System.Windows.Forms.Label();
            this.gbxPercentChange = new System.Windows.Forms.GroupBox();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.lblIncreaseDisplay = new System.Windows.Forms.Label();
            this.lblPercentDecrease = new System.Windows.Forms.Label();
            this.lblDecreaseDisplay = new System.Windows.Forms.Label();
            this.txtStartPop = new System.Windows.Forms.TextBox();
            this.gbxPercentChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(49, 30);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(52, 46);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 20);
            this.txtCity.TabIndex = 1;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(252, 30);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(255, 46);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(29, 20);
            this.txtState.TabIndex = 3;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // txtEndPop
            // 
            this.txtEndPop.Location = new System.Drawing.Point(52, 160);
            this.txtEndPop.Name = "txtEndPop";
            this.txtEndPop.Size = new System.Drawing.Size(100, 20);
            this.txtEndPop.TabIndex = 7;
            this.txtEndPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEndPop.TextChanged += new System.EventHandler(this.txtEndPop_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(52, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(171, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(280, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStartPop
            // 
            this.lblStartPop.AutoSize = true;
            this.lblStartPop.Location = new System.Drawing.Point(49, 98);
            this.lblStartPop.Name = "lblStartPop";
            this.lblStartPop.Size = new System.Drawing.Size(96, 13);
            this.lblStartPop.TabIndex = 4;
            this.lblStartPop.Text = "Starting Population";
            // 
            // lblEndPop
            // 
            this.lblEndPop.AutoSize = true;
            this.lblEndPop.Location = new System.Drawing.Point(49, 144);
            this.lblEndPop.Name = "lblEndPop";
            this.lblEndPop.Size = new System.Drawing.Size(93, 13);
            this.lblEndPop.TabIndex = 6;
            this.lblEndPop.Text = "Ending Population";
            // 
            // gbxPercentChange
            // 
            this.gbxPercentChange.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxPercentChange.Controls.Add(this.lblPercentDecrease);
            this.gbxPercentChange.Controls.Add(this.lblDecreaseDisplay);
            this.gbxPercentChange.Controls.Add(this.lblIncreaseDisplay);
            this.gbxPercentChange.Controls.Add(this.lblIncrease);
            this.gbxPercentChange.Location = new System.Drawing.Point(198, 89);
            this.gbxPercentChange.Name = "gbxPercentChange";
            this.gbxPercentChange.Size = new System.Drawing.Size(173, 140);
            this.gbxPercentChange.TabIndex = 11;
            this.gbxPercentChange.TabStop = false;
            this.gbxPercentChange.Text = "Percent Change";
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.Location = new System.Drawing.Point(27, 25);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(88, 13);
            this.lblIncrease.TabIndex = 0;
            this.lblIncrease.Text = "Percent Increase";
            // 
            // lblIncreaseDisplay
            // 
            this.lblIncreaseDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncreaseDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIncreaseDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIncreaseDisplay.Location = new System.Drawing.Point(54, 45);
            this.lblIncreaseDisplay.Name = "lblIncreaseDisplay";
            this.lblIncreaseDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblIncreaseDisplay.TabIndex = 1;
            this.lblIncreaseDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPercentDecrease
            // 
            this.lblPercentDecrease.AutoSize = true;
            this.lblPercentDecrease.Location = new System.Drawing.Point(27, 78);
            this.lblPercentDecrease.Name = "lblPercentDecrease";
            this.lblPercentDecrease.Size = new System.Drawing.Size(93, 13);
            this.lblPercentDecrease.TabIndex = 2;
            this.lblPercentDecrease.Text = "Percent Decrease";
            // 
            // lblDecreaseDisplay
            // 
            this.lblDecreaseDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecreaseDisplay.Location = new System.Drawing.Point(54, 105);
            this.lblDecreaseDisplay.Name = "lblDecreaseDisplay";
            this.lblDecreaseDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDecreaseDisplay.TabIndex = 3;
            this.lblDecreaseDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtStartPop
            // 
            this.txtStartPop.Location = new System.Drawing.Point(52, 114);
            this.txtStartPop.Name = "txtStartPop";
            this.txtStartPop.Size = new System.Drawing.Size(100, 20);
            this.txtStartPop.TabIndex = 5;
            this.txtStartPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStartPop.TextChanged += new System.EventHandler(this.txtStartPop_TextChanged);
            // 
            // frmPopulation
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(401, 302);
            this.Controls.Add(this.gbxPercentChange);
            this.Controls.Add(this.lblEndPop);
            this.Controls.Add(this.lblStartPop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEndPop);
            this.Controls.Add(this.txtStartPop);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Name = "frmPopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Population";
            this.gbxPercentChange.ResumeLayout(false);
            this.gbxPercentChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtEndPop;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStartPop;
        private System.Windows.Forms.Label lblEndPop;
        private System.Windows.Forms.GroupBox gbxPercentChange;
        private System.Windows.Forms.Label lblPercentDecrease;
        private System.Windows.Forms.Label lblDecreaseDisplay;
        private System.Windows.Forms.Label lblIncreaseDisplay;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.TextBox txtStartPop;
    }
}

