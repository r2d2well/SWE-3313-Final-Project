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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            UpdateTime();
            SetUpListView();
        }

        private void SetUpListView()
        {
            listView1.Items.Clear();
            using (StreamReader file = new StreamReader("EmployeeData.txt")) //Uses StreamReader to iterate though the file
            {
                string line;
                //Creates a String to keep track of the current Line and a counter to keep track of what section of the menu is being looked though

                while ((line = file.ReadLine()) != null)
                {
                    string[] array = line.Split(' ');
                    ListViewItem listViewItem = new ListViewItem(array[0]);
                    listViewItem.SubItems.Add(array[1]);
                    listViewItem.SubItems.Add(array[2]);
                    listViewItem.SubItems.Add(array[3]);
                    listViewItem.SubItems.Add(Program.GetEmployeeType(int.Parse(array[5])));
                    listViewItem.SubItems.Add(array[4]);
                    listView1.Items.Add(listViewItem);
                    //Adds the data in the text file into the listView
                }
            }
        }
        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ViewEmployeeDetailsButton.Visible = true;
                RemoveEmployeeButton.Visible = true;
                if (listView1.SelectedItems[0].SubItems[4].Text == "Server")
                {
                    if (Program.staff.employeeSearch(listView1.SelectedItems[0].Text).isRestricted())
                    {
                        RestrictButton.Text = "Unrestrict";
                    }
                    else
                    {
                        RestrictButton.Text = "Restrict";
                    }
                    RestrictButton.Visible = true;
                }
                else
                {
                    RestrictButton.Visible = false;
                }
                //If an employee is selected make viewEmployeeDetailsButton visable
            }
            else
            {
                ViewEmployeeDetailsButton.Visible = false;
                RemoveEmployeeButton.Visible = false;
                RestrictButton.Visible = false;
                //If an employee is selected make viewEmployeeDetailsButton invisable
            }
        }

        private void ViewEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            string x = listView1.SelectedItems[0].Text;
            Employee employee = Program.staff.employeeSearch(x);
            EmployeeDetailsForm employeeDetailsForm = new EmployeeDetailsForm(employee);
            employeeDetailsForm.ShowDialog();
            //Create a new EmployeeDetailsForm based off of the selected employee
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            SetUpListView();
            //Creates and opens a new AddEmployeeForm
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }

        private void RemoveLine(string FilePath, string ID)
        {
            int count;
            List<String> lineList = File.ReadAllLines(FilePath).ToList();

            for (int x = 0; x < lineList.Count; x++)
            {
                string[] array = lineList.ElementAt(x).Split(' ');
                if (array[0] == ID)
                {
                    lineList.RemoveAt(x);
                }
            }

            File.WriteAllLines(FilePath, lineList);
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            string x = listView1.SelectedItems[0].Text;
            Program.staff.removeEmployee(x);
            RemoveLine("EmployeeData.txt", x);
            SetUpListView();
        }

        private void RestrictButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (Program.staff.employeeSearch(listView1.SelectedItems[0].Text).isRestricted())
                {
                    Program.staff.employeeSearch(listView1.SelectedItems[0].Text).Unrestrict();
                    RestrictButton.Text = "Restrict";
                }
                else
                {
                    Program.staff.employeeSearch(listView1.SelectedItems[0].Text).Restrict();
                    RestrictButton.Text = "Unrestrict";
                }
            }
        }
    }
}