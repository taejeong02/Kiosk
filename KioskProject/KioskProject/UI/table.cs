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
    public partial class table : Form
    {
        private List<string> selectedTables = new List<string> { "A1", "A2", "A3", "A4", "B1", "B2", "B3","B4", "C1", "C2", "C3", "C4" };
        public table()
        {
            this.SuspendLayout();
            // 
            // table
            // 
            this.ClientSize = new System.Drawing.Size(306, 253);
            this.Name = "table";
            this.ResumeLayout(false);
        }

        private void table_Load(object sender, EventArgs e)
        {

        }
    
    private void InitTableButtons()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    string tableName = btn.Text;

                    if (selectedTables.Contains(tableName))
                    {
                        // 선택된 테이블은 비활성화 + 회색
                        btn.Enabled = false;
                        btn.BackColor = Color.LightGray;
                    }
                    else
                    {
                        // 초기 배경색
                        btn.BackColor = Color.White;

                        // 마우스 호버 시 색상
                        btn.MouseEnter += (s, e) =>
                        {
                            Button b = s as Button;
                            b.BackColor = Color.Orange;
                        };
                        btn.MouseLeave += (s, e) =>
                        {
                            Button b = s as Button;
                            b.BackColor = Color.White;
                        };

                        // 클릭 시 동작
                        btn.Click += (s, e) =>
                        {
                            Button b = s as Button;
                            string table = b.Text;
                            MessageBox.Show($"선택된 테이블: {table}");

                            // 여기에 추가 동작 가능
                        };
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            InitTableButtons();
        }
    }
}
