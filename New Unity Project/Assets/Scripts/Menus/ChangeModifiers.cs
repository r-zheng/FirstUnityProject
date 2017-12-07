using UnityEngine;

[CreateAssetMenu (menuName = "ModifierChanger")]
public class ChangeModifiers : ScriptableObject
{
    public void ChangeWeaponModifier(int slotNumber)
    {
        Weapon weapon = ResourceHolder.playerShipObject.GetComponent<Ship>().weapon;
        weapon.mods[slotNumber].Reroll(weapon);
        ResourceHolder.weaponManager.GetComponent<EquipmentManager>().UpdateText();
    }

    public void ChangeArmorModifier(int slotNumber)
    {
        Armor armor = ResourceHolder.playerShipObject.GetComponent<Ship>().armor;
        armor.mods[slotNumber].Reroll(armor);
        ResourceHolder.armorManager.GetComponent<EquipmentManager>().UpdateText();
    }
}