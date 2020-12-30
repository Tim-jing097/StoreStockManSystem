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
    public partial class CustmorInfo : Form
    {
        public CustmorInfo()
        {
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        DataSet ds = null;

        DataTable dt = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustmorInfo_Load(object sender, EventArgs e)
        {
            string sql = "select * from custmorinfo";
            conn = dh.Connection;
            dh.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "adm_adm");
            dt = ds.Tables["adm_adm"];
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
