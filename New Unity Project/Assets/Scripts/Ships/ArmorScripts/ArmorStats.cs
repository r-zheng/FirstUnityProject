using UnityEngine;

[CreateAssetMenu(menuName = "Stats/ArmorStats")]
public class ArmorStats : Stats
{
    public float maxShields;
    private float shields;
    private float percentDamageReduction;
    private float flatDamageReduction;

    public float Shields
    {
        get
        {
            return shields;
        }

        set
        {
            shields = value;
        }
    }

    public float PercentDamageReduction
    {
        get
        {
            return percentDamageReduction;
        }

        set
        {
            percentDamageReduction = value;
        }
    }

    public float FlatDamageReduction
    {
        get
        {
            return flatDamageReduction;
        }

        set
        {
            flatDamageReduction = value;
        }
    }

    public float DamageToTake(float unMitigatedDamage)
    {
        float damageToTake = unMitigatedDamage * PercentDamageReduction - FlatDamageReduction;
        if (damageToTake < 1f)
            return 1f;
        else
            return damageToTake;
    }

    public float TakeDamage(float unMitigatedDamage)
    {
        Debug.Log(DamageToTake(unMitigatedDamage));
        Shields -= DamageToTake(unMitigatedDamage);
        return Shields;
    }

    public override void ClearBonuses()
    {
        PercentDamageReduction = 1.0f;
        FlatDamageReduction = 0f;
    }
}