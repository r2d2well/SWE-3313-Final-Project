using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class Staff
{

    public Staff()
    {
    }

    public Staff(string x)
    {
        SetUpRoster(x);
    }

    List<Employee> Roster = new List<Employee>();

    public bool validPassword(string password)
    {

        if (password.Length != 6)
        {
            return false;
        }
        //Method for checking password validity begins by making sure the password is the correct length

        if (Roster.Count > 0)
        {
            for (int i = 0; i < Roster.Count; i++)
            {
                if (password.Equals(Roster[i].getEmployeeID()))
                {
                    return false;
                }
            }
        }
        //Method continues by making sure the password is unique through comparing new password to all existing passwords

        //Note the next parts of the method look into the password with detail so we converted it into an array
        char[] decomposedPassword = password.ToCharArray();
        int count = 0;


        for (int j = 0; j < 5; j++)
        {
            if (decomposedPassword[j] > 57 || decomposedPassword[j] < 47)
            {
                return false;
            }
        }
        //Confirms all values are numbers

        for (int a = 0; a < 5; a++)
        {
            if (decomposedPassword[a + 1] == decomposedPassword[a])
            {
                count++;
            }
        }

        if (count >= 3)
        {
            return false;
        }
        //Method checks for continous repeating values


        count = 0;
        for (int b = 0; b < 5; b++)
        {
            if (decomposedPassword[b + 1] == (decomposedPassword[b] + 1))
            {
                count++;
            }
            else if (decomposedPassword[b + 1] == (decomposedPassword[b] - 1))
            {
                count++;
            }
        }

        if (count >= 4)
        {
            return false;
        }
        //Method checks for incremental or decremental values

        return true;
        //If all conditions are satisfied then method is true
    }

    public Employee employeeSearch(string password)
    {
        for (int p = 0; p < Roster.Count; p++)
        {
            if (password.Equals(Roster[p].getEmployeeID()))
            {
                return Roster[p];
            }
        }
        return null; ;
    }

    public void addEmployee(Employee employee)
    {
        Roster.Add(employee);
    }

    public void addEmployee()
    {

        string pass, FN, LN;
        int gender, type;

        Console.Write("Pick a 6 digit number code for the employee: ");
        pass = Console.ReadLine();

        if (validPassword(pass) == false)
        {
            do
            {
                Console.Write("Password is too simple choose another 6 digit number code for the employee: ");
                pass = Console.ReadLine();
            } while (validPassword(pass) == false);
        }

        Console.Write("What is the employee's name?: ");
        FN = Console.ReadLine();

        Console.Write("What is the initial of the person's middle name?: ");
        char MN = char.Parse(Console.ReadLine());

        Console.Write("What is the employee's surname?: ");
        LN = Console.ReadLine();

        do
        {
            Console.Write("What is the employee's Gender? \n0 - Male \n1 - Female \nGender: ");
            gender = Convert.ToInt16(Console.ReadLine());
        } while (gender < 0 || gender > 1);


        Console.Write("What is the employee's role? \n1 - Host/Hostess \n2 - Waiter/Waitress \n3 - Chef \n4 - Bartender \n5 Busboy/Busgirl \n6 - Manager \nRole: ");
        type = Convert.ToInt16(Console.ReadLine());

        do
        {
            Console.Write("Number must be between 1 & 6. Choose a proper employee role: ");
            type = Convert.ToInt16(Console.ReadLine());
        } while (type > 6 || type < 1);

        Roster.Add(new Employee(pass, FN, MN, LN, gender, type));
    }

    public void removeEmployee()
    {

        Console.Write("Enter the password of the employee you want to delete: ");
        string x = Console.ReadLine();
        if (employeeSearch(x) == null)
        {
            Console.WriteLine("Process has been canceled");
        }
        else
        {
            Console.WriteLine("Deleting " + employeeSearch(x).getFirstName() + "'s account...");
            Roster.Remove(employeeSearch(x));
            Console.WriteLine("Account has successfully been deleted.");
        }
    }

    public void removeEmployee(string x)
    {
        if (employeeSearch(x) != null)
        {
            Roster.Remove(employeeSearch(x));
        }
    }

    public void restrictEmployee()
    {

        Console.Write("Enter the password of the employee you want to restrict: ");
        string w = Console.ReadLine();
        if (employeeSearch(w) == null)
        {
            Console.WriteLine("Process has been canceled");
        }
        else
        {
            Console.WriteLine("Restricting " + employeeSearch(w).getFirstName() + "'s account...");
            employeeSearch(w).Restrict();
            Console.WriteLine("Account has successfully been restricted.");
        }
    }

    public void unrestrictEmployee()
    {

        Console.Write("Enter the password of the employee you want to unrestrict: ");
        string y = Console.ReadLine();
        if (employeeSearch(y) == null)
        {
            Console.WriteLine("Process has been canceled");
        }
        else
        {
            Console.WriteLine("Unrestricting " + employeeSearch(y).getFirstName() + "'s account...");
            employeeSearch(y).Unrestrict();
            Console.WriteLine("Account has successfully been unrestricted.");
        }
    }

    public void clockInOut()
    {

        Console.Write("Enter your password: ");
        string c = Console.ReadLine();
        if (employeeSearch(c) == null)
        {
            Console.WriteLine("Process has been canceled");
        }
        else if (employeeSearch(c).isClocked() == true)
        {
            employeeSearch(c).clockOut();
        }
        else if (employeeSearch(c).isClocked() == false)
        {
            employeeSearch(c).clockIn();
        }

    }

    public void Login()
    {

        Console.Write("Enter the password of the employee logging in: ");
        string l = Console.ReadLine();
        if (employeeSearch(l) == null)
        {
            Console.WriteLine("Process has been canceled");
        }
        else
        {
            Console.WriteLine(employeeSearch(l).getFirstName() + " has logged in!");
        }
    }
    
    private void SetUpRoster(string FilePath)
    {
        using (StreamReader file = new StreamReader(FilePath)) //Uses StreamReader to iterate though the file
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string [] array = line.Split(' ');
                string ID = array[0];
                string FirstName = array[1];
                char Initial = array[2] [0];
                string LastName = array[3];
                int Gender;
                if (array[4] == "Male")
                {
                    Gender = 0;
                }
                else
                {
                    Gender = 1;
                }
                int EmployeeType = int.Parse(array[5]);
                Roster.Add(new Employee (ID, FirstName, Initial, LastName, Gender, EmployeeType));
            }
        }
    }


    //Two things that need to be added is updating the text file and read in the text file
}