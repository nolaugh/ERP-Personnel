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

namespace PWMS.PerForm
{
    public partial class F_AddressList : Form
    {
        public F_AddressList()
        {
            InitializeComponent();
        }

        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();
        public static DataSet MyDS_Grid;
        public static string AllSql = "Select ID,Name as 姓名,Sex as 性别,Phone as 电话,WordPhone as 工作电话,Handset as 手机, QQ as QQ号,E_Mail as 邮箱地址 from tb_AddressBook";
        public static string Find_Field = "";

        //显示数据
        public void ShowAll()
        {
            ModuleClass.MyModule.Address_ID = "";
            MyDS_Grid = MyDataClass.getDataSet(AllSql, "tb_AddressBook");
            dgv_addresslist.DataSource = MyDS_Grid.Tables[0];
            dgv_addresslist.Columns[0].Visible = false;
            if (dgv_addresslist.RowCount > 1)
            {
                btn_Aupdate.Enabled = true;
                btn_Adelete.Enabled = true;
            }
            else
            {
                btn_Aupdate.Enabled = false;
                btn_Adelete.Enabled = false;
            }
        }

        //加载
        private void F_AddressList_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            ShowAll();
        }

        //点击切换更换ID
        private void dgv_addresslist_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_addresslist.RowCount > 0)
            {
                ModuleClass.MyModule.Address_ID = dgv_addresslist[0, dgv_addresslist.CurrentCell.RowIndex].Value.ToString();
                btn_Aupdate.Enabled = true;
                btn_Adelete.Enabled = true;
            }
            else
            {
                btn_Aupdate.Enabled = true;
                btn_Adelete.Enabled = true;
            }
        }

        //combobox更改条件
        private void cb_selectkind_TextChanged(object sender, EventArgs e)
        {
            switch (((System.Windows.Forms.ComboBox)sender).SelectedIndex)
            {
                case 0:
                    {
                        Find_Field = "Name";
                        break;
                    }
                case 1:
                    {
                        Find_Field = "Sex";
                        break;
                    }
                case 2:
                    {
                        Find_Field = "Phone";
                        break;
                    }
            }
        }

        //根据combobox条件模糊查询
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (txt_selectway.Text == "")
            {
                MessageBox.Show("请输入查询条件!","提示");
                return;
            }
             ModuleClass.MyModule.Address_ID = "";
             MyDS_Grid = MyDataClass.getDataSet(AllSql + " where " + Find_Field + " like '%" + txt_selectway.Text.Trim() + "%'", "tb_AddressBook");
            dgv_addresslist.DataSource = MyDS_Grid.Tables[0];
            dgv_addresslist.Columns[0].Visible = false;
            if (dgv_addresslist.RowCount > 0)
            {
                btn_Aupdate.Enabled = true;
                btn_Adelete.Enabled = true;
            }
            else
            {
                btn_Aupdate.Enabled = false;
                btn_Adelete.Enabled = false;
            }
        }

        //显示全部
        private void btn_all_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        //添加
        private void btn_Ainsert_Click(object sender, EventArgs e)
        {
            SecondaryForm.F_Address FrmAddress = new PWMS.SecondaryForm.F_Address();
            FrmAddress.Text = "通讯录添加操作";
            FrmAddress.Tag = 1;
            FrmAddress.ShowDialog(this);
            ShowAll();
        }

        //更新
        private void btn_Aupdate_Click(object sender, EventArgs e)
        {
            SecondaryForm.F_Address FrmAddress = new PWMS.SecondaryForm.F_Address();
            FrmAddress.Text = "通讯录修改操作";
            FrmAddress.Tag = 2;
            FrmAddress.ShowDialog(this);
            ShowAll();
        }

        //删除
        private void btn_Adelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
            if (dgv_addresslist.CurrentRow.Index == 0)
            {
                MessageBox.Show("首条记录无法删除！", "提示");
                return;
            }

            if (dgv_addresslist.CurrentRow.Index != dgv_addresslist.Rows.Count - 1)
            {
                MessageBox.Show("无法从中删除，请选择修改！", "提示");
                return;
            }

            if (dgv_addresslist.RowCount < 2)
            {
                MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                return;
            }
            else
            {
                if (result == DialogResult.OK)
                {
                    MyDataClass.getsqlcom("Delete tb_AddressBook where ID='" + ModuleClass.MyModule.Address_ID + "'");
                    ShowAll();
                }
                else
                {
                    MessageBox.Show("您选择了取消删除！", "提示");
                }
            }
        }

        //退出
        private void btn_Aexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
