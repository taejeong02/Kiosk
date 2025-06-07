using System.Collections.Generic;
using System.Linq;

namespace KioskProject
{
    public static class Category
    {
        public static List<MenuItem> GetMenuByCategory(string category)
        {
            return MenuDatabase.MenuItems
                .Where(item => item.Category == category)
                .ToList();
        }
    }
}
