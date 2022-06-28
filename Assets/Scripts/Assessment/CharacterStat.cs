using System;
using System.Collections.Generic;

public class CharacterStat 
{
    public float BaseValue;

    public float Value
    {
        get
        {
            if (isDirty)
            {
                _value = CalculateFinalValue();
                isDirty = false;
            }
            return _value;
        }
    }

    private bool isDirty = true;
    private float _value;

    private readonly List<StatModifier> statModifiers;

    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }
    /*
    void someFunc()
    {
        statModifiers = null;
        statModifiers = new List<StatModifier>();

        statModifiers[0] = null;
        statModifiers.Add(new StatModifier());
    */
    public void AddModifier(StatModifier mod)
    {
        // is diurty added and set to truwe so we know modifiers have been added
        isDirty = true;
        statModifiers.Add(mod);
    }

    public bool RemoveModifier(StatModifier mod)
    {
        return statModifiers.Remove(mod);
    }

    private float CalculateFinalValue()
    {
        // isdiurty added to let you know a modifier has been added same as above 
        // no flat modifiers can be added 
        isDirty = true;
        float finalValue = BaseValue;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            // this below line and if statement is to help with adealing with each type in a different way :-)
            StatModifier mod = statModifiers[i];
            // if it a flat modifier we dow what we are already doing
            if (mod.Type == StatModType.Flat)
            {
            finalValue += mod.Value;
            }//but if its a percentage modifier calculaton in a different is needed
            else if (mod.Type == StatModType.Percent)
            {// increases by 10% moifier +10% value in code = 0.1 value will equal 0.1:-) 1.1 = 110% with 0.1 value
                finalValue *= 1 + mod.Value;
            }
        }
        // 12.0001f != 12f
        return (float)Math.Round(finalValue, 4);
    }
}
