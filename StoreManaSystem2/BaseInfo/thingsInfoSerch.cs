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
    public partial class thingsInfoSerch : Form
    {
        private int index;
        public thingsInfoSerch()
        {
            
            InitializeComponent();
        }
        public int x = 0;
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        DataSet ds = null;
        
        DataTable dt = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //显示数据按钮
        private void button3_Click(object sender, EventArgs e)
        {
            
                string sql = "select * from thingsInfo";
                conn = dh.Connection;
                dh.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "adm_tsi");
                dt = ds.Tables["adm_tsi"];
                dataGridView1.DataSource = dt.DefaultView;

            
        }

        //查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            else
            {
                string sql = string.Format("select * from thingsInfo where vnum like '%{0}%' or name like '%{1}%'",
                    textBox1.Text, textBox1.Text);
                conn = dh.Connection;
                dh.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("未查询到该数据", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBox1.Text = "";
                }
                ds = new DataSet();
                da.Fill(ds, "adm_tsi");
                dt = ds.Tables["adm_tsi"];
                dataGridView1.DataSource = dt.DefaultView;

            }
        }

        //用于传值
        class GlobalData
        {
            public static string ids;
        }
        
        //修改按钮
        private void button2_Click(object sender, EventArgs e)
        {
            index= dataGridView1.CurrentRow.Index;
            GlobalData.ids = dataGridView1.Rows[index].Cells[0].Value.ToString();
            using (ThingsInfoMana tim=new ThingsInfoMana(GlobalData.ids))
            {
                //this.Hide();
                tim.ShowDialog();
                //this.Dispose();
                //this.Close();

            }

        }

        private void thingsInfoSerch_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //设置为选中整行
        }


        //添加数据
        private void button4_Click(object sender, EventArgs e)
        {
            using (AddInfo adi=new AddInfo())
            {
                //this.Hide();
                adi.ShowDialog();
                //this.Dispose();
                //this.Close();
            }


        }
     
        //删除数据
        private void button5_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string vnum = dataGridView1.Rows[index].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("是否删除该商品信息", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                string sql = "delete from thingsInfo where vnum='" + vnum + "'";
                conn = dh.Connection;
                dh.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
