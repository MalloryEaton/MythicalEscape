using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour 
{
    private SlidingPuzzle slidingPuzzle;
    private SwitchPuzzle switchesPuzzle;
    private ChangeColor colorPuzzle;

    private Collider treeCollider;

    void Awake()
    {
        colorPuzzle = GameObject.FindObjectOfType<ChangeColor>();
        treeCollider = GameObject.FindGameObjectWithTag("Tree").GetComponent<Collider>();

        if (colorPuzzle.solved())
        {
            Destroy(treeCollider);
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
