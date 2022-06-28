
public enum StatModType
{
    Flat,
    Percent,
}
public class StatModifier 
{
    public readonly float Value;
    public readonly StatModType Type;


    public StatModifier(float value, StatModType type)
    {
        Value = value;
        Type = type;
    }
}
