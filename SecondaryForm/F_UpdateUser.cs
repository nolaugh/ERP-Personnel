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
    public partial class F_UpdateUser : Form
    {
        public F_UpdateUser()
        {
            InitializeComponent();
        }

        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();
        public DataSet DSet;

        //加载
        private void F_UpdateUser_Load(object sender, EventArgs e)
        {
             this.MaximizeBox = false;
             string Name = ModuleClass.MyModule.User_Name;
             DSet = MyDataClass.getDataSet("select Name,Pass from tb_Login where Name='" + Name + "'", "tb_Login");
            text_Name.Text = Convert.ToString(DSet.Tables[0].Rows[0][0]);
            text_Pass.Text = Convert.ToString(DSet.Tables[0].Rows[0][1]);
        }

        //保存
        private void btn_save_Click(object sender, EventArgs e)
        {
            string Name = ModuleClass.MyModule.User_Name;
            MyDataClass.getsqlcom("update tb_Login set Name='" + text_Name.Text + "',Pass='" + text_Pass.Text + "' where Name='" + Name + "'");
            MyDataClass.getsqlcom("update tb_UserPope set PopeName='" + text_Name.Text + "' " + "where PopeName='" + Name + "'");
            MessageBox.Show("修改成功！");
            this.Close();
        }

        //关闭
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
