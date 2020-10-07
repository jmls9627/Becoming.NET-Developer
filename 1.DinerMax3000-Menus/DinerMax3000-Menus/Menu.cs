using System;
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

    }
}
