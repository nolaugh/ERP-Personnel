namespace PWMS.PerForm
{
    partial class F_Stat
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
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.gb_rule = new System.Windows.Forms.GroupBox();
            this.lb_rule = new System.Windows.Forms.ListBox();
            this.gb_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.gb_rule.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_result
            // 
            this.gb_result.Controls.Add(this.dgv_result);
            this.gb_result.Location = new System.Drawing.Point(288, 5);
            this.gb_result.Margin = new System.Windows.Forms.Padding(4);
            this.gb_result.Name = "gb_result";
            this.gb_result.Padding = new System.Windows.Forms.Padding(4);
            this.gb_result.Size = new System.Drawing.Size(267, 431);
            this.gb_result.TabIndex = 3;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "统计结果";
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.AllowUserToResizeRows = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(12, 28);
            this.dgv_result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.RowTemplate.Height = 23;
            this.dgv_result.RowTemplate.ReadOnly = true;
            this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_result.Size = new System.Drawing.Size(243, 395);
            this.dgv_result.TabIndex = 0;
            // 
            // gb_rule
            // 
            this.gb_rule.Controls.Add(this.lb_rule);
            this.gb_rule.Location = new System.Drawing.Point(13, 5);
            this.gb_rule.Margin = new System.Windows.Forms.Padding(4);
            this.gb_rule.Name = "gb_rule";
            this.gb_rule.Padding = new System.Windows.Forms.Padding(4);
            this.gb_rule.Size = new System.Drawing.Size(267, 431);
            this.gb_rule.TabIndex = 2;
            this.gb_rule.TabStop = false;
            this.gb_rule.Text = "统计条件";
            // 
            // lb_rule
            // 
            this.lb_rule.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_rule.FormattingEnabled = true;
            this.lb_rule.ItemHeight = 15;
            this.lb_rule.Location = new System.Drawing.Point(12, 28);
            this.lb_rule.Margin = new System.Windows.Forms.Padding(4);
            this.lb_rule.Name = "lb_rule";
            this.lb_rule.Size = new System.Drawing.Size(241, 394);
            this.lb_rule.TabIndex = 0;
            this.lb_rule.SelectedIndexChanged += new System.EventHandler(this.lb_rule_SelectedIndexChanged);
            // 
            // F_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 442);
            this.Controls.Add(this.gb_result);
            this.Controls.Add(this.gb_rule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事资料统计";
            this.Load += new System.EventHandler(this.F_Stat_Load);
            this.gb_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.gb_rule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_result;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.GroupBox gb_rule;
        private System.Windows.Forms.ListBox lb_rule;
    }
}