using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SWE_3313_Project
{
    public partial class ViewItemForm : Form
    {
        public ViewItemForm(Item item)
        {
            InitializeComponent();
            NameLabel.Text = "Name: " + item.GetName();
            PriceLabel.Text = "Price: " + item.GetCost();
            //Takes in an Item object and displats the item's name and cost
            if (item.GetTopping() != null)
            {
                if (item.GetTopping().GetTopping() != null)
                {
                    SecondToppingLabel.Text = "Second Topping: " + item.GetTopping().GetTopping().GetName();
                    //If item has two topping displays both of them
                }
                else
                {
                    SecondToppingLabel.Visible = false;
                }
                ToppingLabel.Text = "Topping: " + item.GetTopping().GetName();
                //If item has one topping just display the first one
            }
            else
            {
                ToppingLabel.Visible = false;
            }
            if (item is Sandwiche)
            {
                Sandwiche sandwiche = (Sandwiche)item;
                Side1Label.Text = "Side: " + sandwiche.GetSide().GetName();
                Side2Label.Visible = false;
                //If Item is a Sandwiche display the one side
            }
            else if (item is Entree)
            {
                Entree entree = (Entree)item;
                Side1Label.Text = "Side 1: " + entree.GetSides()[0].GetName();
                Side2Label.Text = "Side 2: " + entree.GetSides()[1].GetName();
                //If Item is a Sandwiche display both of the sides
            }
            else
            {
                Side1Label.Visible = false;
                Side2Label.Visible = false;
                //If item is neither a Sandwiche or Entree make Side1 and Side2 label invisable
            }
            if (item.GetRequests() == null)
            {
                AdditionalRequestsLabel.Visible = false;
            }
            else
            {
                AdditionalRequestsLabel.Text = "Additonal Request: " + item.GetRequests();
                //Displays any additonal Requests in the Item like what kind of sauce they want
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Closes the Form
        }
    }
}
