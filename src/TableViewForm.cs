namespace SWE_3313_Project
{
    public partial class TableViewForm : Form
    {
        Table[] TableArray = new Table[32];
        Table CurrentTable = null;
        Button btn = null;
        //Creats various varables that will be utilized in the this Form
        public TableViewForm()
        {
            string[] IDArray = { "A1", "A2", "A3", "A4", "A5", "A6",
            "B1", "B2", "B3", "B4", "B5", "B6", "C5", "C6", "D5", "D6",
            "E1", "E2", "E3", "E4", "E5", "E6", "F1", "F2", "F3", "F4", "F5", "F6",
            "24", "1", "13", "12"};
            //Creates an array of string for each of the table ID's
            for (int x = 0; x < 32; x++)
            {
                TableArray[x] = new Table(IDArray[x]);
                //Sets a each element in the TableArray to a new Table with the equivalent String in the IDArray
            }
            InitializeComponent();
            UpdateTime();
            //Sets up the Current User Display and the Time Display at the bottom of the screen
        }

        public void UpdateTime()
        {
            TimeLabel.Text = "Time: " + DateTime.Now.ToShortTimeString();
            //Gets the current Time with the build in DateTime Class in C# then calls the ToShortTimeString to display the time
        }

        private void setStatusLabel()
        {
            string s;
            //Sets the text on the StatusLabel
            switch (CurrentTable.GetState())
            {
                case 1:
                    s = "Open";
                    break;

                case 2:
                    s = "Dirty";
                    break;

                case 3:
                    s = "Occupied";
                    break;

                case 4:
                    s = "Unavaliable";
                    break;

                default:
                    s = "Error";
                    break;
                    //Switch case that sets a string s to a preprogrammed string
            }
            StatusLabel.Text = "Status: " + s;
            //Sets the text on the StatusLabel to the given string from switch case
        }

        private void setButtonText()
        {
            switch (CurrentTable.GetState())
            {
                case 1:
                    ChangeStateButton.Text = "Seat Customer";
                    break;
                case 2:
                    ChangeStateButton.Text = "Clean Table";
                    break;
                case 3:
                    ChangeStateButton.Text = "Customer Leaves";
                    break;
            }
            //Sets the ButtonText bases off of the CurrentTable's state
        }

        private void setOrderIDLabel()
        {
            if (CurrentTable.GetOrder() != null)
            {
                OrderID.Visible = true;
                OrderID.Text = "Order ID: " + CurrentTable.GetOrder().GetOrderNumber();
                //If CurrentTable.GetOrder is not null make OrderID visable and set the Text
            }
            else
            {
                OrderID.Visible = false;
                //If CurrentTable.GetOrder is null make OrderID Invisable
            }
        }

        private void setPlaceOrderButton()
        {
            //Sets the PlaceOrderButton as visable if the CurrentTable is in state 3
            if (CurrentTable.GetState() == 3)
            {
                //And CurrentTable Order is null
                if ((CurrentTable.GetOrder() == null) && ((Program.User.getEmployeeType() == 4) || (Program.User.getEmployeeType() == 2) || (Program.User.getEmployeeType() == 6)))
                {
                    PlaceOrderButton.Visible = true;
                }
                else
                {
                    PlaceOrderButton.Visible = false;
                }
            }
            else
            {
                PlaceOrderButton.Visible = false;
            }
        }

        private Table GetTable(string ID)
        {
            //Method that takes in a string and returns the corresponding Table that has the ID
            foreach (Table table in TableArray)
            {
                if (table.GetTableID() == ID)
                {
                    return table;
                }
            }
            return null;
        }

        public void AddOrder(Order order)
        {
            CurrentTable.SetOrder(order);
            //Calls the SetOrder Method from the current table with a given Order object
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Program.User.getEmployeeType() != 4)
            {
                SelectTable((Button)sender, e);
            }
            else
            {
                DeselectTable();
            }
        }

        private void SelectTable(Button button, EventArgs e)
        {
            btn = button;
            string[] btnText = btn.Text.Split(' ');
            //Takes the text from the button and splits it based off of where there are spaces in the text

            CurrentTable = GetTable(btnText[1]);
            //Sets the CurrentTable based off of button text array index 1

            SelectedTableLabel.Text = "Currently Selected Table: " + CurrentTable.GetTableID();
            ChangeStateButton.Visible = true;
            setStatusLabel();
            setButtonText();
            setOrderIDLabel();
            setPlaceOrderButton();
            //Sets the text on all the Labels and Buttons
        }

        private void ChangeStateButton_Click(object sender, EventArgs e)
        {
            if ((btn != null) && (CurrentTable != null))
            {
                switch (CurrentTable.GetState())
                {
                    //Switch case that calls a function based off of CurrentTable's state and change the color of the button
                    case 1:
                        if (Program.User.getEmployeeType() != 5)
                        {
                            CurrentTable.SeatCustomer();
                            btn.BackColor = Color.Yellow;
                        }
                        break;
                    case 2:
                        if (Program.User.getEmployeeType() != 1)
                        {
                            CurrentTable.TableCleaned();
                            btn.BackColor = Color.YellowGreen;
                        }
                        break;

                    case 3:
                        if (Program.User.getEmployeeType() != 5)
                        {
                            CurrentTable.PatronsLeave();
                            btn.BackColor = Color.Red;
                        }
                        break;
                }
                setStatusLabel();
                setButtonText();
                setOrderIDLabel();
                setPlaceOrderButton();
                //Updates the labels and buttons text
            }
        }

        private void DeselectTable()
        {
            //Function to deselct the current table
            CurrentTable = null;
            SelectedTableLabel.Text = "Currently Selected Table: ";
            ChangeStateButton.Visible = false;
            StatusLabel.Text = "Status: ";
            PlaceOrderButton.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DeselectTable();
            this.Hide();
            //When the CloseButton is pressed Deselects the current table and close the form
        }

        private void PlaceOrderButtonClick(object sender, EventArgs e)
        {
            PlaceOrderForm placeOrderForm = new PlaceOrderForm(CurrentTable.GetTableID());
            placeOrderForm.ShowDialog();
            //When button is pressed create a new PlaceOrderForm and opens it
            setOrderIDLabel();
            setPlaceOrderButton();
            UpdateTime();
            //When form is closed update the IDLabel and PlaceOrderButton Text's and The Time
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {
            CurrentUserLabel.Text = "Current User: " + Program.User.getFirstName();
            UpdateTime();
        }

        private void Bar_Clicked(object sender, EventArgs e)
        {
            if ((Program.User.getEmployeeType() == 4) || (Program.User.getEmployeeType() == 6))
            {
                SelectTable((Button)sender, e);
            }
            else
            {
                DeselectTable();
            }
        }
    }
}