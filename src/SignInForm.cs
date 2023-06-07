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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            label.Text = string.Empty;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (label.Text == "Error")
            {
                clearButton_Click(sender, e);
                //Clears the Label
            }
            if (label.Text.Length < 6)
            {
                label.Text += btn.Text;
                //Adds the text on button onto the Label
            }
            else
            {
                label.Text = "Error";
                label.ForeColor = Color.Red;
                //if label is bigger then 6 then Display Error and set ForeColor to Red
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            label.Text = string.Empty;
            label.ForeColor = Color.White;
            //Clears the label and set the ForeColor to white
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label.Text.Length < 6)
            {
                label.Text = "Error";
                label.ForeColor = Color.Red;
                //if label is smaller then 6 then Display Error and set ForeColor to Red
            }
            else
            {
                if (Program.staff.employeeSearch(label.Text) != null)
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000;
                    timer.Tick += Close_Form;
                    timer.Start();
                    Program.User = Program.staff.employeeSearch(label.Text);
                    label.Text = "Success";
                    label.ForeColor = Color.Green;
                    //If password is accepted display "Success" and close after 1 second
                }
                else
                {
                    label.Text = "Error";
                    label.ForeColor = Color.Red;
                    //Display Error and set ForeColor to Red
                }
            }
        }

        private void Close_Form(object? sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }
    }
}