using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MTB.ChracterStats
{

[Serializable]
public class CharacterStat 
{
    public float BaseValue;

    public virtual float Value
    {
        get
        {
            if (isDirty || BaseValue != lastBaseValue)
            {
                lastbaseValue = BaseValue;
                _value = CalculateFinalValue();
                isDirty = false;
            }
            return _value;
        }
    }

    protected bool isDirty = true;
    protected float _value;
    protected float lastbaseValue = float.MinValue;

    protected readonly List<StatModifier> statModifiers;
    public readonly ReadOnlyCollection<StatModifier> StatModifiers;//dont change modidifiers after it has been anitially set

    public CharacterStat()
    {
        statModifiers = new List<StatModifier>();
        StatModifiers = statModifiers.AsReadOnly();
    }

    public CharacterStat(float baseValue) : this()
    {
        BaseValue = baseValue;
        //statModifiers = new List<StatModifier>();
        //StatModifiers = statModifiers.AsReadOnly();
    }
    /*
    void someFunc()
    {
        statModifiers = null;
        statModifiers = new List<StatModifier>();

        statModifiers[0] = null;
        statModifiers.Add(new StatModifier());
    */
    public virtual void AddModifier(StatModifier mod)
    {
        // is diurty added and set to truwe so we know modifiers have been added
        isDirty = true;
        statModifiers.Add(mod);
        // calls in order with Sort comparemodifier
        statModifiers.Sort(CompareModifierOrder);
    }
    public virtual bool RemoveModifier(StatModifier mod)
    {
        //isDirty = true;
        if (statModifiers.Remove(mod))
        {
            isDirty = true;
            return true;
        }
        return false;
    }

    public virtual bool RemoveAllModifiersFromSource(object source)
    {//traverse list form end to first to remove stats from source
        bool didRemove = false;
        
        for (int i = statModifiers.Count -1; i >= 0; i--)
        {
            if (statModifiers[i].Source == source)
            {
                isDirty = true;
                didRemove = true;
                statModifiers.RemoveAt(i); // remove in last position if was other way around it would be inefficient so removal in reverse is what i meant to say 
            }         
        }
        return didRemove;
    }

    // oder call for statModifier
    protected virtual int CompareModifierOrder(StatModifier a, StatModifier b)
    {
        if (a.Order < b.Order)
            return -1;
        else if (a.Order > b.Order)
            return 1;
        return 0; //if (a.Order == b.Order)
    }
    public virtual bool RemoveModifier(StatModifier mod)
    {
        return statModifiers.Remove(mod);
    }

    protected virtual float CalculateFinalValue()
    {
        // isdiurty added to let you know a modifier has been added same as above 
        // no flat modifiers can be added 
       // isDirty = true;
        float finalValue = BaseValue;
        float sumPercentAdd = 0;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            // this below line and if statement is to help with adealing with each type in a different way :-)
            StatModifier mod = statModifiers[i];
            // if it a flat modifier we dow what we are already doing
            if (mod.Type == StatModType.Flat)
            {
            finalValue += mod.Value;
            }//but if its a percentage modifier calculaton in a different is needed
            else if (mod.Type == StatModType.PercentAdd)
            {
                sumPercentAdd += mod.Value;

                if (i + 1 >= statModifiers.Count || statModifiers[i + 1].Type != StatModType.PercentAdd)
                {
                    finalValue *= 1 + sumPercentAdd;
                    sumPercentAdd = 0;
                }
            }
            else if (mod.Type == StatModType.PercentMult)
            {// increases by 10% moifier +10% value in code = 0.1 value will equal 0.1:-) 1.1 = 110% with 0.1 value
                finalValue *= 1 + mod.Value;// 10 * 1.1 + 20 = 31x vs (10 +20) * 1.1 = 33 correect answer fun math problem that was
            }
        }
        // 12.0001f != 12f
        return (float)Math.Round(finalValue, 4);
    }
}
