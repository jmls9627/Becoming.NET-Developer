using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer Menu";
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Salmon from the Alpes";
            salmon.Price = 25.50;
            summerMenu.items.Add(salmon);

        }
    }
}
