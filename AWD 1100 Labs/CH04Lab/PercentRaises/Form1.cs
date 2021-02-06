using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Write a GUI program that calculates projected raises:
        ●	Declares a named constant PERCENT_RAISE and 
            assign it a value of 4% (or 1.04)
        ●	Prompts the user for the names and salaries of three employees.
        ●	Displays the projected salaries for these 
            three employees over the next 2 years in a table, 
            assuming that they get a 4% raise every year.
*
*/


namespace PercentRaises
{
    public partial class FormPercentRaises : Form
    {
        const double Percent_Raise = 1.04;
        public FormPercentRaises()
        {
            InitializeComponent();
        }
        const decimal PERCENT_RAISE = 0.04m;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal E1Yr2Salary = 0.0m;
            decimal E1Yr3Salary = 0.0m;
            decimal E2Yr2Salary = 0.0m;
            decimal E2Yr3Salary = 0.0m;
            decimal E3Yr2Salary = 0.0m;
            decimal E3Yr3Salary = 0.0m;
            string Emp1Name = "";
            string Emp2Name = "";
            string Emp3Name = "";
            decimal emp1Salary = 0.0m;
            decimal emp2Salary = 0.0m;
            decimal emp3Salary = 0.0m;
            bool keepGoing = true;

            Emp1Name = Convert.ToString(textBoxEmp1Name.Text);
            Emp2Name = Convert.ToString(textBoxEmp2Name.Text);
            Emp3Name = Convert.ToString(textBoxEmp3Name.Text);
            E1Yr2Salary = emp1Salary * PERCENT_RAISE;
            E1Yr3Salary = E1Yr2Salary * PERCENT_RAISE;
            E2Yr2Salary = emp2Salary * PERCENT_RAISE;
            E2Yr3Salary = E2Yr2Salary * PERCENT_RAISE;
            E3Yr2Salary = emp3Salary * PERCENT_RAISE;
            E3Yr3Salary = E3Yr2Salary * PERCENT_RAISE;


            keepGoing = validateIsNumeric(textBoxEmp1Salary.Text);

            if (keepGoing)
            {
                emp1Salary = Convert.ToDecimal(textBoxEmp1Salary.Text);

                return;
            }
            else
            {
                printMessageBox("Non-numeric salary entered." + " Please reenter a valid salary. ", "NON-NUMERIC SALARY INPUTTED!");

                return;
            }
            
            keepGoing = validateIsNumeric(textBoxEmp2Salary.Text);

            if (keepGoing)
            {
                emp2Salary = Convert.ToDecimal(textBoxEmp2Salary.Text);

                return;
            }
            else
            {
                printMessageBox("Non-numeric salary entered." + " Please reenter a valid salary. ", "NON-NUMERIC SALARY INPUTTED!");

                return;
            }
            
            keepGoing = validateIsNumeric(textBoxEmp3Salary.Text);

            if (keepGoing)
            {
                emp3Salary = Convert.ToDecimal(textBoxEmp3Salary.Text);

                return;
            }
            else
            {
                printMessageBox("Non-numeric salary entered." + " Please reenter a valid salary. ", "NON-NUMERIC SALARY INPUTTED!");
                return;
            }
            
    
        
            
            labelSalaryTable.Text = ("Year" + Emp1Name + Emp2Name + Emp3Name +
                                     "\n2018" + emp1Salary + emp2Salary + emp3Salary + 
                                     "\n2019" + E1Yr2Salary + E2Yr2Salary + E3Yr2Salary +
                                     "\n2020" + E1Yr3Salary + E2Yr3Salary + E3Yr3Salary);








        }
        private bool validateIsNumeric(string input)
        {
            decimal test = 0;

            return decimal.TryParse(input, out test);
        }
        private void printMessageBox(String text, String title)
        {
            MessageBox.Show(text, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

    }
}
