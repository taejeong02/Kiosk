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
        // ShopPacking의 인스턴스를 저장할 static 변수
        public static Form ShopPackingInstance;
         

        public static void CloseAllFormsExceptShopPacking()
        {
            // 현재 열린 폼 목록을 순회
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                // ShopPacking 폼은 건너뛰기
                if (form == ShopPackingInstance)
                    continue;

                // 폼이 삭제되지 않았으면
                if (!form.IsDisposed)
                {
                    try
                    {
                        form.Close(); // 폼을 닫기
                    }
                    catch (ObjectDisposedException ex)
                    {
                        Console.WriteLine("이미 닫힌 폼 접근 시도: " + ex.Message);
                    }
                }
            }

            // 타이머 만료 메시지 표시
            MessageBox.Show("결제 시간이 초과되어 메인 화면으로 돌아갑니다.",
                            "시간 초과", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            if (ShopPackingInstance != null && !ShopPackingInstance.IsDisposed)
            {
                ShopPackingInstance.Show();
            }
        }
    }
}