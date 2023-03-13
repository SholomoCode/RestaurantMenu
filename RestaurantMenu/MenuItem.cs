using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        private static int nextId = 1;

        public MenuItem(int id, string name, string description, string category, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsNew = true;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
    }
}
