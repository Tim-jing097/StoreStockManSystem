using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//测试头文件
using StoreManaSystem2.BaseInfo;
using StoreManaSystem2.DailyBussiness;
using StoreManaSystem2.SerchSystem;
using StoreManaSystem2.SystemMana;

namespace StoreManaSystem2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //以下为测试代码
            //Application.Run(new MainWin());
            //Application.Run(new thingsInfoSerch());
            //Application.Run(new AdminMana());
            //Application.Run(new OutDayThings());
            //Application.Run(new StockSerch());
            //Application.Run(new CustmorInfo());
        }
    }
}
