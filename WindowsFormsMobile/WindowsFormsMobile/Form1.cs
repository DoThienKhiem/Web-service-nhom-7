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
using WindowsFormsMobile.ServiceReferenceDanhMuc;
using WindowsFormsMobile.ServiceReferenceSanPham;
using WindowsFormsMobile.ServiceReferenceUser;
using WindowsFormsMobile.ServiceReferenceDonHang;
using WindowsFormsMobile.ServiceReferenceQuyen;


namespace WindowsFormsMobile
{
    public partial class Form1 : Form
    {
        private ServiceUserClient sus = new ServiceUserClient();
        private ServiceSanPhamClient ssp = new ServiceSanPhamClient();
        private ServiceDanhMucClient sdm = new ServiceDanhMucClient();
        private ServiceDonHangClient sdh = new ServiceDonHangClient();
        private ServiceQuyenClient sq = new ServiceQuyenClient();
        private string _hinh = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobileDataSet2.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.mobileDataSet2.PhieuNhap);
            // TODO: This line of code loads data into the 'mobileDataSet1.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.mobileDataSet1.DonHang);
            // TODO: This line of code loads data into the 'mobileDataSetDanhMucSP.DanhMucSP' table. You can move, or remove it, as needed.
            //this.danhMucSPTableAdapter.Fill(this.mobileDataSetDanhMucSP.DanhMucSP);
            //// TODO: This line of code loads data into the 'mobileDataSet.SanPham' table. You can move, or remove it, as needed.
            //this.sanPhamTableAdapter.Fill(this.mobileDataSet.SanPham);
            //// TODO: This line of code loads data into the 'mobileDataSetUser.NguoiDung' table. You can move, or remove it, as needed.
            //this.nguoiDungTableAdapter.Fill(this.mobileDataSetUser.NguoiDung);
            //// combo box danh muc
            //var dsdm = sdm.findAll();
            //cbb_danhmucsp.DataSource = dsdm;
            //cbb_danhmucsp.DisplayMember = "TenDM";
            //cbb_danhmucsp.ValueMember = "MaDM";
            show();

        }

        private void show()
        {
            // greidview user
            GridViewUser.AutoGenerateColumns = false;
            var danhsachuser = sus.findAll();
            GridViewUser.DataSource = danhsachuser;
            var dsq = sq.findAll();
            cbb_quyenus.DataSource = dsq;
            cbb_quyenus.DisplayMember = "TenQuyen";
            cbb_quyenus.ValueMember = "MaQuyen";

            // gridview san pham
            GridViewSP.AutoGenerateColumns = false;
            var danhSachSP = ssp.findAll();
            GridViewSP.DataSource = danhSachSP;

            // combobox danh muc o tab san pham
            var dsdm = sdm.findAll();
            
            cbb_danhmucsp.DataSource = dsdm;
            cbb_danhmucsp.DisplayMember = "TenDM";
            cbb_danhmucsp.ValueMember = "MaDM";

            // gridview danh muc
            GridViewDM.AutoGenerateColumns = false;
            var danhSachDM = sdm.findAll();
            GridViewDM.DataSource = danhSachDM;

            // gridview don hang
            GridViewDH.AutoGenerateColumns = false;
            var danhSachDH = sdm.findAll();
            GridViewDM.DataSource = danhSachDM;
            




        }



        // tab quan ly user

        //private void but_add_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string username = txt_ID.Text.ToString();
        //        string password = txt_Pass.Text.ToString();
        //        string hotennd = txt_Name.Text.ToString();
        //        string email = txt_Email.Text.ToString();
        //        string diachi = txt_Addres.Text.ToString();
        //        string SoDienThoai = txt_Sodt.Text.ToString();
        //        string NgaySinh = txt_Ngaysinh.Text.ToString();
        //        int quyen = int.Parse(txt_Quyen.Text.ToString());
        //        sus.AddUser(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
        //        MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        GridViewUser.DataSource = null;
        //        GridViewUser.DataSource = sus.findAll();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Lỗi");
        //    }


        //}

        private void GridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            //txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_ID.Text = GridViewUser.Rows[dong].Cells[0].Value.ToString();
            txt_Pass.Text = GridViewUser.Rows[dong].Cells[1].Value.ToString();
            txt_Name.Text = GridViewUser.Rows[dong].Cells[2].Value.ToString();
            txt_Addres.Text = GridViewUser.Rows[dong].Cells[3].Value.ToString();
            txt_Sodt.Text = GridViewUser.Rows[dong].Cells[4].Value.ToString();
            txt_Ngaysinh.Text = GridViewUser.Rows[dong].Cells[5].Value.ToString();
            txt_Email.Text = GridViewUser.Rows[dong].Cells[6].Value.ToString();
            cbb_quyenus.SelectedValue = int.Parse( GridViewUser.Rows[dong].Cells[7].Value.ToString());
        }

        private void but_dele_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này !!!", "Sure?", MessageBoxButtons.YesNo)
          == DialogResult.Yes)
                {
                    string id = txt_ID.Text.ToString();
                    sus.XoaUser(id);

                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridViewUser.DataSource = null;
                    GridViewUser.DataSource = sus.findAll();

                }
                else
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {

                string username = txt_ID.Text.ToString();
                string password = txt_Pass.Text.ToString();
                string hotennd = txt_Name.Text.ToString();
                string email = txt_Email.Text.ToString();
                string diachi = txt_Addres.Text.ToString();
                string SoDienThoai = txt_Sodt.Text.ToString();
                string NgaySinh = txt_Ngaysinh.Text.ToString();
                int quyen = int.Parse(cbb_quyenus.Text.ToString());
                sus.EditUser(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
                MessageBox.Show("Đã Sửa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewUser.DataSource = null;
                GridViewUser.DataSource = sus.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void but_Tim_Click(object sender, EventArgs e)
        {
            if (cbb_loaitimkiem.SelectedIndex.ToString() == "0")
            {
                if (txt_Tim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã người dùng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string a = txt_Tim.Text;
                    GridViewUser.AutoGenerateColumns = false;
                    GridViewUser.DataSource = null;
                    var sp = sus.GetById(a);
                    //GridView_SP.DataSource = null;
                    GridViewUser.DataSource = sp;

                }
            }
            else if (cbb_loaitimkiem.SelectedIndex.ToString() == "1")
            {
                if (txt_Tim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên người dùng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String a = txt_Tim.Text;
                    GridViewUser.AutoGenerateColumns = false;
                    GridViewUser.DataSource = null;
                    var sp = sus.GetByName(a);
                    //GridView_SP.DataSource = null;
                    GridViewUser.DataSource = sp;
                }
            }
            else if (cbb_loaitimkiem.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // tab quan ly san pham



        private void but_addsp_Click(object sender, EventArgs e)
        {
            try
            {
                string tensp = txt_tenspsp.Text.ToString();
                string mota = txt_motasp.Text.ToString();
                int gia = int.Parse(txt_giasp.Text.ToString());
                int soluong = int.Parse(txt_soluongsp.Text.ToString());
                string hinhanh = Path.GetFileName(txt_hinhanhsp.Text);
                string ghichu = txt_ghichusp.Text.ToString();
                string madm = cbb_danhmucsp.SelectedValue.ToString();

                ssp.insert(tensp, mota, gia, soluong, hinhanh, ghichu, madm);

                MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewSP.DataSource = null;
                GridViewSP.DataSource = ssp.findAll();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void but_timhinhsp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "file hinh|*.jpg|all file|*.*";
            dlg.InitialDirectory = @"E:\";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = dlg.FileNames;
                foreach (string i in tmp)
                {
                    FileInfo fi = new FileInfo(i);
                    string[] xxx = i.Split('\\');
                    string des = @"../../../MVCMobile/Content/image/" + xxx[xxx.Length - 1];
                    File.Delete(des);

                    //over.
                    fi.CopyTo(des);
                    txt_hinhanhsp.Text = "";
                    txt_hinhanhsp.Text = des;
                    MessageBox.Show("Chọn hình ảnh thành công");
                    pictureBox1.Image = Image.FromFile(des);
                    _hinh = Path.GetFileName(des);
                }
            }
        }

        private void but_suasp_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txt_maspsp.Text.ToString());
            string tensp = txt_tenspsp.Text.ToString();
            string mota = txt_motasp.Text.ToString();
            int gia = int.Parse(txt_giasp.Text.ToString());
            int soluong = int.Parse(txt_soluongsp.Text.ToString());
            string hinhanh = Path.GetFileName(txt_hinhanhsp.Text);
            string ghichu = txt_ghichusp.Text.ToString();
            string madm = cbb_danhmucsp.Text.ToString();
            ssp.Update(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
            GridViewSP.DataSource = null;
            GridViewSP.DataSource = ssp.findAll();
        }

        private void but_xoasp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục này !!!", "Sure?", MessageBoxButtons.YesNo)
          == DialogResult.Yes)
            {
                int id = int.Parse(txt_maspsp.Text.ToString());
                ssp.delete(id);
                GridViewSP.DataSource = null;
                GridViewSP.DataSource = ssp.findAll();

            }
            else
            { }
        }

        private void GridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            //txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_maspsp.Text = GridViewSP.Rows[dong].Cells[0].Value.ToString();
            txt_tenspsp.Text = GridViewSP.Rows[dong].Cells[1].Value.ToString();
            txt_motasp.Text = GridViewSP.Rows[dong].Cells[2].Value.ToString();
            txt_giasp.Text = GridViewSP.Rows[dong].Cells[3].Value.ToString();
            txt_soluongsp.Text = GridViewSP.Rows[dong].Cells[4].Value.ToString();
            txt_hinhanhsp.Text = GridViewSP.Rows[dong].Cells[5].Value.ToString();
            txt_ghichusp.Text = GridViewSP.Rows[dong].Cells[6].Value.ToString();
            cbb_danhmucsp.Text = GridViewSP.Rows[dong].Cells[7].Value.ToString();
        }

        private void but_timsp_Click(object sender, EventArgs e)
        {
            if (cbb_loaitimsp.SelectedIndex.ToString() == "0")
            {
                if (txt_timsp.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã danh mục", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string a = txt_timsp.Text;
                    GridViewSP.AutoGenerateColumns = false;
                    GridViewSP.DataSource = null;
                    var sp = ssp.GetByDanhMucsp(a);
                    GridViewSP.DataSource = sp;

                }
            }
            else if (cbb_loaitimsp.SelectedIndex.ToString() == "1")
            {
                if (txt_timsp.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String a = txt_timsp.Text;
                    GridViewUser.AutoGenerateColumns = false;
                    GridViewUser.DataSource = null;
                    var sp = ssp.GetByNamesp(a);
                    GridViewSP.DataSource = sp;
                }
            }
            else if (cbb_loaitimsp.SelectedIndex.ToString() == "1")
            {
                if (txt_timsp.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int a = int.Parse(txt_timsp.Text);
                    GridViewUser.AutoGenerateColumns = false;
                    GridViewUser.DataSource = null;
                    var sp = ssp.GetByIdsp(a);
                    GridViewSP.DataSource = sp;
                }
            }
            else if (cbb_loaitimkiem.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            //txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_madmdm.Text = GridViewDM.Rows[dong].Cells[0].Value.ToString();
            txt_tendmdm.Text = GridViewDM.Rows[dong].Cells[1].Value.ToString();

        }

        private void but_Themdm_Click(object sender, EventArgs e)
        {
            string madm = txt_madmdm.Text.ToString();
            string tendm = txt_tendmdm.Text.ToString();

            sdm.insert(madm, tendm);
            //MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridViewDM.DataSource = null;
            GridViewDM.DataSource = sdm.findAll();

        }

        private void but_Suadm_Click(object sender, EventArgs e)
        {
            string madm = txt_madmdm.Text.ToString();
            string tendm = txt_tendmdm.Text.ToString();

            sdm.update(madm, tendm);
            //MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridViewDM.DataSource = null;
            GridViewDM.DataSource = sdm.findAll();
        }

        private void but_Xoadm_Click(object sender, EventArgs e)
        {
            string madm = txt_madmdm.Text.ToString();

            sdm.delete(madm);
            //MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridViewDM.DataSource = null;
            GridViewDM.DataSource = sdm.findAll();
        }

        private void but_timdm_Click(object sender, EventArgs e)
        {
            if (cbb_loaitimdm.SelectedIndex.ToString() == "0")
            {
                if (txt_timdm.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã danh mục", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string a = txt_timdm.Text;
                    GridViewDM.AutoGenerateColumns = false;
                    GridViewDM.DataSource = null;
                    var sp = sdm.GetById(a);
                    //GridView_SP.DataSource = null;
                    GridViewDM.DataSource = sp;

                }
            }
            else if (cbb_loaitimdm.SelectedIndex.ToString() == "1")
            {
                if (txt_timdm.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String a = txt_timdm.Text;
                    GridViewDM.AutoGenerateColumns = false;
                    GridViewDM.DataSource = null;
                    var sp = sdm.GetByName(a);
                    //GridView_SP.DataSource = null;
                    GridViewDM.DataSource = sp;
                }
            }
            else if (cbb_loaitimkiem.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void GridViewDH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            //txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_mdhdh.Text = GridViewDH.Rows[dong].Cells[0].Value.ToString();
            txt_idusdh.Text = GridViewDH.Rows[dong].Cells[1].Value.ToString();
            txt_ngaylapdh.Text = GridViewDH.Rows[dong].Cells[2].Value.ToString();
            txt_tongtien.Text = GridViewDH.Rows[dong].Cells[3].Value.ToString();

            cbb_trangthaidh.SelectedIndex = Int32.Parse(GridViewDH.Rows[dong].Cells[4].Value.ToString());
            //MessageBox.Show(GridViewDH.Rows[dong].Cells[4].Value.ToString());
            //cbb_trangthaidh.SelectedIndex = 1;
            if (cbb_trangthaidh.SelectedIndex == 1)
            {
               but_capnhatdh.Visible = true;
                
            }
            else
            {
                but_capnhatdh.Visible = false;
                
            }
        }

        private void but_capnhatdh_Click(object sender, EventArgs e)
        {
            if ((cbb_trangthaidh.SelectedIndex.ToString()) == "1")
            {
                MessageBox.Show("Không thể cập nhật trạng thái như trạng thái ban đầu", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                if ((cbb_trangthaidh.SelectedIndex.ToString()) == "2")
                {
                    
                    int madh = int.Parse(txt_mdhdh.Text.ToString());
                   
                    sdh.Update( madh);
                    //MessageBox.Show("Đã Thêm Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridViewDH.DataSource = null;
                    GridViewDH.DataSource = sdh.GetAll();

                }
            }

        private void but_Timhd_Click(object sender, EventArgs e)
        {
            if (cbb_timdh.SelectedIndex.ToString() == "0")
            {
                if (txt_Timdh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã đơn hàng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int a = int.Parse(txt_Timdh.Text);
                    GridViewDH.AutoGenerateColumns = false;
                    GridViewDH.DataSource = null;
                    var sp = sdh.GetByID(a);
                    //GridView_SP.DataSource = null;
                    GridViewDH.DataSource = sp;

                }
            }
            else if (cbb_loaitimdm.SelectedIndex.ToString() == "1")
            {
                if (txt_Timdh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ID user", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String a = txt_Timdh.Text;
                    GridViewDH.AutoGenerateColumns = false;
                    GridViewDH.DataSource = null;
                    var sp = sdh.GetByName(a);
                    //GridView_SP.DataSource = null;
                    GridViewDH.DataSource = sp;
                }
            }
            else if (cbb_loaitimkiem.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

        }
        }

        //private void GridViewDH_SelectionChanged(object sender, EventArgs e)
        //{
        //    int dong 
        //    //txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
        //    txt_mdhdh.Text = GridViewDH.Rows[dong].Cells[0].Value.ToString();
        //    txt_tenusdh.Text = GridViewDH.Rows[dong].Cells[1].Value.ToString();
        //    txt_ngaylapdh.Text = GridViewDH.Rows[dong].Cells[2].Value.ToString();
        //    txt_tongtien.Text = GridViewDH.Rows[dong].Cells[3].Value.ToString();

        //    cbb_trangthaidh.SelectedIndex = Int32.Parse(GridViewSP.Rows[dong].Cells[4].Value.ToString());
        //    //MessageBox.Show(GridViewDH.Rows[dong].Cells[4].Value.ToString());
        //    cbb_trangthaidh.SelectedIndex = 1;
        //}


        }


    
 