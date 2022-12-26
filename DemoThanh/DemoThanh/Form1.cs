using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DemoThanh.Common;
using DemoThanh.Data;

namespace DemoThanh
{
    public partial class Form1 : Form
    {
        public static string fileName;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void load_cb(string[] a)
        {
           
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            fileName = common.getFile();
            if(fileName != "")
            {
                lbFileName.Text = fileName;
                string[] sheetList = XuLyDuLieu.GetExcelSheetNames(fileName);
                cbSheet.Items.AddRange(sheetList);
                gtbDemo.Enabled = true;
                cbTuDien.Items.AddRange(sheetList);
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy thông tin file");
            }
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvData.DataSource = XuLyDuLieu.getData(cbSheet.Text+"$", fileName);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.ToLower();
            //MessageBox.Show(searchValue);
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    row.Selected = false;
                    string tam = row.Cells[2].Value.ToString().ToLower();
                    string[] temp = tam.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries);

                    //MessageBox.Show(temp.Length.ToString());
                    //break;
                    if (temp.All(searchValue.Contains))
                    {
                        row.Selected = true;
                        dgvData.FirstDisplayedScrollingRowIndex = dgvData.SelectedRows[0].Index;
                        break;
                    }

                    /* if (row.Cells[2].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        dgvData.FirstDisplayedScrollingRowIndex = dgvData.SelectedRows[0].Index;
                        break;
                    } */
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
