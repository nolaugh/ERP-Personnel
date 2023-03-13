using PWMS.DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PWMS.InfoAddForm
{
    public partial class F_Enroll : Form
    {

        //调用MyMeans类
        DataClass.MyMeans MyClass = new PWMS.DataClass.MyMeans();

        public F_Enroll()
        {
            InitializeComponent();

            //设置文本格式*
            txt_epwd.PasswordChar = '*';
            txt_epwd_twice.PasswordChar = '*';

            //设置用户名长度8
            txt_ename.MaxLength = 8;
            //设置密码名长度10
            txt_epwd.MaxLength = 10;
        }

        //注册
        private void btn_enroll_Click(object sender, EventArgs e)
        {
            //注册验证大小写字母及数字
            Regex regex = new Regex(@"^[a-zA-Z0-9]*$");
            string account = txt_ename.Text.ToString();
            string password = txt_epwd.Text.ToString();
            try
            {
                if (lbl_account.Text == "" && lbl_pass.Text == "" && lbl_pass_t.Text == "")
                {
                    if (txt_ename.Text != "" & txt_epwd.Text != "" && txt_epwd_twice.Text != "")
                    {
                        //判断账号首项必须为字母
                        if (account[0] >= 'A' && account[0] <= 'z')
                        {
                            if (regex.IsMatch(account) && regex.IsMatch(password))
                            {

                                if (txt_epwd.Text == txt_epwd_twice.Text)
                                {
                                    //判断账户是否存在
                                    SqlDataReader login_name = MyClass.getcom("select * from tb_Login where Name ='" + txt_ename.Text.Trim() + "'");
                                    bool sda_login_name_read = login_name.Read();
                                    if (sda_login_name_read == false)
                                    {
                                        MyClass.getsqlcom("insert tb_Login(Name,Pass,Flag) values ('" + txt_ename.Text.Trim() + "','" + txt_epwd.Text.Trim() + "',0)");
                                        MyClass.getsqlcom("insert tb_UserPope(PopeName,Pope) values ('" + txt_ename.Text.Trim() + "','0')");
                                        MessageBox.Show("注册成功！", "提示");
                                        lbl_ewarning.Text = " 注册成功！";
                                        this.Close();
                                    }
                                    else
                                    {
                                        lbl_ewarning.Text = ("账户已存在！");
                                    }
                                }
                                else
                                {
                                    lbl_ewarning.Text = "两次输入不一致！";
                                }
                            }
                            else
                            {
                                MessageBox.Show("账户及密码仅支持字母和数字！", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("账户应由大小写字母开头！", "提示");
                        }
                    }
                    else
                    {
                        if (txt_ename.Text == "" || txt_epwd.Text == "" || txt_epwd_twice.Text == "")
                        {
                            lbl_ewarning.Text = "请填写完整信息！";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请检查输入！", "提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败，请检查输入！", "提示" + ex);
            }

        }

        //返回
        private void btn_ecancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //进入时聚焦点
        private void F_Enroll_Activated(object sender, EventArgs e)
        {
            txt_ename.Focus();
        }

        //账号换行至密码
        private void txt_ename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txt_epwd.Focus();
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //密码回车后注册
        private void txt_epwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_enroll_Click(sender, e);
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //再次输入换至注册按钮
        private void txt_epwd_twice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_enroll.Focus();
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //文本框改变
        private void txt_ename_TextChanged(object sender, EventArgs e)
        {
            string account = txt_ename.Text.ToString();
            if (account.Length < 3 || account.Length > 8)
            {
                lbl_account.Text = "账户长度为3至8位！";
            }
            else
            {
                lbl_account.Text = "";
            }
            lbl_ewarning.Text = "";
        }

        //文本框改变
        private void txt_epwd_TextChanged(object sender, EventArgs e)
        {
            string password = txt_epwd.Text.ToString();
            if (password.Length < 3 || password.Length > 10)
            {
                lbl_pass.Text = "密码长度为3至10位！";
            }
            else
            {
                lbl_pass.Text = "";
            }
            lbl_ewarning.Text = "";
        }

        //文本框改变
        private void txt_epwd_twice_TextChanged(object sender, EventArgs e)
        {
            string tpassword = txt_epwd_twice.Text.ToString();
            if (tpassword.Length < 3 || tpassword.Length > 10)
            {
                lbl_pass_t.Text = "密码长度为3至10位！";
            }
            else
            {
                lbl_pass_t.Text = "";
            }
            lbl_ewarning.Text = "";
        }
    }
}
