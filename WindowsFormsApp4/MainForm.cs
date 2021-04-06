using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp4.DBConnection;

namespace WindowsFormsApp4
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetTable();
        }
        private void ResetTable()
        {
            int d = 0;
            if (metroGrid1.SelectedRows.Count != 0)
                d = metroGrid1.SelectedRows[0].Index;
            metroGrid1.Rows.Clear();
            SQLQuery sq = new SQLQuery();
            DataTable dt = sq.StreetTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                metroGrid1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);

            }
            try { metroGrid1.Rows[d].Selected = true; }
            catch { }
        }
    }
}
