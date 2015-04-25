using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorPuzzleTrigger : MonoBehaviour
{
    private GameObject door;

    public string[] dialogue;
    private Text output;
    private Image panel;

    private int curLine = 0;

    void Awake()
    {
        door = GameObject.FindGameObjectWithTag("SF_Door3");
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
        if (collider.CompareTag("Player"))
        {
            output.enabled = true;
            panel.enabled = true;
            output.text = dialogue[0];
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            output.enabled = false;
            panel.enabled = false;
        }
    }
}
