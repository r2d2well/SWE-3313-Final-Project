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
    public partial class AddEmployeeForm : Form
    {
        bool GenderSelected = false;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form //Closes the form
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            byte temp = 0;
            string FirstName = "";
            string LastName = "";
            string ID = "";
            char Initial = '\0';
            int Gender = 0;
            int Type = 0;
            //Sets varables and inilize them as their base value

            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.BackColor = Color.Red;
                //If TextBox is empty make the BackColor Red
            }
            else
            {
                FirstName = FirstNameTextBox.Text;
                FirstNameTextBox.BackColor = Color.White;
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if (InitalComboBox.Text == "")
            {
                InitalComboBox.BackColor = Color.Red;
                //If ComboBox is empty make the BackColor Red
            }
            else
            {
                InitalComboBox.ForeColor = Color.White;
                Initial = InitalComboBox.Text[0];
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.BackColor = Color.Red;
                //If TextBox is empty make the BackColor Red
            }
            else
            {
                LastName = LastNameTextBox.Text;
                LastNameTextBox.BackColor = Color.White;
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if ((IDTextBox.Text == "") || (!Program.staff.validPassword(IDTextBox.Text)))
            {
                IDTextBox.BackColor = Color.Red;
                //If TextBox is empty make the BackColor Red
            }
            else
            {
                ID = IDTextBox.Text;
                IDTextBox.BackColor = Color.White;
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if ((comboBox1.Text == ""))
            {
                comboBox1.BackColor = Color.Red;
                //If ComboBox is empty make the BackColor Red
            }
            else
            {
                Type = Program.GetEmployeeType(comboBox1.Text);
                comboBox1.BackColor = Color.White;
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if (!GenderSelected)
            {
                groupBox1.BackColor = Color.Red;
                //If no radioButton is selected make the BackColor Red
            }
            else
            {
                groupBox1.BackColor = Color.White;
                temp++;
                //Else make the BackColor White and increase temp by 1
            }
            if (temp == 6)
            {
                //If all the TextBox values are good creates a new employee with given value
                Employee employee = new Employee(ID, FirstName, Initial, LastName, Gender, Type);
                Program.AddEmployee(employee);
                this.Hide();
                //Adds employee to roster and closes the form
            }
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            GenderSelected = true;
            //If any radio button is clicked Bool GenderSelected is true
        }
    }
}