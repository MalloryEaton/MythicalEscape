using UnityEngine;
using System.Collections;

public class Door3 : MonoBehaviour
{
    private GameObject door;
    private GameObject colorPuzzle;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door3");
        colorPuzzle = GameObject.FindGameObjectWithTag("ColorPuzzle");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (colorPuzzle && collider.CompareTag("Player"))
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (colorPuzzle && collider.CompareTag("Player"))
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
