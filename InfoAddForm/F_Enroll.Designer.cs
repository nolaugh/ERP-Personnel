namespace PWMS.InfoAddForm
{
    partial class F_Enroll
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
            this.lbl_ename = new System.Windows.Forms.Label();
            this.lbl_epwd = new System.Windows.Forms.Label();
            this.lbl_epwd_twice = new System.Windows.Forms.Label();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.txt_epwd = new System.Windows.Forms.TextBox();
            this.txt_epwd_twice = new System.Windows.Forms.TextBox();
            this.pic_enroll = new System.Windows.Forms.PictureBox();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.btn_ecancel = new System.Windows.Forms.Button();
            this.lbl_ewarning = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_pass_t = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_enroll)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ename
            // 
            this.lbl_ename.AutoSize = true;
            this.lbl_ename.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ename.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ename.Location = new System.Drawing.Point(105, 222);
            this.lbl_ename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ename.Name = "lbl_ename";
            this.lbl_ename.Size = new System.Drawing.Size(80, 17);
            this.lbl_ename.TabIndex = 5;
            this.lbl_ename.Text = "用户名：";
            // 
            // lbl_epwd
            // 
            this.lbl_epwd.AutoSize = true;
            this.lbl_epwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_epwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_epwd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_epwd.Location = new System.Drawing.Point(105, 255);
            this.lbl_epwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_epwd.Name = "lbl_epwd";
            this.lbl_epwd.Size = new System.Drawing.Size(62, 17);
            this.lbl_epwd.TabIndex = 6;
            this.lbl_epwd.Text = "密码：";
            // 
            // lbl_epwd_twice
            // 
            this.lbl_epwd_twice.AutoSize = true;
            this.lbl_epwd_twice.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_epwd_twice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_epwd_twice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_epwd_twice.Location = new System.Drawing.Point(105, 289);
            this.lbl_epwd_twice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_epwd_twice.Name = "lbl_epwd_twice";
            this.lbl_epwd_twice.Size = new System.Drawing.Size(98, 17);
            this.lbl_epwd_twice.TabIndex = 7;
            this.lbl_epwd_twice.Text = "再次输入：";
            // 
            // txt_ename
            // 
            this.txt_ename.Location = new System.Drawing.Point(285, 213);
            this.txt_ename.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(175, 25);
            this.txt_ename.TabIndex = 8;
            this.txt_ename.TextChanged += new System.EventHandler(this.txt_ename_TextChanged);
            this.txt_ename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ename_KeyPress);
            // 
            // txt_epwd
            // 
            this.txt_epwd.Location = new System.Drawing.Point(285, 246);
            this.txt_epwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_epwd.Name = "txt_epwd";
            this.txt_epwd.Size = new System.Drawing.Size(175, 25);
            this.txt_epwd.TabIndex = 9;
            this.txt_epwd.TextChanged += new System.EventHandler(this.txt_epwd_TextChanged);
            this.txt_epwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_epwd_KeyPress);
            // 
            // txt_epwd_twice
            // 
            this.txt_epwd_twice.Location = new System.Drawing.Point(285, 280);
            this.txt_epwd_twice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_epwd_twice.Name = "txt_epwd_twice";
            this.txt_epwd_twice.Size = new System.Drawing.Size(175, 25);
            this.txt_epwd_twice.TabIndex = 10;
            this.txt_epwd_twice.TextChanged += new System.EventHandler(this.txt_epwd_twice_TextChanged);
            this.txt_epwd_twice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_epwd_twice_KeyPress);
            // 
            // pic_enroll
            // 
            this.pic_enroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_enroll.Image = global::PWMS.Properties.Resources.登录;
            this.pic_enroll.Location = new System.Drawing.Point(0, 0);
            this.pic_enroll.Margin = new System.Windows.Forms.Padding(4);
            this.pic_enroll.Name = "pic_enroll";
            this.pic_enroll.Size = new System.Drawing.Size(620, 400);
            this.pic_enroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_enroll.TabIndex = 1;
            this.pic_enroll.TabStop = false;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(132, 338);
            this.btn_enroll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(100, 29);
            this.btn_enroll.TabIndex = 11;
            this.btn_enroll.Text = "注册";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // btn_ecancel
            // 
            this.btn_ecancel.Location = new System.Drawing.Point(333, 338);
            this.btn_ecancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ecancel.Name = "btn_ecancel";
            this.btn_ecancel.Size = new System.Drawing.Size(100, 29);
            this.btn_ecancel.TabIndex = 12;
            this.btn_ecancel.Text = "返回";
            this.btn_ecancel.UseVisualStyleBackColor = true;
            this.btn_ecancel.Click += new System.EventHandler(this.btn_ecancel_Click);
            // 
            // lbl_ewarning
            // 
            this.lbl_ewarning.AutoSize = true;
            this.lbl_ewarning.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_ewarning.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ewarning.Location = new System.Drawing.Point(281, 309);
            this.lbl_ewarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ewarning.Name = "lbl_ewarning";
            this.lbl_ewarning.Size = new System.Drawing.Size(0, 17);
            this.lbl_ewarning.TabIndex = 13;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("宋体", 8F);
            this.lbl_account.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_account.Location = new System.Drawing.Point(467, 220);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(0, 14);
            this.lbl_account.TabIndex = 14;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("宋体", 8F);
            this.lbl_pass.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pass.Location = new System.Drawing.Point(467, 255);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(0, 14);
            this.lbl_pass.TabIndex = 15;
            // 
            // lbl_pass_t
            // 
            this.lbl_pass_t.AutoSize = true;
            this.lbl_pass_t.Font = new System.Drawing.Font("宋体", 8F);
            this.lbl_pass_t.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pass_t.Location = new System.Drawing.Point(467, 287);
            this.lbl_pass_t.Name = "lbl_pass_t";
            this.lbl_pass_t.Size = new System.Drawing.Size(0, 14);
            this.lbl_pass_t.TabIndex = 16;
            // 
            // F_Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.lbl_pass_t);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_ewarning);
            this.Controls.Add(this.btn_ecancel);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.txt_epwd_twice);
            this.Controls.Add(this.txt_epwd);
            this.Controls.Add(this.txt_ename);
            this.Controls.Add(this.lbl_epwd_twice);
            this.Controls.Add(this.lbl_epwd);
            this.Controls.Add(this.lbl_ename);
            this.Controls.Add(this.pic_enroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Enroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Enroll";
            this.Activated += new System.EventHandler(this.F_Enroll_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pic_enroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ename;
        private System.Windows.Forms.Label lbl_epwd;
        private System.Windows.Forms.Label lbl_epwd_twice;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.TextBox txt_epwd;
        private System.Windows.Forms.TextBox txt_epwd_twice;
        private System.Windows.Forms.PictureBox pic_enroll;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.Button btn_ecancel;
        private System.Windows.Forms.Label lbl_ewarning;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_pass_t;
    }
}