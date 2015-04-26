using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CandyLevelTriggerDialogue : MonoBehaviour 
{
    public string[] dialogue;
    private Text output;
    private Image panel;
    private FirstPersonController fpc;

    private GameObject introText;
    private GameObject outroText;

    private bool isRiddle = false;

    private int curLine = 0;

    void Awake()
    {
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        output = GameObject.FindGameObjectWithTag("CandyText").GetComponent<Text>();
        introText = GameObject.Find("IntroSpeech");
        outroText = GameObject.Find("OutroSpeech");
        panel.enabled = false;
        output.enabled = false;
        fpc = Component.FindObjectOfType<FirstPersonController>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            outroText.SetActive(true);
            output.enabled = true;
            panel.enabled = true;
            output.text = dialogue[0];
        }
    }

    void OnGUI()
    {
        if (output.enabled && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return && !isRiddle)
        {
            curLine++;
            if (curLine < dialogue.Length)
            {
                output.text = dialogue[curLine];
                if (curLine == 3)
                {
                    fpc.toggleMouseMovement();
                }
                if (curLine == 3 || curLine == 5 || curLine == 7)
                {
                    isRiddle = true;
                }
            }
            else
            {
                curLine = 0;
                panel.enabled = false;
                output.enabled = false;
                fpc.toggleDialogue();

                if (outroText.activeInHierarchy == true)
                {
                    Application.LoadLevel("MainScene");
                }
            }
        }
        else if (isRiddle && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Alpha1)
        {
            curLine++;
            if (curLine < dialogue.Length)
            {
                output.text = dialogue[curLine];
            }
            isRiddle = false;
        }
    }
}
