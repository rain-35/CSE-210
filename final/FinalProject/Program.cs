using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("        MRP SYSTEM STORAGE PROOF OF CONCEPT       ");
        Console.WriteLine("==================================================");

        
        InventoryWarehouse warehouse = new InventoryWarehouse();

        
        MockDataSeeder.SeedInventory(warehouse);

        Console.WriteLine("--------------------------------------------------");

        
        Console.WriteLine("\n--> Requesting requirement explosion for: MG-BRKT-99...");
        Component foundItem = warehouse.FindComponent("MG-BRKT-99");

        if (foundItem is ManufacturedGood targetAssembly)
        {
            int batchSize = 50; // Suppose a customer orders 50 brackets
            Dictionary<string, int> requirementsReport = new Dictionary<string, int>();

            // Process calculation using our dedicated processing engine
            MRPProcessingEngine.CalculateTotalRequirements(targetAssembly, batchSize, requirementsReport);

            // Output the calculated final inventory totals
            Console.WriteLine($"\n[REPORT] Material needs for a production batch of {batchSize}:");
            foreach (var kvp in requirementsReport)
            {
                Console.WriteLine($"   -> Part: {kvp.Key,-15} | Total Units Required: {kvp.Value}");
            }
        }
        else
        {
            Console.WriteLine("    [ERROR] Target manufactured item not found in warehouse registry.");
        }

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("POC process finished successfully. Press any key to close.");
        Console.ReadKey();
    }
}