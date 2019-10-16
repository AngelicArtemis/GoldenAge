using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShutter : MonoBehaviour
{
    public GameObject[] shutters;


    public void startAni()
    {
        shutters[0].SetActive(true);
        StartCoroutine(shutter());
        shutters[12].SetActive(false);
    }


    IEnumerator shutter()
    {
        for (int i = 1; i < shutters.Length; i++)
        {
            //yield return new WaitForEndOfFrame();
            yield return new WaitForSeconds(0.01f); //testing purposes
            shutters[i].SetActive(true);
            shutters[i - 1].SetActive(false);
            if(i == 12)
            {
                //yield return new WaitForEndOfFrame();
                yield return new WaitForSeconds(0.01f); //testing purposes
                shutters[12].SetActive(false);
            }
        }
        
    }
}
