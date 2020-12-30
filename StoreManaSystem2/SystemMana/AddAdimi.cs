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

namespace StoreManaSystem2.SystemMana
{
    public partial class AddAdimi : Form
    {
        public AddAdimi()
        {
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        private bool Check()
        {
            string adstuNo = textBox1.Text.Trim();
            string adstuName = textBox2.Text.Trim();
            string adstuclass = textBox3.Text.Trim();

            if (adstuNo.Equals("") || adstuNo == null)
            {
                MessageBox.Show("请填写姓名!            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();//定位光标
                return false;
            }
            else if (adstuName.Equals("") || adstuName == null)
            {
                MessageBox.Show("请填写用户名            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            else if (adstuclass.Equals("") || adstuclass == null)
            {
                MessageBox.Show("请填写密码       ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    conn = dh.Connection;
                    dh.OpenConnection();
                    string name = textBox1.Text.Trim();
                    string username = textBox2.Text.Trim();
                    string pwd = textBox3.Text.Trim();
                    string id = textBox4.Text.Trim();
                    string sql = string.Format(@"insert into admin(name,username,pwd,id) values ('{0}','{1}','{2}','{3}')",
                                                name, username, pwd,id);
                    cmd = new MySqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("添加成功！            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "异常提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd.Dispose();
                    dh.CloseConnection();//关闭数据库连接

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
