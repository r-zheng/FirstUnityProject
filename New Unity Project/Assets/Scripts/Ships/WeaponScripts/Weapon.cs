using UnityEngine;

[CreateAssetMenu(menuName = "Weapon/Weapon")]
public class Weapon : Equipment
{
    public WeaponBehavior behavior;
    public GameObject projectile;

    public void CreateWeapon(GameObject shipObject)
    {
        stats.ClearBonuses();
        this.shipObject = shipObject;
        behavior.SetFields(shipObject, (WeaponStats)stats, isFriendly, projectile);
    }
}