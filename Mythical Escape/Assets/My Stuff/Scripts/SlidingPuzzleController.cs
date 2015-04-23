using UnityEngine;
using System.Collections;

public class SlidingPuzzleController : MonoBehaviour
{
    public GameObject slot;
    float xtemp;
    float ytemp;
    private TileScript tiles;
    public GameObject[] TileArray;
    public Transform transWin;
    private Vector3 v3WinPos;

    void Awake()
    {
        v3WinPos = transWin.position;
        tiles = Component.FindObjectOfType<TileScript>();
        for(int i = 0; i < 15; i++)
        {
            TileArray[i] = GameObject.Find("Tile " + i);
        }
    }

    void OnMouseUp()
    {
        //If the Distance between tiles is 1 then swap tiles
        if (Vector3.Distance(transform.localPosition, slot.transform.position) == 1)
        {
            xtemp = transform.localPosition.x;
            ytemp = transform.localPosition.y;
            transform.localPosition = new Vector3(slot.transform.position.x, slot.transform.position.y, 0);
            slot.transform.position = new Vector3(xtemp, ytemp, 0);
        }

        if(HasWon())
        {
            Debug.Log("Solved");
            GameObject.Find("Text").GetComponent<GUIText>().text = "You Won!";
        }
    }

    bool HasWon()
    {
        for (int i = 0; i < 15; i++)
        {
            if (TileArray[i].transform.position == tiles.winPos())
            {
                return false;
            }
        }
        return true;
    }

    public bool IsWinPos()
    {
        return (transform.position - v3WinPos).magnitude < 0.01;
    }
}
