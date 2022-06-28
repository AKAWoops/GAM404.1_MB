
public enum StatModType
{
    Flat = 100,// index 100 for flat modifiers
    PercentAdd = 200,
    PercentMult = 300,// index 300 and 200 for percentage modifers
}
// these changes match up with sprite renderer and cube renderer for eg 
public class StatModifier 
{
    public readonly float Value;
    public readonly StatModType Type;
    public readonly int Order;
    public readonly object //Source; adding of source variable
    
    // constructors below requires input of stats for three variables this requires veriables
    public StatModifier(float value, StatModType type, int order, object source)
    {
        Value = value;
        Type = type;
        Order = order;
        source = source;
    }
    // this constructor on needs input on value and type and call above contructor for values supplied from above :-)
    //dont forget to hover over enum values ot see there order in the index 
    public StatModifier(float value, StatModType type) : this (value, type, (int)type, null) { }
    public StatModifier(float value, StatModType type, int order) : this(value, type, order, null) { }
    public StatModifier(float value, StatModType type object source) : this(value, type, (int)type, source) { }

}
