using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Armor/Armor")]
public class Armor : Equipment
{
    public void CreateArmor(GameObject shipObject)
    {
        stats.ClearBonuses();
        this.shipObject = shipObject;
        ((ArmorStats)stats).Shields = ((ArmorStats)stats).maxShields;
    }

    public virtual float TakeDamage(float damage, GameObject ship)
    {
        return ((ArmorStats)stats).TakeDamage(damage);
    }
}