using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour 
{
    private SlidingPuzzle slidingPuzzle;
    private SwitchPuzzle switchesPuzzle;
    private ChangeColor colorPuzzle;

    private GameObject player;

    private Collider treeCollider;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        slidingPuzzle = GameObject.FindObjectOfType<SlidingPuzzle>();
        switchesPuzzle = GameObject.FindObjectOfType<SwitchPuzzle>();
        colorPuzzle = GameObject.FindObjectOfType<ChangeColor>();

        treeCollider = GameObject.FindGameObjectWithTag("Tree").GetComponent<Collider>();

        if (colorPuzzle)
        {
            Destroy(treeCollider);
        }

        if (colorPuzzle && colorPuzzle.solved())
        {
            player.transform.position = new Vector3(70, 9, 86);
        }
        else if (switchesPuzzle.solved())
        {
            player.transform.position = new Vector3(11, 9, 86);
        }
        else if (slidingPuzzle.solved())
        {
            player.transform.position = new Vector3(-48, 9, 86);
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
