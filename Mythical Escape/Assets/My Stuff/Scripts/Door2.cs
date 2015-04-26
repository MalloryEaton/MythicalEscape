using UnityEngine;
using System.Collections;

public class Door2 : MonoBehaviour
{
    private GameObject door;
    private SwitchPuzzle switchesPuzzle;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door2");
        switchesPuzzle = GameObject.FindObjectOfType<SwitchPuzzle>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && switchesPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player") && switchesPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
