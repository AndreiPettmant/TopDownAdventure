using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);
    
    [SerializeField] private float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
