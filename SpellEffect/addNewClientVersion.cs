using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;


namespace SpellEffect
{
    public partial class addNewClientVersion : Form
    {
        private string version;

        public addNewClientVersion()
        {
            InitializeComponent();

            versionMajeur.SelectedIndex = 0;
            versionMineur.SelectedIndex = 0;
            versionRevision.SelectedIndex = 1;
        }

        private void addNewClientVersion_Load(object sender, EventArgs e)
        {
            string notificationMSG = "Ce formulaire vous permet d'ajouter les images des sorts d'une nouvelle version du client Dofus.\nLes sorts d'une classe peuvent differencier d'une version à l'autre.\nPour afficher les sorts correctement, l'outil cherche dans le répertoire 'ClientVersion' le dossier qui correspond à la version séléctionné.\net affiche les sorts en question qui se trouves sur ce même dossier au format PNG et nommés selon leurs SpellID.\nSi une version ne se trouve pas dans cette base, alors ce formulaire vous permer d'en ajouter une :\n  - (création d'un répértoir de la version voulue)\n  - (insertion de tous les images des sorts de la version en question)\nMAIS pour ceci il vous faut le client Dofus avec la même version pour qu'il puisse extrere les images en décompilons les sources Dofus";
            MessageBox.Show(notificationMSG);
        }


        private void decompile_Click(object sender, EventArgs e)
        {
            if (versionRevision.SelectedItem.ToString() == "")
                versionRevision.SelectedItem = 1;

            version = versionMajeur.SelectedItem.ToString() + "." + versionMineur.SelectedItem.ToString() + (versionRevision.SelectedItem.ToString() != "0" ? "." + versionRevision.SelectedItem.ToString() : "");

            if (!Directory.Exists("clientVersion\\" + version))
            {
                MessageBox.Show("Dossier [clientVersion\\" + version + "] introuvable, merci de créer un dossier nommé [" + version + "] dans le dossier [clientVersion]. ou suivre le tutoriel sur https://github.com/melharfi/SpellEffect");
                return;
            }
            new Thread(new ThreadStart(() => { process(); })).Start();
        }

        private void process()
        {
            this.BeginInvoke((Action)(() =>
            {
                versionMineur.Enabled = false;
                versionRevision.Enabled = false;
                decompile.Enabled = false;
                this.Height = 235;
            }
            ));

            string[] allSpells = Directory.GetDirectories("clientVersion\\" + version + "\\sprites");

            foreach (string d in allSpells)
                if (d.IndexOf("sort_") == -1)
                    Directory.Delete(d, true);

            allSpells = Directory.GetDirectories("clientVersion\\" + version + "\\sprites");
            int globalSteps = allSpells.Length + 2;
            
            foreach (string d in allSpells)
            {
                string spellID = d.Substring(d.LastIndexOf("sort_") + 5, d.Length - d.LastIndexOf("sort_") - 5);
                File.Copy(d + "\\1.png", "clientVersion\\" + version + "\\" + spellID + ".png");
                this.BeginInvoke((Action)(() =>
                {
                    progressBarGlobal.Increment(1);
                    double percent = (((double)progressBarGlobal.Value / progressBarGlobal.Maximum) * 100);
                    globalInfo.Text = "Avancement total " + percent + "%";
                    int size = TextRenderer.MeasureText(globalInfo.Text, globalInfo.Font).Width;
                    globalInfo.Location = new System.Drawing.Point(size - (size / 2), globalInfo.Location.Y);
                }
                ));
            }

            Directory.Delete("clientVersion\\" + version + "\\sprites", true);

            string zipPath = "clientVersion\\" + version + ".zip";
            if (File.Exists("clientVersion\\" + version + ".zip"))
                File.Delete("clientVersion\\" + version + ".zip");
            ZipFile.CreateFromDirectory("clientVersion\\" + version, zipPath);
            this.BeginInvoke((Action)(() =>
            {
                progressBarGlobal.Increment(1);
                double percent = (((double)progressBarGlobal.Value / progressBarGlobal.Maximum) * 100);
                globalInfo.Text = "Avancement total " + percent + "%";
            }
            ));
            Directory.Delete("clientVersion\\" + version, true);
            this.BeginInvoke((Action)(() =>
            {
                progressBarGlobal.Increment(1);
                versionMineur.Enabled = false;
                versionRevision.Enabled = false;
                decompile.Enabled = false;
                double percent = (((double)progressBarGlobal.Value / progressBarGlobal.Maximum) * 100);
                globalInfo.Text = "Avancement total " + percent + "%";
                MessageBox.Show("Conversion términé", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            ));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            howTo htancv = new howTo("newClientVersion");
            htancv.Show();
            htancv.FormClosed += Htancv_FormClosed;
            this.Enabled = false;
        }

        private void Htancv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
