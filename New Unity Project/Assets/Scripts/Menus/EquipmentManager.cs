using UnityEngine;
using UnityEngine.UI;

public class EquipmentManager : PopupControl
{
    public Button[] mods;
    public Equipment equipment;

    public override void UpdateText()
    {
        panel.GetComponentInChildren<Text>().text = equipment.equipmentName;
        for (int i = 0; i < mods.Length; i++)
        {
            mods[i].GetComponentInChildren<Text>().text = 
                equipment.mods[i].currentMod.name;
        }
    }

    public override void Setup()
    {
        mods = gameObject.GetComponentsInChildren<Button>();
    }
}