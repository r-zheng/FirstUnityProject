using UnityEngine;

public class EnemyControls : ShipControl
{
    public GameObject player = GameObject.Find("Player");
    public Vector2 difference;

    public EnemyControls(GameObject shipObject) : base(shipObject)
    {
        rotationOffset = 90;
    }

    override public void Move()
    {
        difference = (shipObject.transform.position - player.transform.position);
        if((shipObject.transform.position - player.transform.position).magnitude > 5)
        {
            movementControls.Move(-difference, forceScaling);
        }
        else
        {
            movementControls.Move(Quaternion.Euler(0, 0, -90) * difference, forceScaling);
        }
    }

    override public void FaceDirection()
    {
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg + rotationOffset;
        movementControls.FaceDirection(angle, turnSpeed);
    }
}
