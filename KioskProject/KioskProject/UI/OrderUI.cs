using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using KioskProject;

namespace KioskProject
{
    public partial class OrderUI : Form
    {

        Form previousForm;
        private List<string> allCategories = new List<string>();
        private int currentPage = 0;
        private const int itemsPerPage = 7;
        private CartUI cartForm;

        public OrderUI(Form prevForm) // Select_LanguageUI의 정보를 넘겨받기 위해 인자를 설정해야함 => 이전 폼을 저장할 변수    
        {
            InitializeComponent();
            this.previousForm = prevForm; // Select_LanguageUI의 정보를 previousForm에 저장
        }

 
        //폼 첫 로드 시 호출, 카운트 초기화, 카테고리 버튼 생성

        private void OrderUI_Load(object sender, EventArgs e)
        {
            count.Text = "0";
            allCategories = Category.GetAllCategoryNames();
            ShowCategoryPage();
        }


        //자동 증가 카테고리 버튼

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
                }),
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
            previousForm.Show();
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
            List<string> cartLines = new List<string>();
            foreach (var obj in listBox1.Items)
            {
                cartLines.Add(obj.ToString());
            }

            if (cartForm == null || cartForm.IsDisposed)
            {
                cartForm = new CartUI(this, cartLines);
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
    }
}
