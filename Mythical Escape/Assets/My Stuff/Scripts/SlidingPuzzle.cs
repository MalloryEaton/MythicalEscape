using UnityEngine;
using System.Collections;

public class SlidingPuzzle : MonoBehaviour
{
    public GameObject slot;
    float xtemp;
    float ytemp;
    private Tiles tiles;

    void Awake()
    {
        //instantiate
        tiles = new Tiles();
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

        if(tiles.HasWon())
        {
            Debug.Log("Solved");
        }
    }
}
