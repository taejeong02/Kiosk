using Google.Protobuf.WellKnownTypes;
using KioskProject;
using KioskProject.controll;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KioskProject.CartUI;

namespace KioskProject
{
    public partial class OrderUI : Form
    {
        Form previousForm;
        private List<string> allCategories = new List<string>();
        private ShopPacking previousForm2;
        private int currentPage = 0;
        private const int itemsPerPage = 7;
        private CartUI cartForm;

        private System.Windows.Forms.Timer inactivityTimer;
        public int remainingTime = 10;
        public OrderUI(Form prevForm, ShopPacking shopPackingForm) // Select_LanguageUI의 정보를 넘겨받기 위해 인자를 설정해야함 => 이전 폼을 저장할 변수    
        {
            InitializeComponent();
            this.previousForm = prevForm; // Select_LanguageUI의 정보를 previousForm에 저장
            this.previousForm2 = shopPackingForm;
            this.FormClosed += OrderUI_FormClosed;
        }
        //StartInactivityTimer(); 삭제함 아직 폼이 완전 로딩되지 않은 상태에서 로드 되기 때문에 타이머 컨트롤 작동 X


        //폼 첫 로드 시 호출, 카운트 초기화, 카테고리 버튼 생성

        private void OrderUI_Load(object sender, EventArgs e)
        {
            allCategories = KioskProject.entity.MenuDataItem.GetAllCategories();
            ShowCategoryPage();

            //타이머 시작, 사용자 이벤트 감지(새로 추가함)
            StartInactivityTimer(); // 폼 완전 로드시 시작되도록 위치 수정
            this.MouseMove += ResetInactivityTimer;  //이벤트 등록은 여기에 있어야 한 번만 수행됨(아래에 있으면 시간 초기화 될때마다 이벤트 등록됨)
            this.MouseClick += ResetInactivityTimer;

        }

        //현재 페이지 카테고리 버튼 생성
        private void ShowCategoryPage()
        {
            Category.ShowCategoryPage(
                flowLayoutPanel2,
                allCategories,
                currentPage,
                itemsPerPage,
                selectedCategory => Category.LoadMenuByCategory(selectedCategory, flowLayoutPanel1, (item, option) =>
                {
                    Category.AddToOrder(item, option, listBox1, count);
                },
                this), //orderui 자신을 전달함
                
                () => { currentPage--; ShowCategoryPage(); },
                () => { currentPage++; ShowCategoryPage(); }
            );
        }

        //특정 카테고리에 해당하는 메뉴 db에 불러오기

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            previousForm.Show();
            this.Hide();

        }

        private void flowLayoutPanelCategory(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RestoreCartFromData(List<string> cartLine)
        {
            listBox1.Items.Clear(); // 기존 장바구니 내용 초기화

            foreach (string line in cartLine)
            {
                listBox1.Items.Add(line); // 넘겨받은 항목 다시 추가
            }

            count.Text = listBox1.Items.Count.ToString(); // 수량 업데이트
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            List<string> cartLines = new List<string>();
            foreach (var obj in listBox1.Items)
            {
                cartLines.Add(obj.ToString());
            }

            cartForm = new CartUI(this, cartLines, previousForm2);
            cartForm.Show();
            this.Hide();

            if (cartForm == null || cartForm.IsDisposed)
            {
                cartForm = new CartUI(this, cartLines, previousForm2);
                cartForm.FormClosed += (s, args) =>
                {
                    this.Show();            // CartUI 닫히면 다시 OrderUI 보여줌
                    cartForm = null;        // 참조 초기화
                };
                cartForm.Show();
                this.Hide();                // 현재 OrderUI는 숨김
            }
            else
            {
                cartForm.BringToFront();    // 이미 열려있으면 앞으로
            }
        }
    

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // 타이머 남은 시간 라벨이 있다면 업데이트
            Timer.Text = $"남은 시간: {remainingTime}초";

            if (remainingTime == 0)
            {
                inactivityTimer.Stop();

                listBox1.Items.Clear(); // 저장된 카트 정보 초기화

                previousForm2.Show(); // ShopPacking 폼을 직접 표시

                MessageBox.Show("타이머 시간이 만료되었습니다. 메인 화면으로 돌아갑니다.",
                    "타이머 만료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // OrderUI 닫기

                //이 위치에서는 Timer 이벤트가 중복 등록되고 1초에 여러 번 호출되면서 시간이 더 빠르게 줄어드는 문제가 생김 그래서 1번만 실행되도록 위치를 옮겼음
            }
        }
        // 이 함수는 오로지 타이머 초기 시간만 설정하게 하고 이벤트 등록은 load이벤트에서 따로 관리하도록 했음
        public void StartInactivityTimer()
        {
            //타이머 시작 시 중복 방지 코드
            if (inactivityTimer != null)
            {
                inactivityTimer.Stop();
                inactivityTimer.Dispose();
            }
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = 1000; // 1초마다
            inactivityTimer.Tick += InactivityTimer_Tick;
            remainingTime = 10;
            Timer.Text = $"남은 시간: {remainingTime}초"; //타이머 시작 후 초기값
            inactivityTimer.Start();
        }
        public void OrderUI_Activated(object sender, EventArgs e)
        {
            // 타이머 중복 방지 코드
            if (inactivityTimer != null)
            {
                inactivityTimer.Stop();
                inactivityTimer.Dispose();
                inactivityTimer = null;
            }

            // 타이머 재시작
            StartInactivityTimer();
        }

        public void ResetInactivityTimer(object sender, EventArgs e)
        {
            remainingTime = 10;
            Timer.Text = $"남은 시간: {remainingTime}초"; //사용자가 반응하면 다시 시작
        }
        //폼 종료 후 타이머 자꾸 돌아가서 정리하는 함수
        private void OrderUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (inactivityTimer != null)
            {
                inactivityTimer.Stop();
                inactivityTimer.Dispose();
                inactivityTimer = null;
            }
        }

    }

}

