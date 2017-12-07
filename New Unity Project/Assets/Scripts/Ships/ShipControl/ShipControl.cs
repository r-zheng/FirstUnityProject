using UnityEngine;

public abstract class ShipControl
{
    public Rigidbody2D rb;
    public float forceScaling;
    public float dragAmount;
    public float turnSpeed;
    public int rotationOffset;
    public ShipMovement movementControls;
    public GameObject shipObject;

    public ShipControl(GameObject shipObject)
    {
        this.shipObject = shipObject;
        rb = shipObject.GetComponent<Rigidbody2D>();
        forceScaling = 10f;
        dragAmount = 1f;
        rb.drag = dragAmount;
        turnSpeed = 10f;
        rotationOffset = 270;

        movementControls = new ShipMovement(shipObject.transform.gameObject);
    }

    public void DoControls()
    {
        Move();
        FaceDirection();
    }

    public abstract void Move();

    public abstract void FaceDirection();
}
