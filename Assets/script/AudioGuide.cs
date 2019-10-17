using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGuide : MonoBehaviour
{
    public GameObject[] guides;
    public void playThis(int num)
    {
        /*
         * 0 = tori
         * 1 = kinkakuji
         * 2 = tower
         * 3 = station
         * 4 = market
         */
        guides[num].GetComponent<AudioSource>().Play();
    }

}
