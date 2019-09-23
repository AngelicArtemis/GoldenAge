using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoCollider : MonoBehaviour
{ 
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;
    /*
    private int checkPhotoTaken = 0;
    public static int photoCollected = 0;*/
    //public GameObject photo;
    TaskList tasklist = new TaskList();
    public bool taskPic;

    // Use this for initialization
    void Start()
    {
        Debug.Log(gameObject.name);
        setTaskName();
        FindObjectOfType<TaskListManager>().taskChecker(tasklist);
    }

    // Update is called once per frame
    void Update()
    {



        if(playerLookingAtCollider)// && playerClose == true)// && !tasklist.taskCompletion)
        {

            FindObjectOfType<TaskListManager>().taskChecker(tasklist);
            if (playerClose)
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

                    Debug.Log("this is false1");
                    FindObjectOfType<ScreenCaptureManager>().taskPic = false;
                }
                
            }
            if (!playerClose)
            {
                Debug.Log("this is false2");
                FindObjectOfType<ScreenCaptureManager>().taskPic = false;
            }
        }


    }

    void setTaskName() //maybe put a loop and put the word in an array to loop through...eh we're still in testing
    {
        if (gameObject.name.ToLower().Contains("tori"))
        {
            tasklist.taskName = "tori";
        }
        else if (gameObject.name.ToLower().Contains("market"))
        {
            tasklist.taskName = "market";
        }
        else if(gameObject.name.ToLower().Contains("tower"))
        {
            tasklist.taskName = "tower";
        }
        else if(gameObject.name.ToLower().Contains("kinkakuji"))
        {
            tasklist.taskName = "kinkakuji";
        }
        else if (gameObject.name.ToLower().Contains("news"))
        {
            tasklist.taskName = "news";
        }
        else if (gameObject.name.ToLower().Contains("cinema"))
        {
            tasklist.taskName = "cinema";
        }
        else
        {
            tasklist.taskName = "what";
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = true;
            Debug.Log("playerClose = true");
        }
        if(collider.gameObject.name == "playerTouch")
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
}
