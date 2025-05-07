using UnityEngine;

public class Door : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && GameManager.instance.hasKey)
        {
            other.gameObject.SetActive(false);
            GameManager.instance.WinGame();
        }
    }
}