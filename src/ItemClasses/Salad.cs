class Salad : Item
{
    private double SideCost;
    //Creates a float variable to keep track of the cost of the side salad
    public Salad(string Name, double Cost) : base(Name, Cost)
    {
        //Calls the base constructor and sets the SideCost to 0
        SideCost = 0;
    }
    public Salad(string Name, double Cost, double SideCost) : base(Name, Cost)
    {
        //Calls the base constructor and sets the SideCost to the given SideCost
        this.SideCost = SideCost;
    }

    public double GetSideCost() { return SideCost; } //Returns the SideCost
    override public string ToString()
    { //overrides the Item ToString method
        if (SideCost != 0)
        {
            //If the side cost is not 0 then returns a string consisting of the base name, base cost, and the SideCost
            return (base.GetName() + " Cost: " + base.GetCost() + " Side Cost: " + SideCost);
        }
        else
        {
            //If the side does cost 0 then returns a string consisting of the base name and the base cost only
            return (base.GetName() + " Cost: " + base.GetCost());
        }
    }
}