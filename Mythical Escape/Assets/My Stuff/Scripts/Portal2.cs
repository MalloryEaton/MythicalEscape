using UnityEngine;
using System.Collections;

public class Portal2 : MonoBehaviour 
{
    private GameObject elMusico;

    void Awake()
    {
        elMusico = GameObject.Find("Music");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(elMusico);
            Application.LoadLevel("Shrooms");
        }
    }
}
