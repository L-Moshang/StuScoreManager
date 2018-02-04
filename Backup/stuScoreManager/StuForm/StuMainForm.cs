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

namespace stuScoreManager.StuForm
{
    public partial class StuMainForm : Form
    {
        public StuMainForm()
        {
            InitializeComponent();
        }

        private void StuMainForm_Load(object sender, EventArgs e)
        {
            ClassBLL cb = new ClassBLL();
            DataSet ds = cb.getClasses();
            if (ds.Tables[0].Rows.Count > 0)
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comClassName.Items.Add(ds.Tables[0].Rows[i]["Cname"]).ToString();
            comClassName.Text = comClassName.Items[0].ToString();
        }

        string cno = "";

        /// <summary>
        /// 装载dgvStuInfo控件，根据班级编号查找学生信息
        /// </summary>
        private void LoadDgvData()
        {
            StuInfo sInfo = new StuInfo();
            int index = comClassName.SelectedIndex;
            ClassBLL cb = new ClassBLL();
            DataSet ds = cb.getClasses();
            cno = ds.Tables[0].Rows[index]["Cno"].ToString();
            StuBLL sb = new StuBLL();
            DataSet stuDs = sb.getStudentsByCno(cno);
            if (stuDs.Tables[0].Rows.Count > 0)
            {
                dgvStuInfo.DataSource = stuDs.Tables[0];
                dgvStuInfo.Columns[0].HeaderText = "学号";
                dgvStuInfo.Columns[1].HeaderText = "姓名";
                dgvStuInfo.Columns[2].HeaderText = "班级";
            }
            else
                dgvStuInfo.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StuAddForm saf = new StuAddForm(cno);
            if (saf.ShowDialog() == DialogResult.OK)
                LoadDgvData();
        }

        private void comClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgvData();
        }

        StuInfo sInfo = new StuInfo();//为学生信息定义全局变量

        private void dgvStuInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            sInfo.Cno = cno;
            sInfo.Sno = dgvStuInfo.Rows[index].Cells[0].Value.ToString();
            sInfo.Sname = dgvStuInfo.Rows[index].Cells[1].Value.ToString();
            sInfo.Ssex = dgvStuInfo.Rows[index].Cells[2].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (sInfo.Sno != null)
            {
                StuChangeForm scf = new StuChangeForm(sInfo);
                if (scf.ShowDialog() == DialogResult.OK)
                    LoadDgvData();
            }
            else
                MessageBox.Show("请选择一条学生记录！");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (sInfo.Sno != null)
            {
                if (MessageBox.Show("确定删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StuBLL sBLL = new StuBLL();
                    if (sBLL.removeStu(cno, sInfo.Sno))
                    {
                        MessageBox.Show("删除成功！");
                        DataSet ds = sBLL.getStudentsByCno(cno);
                        dgvStuInfo.DataSource = ds.Tables[0];
                    }
                    else
                        MessageBox.Show("删除失败！");
                }
            }
            else
                MessageBox.Show("请选择一条学生记录！");
        }
    }
}
