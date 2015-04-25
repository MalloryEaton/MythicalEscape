using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MainSceneDialogue : MonoBehaviour
{
    public string[] dialogue;
    private Text Moutput;
    private Image Mpanel;
    private Text output;
    private Image panel;
    private FirstPersonController fpc;

    private GameObject introText;
    private GameObject doorText;

    private GameObject proximityDetector;

    private int curLine = 0;

    private static bool introHasPlayed;

    void Awake()
    {
        proximityDetector = GameObject.Find("ProximityDetector");
        if (introHasPlayed)
        {
            proximityDetector.SetActive(false);
        }
        else
        {
            introHasPlayed = false;
        }
        Mpanel = GameObject.Find("MainPanel").GetComponent<Image>();
        Moutput = GameObject.Find("MainText").GetComponent<Text>();
        panel = GameObject.Find("Panel").GetComponent<Image>();
        output = GameObject.Find("Text").GetComponent<Text>();
        introText = GameObject.Find("IntroSpeech");
        doorText = GameObject.Find("DoorText");
        Mpanel.enabled = false;
        Moutput.enabled = false;
        panel.enabled = false;
        output.enabled = false;
        fpc = Component.FindObjectOfType<FirstPersonController>();
    }

    void Start()
    {
        introText.SetActive(true);
        doorText.SetActive(false);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !introHasPlayed)
        {
            Moutput.enabled = true;
            Mpanel.enabled = true;
            Moutput.text = dialogue[0];
        }
    }

    void OnGUI()
    {
        if (Moutput.enabled && Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return && !introHasPlayed)
        {
            curLine++;
            if (curLine < dialogue.Length)
            {
                Moutput.text = dialogue[curLine];
            }
            else
            {
                curLine = 0;
                Mpanel.enabled = false;
                Moutput.enabled = false;
                fpc.toggleDialogue();

                introHasPlayed = true;
                introText.SetActive(false);
                doorText.SetActive(true);
            }
        }
    }
}
