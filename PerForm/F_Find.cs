using Microsoft.Office.Interop.Word;
using PWMS.ModuleClass;
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
    public partial class F_Find : Form
    {
        public F_Find()
        {
            InitializeComponent();
            //禁止最大化
            this.MaximizeBox = false;
        }

        #region 公共类
        ModuleClass.MyModule FindMC = new PWMS.ModuleClass.MyModule();
        DataClass.MyMeans FindDataClass = new PWMS.DataClass.MyMeans();
        public static DataSet MyDS_Grid;
        public string ARsign = " AND ";
        public static string Findall_SQL = "select ID as 编号,StuffName as 职工姓名,Folk as 民族类别,Birthday as 出生日期,Age as 年龄,Kultur as 文化程度,Marriage as 婚姻,Sex as 性别,Visage as 政治面貌,IDCard as 身份证号,Workdate as 单位工作时间,WorkLength as 工龄,Employee as 职工类别,Business as 职务类别,Laborage as 工资类别,Branch as 部门类别,Duthcall as 职称类别,Phone as 电话,Handset as 手机,School as 毕业学校,Speciality as 主修专业,GraduateDate as 毕业时间,M_Pay as 月工资,Bank as 银行帐号,Pact_B as 合同开始时间,Pact_E as 合同结束时间,Pact_Y as 合同年限,BeAware as 籍贯所在省,City as 籍贯所在市 from tb_Stuffbasic";
        #endregion

        private void F_Find_Load(object sender, EventArgs e)
        {
            checkb_all.Checked = false;
            FindMC.CbbData(Find_Folk, "tb_Folk");  //向“民族类别”列表框中添加信息
            FindMC.CbbData(Find_Kultur, "tb_Kultur");  //向"文化程度”列表框中添加信息
            FindMC.CbbData(Find_Visage, "tb_Visage");  //向"政治面貌”列表框中添加信息
            FindMC.CbbData(Find_Employee, "tb_EmployeeGenre");  //向"职工类别”列表框中添加信息
            FindMC.CbbData(Find_Business, "tb_Business");  //向"职务类别”列表框中添加信息
            FindMC.CbbData(Find_Laborage, "tb_Laborage");  //向"工资类别”列表框中添加信息
            FindMC.CbbData(Find_Branch, "tb_Branch");  //向"部门类别”列表框中添加信息
            FindMC.CbbData(Find_Duthcall, "tb_Duthcall");  //向"职称类别”列表框中添加信息

            //向下拉列表中添加省名
            FindMC.CityData(Find_BeAware, "select distinct beaware from tb_City", 0);
            //向下拉列表中添加市名
            FindMC.CityData(Find_School, "select distinct School from tb_Stuffbasic", 0);
            //向下拉列表中添加主修专业
            FindMC.CityData(Find_Speciality, "select distinct Speciality from tb_Stuffbasic", 0);
            //指定MaskedTextBox控件的格式
            FindMC.MaskedTextBox_Format(Find1_WorkDate);  
            FindMC.MaskedTextBox_Format(Find2_WorkDate);
            
            //绑定数据
            MyDS_Grid = FindDataClass.getDataSet(Findall_SQL, "tb_Stuffbasic");
            dgv_result.DataSource = MyDS_Grid.Tables[0];
            dgv_result.AutoGenerateColumns = true;
        }

        //根据省改变市
        private void Find_BeAware_TextChanged(object sender, EventArgs e)
        {
            Find_City.Items.Clear();
            FindMC.CityData(Find_City, "select beaware,city from tb_City where beaware='" + Find_BeAware.Text.Trim() + "'", 1);
        }

        //查询
        private void btn_select_Click(object sender, EventArgs e)
        {
            //清空存储查询语句的变量
            ModuleClass.MyModule.FindValue = "";
            string Find_SQL = Findall_SQL;
            //将指定控件集下的控件组合成查询条件
            FindMC.Find_Grids(gb_basic.Controls, "Find", ARsign);
            FindMC.Find_Grids(gb_personal.Controls, "Find", ARsign);

            if (FindMC.Date_Format(Find1_WorkDate.Text) != "" && FindMC.Date_Format(Find2_WorkDate.Text) != "")
            {
                if (ModuleClass.MyModule.FindValue != "")   //如果FindValue字段不为空
                    //用ARsign变量连接查询条件
                    ModuleClass.MyModule.FindValue = ModuleClass.MyModule.FindValue + ARsign;
                //设置合同日期的查询条件
                ModuleClass.MyModule.FindValue = ModuleClass.MyModule.FindValue + " (" + "workdate>='" + Find1_WorkDate.Text + "' AND workdate<='" + Find2_WorkDate.Text + "')";
            }
            if (ModuleClass.MyModule.FindValue != "")   //如果FindValue字段不为空
                //将查询条件添加到SQL语句的尾部
                Find_SQL = Find_SQL + " where " + ModuleClass.MyModule.FindValue;
            //按照指定的条件进行查询
            MyDS_Grid = FindDataClass.getDataSet(Find_SQL, "tb_Stuffbasic");
            //在dataGridView1控件是显示查询的结果
            dgv_result.DataSource = MyDS_Grid.Tables[0];
            dgv_result.AutoGenerateColumns = true;
            checkb_all.Checked = false;
        }

        //清空当前页面
        private void btn_clear_Click(object sender, EventArgs e)
        {
            FindMC.Clear_Control(gb_basic.Controls);
            FindMC.Clear_Control(gb_personal.Controls);
        }

        //退出当前页面
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //显示全部
        private void checkb_all_Click(object sender, EventArgs e)
        {
            if (checkb_all.Checked == true)
            {
                MyDS_Grid = FindDataClass.getDataSet(Findall_SQL, "tb_Stuffbasic");
                dgv_result.DataSource = MyDS_Grid.Tables[0];
                dgv_result.AutoGenerateColumns = true;
            }
        }

        //选择与运算设置ARsign字符
        private void rb_and_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " AND ";
        }

        //选择或运算设置ARsign字符
        private void rb_or_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " OR ";
        }

        //年龄输入判断
        private void Find_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, "", 0);
        }

        //工龄输入判断
        private void Find_WorkLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, "", 0);
        }

        //工资输入判断
        private void Find_M_Pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, ((TextBox)sender).Text, 1);
        }

        //合同年限输入判断
        private void Find_Pact_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, "", 0);
        }

        //工作时间开始输入判断
        private void Find1_WorkDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, "", 0);
        }

        //工作时间结束输入判断
        private void Find2_WorkDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            FindMC.Estimate_Key(e, "", 0);
        }

        //离开工作时间开始时判断
        private void Find1_WorkDate_Leave(object sender, EventArgs e)
        {
                FindMC.Estimate_Date((MaskedTextBox)sender);  
        }

        //离开工作结束时判断
        private void Find2_WorkDate_Leave(object sender, EventArgs e)
        { 
            if (FindMC.Date_Format(Find1_WorkDate.Text) != "" && FindMC.Date_Format(Find2_WorkDate.Text) != "")
            {
                FindMC.Estimate_Date((MaskedTextBox)sender);
            }

            bool TDate = FindMC.Estimate_Date((MaskedTextBox)sender);
            if (TDate == true)
                if (FindMC.Date_Format(Find1_WorkDate.Text) != "" && FindMC.Date_Format(Find2_WorkDate.Text) != "")
                {
                    if (Convert.ToDateTime(Find2_WorkDate.Text) <= Convert.ToDateTime(Find1_WorkDate.Text))
                    {
                        MessageBox.Show("结束日期必须大于它前一个日期。", "提示");
                        Find2_WorkDate.Text = "";
                    }  
                }
        }
    }
}
