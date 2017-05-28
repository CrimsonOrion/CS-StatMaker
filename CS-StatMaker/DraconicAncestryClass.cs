namespace CS_StatMaker
{
    public partial class Traits
    {
        class DraconicAncestryClass
        {
            public string DragonColor { get; set; }
            public Elements DamageType { get; set; }
            public BreathWeapon BreathWeaponType { get; set; }

            public DraconicAncestryClass(string eDragonColor, Elements eDamageType, BreathWeapon eBreathWeaponType)
            {
                DragonColor = eDragonColor;
                DamageType = eDamageType;
                BreathWeaponType = eBreathWeaponType;
            }

            public DraconicAncestryClass BlackDragon { get; } = new DraconicAncestryClass("Black", Elements.Acid,new BreathWeapon("5 by 30 ft. line", RelativeStat.DEX));
            public DraconicAncestryClass BlueDragon { get; } = new DraconicAncestryClass("Blue", Elements.Lightning, new BreathWeapon("5 by 30 ft. line", RelativeStat.DEX));
            public DraconicAncestryClass BrassDragon { get; } = new DraconicAncestryClass("Brass", Elements.Fire, new BreathWeapon("5 by 30 ft. line", RelativeStat.DEX));
            public DraconicAncestryClass BronzeDragon { get; } = new DraconicAncestryClass("Bronze", Elements.Lightning, new BreathWeapon("5 by 30 ft. line", RelativeStat.DEX));
            public DraconicAncestryClass CopperDragon { get; } = new DraconicAncestryClass("Copper", Elements.Acid, new BreathWeapon("5 by 30 ft. line", RelativeStat.DEX));
            public DraconicAncestryClass GoldDragon { get; } = new DraconicAncestryClass("Gold", Elements.Fire, new BreathWeapon("15 ft. cone", RelativeStat.DEX));
            public DraconicAncestryClass GreenDragon { get; } = new DraconicAncestryClass("Green", Elements.Poison, new BreathWeapon("15 ft. cone", RelativeStat.CON));
            public DraconicAncestryClass RedDragon { get; } = new DraconicAncestryClass("Red", Elements.Fire, new BreathWeapon("15 ft. cone", RelativeStat.DEX));
            public DraconicAncestryClass SilverDragon { get; } = new DraconicAncestryClass("Silver", Elements.Cold, new BreathWeapon("15 ft. cone", RelativeStat.CON));
            public DraconicAncestryClass WhiteDragon { get; } = new DraconicAncestryClass("White", Elements.Cold, new BreathWeapon("15 ft. cone", RelativeStat.CON));
        }

        class BreathWeapon
        {
            public string AreaOfAttack { get; set; }
            public RelativeStat SaveType { get; set; }

            public BreathWeapon(string eAreaOfAttack, RelativeStat eSaveType)
            {
                AreaOfAttack = eAreaOfAttack;
                SaveType = eSaveType;
            }
        }
    }
}