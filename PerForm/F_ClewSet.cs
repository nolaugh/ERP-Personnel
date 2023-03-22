using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PWMS.PerForm
{
    public partial class F_ClewSet : Form
    {
        public F_ClewSet()
        {
            InitializeComponent();
        }
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        public static DataSet MyDS_Grid;

        private void F_ClewSet_Load(object sender, EventArgs e)
        {
            DataSet DSet = MyDataClass.getDataSet("select Fate from tb_Clew", "tb_clew");
            int sday = Convert.ToInt32(DSet.Tables[0].Rows[0][0]);
            nud_day.Value = sday;
            MyDS_Grid = MyDataClass.getDataSet("select * from tb_Stuffbasic where ((getdate()-convert(Nvarchar(12), Pact_E ,110))>=-" + sday + " and(getdate() - convert(Nvarchar(12), Pact_E, 110)) <= 0)", "tb_Stuffbasic");
            dgv_people.DataSource = MyDS_Grid.Tables[0];
        }

        private void checkb_message_CheckedChanged(object sender, EventArgs e)
        {
            bool Tbool = true;
            if (checkb_message.Checked == true)
                Tbool = true;
            else
                Tbool = false;
            gb_message.Enabled = Tbool;
            btn_save.Enabled = Tbool;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MyDataClass.getsqlcom("update tb_Clew set Fate=" + nud_day.Value);
            DataSet DSet = MyDataClass.getDataSet("select Fate from tb_Clew", "tb_clew");
            int sday = Convert.ToInt32(DSet.Tables[0].Rows[0][0]);
            MyDS_Grid = MyDataClass.getDataSet("select * from tb_Stuffbasic where ((getdate()-convert(Nvarchar(12), Pact_E ,110))>=-" + sday + " and(getdate() - convert(Nvarchar(12), Pact_E, 110)) <= 0)", "tb_Stuffbasic");
            dgv_people.DataSource = MyDS_Grid.Tables[0];
            MessageBox.Show("更新成功", "提示");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
