using System;

class Table
{
    //Creates variables used by the class including a static variable to create the table ID
    private string TableID;
    private int TotalPatronSeated;
    private string Sever;
    private Order order;
    private byte State;
    //state 1 indicates table is open
    //state 2 indicates table is unoccupied but dirty
    //state 3 indicates table is occupied
    //state 4 indicates table is unavailable

    private DateTime SeatedTime;

    public Table(string TableID)
    //Constructor that creates the table ID from a static variable and sets the current state of the table to 1
    {
        this.TableID = TableID;
        State = 1;
        TotalPatronSeated = 0;
    }

    public void TableCleaned()
    {
        State = 1;
        //Set the state to one indicating the table is ready for use again
    }

    public void SeatCustomer()
    {
        SeatedTime = DateTime.Now;
        State = 3;
        TotalPatronSeated++;
        //sets the current table stat to 3 and sets the seatedTime to the current time
    }

    public String PatronsLeave()
    {
        State = 2;
        //sets 2 as the current state

        TimeSpan turnAroundTime = DateTime.Now.Subtract(SeatedTime);
        //Creates the turn around time from subtracting the seated time from the current time

        order = null;

        return turnAroundTime.ToString();
        //retruns the turn around time
    }

    public string GetSever() { return Sever; } //Returns the server value

    public Order GetOrder() { return order; } //Returns the Order value

    public string GetTableID() { return TableID; } //Returns TableID value

    public int GetState() { return State; } //Returns State value

    public void SetOrder(Order order) { this.order = order; } //Setter for the order value

    public void SetSever(string Sever) { this.Sever = Sever; } //Setter for the Server value
}