using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace PWMS.PerForm
{
    public partial class F_ManFile : Form
    {
        public F_ManFile()
        {
            InitializeComponent();
        }


        #region  当前窗体的所有共公变量
        //调用MyMeans类
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        //调用MyModule类
        ModuleClass.MyModule Myformat = new PWMS.ModuleClass.MyModule();
        //用于数据绑定
        public static DataSet MyDS_Grid;
        //表中某列数据
        public static string tem_Field = "";
        //当前选择的值
        public static string tem_Value = "";
        //传入的当前表中的ID
        public static string tem_ID = "";
        //图片数据
        public static byte[] imgBytesIn;
        //图片操作判断
        public static int Ima_n = 0;
        //添加或修改值判断
        public static int hold_n = 0;
        //自增ID格式：0001+1=0002
        public static string Part_ID = "";
        #endregion

        //加载
        private void F_ManFile_Load(object sender, EventArgs e)
        {
            //选择整行数据
            dgv_show.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //禁止最大化
            this.MaximizeBox = false;
            //状态栏传入登录名
            status_bar.Items[2].Text = DataClass.MyMeans.Login_Name;
            //数据绑定
            MyDS_Grid = MyDataClass.getDataSet(DataClass.MyMeans.AllSql, "tb_Stuffbasic");
            dgv_show.DataSource = MyDS_Grid.Tables[0];
            //是否自动创建列
            dgv_show.AutoGenerateColumns = true;
            //列宽
            dgv_show.Columns[0].Width = 60;
            dgv_show.Columns[1].Width = 80;

            #region 时间格式规范
            Myformat.MaskedTextBox_Format(S_3);
            Myformat.MaskedTextBox_Format(S_10);
            Myformat.MaskedTextBox_Format(S_19);
            Myformat.MaskedTextBox_Format(S_20);
            Myformat.MaskedTextBox_Format(S_24);

            Myformat.MaskedTextBox_Format(w_2);
            Myformat.MaskedTextBox_Format(w_3);
            Myformat.MaskedTextBox_Format(F_4);
            Myformat.MaskedTextBox_Format(R_3);
            Myformat.MaskedTextBox_Format(R_5);
            #endregion

            #region 数据传入combobox
            Myformat.CbbData(S_2, "tb_Folk");//民族
            Myformat.CbbData(S_7, "tb_Kultur");//文凭
            Myformat.CbbData(S_8, "tb_Visage");//政治面貌
            Myformat.CityData(S_12, "select distinct beaware from tb_City", 0);//省
            Myformat.CbbData(S_14, "tb_Laborage");//工资
            Myformat.CbbData(S_15, "tb_Business");//职务
            Myformat.CbbData(S_16, "tb_Branch");//部门
            Myformat.CbbData(S_17, "tb_Duthcall");//职称
            Myformat.CbbData(S_18, "tb_EmployeeGenre");//职工
            Myformat.CbbData(R_2, "tb_RPKind");//奖惩类别
            #endregion

            //隐藏dgv_show控件中不需要的列字段
            for (int i = 2; i < dgv_show.ColumnCount; i++)
            {
                dgv_show.Columns[i].Visible = false;
            }

            //禁止以列排序-工作简历
            for (int i = 0; i < dgv_show_work.Columns.Count; i++)
            {
                dgv_show_work.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //禁止以列排序-家庭关系
            for (int i = 0; i < dgv_famliy.Columns.Count; i++)
            {
                dgv_famliy.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //禁止以列排序-培训记录
            for (int i = 0; i < dgv_train.Columns.Count; i++)
            {
                dgv_train.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //禁止以列排序-奖惩列别
            for (int i = 0; i < dgv_reward.Columns.Count; i++)
            {
                dgv_reward.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //记录更改
            lbl_show.Text = txtchange(dgv_show);
        }

        //首条
        private void btn_first_Click(object sender, EventArgs e)
        {
            if (dgv_show.CurrentCell.ColumnIndex == -1 || dgv_show.CurrentCell.ColumnIndex > 1)
            {
                dgv_show.CurrentCell = dgv_show[0, 0];
            }
            else
            {
                dgv_show.CurrentCell = dgv_show[0, 0];
            }
        }

        //尾条
        private void btn_last_Click(object sender, EventArgs e)
        {
            dgv_show.CurrentCell = dgv_show.Rows[this.dgv_show.Rows.Count - 1].Cells[0];
        }

        //上一条
        private void btn_previous_Click(object sender, EventArgs e)
        {
            int ColInd = dgv_show.CurrentCell.ColumnIndex;
            if (ColInd == 0)
            {
                dgv_show.CurrentCell = dgv_show[0, 0];
                MessageBox.Show("当前已是首条！", "提示");
            }
            else
            {
                dgv_show.CurrentCell = this.dgv_show[ColInd, dgv_show.CurrentCell.RowIndex - 1];
            }
        }

        // 下一条
        private void btn_next_Click(object sender, EventArgs e)
        {
            int ColInd = dgv_show.CurrentCell.ColumnIndex;
            int row = this.dgv_show.CurrentRow.Index;
            if (row + 1 == dgv_show.RowCount)
            {
                MessageBox.Show("当前已是尾条！", "提示");
            }
            else
            {
                dgv_show.CurrentCell = this.dgv_show[ColInd, dgv_show.CurrentCell.RowIndex + 1];
            }
        }

        //按条件显示所有数据表的内容
        public void selectdata(string C_Value)
        {
            //查询满足条件的数据
            MyDS_Grid = MyDataClass.getDataSet("Select * from tb_Stuffbasic where " + tem_Field + "='" + tem_Value + "'", "tb_Stuffbasic");
            dgv_show.DataSource = MyDS_Grid.Tables[0];
            lbl_show.Text = txtchange(dgv_show);
            dgv_show.Enabled = true;
            btn_delete.Enabled = true;
            if (dgv_show.RowCount < 1)
            {
                Myformat.Ena_Button(btn_first, btn_next, btn_previous, btn_last, 0, 0, 0, 0);
                tem_ID = "";

                //工作简历
                DataSet WDset = MyDataClass.getDataSet("select Stu_ID,ID,BeginDate as 开始时间,EndDate as 结束时间, Branch as 部门, Business as 职务, WordUnit as 工作单位 from tb_WordResume where Stu_ID='" + tem_ID + "'", "tb_WordResume");
                Myformat.WCorrelation_Table(WDset, dgv_show_work);
                if (WDset.Tables[0].Rows.Count < 1)
                {
                    Myformat.Clear_Grids(WDset.Tables[0].Columns.Count, gb_work.Controls, "w_");
                }

                //家庭关系
                DataSet FDset = MyDataClass.getDataSet("select Stu_ID,ID,LeaguerName as 家庭成员名称,Nexus as 与本人的关系, BirthDate as 出生日期, WordUnit as 工作单位, Business as 职务, Visage as 政治面貌, Phone as 电话 from tb_Family where Stu_ID='" + tem_ID + "'", "tb_Family");
                Myformat.FCorrelation_Table(FDset, dgv_famliy);
                if (FDset.Tables[0].Rows.Count < 1)
                {
                    Myformat.Clear_Grids(FDset.Tables[0].Columns.Count, gb_famliy.Controls, "F_");
                }

                //培训记录
                DataSet TDset = MyDataClass.getDataSet("select Stu_ID,ID,TrainFashion as 培训方式,BeginDate as 培训开始时间, EndDate as 培训结束时间, Speciality as 培训专业, TrainUnit as 培训单位, KulturMemo as 培训内容, Charge as 费用, Effect as 效果 from tb_TrainNote where Stu_ID='" + tem_ID + "'", "tb_TrainNote");
                Myformat.TCorrelation_Table(TDset, dgv_train);
                if (TDset.Tables[0].Rows.Count < 1)
                {
                    Myformat.Clear_Grids(TDset.Tables[0].Columns.Count, gb_train.Controls, "T_");
                }

                //奖惩记录
                DataSet RDset = MyDataClass.getDataSet("select Stu_ID,ID,RPKind as 奖惩种类,RPDate as 奖惩时间, SealMan as 批准人, QuashDate as 撤消时间, QuashWhys as 撤消原因 from tb_RANDP where Stu_ID='" + tem_ID + "'", "tb_RANDP");
                Myformat.RCorrelation_Table(RDset, dgv_reward);
                if (RDset.Tables[0].Rows.Count < 1)
                {
                    Myformat.Clear_Grids(RDset.Tables[0].Columns.Count, gb_reward.Controls, "R_");
                }

                //个人评价
                SqlDataReader Read_Memo = MyDataClass.getcom("Select * from tb_Individual where ID='" + tem_ID + "'");
                if (Read_Memo.Read())
                {
                    Ind_Mome.Text = Read_Memo[1].ToString();
                }
                else
                {
                    Ind_Mome.Clear();
                }
            }
            else
            {
                Myformat.Ena_Button(btn_first, btn_next, btn_previous, btn_last, 1, 1, 1, 1);
            }
        }

        //查询框1改变
        private void C_select1_TextChanged(object sender, EventArgs e)
        {
            switch (C_select1.SelectedIndex)
            {
                case 0: //职工姓名
                    {
                        Myformat.CityData(C_select2, "select distinct StuffName from tb_Stuffbasic", 0);
                        tem_Field = "StuffName";
                        break;
                    }
                case 1: //性别
                    {
                        C_select2.Items.Clear();
                        C_select2.Items.Add("男");
                        C_select2.Items.Add("女");
                        tem_Field = "Sex";
                        break;
                    }
                case 2: //民族类别
                    {
                        Myformat.CbbData(C_select2, "tb_Folk");
                        tem_Field = "Folk";
                        break;
                    }
                case 3: //文化程度
                    {
                        Myformat.CbbData(C_select2, "tb_Kultur");
                        tem_Field = "Kultur";
                        break;
                    }
                case 4: //政治面貌
                    {
                        Myformat.CbbData(C_select2, "tb_Visage");
                        tem_Field = "Visage";
                        break;
                    }
                case 5:  //职工类别
                    {
                        Myformat.CbbData(C_select2, "tb_EmployeeGenre");
                        tem_Field = "Employee";
                        break;
                    }
                case 6: //职务类别
                    {
                        Myformat.CbbData(C_select2, "tb_Business");
                        tem_Field = "Business";
                        break;
                    }
                case 7: //部门类别
                    {
                        Myformat.CbbData(C_select2, "tb_Branch");
                        tem_Field = "Branch";
                        break;
                    }
                case 8: //职称类别
                    {
                        Myformat.CbbData(C_select2, "tb_Duthcall");
                        tem_Field = "Duthcall";
                        break;
                    }
                case 9: //工资类别
                    {
                        Myformat.CbbData(C_select2, "tb_Laborage");
                        tem_Field = "Laborage";
                        break;
                    }
            }
        }

        //查询框2改变
        private void C_select2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //tem_Value为查询框2中条件
                tem_Value = C_select2.SelectedItem.ToString();
                selectdata(tem_Value);
            }
            catch
            {
                C_select2.Text = "";
                //MessageBox.Show("只能以选择方式查询。", "提示！");
            }
        }

        //显示数据
        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                //查询所有数据
                MyDS_Grid = MyDataClass.getDataSet(DataClass.MyMeans.AllSql, "tb_Stuffbasic");
                dgv_show.DataSource = MyDS_Grid.Tables[0];
                dgv_show.AutoGenerateColumns = true;
                dgv_show.Columns[0].Width = 60;
                dgv_show.Columns[1].Width = 80;
                btn_delete.Enabled = true;
                //隐藏dataGridView1控件中不需要的列字段
                for (int i = 2; i < dgv_show.ColumnCount; i++)
                {
                    dgv_show.Columns[i].Visible = false;
                }
                //传入记录名
                lbl_show.Text = dgv_show[1, dgv_show.CurrentCell.RowIndex].Value.ToString();
                C_select1.Text = "";
                C_select2.Text = "";
                dgv_show.Enabled = true;
                btn_choose.Enabled = false;
                btn_clear.Enabled = false;
                Myformat.Ena_Button(btn_insert, btn_update, btn_cancel, btn_save, 1, 1, 0, 0);
                Myformat.Ena_Button(btn_winsert, btn_wupdate, btn_wcancel, btn_wsave, 1, 1, 0, 0);
                Myformat.Ena_Button(btn_finsert, btn_fupdate, btn_fcancel, btn_fsave, 1, 1, 0, 0);
                Myformat.Ena_Button(btn_tinsert, btn_rupdate, btn_rcancel, btn_rsave, 1, 1, 0, 0);
                status_bar.Items[4].Text = "无";
            }
            catch
            {
                MessageBox.Show("数据已显示！", "提示");
            }
        }

        //界面切换
        private void tabc_menu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btn_cancel_Click(sender, e);
        }





        //根据点击修改数据-职工基本信息
        public string txtchange(DataGridView DGrid)
        {
            if (DGrid.RowCount > 0)
            {
                byte[] pic;
                S_0.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_1.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_2.Text = Convert.ToString(DGrid[2, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_3.Text = Myformat.Date_Format(Convert.ToString(DGrid[3, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_4.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString().Trim(); ;
                S_5.Text = Convert.ToString(DGrid[7, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_6.Text = Convert.ToString(DGrid[6, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_7.Text = Convert.ToString(DGrid[5, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_8.Text = Convert.ToString(DGrid[8, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_9.Text = Convert.ToString(DGrid[9, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_10.Text = Myformat.Date_Format(Convert.ToString(DGrid[10, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_11.Text = Convert.ToString(DGrid[11, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_18.Text = DGrid[12, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_15.Text = DGrid[13, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_14.Text = DGrid[14, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_16.Text = DGrid[15, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_17.Text = DGrid[16, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_22.Text = DGrid[17, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_23.Text = DGrid[18, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_24.Text = Myformat.Date_Format(Convert.ToString(DGrid[21, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_25.Text = DGrid[19, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_26.Text = DGrid[20, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_27.Text = DGrid[22, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_12.Text = Convert.ToString(DGrid[24, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_13.Text = Convert.ToString(DGrid[25, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_28.Text = Convert.ToString(DGrid[26, DGrid.CurrentCell.RowIndex].Value).Trim();
                S_29.Text = DGrid[27, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_19.Text = Myformat.Date_Format(Convert.ToString(DGrid[28, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_20.Text = Myformat.Date_Format(Convert.ToString(DGrid[29, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_21.Text = Convert.ToString(DGrid[30, DGrid.CurrentCell.RowIndex].Value).Trim();
                Myformat.allreadonly(tabc_menu.TabPages[0].Controls, "S_", 30, false);
                try
                {
                    pic = (byte[])(MyDS_Grid.Tables[0].Rows[DGrid.CurrentCell.RowIndex][23]);//将数据库中的图片存入到字节数组中
                    MemoryStream ms = new MemoryStream(pic);//将字节数组存入到二进制流中
                    S_Photo.Image = System.Drawing.Image.FromStream(ms);//二进制流Image控件中显示
                }
                catch
                {
                    S_Photo.Image = null;
                }
                tem_ID = S_0.Text.Trim();
                return DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
            }
            else
            {
                Myformat.Clear_Control(tabc_menu.TabPages[0].Controls);
                Myformat.Clear_Control(gb_work.Controls);
                tem_ID = "";
                return "";
            }
        }

        //点击切换数据-职工基本信息
        private void dgv_show_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_show.CurrentCell.RowIndex > -1)
                {
                    //职工基本信息
                    lbl_show.Text = txtchange(dgv_show);

                    //工作简历
                    DataSet WDset = MyDataClass.getDataSet("select Stu_ID,ID,BeginDate as 开始时间,EndDate as 结束时间, Branch as 部门, Business as 职务, WordUnit as 工作单位 from tb_WordResume where Stu_ID='" + tem_ID + "'", "tb_WordResume");
                    Myformat.WCorrelation_Table(WDset, dgv_show_work);
                    if (WDset.Tables[0].Rows.Count < 1)
                    {
                        Myformat.Clear_Grids(WDset.Tables[0].Columns.Count, gb_work.Controls, "w_");
                    }

                    //家庭关系
                    DataSet FDset = MyDataClass.getDataSet("select Stu_ID,ID,LeaguerName as 家庭成员名称,Nexus as 与本人的关系, BirthDate as 出生日期, WordUnit as 工作单位, Business as 职务, Visage as 政治面貌, Phone as 电话 from tb_Family where Stu_ID='" + tem_ID + "'", "tb_Family");
                    Myformat.FCorrelation_Table(FDset, dgv_famliy);
                    if (FDset.Tables[0].Rows.Count < 1)
                    {
                        Myformat.Clear_Grids(FDset.Tables[0].Columns.Count, gb_famliy.Controls, "F_");
                    }

                    //培训记录
                    DataSet TDset = MyDataClass.getDataSet("select Stu_ID,ID,TrainFashion as 培训方式,BeginDate as 培训开始时间, EndDate as 培训结束时间, Speciality as 培训专业, TrainUnit as 培训单位, KulturMemo as 培训内容, Charge as 费用, Effect as 效果 from tb_TrainNote where Stu_ID='" + tem_ID + "'", "tb_TrainNote");
                    Myformat.TCorrelation_Table(TDset, dgv_train);
                    if (TDset.Tables[0].Rows.Count < 1)
                    {
                        Myformat.Clear_Grids(TDset.Tables[0].Columns.Count, gb_train.Controls, "T_");
                    }

                    //奖惩记录
                    DataSet RDset = MyDataClass.getDataSet("select Stu_ID,ID,RPKind as 奖惩种类,RPDate as 奖惩时间, SealMan as 批准人, QuashDate as 撤消时间, QuashWhys as 撤消原因 from tb_RANDP where Stu_ID='" + tem_ID + "'", "tb_RANDP");
                    Myformat.RCorrelation_Table(RDset, dgv_reward);
                    if (RDset.Tables[0].Rows.Count < 1)
                    {
                        Myformat.Clear_Grids(RDset.Tables[0].Columns.Count, gb_reward.Controls, "R_");
                    }


                    //个人评价
                    SqlDataReader Read_Memo = MyDataClass.getcom("Select * from tb_Individual where ID='" + tem_ID + "'");
                    if (Read_Memo.Read())
                    {
                        Ind_Mome.Text = Read_Memo[1].ToString();
                    }
                    else
                    {
                        Ind_Mome.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //将图片转换成字节数组-职工基本信息
        public void Read_Image(OpenFileDialog openF, PictureBox MyImage)
        {
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png";   //指定OpenFileDialog控件打开的文件格式
            if (openF.ShowDialog(this) == DialogResult.OK)  //如果打开了图片文件
            {
                try
                {
                    MyImage.Image = System.Drawing.Image.FromFile(openF.FileName);  //将图片文件存入到PictureBox控件中
                    string strimg = openF.FileName.ToString();  //记录图片的所在路径
                    FileStream fs = new FileStream(strimg, FileMode.Open, FileAccess.Read); //将图片以文件流的形式进行保存
                    BinaryReader br = new BinaryReader(fs);
                    imgBytesIn = br.ReadBytes((int)fs.Length);  //将流读入到字节数组中
                }
                catch
                {
                    MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    S_Photo.Image = null;
                }
            }
        }

        //显示数据库图片-职工基本信息
        public void ShowData_Image(byte[] DI, PictureBox Ima)
        {
            byte[] buffer = DI;
            MemoryStream ms = new MemoryStream(buffer);
            Ima.Image = System.Drawing.Image.FromStream(ms);
        }

        //选择图片-职工基本信息
        private void btn_choose_Click(object sender, EventArgs e)
        {
            Read_Image(opf_pic, S_Photo);
            Ima_n = 1;
        }

        //清除图片-职工基本信息
        private void btn_clear_Click(object sender, EventArgs e)
        {
            S_Photo.Image = null;
            imgBytesIn = new byte[65536];
            Ima_n = 2;
        }

        //根据省改变市-职工基本信息
        private void C_12_TextChanged(object sender, EventArgs e)
        {
            S_13.Items.Clear();
            Myformat.CityData(S_13, "select beaware,city from tb_City where beaware='" + S_12.Text.Trim() + "'", 1);//市
        }

        //添加-职工基本信息    
        private void btn_insert_Click(object sender, EventArgs e)
        {
            hold_n = 2;
            Myformat.Clear_Control(tbp_basic.Controls);
            S_0.Text = Myformat.GetAutocoding("tb_StuffBasic", "ID");
            Myformat.Ena_Button(btn_insert, btn_update, btn_cancel, btn_save, 0, 0, 1, 1);
            status_bar.Items[4].Text = "正在添加数据...";
            btn_choose.Enabled = true;
            btn_clear.Enabled = true;
            btn_delete.Enabled = false;
            Myformat.allreadonly(tabc_menu.TabPages[0].Controls, "S_", 30, true);
            dgv_show.Enabled = false;
            gb_read.Enabled = false;
            gb_select.Enabled = false;
        }

        //修改-职工基本信息
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                hold_n = 2;
                Myformat.Ena_Button(btn_insert, btn_update, btn_cancel, btn_save, 0, 0, 1, 1);
                status_bar.Items[4].Text = "正在修改数据...";
                btn_choose.Enabled = true;
                btn_clear.Enabled = true;
                btn_delete.Enabled = false;
                Myformat.allreadonly(tabc_menu.TabPages[0].Controls, "S_", 30, true);
                dgv_show.Enabled = false;
                gb_read.Enabled = false;
                gb_select.Enabled = false;
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }

        }

        //删除-职工基本信息
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                status_bar.Items[4].Text = "正在删除数据...";
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_show.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_show.CurrentRow.Index != dgv_show.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_show.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("删除成功！", "提示");
                        MyDataClass.getsqlcom("Delete tb_Stuffbasic where ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_WordResume where Stu_ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_Family where Stu_ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_TrainNote where Stu_ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_RANDP where Stu_ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_WordResume where Stu_ID='" + S_0.Text.Trim() + "'");
                        MyDataClass.getsqlcom("Delete tb_Individual where ID='" + S_0.Text.Trim() + "'");
                        btn_cancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                        status_bar.Items[4].Text = "无";
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //取消-职工基本信息
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tem_Field = "";
            hold_n = 0;
            Ima_n = 0;
            Myformat.Ena_Button(btn_insert, btn_update, btn_cancel, btn_save, 1, 1, 0, 0);
            status_bar.Items[4].Text = "无";
            if (tem_Field == "")
            {
                btn_show_Click(sender, e);
                gb_read.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
                selectdata(tem_Value);
            }
            btn_choose.Enabled = false;
            btn_clear.Enabled = false;
        }

        //保存-职工基本信息
        private void btn_save_Click(object sender, EventArgs e)
        {
            //progressbar调用
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            try
            {
                if (hold_n == 1 || hold_n == 2)
                {
                    ModuleClass.MyModule.ADDs = "";
                    string All_Field = "ID,StuffName,Folk,Birthday,Age,Sex,Marriage,Kultur,Visage,IDCard,Workdate,WorkLength,BeAware,City,Laborage,Business,Branch,Duthcall,Employee,Pact_B,Pact_E,Pact_Y,Phone,Handset,GraduateDate,School,Speciality,Address,M_Pay,Bank";
                    Myformat.Part_SaveClass(All_Field, S_0.Text.Trim(), "", tabc_menu.TabPages[0].Controls, "S_", "tb_Stuffbasic", 30, hold_n);
                    if (ModuleClass.MyModule.ADDs != "")
                    {
                        MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                    }
                    status_bar.Items[4].Text = "无";
                }
                if (Ima_n > 0)
                {
                    Myformat.SaveImage(S_0.Text.Trim(), imgBytesIn);
                }
                btn_show_Click(sender, e);
                btn_cancel_Click(sender, e);
                hold_n = 0;
            }
            catch
            {
                MessageBox.Show("请输入正确的职工信息！", "提示");
            }
        }

        //导出到word-职工基本信息
        private void btn_importw_Click(object sender, EventArgs e)
        {
            status_bar.Items[4].Text = "正在导出word...";
            try
            {
                #region 针对Word 15.0以上
                int judge1 = 0;
                string path1 = "D:\\PWMS\\Stuffimageword";
                if (Directory.Exists(path1))
                {
                    judge1 = 1;
                }
                else
                {
                    string dict = @"D:\PWMS\";
                    if (!Directory.Exists(dict))
                    {
                        Directory.CreateDirectory(dict);
                    }
                    string dict2 = "Stuffimageword";
                    string pathString = System.IO.Path.Combine(dict, dict2);
                    if (!System.IO.File.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                }


                int judge2 = 0;
                string path2 = "D:\\PWMS\\WORD";
                if (Directory.Exists(path2))
                {
                    judge2 = 1;
                }
                else
                {
                    string dicte = @"D:\PWMS\";
                    if (!Directory.Exists(dicte))
                    {
                        Directory.CreateDirectory(dicte);
                    }
                    string dicte2 = "WORD";
                    string pathStringe = System.IO.Path.Combine(dicte, dicte2);
                    if (!System.IO.File.Exists(pathStringe))
                    {
                        Directory.CreateDirectory(pathStringe);
                    }
                }

                object Nothing = System.Reflection.Missing.Value;
                object missing = System.Reflection.Missing.Value;

                //创建Word文档
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //wordApp.Visible = true;

                //设置文档宽度
                wordApp.Selection.PageSetup.LeftMargin = wordApp.CentimetersToPoints(float.Parse("2"));
                wordApp.Selection.PageSetup.RightMargin = wordApp.CentimetersToPoints(float.Parse("2"));
                wordApp.ActiveWindow.ActivePane.HorizontalPercentScrolled = 20;

                Object start = Type.Missing;
                Object end = Type.Missing;

                PictureBox pb_stuff = new PictureBox();
                int P_flag = 0;
                for (int i = 0; i < MyDS_Grid.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        if (judge1 == 1)
                        {
                            ShowData_Image((byte[])(MyDS_Grid.Tables[0].Rows[i][23]), pb_stuff);
                            pb_stuff.Image.Save(@"D:\PWMS\Stuffimageword\" + MyDS_Grid.Tables[0].Rows[i][1] + ".jpg");    //将图片存入到指定的路径
                        }
                    }
                    catch
                    {
                        P_flag = 1;
                    }
                    Thread.Sleep(500);
                    //object rng = Type.Missing;
                    string strInfo = "职工基本信息表" + "(" + MyDS_Grid.Tables[0].Rows[i][1].ToString() + ")";
                    start = 0;
                    end = 0;
                    wordDoc.Range(ref start, ref end).InsertBefore(strInfo);//插入文本
                    wordDoc.Range(ref start, ref end).Font.Name = "Verdana";//设置字体
                    wordDoc.Range(ref start, ref end).Font.Size = 20;//设置字体大小
                                                                     //设置字体居中
                    wordDoc.Range(ref start, ref end).ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    start = strInfo.Length;
                    end = strInfo.Length;

                    wordDoc.Range(ref start, ref end).InsertParagraphAfter();//插入回车

                    object missingValue = Type.Missing;
                    object location = strInfo.Length;
                    Microsoft.Office.Interop.Word.Range rng2 = wordDoc.Range(ref location, ref location);

                    Microsoft.Office.Interop.Word.Table tab = wordDoc.Tables.Add(rng2, 14, 6, ref missingValue, ref missingValue);
                    tab.Rows.HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAtLeast;
                    tab.Rows.Height = wordApp.CentimetersToPoints(float.Parse("0.8"));
                    tab.Range.Font.Size = 10;
                    tab.Range.Font.Name = "宋体";

                    //设置表格样式
                    tab.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                    tab.Borders.InsideLineWidth = Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth050pt;
                    tab.Borders.InsideColor = Microsoft.Office.Interop.Word.WdColor.wdColorAutomatic;
                    wordApp.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;//设置右对齐

                    //第5行显示合并
                    tab.Cell(1, 5).Merge(tab.Cell(5, 6));
                    //第6行显示合并
                    tab.Cell(6, 5).Merge(tab.Cell(6, 6));
                    //第9行显示合并
                    tab.Cell(9, 4).Merge(tab.Cell(9, 6));
                    //第12行显示合并
                    tab.Cell(12, 2).Merge(tab.Cell(12, 6));
                    //第13行显示合并
                    tab.Cell(13, 2).Merge(tab.Cell(13, 6));
                    //第14行显示合并
                    tab.Cell(14, 2).Merge(tab.Cell(14, 6));

                    //第1行赋值
                    tab.Cell(1, 1).Range.Text = "职工编号：";
                    tab.Cell(1, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][0].ToString();
                    tab.Cell(1, 3).Range.Text = "职工姓名：";
                    tab.Cell(1, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][1].ToString();

                    //插入图片
                    if (P_flag == 0)
                    {
                        string FileName = @"D:\PWMS\Stuffimageword\" + MyDS_Grid.Tables[0].Rows[i][1] + ".jpg";//图片所在路径
                        object LinkToFile = false;
                        object SaveWithDocument = true;
                        object Anchor = tab.Cell(1, 5).Range;    //指定图片插入的区域
                                                                 //将图片插入到单元格中
                        tab.Cell(1, 5).Range.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor);
                    }
                    P_flag = 0;

                    //第2行赋值
                    tab.Cell(2, 1).Range.Text = "民族类别：";
                    tab.Cell(2, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][2].ToString();
                    tab.Cell(2, 3).Range.Text = "出生日期：";
                    try
                    {
                        tab.Cell(2, 4).Range.Text = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][3]).ToShortDateString());
                    }
                    catch { tab.Cell(2, 4).Range.Text = ""; }

                    //第3行赋值
                    tab.Cell(3, 1).Range.Text = "年龄：";
                    tab.Cell(3, 2).Range.Text = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][4]);
                    tab.Cell(3, 3).Range.Text = "文化程度：";
                    tab.Cell(3, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][5].ToString();

                    //第4行赋值
                    tab.Cell(4, 1).Range.Text = "婚姻：";
                    tab.Cell(4, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][6].ToString();
                    tab.Cell(4, 3).Range.Text = "性别：";
                    tab.Cell(4, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][7].ToString();

                    //第5行赋值
                    tab.Cell(5, 1).Range.Text = "政治面貌：";
                    tab.Cell(5, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][8].ToString();
                    tab.Cell(5, 3).Range.Text = "单位工作时间：";
                    try
                    {
                        tab.Cell(5, 4).Range.Text = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[0][10]).ToShortDateString());
                    }
                    catch { tab.Cell(5, 4).Range.Text = ""; }

                    //第6行赋值
                    tab.Cell(6, 1).Range.Text = "籍贯：";
                    tab.Cell(6, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][24].ToString();
                    tab.Cell(6, 3).Range.Text = MyDS_Grid.Tables[0].Rows[i][25].ToString();
                    tab.Cell(6, 4).Range.Text = "身份证：";
                    tab.Cell(6, 5).Range.Text = MyDS_Grid.Tables[0].Rows[i][9].ToString();

                    //第7行赋值
                    tab.Cell(7, 1).Range.Text = "工龄：";
                    tab.Cell(7, 2).Range.Text = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][11]);
                    tab.Cell(7, 3).Range.Text = "职工类别：";
                    tab.Cell(7, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][12].ToString();
                    tab.Cell(7, 5).Range.Text = "职务类别：";
                    tab.Cell(7, 6).Range.Text = MyDS_Grid.Tables[0].Rows[i][13].ToString();

                    //第8行赋值
                    tab.Cell(8, 1).Range.Text = "工资类别：";
                    tab.Cell(8, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][14].ToString();
                    tab.Cell(8, 3).Range.Text = "部门类别：";
                    tab.Cell(8, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][15].ToString();
                    tab.Cell(8, 5).Range.Text = "职称类别：";
                    tab.Cell(8, 6).Range.Text = MyDS_Grid.Tables[0].Rows[i][16].ToString();

                    //第9行赋值
                    tab.Cell(9, 1).Range.Text = "月工资：";
                    tab.Cell(9, 2).Range.Text = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][26]);
                    tab.Cell(9, 3).Range.Text = "银行账号：";
                    tab.Cell(9, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][27].ToString();

                    //第10行赋值
                    tab.Cell(10, 1).Range.Text = "合同起始日期：";
                    try
                    {
                        tab.Cell(10, 2).Range.Text = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][28]).ToShortDateString());
                    }
                    catch { tab.Cell(10, 2).Range.Text = ""; }
                    tab.Cell(10, 3).Range.Text = "合同结束日期：";
                    try
                    {
                        tab.Cell(10, 4).Range.Text = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][29]).ToShortDateString());
                    }
                    catch { tab.Cell(10, 4).Range.Text = ""; }
                    tab.Cell(10, 5).Range.Text = "合同年限：";
                    tab.Cell(10, 6).Range.Text = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][30]);

                    //第11行赋值
                    tab.Cell(11, 1).Range.Text = "电话：";
                    tab.Cell(11, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][17].ToString();
                    tab.Cell(11, 3).Range.Text = "手机：";
                    tab.Cell(11, 4).Range.Text = MyDS_Grid.Tables[0].Rows[i][18].ToString();
                    tab.Cell(11, 5).Range.Text = "毕业时间：";
                    try
                    {
                        tab.Cell(11, 6).Range.Text = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][21]).ToShortDateString());
                    }
                    catch { tab.Cell(11, 6).Range.Text = ""; }

                    //第12行赋值
                    tab.Cell(12, 1).Range.Text = "毕业学校：";
                    tab.Cell(12, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][19].ToString();

                    //第13行赋值
                    tab.Cell(13, 1).Range.Text = "主修专业：";
                    tab.Cell(13, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][20].ToString();

                    //第14行赋值
                    tab.Cell(14, 1).Range.Text = "家庭地址：";
                    tab.Cell(14, 2).Range.Text = MyDS_Grid.Tables[0].Rows[i][22].ToString();

                    if (judge2 == 1)
                    {
                        wordDoc.SaveAs2("D:\\PWMS\\WORD\\" + strInfo + ".docx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    }
                    wordDoc.Save();
                }
                DialogResult result = MessageBox.Show("基本信息表导出到WORD成功，位置: D:\\PWMS\\WORD", "提示");
                if (result == DialogResult.OK)
                {
                    wordDoc.Close();
                    wordApp.Quit();
                }

                status_bar.Items[4].Text = "null";
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "导出失败！请检查是否为microsoft office2019及以下版本！", "提示");
            }

        }

        //导出到excel-职工基本信息
        private void btn_importe_Click(object sender, EventArgs e)
        {
            status_bar.Items[4].Text = "正在导出excel...";
            try
            {
                #region 针对Excel 15.0以上
                int judge1 = 0;
                string path1 = "D:\\PWMS\\Stuffimageexcel";
                if (Directory.Exists(path1))
                {
                    judge1 = 1;
                }
                else
                {
                    string dict = @"D:\PWMS\";
                    if (!Directory.Exists(dict))
                    {
                        Directory.CreateDirectory(dict);
                    }
                    string dict2 = "Stuffimageexcel";
                    string pathString = System.IO.Path.Combine(dict, dict2);
                    if (!System.IO.File.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                }

                int judge2 = 0;
                string path2 = "D:\\PWMS\\EXCEL";
                if (Directory.Exists(path2))
                {
                    judge2 = 1;
                }
                else
                {
                    string dicte = @"D:\PWMS\";
                    if (!Directory.Exists(dicte))
                    {
                        Directory.CreateDirectory(dicte);
                    }
                    string dicte2 = "EXCEL";
                    string pathStringe = System.IO.Path.Combine(dicte, dicte2);
                    if (!System.IO.File.Exists(pathStringe))
                    {
                        Directory.CreateDirectory(pathStringe);
                    }
                }

                object rng = Type.Missing;
                //创建Excel对象
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Application.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)(workbook.Worksheets[1]);
                Microsoft.Office.Interop.Excel.Range range = null;

                //获取除第一行之外的所有单元格范围
                range = worksheet.Range[excel.Cells[2, 1], excel.Cells[15, 6]];

                range.ColumnWidth = 15;//设置单元格宽度
                range.RowHeight = 25;//设置单元格高度
                range.Borders.LineStyle = 1;//设置边框线的宽度
                                            //设置边框线的样式
                range.BorderAround2(1, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Color.Black, Type.Missing);
                range.Font.Size = 12;//设置字体大小
                range.Font.Name = "宋体";//设置字体
                                       //设置对齐格式为左对齐
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignJustify;

                PictureBox pb_stuff = new PictureBox();//新建一个PictureBox控件
                int P_flag = 0;//定义一个标识，用来标识是否存在照片

                for (int i = 0; i < MyDS_Grid.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        if (judge1 == 1)
                        {
                            ShowData_Image((byte[])(MyDS_Grid.Tables[0].Rows[i][23]), pb_stuff);
                            pb_stuff.Image.Save(@"D:\PWMS\Stuffimageexcel\" + MyDS_Grid.Tables[0].Rows[i][1] + ".jpg");    //将图片存入到指定的路径
                        }
                    }
                    catch
                    {
                        P_flag = 1;
                    }

                    //设置标题名称
                    string strInfo = "职工基本信息表" + "(" + MyDS_Grid.Tables[0].Rows[i][1].ToString() + ")";
                    //设置第1行要合并的表格
                    range = worksheet.Range[excel.Cells[1, 1], excel.Cells[1, 6]];
                    range.Merge();//合并单元格
                    range.Font.Size = 30;//设置第一行的字体大小
                    range.Font.Name = "宋体";//设置第一行的字体
                    range.Font.FontStyle = "Bold";//设置第一行字体为粗体
                                                  //设置标题居中显示
                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    excel.Cells[1, 1] = strInfo;//设置标题

                    //第2行到第6行的合并范围，用来显示照片
                    range = worksheet.Range[excel.Cells[2, 5], excel.Cells[6, 6]];
                    range.Merge(true);
                    //第7行显示
                    range = worksheet.Range[excel.Cells[7, 5], excel.Cells[7, 6]];
                    range.Merge(true);
                    //第10行显示
                    range = worksheet.Range[excel.Cells[10, 4], excel.Cells[10, 6]];
                    range.Merge(true);
                    //第13行显示
                    range = worksheet.Range[excel.Cells[13, 2], excel.Cells[13, 6]];
                    range.Merge(true);
                    //第14行显示
                    range = worksheet.Range[excel.Cells[14, 2], excel.Cells[14, 6]];
                    range.Merge(true);
                    //第15行显示
                    range = worksheet.Range[excel.Cells[15, 2], excel.Cells[15, 6]];
                    range.Merge(true);

                    //第1行赋值
                    excel.Cells[2, 1] = "职工编号：";
                    excel.Cells[2, 2] = MyDS_Grid.Tables[0].Rows[i][0].ToString();
                    excel.Cells[2, 3] = "职工姓名：";
                    excel.Cells[2, 4] = MyDS_Grid.Tables[0].Rows[i][1].ToString();

                    //插入照片
                    if (P_flag == 0)
                    {
                        string FileName = @"D:\PWMS\Stuffimageexcel\" + MyDS_Grid.Tables[0].Rows[i][1] + ".jpg";//照片所在路径
                        range = worksheet.Range[excel.Cells[2, 5], excel.Cells[6, 5]];
                        range.Merge();
                        worksheet.Shapes.AddPicture(FileName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 418, 43, 100, 115);
                    }
                    P_flag = 0;
                    //第2行赋值
                    excel.Cells[3, 1] = "民族类别：";
                    excel.Cells[3, 2] = MyDS_Grid.Tables[0].Rows[i][2].ToString();
                    excel.Cells[3, 3] = "出生日期：";
                    try
                    {
                        excel.Cells[3, 4] = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][3]).ToShortDateString());
                    }
                    catch { excel.Cells[3, 4] = ""; }
                    //第3行赋值
                    excel.Cells[4, 1] = "年龄：";
                    excel.Cells[4, 2] = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][4]);
                    excel.Cells[4, 3] = "文化程度：";
                    excel.Cells[4, 4] = MyDS_Grid.Tables[0].Rows[i][5].ToString();
                    //第4行赋值
                    excel.Cells[5, 1] = "婚姻：";
                    excel.Cells[5, 2] = MyDS_Grid.Tables[0].Rows[i][6].ToString();
                    excel.Cells[5, 3] = "性别：";
                    excel.Cells[5, 4] = MyDS_Grid.Tables[0].Rows[i][7].ToString();
                    //第5行赋值
                    excel.Cells[6, 1] = "政治面貌：";
                    excel.Cells[6, 2] = MyDS_Grid.Tables[0].Rows[i][8].ToString();
                    excel.Cells[6, 3] = "单位工作时间：";
                    try
                    {
                        excel.Cells[6, 4] = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[0][10]).ToShortDateString());
                    }
                    catch { excel.Cells[6, 4] = ""; }
                    //第6行赋值
                    excel.Cells[7, 1] = "籍贯：";
                    excel.Cells[7, 2] = MyDS_Grid.Tables[0].Rows[i][24].ToString();
                    excel.Cells[7, 3] = MyDS_Grid.Tables[0].Rows[i][25].ToString();
                    excel.Cells[7, 4] = "身份证：";
                    excel.Cells[7, 5] = MyDS_Grid.Tables[0].Rows[i][9].ToString();
                    //第7行赋值
                    excel.Cells[8, 1] = "工龄：";
                    excel.Cells[8, 2] = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][11]);
                    excel.Cells[8, 3] = "职工类别：";
                    excel.Cells[8, 4] = MyDS_Grid.Tables[0].Rows[i][12].ToString();
                    excel.Cells[8, 5] = "职务类别：";
                    excel.Cells[8, 6] = MyDS_Grid.Tables[0].Rows[i][13].ToString();
                    //第8行赋值
                    excel.Cells[9, 1] = "工资类别：";
                    excel.Cells[9, 2] = MyDS_Grid.Tables[0].Rows[i][14].ToString();
                    excel.Cells[9, 3] = "部门类别：";
                    excel.Cells[9, 4] = MyDS_Grid.Tables[0].Rows[i][15].ToString();
                    excel.Cells[9, 5] = "职称类别：";
                    excel.Cells[9, 6] = MyDS_Grid.Tables[0].Rows[i][16].ToString();
                    //第9行赋值
                    excel.Cells[10, 1] = "月工资：";
                    excel.Cells[10, 2] = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][26]);
                    excel.Cells[10, 3] = "银行账号：";
                    excel.Cells[10, 4] = MyDS_Grid.Tables[0].Rows[i][27].ToString();
                    //第10行赋值
                    excel.Cells[11, 1] = "合同起始日期：";
                    try
                    {
                        excel.Cells[11, 2] = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][28]).ToShortDateString());
                    }
                    catch { excel.Cells[11, 2] = ""; }
                    excel.Cells[11, 3] = "合同结束日期：";
                    try
                    {
                        excel.Cells[11, 4] = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][29]).ToShortDateString());
                    }
                    catch { excel.Cells[11, 4] = ""; }
                    excel.Cells[11, 5] = "合同年限：";
                    excel.Cells[11, 6] = Convert.ToString(MyDS_Grid.Tables[0].Rows[i][30]);
                    //第11行赋值
                    excel.Cells[12, 1] = "电话：";
                    excel.Cells[12, 2] = MyDS_Grid.Tables[0].Rows[i][17].ToString();
                    excel.Cells[12, 3] = "手机：";
                    excel.Cells[12, 4] = MyDS_Grid.Tables[0].Rows[i][18].ToString();
                    excel.Cells[12, 5] = "毕业时间：";
                    try
                    {
                        excel.Cells[12, 6] = Convert.ToString(Convert.ToDateTime(MyDS_Grid.Tables[0].Rows[i][21]).ToShortDateString());
                    }
                    catch { excel.Cells[12, 6] = ""; }
                    //第12行赋值
                    excel.Cells[13, 1] = "毕业学校：";
                    excel.Cells[13, 2] = MyDS_Grid.Tables[0].Rows[i][19].ToString();
                    //第13行赋值
                    excel.Cells[14, 1] = "主修专业：";
                    excel.Cells[14, 2] = MyDS_Grid.Tables[0].Rows[i][20].ToString();
                    //第14行赋值
                    excel.Cells[15, 1] = "家庭地址：";
                    excel.Cells[15, 2] = MyDS_Grid.Tables[0].Rows[i][22].ToString();

                    if (judge2 == 1)
                    {
                        FileInfo finfo = new FileInfo("D:\\PWMS\\EXCEL\\" + strInfo + ".xlsx");
                        if (finfo.Exists)
                        {
                            finfo.Delete();
                            worksheet.SaveAs("D:\\PWMS\\EXCEL\\" + strInfo + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        }
                        else
                        {
                            worksheet.SaveAs("D:\\PWMS\\EXCEL\\" + strInfo + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        }
                    }
                    else
                    {
                        worksheet.Copy(Type.Missing, Type.Missing);
                    }
                    workbook.Save();//保存工作表          
                }
                DialogResult result = MessageBox.Show("基本信息表导出到Excel成功，位置: D:\\PWMS\\EXCEL", "提示");
                if (result == DialogResult.OK)
                {
                    excel.Quit();
                }
                status_bar.Items[4].Text = "null";
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "导出失败！请检查是否为microsoft office2019及以下版本！", "提示");
            }
        }





        //点击切换数据-工作简历
        public void wtxtchange(DataGridView DGrid)
        {
            Myformat.Ena_Button(btn_winsert, btn_wupdate, btn_wcancel, btn_wsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_work.Controls, 5, false);

            if (dgv_show_work.CurrentCell.RowIndex > -1)
            {
                w_2.Text = Myformat.Date_Format(Convert.ToString(DGrid[2, DGrid.CurrentCell.RowIndex].Value).Trim());
                w_3.Text = Myformat.Date_Format(Convert.ToString(DGrid[3, DGrid.CurrentCell.RowIndex].Value).Trim());
                w_4.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
                w_5.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
                w_6.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
            }
        }

        //点击切换数据-工作简历
        private void dgv_show_work_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            wtxtchange(dgv_show_work);
        }

        //添加-工作简历
        private void btn_winsert_Click(object sender, EventArgs e)
        {
            hold_n = 1;
            Myformat.Ena_Button(btn_winsert, btn_wupdate, btn_wcancel, btn_wsave, 0, 0, 1, 1);
            Myformat.Clear_Control(gb_work.Controls);
            Myformat.allreadonly_work(gb_work.Controls, 5, true);
            Part_ID = Myformat.GetAutocoding("tb_WordResume", "ID");
            status_bar.Items[4].Text = "正在添加数据...";
            btn_wdelete.Enabled = false;
            dgv_show_work.Enabled = false;
            dgv_show.Enabled = false;
            gb_read.Enabled = false;
            gb_select.Enabled = false;
        }

        //修改-工作简历
        private void btn_wupdate_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                hold_n = 2;
                Myformat.Ena_Button(btn_winsert, btn_wupdate, btn_wcancel, btn_wsave, 0, 0, 1, 1);
                Myformat.allreadonly_work(gb_work.Controls, 5, true);
                status_bar.Items[4].Text = "正在修改数据...";
                btn_wdelete.Enabled = false;
                dgv_show_work.Enabled = false;
                dgv_show.Enabled = false;
                gb_read.Enabled = false;
                gb_select.Enabled = false;
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //删除-工作简历
        private void btn_wdelete_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                status_bar.Items[4].Text = "正在删除数据...";
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_show_work.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_show_work.CurrentRow.Index != dgv_show_work.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_show_work.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MyDataClass.getsqlcom("Delete tb_WordResume where ID='" + dgv_show_work[1, dgv_show_work.CurrentCell.RowIndex].Value.ToString() + "'");
                        btn_wcancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                        status_bar.Items[4].Text = "无";
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //取消-工作简历
        private void btn_wcancel_Click(object sender, EventArgs e)
        {
            hold_n = 0;
            Myformat.Ena_Button(btn_winsert, btn_wupdate, btn_wcancel, btn_wsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_work.Controls, 5, false);
            status_bar.Items[4].Text = "无";
            btn_wdelete.Enabled = true;
            dgv_show_work.Enabled = true;
            dgv_show.Enabled = true;
            if (tem_Field == "")
            {
                btn_show_Click(sender, e);
                gb_read.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
                selectdata(tem_Value);
            }
        }

        //保存-工作简历
        private void btn_wsave_Click(object sender, EventArgs e)
        {
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            ModuleClass.MyModule.ADDs = "";
            string Work_Field = "Stu_ID,ID,BeginDate,EndDate,Branch,Business,WordUnit";
            if (hold_n == 1 || hold_n == 2)
            {
                if (hold_n == 2)
                {
                    if (dgv_show_work.RowCount < 1)
                    {
                        MessageBox.Show("数据表为空，不可以修改");
                    }
                    else
                    {
                        Part_ID = dgv_show_work[1, dgv_show_work.CurrentCell.RowIndex].Value.ToString();
                    }
                }
                Myformat.Part_SaveClass(Work_Field, tem_ID, Part_ID, gb_work.Controls, "w_", "tb_WordResume", 7, hold_n);
                if (ModuleClass.MyModule.ADDs != "")
                {
                    MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                }
                status_bar.Items[4].Text = "无";
            }
            btn_wcancel_Click(sender, e);
            hold_n = 0;
        }




        //点击切换数据-家庭关系
        public void ftxtchange(DataGridView DGrid)
        {
            Myformat.Ena_Button(btn_finsert, btn_fupdate, btn_fcancel, btn_fsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_famliy.Controls, 7, false);

            if (dgv_famliy.CurrentCell.RowIndex > -1)
            {
                F_2.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                F_3.Text = DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
                F_4.Text = Myformat.Date_Format(Convert.ToString(DGrid[4, DGrid.CurrentCell.RowIndex].Value).Trim());
                F_5.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
                F_6.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
                F_7.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
                F_8.Text = DGrid[8, DGrid.CurrentCell.RowIndex].Value.ToString();
            }
        }

        //点击切换数据-家庭关系
        private void dgv_famliy_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ftxtchange(dgv_famliy);
        }

        //添加-家庭关系
        private void btn_finsert_Click(object sender, EventArgs e)
        {
            hold_n = 1;
            Myformat.Ena_Button(btn_finsert, btn_fupdate, btn_fcancel, btn_fsave, 0, 0, 1, 1);
            Myformat.Clear_Control(gb_famliy.Controls);
            Myformat.allreadonly_work(gb_famliy.Controls, 7, true);
            Part_ID = Myformat.GetAutocoding("tb_Family", "ID");
            status_bar.Items[4].Text = "正在添加数据...";
            btn_fdelete.Enabled = false;
            dgv_famliy.Enabled = false;
            dgv_show.Enabled = false;
            gb_read.Enabled = false;
            gb_select.Enabled = false;
        }

        //修改-家庭关系
        private void btn_fupdate_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                hold_n = 2;
                Myformat.Ena_Button(btn_finsert, btn_fupdate, btn_fcancel, btn_fsave, 0, 0, 1, 1);
                Myformat.allreadonly_work(gb_famliy.Controls, 7, true);
                status_bar.Items[4].Text = "正在修改数据...";
                btn_fdelete.Enabled = false;
                dgv_famliy.Enabled = false;
                dgv_show.Enabled = false;
                gb_read.Enabled = false;
                gb_select.Enabled = false;
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }

        }

        //删除-家庭关系
        private void btn_fdelete_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                status_bar.Items[4].Text = "正在删除数据...";
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_famliy.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_famliy.CurrentRow.Index != dgv_famliy.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_famliy.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MyDataClass.getsqlcom("Delete tb_Family where ID='" + dgv_famliy[1, dgv_famliy.CurrentCell.RowIndex].Value.ToString() + "'");
                        btn_fcancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                        status_bar.Items[4].Text = "无";
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //取消-家庭关系
        private void btn_fcancel_Click(object sender, EventArgs e)
        {
            hold_n = 0;
            Myformat.Ena_Button(btn_finsert, btn_fupdate, btn_fcancel, btn_fsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_famliy.Controls, 7, false);
            status_bar.Items[4].Text = "无";
            btn_fdelete.Enabled = true;
            dgv_famliy.Enabled = true;
            dgv_show.Enabled = true;
            if (tem_Field == "")
            {
                btn_show_Click(sender, e);
                gb_read.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
                selectdata(tem_Value);
            }
        }

        //保存-家庭关系
        private void btn_fsave_Click(object sender, EventArgs e)
        {
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            ModuleClass.MyModule.ADDs = "";
            string Famliy_Field = "ID,Stu_ID,LeaguerName,Nexus,BirthDate,WordUnit,Business,Visage,Phone";
            if (hold_n == 1 || hold_n == 2)
            {
                if (hold_n == 2)
                {
                    if (dgv_famliy.RowCount < 1)
                    {
                        MessageBox.Show("数据表为空，不可以修改");
                    }
                    else
                    {
                        Part_ID = dgv_famliy[1, dgv_famliy.CurrentCell.RowIndex].Value.ToString();
                    }
                }
                Myformat.Part_SaveClass(Famliy_Field, tem_ID, Part_ID, gb_famliy.Controls, "F_", "tb_Family", 9, hold_n);
                if (ModuleClass.MyModule.ADDs != "")
                {
                    MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                }
                status_bar.Items[4].Text = "无";
            }
            btn_fcancel_Click(sender, e);
            hold_n = 0;
        }





        //点击切换数据-培训记录
        public void ttxtchange(DataGridView DGrid)
        {
            Myformat.Ena_Button(btn_tinsert, btn_tupdate, btn_tcancel, btn_tsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_train.Controls, 8, false);

            if (dgv_train.CurrentCell.RowIndex > -1)
            {
                T_2.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                T_3.Text = Myformat.Date_Format(Convert.ToString(DGrid[3, DGrid.CurrentCell.RowIndex].Value).Trim());
                T_4.Text = Myformat.Date_Format(Convert.ToString(DGrid[4, DGrid.CurrentCell.RowIndex].Value).Trim());
                T_5.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
                T_6.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
                T_7.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
                T_8.Text = DGrid[8, DGrid.CurrentCell.RowIndex].Value.ToString();
                T_9.Text = DGrid[9, DGrid.CurrentCell.RowIndex].Value.ToString();
            }
        }

        //点击切换数据-培训记录
        private void dgv_train_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ttxtchange(dgv_train);
        }

        //添加-培训记录
        private void btn_tinsert_Click(object sender, EventArgs e)
        {
            hold_n = 1;
            Myformat.Ena_Button(btn_tinsert, btn_tupdate, btn_tcancel, btn_tsave, 0, 0, 1, 1);
            Myformat.Clear_Control(gb_train.Controls);
            Myformat.allreadonly_work(gb_train.Controls, 8, true);
            Part_ID = Myformat.GetAutocoding("tb_TrainNote", "ID");
            status_bar.Items[4].Text = "正在添加数据...";
            btn_tdelete.Enabled = false;
            dgv_train.Enabled = false;
            dgv_show.Enabled = false;
            gb_read.Enabled = false;
            gb_select.Enabled = false;
        }

        //修改-培训记录
        private void btn_tupdate_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                hold_n = 2;
                Myformat.Ena_Button(btn_tinsert, btn_tupdate, btn_tcancel, btn_tsave, 0, 0, 1, 1);
                Myformat.allreadonly_work(gb_train.Controls, 8, true);
                status_bar.Items[4].Text = "正在修改数据...";
                btn_tdelete.Enabled = false;
                dgv_train.Enabled = false;
                dgv_show.Enabled = false;
                gb_read.Enabled = false;
                gb_select.Enabled = false;
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //删除-培训记录
        private void btn_tdelete_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                status_bar.Items[4].Text = "正在删除数据...";
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_train.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_train.CurrentRow.Index != dgv_train.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_train.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MyDataClass.getsqlcom("Delete tb_TrainNote where ID='" + dgv_train[1, dgv_train.CurrentCell.RowIndex].Value.ToString() + "'");
                        btn_tcancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                        status_bar.Items[4].Text = "无";
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //取消-培训记录
        private void btn_tcancel_Click(object sender, EventArgs e)
        {
            hold_n = 0;
            Myformat.Ena_Button(btn_finsert, btn_tupdate, btn_tcancel, btn_tsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_train.Controls, 7, false);
            status_bar.Items[4].Text = "无";
            btn_tdelete.Enabled = true;
            dgv_train.Enabled = true;
            dgv_show.Enabled = true;
            if (tem_Field == "")
            {
                btn_show_Click(sender, e);
                gb_read.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
                selectdata(tem_Value);
            }
        }

        //保存-培训记录
        private void btn_tsave_Click(object sender, EventArgs e)
        {
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            ModuleClass.MyModule.ADDs = "";
            string Train_Field = "ID,Stu_ID,TrainFashion,BeginDate,EndDate,Speciality,TrainUnit,KulturMemo,Charge,Effect";
            if (hold_n == 1 || hold_n == 2)
            {
                if (hold_n == 2)
                {
                    if (dgv_train.RowCount < 1)
                    {
                        MessageBox.Show("数据表为空，不可以修改");
                    }
                    else
                    {
                        Part_ID = dgv_train[1, dgv_train.CurrentCell.RowIndex].Value.ToString();
                    }
                }
                Myformat.Part_SaveClass(Train_Field, tem_ID, Part_ID, gb_train.Controls, "T_", "tb_TrainNote", 10, hold_n);
                if (ModuleClass.MyModule.ADDs != "")
                {
                    MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                }
                status_bar.Items[4].Text = "无";
            }
            btn_tcancel_Click(sender, e);
            hold_n = 0;
        }





        //点击切换数据-培训记录
        public void rtxtchange(DataGridView DGrid)
        {
            Myformat.Ena_Button(btn_rinsert, btn_rupdate, btn_rcancel, btn_rsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_reward.Controls, 5, false);

            if (dgv_reward.CurrentCell.RowIndex > -1)
            {
                R_2.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                R_3.Text = Myformat.Date_Format(Convert.ToString(DGrid[3, DGrid.CurrentCell.RowIndex].Value).Trim());
                R_4.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
                R_5.Text = Myformat.Date_Format(Convert.ToString(DGrid[5, DGrid.CurrentCell.RowIndex].Value).Trim());
                R_6.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
            }
        }

        //点击切换数据-培训记录
        private void dgv_reward_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtxtchange(dgv_reward);
        }

        //添加-培训记录
        private void btn_rinsert_Click(object sender, EventArgs e)
        {
            hold_n = 1;
            Myformat.Ena_Button(btn_tinsert, btn_rupdate, btn_rcancel, btn_rsave, 0, 0, 1, 1);
            Myformat.Clear_Control(gb_reward.Controls);
            Myformat.allreadonly_work(gb_reward.Controls, 5, true);
            Part_ID = Myformat.GetAutocoding("tb_RANDP", "ID");
            status_bar.Items[4].Text = "正在添加数据...";
            btn_rdelete.Enabled = false;
            dgv_reward.Enabled = false;
            dgv_show.Enabled = false;
            gb_read.Enabled = false;
            gb_select.Enabled = false;
        }

        //修改-培训记录
        private void btn_rupdate_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                hold_n = 2;
                Myformat.Ena_Button(btn_tinsert, btn_rupdate, btn_rcancel, btn_rsave, 0, 0, 1, 1);
                Myformat.allreadonly_work(gb_reward.Controls, 5, true);
                status_bar.Items[4].Text = "正在修改数据...";
                btn_rdelete.Enabled = false;
                dgv_reward.Enabled = false;
                dgv_show.Enabled = false;
                gb_read.Enabled = false;
                gb_select.Enabled = false;
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }

        }

        //删除-培训记录
        private void btn_rdelete_Click(object sender, EventArgs e)
        {
            if (dgv_show.Rows.Count > 0)
            {
                status_bar.Items[4].Text = "正在删除数据...";
                DialogResult result = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel);
                if (dgv_reward.CurrentRow.Index == 0)
                {
                    MessageBox.Show("首条记录无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_reward.CurrentRow.Index != dgv_reward.Rows.Count - 1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }

                if (dgv_reward.RowCount < 2)
                {
                    MessageBox.Show("当前已是最后一条！无法删除！", "提示");
                    status_bar.Items[4].Text = "无";
                    return;
                }
                else
                {
                    if (result == DialogResult.OK)
                    {
                        MyDataClass.getsqlcom("Delete tb_RANDP where ID='" + dgv_reward[1, dgv_reward.CurrentCell.RowIndex].Value.ToString() + "'");
                        btn_rcancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("您选择了取消删除！", "提示");
                        status_bar.Items[4].Text = "无";
                    }
                }
            }
            else
            {
                MessageBox.Show("当前无数据！", "提示");
            }
        }

        //取消-培训记录
        private void btn_rcancel_Click(object sender, EventArgs e)
        {
            hold_n = 0;
            Myformat.Ena_Button(btn_tinsert, btn_rupdate, btn_rcancel, btn_rsave, 1, 1, 0, 0);
            Myformat.allreadonly_work(gb_reward.Controls, 5, false);
            status_bar.Items[4].Text = "无";
            btn_rdelete.Enabled = true;
            dgv_reward.Enabled = true;
            dgv_show.Enabled = true;
            if (tem_Field == "")
            {
                btn_show_Click(sender, e);
                gb_read.Enabled = true;
                gb_select.Enabled = true;
            }
            else
            {
                selectdata(tem_Value);
            }
        }

        //保存-培训记录
        private void btn_rsave_Click(object sender, EventArgs e)
        {
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            ModuleClass.MyModule.ADDs = "";
            string Reward_Field = "ID,Stu_ID,RPKind,RPDate,SealMan,QuashDate,QuashWhys";
            if (hold_n == 1 || hold_n == 2)
            {
                if (hold_n == 2)
                {
                    if (dgv_reward.RowCount < 1)
                    {
                        MessageBox.Show("数据表为空，不可以修改");
                    }
                    else
                    {
                        Part_ID = dgv_reward[1, dgv_reward.CurrentCell.RowIndex].Value.ToString();
                    }
                }
                Myformat.Part_SaveClass(Reward_Field, tem_ID, Part_ID, gb_reward.Controls, "R_", "tb_RANDP", 7, hold_n);
                if (ModuleClass.MyModule.ADDs != "")
                {
                    MyDataClass.getsqlcom(ModuleClass.MyModule.ADDs);
                }
                status_bar.Items[4].Text = "无";
            }
            btn_rcancel_Click(sender, e);
            hold_n = 0;
        }





        //保存-个人评价
        private void btn_save_Biography_Click(object sender, EventArgs e)
        {
            status_bar.Items[4].Text = "正在保存数据...";
            Myformat.pcbusing(pcb_basic, 0, 100, 20);
            SqlDataReader Read_Memo = MyDataClass.getcom("Select * from tb_Individual where ID='" + tem_ID + "'");
            if (Read_Memo.Read())
                MyDataClass.getsqlcom("update tb_Individual set Memo='" + Ind_Mome.Text + "' where ID='" + tem_ID + "'");
            else
                MyDataClass.getsqlcom("insert into tb_Individual (ID,Memo) values('" + tem_ID + "','" + Ind_Mome.Text + "')");
            btn_cancel_Click(sender, e);
            status_bar.Items[4].Text = "无";
        }
    }
}
