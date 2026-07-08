public class MockDataSeeder
{
    public static void SeedInventory(InventoryWarehouse warehouse)
    {
        if (warehouse == null) return;

        Console.WriteLine("--> Seeding hardcoded components into warehouse memory...");

        RawMaterial steelSheet = new RawMaterial("RM-STEEL-01", "10-Gauge Steel Sheet", 75, 5, "SteelCorp Inc.", 10);
        RawMaterial machineScrew = new RawMaterial("RM-SCREW-05", "M5 Machine Screw", 1200, 3, "Fastener Supply", 100);
        RawMaterial plasticGrip = new RawMaterial("RM-PLAS-02", "Industrial Plastic Grip", 300, 2, "PlastiPart Co.", 25);

        warehouse.AddComponent(steelSheet);
        warehouse.AddComponent(machineScrew);
        warehouse.AddComponent(plasticGrip);

        List<BillOfMaterialItem> bracketRecipe = new List<BillOfMaterialItem>
        {
            new BillOfMaterialItem(steelSheet, 1),   
            new BillOfMaterialItem(machineScrew, 4)  
        };
        ManufacturedGood subAssemblyBracket = new ManufacturedGood("MG-SUB-01", "Internal Support Bracket", 24, 4, bracketRecipe);
        warehouse.AddComponent(subAssemblyBracket);

        List<BillOfMaterialItem> enclosureRecipe = new List<BillOfMaterialItem>
        {
            new BillOfMaterialItem(subAssemblyBracket, 2), 
            new BillOfMaterialItem(plasticGrip, 1),       
            new BillOfMaterialItem(machineScrew, 6)        
        };
        ManufacturedGood finalEnclosure = new ManufacturedGood("MG-ENCL-99", "Heavy Duty System Enclosure", 10, 3, enclosureRecipe);
        warehouse.AddComponent(finalEnclosure);

        Console.WriteLine("--> Warehouse setup complete: loaded 3 raw items and 2 manufactured goods (nested).");
    }
}