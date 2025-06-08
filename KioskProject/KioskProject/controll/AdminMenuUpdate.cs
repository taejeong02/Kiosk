using KioskProject.entity;
using System;
using System.Windows.Forms;

namespace KioskProject.controll
{
    internal class AdminMenuUpdate
    {
        public bool UpdateMenu(KioskAdminMenu.FoodItem item)
        {
            try
            {
                MenuDB db = new MenuDB();
                db.Update(item);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("메뉴 수정 중 오류 발생: " + ex.Message);
                return false;
            }
        }
    }
}
