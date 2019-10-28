using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGuideTrigger : MonoBehaviour
{
    public int num;

    /*
    * 0 = tori
    * 1 = kinkakuji
    * 2 = tower
    * 3 = station
    * 4 = market
    */

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioGuide>().playThis(num);
            //Debug.Log("trigger!");
            Destroy(gameObject);
        }
    }
}
