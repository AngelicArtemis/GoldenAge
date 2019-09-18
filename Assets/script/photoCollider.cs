using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoCollider : MonoBehaviour
{ 
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;

    TaskList tasklist = new TaskList();
    public bool taskPic;

    // Use this for initialization
    void Start()
    {
        Debug.Log(gameObject.name);
        setTaskName();
        FindObjectOfType<TaskListManager>().taskChecker(tasklist);
    }

    void Update()
    {
        if(playerClose)
        {
            FindObjectOfType<TaskListManager>().taskChecker(tasklist);
            if (playerLookingAtCollider)
            {
                if(!tasklist.taskCompletion)
                {
                    Debug.Log("this is taskpic in collider");
                    FindObjectOfType<ScreenCaptureManager>().taskPic = true;
                    FindObjectOfType<ScreenCaptureManager>().taskPicName = tasklist.taskName;
                    FindObjectOfType<TaskListManager>().taskChecker(tasklist);
                }
                if(tasklist.taskCompletion)
                {

                    FindObjectOfType<ScreenCaptureManager>().taskPic = false;
                }
                
            }
            if (!playerLookingAtCollider)
            {    //make it so that this say "this is close but isnt it"
                FindObjectOfType<ScreenCaptureManager>().taskPic = false;
            }
        }

    }

    void setTaskName() //maybe put a loop and put the word in an array to loop through...eh we're still in testing
    {
        if (gameObject.name.Contains("tori"))
        {
            tasklist.taskName = "tori";
        }
        else if (gameObject.name.Contains("market"))
        {
            tasklist.taskName = "market";
        }
        else if(gameObject.name.Contains("tower"))
        {
            tasklist.taskName = "tower";
        }
        else if(gameObject.name.Contains("kinkakuji"))
        {
            tasklist.taskName = "kinkakuji";
        }
        else
        {
            tasklist.taskName = "";
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = true;
            Debug.Log("playerClose = true");
        }

    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
            Debug.Log("playerClose = false");
        }
    }
}
