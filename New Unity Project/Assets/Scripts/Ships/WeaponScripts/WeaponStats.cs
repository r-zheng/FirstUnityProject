using UnityEngine;


[CreateAssetMenu(menuName = "Stats/WeaponStats")]
public class WeaponStats : Stats
{
    public float baseFireCooldown;
    private float bonusFireCooldown;
    public float baseDamage;
    private float percentBonusDamage;
    private float flatBonusDamage;
    public float lifeSpan;
    public float spread;
    public float momentumInheritancePercent;

    public float BonusFireCooldown
    {
        get
        {
            return bonusFireCooldown;
        }

        set
        {
            bonusFireCooldown = value;
        }
    }

    public float PercentBonusDamage
    {
        get
        {
            return percentBonusDamage;
        }

        set
        {
            percentBonusDamage = value;
        }
    }

    public float FlatBonusDamage
    {
        get
        {
            return flatBonusDamage;
        }

        set
        {
            flatBonusDamage = value;
        }
    }

    public override void ClearBonuses()
    {
        BonusFireCooldown = 1.0f;
        PercentBonusDamage = 1.0f;
        FlatBonusDamage = 0f;
    }

    public float GetDamage()
    {
        return (baseDamage + FlatBonusDamage) * PercentBonusDamage;
    }

    public float GetFireCooldown()
    {
        return baseFireCooldown * BonusFireCooldown;
    }

    public float ObtainRandomSpreadAngle()
    {
        return Random.Range(-spread, spread);
    }
}