﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TriggerDialogue : MonoBehaviour 
{
    public string[] dialogue;
    private Text output;
    private Image panel;
    private FirstPersonController fpc;

    private GameObject outroText;

    private bool isRiddle = false;
 
    private int curLine = 0;

    private SwitchPuzzle switchesPuzzle;
    private GameObject flashDrive;

 
    void Awake()
    {
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        output = GameObject.FindGameObjectWithTag("CandyText").GetComponent<Text>();
        outroText = GameObject.Find("OutroSpeech");
        panel.enabled = false;
        output.enabled = false;
        fpc = Component.FindObjectOfType<FirstPersonController>();
        flashDrive = GameObject.FindGameObjectWithTag("FlashDrive");
    }

    void OnTriggerEnter (Collider collider) 
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
                fpc.toggleDialogue();

                if (curLine == 3 && outroText.activeInHierarchy == true)
                {
                    Destroy(flashDrive);
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
    }
}
