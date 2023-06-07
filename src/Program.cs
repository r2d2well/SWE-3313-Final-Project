namespace SWE_3313_Project
{
    internal static class Program
    {
        static Queue<Order> orders = new Queue<Order>();
        static Table[] TableArray = new Table[28];
        public static TableViewForm tableViewForm = new TableViewForm();
        public static Staff staff = new Staff("EmployeeData.txt");
        public static Employee User;
        //Creates needed Varables
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void AddOrder(Order order)
        {
            orders.Enqueue(order);
            tableViewForm.AddOrder(order);
            //Adds the given Order object to the Queue and calls the tableViewForm AddOrder method
        }

        public static Queue<Order> GetQueue() { return orders; } //Returns the Queue

        public static void AddEmployee(Employee employee)
        {
            staff.addEmployee(employee);
            //Add employee to Roster
            using (StreamWriter writer = new StreamWriter("EmployeeData.txt", true))
            {
                string x = (employee.getEmployeeID() + " " + employee.getFirstName() + " " + employee.getMiddleInitial() + " " + employee.getLastName() + " " + employee.getGender() + " " + employee.getEmployeeType());
                writer.WriteLine(x);
                //Writes a new Line into the EmployeeData text file
            }
        }

        public static void ClockIn()
        {
            User.clockIn();
            using (StreamWriter writer = new StreamWriter("ClockData.txt", true))
            {
                string x = User.getEmployeeID() + " " + DateTime.Now.ToString() + " 1";
                writer.WriteLine(x);
                //Calls the User.ClockIn method and writes the clock in time into the ClockData file
            }
        }
        public static void ClockOut()
        {
            User.clockOut();
            using (StreamWriter writer = new StreamWriter("ClockData.txt", true))
            {
                string x = User.getEmployeeID() + " " + DateTime.Now.ToString() + " 0";
                writer.WriteLine(x);
                //Calls the User.ClockOut method and writes the clock out time into the ClockData file
            }
        }

        public static string GetEmployeeType(int Type)
        {
            switch (Type)
            {
                case 1:
                    return "Host";

                case 2:
                    return "Server";

                case 3:
                    return "Cook";

                case 4:
                    return "Bartenders";

                case 5:
                    return "Busser";

                case 6:
                    return "Manager";

                default:
                    return "Error";
            }
            //Switch case that Takes in a int and returns the corresponding string based off of EmployeeType
        }
        public static int GetEmployeeType(string Type)
        {
            switch (Type)
            {
                case "Host":
                    return 1;

                case "Server":
                    return 2;

                case "Cook":
                    return 3;

                case "Bartenders":
                    return 4;

                case "Busser":
                    return 5;

                case "Manager":
                    return 6;

                default:
                    return 0;
            }
            //Overloaded method that takes in a int and returns a string vice versa of the other GetEmployeeType method
        }

        static void Main()
        {
            Menu.SetUpList("MenuData.txt");
            //Calls the Menu.SetUpList with the given txt document

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }
    }
}