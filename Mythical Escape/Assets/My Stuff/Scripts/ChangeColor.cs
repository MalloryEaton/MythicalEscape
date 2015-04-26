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

    public static bool puzzle3IsSolved;

    private GameObject puzzle3;

    void Awake()
    {
        puzzle3 = GameObject.Find("ColorPuzzle");
        DontDestroyOnLoad(puzzle3);
        if (!puzzle3IsSolved)
        {
            puzzle3IsSolved = false;
        }
    }

    void Start()
    {
        ccp = Component.FindObjectOfType<CheckColorPuzzle>();
        rend = GetComponent<Renderer>();
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    public bool solved()
    {
        return puzzle3IsSolved;
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
                puzzle3IsSolved = true;
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
