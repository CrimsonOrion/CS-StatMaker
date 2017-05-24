using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_StatMaker
{
    public partial class Form1 : Form
    {
        TextBox sourceTextbox = null;
        bool alreadyRolled = false;
        public Form1()
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
            List<TextBox> textBoxes = new List<TextBox>
            {
                { DieBox1 },
                { DieBox2 },
                { DieBox3 },
                { DieBox4 },
                { DieBox5 },
                { DieBox6 },
                { StrBox },
                { DexBox },
                { ConBox },
                { IntBox },
                { WisBox },
                { ChaBox }
            };

            List<Label> labels = new List<Label>
            {
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
                { ChaTotal }
            };

            List<ComboBox> comboBoxes = new List<ComboBox>
            {
                { RaceDropbox }
            };

            if ((alreadyRolled) && (StrBox.Text != "" | DexBox.Text != "" | ConBox.Text != "" | IntBox.Text != "" | WisBox.Text != "" | ChaBox.Text != "") && MessageBox.Show("Do you want to start over?", "Start Over?", MessageBoxButtons.YesNo) == DialogResult.No )
            {
                return;
            }
            
            foreach (TextBox tBox in textBoxes)
            {
                tBox.Clear();
            }

            foreach (Label label in labels)
            {
                label.Text = "0";
            }

            foreach (ComboBox cBox in comboBoxes)
            {
                cBox.Text = string.Empty;
            }

            Random rng = new Random();
            DieBox1.Text = Program.RollForStats(rng);
            DieBox2.Text = Program.RollForStats(rng);
            DieBox3.Text = Program.RollForStats(rng);
            DieBox4.Text = Program.RollForStats(rng);
            DieBox5.Text = Program.RollForStats(rng);
            DieBox6.Text = Program.RollForStats(rng);
            alreadyRolled = true;

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
                    StrMod.Text = Program.ApplyMod(tb);
                    break;
                case "DexBox":
                    DexMod.Text = Program.ApplyMod(tb);
                    break;
                case "ConBox":
                    ConMod.Text = Program.ApplyMod(tb);
                    break;
                case "IntBox":
                    IntMod.Text = Program.ApplyMod(tb);
                    break;
                case "WisBox":
                    WisMod.Text = Program.ApplyMod(tb);
                    break;
                case "ChaBox":
                    ChaMod.Text = Program.ApplyMod(tb);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            DieBox2.DragEnter += new DragEventHandler(Die_DragEnter);
            DieBox2.MouseDown += new MouseEventHandler(Die_MouseDown);
            DieBox2.DragDrop += new DragEventHandler(Die_DragDrop);
            DieBox3.DragEnter += new DragEventHandler(Die_DragEnter);
            DieBox3.MouseDown += new MouseEventHandler(Die_MouseDown);
            DieBox3.DragDrop += new DragEventHandler(Die_DragDrop);
            DieBox4.DragEnter += new DragEventHandler(Die_DragEnter);
            DieBox4.MouseDown += new MouseEventHandler(Die_MouseDown);
            DieBox4.DragDrop += new DragEventHandler(Die_DragDrop);
            DieBox5.DragEnter += new DragEventHandler(Die_DragEnter);
            DieBox5.MouseDown += new MouseEventHandler(Die_MouseDown);
            DieBox5.DragDrop += new DragEventHandler(Die_DragDrop);
            DieBox6.DragEnter += new DragEventHandler(Die_DragEnter);
            DieBox6.MouseDown += new MouseEventHandler(Die_MouseDown);
            DieBox6.DragDrop += new DragEventHandler(Die_DragDrop);
            Program.AddRaces(RaceDropbox);
        }

        private void RaceDropbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //RaceClass.RaceStatBonus(RaceDropbox, StrBonus, DexBonus, ConBonus, IntBonus, WisBonus, ChaBonus);
            Program.SelectRace(RaceDropbox, StrBonus, DexBonus, ConBonus, IntBonus, WisBonus, ChaBonus, DarkvisionLabel, LanguagesLabel, SkillProficencyListbox, ToolProficencyListbox, WeaponProficencyListbox, ArmorProficencyListbox, RacialTraitTextbox);
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
    }
}
