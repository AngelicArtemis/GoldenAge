using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfWorldCollider : MonoBehaviour
{
    public GameObject DoNotGoOut;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Player"))
        {
            //you reached the end woo now stop
            DoNotGoOut.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            DoNotGoOut.SetActive(false);
        }
    }
}
