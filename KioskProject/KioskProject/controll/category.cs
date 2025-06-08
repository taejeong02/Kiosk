using System.Collections.Generic;
using System.Linq;

namespace KioskProject
{
    public class Category
    {
        public string CategoryName { get; set; }

        public List<MenuItem> GetItems()
        {
            return MenuItem.GetMenuItemsFromDB(this.CategoryName);
        }
    }
}
