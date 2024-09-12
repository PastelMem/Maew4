using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    // public Text gameOverText;  // ลาก Text UI สำหรับ "Game Over" มาที่นี่ใน Inspector
    // public Text developerText;  // ลาก Text UI สำหรับชื่อผู้พัฒนามาที่นี่ใน Inspector

    private bool isGameOver = false;

    void Start()
    {
        // ซ่อนข้อความในตอนเริ่มต้น
        // gameOverText.gameObject.SetActive(false);
        // developerText.gameObject.SetActive(false);
    }

    void Update()
    {
        // if (isGameOver)
        // {
        //     // แสดงข้อความเมื่อ isGameOver เป็น true
        //     gameOverText.gameObject.SetActive(true);
        //     developerText.gameObject.SetActive(true);
        // }
    }

    // เรียกฟังก์ชันนี้เมื่อเกมจบ
    public void TriggerGameOver()
    {
        Debug.Log("Game Over Triggered!");  // ตรวจสอบว่าฟังก์ชันถูกเรียกหรือไม่
        isGameOver = true;
    }
}
