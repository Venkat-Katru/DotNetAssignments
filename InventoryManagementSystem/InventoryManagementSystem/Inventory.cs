using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        public void DisplayItems()
        {
            Console.WriteLine("Current Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public Item FindItemById(int id)
        {
            return items.Find(item => item.ID == id);
        }

        public void UpdateItem(int id, string name, double price, int quantity)
        {
            Item item = FindItemById(id);
            if (item != null)
            {
                item.Name = name;
                item.Price = price;
                item.Quantity = quantity;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void DeleteItem(int id)
        {
            Item item = FindItemById(id);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}
