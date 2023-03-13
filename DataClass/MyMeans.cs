using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PWMS.DataClass
{
    class MyMeans
    {
        #region 全局变量
        public static string Login_ID = "";//登录用户编号
        public static string Login_Name = "";//登录用户
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";//记录SQL，表格，添加及修改
        public static SqlConnection My_con;//sql连接字符串
        public static string M_str_sqlcon = "Data Source=10.91.217.185;Database=db_PWMS;User id=sa;PWD=123";//登录地址
        public static int Login_n = 0;//用户登录与重新登录标识
        public static string AllSql = "Select * from tb_Stuffbasic";//查询员工基本信息
        #endregion

        //连接打开数据库
        public static SqlConnection getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            return My_con;
        }

        //打开数据库
        public void con_open()
        {
            getcon();
        }

        //关闭数据库
        public void con_close()
        {
            if (My_con.State == System.Data.ConnectionState.Open)
            {
                My_con.Close();
                My_con.Dispose();
            }
        }

        //只读方式获取数据
        public SqlDataReader getcom(string SQLstr)
        {
            getcon();
            SqlCommand My_com = My_con.CreateCommand();
            My_com.CommandText = SQLstr;
            SqlDataReader My_read = My_com.ExecuteReader();
            return My_read;
        }

        //执行sql命令
        public void getsqlcom(string SQLstr)
        {
            getcon();
            SqlCommand Sqlcon = new SqlCommand(SQLstr, My_con);
            Sqlcon.ExecuteNonQuery();
            Sqlcon.Dispose();
            con_close();
        }

        //创建dataset对象
        public DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);
            DataSet My_DataSet = new DataSet();
            SQLda.Fill(My_DataSet, tableName);
            con_close();
            return My_DataSet;
        }

    }
}
