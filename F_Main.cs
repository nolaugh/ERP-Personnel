using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS
{
    public partial class F_Main : Form
    {
        //调用MyMeans类
        DataClass.MyMeans MyClass = new PWMS.DataClass.MyMeans();
        //调用MyModule类
        ModuleClass.MyModule MyMenu = new PWMS.ModuleClass.MyModule();

        public F_Main()
        {
            InitializeComponent();
        }

        //treeview设置
        private void Pree_Main() 
        {
            //传入登录名
            status_bar.Items[2].Text = DataClass.MyMeans.Login_Name;
            //将菜单栏以树状图形式展示
            MyMenu.GetMenu(tn_show, ms_basic);
            //设置用户权限开启功能
            MyMenu.MainPope(ms_basic, DataClass.MyMeans.Login_Name);
;        }

        //加载
        private void F_Main_Load(object sender, EventArgs e)
        {
            //调用方法
            Pree_Main();
            //禁止最大化
            this.MaximizeBox = false;
        }

        //人事档案管理功能
        private void 人事档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断功能是否打开
            if (人事档案管理ToolStripMenuItem1.Enabled == true)
            {
                //调用方法
                MyMenu.Show_form(sender.ToString(), 1);
            }
            else
            {
                MessageBox.Show("当前用户无权限使用！","提示");
            }
        }

        //人事资料查询功能
        private void 人事资料查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断功能是否打开
            if (人事资料查询ToolStripMenuItem1.Enabled == true)
            {
                //调用方法
                MyMenu.Show_form(sender.ToString(), 1);
            }
            else
            {
                MessageBox.Show("当前用户无权限使用！", "提示");
            }
        }

        //员工合同提示功能
        private void 员工合同提示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断功能是否打开
            if (员工合同提示ToolStripMenuItem1.Enabled == true)
            {
                //调用方法
                MyMenu.Show_form(sender.ToString(), 1);
            }
            else
            {
                MessageBox.Show("当前用户无权限使用！", "提示");
            }
        }

        //通讯录功能
        private void 通讯录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断功能是否打开
            if (通讯录ToolStripMenuItem1.Enabled == true)
            {
                //调用方法
                MyMenu.Show_form(sender.ToString(), 1);
            }
            else
            {
                MessageBox.Show("当前用户无权限使用！", "提示");
            }
        }

        //日常记事功能
        private void 日常记事ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断功能是否打开
            if (日常记事ToolStripMenuItem.Enabled == true)
            {
                //调用方法
                MyMenu.Show_form(sender.ToString(), 1);
            }
            else
            {
                MessageBox.Show("当前用户无权限使用！", "提示");
            }
        }

        //退出系统功能
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //改变用户登录状态设置flag为0
            MyClass.getsqlcom("update tb_Login set Flag=0 where Name='" + DataClass.MyMeans.Login_Name + "'");
            Application.Exit();
        }

        //民族类别设置功能
        private void 民族类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //职工类别设置功能
        private void 职工类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //文化程度设置功能
        private void 文化程度设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //政治面貌设置功能
        private void 政治面貌设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //部门类别设置功能
        private void 部门类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //工资类别设置功能
        private void 工资类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //职务类别设置功能
        private void 职务类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //职称类别设置功能
        private void 职称类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //奖惩类别设置功能
        private void 奖惩类别设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //记事本类别设置功能
        private void 记事本类别设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //员工合同提示功能
        private void 员工合同提示ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //员工生日提示功能
        private void 员工生日提示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 2);
        }

        //日常记事功能
        private void 日常记事ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //通讯录功能
        private void 通讯录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //人事档案管理功能
        private void 人事档案管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //人事资料查询功能
        private void 人事资料查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //人事资料统计功能
        private void 人事资料统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //备份还原数据库功能
        private void 备份还原数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //清空数据库功能
        private void 清空数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //记事本功能
        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //记事本功能
        private void 记事本ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //用户设置功能
        private void 用户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //系统退出功能
        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClass.getsqlcom("update tb_Login set Flag=0 where Name='" + DataClass.MyMeans.Login_Name + "'");
            MyMenu.Show_form(sender.ToString(), 3);
        }

        //系统帮助功能
        private void 系统帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系本人邮箱chenyandusts@gmail！", "帮助");
        }

        //重新登录功能
        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //改变用户登录状态设置flag为0
            MyClass.getsqlcom("update tb_Login set Flag=0 where Name='" + DataClass.MyMeans.Login_Name + "'");
            Application.Restart();
        }

        //关闭窗口事件
        private void F_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变用户登录状态设置flag为0
            MyClass.getsqlcom("update tb_Login set Flag=0 where Name='" + DataClass.MyMeans.Login_Name + "'");
            Application.Exit();
        }
    }
}
