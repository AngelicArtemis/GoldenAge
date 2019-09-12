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

        /*
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (playerLookingAtCollider == true && playerClose == true && checkPhotoTaken == 0)
            {
                checkPhotoTaken = 1;
                photoCollected = photoCollected + 1;
                photo.SetActive(true);
                Debug.Log("photoActive = true");
            }
        }
        */


        if(playerLookingAtCollider)// && playerClose == true)// && !tasklist.taskCompletion)
        {
            if(playerClose)
            {
                if(!tasklist.taskCompletion)
                {
                    Debug.Log("this is taskpic in collider");
                    FindObjectOfType<ScreenCaptureManager>().taskPic = true;
                    FindObjectOfType<ScreenCaptureManager>().taskPicName = tasklist.taskName;
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

        /*

        if (Input.GetKey("f"))
        {
            Debug.Log("task completion is" + tasklist.taskCompletion);
            if (playerLookingAtCollider == true && playerClose == true && !tasklist.taskCompletion)
            {
                if (FindObjectOfType<ScreenCaptureManager>().taskListPicture(tasklist.taskName))
                {
                    tasklist.taskCompletion = true;
                    Debug.Log("pressed f and took a pic");
                }
                else
                {
                    tasklist.taskCompletion = false;
                    Debug.Log("hewwo? what is this??");
                }
            }
            Debug.Log("did something happen?");

        }
        */

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
