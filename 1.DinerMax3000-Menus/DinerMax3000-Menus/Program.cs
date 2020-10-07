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
            summerMenu.Name = "SummerMenu";
            summerMenu.AddMenuItems("Salmon", "Fresh from Alpes", 25.50);
            summerMenu.AddMenuItems("Tacos", "Mexican Tacos", 15.99);

        }

    }
}
