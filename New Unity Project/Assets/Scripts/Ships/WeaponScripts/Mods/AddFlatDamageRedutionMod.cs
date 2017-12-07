public class AddFlatDamageReduction : ArmorModifier
{
    public AddFlatDamageReduction(Armor armor, string name, float number) : base(armor, name, number)
    {

    }

    public override void ModifyEquipment(Equipment armor)
    {
        ((ArmorStats)armor.stats).FlatDamageReduction += number;
    }
}
