using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thanh.ThuVien;

namespace Thanh.HeThong
{
    public partial class FrmQuanLyFileKey : Form
    {
        private XuLyDuLieu objXldl;
        private DataTable dtKey;
        private int cheDo;
        private String id;
        public FrmQuanLyFileKey()
        {
            InitializeComponent();
            objXldl = new XuLyDuLieu();
            //cboQuyen.SelectedIndex = 0;
            cheDo = 0;
        }

        public void ThietLapTTCacControl()
        {
            if (cheDo == 0)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtUnit.ReadOnly = true;
                txtKey.ReadOnly = true;
                txtMaterial.ReadOnly = true;
                txtClassify.ReadOnly = true;
                txtClassifyType.ReadOnly = true;
                if (dgvKey.Rows.Count < 1)
                {
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                txtUnit.ReadOnly = false;
                txtKey.ReadOnly = false;
                txtMaterial.ReadOnly = false;
                txtClassify.ReadOnly = false;
                txtClassifyType.ReadOnly = false;
            }
        }

        public void HienThiFileKey()
        {
            objXldl.MoKetNoi();
            dtKey = objXldl.LayDt("Select * From tb_key");
            objXldl.DongKetNoi();
            dgvKey.DataSource = dtKey;
            dgvKey.Columns[0].HeaderText = "ID";
            dgvKey.Columns[0].Width = 50;
            dgvKey.Columns[1].HeaderText = "Tên file";
            dgvKey.Columns[2].HeaderText = "Unit";
            dgvKey.Columns[3].HeaderText = "Key";
            dgvKey.Columns[4].HeaderText = "Material";
            dgvKey.Columns[4].Width = 120;
            dgvKey.Columns[5].HeaderText = "Classify Type";
            dgvKey.Columns[5].Width = 120;
            dgvKey.Columns[6].HeaderText = "Classify";
            dgvKey.Columns[6].Width = 120;

            txtUnit.DataBindings.Clear();
            txtKey.DataBindings.Clear();
            txtMaterial.DataBindings.Clear();
            txtClassify.DataBindings.Clear();
            txtClassifyType.DataBindings.Clear();

            txtUnit.DataBindings.Add("text", dtKey, "unit", false, DataSourceUpdateMode.Never);
            txtKey.DataBindings.Add("text", dtKey, "key", false, DataSourceUpdateMode.Never);
            txtMaterial.DataBindings.Add("text", dtKey, "material", false, DataSourceUpdateMode.Never);
            txtClassify.DataBindings.Add("text", dtKey, "classify", false, DataSourceUpdateMode.Never);
            txtClassifyType.DataBindings.Add("text", dtKey, "classifytype", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cheDo = 1;
            ThietLapTTCacControl();
            txtUnit.Text = "";
            txtKey.Text = "";
            txtMaterial.Text = "";
            txtClassify.Text = "";
            txtClassifyType.Text = "";
            // cboQuyen.SelectedIndex = 0;
            // KiemTraToanBo();
            txtUnit.Focus();
        }

        private void FrmQuanLyFileKey_Load(object sender, EventArgs e)
        {
            HienThiFileKey();
            ThietLapTTCacControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                String strSql, tb;
                if (cheDo == 1)
                {
                    strSql = "Insert Into tb_key (unit, [key], material, classify, classifytype) Values('" + txtUnit.Text.Trim() + "', '" + txtKey.Text.Trim() + "', N'" +
                        txtMaterial.Text.Trim() + "', '" + txtClassifyType.Text.Trim() + "', '" + txtClassify.Text.Trim() + "')";
                    tb = "Thêm thành công";
                }
                else
                {
                    strSql = "Update tb_key Set unit = N'" + txtUnit.Text.Trim() + "', [key] = N'" + txtKey.Text.Trim() +
                        "', material = N'" + txtMaterial.Text.Trim() + "', classifytype = N'" + txtClassifyType.Text.Trim() + "', classify = N'" + txtClassify.Text.Trim() +  "' Where id = " + id;
                    tb = "Sửa thành công";
                }
                if (objXldl.ThucHienCauLenh(strSql))
                {
                    MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cheDo = 0;
                    FrmQuanLyFileKey_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + objXldl.loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa key này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (objXldl.ThucHienCauLenh("Delete From tb_key Where id = " + id))
                    {
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQuanLyFileKey_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + objXldl.loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cheDo = 2;
            ThietLapTTCacControl();
            txtUnit.Focus();
        }

        private void dgvKey_SelectionChanged(object sender, EventArgs e)
        {
            cheDo = 0;
            ThietLapTTCacControl();
            try
            {
                if (dgvKey.CurrentRow != null)
                {
                    int dong = dgvKey.CurrentRow.Index;
                    id = dgvKey.Rows[dong].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtKey.DefaultView.RowFilter = "key Like '%" + txtTimKiem.Text + "%'";
        }
    }
}
