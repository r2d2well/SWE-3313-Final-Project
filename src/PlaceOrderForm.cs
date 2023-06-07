using System;
using System.Collections;
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
    public partial class PlaceOrderForm : Form
    {
        private static PlaceOrderForm instance;
        private Order order;
        //Creats varables including a static varable of itself since it is a static class
        public PlaceOrderForm(string TableID)
        {
            InitializeComponent();
            instance = this;
            order = new Order(TableID);
            //Constructor takes in a string and sets the instance varable to itself and uses the given string to
            //set the order varable to a new Order
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            UpdateTime();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Closes the Window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
            //Creats a new AddItemForm and displays it
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                RemoveItemButton.Visible = true;
                ViewItemButton.Visible = true;
                //If a Item is selected the RemoveItemButton and ViewItemButton becomes visable
            }
            else
            {
                RemoveItemButton.Visible = false;
                ViewItemButton.Visible = false;
                //If a Item is not selected the RemoveItemButton and ViewItemButton becomes invisable
            }
        }

        public static void AddItems(Item item)
        {
            //Method that takes in a Item and adds it to the Queue and listView
            instance.order.AddItem(item);
            double subTotal = instance.order.GetSubTotal();
            instance.SubTotalLabel.Text = "Sub Total: " + subTotal;
            instance.TaxLabel.Text = "Tax: " + (subTotal * .07).ToString("N2");
            instance.TotalCostLabel.Text = "Total Cost: " + (subTotal * 1.07).ToString("N2");
            //Updates the TotalCostLabel

            ListViewItem listViewItem = new ListViewItem(item.GetName());
            listViewItem.SubItems.Add(item.GetCost().ToString("N2"));
            instance.listView1.Items.Add(listViewItem);
            //Creates a New listViewItem object and set it to the name of the with the cost as a subitem and adds it to the listView
            instance.PlaceOrderButton.Visible = true;
            //Since atleast 1 item is in the Queue the PlaceOrderButton Becomes Visable
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            listView1.Items.RemoveAt(index);
            order.RemoveItem(index);
            //Gets the index of the selected item in the listview and removes it from the listview and order

            double subTotal = order.GetSubTotal();
            instance.SubTotalLabel.Text = "Sub Total: " + subTotal;
            instance.TaxLabel.Text = "Tax: " + (subTotal *= .07).ToString("N2");
            instance.TotalCostLabel.Text = "Total Cost: " + order.GetTotalCost().ToString("N2");
            if (order.IsEmpty())
            {
                PlaceOrderButton.Visible = false;
            }
            //Updates the TotalCostLabel and if the order is now Empty then makes the PlaceOrderButton invisable
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            Program.AddOrder(order);
            this.Hide();
            //Calls the AddOrder method from the main class with the order and closes the window
        }

        private void ViewItemButton_Click(object sender, EventArgs e)
        {
            ViewItemForm viewItemForm = new ViewItemForm(order.GetItem(listView1.SelectedIndices[0]));
            viewItemForm.ShowDialog();
            UpdateTime();
            //Opens a new ViewItemView form with the currently selected Item in the ListView
        }
        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }
    }
}