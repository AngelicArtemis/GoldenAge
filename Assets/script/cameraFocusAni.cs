using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFocusAni : MonoBehaviour
{
    public GameObject[] aniPages;
    public GameObject cameraEffect;

    public void startAni()
    {
        StartCoroutine(wait());
        aniPages[4].SetActive(false);
    }

    IEnumerator wait()
    {
        yield return null;
        aniPages[0].SetActive(true);
        StartCoroutine(shutter());
    }

    IEnumerator shutter()
    {
        for (int i = 1; i < aniPages.Length; i++)
        {
            yield return new WaitForSeconds(0.18f); //testing purposes
            aniPages[i].SetActive(true);
            aniPages[i - 1].SetActive(false);
            if (i == 4)
            {
                yield return new WaitForSeconds(0.18f); //testing purposes
                aniPages[4].SetActive(false);
                cameraEffect.SetActive(true);
            }
        }

    }
}
