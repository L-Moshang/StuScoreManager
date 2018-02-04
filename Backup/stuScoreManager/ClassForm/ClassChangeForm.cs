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

namespace stuScoreManager.ClassForm
{
    public partial class ClassChangeForm : Form
    {
        public ClassChangeForm()
        {
            InitializeComponent();
        }

        ClassInfo cInfo = new ClassInfo();
        string oldNo = "";

        public ClassChangeForm(ClassInfo cInfo)
        {
            InitializeComponent();
            this.cInfo = cInfo;
        }

        private void ClassChangeForm_Load(object sender, EventArgs e)
        {
            txtCno.Text = cInfo.Cno;
            txtCname.Text = cInfo.Cname;
            txtCdept.Text = cInfo.Cdept;
            oldNo = cInfo.Cno;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            cInfo.Cno = txtCno.Text.Trim();
            cInfo.Cname = txtCname.Text.Trim();
            cInfo.Cdept = txtCdept.Text.Trim();
            ClassBLL cb = new ClassBLL();
            try
            {
                if (cb.changeClass(cInfo, oldNo))
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCdept.Text = txtCname.Text = txtCno.Text = "";
            txtCno.Focus();
        }
    }
}
