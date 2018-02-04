namespace stuScoreManager.ClassForm
{
    partial class ClassAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassAddForm));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCdept = new System.Windows.Forms.TextBox();
            this.lblCdept = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.lblCno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(281, 318);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 29);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 29);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCdept
            // 
            this.txtCdept.Location = new System.Drawing.Point(312, 266);
            this.txtCdept.Margin = new System.Windows.Forms.Padding(4);
            this.txtCdept.Name = "txtCdept";
            this.txtCdept.Size = new System.Drawing.Size(132, 25);
            this.txtCdept.TabIndex = 18;
            // 
            // lblCdept
            // 
            this.lblCdept.AutoSize = true;
            this.lblCdept.BackColor = System.Drawing.Color.Transparent;
            this.lblCdept.Location = new System.Drawing.Point(196, 269);
            this.lblCdept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdept.Name = "lblCdept";
            this.lblCdept.Size = new System.Drawing.Size(67, 15);
            this.lblCdept.TabIndex = 14;
            this.lblCdept.Text = "所属系部";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(312, 203);
            this.txtCname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(132, 25);
            this.txtCname.TabIndex = 17;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.BackColor = System.Drawing.Color.Transparent;
            this.lblCname.Location = new System.Drawing.Point(196, 207);
            this.lblCname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(67, 15);
            this.lblCname.TabIndex = 13;
            this.lblCname.Text = "班级名称";
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(312, 144);
            this.txtCno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(132, 25);
            this.txtCno.TabIndex = 16;
            // 
            // lblCno
            // 
            this.lblCno.AutoSize = true;
            this.lblCno.BackColor = System.Drawing.Color.Transparent;
            this.lblCno.Location = new System.Drawing.Point(196, 148);
            this.lblCno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCno.Name = "lblCno";
            this.lblCno.Size = new System.Drawing.Size(67, 15);
            this.lblCno.TabIndex = 15;
            this.lblCno.Text = "班级编号";
            // 
            // ClassAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCdept);
            this.Controls.Add(this.lblCdept);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblCname);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.lblCno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCdept;
        private System.Windows.Forms.Label lblCdept;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label lblCno;
    }
}