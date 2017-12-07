using UnityEngine;

[CreateAssetMenu (menuName = "ModPool/ArmorModPool/ArmorModPool1")]
public class ArmorModPool1 : ArmorModPool
{
    public override void CreatePool(Equipment armor, int slotNumber)
    {
        poolOfMods.Add(new AddFlatDamageReduction((Armor)armor, "None", 0));
        poolOfMods.Add(new AddFlatDamageReduction((Armor)armor, "Armor +2", 2));
        poolOfMods.Add(new AddPercentDamageReduction((Armor)armor, "Armor +20%", 0.8f));
        poolOfMods.Add(new AddFlatDamageReduction((Armor)armor, "Armor +4", 4));
        poolOfMods.Add(new AddPercentDamageReduction((Armor)armor, "Armor +33%", 0.67f));

        this.slotNumber = slotNumber;
        currentMod = poolOfMods[0];
    }
}