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
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "SummerMenu";
            summerMenu.AddMenuItems("Salmon", "Fresh from Alpes", 25.50);
            summerMenu.AddMenuItems("Tacos", "Mexican Tacos", 15.99);
            summerMenu.HospitalDirections = "Right around the corner of 5th street";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItems("Cuba libre", "classic", 3);
            outsideDrinks.AddMenuItems("Screwdriver", "Makes you hammered", 5);

            Order hungryGuestOrder = new Order();

            for(int i=0; i < summerMenu.items.Count; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);

            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

        }

    }
}
