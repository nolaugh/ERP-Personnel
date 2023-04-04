namespace PWMS.PerForm
{
    partial class F_HaveBack
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
            this.tbc_datause = new System.Windows.Forms.TabControl();
            this.tbp_backup = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.rdb_source = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tbp_review = new System.Windows.Forms.TabPage();
            this.btn_rexit = new System.Windows.Forms.Button();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_choose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.ofd_review = new System.Windows.Forms.OpenFileDialog();
            this.tbc_datause.SuspendLayout();
            this.tbp_backup.SuspendLayout();
            this.tbp_review.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_datause
            // 
            this.tbc_datause.Controls.Add(this.tbp_backup);
            this.tbc_datause.Controls.Add(this.tbp_review);
            this.tbc_datause.Location = new System.Drawing.Point(4, 4);
            this.tbc_datause.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_datause.Name = "tbc_datause";
            this.tbc_datause.SelectedIndex = 0;
            this.tbc_datause.Size = new System.Drawing.Size(440, 222);
            this.tbc_datause.TabIndex = 1;
            // 
            // tbp_backup
            // 
            this.tbp_backup.Controls.Add(this.btn_exit);
            this.tbp_backup.Controls.Add(this.txt_source);
            this.tbp_backup.Controls.Add(this.rdb_source);
            this.tbp_backup.Controls.Add(this.button1);
            this.tbp_backup.Location = new System.Drawing.Point(4, 25);
            this.tbp_backup.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_backup.Name = "tbp_backup";
            this.tbp_backup.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_backup.Size = new System.Drawing.Size(432, 193);
            this.tbp_backup.TabIndex = 0;
            this.tbp_backup.Text = "备份数据库";
            this.tbp_backup.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(260, 115);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 29);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_source
            // 
            this.txt_source.Enabled = false;
            this.txt_source.Location = new System.Drawing.Point(154, 57);
            this.txt_source.Margin = new System.Windows.Forms.Padding(4);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(228, 25);
            this.txt_source.TabIndex = 4;
            this.txt_source.Text = "软件根目录\\bin\\Debug\\bar";
            // 
            // rdb_source
            // 
            this.rdb_source.AutoSize = true;
            this.rdb_source.Checked = true;
            this.rdb_source.Location = new System.Drawing.Point(52, 60);
            this.rdb_source.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_source.Name = "rdb_source";
            this.rdb_source.Size = new System.Drawing.Size(88, 19);
            this.rdb_source.TabIndex = 2;
            this.rdb_source.TabStop = true;
            this.rdb_source.Text = "默认路径";
            this.rdb_source.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "备份";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbp_review
            // 
            this.tbp_review.Controls.Add(this.btn_rexit);
            this.tbp_review.Controls.Add(this.btn_review);
            this.tbp_review.Controls.Add(this.btn_choose);
            this.tbp_review.Controls.Add(this.label1);
            this.tbp_review.Controls.Add(this.txt_review);
            this.tbp_review.Location = new System.Drawing.Point(4, 25);
            this.tbp_review.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_review.Name = "tbp_review";
            this.tbp_review.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_review.Size = new System.Drawing.Size(432, 193);
            this.tbp_review.TabIndex = 1;
            this.tbp_review.Text = "还原数据库";
            this.tbp_review.UseVisualStyleBackColor = true;
            // 
            // btn_rexit
            // 
            this.btn_rexit.Location = new System.Drawing.Point(227, 114);
            this.btn_rexit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rexit.Name = "btn_rexit";
            this.btn_rexit.Size = new System.Drawing.Size(100, 29);
            this.btn_rexit.TabIndex = 4;
            this.btn_rexit.Text = "取消";
            this.btn_rexit.UseVisualStyleBackColor = true;
            this.btn_rexit.Click += new System.EventHandler(this.btn_rexit_Click);
            // 
            // btn_review
            // 
            this.btn_review.Location = new System.Drawing.Point(105, 114);
            this.btn_review.Margin = new System.Windows.Forms.Padding(4);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(100, 29);
            this.btn_review.TabIndex = 3;
            this.btn_review.Text = "还原";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(343, 53);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(58, 29);
            this.btn_choose.TabIndex = 2;
            this.btn_choose.Text = "选择";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "还原路径：";
            // 
            // txt_review
            // 
            this.txt_review.Location = new System.Drawing.Point(117, 54);
            this.txt_review.Margin = new System.Windows.Forms.Padding(4);
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(224, 25);
            this.txt_review.TabIndex = 0;
            // 
            // ofd_review
            // 
            this.ofd_review.FileName = "openFileDialog1";
            // 
            // F_HaveBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 228);
            this.Controls.Add(this.tbc_datause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_HaveBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库操作";
            this.Load += new System.EventHandler(this.F_HaveBack_Load);
            this.tbc_datause.ResumeLayout(false);
            this.tbp_backup.ResumeLayout(false);
            this.tbp_backup.PerformLayout();
            this.tbp_review.ResumeLayout(false);
            this.tbp_review.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_datause;
        private System.Windows.Forms.TabPage tbp_backup;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.RadioButton rdb_source;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbp_review;
        private System.Windows.Forms.Button btn_rexit;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.OpenFileDialog ofd_review;
    }
}