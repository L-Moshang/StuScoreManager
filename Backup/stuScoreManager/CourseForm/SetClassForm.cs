using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stuScoreManager.DAL;
using stuScoreManager.BLL;
using stuScoreManager.Model;

namespace stuScoreManager.CourseForm
{
    public partial class SetClassForm : Form
    {
        public SetClassForm()
        {
            InitializeComponent();
        }

        private void SetClassForm_Load(object sender, EventArgs e)
        {
            CourseBLL cBLL = new CourseBLL();
            DataTable dt = cBLL.getCourse().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
                comCourse.Items.Add(dt.Rows[i]["Cname"].ToString());
            ClassBLL classBLL = new ClassBLL();
            DataTable classDt = classBLL.getClasses().Tables[0];
            for (int i = 0; i < classDt.Rows.Count; i++)
                comClass.Items.Add(classDt.Rows[i]["Cname"].ToString());
        }

         string courseNo;
         string classNo;

        private void comCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataSource 和 comClass.Items.Add(str) 是相互排斥的
            //设置 DataSource 属性后无法修改项集合
            listClass.DataSource = null;
            listClass.Items.Clear(); 
            int index = comCourse.SelectedIndex;
            CourseBLL cBLL = new CourseBLL();
            DataTable dt = cBLL.getCourse().Tables[0];
            courseNo = dt.Rows[index]["Cno"].ToString();
            Class_CourseBLL bll = new Class_CourseBLL();
            DataTable cDt = bll.selectClasses(courseNo).Tables[0];
            listClass.DataSource = cDt;
            listClass.DisplayMember = "Cname";
            listClass.ValueMember = "classNo";
        }

        //添加按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comClass.Text.Trim() == "")
            {
                MessageBox.Show("班级不能为空！");
                return;
            }
            else if (comCourse.Text.Trim() == "")
            {
                MessageBox.Show("课程不能为空！");
                return;
            }
            Class_CourseBLL BLL = new Class_CourseBLL();
            DataTable cDt = BLL.selectClasses(courseNo).Tables[0];
            int i = 0;
            for (; i < cDt.Rows.Count; i++)
            {
                if (cDt.Rows[i]["Cname"].ToString() == comClass.Text.Trim())
                    break;
            }
            if (i >= cDt.Rows.Count)
            {
                Class_CourseInfo info = new Class_CourseInfo();
                info.ClassNo = classNo;
                info.CourseNo = courseNo;

                if (BLL.Add(info))
                {
                    MessageBox.Show("添加成功");
                    //重新绑定
                    cDt = BLL.selectClasses(courseNo).Tables[0];
                    listClass.DataSource = cDt;
                    listClass.DisplayMember = "Cname";
                    listClass.ValueMember = "classNo";
                }
            }
            else
            {
                MessageBox.Show("已经添加了该班级！");
            }
        }

        #region MyRegion
        //public class ComboBoxItem
        //{
        //    private string m_Text;
        //    private string m_Value;
        //    public ComboBoxItem()
        //    {
        //        this.m_Text = String.Empty;
        //        this.m_Value = String.Empty;
        //    }
        //    public string Text
        //    {
        //        get { return this.m_Text; }
        //        set { this.m_Text = value; }
        //    }
        //    public string Value
        //    {
        //        get { return this.m_Value; }
        //        set { this.m_Value = value; }
        //    }
        //    public override string ToString()
        //    {
        //        return this.m_Text;  //最关键的
        //    }
        //}

        //public class ComboxItem
        //{
        //    public string Text = "";
        //    public string Value = "";
        //    public ComboxItem(string _Text, string _Value)
        //    {
        //        Text = _Text;
        //        Value = _Value;
        //    }

        //    public override string ToString()
        //    {
        //        return this.Text;
        //    }
        //} 
        #endregion

        //删除按钮事件
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listClass.SelectedItem != null)
            {
                //选中listBox列表框中的某个班级，单击删除按钮删除该班级
                if (MessageBox.Show("确实要删除该班级吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Class_CourseBLL BLL = new Class_CourseBLL();
                    if (BLL.Remove(classNo, courseNo))
                    {
                        MessageBox.Show("删除成功！");
                        DataTable cDat = BLL.selectClasses(courseNo).Tables[0];
                        listClass.DataSource = cDat;
                        listClass.DisplayMember = "Cname";
                        listClass.ValueMember = "classNo";
                    }
                    else
                        MessageBox.Show("删除失败！");
                }
            }
            else
                MessageBox.Show("请选择班级！");
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listClass.DataSource!=null)
            classNo = listClass.SelectedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassBLL cBLL = new ClassBLL();
            DataTable dt = cBLL.getclassno(comClass.SelectedItem.ToString()).Tables[0];
            classNo = dt.Rows[0]["Cno"].ToString();
        }

    }
}
