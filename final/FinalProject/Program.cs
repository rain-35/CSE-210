// Mrp proof of concept
// CSE-210
// Started by Rainen Morriss on 7/1/26
// Sources
//    class material
//    google
//    AI
//    stackoverflow
// this is an mrp system it does not currently have the functionality to accept custom materials and manufactured goods, 
// But that's something that could be added. It would just take a lot of time.  Currently it puts in some mock data and 
// has the ability to Calculate materials required and dates they are required by. for different manufacturing schedules.

// Inheritance is used with the component as a base class and raw material and manufactured good as subclasses.

// For Abstraction, Each class has very specific responsibilities, and they collaborate with each other. For example inventoryWarehouse stores 
// the inventory, while MaterialRequirement is responsible for tracking when an item will be needed. They both deal with items 
// but have their own purposes.

// For encapsulation, most class variables are either protected or private some of them have public facing read only variants

// Polymorphism is used in The Base Class component as a virtual method getdetails, that method is changed in the two subclasses, RawMaterial and ManufacturedGood


using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
  
        Console.WriteLine("        MRP SYSTEM STORAGE PROOF OF CONCEPT       ");

        InventoryWarehouse warehouse = new InventoryWarehouse();
        MockDataSeeder.SeedInventory(warehouse);

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("SELECT AN MRP MANUFACTURED GOOD TO EXPLODE:");
            Console.WriteLine("1. Test Single-Level Manufactured Good (Internal Bracket: MG-SUB-01)");
            Console.WriteLine("2. Test Multi-Level Nested Manufactured Good (System Enclosure: MG-ENCL-99)");
            Console.WriteLine("3. Exit Program");
            Console.Write("Enter your choice (1-3): ");

            string choice = Console.ReadLine();

            if (choice == "3")
            {
                running = false;
                continue;
            }

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("[INVALID] Please select a valid option (1, 2, or 3).");
                continue;
            }

            // Route target item based on selection (Both are Manufactured Goods)
            string targetPartNumber = (choice == "1") ? "MG-SUB-01" : "MG-ENCL-99";

            // 2. Dynamic Quantity Input
            Console.Write($"\nEnter target production batch quantity for {targetPartNumber}: ");
            if (!int.TryParse(Console.ReadLine(), out int batchSize) || batchSize <= 0)
            {
                Console.WriteLine("[ERROR] Invalid quantity. Please enter a positive whole number.");
                continue;
            }

            // 3. Dynamic Date Input (No assumed deadlines!)
            Console.Write("Enter the final delivery due date (Format: YYYY-MM-DD): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime customerDeadline))
            {
                Console.WriteLine("[ERROR] Invalid date format. Please use YYYY-MM-DD (e.g., 2026-12-25).");
                continue;
            }

            Console.WriteLine($"\n--> Processing recursive requirement calculation for: {targetPartNumber}...");
            Component foundItem = warehouse.FindComponent(targetPartNumber);

            // Execute time-phased calculations safely by verifying it matches our class type
            if (foundItem is ManufacturedGood targetAssembly)
            {
                Dictionary<string, MaterialRequirement> requirementsReport = new Dictionary<string, MaterialRequirement>();

                // Process math through our engine using the standalone tracker collection
                MRPProcessingEngine.CalculateTimePhasedRequirements(targetAssembly, batchSize, customerDeadline, requirementsReport);
                
                Console.WriteLine($"\n[SUCCESS] Time-Phased Explosion complete for Assembly: {targetAssembly.Description}");
                Console.WriteLine($"[REPORT] Raw components required for a batch of {batchSize} due by {customerDeadline:yyyy-MM-dd}:");
                foreach (var kvp in requirementsReport)
                {
                    Console.WriteLine($"   -> Part: {kvp.Key,-12} | Qty Needed: {kvp.Value.Quantity,-5} | Must Be Ready By: {kvp.Value.RequiredByDate:yyyy-MM-dd}");
                }
            }
            else
            {
                Console.WriteLine($"    [ERROR] Target item {targetPartNumber} was not found or is not a manufactured good.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine("\n==================================================");
        Console.WriteLine("POC application closed. Good luck on finals week!");
        Console.WriteLine("==================================================");
    }
}