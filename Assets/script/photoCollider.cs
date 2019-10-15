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
    public GameObject player;
    Vector3 facingDir;
    GameObject directionOfPhoto;

    // Use this for initialization
    void Start()
    {
        init();
    }

    private void init()
    {
        tasklist.taskName = "";
        Debug.Log(gameObject.name);
        setTaskName();
        FindObjectOfType<TaskListManager>().taskChecker(tasklist);
        player = FindObjectOfType<CharacterController>().gameObject;
        //directionOfPhoto = transform.GetChild(0).GetComponent<Collider>().gameObject;
        directionOfPhoto = gameObject.GetComponentInChildren<Collider>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        checkLooking();
        if(playerClose)// && playerClose == true)// && !tasklist.taskCompletion)
        {
            init();
            //FindObjectOfType<TaskListManager>().taskChecker(tasklist);
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
        else if (gameObject.name.ToLower().Contains("station"))
        {
            tasklist.taskName = "station";
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
            //Debug.Log("playerClose = true");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
            //Debug.Log("playerClose = false");
        }
    }

    void checkLooking()
    {
        facingDir = player.transform.forward;
        RaycastHit hit;
        //Debug.Log("raycast?");
        if (Physics.Raycast(player.transform.position,facingDir , out hit))
        {
            //Debug.Log(hit.transform.gameObject.name); //returns the name of the object the ray hit
            if (hit.transform.gameObject== directionOfPhoto)
            {
                //Debug.Log("you hit the goal!!!");
                playerLookingAtCollider = true;
            }
        }
        else
        {
            playerLookingAtCollider = false;
        }
    }
}
