using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;       // ตัวละครที่กล้องจะตาม
    public Vector3 offset;         // ความห่างของกล้องจากตัวละคร
    public float smoothSpeed = 5f; // ความเร็วในการตามแบบ Smooth

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}