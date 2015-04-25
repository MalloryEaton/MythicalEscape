using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour 
{
    private Booleans bools;
    private GameObject door;

    void Awake()
    {
        bools = Component.FindObjectOfType<Booleans>();
        door = GameObject.FindGameObjectWithTag("SF_Door1");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (bools.door1())
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (bools.door1())
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
