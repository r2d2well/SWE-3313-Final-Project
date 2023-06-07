class Side : Item
{
    private double AdditonalCost;
    public Side(string Name, double AdditionalCost) : base(Name, 2.5 + AdditionalCost)
    {
        this.AdditonalCost = AdditionalCost;
        //calls the base constructor with the given name attribute and sets the price to 2.5 plus the given additional cost
    }
    public Side(string Name) : base(Name, 2.5) { } //Just calls the base constructor with the given name variable and sets the cost to 2.5
}