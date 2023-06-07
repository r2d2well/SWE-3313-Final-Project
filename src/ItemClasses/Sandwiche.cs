class Sandwiche : Item
{
    Side Side;
    //Creates a Side attribute consising of variable type Side
    public Sandwiche(string Name, double Cost) : base(Name, Cost) { } //Just calls the base constructor

    public Sandwiche(string Name, double Cost, Side Side) : base(Name, Cost)
    {
        //Calls the base constructor and sets the side variables to the given Side variable
        this.Side = Side;
    }
    public Side GetSide() { return Side; } //Returns the Side attribute
    public void SetSide(Side side)
    {
        Side = side;
        base.CalculateCost();
        //Sets the Side attribute and calls the base CalculateCost method
    }
}