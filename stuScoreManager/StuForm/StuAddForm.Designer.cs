namespace stuScoreManager.StuForm
{
    partial class StuAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuAddForm));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCdept = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.comSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 319);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 29);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 29);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCdept
            // 
            this.lblCdept.AutoSize = true;
            this.lblCdept.BackColor = System.Drawing.Color.Transparent;
            this.lblCdept.Location = new System.Drawing.Point(198, 270);
            this.lblCdept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdept.Name = "lblCdept";
            this.lblCdept.Size = new System.Drawing.Size(37, 15);
            this.lblCdept.TabIndex = 23;
            this.lblCdept.Text = "性别";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(314, 204);
            this.txtSname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(132, 25);
            this.txtSname.TabIndex = 26;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.BackColor = System.Drawing.Color.Transparent;
            this.lblSname.Location = new System.Drawing.Point(198, 208);
            this.lblSname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(37, 15);
            this.lblSname.TabIndex = 22;
            this.lblSname.Text = "姓名";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(314, 145);
            this.txtSno.Margin = new System.Windows.Forms.Padding(4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(132, 25);
            this.txtSno.TabIndex = 25;
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.BackColor = System.Drawing.Color.Transparent;
            this.lblSno.Location = new System.Drawing.Point(198, 149);
            this.lblSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(37, 15);
            this.lblSno.TabIndex = 24;
            this.lblSno.Text = "学号";
            // 
            // comSex
            // 
            this.comSex.FormattingEnabled = true;
            this.comSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comSex.Location = new System.Drawing.Point(314, 267);
            this.comSex.Name = "comSex";
            this.comSex.Size = new System.Drawing.Size(132, 23);
            this.comSex.TabIndex = 31;
            // 
            // StuAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.comSex);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCdept);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.lblSno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuAddForm";
            this.Load += new System.EventHandler(this.StuAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCdept;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.ComboBox comSex;
    }
}