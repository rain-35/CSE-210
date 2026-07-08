public class BillOfMaterialItem
{
    private Component _rm_subComponent;
    private int _rm_quantityRequired;


    public BillOfMaterialItem(Component subComponent, int quantityRequired)
    {
        _rm_subComponent = subComponent;
        _rm_quantityRequired = quantityRequired;
    }
}