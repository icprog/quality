using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Quality;
namespace 质监局证书管理系统
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
           

            frm_login login = new frm_login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                if (login.bLogin)
                {
                    
                    Application.Run(new frm_main(login.Users));
                }

            }
            else if(login.DialogResult==DialogResult.Abort)
            {
                Application.Exit();
            }

           // Application.Run(new frm_main());
        }
    }
}
