namespace PWMS.SecondaryForm
{
    partial class F_Basic
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
            this.gb_use = new System.Windows.Forms.GroupBox();
            this.btn_Bsave = new System.Windows.Forms.Button();
            this.btn_Bcancel = new System.Windows.Forms.Button();
            this.btn_Binsert = new System.Windows.Forms.Button();
            this.btn_Bupdate = new System.Windows.Forms.Button();
            this.btn_Bdelete = new System.Windows.Forms.Button();
            this.gb_change = new System.Windows.Forms.GroupBox();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.gb_basic = new System.Windows.Forms.GroupBox();
            this.lb_basic = new System.Windows.Forms.ListBox();
            this.gb_use.SuspendLayout();
            this.gb_change.SuspendLayout();
            this.gb_basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_use
            // 
            this.gb_use.Controls.Add(this.btn_Bsave);
            this.gb_use.Controls.Add(this.btn_Bcancel);
            this.gb_use.Controls.Add(this.btn_Binsert);
            this.gb_use.Controls.Add(this.btn_Bupdate);
            this.gb_use.Controls.Add(this.btn_Bdelete);
            this.gb_use.Location = new System.Drawing.Point(291, 4);
            this.gb_use.Margin = new System.Windows.Forms.Padding(4);
            this.gb_use.Name = "gb_use";
            this.gb_use.Padding = new System.Windows.Forms.Padding(4);
            this.gb_use.Size = new System.Drawing.Size(167, 331);
            this.gb_use.TabIndex = 8;
            this.gb_use.TabStop = false;
            this.gb_use.Text = "相关操作";
            // 
            // btn_Bsave
            // 
            this.btn_Bsave.Location = new System.Drawing.Point(41, 249);
            this.btn_Bsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bsave.Name = "btn_Bsave";
            this.btn_Bsave.Size = new System.Drawing.Size(100, 29);
            this.btn_Bsave.TabIndex = 6;
            this.btn_Bsave.Text = "保存";
            this.btn_Bsave.UseVisualStyleBackColor = true;
            this.btn_Bsave.Click += new System.EventHandler(this.btn_Bsave_Click);
            // 
            // btn_Bcancel
            // 
            this.btn_Bcancel.Location = new System.Drawing.Point(41, 199);
            this.btn_Bcancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bcancel.Name = "btn_Bcancel";
            this.btn_Bcancel.Size = new System.Drawing.Size(100, 29);
            this.btn_Bcancel.TabIndex = 5;
            this.btn_Bcancel.Text = "取消";
            this.btn_Bcancel.UseVisualStyleBackColor = true;
            this.btn_Bcancel.Click += new System.EventHandler(this.btn_Bcancel_Click);
            // 
            // btn_Binsert
            // 
            this.btn_Binsert.Location = new System.Drawing.Point(41, 49);
            this.btn_Binsert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Binsert.Name = "btn_Binsert";
            this.btn_Binsert.Size = new System.Drawing.Size(100, 29);
            this.btn_Binsert.TabIndex = 2;
            this.btn_Binsert.Text = "添加";
            this.btn_Binsert.UseVisualStyleBackColor = true;
            this.btn_Binsert.Click += new System.EventHandler(this.btn_Binsert_Click);
            // 
            // btn_Bupdate
            // 
            this.btn_Bupdate.Location = new System.Drawing.Point(41, 99);
            this.btn_Bupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bupdate.Name = "btn_Bupdate";
            this.btn_Bupdate.Size = new System.Drawing.Size(100, 29);
            this.btn_Bupdate.TabIndex = 3;
            this.btn_Bupdate.Text = "修改";
            this.btn_Bupdate.UseVisualStyleBackColor = true;
            this.btn_Bupdate.Click += new System.EventHandler(this.btn_Bupdate_Click);
            // 
            // btn_Bdelete
            // 
            this.btn_Bdelete.Location = new System.Drawing.Point(41, 149);
            this.btn_Bdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bdelete.Name = "btn_Bdelete";
            this.btn_Bdelete.Size = new System.Drawing.Size(100, 29);
            this.btn_Bdelete.TabIndex = 4;
            this.btn_Bdelete.Text = "删除";
            this.btn_Bdelete.UseVisualStyleBackColor = true;
            this.btn_Bdelete.Click += new System.EventHandler(this.btn_Bdelete_Click);
            // 
            // gb_change
            // 
            this.gb_change.Controls.Add(this.txt_change);
            this.gb_change.Location = new System.Drawing.Point(3, 262);
            this.gb_change.Margin = new System.Windows.Forms.Padding(4);
            this.gb_change.Name = "gb_change";
            this.gb_change.Padding = new System.Windows.Forms.Padding(4);
            this.gb_change.Size = new System.Drawing.Size(280, 74);
            this.gb_change.TabIndex = 7;
            this.gb_change.TabStop = false;
            this.gb_change.Text = "输入添加\\修改的信息";
            // 
            // txt_change
            // 
            this.txt_change.Location = new System.Drawing.Point(16, 24);
            this.txt_change.Margin = new System.Windows.Forms.Padding(4);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(248, 25);
            this.txt_change.TabIndex = 6;
            // 
            // gb_basic
            // 
            this.gb_basic.Controls.Add(this.lb_basic);
            this.gb_basic.Location = new System.Drawing.Point(3, 4);
            this.gb_basic.Margin = new System.Windows.Forms.Padding(4);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Padding = new System.Windows.Forms.Padding(4);
            this.gb_basic.Size = new System.Drawing.Size(280, 265);
            this.gb_basic.TabIndex = 6;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "基本信息";
            // 
            // lb_basic
            // 
            this.lb_basic.FormattingEnabled = true;
            this.lb_basic.ItemHeight = 15;
            this.lb_basic.Location = new System.Drawing.Point(16, 31);
            this.lb_basic.Margin = new System.Windows.Forms.Padding(4);
            this.lb_basic.Name = "lb_basic";
            this.lb_basic.Size = new System.Drawing.Size(248, 199);
            this.lb_basic.TabIndex = 6;
            this.lb_basic.SelectedIndexChanged += new System.EventHandler(this.lb_basic_SelectedIndexChanged);
            // 
            // F_Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 346);
            this.Controls.Add(this.gb_use);
            this.Controls.Add(this.gb_change);
            this.Controls.Add(this.gb_basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F_Basic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Basic";
            this.Load += new System.EventHandler(this.F_Basic_Load);
            this.gb_use.ResumeLayout(false);
            this.gb_change.ResumeLayout(false);
            this.gb_change.PerformLayout();
            this.gb_basic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_use;
        private System.Windows.Forms.Button btn_Bcancel;
        private System.Windows.Forms.Button btn_Binsert;
        private System.Windows.Forms.Button btn_Bupdate;
        private System.Windows.Forms.Button btn_Bdelete;
        private System.Windows.Forms.GroupBox gb_change;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.GroupBox gb_basic;
        private System.Windows.Forms.ListBox lb_basic;
        private System.Windows.Forms.Button btn_Bsave;
    }
}