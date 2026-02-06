using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 8f;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}
