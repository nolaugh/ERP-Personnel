using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PWMS.PerForm
{
    public partial class F_HaveBack : Form
    {
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();


    public F_HaveBack()
        {
            InitializeComponent();
        }

        private void F_HaveBack_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            string path1 = System.Environment.CurrentDirectory + "\\bar";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str_dar = "";
            if (rdb_source.Checked == true)
            {
                Str_dar = System.Environment.CurrentDirectory + "\\bar\\";
            }
            try
            {

                Str_dar = "backup database db_PWMS to disk='" + Str_dar + System.DateTime.Now.ToShortDateString().Replace("/", "") + MyMC.Date_Format(System.DateTime.Now.ToString()) + ".bak" + "'";
                MyDataClass.getsqlcom(Str_dar);
                MessageBox.Show("数据备份成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            ofd_review.Filter = "*.bak|*.bak";
            if (ofd_review.ShowDialog(this) == DialogResult.OK)
            {
                txt_review.Text = ofd_review.FileName;
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            if (txt_review.Text == "")
            {
                MessageBox.Show("请选择备份数据库文件的路径。");
                return;
            }
            try
            {
                if (DataClass.MyMeans.My_con.State == ConnectionState.Open)
                {
                    DataClass.MyMeans.My_con.Close();
                }
                SqlConnection Tem_con = new SqlConnection(DataClass.MyMeans.M_str_sqlcon);
                Tem_con.Open();
                SqlCommand SQLcom = new SqlCommand("use master restore database db_PWMS from disk='"
                    + txt_review.Text.Trim() + "' with replace", Tem_con);
                SQLcom.ExecuteNonQuery();
                SQLcom.Dispose();
                Tem_con.Close();
                Tem_con.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyDataClass.con_open();
                MyDataClass.con_close();
                MessageBox.Show("为了避免数据丢失，在数据库还原后将关闭整个系统!");
                Application.Exit();
                MyDataClass.getsqlcom("update tb_Login set Flag=0 where Name='" + DataClass.MyMeans.Login_Name + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_rexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
