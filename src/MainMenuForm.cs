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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            UpdateTime();
            OpenTableViewButton.Visible = false;
            OpenQueueButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tableViewForm.ShowDialog();
            Program.tableViewForm.UpdateTime();
            UpdateTime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewQueueForm viewQueueForm = new ViewQueueForm();
            viewQueueForm.ShowDialog();
            UpdateTime();
        }
        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        public void UpdateButtons()
        {
            if (Program.User != null)
            {
                switch (Program.User.getEmployeeType())
                {
                    case 1:
                        OpenTableViewButton.Visible = true;
                        OpenQueueButton.Visible = false;
                        EmployeeListButton.Visible = false;
                        ClockSheetButton.Visible = false;
                        //Host
                        break;

                    case 2:
                        OpenTableViewButton.Visible = true;
                        OpenQueueButton.Visible = true;
                        EmployeeListButton.Visible = false;
                        ClockSheetButton.Visible = false;
                        //Server
                        break;

                    case 3:
                        OpenTableViewButton.Visible = false;
                        OpenQueueButton.Visible = true;
                        EmployeeListButton.Visible = false;
                        ClockSheetButton.Visible = false;
                        //Cook
                        break;

                    case 4:
                        OpenTableViewButton.Visible = true;
                        OpenQueueButton.Visible = true;
                        EmployeeListButton.Visible = false;
                        ClockSheetButton.Visible = false;
                        //Bartenders
                        break;

                    case 5:
                        OpenTableViewButton.Visible = true;
                        OpenQueueButton.Visible = true;
                        EmployeeListButton.Visible = false;
                        ClockSheetButton.Visible = false;
                        //Bussers
                        break;

                    case 6:
                        OpenTableViewButton.Visible = true;
                        OpenQueueButton.Visible = true;
                        EmployeeListButton.Visible = true;
                        ClockSheetButton.Visible = true;
                        //Manager
                        break;
                }
                ClockInButton.Visible = true;
                UpdateTime();
                if (Program.User.isClocked())
                {
                    ClockInButton.Text = "Clock Out";
                }
                else
                {
                    ClockInButton.Text = "Clock In";
                }
            }
            else
            {
                OpenTableViewButton.Visible = false;
                OpenQueueButton.Visible = false;
                EmployeeListButton.Visible = false;
                ClockInButton.Visible = false;
                ClockSheetButton.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.User == null)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.ShowDialog();
                if (Program.User != null)
                {
                    SignInButton.Text = "Sign Out";
                    CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
                    label1.Text = "Welcome: " + Program.User.getFirstName();
                    UpdateButtons();
                }
            }
            else
            {
                Program.User = null;
                SignInButton.Text = "Sign In";
                CurrentUserLabel.Text = "Current User: ";
                label1.Text = "";
                UpdateButtons();
            }
        }

        private void ClockInButton_Click(object sender, EventArgs e)
        {
            if (!Program.User.isClocked())
            {
                Program.ClockIn();
            }
            else
            {
                Program.ClockOut();
            }
            UpdateButtons();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.ShowDialog();
            UpdateTime();
            //Creates and show new EmployeeListForm
        }
        private void ClockSheetButton_Click(object sender, EventArgs e)
        {
            ClockInClockOutForm clockInClockOutForm = new ClockInClockOutForm();
            clockInClockOutForm.ShowDialog();
            UpdateTime();
            //Creates and show new ClockInClockOutForm
        }
    }
}