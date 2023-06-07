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
    public partial class ClockInClockOutForm : Form
    {
        public ClockInClockOutForm()
        {
            InitializeComponent();
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            UpdateTime();
            SetUpListView();
            //Sets the Time and CurrentUser Label also calls the SetUpListView method
        }

        private void SetUpListView()
        {
            using (StreamReader reader = new StreamReader("ClockData.txt")) //Uses StreamReader to iterate though the file
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Iterates though each line in a file
                    string[] array = line.Split(' ');
                    ListViewItem listViewItem = new ListViewItem((array[2] + " " + array[3]));
                    listViewItem.SubItems.Add(array[1]);
                    listViewItem.SubItems.Add(array[0]);
                    if (array[4] == "1")
                    {
                        listViewItem.SubItems.Add("Clock-In");
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Clock-Out");
                    }
                    listView1.Items.Add(listViewItem);
                    //For each line in the text file adds the data in the file into the ListView
                }
            }
        }

        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Closes the Form
        }
    }
}