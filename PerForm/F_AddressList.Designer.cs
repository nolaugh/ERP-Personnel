namespace PWMS.PerForm
{
    partial class F_AddressList
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
            this.gb_dgv = new System.Windows.Forms.GroupBox();
            this.dgv_addresslist = new System.Windows.Forms.DataGridView();
            this.gb_use = new System.Windows.Forms.GroupBox();
            this.btn_Aexit = new System.Windows.Forms.Button();
            this.btn_Adelete = new System.Windows.Forms.Button();
            this.btn_Aupdate = new System.Windows.Forms.Button();
            this.btn_Ainsert = new System.Windows.Forms.Button();
            this.gb_select = new System.Windows.Forms.GroupBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.lbl_selectway = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_selectway = new System.Windows.Forms.TextBox();
            this.cb_selectkind = new System.Windows.Forms.ComboBox();
            this.gb_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addresslist)).BeginInit();
            this.gb_use.SuspendLayout();
            this.gb_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_dgv
            // 
            this.gb_dgv.Controls.Add(this.dgv_addresslist);
            this.gb_dgv.Location = new System.Drawing.Point(13, 89);
            this.gb_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.gb_dgv.Name = "gb_dgv";
            this.gb_dgv.Padding = new System.Windows.Forms.Padding(4);
            this.gb_dgv.Size = new System.Drawing.Size(603, 251);
            this.gb_dgv.TabIndex = 5;
            this.gb_dgv.TabStop = false;
            this.gb_dgv.Text = "数据表";
            // 
            // dgv_addresslist
            // 
            this.dgv_addresslist.AllowUserToAddRows = false;
            this.dgv_addresslist.AllowUserToDeleteRows = false;
            this.dgv_addresslist.AllowUserToResizeRows = false;
            this.dgv_addresslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addresslist.Location = new System.Drawing.Point(11, 25);
            this.dgv_addresslist.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_addresslist.Name = "dgv_addresslist";
            this.dgv_addresslist.ReadOnly = true;
            this.dgv_addresslist.RowHeadersVisible = false;
            this.dgv_addresslist.RowHeadersWidth = 51;
            this.dgv_addresslist.RowTemplate.Height = 23;
            this.dgv_addresslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_addresslist.Size = new System.Drawing.Size(581, 215);
            this.dgv_addresslist.TabIndex = 0;
            this.dgv_addresslist.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addresslist_CellEnter);
            // 
            // gb_use
            // 
            this.gb_use.Controls.Add(this.btn_Aexit);
            this.gb_use.Controls.Add(this.btn_Adelete);
            this.gb_use.Controls.Add(this.btn_Aupdate);
            this.gb_use.Controls.Add(this.btn_Ainsert);
            this.gb_use.Location = new System.Drawing.Point(13, 347);
            this.gb_use.Margin = new System.Windows.Forms.Padding(4);
            this.gb_use.Name = "gb_use";
            this.gb_use.Padding = new System.Windows.Forms.Padding(4);
            this.gb_use.Size = new System.Drawing.Size(603, 64);
            this.gb_use.TabIndex = 4;
            this.gb_use.TabStop = false;
            this.gb_use.Text = "操作";
            // 
            // btn_Aexit
            // 
            this.btn_Aexit.Location = new System.Drawing.Point(447, 25);
            this.btn_Aexit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aexit.Name = "btn_Aexit";
            this.btn_Aexit.Size = new System.Drawing.Size(100, 29);
            this.btn_Aexit.TabIndex = 9;
            this.btn_Aexit.Text = "退出";
            this.btn_Aexit.UseVisualStyleBackColor = true;
            this.btn_Aexit.Click += new System.EventHandler(this.btn_Aexit_Click);
            // 
            // btn_Adelete
            // 
            this.btn_Adelete.Location = new System.Drawing.Point(319, 25);
            this.btn_Adelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Adelete.Name = "btn_Adelete";
            this.btn_Adelete.Size = new System.Drawing.Size(100, 29);
            this.btn_Adelete.TabIndex = 8;
            this.btn_Adelete.Text = "删除";
            this.btn_Adelete.UseVisualStyleBackColor = true;
            this.btn_Adelete.Click += new System.EventHandler(this.btn_Adelete_Click);
            // 
            // btn_Aupdate
            // 
            this.btn_Aupdate.Location = new System.Drawing.Point(185, 25);
            this.btn_Aupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aupdate.Name = "btn_Aupdate";
            this.btn_Aupdate.Size = new System.Drawing.Size(100, 29);
            this.btn_Aupdate.TabIndex = 7;
            this.btn_Aupdate.Text = "修改";
            this.btn_Aupdate.UseVisualStyleBackColor = true;
            this.btn_Aupdate.Click += new System.EventHandler(this.btn_Aupdate_Click);
            // 
            // btn_Ainsert
            // 
            this.btn_Ainsert.Location = new System.Drawing.Point(51, 25);
            this.btn_Ainsert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ainsert.Name = "btn_Ainsert";
            this.btn_Ainsert.Size = new System.Drawing.Size(100, 29);
            this.btn_Ainsert.TabIndex = 6;
            this.btn_Ainsert.Text = "添加";
            this.btn_Ainsert.UseVisualStyleBackColor = true;
            this.btn_Ainsert.Click += new System.EventHandler(this.btn_Ainsert_Click);
            // 
            // gb_select
            // 
            this.gb_select.Controls.Add(this.btn_all);
            this.gb_select.Controls.Add(this.lbl_selectway);
            this.gb_select.Controls.Add(this.lbl_select);
            this.gb_select.Controls.Add(this.btn_select);
            this.gb_select.Controls.Add(this.txt_selectway);
            this.gb_select.Controls.Add(this.cb_selectkind);
            this.gb_select.Location = new System.Drawing.Point(13, 13);
            this.gb_select.Margin = new System.Windows.Forms.Padding(4);
            this.gb_select.Name = "gb_select";
            this.gb_select.Padding = new System.Windows.Forms.Padding(4);
            this.gb_select.Size = new System.Drawing.Size(603, 68);
            this.gb_select.TabIndex = 3;
            this.gb_select.TabStop = false;
            this.gb_select.Text = "查询";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(529, 26);
            this.btn_all.Margin = new System.Windows.Forms.Padding(4);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(57, 29);
            this.btn_all.TabIndex = 5;
            this.btn_all.Text = "全部";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // lbl_selectway
            // 
            this.lbl_selectway.AutoSize = true;
            this.lbl_selectway.Location = new System.Drawing.Point(229, 35);
            this.lbl_selectway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectway.Name = "lbl_selectway";
            this.lbl_selectway.Size = new System.Drawing.Size(82, 15);
            this.lbl_selectway.TabIndex = 4;
            this.lbl_selectway.Text = "查询条件：";
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(13, 35);
            this.lbl_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(82, 15);
            this.lbl_select.TabIndex = 3;
            this.lbl_select.Text = "查询类型：";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(461, 26);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(61, 29);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_selectway
            // 
            this.txt_selectway.Location = new System.Drawing.Point(317, 28);
            this.txt_selectway.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectway.Name = "txt_selectway";
            this.txt_selectway.Size = new System.Drawing.Size(132, 25);
            this.txt_selectway.TabIndex = 1;
            // 
            // cb_selectkind
            // 
            this.cb_selectkind.FormattingEnabled = true;
            this.cb_selectkind.Items.AddRange(new object[] {
            "姓名",
            "性别",
            "电话"});
            this.cb_selectkind.Location = new System.Drawing.Point(100, 29);
            this.cb_selectkind.Margin = new System.Windows.Forms.Padding(4);
            this.cb_selectkind.Name = "cb_selectkind";
            this.cb_selectkind.Size = new System.Drawing.Size(125, 23);
            this.cb_selectkind.TabIndex = 0;
            this.cb_selectkind.TextChanged += new System.EventHandler(this.cb_selectkind_TextChanged);
            // 
            // F_AddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 426);
            this.Controls.Add(this.gb_dgv);
            this.Controls.Add(this.gb_use);
            this.Controls.Add(this.gb_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_AddressList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.F_AddressList_Load);
            this.gb_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addresslist)).EndInit();
            this.gb_use.ResumeLayout(false);
            this.gb_select.ResumeLayout(false);
            this.gb_select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_dgv;
        private System.Windows.Forms.DataGridView dgv_addresslist;
        private System.Windows.Forms.GroupBox gb_use;
        private System.Windows.Forms.Button btn_Aexit;
        private System.Windows.Forms.Button btn_Adelete;
        private System.Windows.Forms.Button btn_Aupdate;
        private System.Windows.Forms.Button btn_Ainsert;
        private System.Windows.Forms.GroupBox gb_select;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label lbl_selectway;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_selectway;
        private System.Windows.Forms.ComboBox cb_selectkind;
    }
}