using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Items");
                Console.WriteLine("3. Find Item by ID");
                Console.WriteLine("4. Update Item");
                Console.WriteLine("5. Delete Item");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddItem(inventory);
                        break;
                    case 2:
                        inventory.DisplayItems();
                        break;
                    case 3:
                        FindItem(inventory);
                        break;
                    case 4:
                        UpdateItem(inventory);
                        break;
                    case 5:
                        DeleteItem(inventory);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddItem(Inventory inventory)
        {
            Console.Write("Enter item ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter item price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter item quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Item item = new Item(id, name, price, quantity);
            inventory.AddItem(item);
        }

        static void FindItem(Inventory inventory)
        {
            Console.Write("Enter item ID to find: ");
            int id = int.Parse(Console.ReadLine());
            Item item = inventory.FindItemById(id);
            if (item != null)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        static void UpdateItem(Inventory inventory)
        {
            Console.Write("Enter item ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new item price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter new item quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            inventory.UpdateItem(id, name, price, quantity);
        }

        static void DeleteItem(Inventory inventory)
        {
            Console.Write("Enter item ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            inventory.DeleteItem(id);
        }
    }
}
