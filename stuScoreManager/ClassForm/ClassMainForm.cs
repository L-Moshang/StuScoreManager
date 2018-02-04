using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stuScoreManager.BLL;
using stuScoreManager.Model;

namespace stuScoreManager.ClassForm
{
    public partial class ClassMainForm : Form
    {
        public ClassMainForm()
        {
            InitializeComponent();
        }

        private void ClassMainForm_Load(object sender, EventArgs e)
        {
            ClassBLL cBLL = new ClassBLL();
            DataSet ds = cBLL.getClasses();
            dgvClassInfo.DataSource = ds.Tables[0];
            dgvClassInfo.Columns[0].HeaderText = "班级编号";
            dgvClassInfo.Columns[1].HeaderText = "班级名称";
            dgvClassInfo.Columns[2].HeaderText = "所属系部";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            ClassAddForm caf = new ClassAddForm();
            //当添加子窗体关闭时重新加载主窗体的DataGridView控件
           
            if (caf.ShowDialog() == DialogResult.OK)
            {
                ClassBLL cBLL = new ClassBLL();
                DataSet ds = cBLL.getClasses();
                dgvClassInfo.DataSource = ds.Tables[0];
            }
        }

        ClassInfo cInfo = new ClassInfo();//为班级信息定义全局变量

        private void dgvClassInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cInfo.Cno = dgvClassInfo.Rows[index].Cells[0].Value.ToString();
            cInfo.Cname = dgvClassInfo.Rows[index].Cells[1].Value.ToString();
            cInfo.Cdept = dgvClassInfo.Rows[index].Cells[2].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cInfo.Cno != null)
            {
                ClassChangeForm ccf = new ClassChangeForm(cInfo);
                if (ccf.ShowDialog() == DialogResult.OK)
                {
                    ClassBLL cBLL = new ClassBLL();
                    DataSet ds = cBLL.getClasses();
                    dgvClassInfo.DataSource = ds.Tables[0];
                }
            }
            else
                MessageBox.Show("请选择班级！");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClassBLL cBLL = new ClassBLL();
                try
                {
                    if (cBLL.removeClass(cInfo.Cno))
                    {
                        MessageBox.Show("删除成功");
                        DataSet ds = cBLL.getClasses();
                        dgvClassInfo.DataSource = ds.Tables[0];
                    }
                    else
                        MessageBox.Show("删除失败");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
