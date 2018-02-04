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
    public partial class FindUserForm : Form
    {
        public FindUserForm()
        {
            InitializeComponent();
        }

        private void btnShowUserInfo_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text.Trim();
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
                    MessageBox.Show("没有该用户！");
                    txtName.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
