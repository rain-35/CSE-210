public class RawMaterial  : Component
{
    private string _rm_supplierName;
    private int _rm_minOrderQty;

    public RawMaterial(string partNumber, string description, int stockQuantity, int leadTimeDays, string supplierName, int minOrderQty): base(partNumber, description, stockQuantity, leadTimeDays)
    {
        _rm_supplierName = supplierName;
        _rm_minOrderQty = minOrderQty;
    }

    

    public override void ProcessProcurement(int shortageQty, DateTime finalDeadline) { }

    public override string GetSaveData()
    {
        return $"RawMaterial|{_rm_partNumber}|{_rm_description}|{_rm_stockQuantity}|{_rm_leadTimeDays}|{_rm_supplierName}|{_rm_minOrderQty}";
    }


}