using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskProject
{
    public partial class Select_Language : MetroFramework.Forms.MetroForm
    {
        public Select_Language()
        {
            InitializeComponent();
            StoreOriginalTexts(this);

            try
            {
                this.Korean.BackgroundImage = Image.FromFile("KoreanFlag.png");
                this.China.BackgroundImage = Image.FromFile("ChinaFlag.jpg");
                this.English.BackgroundImage = Image.FromFile("AmericaFlag.jpg");
                this.Japan.BackgroundImage = Image.FromFile("JapanFlag.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로딩 오류: " + ex.Message);
            }
        }

        int clickcount = 0; // 관리자창은 일반인이 접근하지 못하게끔 숨겨둬야함
                            // 클릭카운트를 두고 특정횟수이상 클릭하게 되면 관리자창에 접근할 수 있도록 되어잇음
        private void test_Click(object sender, EventArgs e)
        {
            clickcount++; // 클릭시 클릭카운트 횟수가 1씩 증가
            if (clickcount == 3) { // 3번 클릭시
                AdminLogin adminLogin = new AdminLogin(); // 관리자 폼 출력
                adminLogin.ShowDialog();
                clickcount = 0; // 클릭카운트 초기화
            }
        }

        private async void Korean_Click(object sender, EventArgs e)
        {
            await TranslateAllTextsAsync("ko");
        }

        private async void English_Click(object sender, EventArgs e)
        {
            await TranslateAllTextsAsync("en");
        }

        private async void China_Click(object sender, EventArgs e)
        {
            await TranslateAllTextsAsync("zh-Hans");
        }

        private async void Japan_Click(object sender, EventArgs e)
        {
            await TranslateAllTextsAsync("ja");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OrderUI orderui = new OrderUI(this); // 현재 폼 참조 전달
            orderui.FormClosed += (s, args) => Application.Exit();
            this.Hide(); // 현재 폼 숨김
            orderui.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OrderUI orderui = new OrderUI(this); // 현재 폼 참조 전달
            orderui.FormClosed += (s, args) => Application.Exit();
            this.Hide(); // 현재 폼 숨김
            orderui.Show();
        }

        private async void Select_Language_Load(object sender, EventArgs e)
        {
            foreach (var language in languages)
            {
                // ComboBox에 언어 이름을 추가합니다.
                cbolang.Items.Add(language.Key);
            }
            await LangINFO.TranslateControlsAsync(this, LangINFO.CurrentLanguage);
        }

        Dictionary<string, string> languages = new Dictionary<string, string>
        {
            { "중국어(간체)", "zh-Hans" },
            { "중국어(번체)", "zh-Hant" },
            { "영어", "en" },
            { "일본어", "ja" },
            { "한국어", "ko" },
        };

        private void StoreOriginalTexts(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!string.IsNullOrEmpty(ctrl.Text))
                {
                    ctrl.Tag = ctrl.Text; // 원문 저장
                }

                if (ctrl.HasChildren)
                {
                    StoreOriginalTexts(ctrl); // 재귀적으로 하위 컨트롤도 저장
                }
            }
        }

        private async Task TranslateAllTextsAsync(string targetLang)
        {
            await TranslateControlTextsAsync(this, targetLang);
        }

        private async Task TranslateControlTextsAsync(Control parent, string targetLang)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag is string originalText && !string.IsNullOrWhiteSpace(originalText))
                {
                    try
                    {
                        string translated = await LangINFO.TranslateStringAsync(originalText, targetLang);
                        ctrl.Text = translated;
                    }
                    catch
                    {
                        // 번역 실패 시 원문 유지
                        ctrl.Text = originalText;
                    }
                }

                if (ctrl.HasChildren)
                {
                    await TranslateControlTextsAsync(ctrl, targetLang);
                }
            }
        }


    }
}
