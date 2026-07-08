public class InventoryWarehouse
{
    private List<Component> _rm_stockPool;

    public InventoryWarehouse()
    {
        _rm_stockPool = new List<Component>();
    }

    // Inside InventoryWarehouse.cs

    public Component FindComponent(string partNumber)
    {
        // Return null immediately if the user entered empty text
        if (string.IsNullOrWhiteSpace(partNumber))
        {
            return null;
        }

        // Loop through the private stock pool to find a match
        foreach (Component item in _rm_stockPool)
        {
            // Tell the object to evaluate its identity internally
            if (item.MatchesPartNumber(partNumber))
            {
                return item; // Hand back the direct object reference
            }
        }

        return null; // Component does not exist in the warehouse registry
    }

    public void AddComponent(Component item)
    {
        if (item != null)
        {
            _rm_stockPool.Add(item);
        }
    }


}