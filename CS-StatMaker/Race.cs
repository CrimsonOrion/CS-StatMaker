using System;
using System.Collections.Generic;


namespace CS_StatMaker
{
    public class Race
    {
        public string Name { get; set; }
        public Stats RacialBonusStats { get; set; }
        public bool Darkvision { get; set; }
        public List<Languages> KnownLanguages { get; set; }
        public List<Proficiency> RacialProficency { get; set; }
        public List<string> RacialNotes { get; set; }
        

        public Race(string eName, Stats eBonusStats, bool eDarkvision, List<Languages> eKnownLanguages, List<Proficiency> eSkillProficiency, List<String> eRacialNotes)
        {
            Name = eName;
            RacialBonusStats = eBonusStats;
            Darkvision = eDarkvision;
            KnownLanguages = eKnownLanguages;
            foreach (Proficiency skill in eSkillProficiency)
            {
                skill.ProfRating = ProficiencyRating.Yes;
            }
            RacialProficency = eSkillProficiency;
            RacialNotes = eRacialNotes;
        }

        public static List<Race> Races()
        {
            List<Proficiency> skillProficiency = new Proficiencies().SkillProficiencies;
            List<Proficiency> toolProficiency = new Proficiencies().ToolProficiencies;
            List<Proficiency> weaponProficiency = new Proficiencies().WeaponProficiencies;
            List<Proficiency> armorProficiency = new Proficiencies().ArmorProficiencies;

            List<Race> races = new List<Race>
            {
                new Race("Hill Dwarf", new Stats { Constitution = 2, Wisdom = 1 }, true, new List<Languages> { Languages.Dwarvish, Languages.Common }, new List<Proficiency>{ weaponProficiency[3], weaponProficiency[5], weaponProficiency[15], weaponProficiency[30], toolProficiency[1], toolProficiency[9], toolProficiency[12] }, new List<string> {Traits.Darkvision, Traits.DwarvenResistance, Traits.DwarvenCombatTraining, "TOOL PROFICIENCY:\r\nYou gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.", "STONECUNNING:\r\nWhenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus." }),
                new Race("Mountain Dwarf", new Stats { Constitution = 2, Strength = 2 }, true, new List<Languages> { Languages.Dwarvish, Languages.Common }, new List<Proficiency>{ weaponProficiency[3], weaponProficiency[5], weaponProficiency[15], weaponProficiency[30], toolProficiency[1], toolProficiency[9], toolProficiency[12], armorProficiency[1], armorProficiency[2] }, new List<string> {Traits.Darkvision, Traits.DwarvenResistance, Traits.DwarvenCombatTraining, "DWARVEN ARMOR TRAINING:\r\nYou have proficiency with light and medium armor." , "TOOL PROFICIENCY:\r\nYou gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.", "STONECUNNING:\r\nWhenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus." }),
                new Race("High Elf", new Stats { Dexterity = 2, Intelligence = 1 }, true, new List<Languages> { Languages.Elvish, Languages.Common, Languages.ADDITIONAL }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[13], weaponProficiency[21], weaponProficiency[27], weaponProficiency[35] }, new List<string> { Traits.Darkvision, Traits.KeenSenses, Traits.FeyAncestry, Traits.Trance, Traits.ExtraLanguage, Traits.ElfWeaponTraining, "CANTRIP:\r\nYou know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it." }),
                new Race("Wood Elf", new Stats { Dexterity = 2, Wisdom = 1 }, true, new List<Languages> { Languages.Elvish, Languages.Common }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[13], weaponProficiency[21], weaponProficiency[27], weaponProficiency[35]  }, new List<string> { Traits.Darkvision, Traits.KeenSenses, Traits.FeyAncestry, Traits.Trance, Traits.ElfWeaponTraining, "FLEET OF FOOT:\r\nYour base walking speed increases to 35 feet.", "MASK OF THE WILD:\r\nYou can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."}),
                new Race("Dark Elf (Drow)", new Stats { Dexterity = 2, Charisma = 1 }, true, new List<Languages> { Languages.Elvish, Languages.Common, Languages.Undercommon }, new List<Proficiency>{ skillProficiency[11], weaponProficiency[25], weaponProficiency[27], weaponProficiency[33] }, new List<string> { Traits.Darkvision, Traits.KeenSenses, Traits.FeyAncestry, Traits.Trance, "SUPERIOR DARKVISION:\r\nYour darkvision has a radius of 120 feet.", "SUNLIGHT SENSITIVITY:\r\nYou have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight.", "DROW MAGIC:\r\nYou know the dancing lights cantrip. When you reach 3rd level, you can cast the faerie fire spell once per day. When you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells.", "DROW WEAPON TRAINING:\r\nYou have proficiency with rapiers, shortswords, and hand crossbows." }),
                new Race("Lightfoot Halfling", new Stats { Dexterity = 2, Charisma = 1 }, false, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Stout Halfling", new Stats { Dexterity = 2, Constitution = 1 }, false, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Human", new Stats { Strength = 1, Dexterity = 1, Constitution = 1, Intelligence = 1, Wisdom = 1, Charisma = 1 }, false, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Human - Variant", new Stats { Additional = 2 }, false, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Dragonborn", new Stats { Strength = 2, Charisma = 1 }, false, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Forest Gnome", new Stats { Intelligence = 2, Dexterity = 1 }, true, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Rock Gnome", new Stats { Intelligence = 2, Constitution = 1 }, true, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Half-Elf", new Stats { Charisma = 2, Additional = 2 }, true, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Half-Orc", new Stats { Strength = 2, Constitution = 1 }, true, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" }),
                new Race("Tiefling", new Stats { Charisma = 2, Intelligence = 1 }, true, new List<Languages> { }, new List<Proficiency>{ }, new List<string> {"" })
            };            

            return races;
        }
    }
}
            