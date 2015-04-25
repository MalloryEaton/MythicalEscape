using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorPuzzleTrigger : MonoBehaviour
{
    private Component elMusico;
    private GameObject door;

    public string[] dialogue;
    private Text output;
    private Image panel;

    private int curLine = 0;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door3");
        elMusico = GameObject.Find("FirstPersonCharacter").GetComponent<AudioSource>();
        DontDestroyOnLoad(elMusico);
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        output = GameObject.FindGameObjectWithTag("CandyText").GetComponent<Text>();
        panel.enabled = false;
        output.enabled = false;
    }

    void Update()
    {
        if (output.enabled && Input.GetKeyUp(KeyCode.Alpha3))
        {
            Application.LoadLevel("ColorPuzzle");
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
