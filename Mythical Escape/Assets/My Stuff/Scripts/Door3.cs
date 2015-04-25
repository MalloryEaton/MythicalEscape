using UnityEngine;
using System.Collections;

public class Door3 : MonoBehaviour
{
    private Booleans bools;
    private GameObject door;

    void Awake()
    {
        bools = Component.FindObjectOfType<Booleans>();
        door = GameObject.FindGameObjectWithTag("SF_Door3");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (bools.door3())
        {
            door.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (bools.door3())
        {
            door.GetComponent<Animation>().Play("close");
        }
    }
}
