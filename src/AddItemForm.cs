using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_3313_Project
{
    public partial class AddItemForm : Form
    {
        int state = 0;
        Item item, temp;
        Side side;
        public AddItemForm()
        {
            InitializeComponent();
            item = null;
            side = null;
            UpdateTime();
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
        }

        public AddItemForm(int x)
        {
            InitializeComponent();
            state = x;
            item = null;
            side = null;
            CloseButton.Visible = false;
            UpdateTime();
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
        }

        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        private void SetButtonText(string[] x)
        {
            //Method that in a string array and sets the button texts based off of the given array
            button1.Text = x[0];
            button2.Text = x[1];
            button3.Text = x[2];
            button4.Text = x[3];
            button5.Text = x[4];
            button6.Text = x[5];
            button7.Text = x[6];
            button8.Text = x[7];
            button1.Visible = (button1.Text != "");
            button2.Visible = (button2.Text != "");
            button3.Visible = (button3.Text != "");
            button4.Visible = (button4.Text != "");
            button5.Visible = (button5.Text != "");
            button6.Visible = (button6.Text != "");
            button7.Visible = (button7.Text != "");
            button8.Visible = (button8.Text != "");
            //if the given string is "" then makes the button invisible
        }

        private void ReturnButtonPress(object sender, EventArgs e)
        {
            UpdateTime();
            if (state == 0)
            {
                this.Hide();
                //If state is 0 then closes the window
            }
            else
            {
                state = 0;
                Label.Text = "";
                SubmitButton.Visible = false;
                TextBoxLabel.Visible = false;
                textBox1.Visible = false;
                comboBox.Visible = false;
                SetButtonText();
                //Else sets the state to 0
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool moveOn = true;
            if (textBox1.Text != "")
            {
                item.AddRequest(textBox1.Text);
                //If there is a written request in the textbox add it to the item class
            }
            if ((comboBox.Text != string.Empty) && (comboBox.Text != "Enter Additional Costs"))
            {
                moveOn = false;
                double x = item.GetCost();
                try
                {
                    x += Double.Parse(comboBox.Text);
                    moveOn = true;
                }
                catch (Exception ex)
                {
                    Label.Text = "Enter a Valid Number!";
                }
                item.SetCost(x);
            }
            if (moveOn)
            {
                PlaceOrderForm.AddItems(item);
                this.Hide();
            }
            //Add the item to the order class in the PlaceOrderForm and close the window
        }

        private void SetButtonText()
        {
            //Switch case that sets the texts of the buttons based off of the current state
            switch (state)
            {
                case 0:
                    string[] zero = { "Appetizers", "Salads", "Entrees", "Sandwiches", "Wraps", "Burgers", "Drinks", "Sides" };
                    SetButtonText(zero);
                    //Each case is the create of a string array of 8 strings and giving it to the SetButtonText
                    break;

                case 1:
                    string[] one = { "Chips & Dip", "Buffalo Blue Chips", "Chicken Nachos", "Pork Nachos", "Pork Sliders",
                    "Chicken Sliders", "Catfish Bites", "Next Page" };
                    SetButtonText(one);
                    //Appatizers page 1
                    break;

                case 2:
                    string[] two = { "Fried Veggies", "Fried Cheese", "Cheese Stick Trio", "Chicken Quesadilla", "Cast Iron Skillet Meatballs", "Wings (6 Count)",
                    "Wings (12 Count)", "Previous Page"};
                    SetButtonText(two);
                    //Appatizers page 2
                    break;

                case 3:
                    string[] three = { "House Salad", "Wedge Salad", "Caesar Salad", "Sweet Potato Chicken Salad", "", "", "", "" };
                    SetButtonText(three);
                    //Salad Selection
                    break;

                case 4:
                    string[] four = { "Shrimp & Grits", "Sweet Tea Fried Chicken", "Caribbean Chicken", "Grilled Pork Chops",
                    "12 Oz New York Strip Steak", "Seared Tuna", "Captain Crunch Chicken Tenders", "Next Page",};
                    SetButtonText(four);
                    //Entree Page 1
                    break;

                case 5:
                    string[] five = { "Shock Top Grouper Fingers", "Mac & Cheese Bar", "", "", "", "", "", "Previous Page" };
                    SetButtonText(five);
                    //Entree Page 2
                    break;

                case 6:
                    string[] six = { "Grilled Cheese (Multigrain Bread)", "Grilled Cheese (White Bread)" ,"100% Beef Hot Dog", "Chicken BLT&A", "Cordon Bleu",
                    "Philly (Steak)", "Philly (Chicken)", "Next Page"};
                    SetButtonText(six);
                    //Sandwiches Page 1
                    break;

                case 7:
                    string[] seven = { "Pulled Pork", "Club", "Meatball Sub", "Po Boy (Shrimp)", "Po Boy (Catfish)", "", "", "Previous Page" };
                    SetButtonText(seven);
                    //Sandwiches Page 2
                    break;

                case 8:
                    string[] eight = { "Club", "Chicken BLT&A", "Veggie", "Chicken Caesar", "", "", "", "" };
                    SetButtonText(eight);
                    //Wraps
                    break;

                case 9:
                    string[] nine = { "J's Burger", "J's Burger (With Cheese)", "Bacon Cheeseburger", "Mushroom Swiss Burger", "Carolina Burger",
                    "Vegan Boca Burger","", ""};
                    SetButtonText(nine);
                    //Burgers
                    break;

                case 10:
                    string[] ten = { "Coffee", "Sweet Tea", "Unsweet Tea", "Coke", "Diet Coke", "Sprite", "Mr.Pibb", "Next Page" };
                    SetButtonText(ten);
                    //Drinks Page 1
                    break;

                case 11:
                    string[] eleven = { "Ginger Ale", "Barq's Root Beer", "Bottled Water", "Lemonade", "Milk", "Chocolate Milk",
                    "Orange Juice", "Previous Page"};
                    SetButtonText(eleven);
                    //Drinks Page 2
                    break;

                case 18:
                case 16:
                case 14:
                case 12:
                    string[] twelve = { "Curly Fries", "Wing Chips", "Sweet Potato Fries (+$1.5)", "Creamy Cabbage Slaw", "Adluh Cheese Grits",
                    "Mashed Potatoes", "Mac & Cheese", "Next Page"};
                    SetButtonText(twelve);
                    //Sides Page 1
                    break;

                case 19:
                case 17:
                case 15:
                case 13:
                    string[] thirteen = { "Spicy Mac & Cheese", "Bacon Mac & Cheese", "Broccoli", "Seasonal Vegetables", "Baked Beans",
                    "Fried Okra (+$1.5)", "Substitute Soup or Side Salad (+$2.50)", "Previous Page"};
                    SetButtonText(thirteen);
                    //Sides Page 2
                    break;

                case 20:
                    string[] saladSize = { "Reqular", "Side", "", "", "", "", "", "" };
                    SetButtonText(saladSize);
                    //Salad Size Selection for House Salad and Ceaser Salad
                    break;

                case 21:
                    string[] saladOptions = { "Reqular", "No Cheese", "No Croutons", "No Dressing", "Portobello Mushroom Cap (+$4.00)", "Roasted Chicken (+$3.00)",
                    "Captain Cruch Chicken (+$3.00)", "Next Page" };
                    SetButtonText(saladOptions);
                    //Salad Toppings Page 1
                    break;

                case 22:
                    string[] saladOptionsTwo = { "New York strip (+$4.00)", "Grilled Shrimp (+$6.00)", "Fried Shrimp (+$6.00)", "Seared Tuna (+$10.00)",
                    "", "", "", "Previous Page" };
                    //Salad Toppings Page 2
                    SetButtonText(saladOptionsTwo);
                    break;

                case 23:
                    string[] cheeseTypes = { "Cheddar", "American", "Swiss", "Provolone", "Pepper jack", "Blue", "Pimento", "" };
                    SetButtonText(cheeseTypes);
                    //Cheese types to put on a Bacon Cheeseburger
                    break;

                case 24:
                    string[] hotDogTopping = { "None", "Mustard", "ketchup", "onion", "jalapeno", "Slaw", "Relish", "Next Page" };
                    SetButtonText(hotDogTopping);
                    //HotDog Toppings Page 1
                    break;

                case 25:
                    string[] hotDogBottomping = { "chili (+$0.25)", "cheddar (+$0.25)", "", "", "", "", "", "Previous Page" };
                    //Visual Studios suggested that name and I think its hilarious so am keeping it
                    SetButtonText(hotDogBottomping);
                    //HotDog Toppings Page 2
                    break;

                case 26:
                    string[] cookedTemputer = { "Medium", "Medium Rare", "Rare", "Well Done", "", "", "", "" };
                    SetButtonText(cookedTemputer);
                    //Cooked temputer for New York Strip and Seared Tuna
                    break;

                case 27:
                case 28:
                    string[] dipChoice = { "Salsa", "Queso", "Guacamole", "", "", "", "", "" };
                    SetButtonText(dipChoice);
                    //Choice of dip for Chips and Dip
                    break;

                case 29:
                    string[] AddBBQsauce = { "Reqular", "Add BBQ (+$0.50)", "", "", "", "", "", "" };
                    SetButtonText(AddBBQsauce);
                    //Option to Add BBQ sauce
                    break;

                case 30:
                case 37:
                    string[] BBQsauces = { "Chipotle", "Jim Beam", " Carolina Gold BBQ", "No Sauce", "", "", "", "" };
                    SetButtonText(BBQsauces);
                    //Option to Add specific type of BBQ sauce to a burger
                    break;

                case 31:
                    string[] chipTopping = { "Rance", "Blue Cheese", "None", "", "", "", "", "" };
                    SetButtonText(chipTopping);
                    //Topping to put of chips
                    break;

                case 32:
                    string[] veggieOptions = { "Okra", "Zucchini", "Squash", "Mix", "Okra and Zucchini", "Okra and Squash", "Zucchini and Squash", "" };
                    SetButtonText(veggieOptions);
                    //Option for type Fried Veggies Appetizer
                    break;

                case 33:
                    string[] friedCheeses = { "Mac and Cheese Bites", "Pimento Cheese", "Mozzarella Cheese", "", "", "", "", "" };
                    SetButtonText(friedCheeses);
                    //Option and type of Fried Cheese Appetizer
                    break;

                case 34:
                case 35:
                    string[] AddSautes = { "No Sautés", "Sautéed Peppers", "Sautéed Onions", "Sautéed Peppers and Onions", "No Cheese", "No marinara",
                    "No Toppings", "" };
                    SetButtonText(AddSautes);
                    //Option to Add Sautés to meatballs or remove topping on them
                    break;

                case 36:
                    string[] AddLetTomOnz = { "No Additional Toppings", "Lettuce", "Tomatos", "Onions", "Lettuce and Tomatos", "Lettuce and Onions",
                    "Lettuce, Tomatos, and Onions", "" };
                    SetButtonText(AddLetTomOnz);
                    //Option to Add Lettuce, Tomatos, or Onions onto a burger or any combination of them
                    break;

                case 38:
                    string[] wingSauce = { "Rance", "Buffalo", "Terhot", "Jim Beam", "BBQ Pineapple Teriyaki", "Chris’ Kickin Teriyaki", "None", "" };
                    SetButtonText(wingSauce);
                    //Possible sauces to be served with wings
                    break;

                case 39:
                    string[] wingRubs = { "Garlic Parmesan", "Lime Pepper", "Jerk", "No Rub", "", "", "", "" };
                    SetButtonText(wingRubs);
                    //Possible Rubs to be served with wings
                    break;

                case 42:
                case 40:
                    string[] macAndCheese1 = { "Pepper Jack Cheese", "Cheddar Cheese", "Swiss Cheese", "Mozzarella Cheese", "Goat Cheese",
                    "Bacon (+$0.50)", "Broccoli (+$0.50)", "Next Page"};
                    SetButtonText(macAndCheese1);
                    //Option to add toppings to a Mac and Cheese Bar Entree Page 1
                    break;

                case 43:
                case 41:
                    string[] macAndCheese2 = { "Mushrooms (+$0.50)", "Grilled Onions (+$0.50)", "Jalapenos (+$0.50)", "Spinach (+$0.50)",
                    "Tomatoes (+$0.50)", "None", "", "Previous Page" };
                    SetButtonText(macAndCheese2);
                    //Option to add toppings to a Mac and Cheese Bar Entree Page 2
                    break;
            }
        }

        private void SetState(string x)
        {
            //Switch case that sets teh state based off of a given string
            switch (x)
            {
                case "Appetizers":
                    state = 1;
                    break;
                case "Salads":
                    state = 3;
                    break;
                case "Entrees":
                    state = 4;
                    break;
                case "Sandwiches":
                    state = 6;
                    break;
                case "Wraps":
                    state = 8;
                    break;
                case "Burgers":
                    state = 9;
                    break;
                case "Drinks":
                    state = 10;
                    break;
                case "Sides":
                    state = 12;
                    break;
            }
        }

        private void GetAdditonalRequests()
        {
            string[] temp = { "", "", "", "", "", "", "", "" };
            SetButtonText(temp);
            Label.Text = "";
            TextBoxLabel.Visible = true;
            textBox1.Visible = true;
            SubmitButton.Visible = true;
            comboBox.Visible = true;
            //Makes the buttons invisable and make the TextBox and TextBoxLabel visable
        }

        private double GetAdditionalPrice(string x)
        {
            //Takes in a string and returns a Additonal Price value
            if (x.Contains("(+$"))
            {
                int startIndex = 0, endIndex = 0;
                for (int y = 0; y < x.Length; y++)
                {
                    if (x[y] == '$')
                    {
                        startIndex = y + 1;
                        //Finds the index of the '$' character and sets the start index to it but 1 more
                    }
                    else if (x[y] == ')')
                    {
                        endIndex = y;
                        //Finds the index of the '$' character and sets the stop index to it
                    }
                }
                string subString = x.Substring(startIndex, endIndex - startIndex);
                //Uses the start and end index to create a substring of the given string
                return Double.Parse(subString);
                //Returns the Parse of the substring
            }
            //if x does not contain an instance of "(+$" then returns the value 0
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UpdateTime();
            if (btn.Text == "Substitute Soup or Side Salad (+$2.50)")
            {
                string[] subSoupOrSalad = { "Soup", "House Salad (Side)", "Caesar Salad (Side)", "", "", "", "", "" };
                SetButtonText(subSoupOrSalad);
                //If the Button Text says Substitute Soup or Side Salad Show to Subsitute Side Option
            }
            else
            {
                //Else go to the Main Switch case
                switch (state)
                {
                    case 0:
                        SetState(btn.Text);
                        SetButtonText();
                        //If State is equal to 0 call the SetState Button with the button's text
                        break;

                    case 1:
                    case 2:
                        temp = Menu.GetItem(btn.Text);
                        item = new Item(temp.GetName(), temp.GetCost());
                        //If State is 1 or 2 (Appitizer) then set the temp object equal to the corrisponding item object in the menu
                        //And create a new Item object with the Name and Cost of the temp Object
                        switch (btn.Text)
                        {
                            //Switch Case that sets the state and Label text depending on the button text
                            case "Chips & Dip":
                                state = 27;
                                Label.Text = "Select First Dip";
                                SetButtonText();
                                break;

                            case "Buffalo Blue Chips":
                                state = 31;
                                Label.Text = "Select Desired Sauce";
                                SetButtonText();
                                break;

                            case "Fried Veggies":
                                state = 32;
                                Label.Text = "Select Desired Vegtable Combination";
                                SetButtonText();
                                break;

                            case "Chicken Nachos":
                            case "Pork Nachos":
                                state = 29;
                                Label.Text = "Add BBQ Sauce?";
                                SetButtonText();
                                break;

                            case "Pork Sliders":
                            case "Chicken Sliders":
                                state = 30;
                                Label.Text = "Selected Desired Sauce";
                                SetButtonText();
                                break;

                            case "Fried Cheese":
                                state = 33;
                                Label.Text = "Select Fried Cheese Type";
                                SetButtonText();
                                break;

                            case "Cast Iron Skillet Meatballs":
                                state = 34;
                                Label.Text = "Select Topping For Meatballs";
                                SetButtonText();
                                break;

                            case "Wings (6 Count)":
                            case "Wings (12 Count)":
                                state = 38;
                                Label.Text = "Select Sauce with Wings";
                                SetButtonText();
                                break;

                            default:
                                GetAdditonalRequests();
                                //If no case corrosponding to the Button Text go ahead and call the GetAdditionalRequests method
                                break;
                        }
                        break;

                    case 3:
                        temp = Menu.GetItem(btn.Text);
                        if ((temp.GetName() == "House Salad") || (temp.GetName() == "Caesar Salad"))
                        {
                            state = 20;
                            Label.Text = "Select Size";
                            item = new Salad(temp.GetName(), temp.GetCost(), 5);
                            //If Button is House Salad or Caesar Salad set item to a new salad with a side cost
                        }
                        else
                        {
                            state = 21;
                            Label.Text = "Select Toppings";
                            item = new Salad(temp.GetName(), temp.GetCost());
                            //Else set item to a new salad without a side cost
                        }
                        SetButtonText();
                        break;

                    case 4:
                    case 5:
                        temp = Menu.GetItem(btn.Text);
                        item = new Entree(temp.GetName(), temp.GetCost());
                        //Sets item to a new Entree
                        if ((btn.Text == "12 Oz New York Strip Steak") || (btn.Text == "Seared Tuna"))
                        {
                            state = 26;
                            Label.Text = "Select The Desired Temputure";
                            //If btn Text is Steak or Tuna get the Temputure the customer would like meal to be cooked too
                        }
                        else if (btn.Text == "Mac & Cheese Bar")
                        {
                            state = 40;
                            Label.Text = "Select The First Topping";
                            //If btn Text is Mac and Cheese Bar Let the user select the first topping
                        }
                        else
                        {
                            state = 14;
                            Label.Text = "Select The First Side";
                            //Else let them select the first side
                        }
                        SetButtonText();
                        break;

                    case 6:
                        temp = Menu.GetItem(btn.Text);
                        item = new Sandwiche(temp.GetName(), temp.GetCost());
                        if (btn.Text == "100% Beef Hot Dog")
                        {
                            state = 24;
                            Label.Text = "Select The Topping";
                            //If Hot Dog is selected ask user what topping they want
                        }
                        else
                        {
                            state = 18;
                            Label.Text = "Select The Side";
                            //Else ask them what side they want
                        }
                        SetButtonText();
                        break;

                    case 7:
                        temp = Menu.GetItem(btn.Text);
                        item = new Sandwiche(temp.GetName(), temp.GetCost());
                        if (btn.Text == "Meatball Sub")
                        {
                            Label.Text = "Select Topping For Meatballs";
                            state = 35;
                            //If MeatBall Sub is selected ask user what Sauted topping they want
                        }
                        else if (btn.Text == "Pulled Pork")
                        {
                            Label.Text = "Select Sauce To Go With Pulled Pork";
                            state = 37;
                            //If Pulled is selected ask user what Sauce they want
                        }
                        else
                        {
                            state = 18;
                            Label.Text = "Select The Side";
                            //Else ask what Side they want
                        }
                        SetButtonText();
                        break;

                    case 8:
                        temp = Menu.GetItem(btn.Text);
                        item = new Sandwiche(temp.GetName(), temp.GetCost());
                        state = 18;
                        SetButtonText();
                        Label.Text = "Select The Side";
                        //Sets item to a new Sandwich and asks user what side they want
                        break;

                    case 9:
                        temp = Menu.GetItem(btn.Text);
                        item = new Sandwiche(temp.GetName(), temp.GetCost());
                        if (btn.Text == "Bacon Cheeseburger")
                        {
                            state = 23;
                            Label.Text = "Select Cheese On Burger";
                            //If user selects Bacon Cheeseburger ask what cheese they want on it
                        }
                        else if (btn.Text == "Carolina Burger")
                        {
                            state = 36;
                            Label.Text = "Would you like to add Lettuce, Tomatos, or Onions?";
                            //If user selects Carolina Burger ask if they want Lettuce Tomatos or Onions
                        }
                        else
                        {
                            state = 18;
                            Label.Text = "Select The Side";
                            //Else Select the Side
                        }
                        SetButtonText();
                        break;

                    case 14:
                    case 15:
                        Entree entree = (Entree)item;
                        side = (Side)Menu.GetItem(btn.Text);
                        entree.AddSide(side);
                        //Gets the First side for an entree
                        Label.Text = "Select The Second Side";
                        state = 16;
                        item = entree;
                        SetButtonText();
                        //Then promps user to select another side
                        break;

                    case 16:
                    case 17:
                        entree = (Entree)item;
                        side = (Side)Menu.GetItem(btn.Text);
                        entree.AddSide(side);
                        item = entree;
                        GetAdditonalRequests();
                        //Gets the second Side for an entree and calls the GetAdditonalRequests method
                        break;

                    case 18:
                    case 19:
                        Sandwiche sandwiche = (Sandwiche)item;
                        side = (Side)Menu.GetItem(btn.Text);
                        sandwiche.SetSide(side);
                        item = sandwiche;
                        GetAdditonalRequests();
                        //Gets the Side for an Sandwiche and calls the GetAdditonalRequests method
                        break;

                    case 20:
                        if (btn.Text == "Side")
                        {
                            Salad temp = (Salad)item;
                            item.SetCost(temp.GetSideCost());
                            //If user selects Side then the salad cost will be equal to it's side cost
                        }
                        state = 21;
                        Label.Text = "Select Toppings";
                        SetButtonText();
                        //Prompts user to select the Salad Toppings
                        break;

                    case 21:
                    case 22:
                    case 29:
                    case 31:
                    case 34:
                        item.SetTopping(new Item(btn.Text, GetAdditionalPrice(btn.Text)));
                        GetAdditonalRequests();
                        //Gets the selected topping from the User and adds any additonal cost to the cost of the Item
                        break;

                    case 23:
                    case 24:
                    case 25:
                    case 35:
                    case 36:
                    case 37:
                        item.SetTopping(new Item(btn.Text, GetAdditionalPrice(btn.Text)));
                        //Gets the selected topping from the User and adds any additonal cost to the cost of the Item
                        state = 18;
                        SetButtonText();
                        Label.Text = "Select The Side";
                        //Promps user to select the side
                        break;

                    case 26:
                        item.AddRequest(btn.Text);
                        //Adds the btn text as a request in the item
                        state = 14;
                        Label.Text = "Select The First Side";
                        SetButtonText();
                        //Then prompt user to enter the side
                        break;

                    case 27:
                        Label.Text = "Select Second Dip";
                        state = 28;
                        item.AddRequest(btn.Text);
                        SetButtonText();
                        //Gets the first Dip choice from user and ask user to enter the second dip choice
                        break;

                    case 28:
                    case 30:
                    case 32:
                    case 33:
                        item.AddRequest(btn.Text);
                        GetAdditonalRequests();
                        //Adds the btn text as a request in the item
                        break;

                    case 38:
                        item.AddRequest("Sauce: " + btn.Text);
                        state = 39;
                        Label.Text = "Select Rub With Wings";
                        SetButtonText();
                        //Gets the Sauce to add to the wings and ask user for what rub the customer would like with them
                        break;

                    case 39:
                        item.AddRequest("Rub: " + btn.Text);
                        GetAdditonalRequests();
                        //Adds the requested Rub to the description of the item
                        break;

                    case 40:
                    case 41:
                        temp = new Item(btn.Text, GetAdditionalPrice(btn.Text));
                        Label.Text = "Select 2nd Topping";
                        state = 42;
                        SetButtonText();
                        //Gets the first topping for the Mac and Cheese Bar
                        break;

                    case 42:
                    case 43:
                        temp.SetTopping(new Item(btn.Text, GetAdditionalPrice(btn.Text)));
                        item.SetTopping(temp);
                        //Gets the second topping for the Mac and Cheese Bar and add it as a topping to the first topping
                        state = 14;
                        Label.Text = "Select The First Side";
                        SetButtonText();
                        //Promp User to Select the first side
                        break;

                    default:
                        temp = Menu.GetItem(btn.Text);
                        item = new Item(temp.GetName(), temp.GetCost());
                        GetAdditonalRequests();
                        //If no Case matchs the current state then creats a new item with the btn text
                        break;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UpdateTime();
            if (state == 0)
            {
                state = 12;
                SetButtonText();
                //If state is 0 set the state to 12 and update the buttons texts
            }
            else if (btn.Text == "Next Page")
            {
                state++;
                SetButtonText();
            }
            //If the Button8 Text is "Next Page" when pressed increase the current state by one and update the buttons Texts
            else if (btn.Text == "Previous Page")
            {
                state--;
                SetButtonText();
                //If the Button8 Text is "Previous Page" when pressed decrease the current state by one and update the buttons Texts
            }
        }
    }
}