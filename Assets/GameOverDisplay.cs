using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverDisplay : MonoBehaviour
{
    // ชื่อผู้พัฒนา
    public string developerName = "Kristy";  

    void OnGUI()
    {
        // กำหนดรูปแบบของข้อความ
        GUIStyle style = new GUIStyle();
        style.fontSize = 40;
        style.normal.textColor = Color.white;

        // แสดงข้อความ "Game Over"
        GUI.Label(new Rect(10, 10, 300, 50), "Game Over", style);

        // แสดงชื่อผู้พัฒนา
        GUI.Label(new Rect(10, 60, 300, 50), "Developed by: " + developerName, style);
    }
}

