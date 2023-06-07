using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SWE_3313_Project
{
    public partial class ViewOrderForm : Form
    {
        Order order;
        public ViewOrderForm(Order order)
        {
            InitializeComponent();
            this.order = order;
            Item[] array = new Item[order.GetSize()];
            for (int x = 0; x < order.GetSize(); x++)
            {
                array[x] = order.GetItem(x);
            }
            //Takes in a Order object and adds each item into the list view
            AddItems(array);
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            UpdateTime();
        }

        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        private void AddItems(Item[] array)
        {
            foreach (Item item in array)
            {
                ListViewItem listViewItem = new ListViewItem(item.GetName());
                //Iterates though each item in the given array
                if (item is Sandwiche)
                {
                    Sandwiche sandwiche = (Sandwiche)item;
                    listViewItem.SubItems.Add(sandwiche.GetSide().GetName());
                    listViewItem.SubItems.Add("");
                    //If item is a sandwich display the one side
                }
                else if (item is Entree)
                {
                    Entree entree = (Entree)item;
                    listViewItem.SubItems.Add(entree.GetSides()[0].GetName());
                    listViewItem.SubItems.Add(entree.GetSides()[1].GetName());
                    //If item is a entree display the two sides
                }
                else
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    //Else do not display either side label
                }
                if (item.GetTopping() != null)
                {
                    listViewItem.SubItems.Add(item.GetTopping().GetName());
                    //Add the first topping into the listViewItem
                    if (item.GetTopping().GetTopping() != null)
                    {
                        listViewItem.SubItems.Add(item.GetTopping().GetTopping().GetName());
                        //Add the second topping into the listViewItem
                    }
                    else
                    {
                        listViewItem.SubItems.Add("");
                    }
                }
                else
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    //If item has no topping do not display either topping label
                }
                listViewItem.SubItems.Add(item.GetCost().ToString());
                listViewItem.SubItems.Add(item.GetRequests());
                listView1.Items.Add(listViewItem);
                //Adds the data into the listview
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ViewItemButton.Visible = true;
                //If Item is selected then ViewItemButton becomes visable
            }
            else
            {
                ViewItemButton.Visible = false;
                //If Item is selected then ViewItemButton becomes invisable
            }
        }

        private void ViewItemButton_Click(object sender, EventArgs e)
        {
            Item item = order.GetItem(listView1.SelectedIndices[0]);
            ViewItemForm viewItemForm = new ViewItemForm(item);
            viewItemForm.ShowDialog();
            UpdateTime();
            //Creates and opens a new ViewItemForm
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Closes the Form
        }
    }
}