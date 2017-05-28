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

        public Race() { }        

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
                new Race("Lightfoot Halfling", new Stats { Dexterity = 2, Charisma = 1 }, false, new List<Languages> { Languages.Halfling, Languages.Common }, new List<Proficiency>{ }, new List<string>{ Traits.Lucky, Traits.Brave, Traits.HalflingNimbleness, "NATURALLY STEALTHY:\r\nYou can attempt to hide even when you are obscured only by a creature that is at least one size larger than you." }),
                new Race("Stout Halfling", new Stats { Dexterity = 2, Constitution = 1 }, false, new List<Languages> { Languages.Halfling, Languages.Common }, new List<Proficiency>{ }, new List<string> { Traits.Lucky, Traits.Brave, Traits.HalflingNimbleness, "STOUT RESISTANCE:\r\nYou have advantage on saving throws against poison, and you have resistance against poison damage." }),
                new Race("Human", new Stats { Strength = 1, Dexterity = 1, Constitution = 1, Intelligence = 1, Wisdom = 1, Charisma = 1 }, false, new List<Languages> { Languages.Common, Languages.ADDITIONAL }, new List<Proficiency>{ }, new List<string> { Traits.ExtraLanguage }),
                new Race("Human - Variant", new Stats { Additional = 2 }, false, new List<Languages> { Languages.Common, Languages.ADDITIONAL }, new List<Proficiency>{ skillProficiency[18] }, new List<string> { Traits.ExtraLanguage, Traits.CustomAbilityScoreIncrease }),
                new Race("Dragonborn", new Stats { Strength = 2, Charisma = 1 }, false, new List<Languages> { Languages.Draconic, Languages.Common }, new List<Proficiency>{ }, new List<string> { Traits.DraconicAncestry, Traits.DraconicBreathWeapon, Traits.DraconicDamageResistance }),
                new Race("Forest Gnome", new Stats { Intelligence = 2, Dexterity = 1 }, true, new List<Languages> { Languages.Gnomish, Languages.Common }, new List<Proficiency>{ }, new List<string> {Traits.Darkvision, Traits.GnomeCunning, "NATURAL ILLUSIONIST:\r\nYou know the minor illusion cantrip. Intelligence is your spellcasting ability for it.", "SPEAK WITH SMALL BEASTS:\r\nThrough sounds and gestures, you can communicate simple ideas with Small or smaller beasts. Forest gnomes love animals and often keep squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets." }),
                new Race("Rock Gnome", new Stats { Intelligence = 2, Constitution = 1 }, true, new List<Languages> { Languages.Gnomish, Languages.Common }, new List<Proficiency>{ toolProficiency[13] }, new List<string> {Traits.Darkvision, Traits.GnomeCunning, "ARTIFICER'S LORE:\r\nWhenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus (expertise), instead of any proficiency bonus you normally apply.", "TINKER:\r\nYou have proficiency with artisan’s tools (tinker’s tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time.\r\nWhen you create a device, choose one of the following options:\r\n\"Clockwork Toy\"\r\nThis toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction. It makes noises as appropriate to the creature it represents.\r\n\"Fire Starter\"\r\nThe device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action.\r\n\"Music Box\"\r\nWhen opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song’s end or when it is closed." }),
                new Race("Half-Elf", new Stats { Charisma = 2, Additional = 2 }, true, new List<Languages> { Languages.Elvish, Languages.Common, Languages.ADDITIONAL }, new List<Proficiency>{ skillProficiency[18], skillProficiency[18] }, new List<string> { Traits.Darkvision, Traits.FeyAncestry, Traits.ExtraLanguage, Traits.CustomAbilityScoreIncrease, "SKILL VERSATILITY:\r\nYou gain proficiency in two skills of your choice." }),
                new Race("Half-Orc", new Stats { Strength = 2, Constitution = 1 }, true, new List<Languages> { Languages.Orc, Languages.Common }, new List<Proficiency>{ skillProficiency[7] }, new List<string> {Traits.Darkvision, "MENACING:\r\nYou gain proficiency in the Intimidation skill.", "RELENTLESS ENDURANCE:\r\nWhen you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a long rest.", "SAVAGE ATTCKS\r\nWhen you score a critical hit with a melee weapon attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit." }),
                new Race("Tiefling", new Stats { Charisma = 2, Intelligence = 1 }, true, new List<Languages> { Languages.Infernal, Languages.Common }, new List<Proficiency>{ }, new List<string> { Traits.Darkvision, "HELLISH RESISTANCE:\r\nYou have resistance to fire damage.", "INFERNAL LEGACY:\r\nYou know the thaumaturgy cantrip. Once you reach 3rd level, you can cast the hellish rebuke spell once per day as a 2nd-level spell. Once you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells." })
            };
            return races;
        }
    }
}
            