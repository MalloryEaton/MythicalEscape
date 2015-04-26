using UnityEngine;
using System.Collections;

public class SwitchPuzzle : MonoBehaviour 
{
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject switch4;
    public GameObject switch5;

    public GameObject switch1CorrectPos;
    public GameObject switch2CorrectPos;
    public GameObject switch3CorrectPos;
    public GameObject switch4CorrectPos;
    public GameObject switch5CorrectPos;

    float xPos;
    float yPos;
    float zPos;
    float yUP = 0.28f;
    float yDown = 0.25f;

    private bool isUp1 = true;
    private bool isUp2 = true;
    private bool isUp3 = true;
    private bool isUp4 = true;
    private bool isUp5 = true;

    public static bool puzzle2IsSolved;

    private GameObject puzzle2;

    void Awake()
    {
        puzzle2 = GameObject.Find("Switch_Puzzle");
        DontDestroyOnLoad(puzzle2);
        if (!puzzle2IsSolved)
        {
            puzzle2IsSolved = false;
        }
    }

    public bool solved()
    {
        return puzzle2IsSolved;
    }

    private bool isCorrect()
    {
        if(switch1.transform.position != switch1CorrectPos.transform.position)
        {
            return false;
        }
        if (switch2.transform.position != switch2CorrectPos.transform.position)
        {
            return false;
        }
        if (switch3.transform.position != switch3CorrectPos.transform.position)
        {
            return false;
        }
        if (switch4.transform.position != switch4CorrectPos.transform.position)
        {
            return false;
        }
        if (switch5.transform.position != switch5CorrectPos.transform.position)
        {
            return false;
        }
        return true;
    }

    void OnMouseUp()
    {
        if (!isCorrect())
        {
            xPos = transform.localPosition.x;
            yPos = 26;
            zPos = transform.localPosition.z;
            if (xPos == switch1.transform.position.x)
            {
                isUp1 = !isUp1;
                if (isUp1)
                {
                    switch1.transform.position = new Vector3(xPos, yPos - yDown, zPos);
                }
                else
                {
                    switch1.transform.position = new Vector3(xPos, yPos + yUP, zPos);
                }
            }
            else if (xPos == switch2.transform.position.x)
            {
                isUp2 = !isUp2;
                if (isUp2)
                {
                    switch2.transform.position = new Vector3(xPos, yPos - yDown, zPos);
                }
                else
                {
                    switch2.transform.position = new Vector3(xPos, yPos + yUP, zPos);
                }
            }
            else if (xPos == switch3.transform.position.x)
            {
                isUp3 = !isUp3;
                if (isUp3)
                {
                    switch3.transform.position = new Vector3(xPos, yPos - yDown, zPos);
                }
                else
                {
                    switch3.transform.position = new Vector3(xPos, yPos + yUP, zPos);
                }
            }
            else if (xPos == switch4.transform.position.x)
            {
                isUp4 = !isUp4;
                if (isUp4)
                {
                    switch4.transform.position = new Vector3(xPos, yPos - yDown, zPos);
                }
                else
                {
                    switch4.transform.position = new Vector3(xPos, yPos + yUP, zPos);
                }
            }
            else if (xPos == switch5.transform.position.x)
            {
                isUp5 = !isUp5;
                if (isUp5)
                {
                    switch5.transform.position = new Vector3(xPos, yPos - yDown, zPos);
                }
                else
                {
                    switch5.transform.position = new Vector3(xPos, yPos + yUP, zPos);
                }
            }

            if(isCorrect())
            {
                puzzle2IsSolved = true;
                Application.LoadLevel("MainScene");
            }
        }
    }
}
