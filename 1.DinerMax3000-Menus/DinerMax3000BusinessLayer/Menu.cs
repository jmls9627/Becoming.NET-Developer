using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.DS_DinerMax3000TableAdapters;


namespace DinerMax3000.Business
{
    public class Menu
    {
        public string Name;
        public List<MenuItem> items;
        private int _databaseId;
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

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter TaMenu = new MenuTableAdapter();
            MenuItemTableAdapter TaMenuItem = new MenuItemTableAdapter();
            var dtMenu = TaMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach(DS_DinerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu._databaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItem = TaMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach(DS_DinerMax3000.MenuItemRow menuItemRow in dtMenuItem.Rows)
                {
                    currentMenu.AddMenuItems(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }
            return allMenus;

        }

        public void SaveNewMenuItem(string Name, string Description, double Price)
        {
            MenuItemTableAdapter TaMenuItem = new MenuItemTableAdapter();
            TaMenuItem.InsertNewMenuItem(Name, Description, Price, _databaseId);
        }



    }

}
