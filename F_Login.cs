using PWMS.InfoAddForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS
{
    public partial class F_Login : Form
    {
        //引用MyMeans类
        DataClass.MyMeans MyClass = new PWMS.DataClass.MyMeans();

        public F_Login()
        {
            InitializeComponent();

            //设置文本框格式为*
            txt_pwd.PasswordChar = '*';

            #region 测试时用的更新验证
            //MyClass.getcom("select ID from tb_Update_ID");
            //DataSet DS_ID_flag= MyClass.getDataSet("select ID from tb_Update_ID", "tb_Update_ID");
            //int ID_flag = Convert.ToInt32(DS_ID_flag.Tables[0].Rows[0][0]);
            //if (ID_flag == 1)
            //{
            //    MessageBox.Show("软件需要更新，即将跳转到下载页面！", "提示");
            //    System.Diagnostics.Process.Start("http://10.91.217.185:8888/aspnet_client/PWMS/");//此处网页站点可以自己创建发布
            //    btn_Login.Enabled = false;
            //}
            //else
            //{
            //    //无需操作
            //}
            #endregion

            #region 数据库验证
            try
            {
                MyClass.con_open();
                MyClass.con_close();
                txt_name.Text = "".Trim();
                txt_pwd.Text = "".Trim();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("数据库连接失败" + ex);
                Application.Exit();
            }
            #endregion
        }

        //登录
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "" && txt_pwd.Text != "")
                {
                    //用户名密码判断
                    SqlDataReader login_test = MyClass.getcom("Select * from tb_Login where Name='" + txt_name.Text.Trim() + "'and Pass='" + txt_pwd.Text.Trim() + "'");
                    bool sda_login_read = login_test.Read();
                    if (sda_login_read == true)
                    {
                        //判断是否有用户登录，用Flag（1或0）记录
                        SqlDataReader login_flag = MyClass.getcom("Select Flag from tb_Login where Flag=1");
                        bool sda_login_flag_read =login_flag.Read();
                        if (sda_login_flag_read ==false)
                        {
                            lbl_warning.Text = "登录成功！";
                            //用于更新ID
                            MyClass.getsqlcom("update tb_Login set Flag=1 where Name='"+ txt_name.Text.Trim()+"'");
                            //传入登录名
                            DataClass.MyMeans.Login_Name = txt_name.Text.Trim();                                            
                            //Thread.Sleep(1000); //登录延时
                            this.Hide();
                            F_Main f_main = new F_Main();
                            f_main.Show();
                        }
                        else
                        {
                            //判断是否有用户登录，用Flag（1或0）记录
                            SqlDataReader login_flag_now = MyClass.getcom("Select Flag from tb_Login where Name='" + txt_name.Text.Trim() + "'and Pass='" + txt_pwd.Text.Trim() + "' and Flag=1");
                            bool sda_login_flag_now = login_flag_now.Read();
                            if (sda_login_flag_now == true)
                            {
                                MessageBox.Show("当前用户已登录！", "提示");
                            }
                            else
                            {
                                MessageBox.Show("其他用户正在进行操作！", "请稍等");
                            }
                        }
                    }
                    else
                    {
                        lbl_warning.Text = "用户名或密码错误！";
                    }
                }
                else
                {
                    if (txt_name.Text == ""|| txt_pwd.Text == "")
                    {
                        lbl_warning.Text = "请填写完整信息！";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败！" + ex);
            }
        }


        //清空文本
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.Text = "".Trim();
            txt_pwd.Text = "".Trim();
        }

        //注册窗口打开
        private void lbl_enroll_Click(object sender, EventArgs e)
        {
            F_Enroll f_enroll = new F_Enroll();
            f_enroll.ShowDialog();
            txt_name.Text = "";
            txt_pwd.Text = "";
            lbl_warning.Text = "";
        }

        //账号换行至密码
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')  
            {
                txt_pwd.Focus();
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //密码回车后登录
        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_Login_Click(sender,e);
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //进入时聚焦点
        private void F_Login_Activated(object sender, EventArgs e)
        {
            txt_name.Focus();
        }

        //文本改变清空提示
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            lbl_warning.Text = "";
        }

        //文本改变清空提示
        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {
            lbl_warning.Text = "";
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
