using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    string sceneName;
    public GameObject ingamemenu;
    public bool gamestart = false;

    void getSceneName()
    {
        Scene currentScene = SceneManager.GetSceneAt(1);
        sceneName = currentScene.name;
    }

    public void lvl0()
    {
        ingamemenu.SetActive(false);
        SceneManager.LoadScene("Lvl0", LoadSceneMode.Additive);
        gamestart = true;
        GameObject canvas = GameObject.Find("PersistentCanvas");
        ButtonManager buttonManager = canvas.GetComponent<ButtonManager>();
        buttonManager.inGame = true;
    }

    public void lvl1()
    {
        FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false; //prevents double loading
        FindObjectOfType<LoadingScreen>().load("Lvl1", "Lvl0");
    }
    public void lvl2()
    {
        FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        FindObjectOfType<LoadingScreen>().load("Lvl0", "Lvl1"); 
    }
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Player"))
        {
            getSceneName();
            if (sceneName == "Lvl1")
            {
                lvl2();
            }
            else if(sceneName == "Lvl0")
            {
                lvl1();
            }
        }
    }



}
