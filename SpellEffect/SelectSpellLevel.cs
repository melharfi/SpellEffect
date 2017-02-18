using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellEffect
{
    public partial class SelectSpellLevel : Form
    {
        public SelectSpellLevel()
        {
            InitializeComponent();
        }

        public SelectSpellLevel(MySqlConn mysqlCon, int spellID)
        {
            InitializeComponent();

            mysqlCon.cmd.CommandText = "select * from " + Form1.spells_levels + " where SpellId = '" + spellID + "'";
            mysqlCon.reader = mysqlCon.cmd.ExecuteReader();
            int counter = 0;
            while (mysqlCon.reader.Read())
                dataGridView1.Rows.Add(mysqlCon.reader["Id"].ToString(), mysqlCon.reader["SpellID"].ToString(), ++counter);
            mysqlCon.reader.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string selectedId = dataGridView1.Rows[index].Cells[0].Value.ToString();
            int.TryParse(selectedId, out SpellEffect.selectedId);
            string selectedLevel = dataGridView1.Rows[index].Cells[2].Value.ToString();
            int.TryParse(selectedLevel, out SpellEffect.selectedLevel);
            this.Close();
        }
    }
}
