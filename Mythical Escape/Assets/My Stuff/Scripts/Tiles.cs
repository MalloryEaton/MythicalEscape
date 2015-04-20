using UnityEngine;
using System.Collections;

public class Tiles : MonoBehaviour 
{
    private Component[] tiles;
 
    void Awake () 
    {
        tiles = GetComponentsInChildren<Tiles>();
    }
 
    void Update()
    {
        Debug.Log("Update");
        if(HasWon())
        {
            GameObject.Find("Text").GetComponent<GUIText>().text = "You Won!";
        }
    }

    public bool HasWon()
    {
        foreach(TileScript t in tiles)
        {
            if (!t.IsHome())
            {
                return false;
            }
        }
        return true;
    }
}
