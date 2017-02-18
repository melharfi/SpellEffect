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
    public partial class howTo : Form
    {
        public howTo()
        {
            InitializeComponent();
        }

        public howTo(string s)
        {
            InitializeComponent();

            if(s == "newClientVersion")
            {
                helpPB.Image = Properties.Resources.howToAddClientVersion;
                description.Text = "Comment ajouter les images des sorts d'une nouvelle version de client Dofus.\nCeci ne change rien et ne modifie absolument rien mais juste pour afficher la bonne image du sort selon la version en question.";
            }
            else if (s == "debugSpell")
            {
                helpPB.Image = Properties.Resources.howToIopWrath;
                description.Text = "Comment debuger le sort collere de iop dans les parametres et dans les effets.\nIl faut appliqer ceci sur tous les niveau 1,2,3,4,5,6 et sur le EffectBin et CriticalEffectBin";
            }
            else if (s == "howToCopyDebugedRawData")
            {
                helpPB.Image = Properties.Resources.howToCopyDebugedRawData;
                description.Text = "Comment appliquer les débugs d'un sort partagés.\nNotez qu'il faut appliqer ceci sur les 6 niveau critique et non critique.";
            }

            this.Size = new Size(helpPB.Size.Width, helpPB.Size.Height + 100);
            description.Location = new Point(0, helpPB.Size.Height + 5);
        }

        private void howTo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            if(Screen.GetBounds(this).Width < this.Width)
            {
                this.Width = Screen.GetBounds(this).Width - 10;
                this.helpPB.Width = this.Width;
            }
            if(Screen.GetBounds(this).Height < this.Height)
            {
                this.Height = Screen.GetBounds(this).Height - 20;
                helpPB.Height = this.Height - 30;
            }
        }
    }
}
