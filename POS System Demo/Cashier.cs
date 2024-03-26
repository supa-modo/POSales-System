using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_Demo
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }


        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            slide(btnNewTrans);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            slide(btnSearch);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            slide(btnPay);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            slide(btnClearCart);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            slide(btnSales);
        }

        private void btnChngPwd_Click(object sender, EventArgs e)
        {
            slide(btnChngPwd);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }
    }
}
