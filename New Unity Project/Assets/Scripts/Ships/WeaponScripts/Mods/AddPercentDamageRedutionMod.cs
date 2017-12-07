public class AddPercentDamageReduction : ArmorModifier
{
    public AddPercentDamageReduction(Armor armor, string name, float number) : base(armor, name, number)
    {

    }

    public override void ModifyEquipment(Equipment armor)
    {
        ((ArmorStats)armor.stats).PercentDamageReduction *= number;
    }
}
