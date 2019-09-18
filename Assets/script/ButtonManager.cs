using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject inGameMenu;
    bool inMenu = false;
    public bool inGame = false;
    public float keyDelay;
    private float timePassed = 0f;
    public GameObject credit; //creditpage
    public GameObject tutorialPage; //tutorialpage
    public int sizeofThis;
    public GameObject[] sizeThis;
    public GameObject testingscale;
    public GameObject inGameIcon;
    public GameObject clickSFX;



    public GameObject tasklistPage; //tasklist page

    private void Start()
    {
        
        for(int i=0;i<sizeofThis;i++)
        {
            var buttsize = sizeThis[i].transform as RectTransform;
            buttsize.sizeDelta = new Vector2(Screen.width, Screen.height);
        }

        var scalethis = mainMenu.transform as RectTransform;
        scalethis.sizeDelta = new Vector2(Screen.width, Screen.height);
        float screenheight, screenwidth;
        screenheight = Screen.height;
        screenwidth = Screen.width;
        float scalex = screenwidth/738; //magic number, will probably fix this...or not who knows
        float scaley = screenheight/415;

        scalethis = testingscale.transform as RectTransform;
        scalethis.transform.localScale = new Vector3(scalex, scaley, 1);

    }
    private void Update()
    {
        //opens ingame menu

        timePassed += Time.deltaTime;
        //print(timePassed);
        if (Input.GetKey("escape") && inGame && timePassed >= keyDelay) 
        {
            if (!inMenu)
            {
                FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
                StartCoroutine(enableCursor());
                inGameMenu.SetActive(true);
                inGameIcon.SetActive(false);
                inMenu = true;
            }
            else if (inMenu)
            {
                FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
                StartCoroutine(disableCursor());
                inGameMenu.SetActive(false);
                inGameIcon.SetActive(true);
                inMenu = false;
            }
            timePassed = 0f;
        }

    }


    public void startGame()
    {
        StartCoroutine(disableCursor());
        inGameIcon.SetActive(true);
        mainMenu.SetActive(false);
        FindObjectOfType<ScreenCaptureManager>().ingame = true;
        FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
    }
    

    private IEnumerator disableCursor()
    {
        yield return new WaitForEndOfFrame();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    private IEnumerator enableCursor()
    {
        yield return new WaitForEndOfFrame();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void returnToMainMenu()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //returns to main menu
        string sceneName;

        if(inGame)
        {
            Scene currentScene = SceneManager.GetSceneAt(1);
            sceneName = currentScene.name;
            SceneManager.UnloadSceneAsync(sceneName);
            inGame = false;

            GameObject canvas = GameObject.Find("PersistentCanvas");
            SceneChanger sceneChanger = canvas.GetComponent<SceneChanger>();
            sceneChanger.gamestart = false;
        }
        
        mainMenu.SetActive(true);
        inGameMenu.SetActive(false);
        inGameIcon.SetActive(false);
        FindObjectOfType<ScreenCaptureManager>().ingame = false;
    }

    public void exitGame()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //exits game
        Application.Quit();
    }

    public void creditPage()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //opens credit page
        credit.SetActive(true);
    }

    public void closeCredit()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        credit.SetActive(false);
    }

    public void libraryPage()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //opens library page
    }

    public void instructionPage()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //opens instruction page
        tutorialPage.SetActive(true);
    }
    public void closeInstruction()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //close tutorialUI
        tutorialPage.SetActive(false);
    }

    public void map()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //opens map
    }

    public void taskList()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        //opens task list
        tasklistPage.SetActive(true);
        FindObjectOfType<TaskListManager>().displayTasks();
    }

    public void closeTaskList()
    {

    }

}
