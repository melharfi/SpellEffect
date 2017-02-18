using Ionic.Crc;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellEffect
{
    public partial class SelectSpellFromClasses : Form
    {
        public SelectSpellFromClasses()
        {
            InitializeComponent();
            this.Tag = -1;
        }

        private void feca_Click(object sender, EventArgs e)
        {
            changeClass(0);
        }

        private void osamodas_Click(object sender, EventArgs e)
        {
            changeClass(1);
        }

        private void enutrof_Click(object sender, EventArgs e)
        {
            changeClass(2);
        }

        private void sram_Click(object sender, EventArgs e)
        {
            changeClass(3);
        }

        private void xelor_Click(object sender, EventArgs e)
        {
            changeClass(4);
        }

        private void ecaflip_Click(object sender, EventArgs e)
        {
            changeClass(5);
        }

        private void eniripsa_Click(object sender, EventArgs e)
        {
            changeClass(6);
        }

        private void iop_Click(object sender, EventArgs e)
        {
            changeClass(7);
        }

        private void cra_Click(object sender, EventArgs e)
        {
            changeClass(8);
        }

        private void sadida_Click(object sender, EventArgs e)
        {
            changeClass(9);
        }

        private void sacrieur_Click(object sender, EventArgs e)
        {
            changeClass(10);
        }

        private void panda_Click(object sender, EventArgs e)
        {
            changeClass(11);
        }

        private void roublard_Click(object sender, EventArgs e)
        {
            changeClass(12);
        }

        private void zobal_Click(object sender, EventArgs e)
        {
            changeClass(13);
        }

        private void steamer_Click(object sender, EventArgs e)
        {
            changeClass(14);
        }

        private void changeClass(int id)
        {
            int counter = 0;
            string zippath = "clientVersion\\" + Form1.clientVersion + ".zip";

            if (id < 12)
            {
                if (id < 10)
                    counter = id * 20;
                else if (id == 10)
                    counter = 430;
                else if (id == 11)
                    counter = 685;

                for (int cnt = 1; cnt <= 20; cnt++)
                {
                    PictureBox spellPB = this.Controls.Find("spell" + cnt, true)[0] as PictureBox;

                    using (ZipFile zip = ZipFile.Read(zippath))
                    {
                        foreach (ZipEntry e1 in zip)
                        {
                            if (e1.FileName == (counter + cnt) + ".png")
                            {
                                CrcCalculatorStream reader = e1.OpenReader();
                                MemoryStream memstream = new MemoryStream();
                                reader.CopyTo(memstream);
                                byte[] bytes = memstream.ToArray();
                                spellPB.Image = Image.FromStream(memstream);
                                break;
                            }
                        }
                    }

                    spellPB.Tag = counter + cnt;
                }
            }
            else if (id == 12)
            {
                // roublard
                using (ZipFile zip = ZipFile.Read(zippath))
                {
                    foreach (ZipEntry e1 in zip)
                    {
                        if (e1.FileName == 2778 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell1.Image = Image.FromStream(memstream);
                            spell1.Tag = 2778;
                        }
                        else if (e1.FileName == 2794 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell2.Image = Image.FromStream(memstream);
                            spell2.Tag = 2794;
                        }
                        else if (e1.FileName == 2808 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell3.Image = Image.FromStream(memstream);
                            spell3.Tag = 2808;
                        }
                        else if (e1.FileName == 2795 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell4.Image = Image.FromStream(memstream);
                            spell4.Tag = 2795;
                        }
                        else if (e1.FileName == 2763 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell5.Image = Image.FromStream(memstream);
                            spell5.Tag = 2763;
                        }
                        else if (e1.FileName == 2796 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell6.Image = Image.FromStream(memstream);
                            spell6.Tag = 2796;
                        }
                        else if (e1.FileName == 2801 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell7.Image = Image.FromStream(memstream);
                            spell7.Tag = 2801;
                        }
                        else if (e1.FileName == 2802 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell8.Image = Image.FromStream(memstream);
                            spell8.Tag = 2802;
                        }
                        else if (e1.FileName == 2803 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell9.Image = Image.FromStream(memstream);
                            spell9.Tag = 2803;
                        }
                        else if (e1.FileName == 2807 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell10.Image = Image.FromStream(memstream);
                            spell10.Tag = 2807;
                        }
                        else if (e1.FileName == 2797 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell11.Image = Image.FromStream(memstream);
                            spell11.Tag = 2797;
                        }
                        else if (e1.FileName == 2806 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell12.Image = Image.FromStream(memstream);
                            spell12.Tag = 2806;
                        }
                        else if (e1.FileName == 2805 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell13.Image = Image.FromStream(memstream);
                            spell13.Tag = 2805;
                        }
                        else if (e1.FileName == 2809 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell14.Image = Image.FromStream(memstream);
                            spell14.Tag = 2809;
                        }
                        else if (e1.FileName == 2804 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell15.Image = Image.FromStream(memstream);
                            spell15.Tag = 2804;
                        }
                        else if (e1.FileName == 2810 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell16.Image = Image.FromStream(memstream);
                            spell16.Tag = 2810;
                        }
                        else if (e1.FileName == 2811 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell17.Image = Image.FromStream(memstream);
                            spell17.Tag = 2811;
                        }
                        else if (e1.FileName == 2812 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell18.Image = Image.FromStream(memstream);
                            spell18.Tag = 2812;
                        }
                        else if (e1.FileName == 2813 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell19.Image = Image.FromStream(memstream);
                            spell19.Tag = 2813;
                        }
                        else if (e1.FileName == 2815 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell20.Image = Image.FromStream(memstream);
                            spell20.Tag = 2815;
                        }
                    }
                }
            }
            else if (id == 13)
            {
                using (ZipFile zip = ZipFile.Read(zippath))
                {
                    foreach (ZipEntry e1 in zip)
                    {
                        if (e1.FileName == 2872 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell1.Image = Image.FromStream(memstream);
                            spell1.Tag = 2872;
                        }
                        else if (e1.FileName == 2879 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell2.Image = Image.FromStream(memstream);
                            spell2.Tag = 2879;
                        }
                        else if (e1.FileName == 2880 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell3.Image = Image.FromStream(memstream);
                            spell3.Tag = 2880;
                        }
                        else if (e1.FileName == 2881 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell4.Image = Image.FromStream(memstream);
                            spell4.Tag = 2881;
                        }
                        else if (e1.FileName == 2882 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell5.Image = Image.FromStream(memstream);
                            spell5.Tag = 2882;
                        }
                        else if (e1.FileName == 2883 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell6.Image = Image.FromStream(memstream);
                            spell6.Tag = 2883;
                        }
                        else if (e1.FileName == 2885 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell7.Image = Image.FromStream(memstream);
                            spell7.Tag = 2885;
                        }
                        else if (e1.FileName == 2886 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell8.Image = Image.FromStream(memstream);
                            spell8.Tag = 2886;
                        }
                        else if (e1.FileName == 2887 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell9.Image = Image.FromStream(memstream);
                            spell9.Tag = 2887;
                        }
                        else if (e1.FileName == 2888 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell10.Image = Image.FromStream(memstream);
                            spell10.Tag = 2888;
                        }
                        else if (e1.FileName == 2889 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell11.Image = Image.FromStream(memstream);
                            spell11.Tag = 2889;
                        }
                        else if (e1.FileName == 2890 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell12.Image = Image.FromStream(memstream);
                            spell12.Tag = 2890;
                        }
                        else if (e1.FileName == 2891 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell13.Image = Image.FromStream(memstream);
                            spell13.Tag = 2891;
                        }
                        else if (e1.FileName == 2892 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell14.Image = Image.FromStream(memstream);
                            spell14.Tag = 2892;
                        }
                        else if (e1.FileName == 2893 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell15.Image = Image.FromStream(memstream);
                            spell15.Tag = 2893;
                        }
                        else if (e1.FileName == 2894 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell16.Image = Image.FromStream(memstream);
                            spell16.Tag = 2894;
                        }
                        else if (e1.FileName == 2895 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell17.Image = Image.FromStream(memstream);
                            spell17.Tag = 2895;
                        }
                        else if (e1.FileName == 2896 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell18.Image = Image.FromStream(memstream);
                            spell18.Tag = 2896;
                        }
                        else if (e1.FileName == 2897 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell19.Image = Image.FromStream(memstream);
                            spell19.Tag = 2897;
                        }
                        else if (e1.FileName == 2899 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell20.Image = Image.FromStream(memstream);
                            spell20.Tag = 2899;
                        }
                    }
                }
            }
            else if (id == 14)
            {
                using (ZipFile zip = ZipFile.Read(zippath))
                {
                    foreach (ZipEntry e1 in zip)
                    {
                        if (e1.FileName == 3202 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell1.Image = Image.FromStream(memstream);
                            spell1.Tag = 3202;
                        }
                        else if (e1.FileName == 3204 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell2.Image = Image.FromStream(memstream);
                            spell2.Tag = 3204;
                        }
                        else if (e1.FileName == 3205 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell3.Image = Image.FromStream(memstream);
                            spell3.Tag = 3205;
                        }
                        else if (e1.FileName == 3206 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell4.Image = Image.FromStream(memstream);
                            spell4.Tag = 3206;
                        }
                        else if (e1.FileName == 3207 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell5.Image = Image.FromStream(memstream);
                            spell5.Tag = 3207;
                        }
                        else if (e1.FileName == 3208 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell6.Image = Image.FromStream(memstream);
                            spell6.Tag = 3208;
                        }
                        else if (e1.FileName == 3209 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell7.Image = Image.FromStream(memstream);
                            spell7.Tag = 3209;
                        }
                        else if (e1.FileName == 3210 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell8.Image = Image.FromStream(memstream);
                            spell8.Tag = 3210;
                        }
                        else if (e1.FileName == 3211 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell9.Image = Image.FromStream(memstream);
                            spell9.Tag = 3211;
                        }
                        else if (e1.FileName == 3212 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell10.Image = Image.FromStream(memstream);
                            spell10.Tag = 3212;
                        }
                        else if (e1.FileName == 3213 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell11.Image = Image.FromStream(memstream);
                            spell11.Tag = 3213;
                        }
                        else if (e1.FileName == 3214 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell12.Image = Image.FromStream(memstream);
                            spell12.Tag = 3214;
                        }
                        else if (e1.FileName == 3215 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell13.Image = Image.FromStream(memstream);
                            spell13.Tag = 3215;
                        }
                        else if (e1.FileName == 3216 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell14.Image = Image.FromStream(memstream);
                            spell14.Tag = 3216;
                        }
                        else if (e1.FileName == 3217 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell15.Image = Image.FromStream(memstream);
                            spell15.Tag = 3217;
                        }
                        else if (e1.FileName == 3218 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell16.Image = Image.FromStream(memstream);
                            spell16.Tag = 3218;
                        }
                        else if (e1.FileName == 3219 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell17.Image = Image.FromStream(memstream);
                            spell17.Tag = 3219;
                        }
                        else if (e1.FileName == 3220 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell18.Image = Image.FromStream(memstream);
                            spell18.Tag = 3220;
                        }
                        else if (e1.FileName == 3221 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell19.Image = Image.FromStream(memstream);
                            spell19.Tag = 3221;
                        }
                        else if (e1.FileName == 3277 + ".png")
                        {
                            CrcCalculatorStream reader = e1.OpenReader();
                            MemoryStream memstream = new MemoryStream();
                            reader.CopyTo(memstream);
                            byte[] bytes = memstream.ToArray();
                            spell20.Image = Image.FromStream(memstream);
                            spell20.Tag = 3277;
                        }
                    }
                }
            }
            spellConteiner.Visible = true;
        }

        private void spell1_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell2_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell3_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell4_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell5_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell6_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell7_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell8_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell9_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell10_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell11_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell12_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell13_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell14_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell15_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell16_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell17_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell18_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell19_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void spell20_DoubleClick(object sender, EventArgs e)
        {
            selectSpell(sender);
        }

        private void selectSpell(object sender)
        {
            PictureBox pb = sender as PictureBox;
            int spellId = (int)pb.Tag;
            this.Tag = spellId;
            this.Close();
        }
    }
}
