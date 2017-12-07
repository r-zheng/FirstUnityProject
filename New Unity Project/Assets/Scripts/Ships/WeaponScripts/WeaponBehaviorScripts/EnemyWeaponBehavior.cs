using UnityEngine;

[CreateAssetMenu (menuName = "WeaponBehavior/EnemyWeapon")]
public class EnemyWeaponBehavior : WeaponBehavior
{
    public override void FireUpdate(Vector3 firePointPos)
    {
        if (Time.time > timeToFire)
        {
            timeToFire = Time.time + stats.GetFireCooldown();
            Shoot(firePointPos);
        }
    }
}
