using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_Repository
{
    public class MenuRepositoryClass
    {
        protected readonly List<MenuClass> _menuRepository = new List<MenuClass>();
        // Seperate readonly for actual ingredients
        protected readonly List<MenuClass> _menuDirectory = new List<MenuClass>();


        // Working with concept from StreamingContentRepository
        // CRUD Create Read Update Delete
        // Create
        public bool AddMenuItemsToDirectory(MenuClass menuClass)
        // Read
            public List<MenuClass> menuDirectory()
        {
            return _menuRepository;
        }
        public MenuClass GetMenuItems(string menuClass)
        {
            foreach (MenuClass menuItem in _menuRepository)
            {
                if (menuclass.MealName.ToLower() == menuItem.ToLower())
                {
                    return menuItem;
                }

            }
            return null;
        }
        // Update
        public bool UpdateMenuItem(string originalMenuItem, MenuItem newMenuItem)
        {
            MenuItem oldMenuItem = GetMenuItems(originalMenuItem);

            if (MenuItem != null)
            {
                oldMenuItem.MealNumber = newMenuItem.MealNumber;
                oldMenuItem.MealName = newMenuItem.MealName;
                oldMenuItem.Description = newMenuItem.Description;
                oldMenuItem.ListOfIngredients = newMenuItem.ListOfIngredients;
                oldMenuItem.Price = newMenuItem.Price;

                return true;
            }
            else
            {
                return false;
            }
        }
        // Delete
        public bool DeleteExistingMenuItem(MenuClass MenuName)
        {
            bool deleteMenuItem = _MenuRepository.Remove(menuItem);
            return deleteResult;
        }

    }
}
