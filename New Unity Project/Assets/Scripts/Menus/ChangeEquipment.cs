using UnityEngine;

[CreateAssetMenu (menuName = "EquipmentChanger")]
public class ChangeEquipment : ScriptableObject
{
    public void Change(Weapon weapon)
    {
        if(ResourceHolder.score.SpendCurrency(5))
        {
            ResourceHolder.playerShipObject.GetComponent<PlayerShip>().ChangeEquipment(weapon);
            ResourceHolder.weaponManager.GetComponent<EquipmentManager>().equipment = weapon;
            weapon.CreateWeapon(ResourceHolder.playerShipObject);
            CreateModPoolMods(weapon);
        }
    }

    public void Change(Armor armor)
    {
        //
    }

    public void CreateModPoolMods(Equipment equipment)
    {
        if (equipment.mods[0].poolOfMods.Count < 1)
        {
            equipment.CreateMods(equipment);
        }
        equipment.Modify();
    }
}