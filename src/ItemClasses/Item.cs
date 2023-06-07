using System.Collections;
using System.Security.Policy;

public class Item
{
    private double Cost;
    private string Name;
    private Item Topping;
    private string Requests;
    //Creates the attributes the class will have including a Item class for additional requests such as toppings

    public Item(string Name, double Cost)
    {
        //Basic constructer that sets the Name and Cost variables to what is given
        this.Name = Name;
        this.Cost = Cost;
    }
    public Item(string Name, double Cost, Item Topping)
    {
        //constructer that sets the Name and Cost variables to what is given and takes in an aditional Item class to set the AdditionalItem attribute
        this.Name = Name;
        this.Cost = Cost;
        this.Topping = Topping;
        Cost += Topping.GetCost();
    }

    public double GetCost() { return Cost; } //returns the Cost attribute

    public string GetName() { return Name; } //returns the Name attribute

    public string GetRequests() { return Requests; } //returns the Requests attribute

    public Item GetTopping() { return Topping; } //returns the Topping attribute

    public void SetTopping(Item item) {
        Topping = item;
        Cost += Topping.GetCost();
        //Sets the topping attribute to a given Item object and adds the price of the object to the base cost
    }

    public void AddRequest (string x)
    {
        if (Requests == "") { Requests = x; }
        //If Requests is an empty string then sets Requests to given string x
        else { Requests += (", " + x); }
        //Else adds the given string to the already existing requests string
    }

    public void CalculateCost()
    {
        double x = Cost;
        //Creates varable x and sets it to the previous cost
        if (this is Sandwiche)
        {
            //if this instance of the Item object is a Sandwich run this block of code
            Sandwiche sandwiche = (Sandwiche) this;
            if (sandwiche.GetSide().GetCost() > 2.5)
            {
                x += (sandwiche.GetSide().GetCost() - 2.5);
                //Gets the cost of the side and subtracts 2.5 from it and adds it to x
            }
        }
        if (this is Entree)
        {
            //if this instance of the Item object is a Entree run this block of code
            Entree entree = (Entree)this;
            if (entree.GetSides()[0].GetCost() > 2.5)
            {
                x += (entree.GetSides()[0].GetCost() - 2.5);
            }
            if (entree.GetSides()[1].GetCost() > 2.5)
            {
                x += (entree.GetSides()[1].GetCost() - 2.5);
            }
            //Gets the cost of the sides and subtracts 2.5 from each of them and adds them to x
        }
        Cost = x;
        //Sets the cost attribute to the x varable
    }

    public void SetCost(double x) { Cost = x; } //Setter for the Cost attribute

    override public string ToString() { return (Name + " Cost: " + Cost); }
    //Overrides the existing ToString method that returns a string consisiting of the name and cost attributes
}