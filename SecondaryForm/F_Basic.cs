using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PWMS.SecondaryForm
{
    public partial class F_Basic : Form
    {
        public F_Basic()
        {
            InitializeComponent();
        }

        DataClass.MyMeans MyDClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyModule = new ModuleClass.MyModule();
        public static string reField = "";  //记录要修改的字段
        public static int indvar = -1;
        public static int B_Save = 0;

        //加载
        private void F_Basic_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            lb_basic.Items.Clear();
            DataSet My_Set = MyDClass.getDataSet(DataClass.MyMeans.Mean_SQL, DataClass.MyMeans.Mean_Table);
            if (My_Set.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < My_Set.Tables[0].Rows.Count; i++)
                {
                    lb_basic.Items.Add(My_Set.Tables[0].Rows[i][1].ToString());
                }
            }
            btn_Bcancel.Enabled = false;
            btn_Bsave.Enabled = false;
        }

        //数据切换
        private void lb_basic_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_change.Text = lb_basic.Text;
            if (lb_basic.SelectedIndex >= 0)
            {
                reField = lb_basic.SelectedItem.ToString();
                indvar = lb_basic.SelectedIndex;
            }
        }

        //添加
        private void btn_Binsert_Click(object sender, EventArgs e)
        {
            txt_change.Text = "";
            MyModule.Ena_Button(btn_Binsert, btn_Bupdate, btn_Bdelete, btn_Bcancel, 0, 0, 0, 1);
            btn_Bsave.Enabled = true;
            gb_basic.Enabled = false;
            B_Save = 1;
        }

        //更新
        private void btn_Bupdate_Click(object sender, EventArgs e)
        {
            if (txt_change.Text.Trim() == "")
            {
                MessageBox.Show("请选择一个数据进行修改！", "提示");
            }
            else
            {
                MyModule.Ena_Button(btn_Binsert, btn_Bupdate, btn_Bdelete, btn_Bcancel, 0, 0, 0, 1);
                btn_Bsave.Enabled = true;
                gb_basic.Enabled = false;
                B_Save = 2;
            }
        }

        //删除
        private void btn_Bdelete_Click(object sender, EventArgs e)
        {
            if (reField != "" & indvar >= 0)
            {
                MyDClass.getsqlcom("delete from " + DataClass.MyMeans.Mean_Table.Trim() + " where " + DataClass.MyMeans.Mean_Field.Trim() + "='" + reField + "'");
                lb_basic.Items.Remove(lb_basic.Items[lb_basic.SelectedIndex]);
                lb_basic.SelectedIndex = -1;
            }
            btn_Bcancel_Click(sender, e);
        }

        //取消
        private void btn_Bcancel_Click(object sender, EventArgs e)
        {
            txt_change.Text = "";
            MyModule.Ena_Button(btn_Binsert, btn_Bupdate, btn_Bdelete, btn_Bcancel, 1, 1, 1, 1);
            gb_basic.Enabled = true;
            F_Basic_Load(sender, e);
        }

        //保存
        private void btn_Bsave_Click(object sender, EventArgs e)
        {
            if (B_Save == 1)
            {
                bool t = false;
                string temField = "";
                if (txt_change.Text != "")
                {
                    temField = txt_change.Text.Trim();
                    SqlDataReader temDR = MyDClass.getcom("select * from " + DataClass.MyMeans.Mean_Table.Trim() + " where " + DataClass.MyMeans.Mean_Field.Trim() + "='" + temField + "'");
                    t = temDR.Read();
                    if (t == false)
                    {
                        MyDClass.getsqlcom("insert into " + DataClass.MyMeans.Mean_Table.Trim() + "(" + DataClass.MyMeans.Mean_Field.Trim() + ") values(" + "'" + temField + "'" + ")");
                        lb_basic.Items.Add(txt_change.Text.Trim());
                        txt_change.Text = "";
                        btn_Bcancel_Click(sender, e);
                        MessageBox.Show("保存成功", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("请输入要添加的数据", "提示");
                }
            }

            if (B_Save == 2)
            {
                bool t = false;
                string temField = "";
                if (txt_change.Text != "")
                {
                    temField = txt_change.Text.Trim();
                    SqlDataReader temDR = MyDClass.getcom("select * from " + DataClass.MyMeans.Mean_Table.Trim() + " where " + DataClass.MyMeans.Mean_Field.Trim() + "='" + reField + "'");
                    t = temDR.Read();
                    if (t == true)
                    {
                        temField = temDR[0].ToString();
                        MyDClass.getsqlcom("update " + DataClass.MyMeans.Mean_Table.Trim() + " set " + DataClass.MyMeans.Mean_Field.Trim() + "='" + txt_change.Text.Trim() + "' where ID='" + temField + "'");
                        if (indvar >= 0)
                            lb_basic.Items[indvar] = (txt_change.Text.Trim());
                        txt_change.Text = "";
                        btn_Bcancel_Click(sender, e);
                        MessageBox.Show("修改成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("请选择要修改的数据", "提示");
                    }
                }
            }
        }
    }
}

