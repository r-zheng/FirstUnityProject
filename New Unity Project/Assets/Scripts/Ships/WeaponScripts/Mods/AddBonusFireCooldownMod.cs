public class AddBonusFireCooldownMod : WeaponModifier
{
    public AddBonusFireCooldownMod(Weapon weapon, string name, float number) : base(weapon, name, number)
    {

    }

    public override void ModifyEquipment(Equipment weapon)
    {
        ((WeaponStats)weapon.stats).BonusFireCooldown *= number;
    }
}
