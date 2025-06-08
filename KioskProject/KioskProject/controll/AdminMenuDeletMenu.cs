using KioskProject.entity;
using System;
using System.Windows.Forms;

namespace KioskProject.controll
{
    internal class AdminMenuDeletMenu
    {
        public bool DeleteMenu(string productId)
        {
            try
            {
                MenuDB db = new MenuDB();
                db.Delete(productId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("메뉴 삭제 중 오류 발생: " + ex.Message);
                return false;
            }
        }
    }
}
