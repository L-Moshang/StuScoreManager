namespace stuScoreManager.StuForm
{
    partial class StuChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuChangeForm));
            this.comSex = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblCdept = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comSex
            // 
            this.comSex.FormattingEnabled = true;
            this.comSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comSex.Location = new System.Drawing.Point(314, 268);
            this.comSex.Name = "comSex";
            this.comSex.Size = new System.Drawing.Size(132, 23);
            this.comSex.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 320);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 29);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 29);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(196, 320);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(69, 28);
            this.btnChange.TabIndex = 37;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblCdept
            // 
            this.lblCdept.AutoSize = true;
            this.lblCdept.BackColor = System.Drawing.Color.Transparent;
            this.lblCdept.Location = new System.Drawing.Point(198, 271);
            this.lblCdept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdept.Name = "lblCdept";
            this.lblCdept.Size = new System.Drawing.Size(37, 15);
            this.lblCdept.TabIndex = 33;
            this.lblCdept.Text = "性别";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(314, 205);
            this.txtSname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(132, 25);
            this.txtSname.TabIndex = 36;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.BackColor = System.Drawing.Color.Transparent;
            this.lblSname.Location = new System.Drawing.Point(198, 209);
            this.lblSname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(37, 15);
            this.lblSname.TabIndex = 32;
            this.lblSname.Text = "姓名";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(314, 146);
            this.txtSno.Margin = new System.Windows.Forms.Padding(4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(132, 25);
            this.txtSno.TabIndex = 35;
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.BackColor = System.Drawing.Color.Transparent;
            this.lblSno.Location = new System.Drawing.Point(198, 150);
            this.lblSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(37, 15);
            this.lblSno.TabIndex = 34;
            this.lblSno.Text = "学号";
            // 
            // StuChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.comSex);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblCdept);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.lblSno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuChangeForm";
            this.Load += new System.EventHandler(this.StuChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comSex;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblCdept;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label lblSno;
    }
}