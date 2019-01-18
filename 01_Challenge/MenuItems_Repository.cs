using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuItems_Repository
    {
        List<MenuItems> _listMenuItems = new List<MenuItems>();

        public void AddMenuItemList(MenuItems item)
        {
            _listMenuItems.Add(item);
        }

        public List<MenuItems> GetMenuRepositoryList()
        {
            return _listMenuItems;
        }
        public MenuItems FindItemsByName(string mealName)
        {
            MenuItems item = new MenuItems();

            foreach (MenuItems menuItems in _listMenuItems)
            {
                if (mealName == menuItems.MealName)
                    item = menuItems;
            }
            return item;
        }
        public void RemoveMenuItems(MenuItems item)
        {
            _listMenuItems.Remove(item);
        }

        public void RemoveOrderedItem(string mealName)
        {
            
            foreach (MenuItems item in _listMenuItems)
            {
                if (item.MealName == mealName)
                {
                    RemoveMenuItems(item);
                    break;
                }
            }
            

        }
           
        

    }

}
