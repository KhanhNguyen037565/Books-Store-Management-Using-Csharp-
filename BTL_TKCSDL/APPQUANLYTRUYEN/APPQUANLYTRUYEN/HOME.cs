using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace APPQUANLYTRUYEN
{
    
    public partial class HOME : Form
    {
        private Button buttonHienHanh;
        private Random random;
        private int chiSoTamThoi;
        //constructors
        public HOME()
        {
            InitializeComponent();
            anMenuCon();
            random = new Random();
        }
        // ẩn các menu con
        private void anMenuCon()
        {
            panelThongKe.Visible = false;
        }
        // hiển thị menu con
        private void hienThiMenuCon(Panel panel)
        {
            if(panel.Visible == false)
            {
                anMenuCon();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        
        //phuong thuc
        // chon random màu từ danh sách màu theme
        private Color chonMauTuTheme()
        {
            int chiSo = random.Next(ThemeColor.DanhSachColor.Count);
            // nếu màu đã được chọn, chúng tôi chọn lại để chọn một màu khác
            while (chiSoTamThoi == chiSo)
            {
                chiSo= random.Next(ThemeColor.DanhSachColor.Count);
            }
            chiSoTamThoi = chiSo;
            string color = ThemeColor.DanhSachColor[chiSo];
            return ColorTranslator.FromHtml(color);
        }
        // chúng ta làm nổi bật button đã được click:
        // 1. chúng ta chọn random màu từ theme, cần sử dụng 1 màu đơn để làm nổi bật button
        // 2. chúng ta thay đổi màu nền của button
        // 3. chúng ta thay đổi màu chữ của button
        // 4. chúng ta thay đổi kích thước chữ của button
        private void buttonHoatDong(object btnSender)
        {
            if(btnSender != null)
            {
                if(buttonHienHanh != (Button)btnSender)
                {
                    voHieuHoaButton();
                    Color color = chonMauTuTheme();
                    buttonHienHanh = (Button)btnSender;
                    buttonHienHanh.BackColor = color;
                    buttonHienHanh.ForeColor = Color.White;
                    buttonHienHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTieuDe.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                }
            }
        }

        // chúng ta hủy kích hoạt làm nổi bật button - giá trị mặc định
        private void voHieuHoaButton()
        {
            foreach(Control truocButton in panelSideMenu.Controls)
            {
                if(truocButton.GetType() == typeof(Button))
                {
                    truocButton.BackColor = Color.FromArgb(51, 51, 76);
                    truocButton.ForeColor = Color.Gainsboro;
                    truocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
           
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }


        private void btnNhungTruyenChuaCoDocGiaMuon_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnTop5TruyenDuocMuonNhieuNhat_Click_1(object sender, EventArgs e)
        {
            
        }
        

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            moFormCon(new THONGKE());
            buttonHoatDong(sender);
            hienThiMenuCon(panelThongKe);
            lblTieuDe.Text = "THỐNG KÊ";
            lblTieuDe.Location = new Point(280, 42);

        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            moFormCon(new PHIEUMUON());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "PHIẾU MƯỢN";
           // lblTieuDe.Size = new Size(184,33) ;
            lblTieuDe.AutoSize = true;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(280, 42);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moFormCon(new NHANVIEN());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "NHÂN VIÊN";
            lblTieuDe.Location = new Point(275, 42);
        }

        private void btnTruyen_Click(object sender, EventArgs e)
        {
            moFormCon(new TRUYEN());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "TRUYỆN";
            lblTieuDe.Location = new Point(300, 42);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            moFormCon(new TACGIA());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "TÁC GIẢ";
            lblTieuDe.Location = new Point(300, 42);
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            moFormCon(new DOCGIA());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "ĐỘC GIẢ";
            lblTieuDe.Location = new Point(300, 42);
        }

        private void btnDanhSachMuon_Click(object sender, EventArgs e)
        {
            moFormCon(new DANHSACHMUON());
            buttonHoatDong(sender);
            anMenuCon();
            lblTieuDe.Text = "DANH SÁCH MƯỢN";
            lblTieuDe.Size = new Size(240, 33);
            lblTieuDe.Location = new Point(235,40);

        }

        private void btnBaoCaoSoLuongDaMuon_Click(object sender, EventArgs e)
        {
            moFormCon(new BAOCAOSOLUONGDAMUON());
            anMenuCon();
            lblTieuDe.Text = "BÁO CÁO SỐ LƯỢNG ĐÃ MƯỢN";
            lblTieuDe.Location = new Point(175, 42);
        }

        private void btnNhungTruyenChuaCoDocGiaMuon_Click(object sender, EventArgs e)
        {
            moFormCon(new NHUNGTRUYENCHUCODOCGIAMUON());
            anMenuCon();
            lblTieuDe.Text = "NHỮNG TRUYỆN CHƯA CÓ ĐỘC GIẢ MƯỢN";
            lblTieuDe.Location = new Point(125, 42);
        }

        private void btnTop5TruyenDuocMuonNhieuNhat_Click(object sender, EventArgs e)
        {
            moFormCon(new TOP5TRUYENDUOCMUONNHIEUNHAT());
            anMenuCon();
            lblTieuDe.Text = "TOP 5 TRUYỆN ĐƯỢC MƯỢN NHIỀU NHẤT";
            lblTieuDe.Location = new Point(125, 42);
        }
        private Form formHienThi = null;
        private void moFormCon(Form childForm)
        {
            if(formHienThi != null)
            {
                childForm.BringToFront();
            }
            formHienThi = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDestop.Controls.Add(childForm);
            panelDestop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            moFormCon(new TRANGCHU());
            lblTieuDe.Text = "QUẢN LÝ TRUYỆN";
            lblTieuDe.Location = new Point(268, 41);
            anMenuCon();
        }

    }
}
