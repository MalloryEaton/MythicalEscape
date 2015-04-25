using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour 
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject door = GameObject.FindGameObjectWithTag("SF_Door1");
        door.GetComponent<Animation>().Play("open");
    }

    void OnTriggerExit(Collider collider)
    {
        GameObject door = GameObject.FindGameObjectWithTag("SF_Door1");
        door.GetComponent<Animation>().Play("close");
    }
}
