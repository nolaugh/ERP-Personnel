namespace PWMS
{
    partial class F_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.lbl_enroll = new System.Windows.Forms.Label();
            this.pic_login = new System.Windows.Forms.PictureBox();
            this.lbl_exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(159, 304);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 29);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(359, 304);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name.Location = new System.Drawing.Point(155, 198);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 17);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "用户名：";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_pwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pwd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_pwd.Location = new System.Drawing.Point(155, 253);
            this.lbl_pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(62, 17);
            this.lbl_pwd.TabIndex = 5;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(284, 195);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(175, 25);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(284, 244);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(175, 25);
            this.txt_pwd.TabIndex = 7;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            this.txt_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_KeyPress);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning.Location = new System.Drawing.Point(281, 274);
            this.lbl_warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 17);
            this.lbl_warning.TabIndex = 8;
            // 
            // lbl_enroll
            // 
            this.lbl_enroll.AutoSize = true;
            this.lbl_enroll.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enroll.ForeColor = System.Drawing.Color.Blue;
            this.lbl_enroll.Location = new System.Drawing.Point(173, 337);
            this.lbl_enroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_enroll.Name = "lbl_enroll";
            this.lbl_enroll.Size = new System.Drawing.Size(67, 15);
            this.lbl_enroll.TabIndex = 9;
            this.lbl_enroll.Text = "点此注册";
            this.lbl_enroll.Click += new System.EventHandler(this.lbl_enroll_Click);
            // 
            // pic_login
            // 
            this.pic_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_login.BackgroundImage")));
            this.pic_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_login.Location = new System.Drawing.Point(0, 0);
            this.pic_login.Margin = new System.Windows.Forms.Padding(4);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(620, 400);
            this.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_login.TabIndex = 0;
            this.pic_login.TabStop = false;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_exit.Location = new System.Drawing.Point(377, 337);
            this.lbl_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(67, 15);
            this.lbl_exit.TabIndex = 10;
            this.lbl_exit.Text = "点此退出";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_enroll);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pic_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.F_Login_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Label lbl_enroll;
        private System.Windows.Forms.Label lbl_exit;
    }
}

