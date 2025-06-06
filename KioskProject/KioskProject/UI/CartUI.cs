using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskProject.UI;

namespace KioskProject
{
    public partial class CartUI : Form
    {
        public CartUI()
        {
            InitializeComponent();
        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            AdminCheck adminCheck = new AdminCheck();
            MessageBox.Show("결제 승인 요청중");
            adminCheck.ShowDialog();

            if (adminCheck.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void cashBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
