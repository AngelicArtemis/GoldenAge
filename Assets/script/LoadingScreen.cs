using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject[] loadingPages;
    public GameObject loading;


    IEnumerator loadingNewScene(string scene, string unScene)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);

        while (!ao.isDone)
        {
            //yield return StartCoroutine(loadingThings());
            yield return null;
            // [0, 0.9] > [0, 1]
            float progress = Mathf.Clamp01(ao.progress / 0.9f);
            Debug.Log("ao.progress" + ao.progress); //this only shows 0 and 0.9??? wtf???hello??? wheres the number in between???

            //StartCoroutine(loadingThings(progress));
            showLoading(progress);
        }
        SceneManager.UnloadSceneAsync(unScene);
        doneLoading();
    }

    IEnumerator loadingThings(float progress)
    {
        int i = (int)((progress * 100) / 12.5);

        if (i == 8)
        {
            loadingPages[7].SetActive(true);
        }
        else
            loadingPages[i].SetActive(true);
        if (i == 0)
        {

        }
        else
        {
            loadingPages[i - 1].SetActive(false);
        }
        yield return null;
    }

    void showLoading(float progress)
    {
        int i = (int)(progress * 100) / 12;

        switch(i)
        {
            case 0:
                loadingPages[0].SetActive(true);
                break;
            case 1:
                loadingPages[1].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 2:
                loadingPages[2].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 3:
                loadingPages[3].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 4:
                loadingPages[4].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 5:
                loadingPages[5].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 6:
                loadingPages[6].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            case 7:
                loadingPages[7].SetActive(true);
                loadingPages[i - 1].SetActive(false);
                break;
            default:
                break;
        }

    }

    void doneLoading()
    {
        loadingPages[7].SetActive(false);
        loading.SetActive(false);
    }

    public void load(string scene, string unScene)
    {
        loading.SetActive(true);
        var resizing = loading.transform as RectTransform;
        //var resizing = loading.GetComponent<RectTransform>();
        resizing.sizeDelta = new Vector2(Screen.width, Screen.height);

        StartCoroutine(loadingNewScene(scene,unScene));
    }

}
