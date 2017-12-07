public class AddPercentDamageMod : WeaponModifier
{
    public AddPercentDamageMod(Weapon weapon, string name, float number) : base(weapon, name, number)
    {

    }

    public override void ModifyEquipment(Equipment weapon)
    {
        ((WeaponStats)weapon.stats).PercentBonusDamage *= number;
    }
}
