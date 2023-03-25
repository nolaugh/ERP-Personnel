namespace PWMS.PerForm
{
    partial class F_user
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.gb_use = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.gb_manage = new System.Windows.Forms.GroupBox();
            this.lbl_pope = new System.Windows.Forms.Label();
            this.btn_newuser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.gb_use.SuspendLayout();
            this.gb_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_user);
            this.groupBox1.Location = new System.Drawing.Point(13, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(458, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息表";
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AllowUserToResizeRows = false;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(12, 25);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 23;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(438, 192);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellEnter);
            // 
            // gb_use
            // 
            this.gb_use.Controls.Add(this.btn_newuser);
            this.gb_use.Controls.Add(this.btn_update);
            this.gb_use.Controls.Add(this.btn_delete);
            this.gb_use.Location = new System.Drawing.Point(13, 12);
            this.gb_use.Name = "gb_use";
            this.gb_use.Size = new System.Drawing.Size(458, 65);
            this.gb_use.TabIndex = 4;
            this.gb_use.TabStop = false;
            this.gb_use.Text = "操作";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(332, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "用户删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(267, 24);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(90, 30);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "添加权限";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(188, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 30);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "用户修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // gb_manage
            // 
            this.gb_manage.Controls.Add(this.lbl_pope);
            this.gb_manage.Controls.Add(this.btn_insert);
            this.gb_manage.Location = new System.Drawing.Point(12, 83);
            this.gb_manage.Name = "gb_manage";
            this.gb_manage.Size = new System.Drawing.Size(459, 70);
            this.gb_manage.TabIndex = 7;
            this.gb_manage.TabStop = false;
            this.gb_manage.Text = "用户权限";
            // 
            // lbl_pope
            // 
            this.lbl_pope.AutoSize = true;
            this.lbl_pope.Location = new System.Drawing.Point(108, 32);
            this.lbl_pope.Name = "lbl_pope";
            this.lbl_pope.Size = new System.Drawing.Size(129, 15);
            this.lbl_pope.TabIndex = 7;
            this.lbl_pope.Text = "是否管理员：null";
            // 
            // btn_newuser
            // 
            this.btn_newuser.Location = new System.Drawing.Point(40, 21);
            this.btn_newuser.Name = "btn_newuser";
            this.btn_newuser.Size = new System.Drawing.Size(90, 30);
            this.btn_newuser.TabIndex = 7;
            this.btn_newuser.Text = "用户注册";
            this.btn_newuser.UseVisualStyleBackColor = true;
            this.btn_newuser.Click += new System.EventHandler(this.btn_newuser_Click);
            // 
            // F_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 402);
            this.Controls.Add(this.gb_manage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_use);
            this.Name = "F_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户设置";
            this.Activated += new System.EventHandler(this.F_user_Activated);
            this.Load += new System.EventHandler(this.F_user_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.gb_use.ResumeLayout(false);
            this.gb_manage.ResumeLayout(false);
            this.gb_manage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.GroupBox gb_use;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox gb_manage;
        private System.Windows.Forms.Label lbl_pope;
        private System.Windows.Forms.Button btn_newuser;
    }
}