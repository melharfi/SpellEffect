using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SpellEffect
{
    public partial class Form1 : Form
    {
        MySqlConn mysqlCon;
        public static string userDB;
        public static string passwordDB;
        public static string adresseDB;
        public static string DBName;
        public static string spells_levels = "spells_levels";
        public static string clientVersion;
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        public Form1()
        {
            InitializeComponent();
            reload();
            if (clientVersionCB.Items.Count > 0)
                clientVersionCB.SelectedIndex = 0;

            ToolTip1.SetToolTip(addNewClientVersionDirectory, "Ajouter une nouvelle version du client Dofus");
        }

        private void reload()
        {
            clientVersionCB.Items.Clear();
            clientVersionCB.Items.Add("Par défaut (2.10)");
            // récupération des liste de client supporté
            foreach (string zip in Directory.GetFiles("clientVersion"))
                if (zip.Length > 4 && zip.Substring(zip.Length - 4, 4) == ".zip" && zip != "clientVersion\\2.10.zip")
                    clientVersionCB.Items.Add(zip.Substring(zip.LastIndexOf("\\") + 1, zip.Length - zip.LastIndexOf("\\") - 5));
            clientVersionCB.SelectedIndex = 0;
        }

        private void connection_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Entrer le d'utilisateur");
                return;
            }
            else if (DB.Text == "")
            {
                MessageBox.Show("Entrer la Base de donné");
                return;
            }
            else if (Ip.Text == "")
            {
                MessageBox.Show("Entrer l'adresse Ip");
                return;
            }

            if(clientVersionCB.Items.Count == 0)
            {
                MessageBox.Show("La base qui contiens les sorts des differents clients Dofus est vide.\nMerci de vérifier le répértoir 'clientVersion' qui dois contenir un répertoire pour chaque version comme 2.10, 2.29 ... et chaque répertoire dois contenir tous les sorts du client en question.\n pour récuperer les sorts il faut les extraires depuis le client");
                return;
            }

            MySqlConn mysqlCon = new MySqlConn(username.Text, Password.Text, DB.Text, Ip.Text);
            
            if(mysqlCon.conn.State == ConnectionState.Open)
            {
                userDB = username.Text;
                passwordDB = Password.Text;
                adresseDB = Ip.Text;
                DBName = DB.Text;
                clientVersion = clientVersionCB.SelectedItem.ToString() == "Par défaut (2.10)" ? "2.10" : clientVersionCB.SelectedItem.ToString();
                this.Hide();

                SpellEffect spellEffect = new SpellEffect(mysqlCon);
                spellEffect.Show();
                spellEffect.FormClosed += SpellEffect_FormClosed;
            }
        }

        private void SpellEffect_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mysqlCon != null && mysqlCon.conn.State == ConnectionState.Open)
            {
                mysqlCon.conn.Close();
                mysqlCon.Dispose();
                mysqlCon = null;
            }
        }

        private void username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                connection_Click(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Enabled = false;
            about.FormClosed += About_FormClosed;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void addNewClientVersionDirectory_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            addNewClientVersion ancv = new addNewClientVersion();
            ancv.Show();
            ancv.FormClosed += Ancv_FormClosed;
        }

        private void Ancv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            reload();
        }
    }
}
