namespace stuScoreManager.ScoreForm
{
    partial class ScoreMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeClassCourse = new System.Windows.Forms.TreeView();
            this.dgvScoreInfo = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // treeClassCourse
            // 
            this.treeClassCourse.Location = new System.Drawing.Point(13, 13);
            this.treeClassCourse.Name = "treeClassCourse";
            this.treeClassCourse.Size = new System.Drawing.Size(111, 461);
            this.treeClassCourse.TabIndex = 0;
            this.treeClassCourse.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeClassCourse_NodeMouseClick);
            // 
            // dgvScoreInfo
            // 
            this.dgvScoreInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreInfo.Location = new System.Drawing.Point(131, 13);
            this.dgvScoreInfo.Name = "dgvScoreInfo";
            this.dgvScoreInfo.RowTemplate.Height = 23;
            this.dgvScoreInfo.Size = new System.Drawing.Size(438, 434);
            this.dgvScoreInfo.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(418, 451);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "生成报表";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ScoreMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(581, 486);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvScoreInfo);
            this.Controls.Add(this.treeClassCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreMainForm";
            this.Load += new System.EventHandler(this.ScoreMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeClassCourse;
        private System.Windows.Forms.DataGridView dgvScoreInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
    }
}