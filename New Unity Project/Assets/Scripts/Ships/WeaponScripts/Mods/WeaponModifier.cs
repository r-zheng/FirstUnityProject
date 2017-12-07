public abstract class WeaponModifier : Modifiers
{
    public WeaponModifier(Weapon weapon, string name, float number)
    {
        this.name = name;
        equipment = weapon;
        this.number = number;
    }
}