using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool hasKey = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void WinGame()
    {
        Debug.Log("You Win!");
        // ตัวอย่าง: โหลดฉาก "WinScene" หรือโชว์ UI ชนะ
        // SceneManager.LoadScene("WinScene");

        // หรือหยุดเกมพร้อมแสดงข้อความ
        Time.timeScale = 0f;
        // แสดง UI ชนะเกมก็ได้ (ถ้ามี)
    }
}