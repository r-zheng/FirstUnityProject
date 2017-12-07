using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : ScriptableObject
{
    protected GameObject shipObject;
    public string equipmentName;
    public List<ModPool> mods = new List<ModPool>();
    public Stats stats;
    public bool isFriendly;

    public void CreateMods(Equipment equipment)
    {
        for(int i = 0; i < 5; i++)
        {
            mods[i].CreatePool(equipment, i);
        }
    }

    public void Modify()
    {
        stats.ClearBonuses();
        foreach (ModPool mods in mods)
        {
            mods.currentMod.ModifyEquipment(this);
        }
    }
}
