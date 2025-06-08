using KioskProject.entity;
using System.Collections.Generic;
using System.Linq;

namespace KioskProject.controll
{
    internal class AdminMenuAdd
    {
        // 메뉴 중복 검사
        public bool IsDuplicate(List<KioskAdminMenu.FoodItem> list, string name)
        {
            return list.Any(item => item.ProductName == name);
        }

        // 메뉴 DB에 저장
        public void AddMenu(KioskAdminMenu.FoodItem item)
        {
            MenuDB db = new MenuDB();
            db.Insert(item);
        }
    }
}
