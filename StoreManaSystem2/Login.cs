using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManaSystem2.util;

using MySql.Data.MySqlClient;
namespace StoreManaSystem2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string userpwd = textBox2.Text.Trim();
            string sql = "select * from admin where username='" + username + "' and pwd='" + userpwd + "'";
            conn = dh.Connection;
            dh.OpenConnection();
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader sread = cmd.ExecuteReader();//查询语句
            try
            {
                if (sread.Read())
                {
                    MessageBox.Show("登录成功", "登录");
                    using (MainWin mw = new MainWin())
                    {
                        this.Hide();
                        mw.ShowDialog();
                        this.Dispose();
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
            finally
            {
                conn.Close();                    //关闭连接
                conn.Dispose();                  //释放连接

            }
        }
    }
    
}
