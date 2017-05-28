using System.Collections.Generic;

namespace CS_StatMaker
{
    public class Proficiency
    {
        public string Type { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public RelativeStat RelativeStat { get; set; }
        public ProficiencyRating ProfRating { get; set; }

        public Proficiency(string eType, int eIndex, string eName, RelativeStat eRelativeStat, ProficiencyRating eProfRating)
        {
            Type = eType;
            Index = eIndex;
            Name = eName;
            RelativeStat = eRelativeStat;
            ProfRating = eProfRating;
        }
    }

    public class Proficiencies
    {
        public List<Proficiency> SkillProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Skill",0,"Acrobatics",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill",1,"Animal Handling",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill",2,"Arcana",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill",3,"Athletics",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Skill",4,"Deception",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill",5,"History",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill",6,"Insight",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill",7,"Intimidation",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill",8,"Investigation",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill",9,"Medicine",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill",10,"Nature",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill",11,"Perception",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill",12,"Performance",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill",13,"Persuasion",RelativeStat.CHA,ProficiencyRating.No),
            new Proficiency("Skill",14,"Religion",RelativeStat.INT,ProficiencyRating.No),
            new Proficiency("Skill",15,"Sleight of Hand",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill",16,"Stealth",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Skill",17,"Survival",RelativeStat.WIS,ProficiencyRating.No),
            new Proficiency("Skill",18,"Additional Skill",RelativeStat.None,ProficiencyRating.No)
        };

        public List<Proficiency> ToolProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Tool",0,"Alchemist's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",1,"Brewer's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",2,"Calligrapher's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",3,"Carpenter's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",4,"Cobbler's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",5,"Cook's Utensils",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",6,"Glassblower's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",7,"Jeweler's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",8,"Leatherworker's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",9,"Mason's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",10,"Painter's Supplies",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",11,"Potter's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",12,"Smith's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",13,"Tinker's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",14,"Weaver's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",15,"Woodcarver's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",16,"Disguise Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",17,"Forgery Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",18,"Dice Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",19,"Dragonchess Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",20,"Playing Card Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",21,"Three-Dragon Ante Set",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",22,"Herbalism Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",23,"Bagpipes",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",24,"Drum",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",25,"Dulcimer",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",26,"Flute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",27,"Lute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",28,"Lyre",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",29,"Horn",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",30,"Pan Flute",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",31,"Shawm",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",32,"Viol",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",33,"Navigator's Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",34,"Poisoner's Kit",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",35,"Thieves' Tools",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",36,"Land Vehicles",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Tool",37,"Water Vehicles",RelativeStat.None,ProficiencyRating.No)
        };

        public List<Proficiency> WeaponProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Weapon",0,"Club",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",1,"Dagger",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon",2,"Greatclub",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",3,"Handaxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",4,"Javelin",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",5,"Light Hammer",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",6,"Mace",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",7,"Quarterstaff",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",8,"Sickle",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",9,"Spear",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",10,"Unarmed",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",11,"Light XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",12,"Dart",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",13,"Shortbow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",14,"Sling",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",15,"Battleaxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",16,"Flail",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",17,"Glaive",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",18,"Greataxe",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",19,"Halberd",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",20,"Lance",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",21,"Longsword",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",22,"Maul",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",23,"Morning Star",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",24,"Pike",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",25,"Rapier",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon",26,"Scimitar",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon",27,"Shortsword",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon",28,"Trident",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",29,"War Pick",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",30,"Warhammer",RelativeStat.STR,ProficiencyRating.No),
            new Proficiency("Weapon",31,"Whip",RelativeStat.Finesse,ProficiencyRating.No),
            new Proficiency("Weapon",32,"Blowgun",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",33,"Hand XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",34,"Heavy XBow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",35,"Longbow",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Weapon",36,"Net",RelativeStat.DEX,ProficiencyRating.No)
        };

        public List<Proficiency> ArmorProficiencies { get; } = new List<Proficiency>
        {
            new Proficiency("Armor",0,"Heavy Armor",RelativeStat.None,ProficiencyRating.No),
            new Proficiency("Armor",1,"Medium Armor",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Armor",2,"Light Armor",RelativeStat.DEX,ProficiencyRating.No),
            new Proficiency("Armor",3,"Shield",RelativeStat.None,ProficiencyRating.No)
        };
    }
}