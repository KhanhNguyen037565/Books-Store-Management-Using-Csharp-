using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thietKeTuyChinh();
        }
        private void thietKeTuyChinh()
        {
            // ẩn các menu con
            panelDanhSachMuon.Visible = false;
            panelThongKe.Visible = false;
        }

        // hàm ẩn menu con đã được hiển thị trước đó
        private void anMenuCon()
        {
            if(panelDanhSachMuon.Visible == true)
            {
                panelDanhSachMuon.Visible = false;
            }
            if(panelThongKe.Visible == true)
            {
                panelThongKe.Visible = false;
            }
        }

        // hàm hiển thị menu con
        private void hienThiMenuCon(Panel menuCon) 
        {
            if(menuCon.Visible == false)
            {
                anMenuCon(); // ẩn menu con khác đang hiện
                menuCon.Visible = true; // hiện menu con cần mở
            }
            else
            {
                menuCon.Visible = false;
            }
        }
    

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            hienThiMenuCon(panelThongKe);
        }

        private void btnTrongKyHan_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnBaoCaoSoLuongDaMuon_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnTop5TruyenChuaCoDocGiaMuon_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnTop5TruyenDuocMuonNhieuNhat_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnDanhSachMuon_Click(object sender, EventArgs e)
        {
            hienThiMenuCon(panelDanhSachMuon);
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            hienThiFormCon(new FormPhieuMuon());
            anMenuCon();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnTruyen_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            anMenuCon();
        }
        private Form trangThaiHoatDongForm = null;
        private void hienThiFormCon(Form hienThi)
        {
            // kiểm tra form khác có đang mở hay không, nếu có thì đóng form khác 
            if(trangThaiHoatDongForm != null)
            {
                Close();
            }
            // sau đó gán trạng thái hiển thị bằng form muốn hiển thị
            trangThaiHoatDongForm = hienThi;
            hienThi.TopLevel = false;
            hienThi.FormBorderStyle = FormBorderStyle.None;
            hienThi.Dock = DockStyle.Fill; // lấp đầy phần hiển thị
            panelHienThi.Controls.Add(hienThi);
            panelHienThi.Tag = hienThi;
            // hiển thị form lên phía trước
            hienThi.BringToFront();
            // hiển thị form
            hienThi.Show();
        }
    }
}
