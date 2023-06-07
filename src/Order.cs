using System;
using System.Collections;

public class Order
{
    //Creates variables used by the class
    private ArrayList ItemList = new ArrayList();
    private DateTime PlacedTime;
    private double TotalCost;
    private string TableID;
    private static int Counter = 1;
    private int OrderNumber;
    private double SubTotal;

    public Order()
    //Constructor that creates the placed time and calls the CalculateTotalCost Method
    {
        OrderNumber = Counter;
        Counter++;
        PlacedTime = DateTime.Now;
        TotalCost = CalculateTotalCost();
    }

    public Order(string TableID)
    //Constructor that creates the placed time and calls the CalculateTotalCost Method
    {
        OrderNumber = Counter;
        Counter++;
        PlacedTime = DateTime.Now;
        TotalCost = CalculateTotalCost();
        this.TableID = TableID;
    }

    public Order(string TableID, ArrayList list)
    //Overloaded Constructor that works as first Constructor but takes in a arraylist to create the ItemList from a given ArrayList
    {
        OrderNumber = Counter;
        Counter++;
        ItemList = list;
        PlacedTime = DateTime.Now;
        TotalCost = CalculateTotalCost();
        this.TableID = TableID;
    }

    private double CalculateTotalCost()
    {
        //Method that adds up the cost from every item in the ItemList and returns the sum
        double cost = 0;
        foreach (Item item in ItemList)
        {
            cost += item.GetCost();
        }
        SubTotal = cost;
        return (cost * 1.07);
    }

    public void AddItem(Item AddedItem)
    {
        //Method that adds a new Item into the ItemList and calculate the new TotalCost
        ItemList.Add(AddedItem);
        TotalCost = CalculateTotalCost();
    }

    public void RemoveItem(int Index)
    {
        //Method that removes an Item at a certain Index and calculate the new TotalCost
        ItemList.RemoveAt(Index);
        TotalCost = CalculateTotalCost();
    }

    public double GetTotalCost() { return TotalCost; } //Returns the TotalCost value

    public string GetTableID() { return TableID; } //Returns the TableID value

    public int GetOrderNumber() { return OrderNumber; } //Returns the OrderNumber value

    public DateTime GetPlacedTime() { return PlacedTime; } //Returns the PlacedTime value

    public Item GetItem(int index) { return ItemList [index] as Item; } //Returns the Item at a given Index

    public bool IsEmpty() { return ItemList.Count == 0; } //Returns true if list is empty else returns false

    public int GetSize() { return ItemList.Count; }

    public double GetSubTotal() { return SubTotal; }
}