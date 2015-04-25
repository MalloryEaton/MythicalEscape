using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour 
{
    public GameObject player;

    void OnTriggerEnter()
    {
        player.transform.position = new Vector3(233, 1, 76);
    }
}
