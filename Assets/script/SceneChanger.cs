using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    string sceneName;
    public GameObject button1;
    public bool gamestart = false;

    void Update()
    {
        if(gamestart)
        {
            Scene currentScene = SceneManager.GetSceneAt(1);
            sceneName = currentScene.name;
        }
    }

    public void lvl0()
    {
        button1.SetActive(false);
        SceneManager.LoadScene("Lvl0", LoadSceneMode.Additive);
        gamestart = true;
        GameObject canvas = GameObject.Find("PersistentCanvas");
        ButtonManager buttonManager = canvas.GetComponent<ButtonManager>();
        buttonManager.inGame = true;
    }

    public void lvl1()
    {
        FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false; //prevents double loading
        SceneManager.LoadSceneAsync("Lvl1", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Lvl0");

    }
    public void lvl2()
    {
        FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        SceneManager.LoadSceneAsync("Lvl0", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Lvl1");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "playerTouch")
        {
            if(sceneName == "Lvl1")//&& photoCollider.photoCollected == 3) rather than putting it here, make it so
                //that the portal only appear AFTER you finish collecting the three pics
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
