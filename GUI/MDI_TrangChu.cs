using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MDI_TrangChu : Form
    {
        public MDI_TrangChu()
        {
            InitializeComponent();
        }

        private void MDI_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DoiMatKhau a = new GUI_DoiMatKhau();
            a.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_DangNhap a = new GUI_DangNhap();
            a.ShowDialog();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLLoaiHang a = new GUI_QLLoaiHang();
            a.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLNhaCungCap a = new GUI_QLNhaCungCap();
            a.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLKhachHang a = new GUI_QLKhachHang();
            a.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLSanPham a = new GUI_QLSanPham();
            a.ShowDialog();
        }
    }
}
