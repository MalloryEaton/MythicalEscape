using UnityEngine;
using System.Collections;

public class Door3 : MonoBehaviour
{
    private GameObject door;
    private ChangeColor colorPuzzle;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door3");
        if (GameObject.FindObjectOfType<ChangeColor>())
        {
            colorPuzzle = GameObject.FindObjectOfType<ChangeColor>();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (colorPuzzle && collider.CompareTag("Player") && colorPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (colorPuzzle && collider.CompareTag("Player") && colorPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
