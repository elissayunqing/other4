using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace other4
{
    internal class DataBase
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=DESKTOP-M0B7CAD\AMOXIANG;Initial Catalog=testdata3;Integrated Security=True";//数据库字符串
            SqlConnection sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();  //打开数据库
            return sc;  //返回数据库对象
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql) //更新操作
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
