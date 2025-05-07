using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // บอก GameManager ว่าเก็บกุญแจแล้ว
            GameManager.instance.hasKey = true;

            // ลบกุญแจออกจากฉาก
            Destroy(gameObject);
        }
    }
}