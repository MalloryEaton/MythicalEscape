using UnityEngine;
using System.Collections;

public class Puzzle : MonoBehaviour
{
    private Component[] tiles;

    void Awake()
    {
        tiles = GetComponentsInChildren<Puzzle>();
    }

    public bool HasWon()
    {
        foreach (TileScript t in tiles)
        {
            if (!t.IsWinPos())
            {
                return false;
            }
        }
        GameObject.Find("Text").GetComponent<GUIText>().text = "You Won!";
        return true;
    }
}
