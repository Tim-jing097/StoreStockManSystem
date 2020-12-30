using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManaSystem2.BaseInfo;
using StoreManaSystem2.DailyBussiness;
using StoreManaSystem2.SerchSystem;
using StoreManaSystem2.SystemMana;

namespace StoreManaSystem2
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void 商品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (thingsInfoSerch thi = new thingsInfoSerch())
            {
                // this.Hide();
                thi.ShowDialog();
                //this.Dispose();
               // this.Close();

            }
        }

        private void 客户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CustmorInfo csI = new CustmorInfo())
            {
                //this.Hide();
                csI.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AdminMana adm = new AdminMana())
            {
                //this.Hide();
                adm.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EnterMana etm = new EnterMana())
            {
                //this.Hide();
                etm.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void 出库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OutMana otm = new OutMana())
            {
                //this.Hide();
                otm.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StockSerch tss = new StockSerch())
            {
                //this.Hide();
                tss.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }

        private void 过期商品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OutDayThings odt=new OutDayThings())
            {
                //this.Hide();
                odt.ShowDialog();
                //this.Dispose();
                //this.Close();

            }
        }
    }
}
