using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PWMS.PerForm
{
    public partial class F_WordPad : Form
    {
        public F_WordPad()
        {
            InitializeComponent();
        }

        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        public static string AllSql = "select ID,BlotterDate as 记事时间,BlotterSort as 记事类别,Motif as 主题,Wordpad from tb_DayWordPad";
        public static DataSet MyDS_Grid;  //存储数据表信息
        public static string Word_ID = "";  //存储添加信息时的自动编号
        public static int Word_S = 0;

        //加载
        private void F_WordPad_Load(object sender, EventArgs e)
        {
            WordPad_1.Enabled = false;
            dtp_time.Value = DateTime.Today;
            MyDS_Grid = MyDataClass.getDataSet(AllSql, "tb_DayWordPad");
            dgv_information.DataSource = MyDS_Grid.Tables[0];
            for (int i = 1; i < 4; i++)
            {
                dgv_information.Columns[i].Width = 125;
            }
            //隐藏dataGridView1控件中不需要的列字段
            dgv_information.Columns[0].Visible = false;
            dgv_information.Columns[4].Visible = false;

            MyMC.CbbData(cb_kind, "tb_WordPad");
            MyMC.CbbData(WordPad_2, "tb_WordPad");

            
            MyMC.allreadonly_work(gb_word.Controls,4,false);
            MyMC.Ena_Button(btn_Winsert, btn_Wupdate, btn_Wcancel, btn_Wsave, 1, 1, 0, 0);
        }

        //点击切换数据
        private void dgv_information_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_information.RowCount > 0)
            {
                try
                {
                    Word_ID = dgv_information[0, dgv_information.CurrentCell.RowIndex].Value.ToString();
                    WordPad_1.Value = Convert.ToDateTime(dgv_information[1, dgv_information.CurrentCell.RowIndex].Value.ToString());
                    WordPad_2.Text = dgv_information[2, dgv_information.CurrentCell.RowIndex].Value.ToString();
                    WordPad_3.Text = dgv_information[3, dgv_information.CurrentCell.RowIndex].Value.ToString();
                    WordPad_4.Text = dgv_information[4, dgv_information.CurrentCell.RowIndex].Value.ToString();
                }
                catch
                {
                    WordPad_2.Text = "";
                    WordPad_3.Text = "";
                    WordPad_4.Text = "";
                    Word_ID = "";
                }
            }
            else
            {
                MyMC.Clear_Control(gb_word.Controls);
                Word_ID = "";
                WordPad_1.Value = Convert.ToDateTime(System.DateTime.Now.ToString());
            }
        }

        //查询
        private void btn_select_Click(object sender, EventArgs e)
        {
            WordPad_1.Enabled = false;
            string Fing_Sql = "";
            if (checkb_time.Checked == true)
            {
                Fing_Sql = " (BlotterDate = '" + MyMC.Date_Format(dtp_time.Text) + "')";
            }
            if (checkb__kind.Checked == true)
            {
                if ((cb_kind.Text.Trim()).Length == 0)
                {
                    MessageBox.Show("请添写查询条件。");
                    return;
                }
                else
                {
                    if (Fing_Sql == "")
                    {
                        Fing_Sql = "(BlotterSort = '" + cb_kind.Text + "')";
                    }
                    else
                    {
                        Fing_Sql = Fing_Sql + " AND " + " (BlotterSort = '" + cb_kind.Text + "')";
                    }
                }
                if (Fing_Sql != "")
                    Fing_Sql = AllSql + " where " + Fing_Sql;
                else
                    Fing_Sql = AllSql;
                MyDS_Grid = MyDataClass.getDataSet(Fing_Sql, "tb_DayWordPad");
                dgv_information.DataSource = MyDS_Grid.Tables[0];
                checkb_all.Checked = false;
                if (MyDS_Grid.Tables[0].Rows.Count < 1) //如果查询结果为空，清除相关文本
                {
                    Word_ID = "";
                    WordPad_2.Text = "";
                    WordPad_3.Text = "";
                    WordPad_4.Text = "";  
                }
            }
        }

        //显示全部
        private void checkb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_all.Checked == true)
            {
                MyDS_Grid = MyDataClass.getDataSet(AllSql, "tb_DayWordPad");
                dgv_information.DataSource = MyDS_Grid.Tables[0];
            }
        }

        //添加
        private void btn_Winsert_Click(object sender, EventArgs e)
        {
            Word_S = 1;
            MyMC.Clear_Control(gb_word.Controls);
            WordPad_1.Value = Convert.ToDateTime(System.DateTime.Now.ToString());
            Word_ID = MyMC.GetAutocoding("tb_DayWordPad", "ID");  //自动添加编号;
            MyMC.allreadonly_work(gb_word.Controls, 4, true);
            WordPad_1.Enabled = true;
            dgv_information.Enabled = false;
            btn_Wdelete.Enabled = false;
            checkb_all.Enabled = false;
            gb_select.Enabled = false;
            MyMC.Ena_Button(btn_Winsert, btn_Wupdate, btn_Wcancel, btn_Wsave, 0, 0, 1, 1);
        }

        //修改
        private void btn_Wupdate_Click(object sender, EventArgs e)
        {
            if (dgv_information.Rows.Count > 0)
            {
                Word_S = 2;
                MyMC.allreadonly_work(gb_word.Controls, 4, true);
                WordPad_1.Enabled = true;
                dgv_information.Enabled = false;
                btn_Wdelete.Enabled = false;
                checkb_all.Enabled = false;
                gb_select.Enabled = false;
                MyMC.Ena_Button(btn_Winsert, btn_Wupdate, btn_Wcancel, btn_Wsave, 0, 0, 1, 1);
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }

        }

        //删除
        private void btn_Wdelete_Click(object sender, EventArgs e)
        {
            if (dgv_information.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_information.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    return;
                }

                if (dgv_information.CurrentRow.Index != dgv_information.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");

                    return;
                }

                if (dgv_information.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("删除成功！", "提示");
                        MyDataClass.getsqlcom("Delete tb_DayWordPad where ID='" + Word_ID + "'");
                        btn_Wcancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
            
        }

        //取消
        private void btn_Wcancel_Click(object sender, EventArgs e)
        {
            Word_S = 0;
            MyMC.Ena_Button(btn_Winsert, btn_Wupdate, btn_Wcancel, btn_Wsave, 1, 1, 0, 0);
            MyMC.allreadonly_work(gb_word.Controls, 4, false);
            btn_Wdelete.Enabled = true;
            dgv_information.Enabled = true;
            if (checkb_time.Checked==false&&checkb__kind.Checked==false)
            {
                MyDS_Grid = MyDataClass.getDataSet(AllSql, "tb_DayWordPad");
                dgv_information.DataSource = MyDS_Grid.Tables[0];
                checkb_all.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
               btn_select_Click(sender, e);
                gb_select.Enabled=true;
                checkb_all.Enabled=true;
            }
        }
    }
}
