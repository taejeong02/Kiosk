using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject.controll
{
    public static class TimerControl
    {
        public static void CloseAllFormsExceptShopPacking()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                // ShopPacking 폼을 제외한 모든 폼을 닫기
                if (form is ShopPacking)
                {
                    continue;  // ShopPacking 폼은 건너뛰고, 다른 폼들은 닫기
                }
                else
                {
                    form.Close();
                }
            }
        }
    }
}
