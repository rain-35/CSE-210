using System.Collections.Generic;

public class ManufacturedGood : Component
{
    private List<BillOfMaterialItem> _rm_recipe;

    public IReadOnlyList<BillOfMaterialItem> Recipe => _rm_recipe;

    public ManufacturedGood(string partNumber, string description, int stockQuantity, int leadTimeDays, List<BillOfMaterialItem> recipe)
        : base(partNumber, description, stockQuantity, leadTimeDays)
    {
        _rm_recipe = recipe ?? new List<BillOfMaterialItem>();
    }

    public void AddRecipeItem(Component subComponent, int qtyRequired)
    {
        if (subComponent != null && qtyRequired > 0)
        {
            _rm_recipe.Add(new BillOfMaterialItem(subComponent, qtyRequired));
        }
    }

}