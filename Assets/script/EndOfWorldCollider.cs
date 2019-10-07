using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfWorldCollider : MonoBehaviour
{

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.name == "playerTouch")
        {
           //you reached the end woo now stop
        }
    }
}
