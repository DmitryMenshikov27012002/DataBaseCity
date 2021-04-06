using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4.Forms
{
    public partial class SettingsP : MetroFramework.Forms.MetroForm
    {
        private int Param {get;}
        private string DBn { get; set; }
        public SettingsP(int parametr)
        {
            InitializeComponent();
            Param = parametr;
        }

        private void SettingsP_Load(object sender, EventArgs e)
        {
            DBn = metroTextBox1.Text = Properties.Settings.Default.DBName;
            if (Param == 1)
            {
                metroButton3.Visible = true;
            }
            else
            {
                metroButton3.Visible = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DBn = Properties.Settings.Default.DBName = metroTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (Param == 1)
            {
                Application.Exit();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
