using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        InventoryWarehouse warehouse = new InventoryWarehouse();



        bool running = true;

        while (running)
        {
            
        

            Console.Clear();
            Console.WriteLine(" [1] Add New Raw Material to Inventory");
            Console.WriteLine(" [2] Add New Manufactured Good to Inventory");
            Console.WriteLine(" [3] Save Current Warehouse State to Disk");
            Console.WriteLine(" [4] Load Warehouse State from Disk");
            Console.WriteLine(" [5] Exit System");

            string choice = Console.ReadLine();



            switch (choice)
            {
                case "1":
                    // add New Raw Material to Inventory
                    Console.Write("Enter Part Number: ");
                    string rmPart = Console.ReadLine();
                    
                    Console.Write("Enter Description: ");
                    string rmDesc = Console.ReadLine();
                    
                    Console.Write("Enter Initial Stock Quantity: ");
                    int rmStock = int.Parse(Console.ReadLine());
                    
                    Console.Write("Enter Lead Time (Days): ");
                    int rmLead = int.Parse(Console.ReadLine());
                    
                    Console.Write("Enter Supplier Name: ");
                    string rmSupplier = Console.ReadLine();
                    
                    Console.Write("Enter Minimum Order Quantity: ");
                    int rmMinOrder = int.Parse(Console.ReadLine());
                    
                    // Create and store the exact configuration
                    RawMaterial newMat = new RawMaterial(rmPart, rmDesc, rmStock, rmLead, rmSupplier, rmMinOrder);
                    warehouse.AddComponent(newMat);
                    
                    Console.WriteLine("\n>>> Raw Material registered in active memory.");
                    Console.ReadKey();
                    break;
                
                case "2":
                    // Add New Manufactured Good to Inventory
                    Console.Write("Enter Assembly Part Number: ");
                    string mgPart = Console.ReadLine();
                    
                    Console.Write("Enter Description: ");
                    string mgDesc = Console.ReadLine();
                    
                    Console.Write("Enter Initial Stock Quantity: ");
                    int mgStock = int.Parse(Console.ReadLine());
                    
                    Console.Write("Enter In-House Lead Time (Days): ");
                    int mgLead = int.Parse(Console.ReadLine());

                    // Create a temporary list to hold ingredients during the setup phase
                    List<BillOfMaterialItem> tempRecipe = new List<BillOfMaterialItem>();

                    Console.WriteLine($"\n--- Defining Recipe for Assembly {mgPart} ---");
                    bool addingComponents = true;

                    while (addingComponents)
                    {
                        Console.Write("\nEnter Ingredient/Sub-Component Part Number (or press Enter to finish): ");
                        string ingredientPart = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(ingredientPart))
                        {
                            addingComponents = false;
                            continue;
                        }

                        Component subComponent = warehouse.FindComponent(ingredientPart);
                        while (subComponent == null)
                        {
                            Console.WriteLine($"\n>>> ERROR: Component '{ingredientPart}' does not exist.");
                            Console.WriteLine(" [1] Try typing the part number again");
                            Console.WriteLine(" [2] Create a new Raw Material for this ingredient right now");
                            Console.WriteLine(" [3] Cancel adding this specific ingredient");
                            Console.Write(" Select an option (1-3): ");
                            string missingChoice = Console.ReadLine();

                            if (missingChoice == "1")
                            {
                                Console.Write("Re-enter Part Number: ");
                                ingredientPart = Console.ReadLine();
                                subComponent = warehouse.FindComponent(ingredientPart);
                            }
                            else if (missingChoice == "2")
                            {
                                // In-line creation of the missing raw material
                                Console.WriteLine($"\n--- Quick Create Raw Material: {ingredientPart} ---");
                                Console.Write("Enter Description: ");
                                string rmDesc = Console.ReadLine();
                                Console.Write("Enter Initial Stock Quantity: ");
                                int rmStock = int.Parse(Console.ReadLine());
                                Console.Write("Enter Lead Time (Days): ");
                                int rmLead = int.Parse(Console.ReadLine());
                                Console.Write("Enter Supplier Name: ");
                                string rmSupplier = Console.ReadLine();
                                Console.Write("Enter Minimum Order Quantity: ");
                                int rmMinOrder = int.Parse(Console.ReadLine());

                                // Instantiate and register it inside the warehouse directly
                                RawMaterial quickMat = new RawMaterial(ingredientPart, rmDesc, rmStock, rmLead, rmSupplier, rmMinOrder);
                                warehouse.AddComponent(quickMat);
                                
                                // Set the reference so the parent recipe builder can use it immediately
                                subComponent = quickMat;
                                Console.WriteLine($">>> Success: '{ingredientPart}' created and registered.");
                            }
                            else if (missingChoice == "3")
                            {
                                break; // Break out of the error recovery loop, subComponent remains null
                            }
        
                        }

                    }





                    
                    break;
                case "3":
                    // Save Current Warehouse State to Disk"
                    
                    
                    break;

                case "4":
                    // Load Warehouse State from Disk
                    
                    
                    break;

                case "5":
                    // Exit System
                    running = false;
                    Console.WriteLine("Closing system down smoothly.");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        
        }



    }
}