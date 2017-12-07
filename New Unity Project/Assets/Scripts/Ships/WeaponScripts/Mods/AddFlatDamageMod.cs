public class AddFlatDamageMod : WeaponModifier
{
    public AddFlatDamageMod(Weapon weapon, string name, float number) : base(weapon, name, number)
    {

    }

    public override void ModifyEquipment(Equipment weapon)
    {
        ((WeaponStats)weapon.stats).FlatBonusDamage += number;
    }
}
