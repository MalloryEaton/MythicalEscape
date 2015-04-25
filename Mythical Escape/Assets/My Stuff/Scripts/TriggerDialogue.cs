using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TriggerDialogue : MonoBehaviour 
{
    public string[] dialogue;
    private Text output;
    private Image panel;
    private FirstPersonController fpc;
 
    private int curLine = 0;
 
    void Awake()
    {
        fpc = Component.FindObjectOfType<FirstPersonController>();
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        output = GameObject.FindGameObjectWithTag("CandyText").GetComponent<Text>();
        panel.enabled = false;
        output.enabled = false;
    }

    void OnTriggerEnter (Collider collider) 
    {
        if (collider.CompareTag("Player"))
        {
            output.enabled = true;
            panel.enabled = true;
            output.text = dialogue[0];
        }
    }
 
    void OnGUI() 
    {
        if (output.enabled && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return) 
        {
            curLine++;
            if (curLine < dialogue.Length) 
            {
                output.text = dialogue[curLine];
            } 
            else 
            {
                curLine = 0;
                panel.enabled = false;
                output.enabled = false;
                fpc.toggleDialogue();

                Application.LoadLevel("MainScene");
            }
        }
    }
}
