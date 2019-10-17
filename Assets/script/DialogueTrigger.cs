using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue[] dialogues;
    Dialogue dialogue;
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;
    public bool talking = false;
    bool typing = false;

    void Update()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            IsThisTyping();
            if (typing)
                return;
            if (talking)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
                if (FindObjectOfType<DialogueManager>().endChat)
                {
                    talking = false;
                }
            }
            else
            {
                if (playerLookingAtCollider == true && playerClose == true) //show the talking chat bubble vfx here to show you can talk to him
                {
                    dialogue = dialogues[Random.Range(0, dialogues.Length)];
                    TriggerDialogue();
                    talking = true;
                }

            }
        }
            
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().startDialogue(dialogue);
    }

    public void IsThisTyping()
    {
        typing = FindObjectOfType<DialogueManager>().typing;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = true;
        }
        if (collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
        }
        if (collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = false;
        }
    }


}