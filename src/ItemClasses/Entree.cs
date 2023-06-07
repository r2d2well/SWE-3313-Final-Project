class Entree : Item
{
    Side Side1;
    Side Side2;
    //Creates 2 attributes consisting of Side classes
    public Entree(string Name, double Cost) : base(Name, Cost) { } //Just calls the base constructor

    public Entree(string Name, double Cost, Side Side1) : base(Name, Cost)
    {
        //Calls the base constructor and sets one of the side variables to the given Side variable
        this.Side1 = Side1;
    }

    public Entree(string Name, double Cost, Side Side1, Side Side2) : base(Name, Cost)
    {
        //Calls the base constructor and sets the 2 side variables to the given Side variables
        this.Side1 = Side1;
        this.Side2 = Side2;
    }
    public void AddSide(Side side)
    {
        //Method to the Entree, takes in a Side class paramater
        if (Side1 == null)
        {
            //If Side1 is null sets the new Side to Side1
            Side1 = side;
        }
        else if (Side2 == null)
        {
            //If Side2 is null sets the new Side to Side2 and calls the CalculateCost method from the Item Class
            Side2 = side;
            base.CalculateCost();
        }
    }
    public Side[] GetSides()
    {
        Side[] sideArray = new Side[2];
        sideArray[0] = Side1;
        sideArray[1] = Side2;
        return sideArray;
        //Creates an array of 2 sides and set each section to one of the sides in the class and returns the array
    } 
}