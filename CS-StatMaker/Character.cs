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
                new Race("Hill Dwarf", new Stats { Constitution = 2, Wisdom = 1 }, new List<Proficiency>{ weaponProficiency[0], weaponProficiency[1], weaponProficiency[2], weaponProficiency[3], toolProficiency[1], toolProficiency[2], toolProficiency[3], skillProficiency[5] }),
                new Race("Mountain Dwarf", new Stats { Constitution = 2, Strength = 2 }, new List<Proficiency>{ weaponProficiency[0], weaponProficiency[1], weaponProficiency[2], weaponProficiency[3], toolProficiency[1], toolProficiency[2], toolProficiency[3], skillProficiency[5], armorProficiency[1], armorProficiency[2] }),
                new Race("High Elf", new Stats { Dexterity = 2, Intelligence = 1 }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[4], weaponProficiency[5], weaponProficiency[6], weaponProficiency[7] }),
                new Race("Wood Elf", new Stats { Dexterity = 2, Wisdom = 1 }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[4], weaponProficiency[5], weaponProficiency[6], weaponProficiency[7] }),
                new Race("Drow", new Stats { Dexterity = 2, Charisma = 1 }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[5], weaponProficiency[8], weaponProficiency[9] }),
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
        public string Type { get; set; }
        public string Name { get; set; }
        public RelativeStat RelativeStat { get; set; }
        public ProficiencyRating ProfRating { get; set; } = ProficiencyRating.No;

        public Proficiency(string eType, string eName, RelativeStat eRelativeStat, ProficiencyRating eProfRating)
        {
            Type = eType;
            Name = eName;
            RelativeStat = eRelativeStat;
            ProfRating = eProfRating;
        }
    }

    public enum ProficiencyRating
    {
        No, JackOfAllTrades, Yes, Expertise
    };

    public enum RelativeStat
    {
        STR, DEX, CON, INT, WIS, CHA, Finesse, None
    }
    
    public class Proficiencies
    {
        public List<Proficiency> SkillProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Skill","Acrobatics",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill","Animal Handling",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill","Arcana",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill","Athletics",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Skill","Deception",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill","History",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill","Insight",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill","Intimidation",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill","Investigation",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill","Medicine",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill","Nature",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill","Perception",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill","Performance",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill","Persuasion",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill","Religion",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill","Sleight of Hand",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill","Stealth",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill","Survival",RelativeStat.WIS,ProficiencyRating.No)
        };

        public List<Proficiency> ToolProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Tool","Alchemist's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Brewer's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Calligrapher's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Carpenter's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Cobbler's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Cook's Utensils",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Glassblower's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Jeweler's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Leatherworker's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Mason's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Painter's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Potter's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Smith's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Tinker's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Weaver's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Woodcarver's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Disguise Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Forgery Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Dice Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Dragonchess Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Playing Card Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Three-Dragon Ante Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Herbalism Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Bagpipes",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Drum",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Dulcimer",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Flute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Lute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Lyre",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Horn",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Pan Flute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Shawm",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Viol",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Navigator's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Poisoner's Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Thieves' Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Land Vehicles",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool","Water Vehicles",RelativeStat.None,ProficiencyRating.No)
        };

        public List<Proficiency> WeaponProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Weapon","Club",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Dagger",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon","Greatclub",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Handaxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Javelin",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Light Hammer",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Mace",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Quarterstaff",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Sickle",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Spear",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Unarmed",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Light XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Dart",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Shortbow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Sling",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Battleaxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Flail",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Glaive",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Greataxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Halberd",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Lance",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Longsword",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Maul",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Morning Star",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Pike",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Rapier",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon","Scimitar",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon","Shortsword",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon","Trident",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","War Pick",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Warhammer",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon","Whip",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon","Blowgun",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Hand XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Heavy XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Longbow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon","Net",RelativeStat.DEX,ProficiencyRating.No)
        };

        public List<Proficiency> ArmorProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Armor","Heavy Armor",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Armor","Medium Armor",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Armor","Light Armor",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Armor","Shield",RelativeStat.None,ProficiencyRating.No)
        };
    }
}
            