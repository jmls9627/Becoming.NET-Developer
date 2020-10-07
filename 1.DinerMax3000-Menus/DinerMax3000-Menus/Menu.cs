﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000_Menus
{
    class Menu
    {
        public string Name;
        public List<MenuItem> items;

        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddMenuItems(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
     


        }
    }
}
