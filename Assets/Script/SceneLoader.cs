using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // ตั้งชื่อซีนใน Inspector
    public string sceneName;

    // ฟังก์ชันนี้จะถูกเรียกจากปุ่ม
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}