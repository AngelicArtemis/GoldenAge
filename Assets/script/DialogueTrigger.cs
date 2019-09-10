using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue[] dialogues;
    Dialogue dialogue;
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;
    public bool talking = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
        if (talking)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }
            else
            {
                if (playerLookingAtCollider == true && playerClose == true)
                {
                    dialogue = dialogues[Random.Range(0, dialogues.Length)];
                    TriggerDialogue();
                    talking = true;
                }
            
            }
        }
            
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = true;
            Debug.Log("playerClose = true");
        }
        if (collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = true;
            Debug.Log("playerLookingAtCollider = true");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
            Debug.Log("playerClose = false");
        }
        if (collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = false;
            Debug.Log("playerLookingAtCollider = false");
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().startDialogue(dialogue);
    }

}