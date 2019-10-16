using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGuide : MonoBehaviour
{
    bool played = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(!played)
        {
            gameObject.GetComponent<AudioSource>().Play();
            played = true;
        }
    }

}
