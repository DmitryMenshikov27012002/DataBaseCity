using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp4.DBConnection
{
    class SQLQuery
    {
        private OleDbConnection ConnectString { get; set; }
        public SQLQuery()
        {
            DBConnection dbc = new DBConnection(Properties.Settings.Default.DBName);
            ConnectString = dbc.GetStringConnection();
        }

        public bool CheckConn()
        {
            try
            {
                ConnectString.Open();
                OleDbCommand cm = new OleDbCommand("Select * From [VersionDB]", ConnectString);
                cm.ExecuteNonQuery();
                ConnectString.Close();
                return true;
            }
            
            catch 
            {
                ConnectString.Close();
                return false;
            }
        }

        public DataTable StreetTable()
        {
            DataTable streets = new DataTable();
            OleDbCommand cm = new OleDbCommand("Select * From Streets", ConnectString);
            ConnectString.Open();
            OleDbDataReader rd = cm.ExecuteReader();
            for (int i = 0; i < rd.FieldCount; i++)
                streets.Columns.Add();
            while (rd.Read())
            {
                streets.Rows.Add(rd[0], rd[1], rd[2]);
            }
            ConnectString.Close();
            return streets; 
        }

    }
}
