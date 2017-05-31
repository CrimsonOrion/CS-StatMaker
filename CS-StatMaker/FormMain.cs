using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CS_StatMaker
{
    public partial class FormMain : Form
    {
        TextBox sourceTextbox = null;
        //bool alreadyRolled = false;       
        public FormMain()
        {
            InitializeComponent();            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            /*
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            int dice4 = rnd.Next(1, 7);
            List<int> Stats = new List<int>() { dice1, dice2, dice3, dice4 };
            textBox1.Text += dice1.ToString() + " + " + dice2.ToString() + " + " + dice3.ToString() + " + " + dice4.ToString() + "\r\n";
            */

            List<TextBox> statBoxes = new List<TextBox>
            {
                { StrBox },
                { DexBox },
                { ConBox },
                { IntBox },
                { WisBox },
                { ChaBox },                
            };

            List<TextBox> textBoxes = new List<TextBox>
            {               
                { RacialTraitTextbox }
            };

            List<Label> labels = new List<Label>
            {
                { RemainingPoints },
                { StrMod },
                { DexMod },
                { ConMod },
                { IntMod },
                { WisMod },
                { ChaMod },
                { StrBonus },
                { DexBonus },
                { ConBonus },
                { IntBonus },
                { WisBonus },
                { ChaBonus },
                { StrTotal },
                { DexTotal },
                { ConTotal },
                { IntTotal },
                { WisTotal },
                { ChaTotal },
                { DarkvisionLabel },
                { LanguagesLabel }
            };

            List<ListBox> listBoxes = new List<ListBox>
            {
                { SkillProficencyListbox },
                { ToolProficencyListbox },
                { WeaponProficencyListbox },
                { ArmorProficencyListbox }
            };

            List<ComboBox> comboBoxes = new List<ComboBox>
            {
                { RaceDropbox }
            };

            List<RadioButton> radioButtons = new List<RadioButton>
            {
                { RadioRoll },
                { RadioSet }
            };
            
            Random rng = new Random();
            foreach (TextBox tBox in statBoxes)
            {
                tBox.Text = Program.RollForStats(rng);
            }
        }

        private void Die_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            sourceTextbox = tb;
            tb.DoDragDrop(tb.Text, DragDropEffects.Move);            
        }

        private void Die_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;                
            }
            else
            {
                e.Effect = DragDropEffects.None;                
            }
        }

        private void Die_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            sourceTextbox.Text = tb.Text;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
            switch (tb.Name)
            {
                case "StrBox":
                    StrMod.Text = Program.ApplyMod(tb.Text);
                    break;
                case "DexBox":
                    DexMod.Text = Program.ApplyMod(tb.Text);
                    break;
                case "ConBox":
                    ConMod.Text = Program.ApplyMod(tb.Text);
                    break;
                case "IntBox":
                    IntMod.Text = Program.ApplyMod(tb.Text);
                    break;
                case "WisBox":
                    WisMod.Text = Program.ApplyMod(tb.Text);
                    break;
                case "ChaBox":
                    ChaMod.Text = Program.ApplyMod(tb.Text);
                    break;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            StrBox.DragEnter += new DragEventHandler(Die_DragEnter);
            StrBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            StrBox.DragDrop += new DragEventHandler(Die_DragDrop);
            DexBox.DragEnter += new DragEventHandler(Die_DragEnter);
            DexBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            DexBox.DragDrop += new DragEventHandler(Die_DragDrop);
            ConBox.DragEnter += new DragEventHandler(Die_DragEnter);
            ConBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            ConBox.DragDrop += new DragEventHandler(Die_DragDrop);
            IntBox.DragEnter += new DragEventHandler(Die_DragEnter);
            IntBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            IntBox.DragDrop += new DragEventHandler(Die_DragDrop);
            WisBox.DragEnter += new DragEventHandler(Die_DragEnter);
            WisBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            WisBox.DragDrop += new DragEventHandler(Die_DragDrop);
            ChaBox.DragEnter += new DragEventHandler(Die_DragEnter);
            ChaBox.MouseDown += new MouseEventHandler(Die_MouseDown);
            ChaBox.DragDrop += new DragEventHandler(Die_DragDrop);            
            Program.AddRaces(RaceDropbox);
            string characterName = "What is your character's name?";
            Program.ShowInputDialog(ref characterName);
            this.Text += " - " + characterName;
        }

        private void RaceDropbox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Program.SelectRace(RaceDropbox, StrBonus, DexBonus, ConBonus, IntBonus, WisBonus, ChaBonus, BonusStat, DarkvisionLabel, LanguagesLabel, SkillProficencyListbox, ToolProficencyListbox, WeaponProficencyListbox, ArmorProficencyListbox, RacialTraitTextbox);
            if (StrBox.Text != "") { StrTotal.Text = (Convert.ToInt16(StrBox.Text) + Convert.ToInt16(StrBonus.Text)).ToString(); } else { StrTotal.Text = "0"; }
            if (DexBox.Text != "") { DexTotal.Text = (Convert.ToInt16(DexBox.Text) + Convert.ToInt16(DexBonus.Text)).ToString(); } else { DexTotal.Text = "0"; }
            if (ConBox.Text != "") { ConTotal.Text = (Convert.ToInt16(ConBox.Text) + Convert.ToInt16(ConBonus.Text)).ToString(); } else { ConTotal.Text = "0"; }
            if (IntBox.Text != "") { IntTotal.Text = (Convert.ToInt16(IntBox.Text) + Convert.ToInt16(IntBonus.Text)).ToString(); } else { IntTotal.Text = "0"; }
            if (WisBox.Text != "") { WisTotal.Text = (Convert.ToInt16(WisBox.Text) + Convert.ToInt16(WisBonus.Text)).ToString(); } else { WisTotal.Text = "0"; }
            if (ChaBox.Text != "") { ChaTotal.Text = (Convert.ToInt16(ChaBox.Text) + Convert.ToInt16(ChaBonus.Text)).ToString(); } else { ChaTotal.Text = "0"; }
            StrMod.Text = Program.ApplyMod(null, StrTotal);
            DexMod.Text = Program.ApplyMod(null, DexTotal);
            ConMod.Text = Program.ApplyMod(null, ConTotal);
            IntMod.Text = Program.ApplyMod(null, IntTotal);
            WisMod.Text = Program.ApplyMod(null, WisTotal);
            ChaMod.Text = Program.ApplyMod(null, ChaTotal);            
        }

        private void RadioRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRoll.Checked == true && MessageBox.Show("Roll for stats instead?", "Roll Instead?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                StartButton.Enabled = true;
                RemainingPoints.Text = "0";
                StartButton_Click(sender, e);
            }
        }

        private void RadioSet_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSet.Checked == true && MessageBox.Show("Set stats instead?", "Set Instead?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<TextBox> statBoxes = new List<TextBox>{ StrBox,DexBox,ConBox,IntBox,WisBox,ChaBox };                
                StartButton.Enabled = false;                
                RemainingPoints.Text = "27";
                foreach (TextBox tBox in statBoxes)
                {
                    tBox.Text = "8";
                }
            }
        }

        private void DieBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox DieBox = sender as TextBox;
            if (RadioSet.Checked == true && DieBox.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Add)
                {
                    Program.AddToStat(DieBox, RemainingPoints);
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    Program.SubtractFromStat(DieBox, RemainingPoints);
                }
            }
        }

        private void RaceTab_Enter(object sender, EventArgs e)
        {
            List<Label> statTotal = new List<Label> { StrTotal, DexTotal, ConTotal, IntTotal, WisTotal, ChaTotal };
            List<TextBox> statBox = new List<TextBox> { StrBox, DexBox, ConBox, IntBox, WisBox, ChaBox };
            List<Label> statBonus = new List<Label> { StrBonus, DexBonus, ConBonus, IntBonus, WisBonus, ChaBonus };
            List<Label> statMod = new List<Label> { StrMod, DexMod, ConMod, IntMod, WisMod, ChaMod };

            for (int index = 0; index < statTotal.Count; index++)
            {
                statTotal[index].Text = (Convert.ToInt16(statBox[index].Text) + Convert.ToInt16(statBonus[index].Text)).ToString();
                statMod[index].Text = Program.ApplyMod(statTotal[index].Text);
            }            
        }

        private void Bonus_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            switch (lbl.Name)
            {
                case "StrBonus":
                    Program.ApplyBonusStat(sender, BonusStat, StrTotal, StrMod);
                    break;
                case "DexBonus":
                    Program.ApplyBonusStat(sender, BonusStat, DexTotal, DexMod);
                    break;
                case "ConBonus":
                    Program.ApplyBonusStat(sender, BonusStat, ConTotal, ConMod);
                    break;
                case "IntBonus":
                    Program.ApplyBonusStat(sender, BonusStat, IntTotal, IntMod);
                    break;
                case "WisBonus":
                    Program.ApplyBonusStat(sender, BonusStat, WisTotal, WisMod);
                    break;
                case "ChaBonus":
                    Program.ApplyBonusStat(sender, BonusStat, ChaTotal, ChaMod);
                    break;
            }
        }
    }
}
