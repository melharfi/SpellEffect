using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Ionic.Zip;
using Ionic;
using System.IO;
using System.Windows.Media.Imaging;
using System.Collections;
using Ionic.Crc;

namespace SpellEffect
{
    public partial class SpellEffect : Form
    {
        MySqlConn mysqlCon;
        public static int selectedId = -1;
        public static int selectedLevel = -1;

        public SpellEffect()
        {
            InitializeComponent();
        }

        public SpellEffect(MySqlConn _mysqlCon)
        {
            InitializeComponent();
            mysqlCon = _mysqlCon;
        }

        private void editSpell_Click(object sender, EventArgs e)
        {
            int convertedSortID;
            if(!int.TryParse(sortID.Text, out convertedSortID))
            {
                MessageBox.Show("Veuillez entrer un numéro valide");
                return;
            }
            selectedId = -1;
            mysqlCon.cmd.CommandText = "select count(id) from " + Form1.spells_levels + " where SpellId = '" + convertedSortID + "'";
            try
            {
                mysqlCon.reader = mysqlCon.cmd.ExecuteReader();
                mysqlCon.reader.Read();
                int count = mysqlCon.reader.GetInt32(0);
                mysqlCon.reader.Close();
                if (count > 0)
                {
                    this.Hide();
                    SelectSpellLevel selectSpellLevel = new SelectSpellLevel(mysqlCon, convertedSortID);
                    selectSpellLevel.Show();
                    selectSpellLevel.FormClosing += SelectSpellLevel_FormClosing;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                switch (ex.Number)
                {
                    case 1146:
                        SelectionTable selectionTable = new SelectionTable(mysqlCon);
                        selectionTable.Show();
                        selectionTable.FormClosed += SelectionTable_FormClosed;
                        this.Enabled = false;
                        break;
                    default :
                        MessageBox.Show(ex.ToString());
                        break;
                }
                
                
            }
        }

        private void SelectionTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender as Form).Tag != null)
            {
                Form1.spells_levels = (sender as Form).Tag.ToString();
                this.Enabled = true;

            }
        }

        private void SelectSpellLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            if (selectedId == -1)
                return;
            showInfo();
        }

        List<string> columnName = new List<string>();
        void showInfo()
        {
            spellLevelL.Text = "Level " + selectedLevel;
            dataGridView1.Columns.Clear();
            //// recuperer le nom des colonnes
            MySqlConn mysqlCon2 = new MySqlConn(Form1.userDB, Form1.passwordDB, "information_schema", Form1.adresseDB);
            mysqlCon2.cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_schema = '" + Form1.DBName + "' AND table_name = '" + Form1.spells_levels + "'";
            mysqlCon2.reader = mysqlCon2.cmd.ExecuteReader();
            int count = 0;
            columnName.Clear();
            while (mysqlCon2.reader.Read())
            {
                count++;
                string column = mysqlCon2.reader[0].ToString();
                columnName.Add(column);
            }
            mysqlCon2.reader.Close();

            for (int cnt = 0; cnt < count; cnt++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = columnName[cnt];
                column.Name = columnName[cnt];
                column.ReadOnly = true;
                column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns.Add(column);
            }
            ///////////////////////////////// insertion des données
            dataGridView1.Rows.Clear();
            dataGridView1.CellDoubleClick -= DataGridView1_CellDoubleClick;
            mysqlCon.cmd.CommandText = "select * from " + Form1.spells_levels + " where Id = '" + selectedId + "'";
            mysqlCon.reader = mysqlCon.cmd.ExecuteReader();

            while (mysqlCon.reader.Read())
            {
                object[] data = new object[count];
                for (int cnt = 0; cnt < data.Length; cnt++)
                    data[cnt] = mysqlCon.reader[cnt];

                dataGridView1.Rows.Add(data);
            }
            mysqlCon.reader.Close();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = dataGridView1.Height + 120;
            panel2.Visible = true;
            this.Location = new Point(0, 0);
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if(value.GetType() == typeof(Byte[]) && (columnName[e.ColumnIndex] == "EffectsBin" || columnName[e.ColumnIndex] == "CriticalEffectsBin" || columnName[e.ColumnIndex] == "Effects" || columnName[e.ColumnIndex] == "CriticalEffect" || columnName[e.ColumnIndex] == "CriticalEffects" || columnName[e.ColumnIndex] == "Effect"))
            {
                this.Hide();
                EffectBin effectBin = new EffectBin(value as Byte[], mysqlCon, Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), columnName[e.ColumnIndex]);
                effectBin.FormClosed += EffectBin_FormClosed;
                effectBin.Show();
            }

            dataGridView1.BeginEdit(true);
            dataGridView1.CurrentCell.ReadOnly = false;
        }

        private void EffectBin_FormClosed(object sender, FormClosedEventArgs e)
        {
            showInfo();
            this.Show();
        }

        private void sortID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editSpell_Click(null, null);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string value = "";

                for (int cnt = 2; cnt < dataGridView1.Rows[0].Cells.Count; cnt++)
                {
                    if (columnName[cnt] == "EffectsBin" || columnName[cnt] == "CriticalEffectsBin")
                        continue;
                    DataGridViewTextBoxCell dgvtbc = (DataGridViewTextBoxCell)dataGridView1.Rows[0].Cells[cnt];
                    value += Form1.spells_levels + "." + columnName[cnt] + " = '" + dgvtbc.Value.ToString() + "', ";
                }
                
                value = value.Substring(0, value.Length - 2);
                
                mysqlCon.cmd.CommandText = "update " + Form1.spells_levels + " set " + value + " where id = '" + selectedId + "'";
                mysqlCon.reader = mysqlCon.cmd.ExecuteReader();
                mysqlCon.reader.Close();
                MessageBox.Show("Enregistré");
            }
        }

        private void sortID_TextChanged(object sender, EventArgs e)
        {
            int spellId;
            if (int.TryParse(sortID.Text, out spellId))
            {
                string zippath = "clientVersion\\" + Form1.clientVersion + ".zip";

                using (ZipFile zip = ZipFile.Read(zippath))
                {
                    bool found = false;
                    foreach (ZipEntry e1 in zip)
                    {
                        if (e1.FileName == spellId + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            SpellPicture.Image = Image.FromStream(memstream);
                            found = true;
                            SpellPicture.Visible = true;
                            break;
                        }
                    }
                    if (!found)
                        SpellPicture.Visible = false;
                }
            }
            else
            {
                SpellPicture.Image = null;
            }
        }

        private void chooseSpell_Click(object sender, EventArgs e)
        {
            if (Form1.clientVersion == "2.10")
            {
                SelectSpellFromClasses ssfc = new SelectSpellFromClasses();
                ssfc.Show();
                this.Enabled = false;
                ssfc.FormClosed += Ssfc_FormClosed;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Seul les sorts de la version 2.10 (par defaut) sont affichés dans ce pannel.\nPar contre si vous tapez l'id de sort directement, le sort s'affiche correctement selon la version séléctionné.\nVous voulez comme même afficher le panel des sorts 2.10 ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    SelectSpellFromClasses ssfc = new SelectSpellFromClasses();
                    ssfc.Show();
                    this.Enabled = false;
                    ssfc.FormClosed += Ssfc_FormClosed;
                }
            }
        }

        private void Ssfc_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectSpellFromClasses ssfc = sender as SelectSpellFromClasses;
            int selectedSpell = (int)ssfc.Tag;
            this.Enabled = true;
            if (selectedSpell != -1)
            {
                sortID.Text = selectedSpell.ToString();
                spellLevelL.Text = "";
                editSpell_Click(null, null);
            }
        }

        private void tuto1_Click(object sender, EventArgs e)
        {
            howTo hta = new howTo("debugSpell");
            hta.Show();
            this.Enabled = false;
            hta.FormClosed += Hta_FormClosed;
        }

        private void Hta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void tuto2_Click(object sender, EventArgs e)
        {
            howTo hta = new howTo("howToCopyDebugedRawData");
            hta.Show();
            this.Enabled = false;
            hta.FormClosed += Hta_FormClosed;
        }

        private void Ht_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
