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

namespace StoreManaSystem2.SerchSystem
{
    public partial class ModifyNum : Form
    {
        private string ids;
        public ModifyNum(string ids)
        {
            this.ids = ids;
            InitializeComponent();
        }

        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            string vnum = textBox1.Text.Trim(); //1编号
            string name = textBox2.Text.Trim();
          


            if (vnum.Equals("") || vnum == null)
            {
                MessageBox.Show("请填写编号!            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();//定位光标
                return false;
            }
            else if (name.Equals("") || name == null)
            {
                MessageBox.Show("请填写库存            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        //修改
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    conn = dh.Connection;
                    dh.OpenConnection();

                    //string vnum = textBox1.Text.Trim();
                    string stock = textBox2.Text.Trim();

                    //int stock = 0;
                    string sql = "UPDATE thingsinfo set stock='" + stock + "'where vnum='" + ids + "'";
                    cmd = new MySqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("修改成功！            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！            ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ModifyNum_Load(object sender, EventArgs e)
        {
            textBox1.Text = ids;
        }
    }
    
}
