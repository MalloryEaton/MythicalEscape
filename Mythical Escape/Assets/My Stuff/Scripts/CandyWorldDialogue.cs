using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CandyWorldDialogue : MonoBehaviour
{
    public string[] dialogue;
    private Text Coutput;
    private Image Cpanel;
    private FirstPersonController fpc;

    private GameObject introText;
    private GameObject outroText;

    private int curLine = 0;

    void Awake()
    {
        Cpanel = GameObject.Find("CandyPanel").GetComponent<Image>();
        Coutput = GameObject.Find("CandyText").GetComponent<Text>();
        introText = GameObject.Find("IntroSpeech");
        outroText = GameObject.Find("OutroSpeech");
        fpc = Component.FindObjectOfType<FirstPersonController>();
    }

    void Start()
    {
        introText.SetActive(true);
        outroText.SetActive(false);
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
            }
            else
            {
                curLine = 0;
                Cpanel.enabled = false;
                Coutput.enabled = false;
                fpc.toggleDialogue();
                introText.SetActive(false);
            }
        }
    }
}
