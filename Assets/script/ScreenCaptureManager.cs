﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenCaptureManager : MonoBehaviour
{
    public bool ingame = false; //only take picture if you're ingame lol
    public GameObject inGameIcon; //you wanna hide this to take picture and then unhide this after taking picture
    bool cameraMode = false; //you can only take picture after turning on camera mode lol?
    public GameObject cameraEffect; //you'll see this when you turn on camera mode 
    string lastPicture;
    public GameObject taskComplete;
    public bool inMenu = false;


    //a list of ui objects to show which task is completed at display last picture taken
    public GameObject toriTask;
    public GameObject marketTask;
    public GameObject newsTask;
    public GameObject towerTask;
    public GameObject cinemaTask;
    public GameObject kinkakujiTask;
    float pictureTimer = 2.01f;
    float picTime = 0f;


    private float keyDelay = 0.2f; //so you dont spam stuff omg
    private float timePassed = 0f;
    public bool taskPic;
    public string taskPicName;

    public GameObject pictureTaken; //the panel to show you the picture taken lol

    public GameObject TakePhotoSFX;

    public string ScreenCapDirectory;

    public string ScreenCapName = "Pictures";

    public string fileType = ".png";

    //Private variables to get how many screenshots exist
    private int count;

    public GameObject[] goodpics;
    public GameObject[] badpics;

    void Start()
    {   
        count = 0;
        //ScreenCapDirectory = "C:\\GoldenAge\\cameraSS\\";
        //ScreenCapDirectory = Application.persistentDataPath;
        ScreenCapDirectory = Path.Combine(Application.persistentDataPath,"cameraSS/");
        //ScreenCapDirectory = @"Assets\testing\";
        if (!Directory.Exists(ScreenCapDirectory))
        {
            Directory.CreateDirectory(ScreenCapDirectory);
        }

        var scalethis = cameraEffect.transform as RectTransform;
        scalethis.sizeDelta = new Vector2(Screen.width, Screen.height);

    }

    void Update()
    {
        picTime += Time.deltaTime;
        timePassed += Time.deltaTime;
        if (Input.GetMouseButton(1) && cameraMode == true && timePassed >= keyDelay)
        {
            TakePhotoSFX.GetComponent<AudioSource>().Play();

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

        if(!inMenu)
        {
            if (Input.GetKey("f") && ingame == true && !cameraMode && timePassed >= keyDelay)
            {
                inGameIcon.SetActive(false);
                onCameraMode();
            }
            if(Input.GetKey("f") && ingame == true && cameraMode && timePassed >= keyDelay)
            {
                inGameIcon.SetActive(true); 
                offCameraMode();
                timePassed = 0f;
            }

        }

       
    }

    void onCameraMode()
    {
        FindObjectOfType<FocusChanging>().changeFocus();
        FindObjectOfType<cameraFocusAni>().startAni();
        cameraMode = true;
        turniton();
        timePassed = 0f;
        //cameraEffect.SetActive(true);
        Debug.Log(Application.persistentDataPath);
        Debug.Log(ScreenCapDirectory);
        FindObjectOfType<ObjectManager>().setCameraMode(true);
    }

    public void offCameraMode()
    {
        cameraEffect.SetActive(false);
        cameraMode = false;
        turnitoff();
        FindObjectOfType<ObjectManager>().setCameraMode(false);
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
        if (picTime >= pictureTimer)
        {
            turnitoff();
            cameraEffect.SetActive(false);
            if (SceneManager.GetSceneAt(1).name == "Lvl1")
            {
                FindObjectOfType<hideArrow>().hide();
            }
            takePicture();
            StartCoroutine(inGameIconBack());
            StartCoroutine(displayTimer());
            cameraMode = false;
            FindObjectOfType<ObjectManager>().setCameraMode(false);
            picTime = 0f;
        }
        
    }
    void takePicture()
    {
        string datetime = (System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
        //ScreenCapture.CaptureScreenshot(ScreenCapDirectory + ScreenCapName + (ScreenCaps + 1) + fileType);
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + ScreenCapName + " " + datetime + fileType);

        FindObjectOfType<CameraShutter>().startAni();
        Debug.Log("ScreenCapture Taken!");
        Debug.Log("ScreenCap Location: " + ScreenCapDirectory);
        lastPicture = ScreenCapName + " " + datetime + fileType;
        Debug.Log("screencap name : " + lastPicture);

        StartCoroutine(displayLastPicture());
    }

    public IEnumerator displayTimer()
    {
        yield return new WaitForSeconds(2);
        removeText();
        toriTask.SetActive(false);
        marketTask.SetActive(false);
        newsTask.SetActive(false);
        towerTask.SetActive(false);
        cinemaTask.SetActive(false);
        kinkakujiTask.SetActive(false);
        taskComplete.SetActive(false);
        pictureTaken.SetActive(false);
    }

    public IEnumerator inGameIconBack()
    {
        yield return new WaitForSeconds(0.5f);
        inGameIcon.SetActive(true);
        Debug.Log("sets the dang icon active dang it");
    }

    public void taskListPicture(string placeName)
    {
        if (cameraMode == true && picTime >= pictureTimer)
        {
            turnitoff();

            cameraEffect.SetActive(false);
            ScreenCapture.CaptureScreenshot(ScreenCapDirectory + placeName  + fileType);

            FindObjectOfType<CameraShutter>().startAni();
            Debug.Log("Task list ScreenCapture Taken!");
            Debug.Log("ScreenCap Location: " + ScreenCapDirectory);
            lastPicture = placeName + fileType;
            Debug.Log("screencap name : " + lastPicture);

            taskComplete.SetActive(true);
            if(placeName == "tori")
            {
                toriTask.SetActive(true);
            }
            else if(placeName == "market")
            {
                marketTask.SetActive(true);
            }
            else if (placeName == "station")
            {
                newsTask.SetActive(true);
            }
            else if (placeName == "tower")
            {
                towerTask.SetActive(true);
            }
            else if (placeName == "cinema")
            {
                cinemaTask.SetActive(true);
            }
            else if (placeName == "kinkakuji")
            {
                kinkakujiTask.SetActive(true);
            }

            StartCoroutine(displayLastPicture());
            StartCoroutine(inGameIconBack());
            StartCoroutine(displayTimer());
            cameraMode = false;
            picTime = 0f;
            FindObjectOfType<ObjectManager>().setCameraMode(false);

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


    int FindScreenCaptures(string DirectoryPath, string FileName)
    {
        count = 0;

        for (int i = 0; i < Directory.GetFiles(DirectoryPath).Length; i++)
        {
            if (Directory.GetFiles(DirectoryPath)[i].Contains(FileName) && Directory.GetFiles(DirectoryPath)[i].EndsWith(fileType))
            {
                count += 1;
            }
        }
        return count;
    }


    //Texture2D myTexture;
    public IEnumerator displayLastPicture()
    {
        yield return new WaitForSeconds(0.7f);
        pictureTaken.SetActive(true);
        if(lastPicture.Contains(ScreenCapName))
        {
            itsbad();
        }
        else
        {
            itsgood();
        }
        pictureTaken.GetComponentInChildren<RawImage>().texture = LoadImage(ScreenCapDirectory + lastPicture);
    }

    public static Texture2D LoadImage(string filename)
    {
        byte[] bytes = File.ReadAllBytes(filename);

        Texture2D texture = new Texture2D(Screen.width,Screen.height);
        texture.LoadImage(bytes);

        return texture;
    }

    int ranTextInt;

    void itsgood()
    {
        ranTextInt = Random.Range(0, goodpics.Length);
        goodpics[ranTextInt].SetActive(true);
    }
        
    void removeText()
    {
        badpics[0].SetActive(false);
        badpics[1].SetActive(false);
        badpics[2].SetActive(false);
        badpics[3].SetActive(false);
        goodpics[0].SetActive(false);
        goodpics[1].SetActive(false);

    }
    void itsbad()
    {
        ranTextInt = Random.Range(0, badpics.Length);
        badpics[ranTextInt].SetActive(true);
    }

    public void setTask(string taskName)
    {
        taskPicName = taskName;
        taskPic = true;
    }
}
