using UnityEngine;

public class LaserGuidedMissileProjectileControl : ProjectileControl
{
    public float turnSpeed;
    public float velocity;
    public int offset;

    public override void SetProperties()
    {
        
    }

    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    public override void FixedUpdate()
    {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, angle + offset), turnSpeed);
        rb.velocity = transform.up.normalized * velocity;
        base.FixedUpdate();
    }
}