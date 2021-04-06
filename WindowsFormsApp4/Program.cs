using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp4.DBConnection;
using WindowsFormsApp4.Forms;

namespace WindowsFormsApp4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLQuery db = new SQLQuery();
            if (db.CheckConn())
            {
                Application.Run(new MainForm());

            }
            else
            {
                Application.Run(new SettingsP(1));

            }
        }
    }
}
