using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SpellEffect
{
    public partial class TargetEditor : Form
    {
        EffectData effectData;
        MySqlConn mysqlCon;

        public TargetEditor()
        {
            InitializeComponent();
        }

        public TargetEditor(ref EffectData _effectData, MySqlConn _mysqlconn)
        {
            InitializeComponent();
            mysqlCon = _mysqlconn;
            effectData = _effectData;
            ChangeTargetTB.Text = ((uint)effectData.targets).ToString();
            CurrentValueTB.Text = ((uint)effectData.targets).ToString();

            foreach (SpellTargetType stt in Enum.GetValues(typeof(SpellTargetType)))
                if (effectData.targets.HasFlag(stt))
                    CurrentValueLB.Items.Add(stt.ToString());

            // AllEnumValuesLB
            string[] spellTargetType = Enum.GetNames(typeof(SpellTargetType));
            for (int cnt = 0; cnt < spellTargetType.Length; cnt++)
                if(CurrentValueLB.Items.IndexOf(spellTargetType[cnt]) == -1)
                    AllEnumValuesLB.Items.Add(spellTargetType[cnt]);
        }

        public static byte[] FromHex(string hex)
        {
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return raw;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SpellTargetType stt2 = SpellTargetType.NONE;
            foreach (SpellTargetType stt in Enum.GetValues(typeof(SpellTargetType)))
                if (CurrentValueLB.Items.Contains(stt.ToString()))
                    stt2 |= stt;

            if((Int32)stt2 == 230)
            {
                MessageBox.Show("Cette valeur/Flags n'est pas valide pour Stump World");
                return;
            }

            effectData.targets = stt2;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Method1Panel.Enabled = true;
            else
                Method2Panel.Enabled = true;
        }

        private void LeftArrowPB_Click(object sender, EventArgs e)
        {
            if (AllEnumValuesLB.SelectedIndex != -1)
            {
                string selectedValue = AllEnumValuesLB.SelectedItem.ToString();
                CurrentValueLB.Items.Add(AllEnumValuesLB.SelectedItem);
                AllEnumValuesLB.Items.Remove(AllEnumValuesLB.SelectedItem);

                // recalcule
                SpellTargetType stt2 = SpellTargetType.NONE;
                foreach(SpellTargetType stt in Enum.GetValues(typeof(SpellTargetType)))
                    if (CurrentValueLB.Items.Contains(stt.ToString()))
                        stt2 |= stt;

                CurrentValueTB.Text = ((uint)stt2).ToString();
                effectData.targets = stt2;

                AllEnumValuesLB.SelectedIndex = AllEnumValuesLB.Items.Count - 1;
            }
            else
                MessageBox.Show("Veuillez selectionner un élement dans la liste 'Avalaible Flags'");
        }

        private void RightArrowPB_Click(object sender, EventArgs e)
        {
            if (CurrentValueLB.SelectedIndex != -1)
            {
                string selectedValue = CurrentValueLB.SelectedItem.ToString();
                AllEnumValuesLB.Items.Add(CurrentValueLB.SelectedItem);
                CurrentValueLB.Items.Remove(CurrentValueLB.SelectedItem);

                // recalcule
                SpellTargetType stt2 = SpellTargetType.NONE;
                foreach (SpellTargetType stt in Enum.GetValues(typeof(SpellTargetType)))
                    if (CurrentValueLB.Items.Contains(stt.ToString()))
                        stt2 |= stt;

                CurrentValueTB.Text = ((uint)stt2).ToString();
                effectData.targets = stt2;

                CurrentValueLB.SelectedIndex = CurrentValueLB.Items.Count - 1;
            }
            else
                MessageBox.Show("Veuillez selectionner un élement dans la liste 'Current Flags'");
        }

        private void EditBtn2_Click(object sender, EventArgs e)
        {
            int targetValue;
            bool parsed = int.TryParse(ChangeTargetTB.Text, out targetValue);
            if (targetValue == 230)
            {
                MessageBox.Show("Cette valeur/Flags n'est pas valide pour Stump World");
                return;
            }

            if (parsed)
                effectData.targets = (SpellTargetType)targetValue;
            else
            {
                MessageBox.Show("Impossible de déterminer la valeur Target selon la valeur " + ChangeTargetTB.Text);
                return;
            }

            this.Close();
        }
    }
}