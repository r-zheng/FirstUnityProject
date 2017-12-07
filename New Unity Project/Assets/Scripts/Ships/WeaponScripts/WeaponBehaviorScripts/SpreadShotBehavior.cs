using UnityEngine;

[CreateAssetMenu(menuName = "WeaponBehavior/SpreadShotWeapon")]
public class SpreadShotBehavior : PlayerWeaponBehavior
{
    public int projectilesPerFire;
    public float angleBetweenRounds;
    
    protected override void Shoot(Vector3 firePointPos)
    {
        for (int round = 0; round < projectilesPerFire ; round++)
        {
            float spreadAngle = stats.ObtainRandomSpreadAngle() - (angleBetweenRounds * round - angleBetweenRounds * (projectilesPerFire - 1) / 2);
            GameObject shotProjectile = Instantiate(projectile, firePointPos, Quaternion.Euler(0, 0, shipObject.transform.eulerAngles.z + spreadAngle));
            shotProjectile.GetComponent<ProjectileControl>().Go(isFriendly, shipObject, shipObject.GetComponent<Rigidbody2D>().velocity, stats);
        }
    }
}