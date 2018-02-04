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

namespace stuScoreManager.StuForm
{
    public partial class StuChangeForm : Form
    {
        public StuChangeForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSno.Text = txtSname.Text = "";
            txtSno.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        StuInfo sInfo = new StuInfo();
        string oldSno = "";

        public StuChangeForm(StuInfo sInfo)
        {
            InitializeComponent();
            this.sInfo = sInfo;
            oldSno = sInfo.Sno;
        }

        private void StuChangeForm_Load(object sender, EventArgs e)
        {
            comSex.Text = "男";
            txtSno.Text = sInfo.Sno;
            txtSname.Text = sInfo.Sname;
            if (sInfo.Ssex == "男")
                comSex.Text = comSex.Items[0].ToString();
            else
                comSex.Text = comSex.Items[1].ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            sInfo.Sno = txtSno.Text.Trim();
            sInfo.Sname = txtSname.Text.Trim();
            sInfo.Ssex = comSex.Text.Trim();
            StuBLL sb = new StuBLL();
            try
            {
                if (sb.changeStu(sInfo, oldSno))
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

    }
}
