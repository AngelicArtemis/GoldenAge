using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class photoCollider : MonoBehaviour
{ 
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;

    TaskList tasklist = new TaskList();
    public bool taskPic;
    GameObject player;
    Vector3 facingDir;
    public GameObject directionOfPhoto;

    string ScreenCapDirectory;// = "C:\\GoldenAge\\cameraSS\\";

    string ScreenCapName = "Pictures";

    void Start()
    {
        ScreenCapDirectory = Application.persistentDataPath;
        ScreenCapDirectory = Path.Combine(ScreenCapDirectory,"\\cameraSS\\");
        init();
    }

    private void init()
    {
        tasklist.taskName = "";
        setTaskName();
        //FindObjectOfType<TaskListManager>().taskChecker(tasklist);
        taskChecker();
        //player = FindObjectOfType<CharacterController>().gameObject;
        player = FindObjectOfType<FocusChanging>().gameObject;
    }

    void taskChecker()
    {
        for (int i = 0; i < Directory.GetFiles(ScreenCapDirectory).Length; i++)
        {
            if (Directory.GetFiles(ScreenCapDirectory)[i].Contains(tasklist.taskName) && Directory.GetFiles(ScreenCapDirectory)[i].EndsWith(".png"))
            {
                tasklist.taskCompletion = true;
            }
        }
    }

    void Update()
    {
        if(playerClose)
        {
            checkLooking();
            if (playerLookingAtCollider)
            {
                if(!tasklist.taskCompletion)
                {
                    Debug.Log("this is taskpic in collider");
                    FindObjectOfType<ScreenCaptureManager>().taskPic = true;
                    FindObjectOfType<ScreenCaptureManager>().taskPicName = tasklist.taskName;
                    //FindObjectOfType<TaskListManager>().taskChecker(tasklist);
                }
                if(tasklist.taskCompletion)
                {

                    Debug.Log("this is false1");
                    FindObjectOfType<ScreenCaptureManager>().taskPic = false;
                }
                
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
        init();
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
            //Debug.Log("playerClose = false");
        }
        closeArrows();
    }

    void checkLooking()
    {
        facingDir = player.transform.forward;
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position,facingDir , out hit, 100f))
        {
            //Debug.Log(hit.collider.gameObject);
            if (hit.collider.gameObject == directionOfPhoto)
            {
                Debug.Log("you hit the goal!!!");
                closeArrows();
                playerLookingAtCollider = true;
            }
            else
            {
                playerLookingAtCollider = false;
                hint();
            }
        }
        
    }

    public GameObject left;
    public GameObject right;

    void hint()
    {
        Vector3 rightDir = directionOfPhoto.transform.position - player.transform.position;


        float angle = Vector3.SignedAngle(rightDir, player.transform.forward, Vector3.up);

        //Debug.Log(angle); //if negative, look right
        arrows(angle);
    }

    void arrows(float angle)
    {
        if(angle < 0)
        {
            right.SetActive(true);
            left.SetActive(false);
        }
        if(angle > 0)
        {
            right.SetActive(false);
            left.SetActive(true);
        }
    }

    void closeArrows()
    {
        right.SetActive(false);
        left.SetActive(false);
    }
}
