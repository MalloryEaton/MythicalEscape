using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour 
{
    public Color[] colors;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    private float xPos;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    void OnMouseUp()
    {
        xPos = transform.localPosition.x;
        if(xPos == cube1.transform.position.x)
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

        checkIsCorrect();
    }

    void checkIsCorrect()
    {
        //if (cube1IsCorrect && cube2IsCorrect && cube3IsCorrect)
        //{
         //   Debug.Log("You remembered the colors :)");
            //return true;
       // }
        //return false;
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
