using UnityEngine;
using System.Collections;

public class Booleans : MonoBehaviour
{
    public static bool door1IsSolved = false;
    public static bool door2IsSolved = false;
    public static bool door3IsSolved = false;

    void Awake()
    {
        if (!door1IsSolved)
        {
            door1IsSolved = false;
        }
        if (!door2IsSolved)
        {
            door2IsSolved = false;
        }
        if (!door3IsSolved)
        {
            door3IsSolved = false;
        }
    }

    public void toggleDoor1()
    {
        door1IsSolved = true;
    }
    public void toggleDoor2()
    {
        door2IsSolved = true;
    }
    public void toggleDoor3()
    {
        door3IsSolved = true;
    }

    public bool door1()
    {
        if(door1IsSolved)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool door2()
    {
        if (door2IsSolved)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool door3()
    {
        if (door3IsSolved)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
