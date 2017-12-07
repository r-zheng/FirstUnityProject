using UnityEngine;

public class EnemyShips : Ship
{
    public int pointsWorth;

    public void Awake()
    {
        weapon = Instantiate(ResourceHolder.enemyWeapon);
        weapon.behavior = Instantiate(ResourceHolder.enemyWeaponBehavior);
        armor = Instantiate(ResourceHolder.enemyArmor);
        armor.stats = Instantiate(ResourceHolder.enemyArmorStats);
        weapon.CreateWeapon(gameObject);
        armor.CreateArmor(gameObject);
        shipControl = new EnemyControls(gameObject);
    }

    public override void BlowUp()
    {
        ResourceHolder.score.IncreaseScore(pointsWorth);
        base.BlowUp();
    }
}