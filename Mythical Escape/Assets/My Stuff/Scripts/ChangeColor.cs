using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour 
{
    public Color[] colors;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    private float xPos;

    private Renderer rend;

    private CheckColorPuzzle ccp;

    private Booleans bools;

    //private GameObject elMusico;

    void Start()
    {
        //elMusico = GameObject.Find("Music");
        ccp = Component.FindObjectOfType<CheckColorPuzzle>();
        bools = Component.FindObjectOfType<Booleans>();
        rend = GetComponent<Renderer>();
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    void OnMouseUp()
    {
        if (!ccp.checkColors())
        {
            xPos = transform.localPosition.x;
            if (xPos == cube1.transform.position.x)
            {
                changeColor();
            }
            else if (xPos == cube2.transform.position.x)
            {
                changeColor();
            }
            else if (xPos == cube3.transform.position.x)
            {
                changeColor();
            }

            if (ccp.checkColors())
            {
                bools.toggleDoor3();
                Application.LoadLevel("MainScene");
            }
        }
    }

    void changeColor()
    {
        if (rend.material.color == colors[0])
        {
            rend.material.color = colors[1];
        }
        else if (rend.material.color == colors[1])
        {
            rend.material.color = colors[2];
        }
        else if (rend.material.color == colors[2])
        {
            rend.material.color = colors[3];
        }
        else if (rend.material.color == colors[3])
        {
            rend.material.color = colors[4];
        }
        else if (rend.material.color == colors[4])
        {
            rend.material.color = colors[5];
        }
        else if (rend.material.color == colors[5])
        {
            rend.material.color = colors[0];
        }
    }
}
