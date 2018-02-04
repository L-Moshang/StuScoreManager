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
    public partial class ClassAddForm : Form
    {
        public ClassAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string no = txtCno.Text.Trim();
            string name = txtCname.Text.Trim();
            string dept = txtCdept.Text;
            ClassInfo model = new ClassInfo();
            model.Cno = no;
            model.Cname = name;
            model.Cdept = dept;
            ClassBLL Cbll = new ClassBLL();
            try
            {
                if (Cbll.Add(model))
                { 
                    MessageBox.Show("添加成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("添加失败！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCdept.Text = txtCname.Text = txtCno.Text = "";
            txtCno.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
