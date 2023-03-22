using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS.SecondaryForm
{
    public partial class F_Address : Form
    {
        public F_Address()
        {
            InitializeComponent();
        }

        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();
        public static DataSet MyDS_Grid;
        public static string Address_ID = "";

        //加载
        private void F_Address_Load(object sender, EventArgs e)
        {
            if ((int)(this.Tag) == 1)
            {
                Address_ID = MyMC.GetAutocoding("tb_AddressBook", "ID");
            }
            if ((int)this.Tag == 2)
            {
                MyDS_Grid = MyDataClass.getDataSet("select ID,Name,Sex,Phone,Handset,WordPhone,QQ,E_Mail from tb_AddressBook where ID='" + ModuleClass.MyModule.Address_ID + "'", "tb_AddressBook");
                Address_ID = MyDS_Grid.Tables[0].Rows[0][0].ToString();
                this.CT_1.Text = MyDS_Grid.Tables[0].Rows[0][1].ToString();
                this.CT_2.Text = MyDS_Grid.Tables[0].Rows[0][2].ToString();
                this.CT_3.Text = MyDS_Grid.Tables[0].Rows[0][3].ToString();
                this.CT_4.Text = MyDS_Grid.Tables[0].Rows[0][4].ToString();
                this.CT_5.Text = MyDS_Grid.Tables[0].Rows[0][5].ToString();
                this.CT_6.Text = MyDS_Grid.Tables[0].Rows[0][6].ToString();
                this.CT_7.Text = MyDS_Grid.Tables[0].Rows[0][7].ToString();

            }
        }

        //保存
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.CT_1.Text != "")
            {
                MyMC.Part_SaveClass("ID,Name,Sex,Phone,Handset,WordPhone,QQ,E_Mail", Address_ID, "", this.gb_connect.Controls, "CT_", "tb_AddressBook", 8, (int)this.Tag);
                MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                this.Close();
            }
            else
            { MessageBox.Show("人员姓名不能为空。"); }
                
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
