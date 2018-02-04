namespace stuScoreManager.UserForm
{
    partial class ChangeUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserForm));
            this.lblOldName = new System.Windows.Forms.Label();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.btnShowUserInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCZ = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.BackColor = System.Drawing.Color.Transparent;
            this.lblOldName.Location = new System.Drawing.Point(89, 93);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(112, 15);
            this.lblOldName.TabIndex = 0;
            this.lblOldName.Text = "请输入用户名：";
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(207, 89);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(148, 25);
            this.txtOldName.TabIndex = 1;
            // 
            // btnShowUserInfo
            // 
            this.btnShowUserInfo.Location = new System.Drawing.Point(361, 91);
            this.btnShowUserInfo.Name = "btnShowUserInfo";
            this.btnShowUserInfo.Size = new System.Drawing.Size(106, 23);
            this.btnShowUserInfo.TabIndex = 2;
            this.btnShowUserInfo.Text = "显示用户信息";
            this.btnShowUserInfo.UseVisualStyleBackColor = true;
            this.btnShowUserInfo.Click += new System.EventHandler(this.btnShowUserInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCZ);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(92, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // btnCZ
            // 
            this.btnCZ.Location = new System.Drawing.Point(145, 146);
            this.btnCZ.Name = "btnCZ";
            this.btnCZ.Size = new System.Drawing.Size(59, 23);
            this.btnCZ.TabIndex = 6;
            this.btnCZ.Text = "重置";
            this.btnCZ.UseVisualStyleBackColor = true;
            this.btnCZ.Click += new System.EventHandler(this.btnCZ_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(80, 146);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(59, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(77, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "密码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名";
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowUserInfo);
            this.Controls.Add(this.txtOldName);
            this.Controls.Add(this.lblOldName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Button btnShowUserInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCZ;
    }
}