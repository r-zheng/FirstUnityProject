using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float dampTime = 0.01f;
    public Vector3 offset = new Vector3(0, 0, -5);
    public Vector3 velocity = Vector3.zero;

    public void Start()
    {
        target = ResourceHolder.playerShipObject.transform;
    }

    public void FixedUpdate()
    {
        Vector3 offsetTarget = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, offsetTarget, ref velocity, dampTime);
        transform.position = smoothedPosition;
    }
}