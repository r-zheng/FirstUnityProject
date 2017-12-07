using UnityEngine;

public abstract class WeaponBehavior : ScriptableObject
{
    protected float timeToFire;
    protected WeaponStats stats;
    protected GameObject projectile;
    protected GameObject shipObject;
    protected float lifeSpan;
    protected bool isFriendly;  
    public float rotationOffset = 270;

    public void SetFields(GameObject shipObject, WeaponStats stats, bool isFriendly, GameObject projectile)
    {
        timeToFire = 0;
        this.shipObject = shipObject;
        this.stats = stats;
        this.isFriendly = isFriendly;
        this.projectile = projectile;
        lifeSpan = stats.lifeSpan;
    }   

    public abstract void FireUpdate(Vector3 firePointPos);

    protected virtual void Shoot(Vector3 firePointPos)
    {
        float spreadAngle = stats.ObtainRandomSpreadAngle();
        GameObject shotProjectile = Instantiate(projectile, firePointPos, Quaternion.Euler(0, 0, shipObject.transform.eulerAngles.z + spreadAngle));
        shotProjectile.GetComponent<ProjectileControl>().Go(isFriendly, shipObject, shipObject.GetComponent<Rigidbody2D>().velocity, stats);
    }
}
