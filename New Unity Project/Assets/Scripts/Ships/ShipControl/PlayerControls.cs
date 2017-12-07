using UnityEngine;

public class PlayerControls : ShipControl
{
    public PlayerControls(GameObject shipObject) : base(shipObject)
    {

    }

    override public void Move()
    {
        Vector2 v = new Vector2(0, 0);
        if (Input.GetKey("e"))
        {
            v += Vector2.up;
        }

        if (Input.GetKey("d"))
        {
            v += Vector2.down;
        }

        if (Input.GetKey("s"))
        {
            v += Vector2.left;
        }

        if (Input.GetKey("f"))
        {
            v += Vector2.right;
        }

        movementControls.Move(v, forceScaling);
    }

    override public void FaceDirection()
    {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - shipObject.transform.position;
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg + rotationOffset;
        movementControls.FaceDirection(angle, turnSpeed);
    }
}
