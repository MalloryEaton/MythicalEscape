using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour 
{
    private SlidingPuzzle slidingPuzzle;
    private SwitchPuzzle switchesPuzzle;
    private GameObject colorPuzzle;

    private GameObject player;

    private Collider treeCollider;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        slidingPuzzle = GameObject.FindObjectOfType<SlidingPuzzle>();
        switchesPuzzle = GameObject.FindObjectOfType<SwitchPuzzle>();
        colorPuzzle = GameObject.FindGameObjectWithTag("ColorPuzzle");

        treeCollider = GameObject.FindGameObjectWithTag("Tree").GetComponent<Collider>();

        if (slidingPuzzle && switchesPuzzle && colorPuzzle)
        {
            Destroy(treeCollider);
        }

        if (colorPuzzle)
        {
            player.transform.position = new Vector3(70, 9, 86);
            player.transform.Rotate(0, 20f, 0);
        }
        else if (switchesPuzzle.solved())
        {
            player.transform.position = new Vector3(11, 9, 86);
        }
        else if (slidingPuzzle.solved())
        {
            player.transform.position = new Vector3(-48, 9, 86);
            player.transform.Rotate(0, -37f, 0);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Application.LoadLevel("Tree");
        }
    }
}
