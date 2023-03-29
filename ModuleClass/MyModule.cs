using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using PWMS.PerForm;
using System.Text;
using System.Linq;

namespace PWMS.ModuleClass
{
    class MyModule
    {
        #region 公共变量
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();//调用Mymean
        public static string ADDs = "";//存储sql
        public static string FindValue = "";//存储条件
        public static string Address_ID = "";//存储通讯录添加修改时的ID编号
        public static string User_ID = "";//存储用户ID
        public static string User_Name = "";//存储用户名
        #endregion

        //-------------------------------F_Main
        #region 窗体调用-Show_form/F_Main
        ///<sunmmary>
        /// 窗体调用
        ///</sunmmary> 
        ///<param name="FrmName">调用窗体的text属性值</param>
        ///<param name="n">标识</param>
        public void Show_form(string FrmName, int n)
        {
            if (n == 1)
            {
                if (FrmName == "人事档案管理")
                {
                    PerForm.F_ManFile f_ManFile = new PWMS.PerForm.F_ManFile();
                    f_ManFile.Text = "人事档案管理";
                    f_ManFile.ShowDialog();
                    f_ManFile.Dispose();
                }
                if (FrmName == "人事资料查询")
                {
                    PerForm.F_Find f_Find = new PWMS.PerForm.F_Find();
                    f_Find.Text = "人事资料查询";
                    f_Find.ShowDialog();
                    f_Find.Dispose();
                }
                if (FrmName == "员工合同提示")
                {
                    PerForm.F_ClewSet f_ClewSet = new PWMS.PerForm.F_ClewSet();
                    f_ClewSet.Text = "员工合同提示";
                    f_ClewSet.ShowDialog();
                    f_ClewSet.Dispose();
                }
                if (FrmName == "通讯录")
                {
                    PerForm.F_AddressList f_AddressList = new PWMS.PerForm.F_AddressList();
                    f_AddressList.Text = "通讯录";
                    f_AddressList.ShowDialog();
                    f_AddressList.Dispose();
                }
                if (FrmName == "日常记事")
                {
                    PerForm.F_WordPad f_WordPad = new PWMS.PerForm.F_WordPad();
                    f_WordPad.Text = "日常记事";
                    f_WordPad.ShowDialog();
                    f_WordPad.Dispose();
                }
            }
            if (n == 2)
            {
                String Frmstr = "";//记录窗口名称
                if (FrmName == "民族类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Folk ";
                    DataClass.MyMeans.Mean_Table = "tb_Folk";
                    DataClass.MyMeans.Mean_Field = "FolkName";
                    Frmstr = FrmName;
                }

                if (FrmName == "职工类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Table = "tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Field = "EmployeeName";
                    Frmstr = FrmName;
                }

                if (FrmName == "文化程度设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Kultur";
                    DataClass.MyMeans.Mean_Table = "tb_Kultur";
                    DataClass.MyMeans.Mean_Field = "KulturName";
                    Frmstr = FrmName;
                }

                if (FrmName == "政治面貌设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Visage";
                    DataClass.MyMeans.Mean_Table = "tb_Visage";
                    DataClass.MyMeans.Mean_Field = "VisageName";
                    Frmstr = FrmName;
                }

                if (FrmName == "部门类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Branch";
                    DataClass.MyMeans.Mean_Table = "tb_Branch";
                    DataClass.MyMeans.Mean_Field = "BranchName";
                    Frmstr = FrmName;
                }

                if (FrmName == "工资类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Laborage";
                    DataClass.MyMeans.Mean_Table = "tb_Laborage";
                    DataClass.MyMeans.Mean_Field = "LaborageName";
                    Frmstr = FrmName;
                }

                if (FrmName == "职务类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Business";
                    DataClass.MyMeans.Mean_Table = "tb_Business";
                    DataClass.MyMeans.Mean_Field = "BusinessName";
                    Frmstr = FrmName;
                }

                if (FrmName == "职称类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Duthcall";
                    DataClass.MyMeans.Mean_Table = "tb_Duthcall";
                    DataClass.MyMeans.Mean_Field = "DuthcallName";
                    Frmstr = FrmName;
                }

                if (FrmName == "奖惩类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_RPKind";
                    DataClass.MyMeans.Mean_Table = "tb_RPKind";
                    DataClass.MyMeans.Mean_Field = "RPKind";
                    Frmstr = FrmName;
                }

                if (FrmName == "记事本类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_WordPad";
                    DataClass.MyMeans.Mean_Table = "tb_WordPad";
                    DataClass.MyMeans.Mean_Field = "WordPad";
                    Frmstr = FrmName;
                }
                SecondaryForm.F_Basic f_Basic = new PWMS.SecondaryForm.F_Basic();
                f_Basic.Text = Frmstr;
                f_Basic.ShowDialog();
                f_Basic.Dispose();
            }
            if (n == 3)
            {
                if (FrmName == "日常记事")
                {
                    PerForm.F_WordPad f_WordPad = new PWMS.PerForm.F_WordPad();
                    f_WordPad.Text = "日常记事";
                    f_WordPad.ShowDialog();
                    f_WordPad.Dispose();
                }

                if (FrmName == "通讯录")
                {
                    PerForm.F_AddressList f_AddressList = new PWMS.PerForm.F_AddressList();
                    f_AddressList.Text = "通讯录";
                    f_AddressList.ShowDialog();
                    f_AddressList.Dispose();
                }

                if (FrmName == "人事档案管理")
                {
                    PerForm.F_ManFile f_ManFile = new PWMS.PerForm.F_ManFile();
                    f_ManFile.Text = "人事档案管理";
                    f_ManFile.ShowDialog();
                    f_ManFile.Dispose();
                }

                if (FrmName == "人事资料查询")
                {
                    PerForm.F_Find FrmFind = new PWMS.PerForm.F_Find();
                    FrmFind.Text = "人事资料查询";
                    FrmFind.ShowDialog();
                    FrmFind.Dispose();
                }

                if (FrmName == "人事资料统计")
                {
                    PerForm.F_Stat f_Stat = new PWMS.PerForm.F_Stat();
                    f_Stat.Text = "人事资料统计";
                    f_Stat.ShowDialog();
                    f_Stat.Dispose();
                }

                if (FrmName == "备份/还原数据库")
                {
                    PerForm.F_HaveBack f_HaveBack = new PWMS.PerForm.F_HaveBack();
                    f_HaveBack.Text = "备份/还原数据库";
                    f_HaveBack.ShowDialog();
                    f_HaveBack.Dispose();
                }

                if (FrmName == "清空数据库")
                {
                    PerForm.F_ClearData f_ClearData = new PWMS.PerForm.F_ClearData();
                    f_ClearData.Text = "清空数据库";
                    f_ClearData.ShowDialog();
                    f_ClearData.Dispose();
                }

                if (FrmName == "计算器")
                {
                    try
                    {
                        System.Diagnostics.Process.Start("calc.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("请检查系统中是否存在计算器程序！" + ex);
                    }
                }

                if (FrmName == "记事本")
                {
                    try
                    {
                        System.Diagnostics.Process.Start("notepad.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("请检查系统中是否存在记事本程序！" + ex);
                    }
                }

                if (FrmName == "用户设置")
                {
                    PerForm.F_user f_user = new PWMS.PerForm.F_user();
                    f_user.Text = "用户设置";
                    f_user.ShowDialog();
                    f_user.Dispose();
                }

                if (FrmName == "系统退出")
                {
                    Application.Exit();
                }
            }
        }
        #endregion

        #region  MenuStrip信息添加至treeView-GetMenu/F_Main
        /// <summary>
        /// 读取菜单中的信息.
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="Menus">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip Menus)
        {
            //遍历以一级菜单
            for (int i = 0; i < Menus.Items.Count; i++)
            {
                //添加一级菜单到TreeView节点中，子节点为TN1
                TreeNode TN1 = treeV.Nodes.Add(Menus.Items[i].Text);
                //把当前内容存储到对象ToolStripDropDownItem中
                ToolStripDropDownItem TSDDI1 = (ToolStripDropDownItem)Menus.Items[i];
                //判断是否有二级菜单
                if (TSDDI1.HasDropDownItems && TSDDI1.DropDownItems.Count > 0)
                {
                    //遍历二级菜单
                    for (int j = 0; j < TSDDI1.DropDownItems.Count; j++)
                    {
                        //添加二级菜单到TN1节点中，设置此子节点为TN2
                        TreeNode TN2 = TN1.Nodes.Add(TSDDI1.DropDownItems[j].Text);
                        //把当前内容存储到对象ToolStripDropDownItem中
                        ToolStripDropDownItem TSDDI2 = (ToolStripDropDownItem)TSDDI1.DropDownItems[j];
                        //判断是否有三级菜单
                        if (TSDDI2.HasDropDownItems && TSDDI2.DropDownItems.Count > 0)
                        {
                            //遍历三级菜单
                            for (int k = 0; k < TSDDI2.DropDownItems.Count; k++)
                            {
                                //将三级菜单添加到TN2子节点中
                                TN2.Nodes.Add(TSDDI2.DropDownItems[k].Text);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region  根据用户权限设置主窗体菜单/F_Main
        /// <summary>
        /// 根据用户权限设置菜单是否可用.
        /// </summary>
        /// <param name="MenuS">MenuStrip控件</param>
        /// <param name="UName">当前登录用户名</param>
        public void MainPope(MenuStrip MenuS, String UName)
        {
            int sPope;//用于返回权限1或0
            string MenuName = "";//存储菜单栏
            bool flag;//逻辑判断方便后续维护
            try
            {
                //查询权限表中是否有登录名
                DataSet Dset = MyDataClass.getDataSet("select PopeName from tb_UserPope where PopeName='" + UName + "'", "tb_UserPope");
                //返回操作名
                string cNameT = (Dset.Tables[0].Rows[0][0]).ToString();
                //若返回有值
                if (cNameT != null)
                {
                    //查询权限表中该用户权限
                    Dset = MyDataClass.getDataSet("select PopeName,Pope from tb_UserPope where PopeName='" + UName + "'", "tb_UserPope");
                    //有数据正常执行，无数据返回异常，进入catch
                    sPope = Convert.ToInt32(Dset.Tables[0].Rows[0][1]);
                    if (sPope == 1)
                    {
                        //无需任何执行即可
                    }
                    else
                    {
                        flag = false;//标识为否
                        for (int i = 0; i < MenuS.Items.Count; i++)
                        {
                            //把当前内容存储到对象ToolStripDropDownItem中
                            ToolStripDropDownItem TSDDI1 = (ToolStripDropDownItem)MenuS.Items[i];
                            //判断是否有二级菜单
                            if (TSDDI1.HasDropDownItems && TSDDI1.DropDownItems.Count > 0)
                            {
                                //遍历二级菜单
                                for (int j = 0; j < TSDDI1.DropDownItems.Count; j++)
                                {
                                    //将TSDDI1中数据存储至MenuName
                                    MenuName = TSDDI1.DropDownItems[j].Name;
                                    //DropDownItems部分设置为否不打开
                                    TSDDI1.DropDownItems[j].Enabled = flag;
                                    //把当前内容存储到对象ToolStripDropDownItem中
                                    ToolStripDropDownItem TSSDI2 = (ToolStripDropDownItem)TSDDI1.DropDownItems[j];
                                    //判断是否有三级菜单
                                    if (TSSDI2.HasDropDownItems && TSSDI2.DropDownItems.Count > 0)
                                    {
                                        //遍历三级菜单
                                        for (int k = 0; k < TSSDI2.DropDownItems.Count; k++)
                                        {
                                            //将TSSDI2中数据存储至MenuName
                                            MenuName = TSSDI2.DropDownItems[k].Name;
                                            //DropDownItems部分设置为否不打
                                            TSSDI2.DropDownItems[k].Enabled = flag;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                flag = false;//标识为否
                //遍历一级目录
                for (int i = 0; i < MenuS.Items.Count; i++)
                {
                    //把当前内容存储到对象ToolStripDropDownItem中
                    ToolStripDropDownItem TSDDI1 = (ToolStripDropDownItem)MenuS.Items[i];
                    //判断是否有二级菜单
                    if (TSDDI1.HasDropDownItems && TSDDI1.DropDownItems.Count > 0)
                    {
                        //遍历二级菜单
                        for (int j = 0; j < TSDDI1.DropDownItems.Count; j++)
                        {
                            //将TSDDI1中数据存储至MenuName
                            MenuName = TSDDI1.DropDownItems[j].Name;
                            //DropDownItems部分设置为否不打开
                            TSDDI1.DropDownItems[j].Enabled = flag;
                            //把当前内容存储到对象ToolStripDropDownItem中
                            ToolStripDropDownItem TSSDI2 = (ToolStripDropDownItem)TSDDI1.DropDownItems[j];
                            //判断是否有三级菜单
                            if (TSSDI2.HasDropDownItems && TSSDI2.DropDownItems.Count > 0)
                            {
                                //遍历三级菜单
                                for (int k = 0; k < TSSDI2.DropDownItems.Count; k++)
                                {
                                    //将TSSDI2中数据存储至MenuName
                                    MenuName = TSSDI2.DropDownItems[k].Name;
                                    //DropDownItems部分设置为否不打
                                    TSSDI2.DropDownItems[k].Enabled = flag;
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        //-------------------------------F_Main


        //-------------------------------F_MainFile
        #region  设置MaskedTextBox控件的格式/F_MainFile
        /// <summary>
        /// 将MaskedTextBox控件的格式设为yyyy-mm-dd格式.
        /// </summary>
        /// <param name="MTBox">控件名称</param>
        public void MaskedTextBox_Format(MaskedTextBox MTBox)
        {
            MTBox.Mask = "0000-00-00";
            MTBox.ValidatingType = typeof(System.DateTime);
        }
        #endregion

        #region  向comboBox控件传递数据表中的数据/F_MainFile
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加数据.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="TableName">数据表名称</param>
        public void CbbData(ComboBox cobox, string TableName)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.getcom("select * from " + TableName);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[1].ToString() != "" && MyDR[1].ToString() != null)
                        cobox.Items.Add(MyDR[1].ToString());
                }
            }
        }
        #endregion

        #region  向comboBox控件传递各省市的名称/F_MainFile
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加省名.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="SQLstr">SQL语句</param>
        /// <param name="n">字段位数</param>
        public void CityData(ComboBox cobox, string SQLstr, int n)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.getcom(SQLstr);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[n].ToString() != "" && MyDR[n].ToString() != null)
                        cobox.Items.Add(MyDR[n].ToString());
                }
            }
        }
        #endregion

        #region  遍历清空指定的控件/F_MainFile-职工基本信息
        /// <summary>
        /// 清空所有控件下的所有控件.
        /// </summary>
        /// <param name="Con">可视化控件</param>
        public void Clear_Control(Control.ControlCollection Con)
        {
            foreach (Control C in Con)
            { //遍历可视化组件中的所有控件
                if (C.GetType().Name == "TextBox")  //判断是否为TextBox控件
                    if (((TextBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((TextBox)C).Clear();   //清空当前控件
                if (C.GetType().Name == "MaskedTextBox")  //判断是否为MaskedTextBox控件
                    if (((MaskedTextBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((MaskedTextBox)C).Clear();   //清空当前控件
                if (C.GetType().Name == "ComboBox")  //判断是否为ComboBox控件
                    if (((ComboBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((ComboBox)C).Text = "";   //清空当前控件的Text属性值
                if (C.GetType().Name == "PictureBox")  //判断是否为PictureBox控件
                    if (((PictureBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((PictureBox)C).Image = null;   //清空当前控件的Image属性
            }
        }
        #endregion

        #region  清空控件集上的控件信息/F_MainFile-工作简历
        /// <summary>
        /// 清空GroupBox控件上的控件信息.
        /// </summary>
        /// <param name="n">控件个数</param>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        public void Clear_Grids(int n, Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            for (int i = 1; i < n; i++)
            {
                sID = TName + i.ToString();
                foreach (Control C in GBox)
                {
                    if (C.GetType().Name == "TextBox" || C.GetType().Name == "MaskedTextBox")
                        if (C.Name == sID)
                        {
                            C.Text = "";
                        }
                }
            }
        }
        #endregion

        #region  将日期转换成指定的格式/F_MainFile
        /// <summary>
        /// 将日期转换成yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <returns>返回String对象</returns>
        public string Date_Format(string NDate)
        {
            string sm, sd;
            int y, m, d;
            try
            {
                y = Convert.ToDateTime(NDate).Year;
                m = Convert.ToDateTime(NDate).Month;
                d = Convert.ToDateTime(NDate).Day;
            }
            catch
            {
                return "";
            }
            if (y < 1950)
                return "";
            if (m < 10)
                sm = "0" + Convert.ToString(m);
            else
                sm = Convert.ToString(m);
            if (d < 10)
                sd = "0" + Convert.ToString(d);
            else
                sd = Convert.ToString(d);
            return Convert.ToString(y) + "-" + sm + "-" + sd;
        }
        #endregion

        #region  用按钮控制数据记录移动时，改变按钮的可用状态/F_MainFile
        /// <summary>
        /// 设置按钮是否可用.
        /// </summary>
        /// <param name="B1">按钮1</param>
        /// <param name="B2">按钮2</param>
        /// <param name="B3">按钮3</param>
        /// <param name="B4">按钮4</param>
        /// <param name="n1">开关状态</param>
        /// <param name="n2">开关状态</param>
        /// <param name="n3">开关状态</param>
        /// <param name="n4">开关状态</param>
        public void Ena_Button(Button B1, Button B2, Button B3, Button B4, int n1, int n2, int n3, int n4)
        {
            B1.Enabled = Convert.ToBoolean(n1);
            B2.Enabled = Convert.ToBoolean(n2);
            B3.Enabled = Convert.ToBoolean(n3);
            B4.Enabled = Convert.ToBoolean(n4);
        }
        #endregion

        #region  自动编号/F_MainFile
        /// <summary>
        /// 在添加信息时自动计算编号.
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="ID">字段名</param>
        /// <returns>返回String对象</returns>
        public String GetAutocoding(string TableName, string ID)
        {
            int Num = 0;
            //查找指定表中ID号为最大的记录
            SqlDataReader MyDR = MyDataClass.getcom("select max(" + ID + ") NID from " + TableName);
            if (MyDR.HasRows)   //当查找到记录时
            {
                MyDR.Read();    //读取当前记录
                if (MyDR[0].ToString() == "")
                    return "0001";
                Num = Convert.ToInt32(MyDR[0].ToString());  //将当前找到的最大编号转换成整数
                ++Num;  //最大编号加1
                string s = string.Format("{0:0000}", Num);  //将整数值转换成指定格式的字符串
                return s;   //返回自动生成的编号
            }
            else
            {
                return "0001";  //当数据表没有记录时，返回0001
            }
        }
        #endregion

        #region  保存添加或修改的信息/F_MainFile
        /// <summary>
        /// 保存添加或修改的信息.
        /// </summary>
        /// <param name="Sarr">数据表中的所有字段</param>
        /// <param name="ID1">第一个字段值</param>
        /// <param name="ID2">第二个字段值</param>
        /// <param name="Contr">指定控件的数据集</param>
        /// <param name="BoxName">要搜索的控件名称</param>
        /// <param name="TableName">数据表名称</param>
        /// <param name="n">控件的个数</param>
        /// <param name="m">标识，用于判断是添加还是修改</param>
        public void Part_SaveClass(string Sarr, string ID1, string ID2, Control.ControlCollection Contr, string BoxName, string TableName, int n, int m)
        {
            string tem_Field = "", tem_Value = "";
            int p = 2;
            if (m == 1)
            {    //当m为1时，表示添加数据信息
                if (ID1 != "" && ID2 == "")
                { //根据参数值判断添加的字段
                    tem_Field = "ID";
                    tem_Value = "'" + ID1 + "'";
                    p = 1;
                }
                else
                {
                    tem_Field = "Stu_ID,ID";
                    tem_Value = "'" + ID1 + "','" + ID2 + "'";
                }
            }
            else
                if (m == 2)
            {    //当m为2时，表示修改数据信息
                if (ID1 != "" && ID2 == "")
                { //根据参数值判断添加的字段
                    tem_Value = "ID='" + ID1 + "'";
                    p = 1;
                }
                else
                {
                    tem_Value = "Stu_ID='" + ID1 + "',ID='" + ID2 + "'";
                }

            }

            if (m > 0)
            { //生成部份添加、修改语句
                string[] Parr = Sarr.Split(Convert.ToChar(','));
                for (int i = p; i < n; i++)
                {
                    string sID = BoxName + i.ToString();    //通过BoxName参数获取要进行操作的控件名称
                    foreach (Control C in Contr)
                    {   //遍历控件集中的相关控件
                        if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                            if (C.Name == sID)
                            { //如果在控件集中找到相应的组件
                                string Ctext = C.Text;
                                if (C.GetType().Name == "MaskedTextBox")    //如果当前是MaskedTextBox控件
                                    Ctext = Date_Format(C.Text);    //对当前控件的值进行格式化
                                if (m == 1)
                                {    //组合SQL语句中insert的相关语句
                                    tem_Field = tem_Field + "," + Parr[i];
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + "NULL";
                                    else
                                        tem_Value = tem_Value + "," + "'" + Ctext + "'";
                                }
                                if (m == 2)
                                {    //组合SQL语句中update的相关语句
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + Parr[i] + "=NULL";
                                    else
                                        tem_Value = tem_Value + "," + Parr[i] + "='" + Ctext + "'";
                                }
                            }
                    }
                }
                ADDs = "";
                if (m == 1) //生成SQL的添加语句
                    ADDs = "insert into " + TableName + " (" + tem_Field + ") values(" + tem_Value + ")";
                if (m == 2) //生成SQL的修改语句
                    if (ID2 == "")  //根据ID2参数，判断修改语句的条件
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID1 + "'";
                    else
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID2 + "'";
            }
        }
        #endregion

        #region  将图片存储到数据库中/F_MainFile
        /// <summary>
        /// 以二进制的形式将图片存储到数据库中.
        /// </summary>
        /// <param name="MID">职工编号</param>
        /// <param name="p">图片的二进制形式</param>
        public void SaveImage(string MID, byte[] p)
        {
            MyDataClass.con_open();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Stuffbasic Set Photo=@Photo where ID=" + MID);
            SqlCommand cmd = new SqlCommand(strSql.ToString(), DataClass.MyMeans.My_con);
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = p;
            cmd.ExecuteNonQuery();
            DataClass.MyMeans.My_con.Close();
        }
        #endregion

        #region 整体设置只读/F_MainFile-职工基本信息
        /// <summary>
        /// 整体设置只读
        /// </summary>
        /// <param name="Contr">指定控件的数据集</param>
        /// <param name="BoxName">要搜索的控件名称</param>
        /// <param name="n">控件个数</param>
        /// <param name="flag">控件状态</param>
        public void allreadonly(Control.ControlCollection Contr, string BoxName, int n, bool flag)
        {
            for (int i = 0; i < n; i++)
            {
                foreach (Control C in Contr)
                {

                    if (C.GetType().Name == "TextBox" || C.GetType().Name == "MaskedTextBox" || C.GetType().Name == "ComboBox")
                    {
                        if (C.Name == "S_0")
                        {
                            C.Enabled = false;
                        }
                        else
                        {
                            C.Enabled = flag;
                        }
                    }
                }
            }
        }
        #endregion

        #region 整体设置只读/F_MainFile-工作简历
        /// <summary>
        /// 整体设置只读
        /// </summary>
        /// <param name="Gbox">指定控件的数据集</param>
        /// <param name="n">控件个数</param>
        /// <param name="flag">控件状态</param>
        public void allreadonly_work(Control.ControlCollection Gbox, int n, bool flag)
        {
            for (int i = 0; i < n; i++)
            {
                foreach (Control C in Gbox)
                {
                    if (C.GetType().Name == "TextBox" || C.GetType().Name == "MaskedTextBox" || C.GetType().Name == "ComboBox")
                    {
                        {
                            C.Enabled = flag;
                        }
                    }
                }
            }
        }
        #endregion

        #region 进度条方法/F_MainFile
        /// <summary>
        /// 进度条方法
        /// </summary>
        /// <param name="pcb">进度条控件名</param>
        /// <param name="min">进度条最小值</param>
        /// <param name="max">进度条最大值</param>
        /// <param name="step">进度条递增值</param>
        public void pcbusing(ProgressBar pcb, int min, int max, int step)
        {
            pcb.Visible = true;
            pcb.Minimum = min;
            pcb.Maximum = max;
            pcb.Value = 0;
            pcb.Step = step;
            for (; min < max; min = min + step)
            {
                System.Threading.Thread.Sleep(100);
                pcb.PerformStep();
            }
            MessageBox.Show("保存成功！", " 提示");
            pcb.Visible = false;
        }
        #endregion

        #region 控制数据表的显示字段/F_MainFile-工作简历
        /// <summary>
        /// 通过条件显示相关表的字段，因使用DataGridView控件，添加System.Windows.Forms命名空间
        /// </summary>
        /// <param name="DSet">DataSet类</param>
        /// <param name="DGrid">DataGridView控件</param>
        public void WCorrelation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            DGrid.Columns[2].Width = 150;
            DGrid.Columns[3].Width = 150;
            for (int j = 4; j < 6; j++)
            {
                DGrid.Columns[j].Width = 80;
            }
            DGrid.Columns[6].Width = 240;
            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region 控制数据表的显示字段/F_MainFile-家庭关系
        /// <summary>
        /// 通过条件显示相关表的字段，因使用DataGridView控件，添加System.Windows.Forms命名空间
        /// </summary>
        /// <param name="DSet">DataSet类</param>
        /// <param name="DGrid">DataGridView控件</param>
        public void FCorrelation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            DGrid.Columns[2].Width = 100;
            DGrid.Columns[3].Width = 100;
            DGrid.Columns[4].Width = 150;
            for (int i = 5; i < 8; i++)
            {
                DGrid.Columns[i].Width = 100;
            }

            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region 控制数据表的显示字段/F_MainFile-培训记录
        /// <summary>
        /// 通过条件显示相关表的字段，因使用DataGridView控件，添加System.Windows.Forms命名空间
        /// </summary>
        /// <param name="DSet">DataSet类</param>
        /// <param name="DGrid">DataGridView控件</param>
        public void TCorrelation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            for (int i = 2; i < 9; i++)
            {
                DGrid.Columns[i].Width = 120;
            }

            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region 控制数据表的显示字段/F_MainFile-奖惩记录
        /// <summary>
        /// 通过条件显示相关表的字段，因使用DataGridView控件，添加System.Windows.Forms命名空间
        /// </summary>
        /// <param name="DSet">DataSet类</param>
        /// <param name="DGrid">DataGridView控件</param>
        public void RCorrelation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            for (int i = 2; i < 7; i++)
            {
                DGrid.Columns[i].Width = 120;
            }
            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        //-------------------------------F_MainFile


        //-------------------------------F_Find
        #region  判断字符型日期是否正确/F_Find
        /// <summary>
        /// 将字符型日期转换成日期进行判断.
        /// </summary>
        /// <param name="MTbox">MaskedTextBox控件</param>
        /// <>
        public bool Estimate_Date(MaskedTextBox MTbox)
        {
            try
            {
                DateTime DT = DateTime.Parse(MTbox.Text.Trim());
                return true;
            }
            catch
            {
                MTbox.Text = "";
                MessageBox.Show("日期输入错误或未填写完整，请重新输入！", "提示");
                return false;
            }
        }
        #endregion

        #region  设置文本框只能输入数字型字符串/F_Find
        /// <summary>
        /// 文本框只能输入数字型和单精度型的字符串.
        /// </summary>
        /// <param name="e">KeyPressEventArgs类</param>
        /// <param name="s">文本框的字符串</param>
        /// <param name="n">标识，判断是数字型还是单精度型</param>
        public void Estimate_Key(KeyPressEventArgs e, string s, int n)
        {
            if (n == 0)   //只能输入整型
                if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;   //处理KeyPress事件
                }
            if (n == 1) //可以输入整型或单精度型
            {
                if ((!(e.KeyChar <= '9' && e.KeyChar >= '0')) && e.KeyChar != '.' && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == '.')   //如果输入“.”
                        if (s == "")    //当前文本框为空
                            e.Handled = true;   //处理KeyPress事件
                        else
                        {
                            if (s.Length > 0)   //当文本框不为空时
                            {
                                if (s.IndexOf(".") > -1)    //查找是否已输入过“.”
                                    e.Handled = true;   //处理KeyPress事件
                            }
                        }
                }
            }
        }
        #endregion

        #region  组合查询条件/F_find
        /// <summary>
        /// 根据控件是否为空组合查询条件.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        /// <param name="TName">查询关系</param>
        public void Find_Grids(Control.ControlCollection GBox, string TName, string ANDSign)
        {
            string sID = "";    //定义局部变量
            if (FindValue.Length > 0)
                FindValue = FindValue + ANDSign;
            foreach (Control C in GBox)
            { //遍历控件集上的所有控件
                if (C.GetType().Name == "TextBox" | C.GetType().Name == "ComboBox")
                { //判断是否要遍历的控件
                    if (C.GetType().Name == "ComboBox" && C.Text != "")
                    {   //当指定控件不为空时
                        sID = C.Name;
                        if (sID.IndexOf(TName) > -1)
                        {    //当TName参数是当前控件名中的部分信息时
                            string[] Astr = sID.Split(Convert.ToChar('_')); //用“_”符号分隔当前控件的名称,获取相应的字段名
                            FindValue = FindValue + "(" + Astr[1] + " = '" + C.Text + "')" + ANDSign;   //生成查询条件
                        }
                    }
                    if (C.GetType().Name == "TextBox" && C.Text != "")  //如果当前为TextBox控件，并且控件不为空
                    {
                        sID = C.Name;   //获取当前控件的名称
                        if (sID.IndexOf(TName) > -1)    //判断TName参数值是否为当前控件名的子字符串
                        {
                            string[] Astr = sID.Split(Convert.ToChar('_')); //以“_”为分隔符，将控件名存入到一维数组中
                            string m_Sgin = ""; //用于记录逻辑运算符
                            string mID = "";    //用于记录字段名
                            if (Astr.Length > 2)    //当数组的元素个数大于2时
                                mID = Astr[1] + "_" + Astr[2];  //将最后两个元素组成字段名
                            else
                                mID = Astr[1];  //获取当前条件所对应的字段名称
                            foreach (Control C1 in GBox)    //遍历控件集
                            {
                                if (C1.GetType().Name == "ComboBox")    //判断是否为ComboBox组件
                                    if ((C1.Name).IndexOf(mID) > -1)    //判断当前组件名是否包含条件组件的部分文件名
                                    {
                                        if (C1.Text == "")  //当查询条件为空时
                                            break;  //退出本次循环
                                        else
                                        {
                                            m_Sgin = C1.Text;   //将条件值存储到m_Sgin变量中
                                            break;
                                        }
                                    }
                            }
                            if (m_Sgin != "")   //当该控件件不为空时
                                FindValue = FindValue + "(" + mID + m_Sgin + C.Text + ")" + ANDSign;    //组合SQL语句的查询条件
                        }
                    }
                }
            }
            if (FindValue.Length > 0)   //当存储查询条的变量不为空时，删除逻辑运算符AND和OR
            {
                if (FindValue.IndexOf("AND") > -1)  //判断是否用AND连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);
                if (FindValue.IndexOf("OR") > -1)  //判断是否用OR连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 3);
            }
            else
                FindValue = "";

        }
        #endregion
        //-------------------------------F_Find


        //-------------------------------F_ClewSet
        #region  查询指定范围内生日与合同到期的职工
        /// <summary>
        /// 查询指定范围内生日与合同到期的职工.
        /// </summary>
        public void PactDay()
        {
            DataSet DSet = MyDataClass.getDataSet("select Fate from tb_Clew ", "tb_clew");
            if (DSet.Tables[0].Rows.Count > 0)
            {
                string Vfield = "";
                string dSQL = "";
                int sday = Convert.ToInt32(DSet.Tables[0].Rows[0][0]);
                Vfield = "Pact_E";
                dSQL = "select * from tb_Stuffbasic where ((getdate()-convert(Nvarchar(12)," + Vfield + ",110))>=-" + sday + " and (getdate()-convert(Nvarchar(12)," + Vfield + ",110))<=0)";

                DSet = MyDataClass.getDataSet(dSQL, "tb_Stuffbasic");
                if (DSet.Tables[0].Rows.Count > 0)
                {
                    Vfield = "是否查看" + sday.ToString() + "天内合同到期的职工信息？";
                    if (MessageBox.Show(Vfield, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Show_form("员工合同提示", 1);
                    }
                }

            }
            #endregion
        //-------------------------------F_ClewSet

        } 
    } 
}

