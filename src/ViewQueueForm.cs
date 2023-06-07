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
    public partial class ViewQueueForm : Form
    {
        public ViewQueueForm()
        {
            InitializeComponent();
            setListView();
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            updateTime();
        }

        private void updateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
        }

        private void setListView()
        {
            listView1.Items.Clear();
            Queue<Order> orders = Program.GetQueue();
            foreach (Order order in orders)
            {
                //Iterates though each Order in the Queue
                ListViewItem listViewItem = new ListViewItem(order.GetOrderNumber().ToString());
                listViewItem.SubItems.Add(order.GetTotalCost().ToString());
                listViewItem.SubItems.Add(order.GetPlacedTime().ToShortTimeString());
                listViewItem.SubItems.Add(order.GetTableID().ToString());
                listView1.Items.Add(listViewItem);
                //Adds data from the Order and puts it in the listView
            }
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Closes the Form
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            setListView(); //Calls the setListViewButton
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            Queue<Order> queue = Program.GetQueue();
            Order order = queue.ElementAt(listView1.SelectedIndices[0]);
            ViewOrderForm viewOrderForm = new ViewOrderForm(order);
            viewOrderForm.ShowDialog();
            //Creates and opens a new ViewOrderForm
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ViewOrderButton.Visible = true;
                if ((Program.User.getEmployeeType() == 6) || (Program.User.getEmployeeType() == 3))
                {
                    SendOrderButton.Visible = true;
                }
                else
                {
                    SendOrderButton.Visible = false;
                }
                //If Item is selected then ViewItemButton becomes visable
            }
            else
            {
                SendOrderButton.Visible = false;
                ViewOrderButton.Visible = false;
                //If Item is selected then ViewItemButton becomes invisable
            }
        }

        private void SendOrderButton_Click(object sender, EventArgs e)
        {
            Program.GetQueue().Dequeue();
            setListView();
        }
    }
}
