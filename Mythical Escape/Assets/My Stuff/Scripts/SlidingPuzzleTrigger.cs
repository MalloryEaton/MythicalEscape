using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlidingPuzzleTrigger : MonoBehaviour 
{
    private Component elMusico;
    private GameObject door;
    private GameObject player;

    public string[] dialogue;
    private Text output;
    private Image panel;

    private int curLine = 0;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        door = GameObject.FindGameObjectWithTag("SF_Door1");
        elMusico = GameObject.Find("FirstPersonCharacter").GetComponent<AudioSource>();
        DontDestroyOnLoad(elMusico);
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        output = GameObject.FindGameObjectWithTag("CandyText").GetComponent<Text>();
        panel.enabled = false;
        output.enabled = false;
    }

    void Update()
    {
        if (output.enabled && Input.GetKeyUp(KeyCode.Alpha1))
        {
            Application.LoadLevel("SlidingPuzzle");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        //door.GetComponent<Animation>().Play("open");

        if (collider.CompareTag("Player"))
        {
            output.enabled = true;
            panel.enabled = true;
            output.text = dialogue[0];
        }
    }

    void OnTriggerExit(Collider collider)
    {
        //door.GetComponent<Animation>().Play("close");
        if (collider.CompareTag("Player"))
        {
            output.enabled = false;
            panel.enabled = false;
        }
    }
}
