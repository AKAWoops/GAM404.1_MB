using MTB.ChracterStats;
public class Character
{
    public CharacterStat Strength;
}

public class Item
{
    StatModifier mod1, mod2;

    public void Equip(Character c)
    {
        // need ot to sttore modifiers in variables before i add then to a stat
       //mod1 = new StatModifier(10, StatModType.Flat, this);
       // mod2 = new StatModifier(0.1f, StatModType.PercentMult, this);
       // c.Strength.AddModifier(mod1);
       // c.Strength.AddModifier(mod2);
       // added this into new line more efficient

        c.Strength.AddModifiernew StatModifier(10, StatModType.Flat, this));
        c.Strength.AddModifier new StatModifier(0.1f, StatModType.PercentMult, this));
    }

    public void Unequip(Character c)
    {// stored modfiers in order so i can remove them
     // they would be lost other wise
     // c.Strength.RemoveModifier(mod1);
     // c.Strength.RemoveModifier(mod2);
     // updated code now
        c.Strength.RemoveAllModifiersFromSource(this);
    }
}