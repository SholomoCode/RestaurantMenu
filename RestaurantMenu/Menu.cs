using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items;

        public DateTime LastUpdated;

        PublicKey Menu(List<MenuItem> item, DateTime lastUpdated)
        {
            Items = item;
            LastUpdated = lastUpdated;
        }

        public void ShowAll()
        {
            foreach(MenuItem item in Items)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Description}\n{item.Price}");
                Console.WriteLine("------------------");
            }
        }

        public void ShowItem()
        {
            Console.WriteLine($"chose id num");
            int idx = (int.Parse(Console.ReadLine())) - 1;

            if (idx < 0 || idx > Items.Count - 1)
            {
                Console.WriteLine($"no item at index");
            }
                
        }

        public void Add(MenuItem item)
        {
            Items.Add(item);
                LastUpdated = DateTime.Now;
        }

        public void Remove()
        {

        }
    }
}
