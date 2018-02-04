using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using stuScoreManager.Model;
using stuScoreManager.BLL;

namespace stuScoreManager.CourseForm
{
    public partial class CourseMainForm : Form
    {
        public CourseMainForm()
        {
            InitializeComponent();
        }

        private void CourseMainForm_Load(object sender, EventArgs e)
        {
            dgvLoadData();
            txtCname.Enabled = false;
            txtCno.Enabled = false;
            txtTeacher.Enabled = false;
            btnChange.Enabled = false;
        }

        private void dgvLoadData()
        {
            CourseBLL cBLL = new CourseBLL();
            DataSet ds = cBLL.getCourse();
            dgvCourseInfo.DataSource = ds.Tables[0];
            dgvCourseInfo.Columns[0].HeaderText = "课程编号";
            dgvCourseInfo.Columns[1].HeaderText = "课程名称";
            dgvCourseInfo.Columns[2].HeaderText = "任课教师";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "添加")
            {
                txtCno.Text = "";
                txtCname.Text = "";
                txtTeacher.Text = "";
                btnAdd.Enabled = true;
                txtCno.Enabled = true;
                txtCname.Enabled = true;
                txtTeacher.Enabled = true;
                btnAdd.Text = "确定";
                dgvCourseInfo.Enabled = false;
            }
            else
            {
                btnAdd.Text = "添加";
                CourseInfo cInfo = new CourseInfo();
                cInfo.Cno = txtCno.Text.Trim();
                cInfo.Cname = txtCname.Text.Trim();
                cInfo.Cteacher = txtTeacher.Text.Trim();
                CourseBLL cBLL = new CourseBLL();
                try
                {
                    if (cBLL.Add(cInfo))
                    {
                        MessageBox.Show("添加成功！", "提示");
                        txtCno.Enabled = false;
                        txtCname.Enabled = false;
                        txtTeacher.Enabled = false;
                        dgvCourseInfo.Enabled = true;
                        dgvLoadData();
                    }
                    else
                        MessageBox.Show("添加失败！", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //修改按钮事件
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "修改")
            {
                btnRemove.Enabled = false;
                btnChange.Text = "确定";
                txtCno.Enabled = true;
                txtCname.Enabled = true;
                txtTeacher.Enabled = true;
                dgvCourseInfo.Enabled = false;
            }
            else
            {
                btnChange.Text = "修改";
                CourseInfo cInfo = new CourseInfo();
                cInfo.Cno = txtCno.Text.Trim();
                cInfo.Cname = txtCname.Text.Trim();
                cInfo.Cteacher = txtTeacher.Text.Trim();
                CourseBLL cBLL = new CourseBLL();
                try
                {
                    if (cBLL.changeCourse(cInfo, oldCno))
                    {
                        MessageBox.Show("修改成功！", "提示");
                        dgvLoadData();
                        dgvCourseInfo.Enabled = true;
                        btnAdd.Enabled = true;
                        btnChange.Enabled = false;
                        txtCno.Enabled = false;
                        txtCname.Enabled = false;
                        txtTeacher.Enabled = false;
                    }
                    else
                        MessageBox.Show("修改失败！", "提示");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        string oldCno;//为修改前的课程编号，定义为全局变量

        private void dgvCourseInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCourseInfo.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = true;
                btnRemove.Enabled = true;
                txtCno.Text = dgvCourseInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCname.Text = dgvCourseInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTeacher.Text = dgvCourseInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                oldCno = txtCno.Text.Trim();
            }
            else
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = false;
                btnRemove.Enabled = false;
                txtCno.Text = "";
                txtCname.Text = "";
                txtTeacher.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            if (MessageBox.Show("确定删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CourseBLL cBLL = new CourseBLL();
                if (cBLL.removeCourse(txtCno.Text.Trim()))
                {
                    MessageBox.Show("删除成功！", "警告");
                    dgvLoadData();
                    dgvCourseInfo.Enabled = true;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = false;
                }
                else
                    MessageBox.Show("删除失败！", "提示");
            }
        }

        private void btnSetClass_Click(object sender, EventArgs e)
        {
            SetClassForm scf = new SetClassForm();
            scf.Show();
        }
    }
}
