using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    void OnGUI()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Escape)
        {
            Application.Quit();
        }
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
        {
            Application.LoadLevel("MainScene");
        }
    }
}
