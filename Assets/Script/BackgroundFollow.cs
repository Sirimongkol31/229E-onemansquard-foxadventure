using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 2f;
    public Vector3 offset;

    void Update()
    {
        if (player != null)
        {
            // ค่อยๆ ขยับตำแหน่งของ background ไปหาตำแหน่ง player แบบ smooth
            Vector3 targetPos = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
        }
    }
}