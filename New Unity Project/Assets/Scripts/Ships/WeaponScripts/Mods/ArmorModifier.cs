public abstract class ArmorModifier : Modifiers
{
    public ArmorModifier(Armor armor, string name, float number)
    {
        this.name = name;
        equipment = armor;
        this.number = number;
    }
}