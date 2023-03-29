namespace PWMS.PerForm
{
    partial class F_ClewSet
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
            this.checkb_message = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gb_message = new System.Windows.Forms.GroupBox();
            this.nud_day = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_former = new System.Windows.Forms.Label();
            this.gb_message_people = new System.Windows.Forms.GroupBox();
            this.dgv_people = new System.Windows.Forms.DataGridView();
            this.col_StuffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).BeginInit();
            this.gb_message_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).BeginInit();
            this.SuspendLayout();
            // 
            // checkb_message
            // 
            this.checkb_message.AutoSize = true;
            this.checkb_message.Location = new System.Drawing.Point(20, 119);
            this.checkb_message.Margin = new System.Windows.Forms.Padding(4);
            this.checkb_message.Name = "checkb_message";
            this.checkb_message.Size = new System.Drawing.Size(104, 19);
            this.checkb_message.TabIndex = 7;
            this.checkb_message.Text = "应用提示框";
            this.checkb_message.UseVisualStyleBackColor = true;
            this.checkb_message.CheckedChanged += new System.EventHandler(this.checkb_message_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(260, 113);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(72, 29);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(159, 113);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 29);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gb_message
            // 
            this.gb_message.Controls.Add(this.nud_day);
            this.gb_message.Controls.Add(this.label2);
            this.gb_message.Controls.Add(this.lbl_former);
            this.gb_message.Enabled = false;
            this.gb_message.Location = new System.Drawing.Point(13, 13);
            this.gb_message.Margin = new System.Windows.Forms.Padding(4);
            this.gb_message.Name = "gb_message";
            this.gb_message.Padding = new System.Windows.Forms.Padding(4);
            this.gb_message.Size = new System.Drawing.Size(328, 92);
            this.gb_message.TabIndex = 4;
            this.gb_message.TabStop = false;
            this.gb_message.Text = "设置提示时间";
            // 
            // nud_day
            // 
            this.nud_day.Location = new System.Drawing.Point(97, 44);
            this.nud_day.Margin = new System.Windows.Forms.Padding(4);
            this.nud_day.Name = "nud_day";
            this.nud_day.Size = new System.Drawing.Size(163, 25);
            this.nud_day.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "天";
            // 
            // lbl_former
            // 
            this.lbl_former.AutoSize = true;
            this.lbl_former.Location = new System.Drawing.Point(35, 51);
            this.lbl_former.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_former.Name = "lbl_former";
            this.lbl_former.Size = new System.Drawing.Size(52, 15);
            this.lbl_former.TabIndex = 2;
            this.lbl_former.Text = "提前：";
            // 
            // gb_message_people
            // 
            this.gb_message_people.Controls.Add(this.dgv_people);
            this.gb_message_people.Enabled = false;
            this.gb_message_people.Location = new System.Drawing.Point(13, 150);
            this.gb_message_people.Margin = new System.Windows.Forms.Padding(4);
            this.gb_message_people.Name = "gb_message_people";
            this.gb_message_people.Padding = new System.Windows.Forms.Padding(4);
            this.gb_message_people.Size = new System.Drawing.Size(328, 313);
            this.gb_message_people.TabIndex = 8;
            this.gb_message_people.TabStop = false;
            this.gb_message_people.Text = "人员查看";
            // 
            // dgv_people
            // 
            this.dgv_people.AllowUserToAddRows = false;
            this.dgv_people.AllowUserToDeleteRows = false;
            this.dgv_people.AllowUserToResizeColumns = false;
            this.dgv_people.AllowUserToResizeRows = false;
            this.dgv_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_StuffName,
            this.col_day});
            this.dgv_people.Location = new System.Drawing.Point(7, 25);
            this.dgv_people.Name = "dgv_people";
            this.dgv_people.RowHeadersVisible = false;
            this.dgv_people.RowHeadersWidth = 51;
            this.dgv_people.RowTemplate.Height = 27;
            this.dgv_people.Size = new System.Drawing.Size(314, 281);
            this.dgv_people.TabIndex = 0;
            // 
            // col_StuffName
            // 
            this.col_StuffName.DataPropertyName = "StuffName";
            this.col_StuffName.HeaderText = "员工姓名";
            this.col_StuffName.MinimumWidth = 6;
            this.col_StuffName.Name = "col_StuffName";
            this.col_StuffName.Width = 125;
            // 
            // col_day
            // 
            this.col_day.DataPropertyName = "Pact_E";
            this.col_day.HeaderText = "合同到期时间";
            this.col_day.MinimumWidth = 6;
            this.col_day.Name = "col_day";
            this.col_day.Width = 214;
            // 
            // F_ClewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 476);
            this.Controls.Add(this.gb_message_people);
            this.Controls.Add(this.checkb_message);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_ClewSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工合同提示";
            this.Load += new System.EventHandler(this.F_ClewSet_Load);
            this.gb_message.ResumeLayout(false);
            this.gb_message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).EndInit();
            this.gb_message_people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkb_message;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox gb_message;
        private System.Windows.Forms.NumericUpDown nud_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_former;
        private System.Windows.Forms.GroupBox gb_message_people;
        private System.Windows.Forms.DataGridView dgv_people;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StuffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_day;
    }
}