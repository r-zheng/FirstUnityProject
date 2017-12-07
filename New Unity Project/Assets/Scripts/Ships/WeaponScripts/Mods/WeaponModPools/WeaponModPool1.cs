using UnityEngine;

[CreateAssetMenu (menuName = "ModPool/WeaponModPool/WeaponModPool1")]
public class WeaponModPool1 : WeaponModPool
{
    public override void CreatePool(Equipment weapon, int slotNumber)
    {
        poolOfMods.Add(new AddFlatDamageMod((Weapon)weapon, "None", 0));
        poolOfMods.Add(new AddPercentDamageMod((Weapon)weapon, "Atk +20%", 1.2f));
        poolOfMods.Add(new AddPercentDamageMod((Weapon)weapon, "Atk +33%", 1.33f));
        poolOfMods.Add(new AddFlatDamageMod((Weapon)weapon, "Atk +10", 10));
        poolOfMods.Add(new AddFlatDamageMod((Weapon)weapon, "Atk +15", 15));
        poolOfMods.Add(new AddBonusFireCooldownMod((Weapon)weapon, "FireCooldown -33%", 0.67f));
        poolOfMods.Add(new AddBonusFireCooldownMod((Weapon)weapon, "FireCooldown -40%", 0.60f));

        this.slotNumber = slotNumber;
        currentMod = poolOfMods[0];
    }
}
