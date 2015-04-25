using UnityEngine;
using System.Collections;

public class Door3 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject door = GameObject.FindGameObjectWithTag("SF_Door3");
        door.GetComponent<Animation>().Play("open");
    }

    void OnTriggerExit(Collider collider)
    {
        GameObject door = GameObject.FindGameObjectWithTag("SF_Door3");
        door.GetComponent<Animation>().Play("close");
    }
}
