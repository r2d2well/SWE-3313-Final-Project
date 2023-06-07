using System;
using System.Globalization;

public class Employee
{

    private string EmployeeID;
    private string FirstName;
    private char MiddleInitial;
    private string LastName;
    private bool Gender; //Set to true for male and false for female
    private bool Restricted;
    private int EmployeeType; //Should be from 1 - 6. | 1 - Host Staff | 2 - Wait Staff | 3 - Cooks | 4 - Bartenders | 5 - Bussers | 6 - Managers |
    private double Hours;
    private bool Clocked;
    private DateTime clockInTime;

    public Employee()
    {
        EmployeeID = "";
        FirstName = "";
        MiddleInitial = ' ';
        LastName = "";
        Gender = true;
        Restricted = true;
        EmployeeType = 0;
        Hours = 0.0;
        Clocked = false;
    }

    public Employee(string ID, string name, char mid, string surname, int gen, int type)
    {
        EmployeeID = ID;
        FirstName = name;
        MiddleInitial = mid;
        LastName = surname;

        if (gen == 0)
        {
            Gender = true;
        }
        else
        {
            Gender = false;
        }

        Restricted = true;
        EmployeeType = type;
        Hours = 0.0;
        Clocked = false;
    }



    public string getEmployeeID()
    {
        return EmployeeID;
    }

    public string getFirstName()
    {
        return FirstName;
    }

    public char getMiddleInitial()
    {
        return MiddleInitial;
    }

    public string getLastName()
    {
        return LastName;
    }

    public string getGender()
    {
        if (Gender == true)
        {
            return "Male";
        }
        else
        {
            return "Female";
        }
    }

    public int getEmployeeType()
    {
        return EmployeeType;
    }

    public string RestrictedAccount()
    {
        if (Restricted == true)
        {
            return "Restricted";
        }
        else if (Restricted == false)
        {
            return "Unrestricted";
        }
        else
        {
            return "N/A";
        }
    }

    public bool isRestricted()
    {
        if (Restricted == true)
        {
            return true;
        }
        else if (Restricted == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string getRole()
    {

        switch (EmployeeType)
        {

            case 1:
                if (Gender == true)
                {
                    return "Host";
                }
                else if (Gender == false)
                {
                    return "Hostess";
                }
                else
                {
                    return "Genderless Hosting Staff";
                }
                break;

            case 2:
                if (Gender == true)
                {
                    return "Waiter";
                }
                else if (Gender == false)
                {
                    return "Waitress";
                }
                else
                {
                    return "Genderless Waiting Staff";
                }
                break;

            case 3:
                return "Cook/Chef";
                break;

            case 4:
                return "Bartender";
                break;

            case 5:
                if (Gender == true)
                {
                    return "Busboy";
                }
                else if (Gender == false)
                {
                    return "Busgirl";
                }
                else
                {
                    return "Genderless Bussing Staff";
                }
                break;

            case 6:
                return "Manager";
                break;

            default:
                return "Does not work here";
                break;

        }
    }

    public double getHours()
    {
        return Hours;
    }

    public bool isClocked()
    {
        if (Clocked == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Getters


    public void setEmployeeNumber(string num)
    {
        EmployeeID = num;
    }

    public void setFirstName(string name)
    {
        FirstName = name;
    }

    public void setMiddleInitial(char mid)
    {
        MiddleInitial = mid;
    }

    public void setLastName(string surname)
    {
        LastName = surname;
    }

    public void setGender(string MF)
    {
        if (MF.ToUpper().Equals("M"))
        {
            Gender = true;
        }
        else if (MF.ToUpper().Equals("F"))
        {
            Gender = false;
        }
    }

    public void Restrict()
    {
        Restricted = true;
    }

    public void Unrestrict()
    {
        Restricted = false;
    }

    public void setEmployeeType(int type)
    {
        EmployeeType = type;
    }

    public void addHours(double time)
    {
        Hours += time;
    }

    public void clockIn()
    {
        Clocked = true;
        Console.WriteLine(FirstName + " has clocked in at " + DateTime.Now + ". Enjoy your shift!");
        clockInTime = DateTime.Now;
    }

    public void clockOut()
    {
        Clocked = false;
        Console.WriteLine(FirstName + " has clocked out at " + DateTime.Now + ". Have a nice day!");
        addHours((clockInTime.Subtract(DateTime.Now)).TotalHours);
        clockInTime = DateTime.MinValue;
    }
    // Setters

    public void getSummary()
    {
        Console.WriteLine("Name: " + FirstName + " " + MiddleInitial + ". " + LastName);
        Console.WriteLine("Gender: " + getGender());
        Console.WriteLine("Role: " + getRole());
        Console.WriteLine("Hours worked: " + getHours());
        Console.WriteLine("Account Status: " + RestrictedAccount());
    }
    //This method also functions as a ToString Method

}
