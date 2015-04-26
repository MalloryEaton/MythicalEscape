using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour 
{
    private GameObject door;
    private SlidingPuzzle slidingPuzzle;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door1");
        slidingPuzzle = GameObject.FindObjectOfType<SlidingPuzzle>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && slidingPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player") && slidingPuzzle.solved())
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
