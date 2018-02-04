using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stuScoreManager.Model;
using stuScoreManager.BLL;

namespace stuScoreManager.UserForm
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent(); 
        }

        //重置按钮事件
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPassword.Text = txtComfirmPwd.Text = "";
            txtName.Focus();            //添加焦点至txtName
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPwd=txtComfirmPwd.Text.Trim();
            UserInfo model = new UserInfo();
            model.UserName = name;
            model.UserPwd = password;
            UserBLL yhBLL = new UserBLL();
            try
            {
                if (yhBLL.Add(model, confirmPwd))
                    MessageBox.Show("添加成功！");
                else
                    MessageBox.Show("添加失败！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
