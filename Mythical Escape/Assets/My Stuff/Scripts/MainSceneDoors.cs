using UnityEngine;
using System.Collections;

public class MainSceneDoors : MonoBehaviour 
{
    private static bool door1IsSolved;
    private static bool door2IsSolved;
    private static bool door3IsSolved;

    void Awake()
    {
        door1IsSolved = false;
        door2IsSolved = false;
        door3IsSolved = false;
    }
}
