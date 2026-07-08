public abstract class Component
{
    
    protected string _rm_partNumber;
    protected string _rm_description;
    protected int _rm_stockQuantity;
    protected int _rm_leadTimeDays;

    protected Component(string partNumber, string description, int stockQuantity, int leadTimeDays)
    {
        _rm_partNumber = partNumber;
        _rm_description = description;
        _rm_stockQuantity = stockQuantity;
        _rm_leadTimeDays = leadTimeDays;
    }

    // Inside Component.cs

    public bool MatchesPartNumber(string targetPartNumber)
    {
        if (string.IsNullOrWhiteSpace(targetPartNumber))
        {
            return false;
        }

        // Direct case-insensitive comparison of the private field
        return _rm_partNumber.Equals(targetPartNumber.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    public abstract string GetSaveData();
    // Inside Component.cs
    public abstract void ProcessProcurement(int shortageQty, DateTime finalDeadline);

}