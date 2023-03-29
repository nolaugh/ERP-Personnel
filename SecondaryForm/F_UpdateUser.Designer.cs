namespace PWMS.SecondaryForm
{
    partial class F_UpdateUser
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gb_information = new System.Windows.Forms.GroupBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.gb_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(162, 127);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 29);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(29, 127);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gb_information
            // 
            this.gb_information.Controls.Add(this.text_Pass);
            this.gb_information.Controls.Add(this.text_Name);
            this.gb_information.Controls.Add(this.lbl_pass);
            this.gb_information.Controls.Add(this.lbl_user);
            this.gb_information.Location = new System.Drawing.Point(13, 13);
            this.gb_information.Margin = new System.Windows.Forms.Padding(4);
            this.gb_information.Name = "gb_information";
            this.gb_information.Padding = new System.Windows.Forms.Padding(4);
            this.gb_information.Size = new System.Drawing.Size(261, 108);
            this.gb_information.TabIndex = 3;
            this.gb_information.TabStop = false;
            this.gb_information.Text = "用户信息";
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(100, 66);
            this.text_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.PasswordChar = '*';
            this.text_Pass.Size = new System.Drawing.Size(132, 25);
            this.text_Pass.TabIndex = 4;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(100, 28);
            this.text_Name.Margin = new System.Windows.Forms.Padding(4);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(132, 25);
            this.text_Name.TabIndex = 3;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(24, 72);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(68, 15);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "密  码：";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(24, 35);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(67, 15);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "用户名：";
            // 
            // F_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 166);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账户密码修改";
            this.Load += new System.EventHandler(this.F_UpdateUser_Load);
            this.gb_information.ResumeLayout(false);
            this.gb_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox gb_information;
        private System.Windows.Forms.TextBox text_Pass;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
    }
}