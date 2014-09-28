using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryBonusCalculate
{
    public partial class SalaryBonusForm : Form
    {
        public SalaryBonusForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double salaryBalance = Convert.ToDouble(salaryTextBox.Text);
            double bonusPercen;

            if (salaryBalance > 10000)
                bonusPercen = salaryBalance * .05;
            else if (salaryBalance == 10000)
                bonusPercen = salaryBalance * .06;
            else
                bonusPercen = salaryBalance * .07;

            MessageBox.Show("Employee Bonus is : " + bonusPercen);
        }
    }
}
