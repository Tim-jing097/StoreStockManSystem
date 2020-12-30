using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace StoreManaSystem2.util
{
    class Dbutil
    {
        private string sql = "server=localhost;user=root;database=storemana;port=3306;password=123456;Charset=utf8;";

        // 数据库连接 Connection 对象
        private MySqlConnection conn;

        /// <summary>
        /// Connection对象
        /// </summary>
        public MySqlConnection Connection
        {
            get
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(sql);
                }
                return conn;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
    }
}
