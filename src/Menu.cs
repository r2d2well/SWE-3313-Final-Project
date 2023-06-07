using System.Globalization;
using static System.Windows.Forms.LinkLabel;

static class Menu
{
    private static List<Appetizer> AppetizerList = new List<Appetizer>();
    private static List<Salad> SaladList = new List<Salad>();
    private static List<Entree> EntreeList = new List<Entree>();
    private static List<Sandwiche> SandwicheList = new List<Sandwiche>();
    private static List<Sandwiche> WrapList = new List<Sandwiche>();
    private static List<Sandwiche> BurgerList = new List<Sandwiche>();
    private static List<Drink> DrinkList = new List<Drink>();
    private static List<Side> SideList = new List<Side>();
    //Creates several List for each type of Item on the menu

    public static void SetUpList(string FilePath) //Takes in the file path as a String and sets up the list with the given text file path
    {
        using (StreamReader file = new StreamReader(FilePath)) //Uses StreamReader to iterate though the file
        {
            string line;
            int counter = 0;
            //Creates a String to keep track of the current Line and a counter to keep track of what section of the menu is being looked though

            while ((line = file.ReadLine()) != null)
            //Makes sure there is still unread lines in the file
            {
                if (line == "")
                {
                    counter++;
                    //If the line is empty increases the value of counter by 1
                }
                else
                {
                    string[] StringArray = line.Split(' ');
                    //If line is not empty converts the String into a StringArray split wherever there is a space

                    switch (counter)
                    {
                        //A switch case that adds a new Item to one of the Lists depending on what section of the menu we are currently on
                        //It knows this based off of the counter variable
                        case 0:
                            AppetizerList.Add(new Appetizer(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 1:
                            //If given item is a salad then it decides what constructor to call based off of the length of the StringArray
                            if (StringArray.Length == 3)
                            {
                                SaladList.Add(new Salad(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat), float.Parse(StringArray[2], CultureInfo.InvariantCulture.NumberFormat)));
                            }
                            else
                            {
                                SaladList.Add(new Salad(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            }
                            break;
                        case 2:
                            EntreeList.Add(new Entree(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 3:
                            SandwicheList.Add(new Sandwiche(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 4:
                            WrapList.Add(new Sandwiche(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 5:
                            BurgerList.Add(new Sandwiche(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 6:
                            DrinkList.Add(new Drink(StringArray[0].Replace('_', ' ')));
                            break;
                        case 7:
                            //If given item is a Side then it decides what constructor to call based off of the length of the StringArray
                            if (StringArray.Length == 2)
                            {
                                SideList.Add(new Side(StringArray[0].Replace('_', ' '), float.Parse(StringArray[1], CultureInfo.InvariantCulture.NumberFormat)));
                            }
                            else
                            {
                                SideList.Add(new Side(StringArray[0].Replace('_', ' ')));
                            }
                            break;
                        default:
                            //Default case that prints an Error Message
                            throw new Exception("Menu SetUpList Exception!");
                    }
                }
            }
        }
    }

    private static void PrintList<T>(List<T> List) where T : Item
    {
        //Function that takes in a List of any variable as long as said variable is a child of the Item class
        foreach (Item item in List)
        {
            Console.WriteLine(item.ToString());
            //For each item in the List prints out the item.ToString method
        }
        Console.WriteLine();
        //After method is done printing out every item in the list calls the COnsole.WriteLine method to add a blank space between lists
    }

    public static void PrintMenu()
    {
        PrintList(AppetizerList);
        PrintList(SaladList);
        PrintList(EntreeList);
        PrintList(SandwicheList);
        PrintList(WrapList);
        PrintList(BurgerList);
        PrintList(DrinkList);
        PrintList(SideList);
        //Calls the PrintList function for every list in the Menu class
    }

    private static Item FindItem <T> (List<T> List, string x) where T : Item
    {
        //Method that takes in a List of a singular object type inhreating from the Item class
        //and searchs said List for a Item object with the given string called x
        foreach (Item item in List)
        {
            if (item.GetName() == x)
            {
                return item;
                //If a object is found with the same name as x returns a instance of that object
            }
        }
        return null;
        //Else returns null
    }

    public static Item GetItem(string name)
    {
        //If one of the list contains an item object with the same name as given returns the item object
        if (FindItem(AppetizerList, name) != null)
        {
            return FindItem(AppetizerList, name);
        }

        else if (FindItem(SaladList, name) != null)
        {
            return FindItem(SaladList, name);
        }

        else if (FindItem(EntreeList, name) != null)
        {
            return FindItem(EntreeList, name);
        }

        else if (FindItem(SandwicheList, name) != null)
        {
            return FindItem(SandwicheList, name);
        }

        else if (FindItem(WrapList, name) != null)
        {
            return FindItem(WrapList, name);
        }

        else if (FindItem(BurgerList, name) != null)
        {
            return FindItem(BurgerList, name);
        }

        else if (FindItem(DrinkList, name) != null)
        {
            return FindItem(DrinkList, name);
        }

        else if (FindItem(SideList, name) != null)
        {
            return FindItem(SideList, name);
        }

        return null;
    }
}