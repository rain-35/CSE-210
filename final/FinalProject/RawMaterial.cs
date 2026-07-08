public class RawMaterial : Component
{
    private string _rm_supplierName;
    private int _rm_minOrderQty;

    public RawMaterial(string partNumber, string description, int stockQuantity, int leadTimeDays, string supplierName, int minOrderQty)
        : base(partNumber, description, stockQuantity, leadTimeDays)
    {
        _rm_supplierName = supplierName;
        _rm_minOrderQty = minOrderQty;
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $" | Supplier: {_rm_supplierName}";
    }
}