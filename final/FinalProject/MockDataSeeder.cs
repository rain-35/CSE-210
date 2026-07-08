public class MockDataSeeder
{
    public static void SeedInventory(InventoryWarehouse warehouse)
    {
        if (warehouse == null) return;

        Console.WriteLine("--> Seeding hardcoded components into warehouse memory...");

        
        RawMaterial steelSheet = new RawMaterial("RM-STEEL-01", "10-Gauge Steel Sheet", 75, 5, "SteelCorp Inc.", 10);
        RawMaterial machineScrew = new RawMaterial("RM-SCREW-05", "M5 Machine Screw", 1200, 3, "Fastener Supply", 100);

        warehouse.AddComponent(steelSheet);
        warehouse.AddComponent(machineScrew);

        
        List<BillOfMaterialItem> bracketRecipe = new List<BillOfMaterialItem>
        {
            new BillOfMaterialItem(steelSheet, 1),   
            new BillOfMaterialItem(machineScrew, 4)  
        };

        
        ManufacturedGood steelBracket = new ManufacturedGood("MG-BRKT-99", "Heavy Duty Mounting Bracket", 24, 4, bracketRecipe);
        warehouse.AddComponent(steelBracket);

        Console.WriteLine("--> Warehouse setup complete: loaded 2 raw items and 1 manufactured assembly.");
    }
}