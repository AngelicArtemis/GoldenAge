using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintSound : MonoBehaviour
{
    public GameObject hintBellSound;
    

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            hintBellSound.GetComponent<AudioSource>().Play();
        }
    }
}
