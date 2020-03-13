using QLKHO.Formcontains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHO
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            FormNhapHang fnh = new FormNhapHang();
            fnh.Show();
            this.Hide();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            FormXuatHang fxh = new FormXuatHang();
            fxh.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe ftk = new FormThongKe();
            ftk.Show();
            this.Hide();
        }

        private void btntimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiem ftk = new FormTimKiem();
            ftk.Show();
            this.Hide();

        }
    }
}
