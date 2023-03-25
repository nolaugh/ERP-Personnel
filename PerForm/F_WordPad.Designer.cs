namespace PWMS.PerForm
{
    partial class F_WordPad
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
            this.btn_Wsave = new System.Windows.Forms.Button();
            this.btn_Wcancel = new System.Windows.Forms.Button();
            this.btn_Wdelete = new System.Windows.Forms.Button();
            this.btn_Wupdate = new System.Windows.Forms.Button();
            this.btn_Winsert = new System.Windows.Forms.Button();
            this.gb_word = new System.Windows.Forms.GroupBox();
            this.lbl_main = new System.Windows.Forms.Label();
            this.lbl_include = new System.Windows.Forms.Label();
            this.lbl_kind = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.WordPad_4 = new System.Windows.Forms.TextBox();
            this.WordPad_3 = new System.Windows.Forms.TextBox();
            this.WordPad_2 = new System.Windows.Forms.ComboBox();
            this.WordPad_1 = new System.Windows.Forms.DateTimePicker();
            this.gb_information = new System.Windows.Forms.GroupBox();
            this.checkb_all = new System.Windows.Forms.CheckBox();
            this.dgv_information = new System.Windows.Forms.DataGridView();
            this.gb_select = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cb_kind = new System.Windows.Forms.ComboBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.checkb__kind = new System.Windows.Forms.CheckBox();
            this.checkb_time = new System.Windows.Forms.CheckBox();
            this.gb_use.SuspendLayout();
            this.gb_word.SuspendLayout();
            this.gb_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_information)).BeginInit();
            this.gb_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_use
            // 
            this.gb_use.Controls.Add(this.btn_Wsave);
            this.gb_use.Controls.Add(this.btn_Wcancel);
            this.gb_use.Controls.Add(this.btn_Wdelete);
            this.gb_use.Controls.Add(this.btn_Wupdate);
            this.gb_use.Controls.Add(this.btn_Winsert);
            this.gb_use.Location = new System.Drawing.Point(497, 436);
            this.gb_use.Margin = new System.Windows.Forms.Padding(4);
            this.gb_use.Name = "gb_use";
            this.gb_use.Padding = new System.Windows.Forms.Padding(4);
            this.gb_use.Size = new System.Drawing.Size(447, 62);
            this.gb_use.TabIndex = 7;
            this.gb_use.TabStop = false;
            this.gb_use.Text = "操作";
            // 
            // btn_Wsave
            // 
            this.btn_Wsave.Location = new System.Drawing.Point(347, 22);
            this.btn_Wsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Wsave.Name = "btn_Wsave";
            this.btn_Wsave.Size = new System.Drawing.Size(71, 29);
            this.btn_Wsave.TabIndex = 4;
            this.btn_Wsave.Text = "保存";
            this.btn_Wsave.UseVisualStyleBackColor = true;
            this.btn_Wsave.Click += new System.EventHandler(this.btn_Wsave_Click);
            // 
            // btn_Wcancel
            // 
            this.btn_Wcancel.Location = new System.Drawing.Point(268, 22);
            this.btn_Wcancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Wcancel.Name = "btn_Wcancel";
            this.btn_Wcancel.Size = new System.Drawing.Size(71, 29);
            this.btn_Wcancel.TabIndex = 3;
            this.btn_Wcancel.Text = "取消";
            this.btn_Wcancel.UseVisualStyleBackColor = true;
            this.btn_Wcancel.Click += new System.EventHandler(this.btn_Wcancel_Click);
            // 
            // btn_Wdelete
            // 
            this.btn_Wdelete.Location = new System.Drawing.Point(189, 22);
            this.btn_Wdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Wdelete.Name = "btn_Wdelete";
            this.btn_Wdelete.Size = new System.Drawing.Size(71, 29);
            this.btn_Wdelete.TabIndex = 2;
            this.btn_Wdelete.Text = "删除";
            this.btn_Wdelete.UseVisualStyleBackColor = true;
            this.btn_Wdelete.Click += new System.EventHandler(this.btn_Wdelete_Click);
            // 
            // btn_Wupdate
            // 
            this.btn_Wupdate.Location = new System.Drawing.Point(111, 22);
            this.btn_Wupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Wupdate.Name = "btn_Wupdate";
            this.btn_Wupdate.Size = new System.Drawing.Size(71, 29);
            this.btn_Wupdate.TabIndex = 1;
            this.btn_Wupdate.Text = "修改";
            this.btn_Wupdate.UseVisualStyleBackColor = true;
            this.btn_Wupdate.Click += new System.EventHandler(this.btn_Wupdate_Click);
            // 
            // btn_Winsert
            // 
            this.btn_Winsert.Location = new System.Drawing.Point(32, 22);
            this.btn_Winsert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Winsert.Name = "btn_Winsert";
            this.btn_Winsert.Size = new System.Drawing.Size(71, 29);
            this.btn_Winsert.TabIndex = 0;
            this.btn_Winsert.Text = "添加";
            this.btn_Winsert.UseVisualStyleBackColor = true;
            this.btn_Winsert.Click += new System.EventHandler(this.btn_Winsert_Click);
            // 
            // gb_word
            // 
            this.gb_word.Controls.Add(this.lbl_main);
            this.gb_word.Controls.Add(this.lbl_include);
            this.gb_word.Controls.Add(this.lbl_kind);
            this.gb_word.Controls.Add(this.lbl_time);
            this.gb_word.Controls.Add(this.WordPad_4);
            this.gb_word.Controls.Add(this.WordPad_3);
            this.gb_word.Controls.Add(this.WordPad_2);
            this.gb_word.Controls.Add(this.WordPad_1);
            this.gb_word.Location = new System.Drawing.Point(497, 94);
            this.gb_word.Margin = new System.Windows.Forms.Padding(4);
            this.gb_word.Name = "gb_word";
            this.gb_word.Padding = new System.Windows.Forms.Padding(4);
            this.gb_word.Size = new System.Drawing.Size(447, 334);
            this.gb_word.TabIndex = 6;
            this.gb_word.TabStop = false;
            this.gb_word.Text = "记事本内容";
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Location = new System.Drawing.Point(13, 101);
            this.lbl_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(84, 15);
            this.lbl_main.TabIndex = 7;
            this.lbl_main.Text = "主    题：";
            // 
            // lbl_include
            // 
            this.lbl_include.AutoSize = true;
            this.lbl_include.Location = new System.Drawing.Point(12, 131);
            this.lbl_include.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_include.Name = "lbl_include";
            this.lbl_include.Size = new System.Drawing.Size(52, 15);
            this.lbl_include.TabIndex = 6;
            this.lbl_include.Text = "内容：";
            // 
            // lbl_kind
            // 
            this.lbl_kind.AutoSize = true;
            this.lbl_kind.Location = new System.Drawing.Point(13, 68);
            this.lbl_kind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kind.Name = "lbl_kind";
            this.lbl_kind.Size = new System.Drawing.Size(82, 15);
            this.lbl_kind.TabIndex = 5;
            this.lbl_kind.Text = "记事类别：";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(13, 34);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(82, 15);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "记事时间：";
            // 
            // WordPad_4
            // 
            this.WordPad_4.Location = new System.Drawing.Point(15, 154);
            this.WordPad_4.Margin = new System.Windows.Forms.Padding(4);
            this.WordPad_4.Multiline = true;
            this.WordPad_4.Name = "WordPad_4";
            this.WordPad_4.Size = new System.Drawing.Size(417, 164);
            this.WordPad_4.TabIndex = 3;
            // 
            // WordPad_3
            // 
            this.WordPad_3.Location = new System.Drawing.Point(103, 95);
            this.WordPad_3.Margin = new System.Windows.Forms.Padding(4);
            this.WordPad_3.Name = "WordPad_3";
            this.WordPad_3.Size = new System.Drawing.Size(329, 25);
            this.WordPad_3.TabIndex = 2;
            // 
            // WordPad_2
            // 
            this.WordPad_2.FormattingEnabled = true;
            this.WordPad_2.Location = new System.Drawing.Point(103, 61);
            this.WordPad_2.Margin = new System.Windows.Forms.Padding(4);
            this.WordPad_2.Name = "WordPad_2";
            this.WordPad_2.Size = new System.Drawing.Size(162, 23);
            this.WordPad_2.TabIndex = 1;
            // 
            // WordPad_1
            // 
            this.WordPad_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.WordPad_1.Location = new System.Drawing.Point(103, 28);
            this.WordPad_1.Margin = new System.Windows.Forms.Padding(4);
            this.WordPad_1.Name = "WordPad_1";
            this.WordPad_1.Size = new System.Drawing.Size(162, 25);
            this.WordPad_1.TabIndex = 0;
            // 
            // gb_information
            // 
            this.gb_information.Controls.Add(this.checkb_all);
            this.gb_information.Controls.Add(this.dgv_information);
            this.gb_information.Location = new System.Drawing.Point(13, 94);
            this.gb_information.Margin = new System.Windows.Forms.Padding(4);
            this.gb_information.Name = "gb_information";
            this.gb_information.Padding = new System.Windows.Forms.Padding(4);
            this.gb_information.Size = new System.Drawing.Size(476, 399);
            this.gb_information.TabIndex = 5;
            this.gb_information.TabStop = false;
            this.gb_information.Text = "信息表";
            // 
            // checkb_all
            // 
            this.checkb_all.AutoSize = true;
            this.checkb_all.Location = new System.Drawing.Point(187, 374);
            this.checkb_all.Margin = new System.Windows.Forms.Padding(4);
            this.checkb_all.Name = "checkb_all";
            this.checkb_all.Size = new System.Drawing.Size(89, 19);
            this.checkb_all.TabIndex = 1;
            this.checkb_all.Text = "全部显示";
            this.checkb_all.UseVisualStyleBackColor = true;
            this.checkb_all.CheckedChanged += new System.EventHandler(this.checkb_all_CheckedChanged);
            // 
            // dgv_information
            // 
            this.dgv_information.AllowUserToAddRows = false;
            this.dgv_information.AllowUserToDeleteRows = false;
            this.dgv_information.AllowUserToResizeRows = false;
            this.dgv_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_information.Location = new System.Drawing.Point(13, 30);
            this.dgv_information.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_information.Name = "dgv_information";
            this.dgv_information.ReadOnly = true;
            this.dgv_information.RowHeadersVisible = false;
            this.dgv_information.RowHeadersWidth = 51;
            this.dgv_information.RowTemplate.Height = 23;
            this.dgv_information.RowTemplate.ReadOnly = true;
            this.dgv_information.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_information.Size = new System.Drawing.Size(450, 334);
            this.dgv_information.TabIndex = 0;
            this.dgv_information.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_information_CellEnter);
            // 
            // gb_select
            // 
            this.gb_select.Controls.Add(this.btn_select);
            this.gb_select.Controls.Add(this.cb_kind);
            this.gb_select.Controls.Add(this.dtp_time);
            this.gb_select.Controls.Add(this.checkb__kind);
            this.gb_select.Controls.Add(this.checkb_time);
            this.gb_select.Location = new System.Drawing.Point(13, 13);
            this.gb_select.Margin = new System.Windows.Forms.Padding(4);
            this.gb_select.Name = "gb_select";
            this.gb_select.Padding = new System.Windows.Forms.Padding(4);
            this.gb_select.Size = new System.Drawing.Size(931, 70);
            this.gb_select.TabIndex = 4;
            this.gb_select.TabStop = false;
            this.gb_select.Text = "查询";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(684, 20);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 29);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cb_kind
            // 
            this.cb_kind.FormattingEnabled = true;
            this.cb_kind.Location = new System.Drawing.Point(506, 24);
            this.cb_kind.Margin = new System.Windows.Forms.Padding(4);
            this.cb_kind.Name = "cb_kind";
            this.cb_kind.Size = new System.Drawing.Size(139, 23);
            this.cb_kind.TabIndex = 3;
            // 
            // dtp_time
            // 
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(229, 21);
            this.dtp_time.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(166, 25);
            this.dtp_time.TabIndex = 2;
            this.dtp_time.Value = new System.DateTime(2008, 3, 18, 0, 0, 0, 0);
            // 
            // checkb__kind
            // 
            this.checkb__kind.AutoSize = true;
            this.checkb__kind.Location = new System.Drawing.Point(409, 26);
            this.checkb__kind.Margin = new System.Windows.Forms.Padding(4);
            this.checkb__kind.Name = "checkb__kind";
            this.checkb__kind.Size = new System.Drawing.Size(89, 19);
            this.checkb__kind.TabIndex = 1;
            this.checkb__kind.Text = "记事类别";
            this.checkb__kind.UseVisualStyleBackColor = true;
            // 
            // checkb_time
            // 
            this.checkb_time.AutoSize = true;
            this.checkb_time.Location = new System.Drawing.Point(132, 26);
            this.checkb_time.Margin = new System.Windows.Forms.Padding(4);
            this.checkb_time.Name = "checkb_time";
            this.checkb_time.Size = new System.Drawing.Size(89, 19);
            this.checkb_time.TabIndex = 0;
            this.checkb_time.Text = "记事时间";
            this.checkb_time.UseVisualStyleBackColor = true;
            // 
            // F_WordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 500);
            this.Controls.Add(this.gb_use);
            this.Controls.Add(this.gb_word);
            this.Controls.Add(this.gb_information);
            this.Controls.Add(this.gb_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_WordPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.F_WordPad_Load);
            this.gb_use.ResumeLayout(false);
            this.gb_word.ResumeLayout(false);
            this.gb_word.PerformLayout();
            this.gb_information.ResumeLayout(false);
            this.gb_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_information)).EndInit();
            this.gb_select.ResumeLayout(false);
            this.gb_select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_use;
        private System.Windows.Forms.Button btn_Wsave;
        private System.Windows.Forms.Button btn_Wcancel;
        private System.Windows.Forms.Button btn_Wdelete;
        private System.Windows.Forms.Button btn_Wupdate;
        private System.Windows.Forms.Button btn_Winsert;
        private System.Windows.Forms.GroupBox gb_word;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Label lbl_include;
        private System.Windows.Forms.Label lbl_kind;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox WordPad_4;
        private System.Windows.Forms.TextBox WordPad_3;
        private System.Windows.Forms.ComboBox WordPad_2;
        private System.Windows.Forms.DateTimePicker WordPad_1;
        private System.Windows.Forms.GroupBox gb_information;
        private System.Windows.Forms.CheckBox checkb_all;
        private System.Windows.Forms.DataGridView dgv_information;
        private System.Windows.Forms.GroupBox gb_select;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cb_kind;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.CheckBox checkb__kind;
        private System.Windows.Forms.CheckBox checkb_time;
    }
}