public class InventoryWarehouse
{
    private List<Component> _rm_stockPool;

    public InventoryWarehouse()
    {
        _rm_stockPool = new List<Component>();
    }

    public Component FindComponent(string partNumber)
    {
        
        if (string.IsNullOrWhiteSpace(partNumber))
        {
            return null;
        }

        
        foreach (Component item in _rm_stockPool)
        {
            
            if (item.MatchesPartNumber(partNumber))
            {
                return item; 
            }
        }

        return null; 
    }

    public void AddComponent(Component item)
    {
        if (item != null)
        {
            _rm_stockPool.Add(item);
        }
    }


}