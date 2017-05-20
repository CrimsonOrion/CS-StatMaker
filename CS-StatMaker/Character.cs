using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_StatMaker
{
    public class Character
    {
        // Basic Information
        public string Name { get; set; }

        // Base stats
        public Stats BaseStats { get; set; }

        // Race
        public Race MyRace { get; set; }

        public Character(string eName, Stats eBaseStats, Race eMyRace)
        {
            Name = eName;
            BaseStats = eBaseStats;
            MyRace = eMyRace;
        }


    }

    public class Stats
    {
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Wisdom { get; set; } = 0;
        public int Charisma { get; set; } = 0;
        public int Additional { get; set; } = 0;
    }

    public class Race
    {
        public string Name { get; set; }

        public Stats RacialBonusStats { get; set; }

        public List<Proficiency> RacialProficency { get; set; }
        

        public Race(string eName, Stats eBonusStats, List<Proficiency> eSkillProficiency)
        {
            Name = eName;
            RacialBonusStats = eBonusStats;            
            foreach (Proficiency skill in eSkillProficiency)
            {
                skill.ProfRating = ProficiencyRating.Yes;
            }
            RacialProficency = eSkillProficiency;
        }

        public static List<Race> Races()
        {
            List<Proficiency> skillProficiency = new Proficiencies().SkillProficiencies;
            List<Proficiency> toolProficiency = new Proficiencies().ToolProficiencies;
            List<Proficiency> weaponProficiency = new Proficiencies().WeaponProficiencies;
            List<Proficiency> armorProficiency = new Proficiencies().ArmorProficiencies;

            List<Race> races = new List<Race>
            {
                new Race("Hill Dwarf", new Stats { Constitution = 2, Wisdom = 1 }, new List<Proficiency>{ weaponProficiency[0], weaponProficiency[1], weaponProficiency[2], weaponProficiency[3], toolProficiency[1], skillProficiency[5] }),
                new Race("Mountain Dwarf", new Stats { Constitution = 2, Strength = 2 }, new List<Proficiency>{ }),
                new Race("High Elf", new Stats { Dexterity = 2, Intelligence = 1 }, new List<Proficiency>{ }),
                new Race("Wood Elf", new Stats { Dexterity = 2, Wisdom = 1 }, new List<Proficiency>{ }),
                new Race("Drow", new Stats { Dexterity = 2, Charisma = 1 }, new List<Proficiency>{ }),
                new Race("Lightfoot Halfling", new Stats { Dexterity = 2, Charisma = 1 }, new List<Proficiency>{ }),
                new Race("Stout Halfling", new Stats { Dexterity = 2, Constitution = 1 }, new List<Proficiency>{ }),
                new Race("Human", new Stats { Strength = 1, Dexterity = 1, Constitution = 1, Intelligence = 1, Wisdom = 1, Charisma = 1 }, new List<Proficiency>{ }),
                new Race("Human - Variant", new Stats { Additional = 2 }, new List<Proficiency>{ }),
                new Race("Dragonborn", new Stats { Strength = 2, Charisma = 1 }, new List<Proficiency>{ }),
                new Race("Forest Gnome", new Stats { Intelligence = 2, Dexterity = 1 }, new List<Proficiency>{ }),
                new Race("Rock Gnome", new Stats { Intelligence = 2, Constitution = 1 }, new List<Proficiency>{ }),
                new Race("Half-Elf", new Stats { Charisma = 2, Additional = 2 }, new List<Proficiency>{ }),
                new Race("Half-Orc", new Stats { Strength = 2, Constitution = 1 }, new List<Proficiency>{ }),
                new Race("Tiefling", new Stats { Charisma = 2, Intelligence = 1 }, new List<Proficiency>{ })
            };

            return races;
        }
    }

    public class Proficiency
    {
        public string Name { get; set; }
        public Stats RelativeStat { get; set; }
        public ProficiencyRating ProfRating { get; set; } = ProficiencyRating.No;

        public Proficiency(string eName, Stats eRelativeStat, ProficiencyRating eProfRating)
        {
            Name = eName;
            RelativeStat = eRelativeStat;
            ProfRating = eProfRating;
        }
    }

    public enum ProficiencyRating
    {
        No = 0,
        JackOfAllTrades,
        Yes,
        Expertise
    };
    
    public class Proficiencies
    {
        public List<Proficiency> SkillProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Acrobatics",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Animal Handling",new Stats(){Wisdom = 1},ProficiencyRating.No),
            new Proficiency("Arcana",new Stats(){Intelligence = 1},ProficiencyRating.No),
            new Proficiency("Athletics",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Deception",new Stats(){Charisma = 1},ProficiencyRating.No),
            new Proficiency("History",new Stats(){Intelligence = 1},ProficiencyRating.No),
            new Proficiency("Insight",new Stats(){Wisdom = 1},ProficiencyRating.No),
            new Proficiency("Intimidation",new Stats(){Charisma = 1},ProficiencyRating.No),
            new Proficiency("Investigation",new Stats(){Intelligence = 1},ProficiencyRating.No),
            new Proficiency("Medicine",new Stats(){Wisdom = 1},ProficiencyRating.No),
            new Proficiency("Nature",new Stats(){Intelligence = 1},ProficiencyRating.No),
            new Proficiency("Perception",new Stats(){Wisdom = 1},ProficiencyRating.No),
            new Proficiency("Performance",new Stats(){Charisma = 1},ProficiencyRating.No),
            new Proficiency("Persuasion",new Stats(){Charisma = 1},ProficiencyRating.No),
            new Proficiency("Religion",new Stats(){Intelligence = 1},ProficiencyRating.No),
            new Proficiency("Sleight of Hand",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Stealth",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Survival",new Stats(){Wisdom = 1},ProficiencyRating.No)
        };

        public List<Proficiency> ToolProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Thieves' Tools",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Smith's Tools",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Brewer's Supplies",new Stats(){Dexterity = 1},ProficiencyRating.No),
            new Proficiency("Mason's Tools",new Stats(){Dexterity = 1},ProficiencyRating.No)
        };

        public List<Proficiency> WeaponProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Battleaxe",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Handaxe",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Throwing Hammer",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Warhammer",new Stats(){Strength = 1},ProficiencyRating.No)
        };

        public List<Proficiency> ArmorProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Heavy Armor",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Medium Armor",new Stats(){Strength = 1},ProficiencyRating.No),
            new Proficiency("Light Armor",new Stats(){Strength = 1},ProficiencyRating.No)
        };
    }
}
            