using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManaSystem2.SystemMana;

using StoreManaSystem2.util;
using MySql.Data.MySqlClient;

namespace StoreManaSystem2.SystemMana
{
    public partial class AdminMana : Form
    {
        private int index;
        public AdminMana()
        {
            InitializeComponent();
        }

        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
       // MySqlCommand cmd = null;
        DataSet ds = null;
        //MySqlDataAdapter da = null;
        DataTable dt = null;

        private void AdminMana_Load(object sender, EventArgs e)
        {
            string sql = "select * from admin";
            conn = dh.Connection;
            dh.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "adm_adm");
            dt = ds.Tables["adm_adm"];
            dataGridView1.DataSource = dt.DefaultView;
        }

        class GlobalData
        {
            public static string ids;
        }
        //添加
        private void button2_Click(object sender, EventArgs e)
        {
            
            using (AddAdimi adm =new AddAdimi())
            {
                //this.Hide();
                adm.ShowDialog();
                //this.Dispose();
                //this.Close();
            }
        }

        //刷新列表
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin";
            conn = dh.Connection;
            dh.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "adm_adm");
            dt = ds.Tables["adm_adm"];
            dataGridView1.DataSource = dt.DefaultView;
        }

        //退出
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //删除
        private void button6_Click(object sender, EventArgs e)
        {
            //按用户名删除
            int indexs = dataGridView1.CurrentRow.Index;
            string username = dataGridView1.Rows[indexs].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("是否删除该用户", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = "delete from admin where username='" + username + "'";
                conn = dh.Connection;
                dh.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        //修改功能
        private void button5_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            GlobalData.ids = dataGridView1.Rows[index].Cells[3].Value.ToString();
            using (ModifyAdimi mod= new ModifyAdimi(GlobalData.ids))
            {
                //this.Hide();
                mod.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

