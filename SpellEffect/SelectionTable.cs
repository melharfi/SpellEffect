using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpellEffect
{
    public partial class SelectionTable : Form
    {
        public SelectionTable()
        {
            InitializeComponent();
        }

        public SelectionTable(MySqlConn mysqlConn)
        {
            InitializeComponent();
            mysqlConn.cmd.CommandText = "show tables";
            mysqlConn.reader = mysqlConn.cmd.ExecuteReader();
            while (mysqlConn.reader.Read())
            {
                string column = mysqlConn.reader[0].ToString();
                this.tablesName.Items.Add(column);
            }
            tablesName.SelectedIndex = 0;
            mysqlConn.reader.Close();
        }

        
        private void connexion_Click(object sender, EventArgs e)
        {
            this.Tag = tablesName.SelectedItem;
            this.Close();
        }
    }
}
