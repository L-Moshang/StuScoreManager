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

namespace stuScoreManager.ScoreForm
{
    public partial class ScoreMainForm : Form
    {
        public ScoreMainForm()
        {
            InitializeComponent();
        }

        private void ScoreMainForm_Load(object sender, EventArgs e)
        {
            CourseBLL cBLL = new CourseBLL();
            DataTable dt = cBLL.getCourse().Tables[0];
            if (dt.Rows.Count > 0)
            {
                //装载TreeView控件
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = dt.Rows[i]["Cname"].ToString();
                    node.Name = dt.Rows[i]["Cno"].ToString();
                    treeClassCourse.Nodes.Add(node);
                    //根据课程编号查找上该课程的班级
                    Class_CourseBLL BLL = new Class_CourseBLL();
                    DataTable dtCourse = BLL.selectClasses(dt.Rows[i]["Cno"].ToString()).Tables[0];
                    if (dtCourse.Rows.Count > 0)
                    {
                        for (int j = 0; j < dtCourse.Rows.Count; j++)
                        {
                            TreeNode ziNode = new TreeNode();
                            ziNode.Text = dtCourse.Rows[j]["Cname"].ToString();
                            ziNode.Name = dtCourse.Rows[j]["classNo"].ToString();
                            treeClassCourse.Nodes[i].Nodes.Add(ziNode);
                        }
                    }
                }
            }
        }

        public string classNo;         //自定义非书本
        public string courseNo;

        private void treeClassCourse_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //判断单击的是否为班级节点
            if (e.Node.Parent != null)
            {
                string className = e.Node.Text;
                classNo = e.Node.Name;
                string courseName = e.Node.Parent.Text;
                courseNo = e.Node.Parent.Name;
                loadDgvData();
            }
        }

        //刷新datagridview数据
        private void loadDgvData()
        {
            ScoreBLL sBLL = new ScoreBLL();
            DataTable dt = sBLL.getScore(classNo, courseNo).Tables[0];
            if (dt.Rows.Count > 0)
            {
                dgvScoreInfo.DataSource = dt;
                dgvScoreInfo.Columns[0].HeaderText = "学号";
                dgvScoreInfo.Columns[1].HeaderText = "姓名";
                dgvScoreInfo.Columns[2].HeaderText = "成绩";

                dgvScoreInfo.Columns[0].ReadOnly = true;
                dgvScoreInfo.Columns[1].ReadOnly = true;
            }
            else
            {
                StuBLL stuBLL = new StuBLL();
                dt = stuBLL.getStudentsByCno(classNo).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dt.Columns.Remove("Ssex");
                    dt.Columns.Add("Grade");
                    dgvScoreInfo.DataSource = dt;
                    dgvScoreInfo.Columns[0].HeaderText = "学号";
                    dgvScoreInfo.Columns[1].HeaderText = "姓名";
                    dgvScoreInfo.Columns[2].HeaderText = "成绩";
                    dgvScoreInfo.Columns[0].ReadOnly = true;
                    dgvScoreInfo.Columns[1].ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("该班级没有学生！");
                    dgvScoreInfo.DataSource = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvScoreInfo.DataSource;
            dt.Columns.Remove("Sname");
            dt.Columns.Add("classNo");
            dt.Columns.Add("courseNo");
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["classNo"] = classNo;
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["courseNo"] = courseNo;
            ScoreBLL sBLL = new ScoreBLL();
            DataTable sDt = sBLL.getScore(classNo, courseNo).Tables[0];
            if (sDt.Rows.Count > 0)
            {
                dgvScoreInfo.DataSource = null;
                ScoreInfo sInfo = new ScoreInfo();
                //修改成绩
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sInfo.Sno = dt.Rows[i]["Sno"].ToString();
                    sInfo.CoureNo = dt.Rows[i]["Courseno"].ToString();
                    sInfo.ClassNo = dt.Rows[i]["ClassNo"].ToString();
                    sInfo.Grade = dt.Rows[i]["Grade"].ToString();
                    sBLL.changeGrade(sInfo);
                }
                loadDgvData();
                MessageBox.Show("保存成功！");
            }
            else
            {
                ScoreInfo sInfo = new ScoreInfo();
                //添加成绩
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sInfo.Sno = dt.Rows[i]["Sno"].ToString();
                    sInfo.CoureNo = dt.Rows[i]["Courseno"].ToString();
                    sInfo.ClassNo = dt.Rows[i]["ClassNo"].ToString();
                    sInfo.Grade = dt.Rows[i]["Grade"].ToString();
                    sBLL.Add(sInfo);
                }
                loadDgvData();
                MessageBox.Show("保存成功！");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ScoreBLL sBLL = new ScoreBLL();
            DataTable dt = sBLL.getScore(classNo, courseNo).Tables[0];
            if (dt.Rows.Count > 0)
            {
                rtScoreForm rtf = new rtScoreForm(dt);
                rtf.Show();
            }
            else
                MessageBox.Show("请先保存！");
        }
    }
}
