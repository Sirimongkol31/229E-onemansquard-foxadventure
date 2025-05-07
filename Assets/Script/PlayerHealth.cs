using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Text hpText; // อ้างถึง Text UI

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHPText();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Player HP: " + currentHealth);

        UpdateHPText();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHPText()
    {
        if (hpText != null)
        {
            hpText.text = "HP: " + currentHealth.ToString();
        }
    }

    void Die()
    {
        Debug.Log("Player Died");

        // โหลดฉาก GameOver (ต้องมีใน Build Settings ด้วย)
        SceneManager.LoadScene("GameOver");
    }
}