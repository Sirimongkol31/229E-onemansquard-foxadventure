using UnityEngine;

using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Optional Sound Effect")]
    public AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // เพิ่มคะแนนหรือจำนวนเหรียญ (จะอธิบายต่อ)
            CoinManager.instance.AddCoin(1);

            // เล่นเสียงถ้ามี
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            // ทำลายเหรียญ
            Destroy(gameObject);
        }
    }
}