namespace SalaryBonusCalculate
{
    partial class SalaryBonusForm
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
            this.inputSalaryLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSalaryLabel
            // 
            this.inputSalaryLabel.AutoSize = true;
            this.inputSalaryLabel.Location = new System.Drawing.Point(13, 27);
            this.inputSalaryLabel.Name = "inputSalaryLabel";
            this.inputSalaryLabel.Size = new System.Drawing.Size(121, 13);
            this.inputSalaryLabel.TabIndex = 0;
            this.inputSalaryLabel.Text = "Input Employee Salary : ";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(141, 27);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(183, 20);
            this.salaryTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(330, 24);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(108, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Bonus";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SalaryBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 112);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.inputSalaryLabel);
            this.Name = "SalaryBonusForm";
            this.Text = "Employee Salary Bonus Calculate Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputSalaryLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

