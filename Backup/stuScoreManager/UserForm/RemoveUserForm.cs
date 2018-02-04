using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using stuScoreManager.BLL;

namespace stuScoreManager.UserForm
{
    public partial class RemoveUserForm : Form
    {
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string name = txtName.Text.Trim();
                UserBLL yhBLL = new UserBLL();
                try
                {
                    if (yhBLL.removeUser(name))
                        MessageBox.Show("删除成功");
                    else
                        MessageBox.Show("删除失败");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
