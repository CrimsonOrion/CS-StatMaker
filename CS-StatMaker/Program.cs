﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_StatMaker
{
    class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string RollForStats(Random rnd)
        {
            List<int> Stats = new List<int>();
            string statsString = string.Empty;

            for (int i = 1; i < 5; i++)
            {
                int diceRoll = 0;
                bool reroll = true;
                while (reroll)
                {
                    diceRoll = rnd.Next(1, 7);
                    if (diceRoll != 1)
                    {
                        reroll = false;
                    }
                }
                Stats.Add(diceRoll);
            }
            int topRolls = Stats.Sum() - Stats.Min();

            //statsString = "Here is your stat total:" + topRolls + "\r\n";
            //statsString = Stats[0] + " + " + Stats[1] + " + " + Stats[2] + " + " + Stats[3];// + "\r\n";

            return topRolls.ToString();
        }

        public static string ApplyMod(TextBox tBox, Label lbl = null)
        {
            int modifierBonus = 0;
            int stat = 0;
            if (tBox != null) { stat = Convert.ToInt32(tBox.Text); } else { stat = Convert.ToInt32(lbl.Text); }
            switch (stat)
            {
                case 6:
                case 7:
                    modifierBonus = -2;
                    break;
                case 8:
                case 9:
                    modifierBonus = -1;
                    break;
                case 10:
                case 11:
                    modifierBonus = 0;
                    break;
                case 12:
                case 13:
                    modifierBonus = 1;
                    break;
                case 14:
                case 15:
                    modifierBonus = 2;
                    break;
                case 16:
                case 17:
                    modifierBonus = 3;
                    break;
                case 18:
                case 19:
                    modifierBonus = 4;
                    break;
                case 20:
                case 21:
                    modifierBonus = 5;
                    break;
                case 22:
                case 23:
                    modifierBonus = 6;
                    break;
                case 24:
                case 25:
                    modifierBonus = 7;
                    break;
                case 26:
                case 27:
                    modifierBonus = 8;
                    break;
                case 28:
                case 29:
                    modifierBonus = 9;
                    break;
                case 30:
                    modifierBonus = 10;
                    break;
            }
            return modifierBonus.ToString();
        }

        public static void AddRaces(ComboBox raceBox)
        {
            List<Race> races = Race.Races();
            foreach (Race race in races)
            {
                raceBox.Items.Add(race.Name);
            }
            raceBox.SelectedIndex = -1;
        }

        public static void SelectRace(ComboBox raceBox, Label str, Label dex, Label con, Label intel, Label wis, Label cha, ListBox skill, ListBox tool, ListBox weapon, ListBox armor)
        {
            List<Race> races = Race.Races();

            Race race = races.Where(f => f.Name.Equals(raceBox.SelectedItem)).FirstOrDefault();
            if (race != null)
            {
                str.Text = race.RacialBonusStats.Strength.ToString();
                dex.Text = race.RacialBonusStats.Dexterity.ToString();
                con.Text = race.RacialBonusStats.Constitution.ToString();
                intel.Text = race.RacialBonusStats.Intelligence.ToString();
                wis.Text = race.RacialBonusStats.Wisdom.ToString();
                cha.Text = race.RacialBonusStats.Charisma.ToString();
                List<string> skills = new List<string>();
                List<string> tools = new List<string>();
                List<string> weapons = new List<string>();
                List<string> armors = new List<string>();
                //string stat = race.RacialProficency.Where(s => s.RelativeStat.Equals(1)).FirstOrDefault().ToString();
                foreach (Proficiency prof in race.RacialProficency)
                {
                    switch (prof.Type)
                    {
                        case "Skill":
                            skills.Add(prof.Name + " (" + prof.RelativeStat.ToString() + ")");
                            break;
                        case "Tool":
                            tools.Add(prof.Name + " (" + prof.RelativeStat.ToString() + ")");
                            break;
                        case "Weapon":
                            weapons.Add(prof.Name + " (" + prof.RelativeStat.ToString() + ")");
                            break;
                        case "Armor":
                            armors.Add(prof.Name + " (" + prof.RelativeStat.ToString() + ")");
                            break;
                    }                    
                }
                skill.DataSource = skills;
                tool.DataSource = tools;
                weapon.DataSource = weapons;
                armor.DataSource = armors;
            }
        }
    }
}