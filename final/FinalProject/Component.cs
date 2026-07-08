public abstract class Component
{
    
    protected string _rm_partNumber;
    protected string _rm_description;
    protected int _rm_stockQuantity;
    protected int _rm_leadTimeDays;

    public string PartNumber => _rm_partNumber;
    public string Description => _rm_description;
    public int StockQuantity => _rm_stockQuantity;
    public int LeadTimeDays => _rm_leadTimeDays;

    protected Component(string partNumber, string description, int stockQuantity, int leadTimeDays)
    {
        _rm_partNumber = partNumber;
        _rm_description = description;
        _rm_stockQuantity = stockQuantity;
        _rm_leadTimeDays = leadTimeDays;
    }

    

    public bool MatchesPartNumber(string targetPartNumber)
    {
        if (string.IsNullOrWhiteSpace(targetPartNumber))
        {
            return false;
        }
        return _rm_partNumber.Equals(targetPartNumber.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    public void AdjustStock(int amount)
    {
        _rm_stockQuantity += amount;
    }

    public virtual string GetDetails()
    {
        return $"Part: {_rm_partNumber} | Lead Time: {_rm_leadTimeDays} days";
    }


}