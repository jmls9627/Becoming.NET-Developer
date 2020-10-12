using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> MenusFomDB = Menu.GetAllMenus();


            Order hungryGuestOrder = new Order();

            foreach (Menu CurrentMenu in MenusFomDB)
            {
                foreach (MenuItem currentItem in CurrentMenu.items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }

            Console.WriteLine("the Total is: " + hungryGuestOrder.Total);

           
          
            Console.ReadKey();

        }

    }
}
