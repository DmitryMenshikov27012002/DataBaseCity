using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4.DBConnection
{
    class DBConnection
    {
        private string DataBase { get; set; }

        public DBConnection(string nameDB)
        {
            DataBase = nameDB;
        }

        public OleDbConnection GetStringConnection()
        {

            OleDbConnection ole = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DataBase + ";");
            return ole;
        }
    }
}
