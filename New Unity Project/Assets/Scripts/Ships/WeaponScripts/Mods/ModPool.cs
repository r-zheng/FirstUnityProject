using UnityEngine;
using System.Collections.Generic;

public abstract class ModPool : ScriptableObject
{
    public Modifiers currentMod;
    public List<Modifiers> poolOfMods = new List<Modifiers>();
    public int slotNumber;

    public void Reroll(Equipment equipment)
    {
        if(ResourceHolder.score.SpendCurrency(2))
        {
            int randIndex = Random.Range(1, poolOfMods.Count);
            while (poolOfMods[randIndex] == currentMod)
            {
                randIndex = Random.Range(1, poolOfMods.Count);
            }
            currentMod = poolOfMods[randIndex];
            equipment.Modify();
        }
    }

    public abstract void CreatePool(Equipment equipment, int slotNumber);
}
