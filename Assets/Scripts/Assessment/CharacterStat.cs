using System.Collections.Generic;


public class CharacterStat 
{
    public float BaseValue;

    private readonly List<StatModifier> statModifiers;

    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
    }
    void someFunc()
    {
        statModifiers = null;
        statModifiers = new List<StatModifier>();

        statModifiers[0] = null;
        statModifiers.Add(new StatModifier());

    }
}
