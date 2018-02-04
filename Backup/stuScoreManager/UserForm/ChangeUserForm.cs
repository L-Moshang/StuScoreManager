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

namespace stuScoreManager.UserForm
{
    public partial class ChangeUserForm : Form
    {
        public ChangeUserForm()
        {
            InitializeComponent();
        }

        //显示用户信息按钮事件
        private void btnShowUserInfo_Click(object sender, EventArgs e)
        {
            string name = txtOldName.Text.Trim();
            UserBLL yhBLL = new UserBLL();
            UserInfo user = new UserInfo();
            user = yhBLL.getUser(name);
            try
            {
                if (user != null)
                {
                    txtName.Text = user.UserName;
                    txtPassword.Text = user.UserPwd;
                }
                else
                {
                    MessageBox.Show("没有该用户");
                    //txtName.Text = "";
                    //txtPassword.Text="";
                    txtOldName.Text = "";
                    txtOldName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text;
            string oldName = txtOldName.Text.Trim();
            UserInfo user = new UserInfo();
            user.UserName = name;
            user.UserPwd = password;
            UserBLL yhBLL = new UserBLL();
            try
            {
                if (yhBLL.changeUser(user, oldName))
                    MessageBox.Show("修改成功!");
                else
                    MessageBox.Show("没有改用户，修改失败！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPassword.Text = "";
            txtName.Focus();
            txtPassword.Focus();
        }


    }
}
