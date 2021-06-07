using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBangHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static int session = 0;
        public static int profile = 0;
        public static string mail;
        Thread th;

        FrmDangNhap dn = new FrmDangNhap();
        
        private bool CheckExistsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void VaiTroNV()
        {
            MS_NhanVien.Visible = false;
            MS_ThongKe.Visible = false;
        }

        private void ResetValue()
        {
            if (session == 1)
            {
                txtChao.Text = "Chào" + FrmMain.mail;
                MS_NhanVien.Visible = true;
                MS_DanhMuc.Visible = true;
                MS_DangXuat.Visible = true;
                MS_ThongKe.Visible = true;
                MS_ThongKeSP.Visible = true;
                MS_HoSoNV.Visible = true;
                MS_DangNhap.Enabled = false;
                if(int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                MS_NhanVien.Visible = false;
                MS_DanhMuc.Visible = false;
                MS_DangXuat.Enabled = false;
                MS_HoSoNV.Visible = false;
                MS_ThongKeSP.Visible = false;
                MS_ThongKe.Visible = false;
                MS_DangNhap.Enabled = true;
                txtChao.Text = null; 
            }
        }

        void FrmDangNhap_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }

        private void MS_DangNhap_Click(object sender, EventArgs e)
        {
            dn = new FrmDangNhap();
            if(!CheckExistsForm("FrmDangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClose);
            }
            else
            {
                ActiveChildForm("FrmDangNhap");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1)
            {
                txtChao.Text = null;
                profile = 0;
            }
        }

        void FrmNhanVien_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }

        private void MS_HoSoNV_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau profilenv = new FrmDoiMatKhau(FrmMain.mail);
            if (!CheckExistsForm("FrmDoiMatKhau"))
            {
                 profilenv.MdiParent = this;
                profilenv.FormClosed += new FormClosedEventHandler(FrmNhanVien_FormClose);
                profilenv.Show();                   
            }
            else
            {
                ActiveChildForm("FrmDoiMatKhau");
            }
        }

        private void MS_DangXuat_Click(object sender, EventArgs e)
        {
            session = 0;
            profile = 0;
            ResetValue();
        }

        private void MS_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MS_NhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            if (!CheckExistsForm ("FrmNhanVien"))
            {
                nv.MdiParent = this;
                nv.FormClosed += new FormClosedEventHandler(FrmNhanVien_FormClose);
                nv.Show();
            }
            else
            {
                ActiveChildForm("FrmNhanVien");
            }
        }

        private void MS_KhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();

            if (!CheckExistsForm("FrmKhachHang"))
            {
                kh.MdiParent = this;
                kh.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClose);
                kh.Show();
            }
            else
            {
                ActiveChildForm("FrmKhachHang");
            }
        }

        private void MS_SanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham sp = new FrmSanPham();

            if(!CheckExistsForm("FrmSanPham"))
            {
                sp.MdiParent = this;
                sp.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClose);
                sp.Show();
            }
            else
            {
                ActiveChildForm("FrmSanPham");
            }
        }

        void FrmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }

        private void MS_ThongKeSP_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe();

            if (!CheckExistsForm("FrmThongKe"))
            {
                tk.MdiParent = this;
                tk.FormClosed += new FormClosedEventHandler(FrmThongKe_FormClosed);
                tk.Show();
            }
            else
            {
                ActiveChildForm("FrmThongKe");
            }
        }
    }
}
