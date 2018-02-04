using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stuScoreManager.UserForm;
using Microsoft.Win32;
using stuScoreManager.ClassForm;
using stuScoreManager.StuForm;
using stuScoreManager.CourseForm;
using stuScoreManager.ScoreForm;

namespace stuScoreManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region 定位代码
            //RegistryKey reg1 = Registry.CurrentUser;
            //RegistryKey reg2 = reg1.CreateSubKey("SoftWare\\MySoft");
            //reg2.SetValue("1", this.Location.X);
            //reg2.SetValue("2", this.Location.Y); 
            #endregion
            Application.Exit();
        }


        private void 添加用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                AddUserForm auf = new AddUserForm();
                auf.MdiParent = this;
                auf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                AddUserForm auf = new AddUserForm();
                auf.MdiParent = this;
                auf.Show();
            }
        }

        private void 修改用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                ChangeUserForm cuf = new ChangeUserForm();
                cuf.MdiParent = this;
                cuf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                ChangeUserForm cuf = new ChangeUserForm();
                cuf.MdiParent = this;
                cuf.Show();
            }
        }

        private void 删除用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                RemoveUserForm ruf = new RemoveUserForm();
                ruf.MdiParent = this;
                ruf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                RemoveUserForm ruf = new RemoveUserForm();
                ruf.MdiParent = this;
                ruf.Show();
            }
        }

        private void 查询用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FindUserForm fuf = new FindUserForm();
                fuf.MdiParent = this;
                fuf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                FindUserForm fuf = new FindUserForm();
                fuf.MdiParent = this;
                fuf.Show();
            }
        }

        private void 班级信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild==null)
            {
                ClassMainForm cmf = new ClassMainForm();
                cmf.MdiParent = this;
                cmf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                ClassMainForm cmf = new ClassMainForm();
                cmf.MdiParent = this;
                cmf.Show();
            }
        }

        private void 学生信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                StuMainForm smf = new StuMainForm();
                smf.MdiParent = this; 
                smf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                StuMainForm smf = new StuMainForm();
                smf.MdiParent = this; 
                smf.Show();
            }
        }

        private void 课程信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                CourseMainForm cmf = new CourseMainForm();
                cmf.MdiParent = this;
                cmf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                CourseMainForm cmf = new CourseMainForm();
                cmf.MdiParent = this;
                cmf.Show();
            }
        }

        private void 成绩信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                ScoreMainForm smf = new ScoreMainForm();
                smf.MdiParent = this;
                smf.Show();
            }
            else
            {
                foreach (Form frm in this.MdiChildren) //遍历关闭所有子窗体
                    frm.Close();
                ScoreMainForm smf = new ScoreMainForm();
                smf.MdiParent = this;
                smf.Show();
            }
        }









        #region 定位代码
        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    //RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare\\MySoft");
        //    //int x = Convert.ToInt32(reg.GetValue("1"));
        //    //int y = Convert.ToInt32(reg.GetValue("2"));
        //    //this.Location = new Point(x, y);//可以转换成 Left 、Top 见 2.
        //} 
        #endregion

    }
}
