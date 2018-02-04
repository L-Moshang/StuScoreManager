using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Data.SqlClient;
using stuScoreManager.BLL;

namespace stuScoreManager
{
    public partial class FrmLogin : Form
    {
        VerificationCode vc = new VerificationCode();

        public FrmLogin()
        {
            InitializeComponent();
        }

        //登录按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region
            //if (txtName.Text != "" && txtPwd.Text != "")
            //{
            //    try
            //    {
            //        //string constr = "server=USER-20141022LE\\SQLEXPRESS;database=stuScoreManager;Integrated Security=True";
            //        string constr = "server=Moshang-PC;database=stuScoreManager;Integrated Security=True";
            //        SqlConnection con = new SqlConnection(constr);
            //        string sql = "select count(*) from users where username=@name and userPwd=@pwd";
            //        SqlCommand cmd = new SqlCommand(sql, con);
            //        SqlParameter[] paras ={
            //                     new SqlParameter("@name",SqlDbType.VarChar,20),
            //                     new SqlParameter("@pwd",SqlDbType.VarChar,50)
            //                 };
            //        paras[0].Value = txtName.Text.Trim();
            //        paras[1].Value = EncryptWithMD5(txtPwd.Text);
            //        cmd.Parameters.AddRange(paras);
            //        con.Open();
            //        int n = int.Parse(cmd.ExecuteScalar().ToString());
            //        con.Close();
            //        if (n > 0)
            //        {
            //            //登录成功跳转至菜单页面
            //            Menu form = new Menu();
            //            form.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("用户名或密码出错");
            //            txtName.Text = "";
            //            txtPwd.Text = "";
            //            txtName.Focus();            //添加焦点至txtName
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("登录失败 :" + ex.Message);
            //        throw;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("用户名或密码不能为空");
            //    txtName.Focus();            //添加焦点至txtName
            //} 
            #endregion

            try
            {
                if (vc.YanZ(txtWb.Text))
                {
                    string name = txtName.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    UserBLL yhBLL = new UserBLL();
                    try
                    {
                        if (yhBLL.Login(name, password))
                        {
                            MainForm mf = new MainForm();
                            mf.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        chongzhi();
                    }
                }
                else if (vc.YanZ(txtWb.Text))
                {
                    pictureBox1.Image = vc.Yzm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = vc.Yzm();
                txtWb.Text = "";
                txtWb.Focus();
            }
        }

        //重置按钮事件
        private void btnReset_Click(object sender, EventArgs e)
        {
            chongzhi();            //添加焦点至txtName
        }
        
        private void chongzhi()
        {
            txtName.Text = txtPassword.Text = txtWb.Text="";
            txtName.Focus();
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = vc.Yzm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = vc.Yzm();
        }

        private void txtWb_Enter(object sender, EventArgs e)
        {
            txtWb.Text = "";
        }

        private void txtWb_Leave(object sender, EventArgs e)
        {
            if (txtWb.Text.Trim() == "")
                txtWb.Text = "请输入验证码";
        }
    }
}
