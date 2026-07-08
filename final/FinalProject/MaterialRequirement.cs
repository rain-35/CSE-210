public class MaterialRequirement
{
    private int _rm_quantity;
    private DateTime _rm_requiredByDate;

    public int Quantity => _rm_quantity;
    public DateTime RequiredByDate => _rm_requiredByDate;

    public MaterialRequirement(int quantity, DateTime requiredByDate)
    {
        _rm_quantity = quantity;
        _rm_requiredByDate = requiredByDate;
    }

    public void AddQuantity(int amount)
    {
        _rm_quantity += amount;
    }

    public void UpdateToEarlierDate(DateTime newDate)
    {
        if (newDate < _rm_requiredByDate)
        {
            _rm_requiredByDate = newDate;
        }
    }
}