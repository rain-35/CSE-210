public class ProductionOrder
{
    private string _orderId;
    private ManufacturedGood _itemToBuild;
    private int _quantity;
    private DateTime _startDate;
    private DateTime _dueDate;
    private string _status; 

    public ProductionOrder(string orderId, ManufacturedGood item, int quantity, DateTime dueDate)
    {
        _orderId = orderId;
        _itemToBuild = item;
        _quantity = quantity;
        _dueDate = dueDate;

        _startDate = dueDate.AddDays(-item.LeadTimeDays); 
        _status = "Planned";
    }

    public void PrintOrderTicket()
    {
        Console.WriteLine($"[PRODUCTION ORDER: {_orderId}] Status: {_status}");
        Console.WriteLine($"   -> Build: {_quantity} x {_itemToBuild.Description}");
        Console.WriteLine($"   -> Start Production: {_startDate:yyyy-MM-dd}");
        Console.WriteLine($"   -> Must Complete By:  {_dueDate:yyyy-MM-dd}");
    }
}