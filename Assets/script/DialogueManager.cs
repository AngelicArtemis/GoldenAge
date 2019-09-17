using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;
    
    public Queue<string> sentences;
    public GameObject dialogBox;
    public bool typing = false;


    private void Start()
    {
        sentences = new Queue<string>();
    }


    public void startDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        firstPersonController.enabled = false;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(typing)
        {
            return;
        }
        if (sentences.Count == 0)
        {
            endDialogue();
            return;
        }

        dialogBox.SetActive(true);
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        typing = true;
        dialogBox.transform.Find("Text").GetComponent<UnityEngine.UI.Text>().text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogBox.transform.Find("Text").GetComponent<UnityEngine.UI.Text>().text += letter;
            yield return new WaitForSeconds(0.02f);
        }
        typing = false;
    }

    void endDialogue()
    {
        dialogBox.SetActive(false);
        FindObjectOfType<DialogueTrigger>().talking = false;
        firstPersonController.enabled = true;
    }
}