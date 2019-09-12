﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScreenCaptureManager : MonoBehaviour
{

    //screenCaptureKey: Change this to any key you want. It is easily changeable in the editor
    public KeyCode screenCaptureKey = KeyCode.F2;
    public bool ingame = false; //only take picture if you're ingame lol
    public GameObject inGameIcon; //you wanna hide this to take picture and then unhide this after taking picture
    bool cameraMode = false; //you can only take picture after turning on camera mode lol?
    public GameObject cameraEffect; //you'll see this when you turn on camera mode 
    string lastPicture;
    public GameObject taskComplete;
    public GameObject toriTask;
    public GameObject marketTask;
    //public GameObject otherTask; //if you need it for futuer stuff lol

    private float keyDelay = 0.2f; //so you dont spam stuff omg
    private float timePassed = 0f;
    public bool taskPic;
    public string taskPicName;

    public GameObject pictureTaken; //the panel to show you the picture taken lol

    //ScreenCapDirectory: If you want a 
    //specific directory do something like this: "C:\\Users\\YourUserNameGoesHere\\Documents\\"
    //Or if you want to use Application.persistentDataPath put it in the 
    //void Start() method and leave this string empty.

    //public GameObject TakePhoto;


#if UNITY_EDITOR
    public string ScreenCapDirectory = @"Assets\testing\";
#else
    public string ScreenCapDirectory = Application.persistentDataPath+"\\cameraSS";
#endif
    //public string ScreenCapDirectory = "C:\\Users\\YourUserNameGoesHere\\Documents\\";
    //public string ScreenCapDirectory = Application.persistentDataPath+"\\cameraSS";  ONLY FOR BUILT SOLUTION! DOES NOT WORK IN UNITY EDITOR

    //The name of the screen capture taken. Put anything you want
    public string ScreenCapName = "Pictures";

    //This will be what type of file your screen capture is. Another type besides png is jpg.
    public string fileType = ".png";

    //Private variables to get how many screenshots exist
    private int count;
    private int ScreenCaps;

    void Start()
    {

        //Set them both to 0 at start
        count = 0;
        ScreenCaps = 0;


        var scalethis = cameraEffect.transform as RectTransform;
        scalethis.sizeDelta = new Vector2(Screen.width, Screen.height);
        //scalethis = pictureTaken.transform as RectTransform;
        //scalethis.sizeDelta = new Vector2(Screen.width * 0.7f, Screen.height * 0.7f);

    }

    void Update()
    {

        timePassed += Time.deltaTime;

        // ScreenCapDirectory = Application.persistentDataPath + "\\cameraSS";
        //ScreenCaps: Say we have 2 files with the same name as your ScreenCapName,
        //            Well then this would just tell us 2 of those files exist.
        //            Then we add that value to our ScreenCaps number to reference later.
        ScreenCaps = (FindScreenCaptures(ScreenCapDirectory, ScreenCapName));

        //If we press our capture key
        if (Input.GetKey(screenCaptureKey) && cameraMode == true && timePassed >= keyDelay)
        {
            /*TakePhoto.SetActive(true);
            TakePhoto.GetComponent<AudioSource>().Play();*/

            if(!taskPic)
            {
                nonTaskListPictures();
            }
            if(taskPic)
            {
                Debug.Log("this is taskpic. in screencap");
                taskListPicture(taskPicName);
            }

        }


        if(Input.GetKey("h") && ingame == true && !cameraMode && timePassed >= keyDelay)
        {
            inGameIcon.SetActive(false);
            cameraEffect.SetActive(true);
            cameraMode = true;
            turniton();
            timePassed = 0f;

        }
        if(Input.GetKey("h") && ingame == true && cameraMode && timePassed >= keyDelay)
        {
            inGameIcon.SetActive(true);
            cameraEffect.SetActive(false);
            cameraMode = false;
            turnitoff();
            timePassed = 0f;
        }
    }



    void turnitoff()
    {
        postProcessingBehaviour vfx = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().GetComponentInChildren<postProcessingBehaviour>();
        vfx.enabled = false;
    }

    void turniton()
    {
        postProcessingBehaviour vfx = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().GetComponentInChildren<postProcessingBehaviour>();
        vfx.enabled = true;
    }

    void nonTaskListPictures()
    {
        turnitoff();
        cameraEffect.SetActive(false);
        takePicture();
        StartCoroutine(inGameIconBack());
        StartCoroutine(displayTimer());
        cameraMode = false;
        timePassed = 0f;
    }
    void takePicture()
    {
        //This is how you save the screenshot to a certain directory and a certain name
        //(ScreenCaps + 1): We reference this from above and use it for our picture name
        //                  So if we know 2 files exist we add 1 to our value so it is a new picture.
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + ScreenCapName + (ScreenCaps + 1) + fileType);
        Debug.Log("ScreenCapture Taken!");
        Debug.Log("ScreenCap Location: " + ScreenCapDirectory);
        lastPicture = ScreenCapName + (ScreenCaps + 1)+ fileType;
        Debug.Log("screencap name : " + lastPicture);

        StartCoroutine(displayLastPicture());
    }

    public IEnumerator displayTimer()
    {
        yield return new WaitForSeconds(2);
        pictureTaken.SetActive(false);
        taskComplete.SetActive(false);
    }
    public IEnumerator inGameIconBack()
    {
        yield return new WaitForSeconds(0.5f);
        inGameIcon.SetActive(true);
        Debug.Log("sets the dang icon active dang it");
    }

    public void taskListPicture(string placeName)
    {
        if (cameraMode == true && timePassed >= keyDelay)
        {
            turnitoff();

            cameraEffect.SetActive(false);
            ScreenCapture.CaptureScreenshot(ScreenCapDirectory + placeName  + fileType);
            Debug.Log("Task list ScreenCapture Taken!");
            Debug.Log("ScreenCap Location: " + ScreenCapDirectory);
            lastPicture = placeName + fileType;
            Debug.Log("screencap name : " + lastPicture);

            taskComplete.SetActive(true);
            if(placeName == "tori")
            {
                toriTask.SetActive(true);
            }
            if(placeName == "market")
            {
                marketTask.SetActive(true);
            }

            StartCoroutine(displayLastPicture());
            StartCoroutine(inGameIconBack());
            StartCoroutine(displayTimer());
            cameraMode = false;
            timePassed = 0f;
            //takingTaskListPicture = false;
            //taskComplete.SetActive(false);

        }
        
    }

    public bool taskListCheck(string taskname)
    {
        if(FindScreenCaptures(ScreenCapDirectory,taskname) > 0)
        {
            return true;
        }
        return false;
    }

    //This gets all the existing files from the Directory (DirectoryPath)
    //with the FileName(FileName).
    int FindScreenCaptures(string DirectoryPath, string FileName)
    {
        //Set count to 0 at every run so we count up from 0 to 
        //how many files exist with the FileName entered
        count = 0;


        //This loops through the files in your entered Directory
        for (int i = 0; i < Directory.GetFiles(DirectoryPath).Length; i++)
        {
            //If any file has the same name as your picture
            if (Directory.GetFiles(DirectoryPath)[i].Contains(FileName) && Directory.GetFiles(DirectoryPath)[i].EndsWith(fileType))
            {
                //Add 1 to the count because we need to know how many
                //files with the same name exist
                count += 1;
            }
        }
        //Once we know we return that amount
        return count;
    }



    //make a function to activate count number of boxes of ui 
    //we coult instantaniate? set alignment? 
    //or just have a single picture on the screen and have arrows to go back and next if there's such thing
    //and then load the the images into the boxes of ui

    Texture2D myTexture;
    public IEnumerator displayLastPicture()
    {
        yield return new WaitForSeconds(0.1f);
        pictureTaken.SetActive(true);
        pictureTaken.GetComponentInChildren<RawImage>().texture = LoadImage("Assets\\testing\\" + lastPicture);
    }

    public static Texture2D LoadImage(string filename)
    {
        byte[] bytes = File.ReadAllBytes(filename);

        Texture2D texture = new Texture2D(Screen.width,Screen.height);
        texture.LoadImage(bytes);

        return texture;
    }

}
