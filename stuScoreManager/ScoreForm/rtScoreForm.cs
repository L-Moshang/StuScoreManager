using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stuScoreManager.ScoreForm
{
    public partial class rtScoreForm : Form
    {
        public rtScoreForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        public rtScoreForm(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void rtScoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                rtScore rpt = new rtScore();
                rpt.SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
