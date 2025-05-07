using UnityEngine;
public class EnemyFacePlayer : MonoBehaviour
{
    public Transform player; // ตัวละครผู้เล่น

    private void Update()
    {
        Vector3 scale = transform.localScale;

        // เช็คตำแหน่งผู้เล่นเทียบกับศัตรู
        if (player.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x); // หันขวา
        }
        else
        {
            scale.x = -Mathf.Abs(scale.x); // หันซ้าย
        }

        transform.localScale = scale;
    }
}