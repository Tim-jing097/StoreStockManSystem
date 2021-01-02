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


namespace StoreManaSystem2.BaseInfo
{
    public partial class AddInfo : Form
    {
        //private int x;
        public AddInfo()
        {
           
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        private bool Check()
        {
            string vnum = textBox1.Text.Trim(); //1编号
            string name = textBox2.Text.Trim();
            string begintime = textBox3.Text.Trim();
            string shortname = textBox4.Text.Trim();
            string endtime = textBox5.Text.Trim();
            string stock = textBox6.Text.Trim();

            if (vnum.Equals("") || vnum == null)
            {
                MessageBox.Show("请填写编号!            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();//定位光标
                return false;
            }
            else if (name.Equals("") || name == null)
            {
                MessageBox.Show("请填写名称            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            else if (begintime.Equals("") || begintime == null)
            {
                MessageBox.Show("请填写生产日期       ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }
            else if (shortname.Equals("") || shortname == null)
            {
                MessageBox.Show("请填写简称            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return false;
            }
            else if (endtime.Equals("") || endtime == null)
            {
                MessageBox.Show("请填写保质期         ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        //添加
        private void button4_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    conn = dh.Connection;
                    dh.OpenConnection();
                    string vnum = textBox1.Text.Trim(); //1编号
                    string name = textBox2.Text.Trim();
                    string begintime = textBox3.Text.Trim();
                    string shortname = textBox4.Text.Trim();
                    string endtime = textBox5.Text.Trim();
                    string stock = textBox6.Text.Trim();

                    string sql = string.Format(@"insert into thingsInfo(vnum,name,shortname,begintime,endtime,stock) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                vnum, name, shortname, begintime, endtime, stock);
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInfo_Load(object sender, EventArgs e)
        {

        }
    }
    
}
