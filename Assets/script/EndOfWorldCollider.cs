using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfWorldCollider : MonoBehaviour
{
    public GameObject DoNotGoOut;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.name == "playerTouch")
        {
            //you reached the end woo now stop
            DoNotGoOut.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "playerTouch")
        {
            DoNotGoOut.SetActive(false);
        }
    }
}
