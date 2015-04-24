using UnityEngine;
using System.Collections;

public class SlidingPuzzle : MonoBehaviour
{
    public GameObject tile0;
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public GameObject tile5;
    public GameObject tile6;
    public GameObject tile7;
    public GameObject tile8;
    public GameObject tile9;
    public GameObject tile10;
    public GameObject tile11;
    public GameObject tile12;
    public GameObject tile13;
    public GameObject tile14;

    public GameObject winTile0;
    public GameObject winTile1;
    public GameObject winTile2;
    public GameObject winTile3;
    public GameObject winTile4;
    public GameObject winTile5;
    public GameObject winTile6;
    public GameObject winTile7;
    public GameObject winTile8;
    public GameObject winTile9;
    public GameObject winTile10;
    public GameObject winTile11;
    public GameObject winTile12;
    public GameObject winTile13;
    public GameObject winTile14;

    public GameObject slot;

    private bool puzzleIsWon = false;

    float xtemp;
    float ytemp;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            solvePuzzle();
            puzzleIsWon = true;
            GameObject.Find("Text").GetComponent<GUIText>().text = "You Won!";
        }
    }

    void OnMouseUp()
    {
        //If the Distance between tiles is 1 then swap tiles
        if (Vector3.Distance(transform.localPosition, slot.transform.position) == 1 && !puzzleIsWon)
        {
            xtemp = transform.localPosition.x;
            ytemp = transform.localPosition.y;
            transform.localPosition = new Vector3(slot.transform.position.x, slot.transform.position.y, 0);
            slot.transform.position = new Vector3(xtemp, ytemp, 0);
        }

        if(HasWon())
        {
            puzzleIsWon = true;
            GameObject.Find("Text").GetComponent<GUIText>().text = "You Won!";
        }
    }

    bool HasWon()
    {
        if(tile0.transform.position != winTile0.transform.position)
        {
            return false;
        }
        if (tile1.transform.position != winTile1.transform.position)
        {
            return false;
        }
        if (tile2.transform.position != winTile2.transform.position)
        {
            return false;
        }
        if (tile3.transform.position != winTile3.transform.position)
        {
            return false;
        }
        if (tile4.transform.position != winTile4.transform.position)
        {
            return false;
        }
        if (tile5.transform.position != winTile5.transform.position)
        {
            return false;
        }
        if (tile6.transform.position != winTile6.transform.position)
        {
            return false;
        }
        if (tile7.transform.position != winTile7.transform.position)
        {
            return false;
        }
        if (tile8.transform.position != winTile8.transform.position)
        {
            return false;
        }
        if (tile9.transform.position != winTile9.transform.position)
        {
            return false;
        }
        if (tile10.transform.position != winTile10.transform.position)
        {
            return false;
        }
        if (tile11.transform.position != winTile11.transform.position)
        {
            return false;
        }
        if (tile12.transform.position != winTile12.transform.position)
        {
            return false;
        }
        if (tile13.transform.position != winTile13.transform.position)
        {
            return false;
        }
        if (tile14.transform.position != winTile14.transform.position)
        {
            return false;
        }
        return true;
    }

    void solvePuzzle()
    {
        tile0.transform.position = winTile0.transform.position;
        tile1.transform.position = winTile1.transform.position;
        tile2.transform.position = winTile2.transform.position;
        tile3.transform.position = winTile3.transform.position;
        tile4.transform.position = winTile4.transform.position;
        tile5.transform.position = winTile5.transform.position;
        tile6.transform.position = winTile6.transform.position;
        tile7.transform.position = winTile7.transform.position;
        tile8.transform.position = winTile8.transform.position;
        tile9.transform.position = winTile9.transform.position;
        tile10.transform.position = winTile10.transform.position;
        tile11.transform.position = winTile11.transform.position;
        tile12.transform.position = winTile12.transform.position;
        tile13.transform.position = winTile13.transform.position;
        tile14.transform.position = winTile14.transform.position;
    }
}
