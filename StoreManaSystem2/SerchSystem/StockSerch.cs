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
    public partial class StockSerch : Form
    {
        public StockSerch()
        {
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        DataSet ds = null;
        //MySqlDataAdapter da = null;
        DataTable dt = null;

        private void StockSerch_Load(object sender, EventArgs e)
        {
            string sql = "SELECT vnum,name,stock FROM thingsinfo WHERE stock>0;";
            conn = dh.Connection;
            dh.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "adm_tsi");
            dt = ds.Tables["adm_tsi"];
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {      
            this.Close();

        }
    }
}
