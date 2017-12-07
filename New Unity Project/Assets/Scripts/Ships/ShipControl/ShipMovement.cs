using UnityEngine;

public class ShipMovement
{
    public Rigidbody2D rb;

    public ShipMovement(GameObject ShipObject)
    {
        rb = ShipObject.GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 v, float force)
    {
        v.Normalize();
        rb.AddForce(v * force);
    }

    public void FaceDirection(float angle, float turnSpeed)
    {
        rb.transform.rotation = Quaternion.RotateTowards(rb.transform.rotation, Quaternion.Euler(0f, 0f, angle), turnSpeed);
    }
}