using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    string sceneName;
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
         sceneName = currentScene.name;
    }

    public void lvl1()
    {
        //SceneManager.LoadScene("Lvl1", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Lvl1",LoadSceneMode.Additive);
    }
    public void lvl2()
    {
        //SceneManager.LoadScene("Lvl2", LoadSceneMode.Additive);
        //SceneManager.UnloadScene("Lvl1");
        SceneManager.LoadSceneAsync("Lvl2", LoadSceneMode.Additive);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "playerTouch")
        {
            if(sceneName == "Lvl1")//&& photoCollider.photoCollected == 3) rather than putting it here, make it so
                //that the portal only appear AFTER you finish collecting the three pics ya know?
            {
                lvl2();
                SceneManager.UnloadSceneAsync("Lvl1");
            }
            else
            {
                lvl1();
                SceneManager.UnloadSceneAsync("Lvl0");
            }
        }
    }
}
