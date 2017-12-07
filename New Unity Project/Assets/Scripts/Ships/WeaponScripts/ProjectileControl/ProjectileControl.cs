using UnityEngine;

public abstract class ProjectileControl : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected float lifeSpan;
    protected float timeAlive = 0;
    public float scaledForce;
    protected float damage;
    public int opposingLayer;
    protected GameObject originShip;

    public virtual void Go(bool isFriendly, GameObject shipObject, Vector2 shipVelocity, WeaponStats stats)
    {
        SetProperties();
        lifeSpan = stats.lifeSpan;
        rb = transform.GetComponent<Rigidbody2D>();
        damage = stats.baseDamage;
        Vector2 scaledVector2 = transform.up;
        scaledVector2.Normalize();
        rb.velocity = shipVelocity * stats.momentumInheritancePercent;
        rb.AddForce(scaledVector2 * scaledForce, ForceMode2D.Impulse);
        originShip = shipObject;
    }

    public virtual void FixedUpdate()
    {
        timeAlive += Time.fixedDeltaTime;
        if (timeAlive > lifeSpan)
        {
            Destroy(gameObject);
        }
    }

    public abstract void SetProperties();

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == opposingLayer)
        {
            Ship shipScript = other.gameObject.GetComponent<Ship>();
            shipScript.TakeDamage(damage, originShip);
            if (((ArmorStats)shipScript.armor.stats).Shields <= 0)
            {
                shipScript.BlowUp();
            }
        }
        Destroy(gameObject);
    }

}
