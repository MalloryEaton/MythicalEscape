using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ComputerWorldDialogue : MonoBehaviour
{
    public string[] dialogue;
    private Text Coutput;
    private Image Cpanel;
    private FirstPersonController fpc;
    private GameObject outroText;

    private int curLine = 0;

    private GameObject easel;

    void Awake()
    {
        Cpanel = GameObject.Find("Panel").GetComponent<Image>();
        Coutput = GameObject.Find("Text").GetComponent<Text>();
        outroText = GameObject.Find("OutroSpeech");
        fpc = Component.FindObjectOfType<FirstPersonController>();
        easel = GameObject.FindGameObjectWithTag("Easel");
    }

    void Start()
    {
        outroText.SetActive(true);
        Coutput.enabled = false;
        Cpanel.enabled = false;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Coutput.enabled = true;
            Cpanel.enabled = true;
            Coutput.text = dialogue[0];
        }
    }

    void OnGUI()
    {
        if (Coutput.enabled && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
        {
            curLine++;
            if (curLine < dialogue.Length)
            {
                Coutput.text = dialogue[curLine];
                if(curLine == 4)
                {
                    Destroy(easel);
                }
            }
            else
            {
                curLine = 0;
                Cpanel.enabled = false;
                Coutput.enabled = false;
                fpc.toggleDialogue();

                if (outroText.activeInHierarchy == true)
                {
                    Application.LoadLevel("MainScene");
                }
            }
        }
    }
}
