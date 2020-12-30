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
    public partial class OutDayThings : Form
    {
        public OutDayThings()
        {
            InitializeComponent();
        }
        Dbutil dh = new Dbutil();
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        DataSet ds = null;
        //MySqlDataAdapter da = null;
        DataTable dt = null;

        private void OutDayThings_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM thingsinfo WHERE endtime <NOW();";
            conn = dh.Connection;
            dh.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "adm_adm");
            dt = ds.Tables["adm_adm"];
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
