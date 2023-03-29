using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS.PerForm
{
    public partial class F_user : Form
    {

        public static DataSet MyDS_Grid;
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();

        public F_user()
        {
            InitializeComponent();
        }

        //加载
        public void loading()
        {
            MyDS_Grid = MyDataClass.getDataSet("select Name as 用户名,Pass as 密码 from tb_Login", "tb_Login");
            dgv_user.DataSource = MyDS_Grid.Tables[0];
            dgv_user.Columns[0].Width = 170;
            dgv_user.Columns[1].Width = 170;
        }

        //加载
        private void F_user_Load(object sender, EventArgs e)
        {
            loading();
        }

        //点击切换数据
        private void dgv_user_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_user.Rows.Count>0)
            {
                string name = dgv_user[0, dgv_user.CurrentCell.RowIndex].Value.ToString();
                DataSet Dset = MyDataClass.getDataSet("select Pope from tb_UserPope where PopeName='" + name + "'", "tb_UserPope");
                if (name != null)
                {
                    int sPope = Convert.ToInt32(Dset.Tables[0].Rows[0][0]);
                    if (sPope == 1)
                    {
                        lbl_pope.Text = "是否管理员：是";
                        btn_insert.Text = "取消权限";
                    }
                    else
                    {
                        lbl_pope.Text = "是否管理员：否";
                        btn_insert.Text = "添加权限";
                    }
                }
            }
        }

        //注册
        private void btn_newuser_Click(object sender, EventArgs e)
        {
            InfoAddForm.F_Enroll f_Enroll=new InfoAddForm.F_Enroll();
            f_Enroll.ShowDialog();
            f_Enroll.Dispose();
        }

        //修改
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_user.CurrentRow.Index < 2)
            {
                MessageBox.Show("不能修改超级用户 !", "提示");
                return;
            }
            else
            {
                ModuleClass.MyModule.User_Name = dgv_user[0, dgv_user.CurrentCell.RowIndex].Value.ToString();
                SecondaryForm.F_UpdateUser f_UpdateUser = new SecondaryForm.F_UpdateUser();
                f_UpdateUser.ShowDialog();
                f_UpdateUser.Dispose();
            }
           
        }

        //权限修改
        private void btn_insert_Click(object sender, EventArgs e)
        {
            switch (btn_insert.Text.Trim()) 
            { 
                case "添加权限":
                    if (dgv_user.Rows.Count > 0)
                    {
                        string name = dgv_user[0, dgv_user.CurrentCell.RowIndex].Value.ToString();
                        MyDataClass.getsqlcom("update tb_UserPope set Pope='1' where PopeName='" + name + "'");
                        DataSet Dset = MyDataClass.getDataSet("select Pope from tb_UserPope where PopeName='" + name + "'", "tb_UserPope");
                        if (name != null)
                        {
                            int sPope = Convert.ToInt32(Dset.Tables[0].Rows[0][0]);
                            if (sPope == 1)
                            {
                                lbl_pope.Text = "是否管理员：是";
                                btn_insert.Text = "取消权限";
                                MessageBox.Show("添加权限成功！", "提示");
                            }
                            else
                            {
                                lbl_pope.Text = "是否管理员：否";
                                btn_insert.Text = "添加权限";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择一条数据进行修改！", "提示");
                    }
                    break;
                case "取消权限":
                    if (dgv_user.Rows.Count > 0)
                    {
                        if (dgv_user.CurrentRow.Index < 2)
                        {
                            MessageBox.Show("当前用户为超级管理员，无法修改！", " 提示");
                            return;
                        }
                        string name = dgv_user[0, dgv_user.CurrentCell.RowIndex].Value.ToString();
                        MyDataClass.getsqlcom("update tb_UserPope set Pope='0' where PopeName='" + name + "'");
                        DataSet Dset = MyDataClass.getDataSet("select Pope from tb_UserPope where PopeName='" + name + "'", "tb_UserPope");
                        if (name != null)
                        {
                            int sPope = Convert.ToInt32(Dset.Tables[0].Rows[0][0]);
                            if (sPope == 0)
                            {
                                lbl_pope.Text = "是否管理员：否";
                                btn_insert.Text = "添加权限";
                                MessageBox.Show("取消权限成功！", "提示");
                            }
                            else
                            {
                                lbl_pope.Text = "是否管理员：是";
                                btn_insert.Text = "取消权限";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择一条数据进行修改！", "提示");
                    }
                        break;
            }
                


           
        }

        //删除
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_user.Rows.Count > 0)
            {
               
                if (dgv_user.RowCount < 3)
                {
                    MessageBox.Show("超级用户，无法删除！", "提示");
                    return;
                }

                if (dgv_user.Rows.Count > 2 && dgv_user.CurrentRow.Index != dgv_user.Rows.Count-1)
                {
                    MessageBox.Show("无法从中删除，请选择修改！", "提示");
                    return;
                }

                string name = dgv_user[0, dgv_user.CurrentCell.RowIndex].Value.ToString();
                MyDataClass.getsqlcom("Delete tb_Login where Name='" + name + "'");
                MyDataClass.getsqlcom("Delete tb_UserPope where PopeName='" + name + "'");
                MessageBox.Show("删除成功！", "提示");
            }
            else
            {
                MessageBox.Show("请选择一条数据进行修改！", "提示");
            }
        }

        //激活窗口
        private void F_user_Activated(object sender, EventArgs e)
        {
            loading();
        }
    }
}
