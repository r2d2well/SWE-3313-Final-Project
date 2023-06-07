using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_3313_Project
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm(Employee x)
        {
            //Takes in a Employee object and sets the label based off of the data in the Employee object
            InitializeComponent();
            FirstNameLabel.Text = "First Name: " + x.getFirstName();
            InitalLabel.Text = "Inital: " + x.getMiddleInitial();
            LastNameLabel.Text = "Last Name: " + x.getLastName();
            IDLabel.Text = "Employee ID: " + x.getEmployeeID();
            TypeLabel.Text = "Employee Type: " + Program.GetEmployeeType(x.getEmployeeType());
            GenderLabel.Text = "Gender: " + x.getGender();
            HoursLabel.Text = "Hours: " + x.getHours();
            ClockedLabel.Text = "Clocked: " + x.isClocked();
            if (x.getEmployeeType() == 2)
            {
                RestrictedLabel.Visible = true;
            }
            RestrictedLabel.Text = "Restricted: " + x.isRestricted();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
