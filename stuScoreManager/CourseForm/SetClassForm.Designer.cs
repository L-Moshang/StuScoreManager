namespace stuScoreManager.CourseForm
{
    partial class SetClassForm
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
            this.listClass = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.comCourse = new System.Windows.Forms.ComboBox();
            this.comClass = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClass
            // 
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 15;
            this.listClass.Location = new System.Drawing.Point(16, 166);
            this.listClass.Margin = new System.Windows.Forms.Padding(4);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(741, 379);
            this.listClass.TabIndex = 0;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 118);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Location = new System.Drawing.Point(45, 52);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(82, 15);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "请选择课程";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Location = new System.Drawing.Point(45, 120);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(82, 15);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "请选择班级";
            // 
            // comCourse
            // 
            this.comCourse.FormattingEnabled = true;
            this.comCourse.Location = new System.Drawing.Point(160, 49);
            this.comCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comCourse.Name = "comCourse";
            this.comCourse.Size = new System.Drawing.Size(205, 23);
            this.comCourse.TabIndex = 3;
            this.comCourse.SelectedIndexChanged += new System.EventHandler(this.comCourse_SelectedIndexChanged);
            // 
            // comClass
            // 
            this.comClass.FormattingEnabled = true;
            this.comClass.Location = new System.Drawing.Point(160, 116);
            this.comClass.Margin = new System.Windows.Forms.Padding(4);
            this.comClass.Name = "comClass";
            this.comClass.Size = new System.Drawing.Size(205, 23);
            this.comClass.TabIndex = 3;
            this.comClass.SelectedIndexChanged += new System.EventHandler(this.comClass_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(160, 564);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 564);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuScoreManager.Properties.Resources.Fate_Wallpapers__12_;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.comClass);
            this.Controls.Add(this.comCourse);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetClassForm";
            this.Load += new System.EventHandler(this.SetClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox comCourse;
        private System.Windows.Forms.ComboBox comClass;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
    }
}