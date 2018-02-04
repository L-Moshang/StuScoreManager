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
    public partial class StuAddForm : Form
    {
        
        string cno;

        public StuAddForm(string cno)
        {
            InitializeComponent();
            this.cno = cno;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string no = txtSno.Text.Trim();
            string name = txtSname.Text.Trim();
            string sex = comSex.Text.Trim();
            StuInfo model = new StuInfo();
            model.Sno = no;
            model.Sname = name;
            model.Ssex = sex;
            model.Cno = cno;
            StuBLL Sbll = new StuBLL();
            try
            {
                if (Sbll.Add(model))
                { 
                    MessageBox.Show("添加成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("学生已存在，添加失败！");
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
            txtSno.Text = txtSname.Text = "";
            txtSno.Focus();
        }

        private void StuAddForm_Load(object sender, EventArgs e)
        {
            comSex.Text = "男";
        }

    }
}
