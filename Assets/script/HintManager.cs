using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    //chuck this into the collider game object.
    //complayer playerTouch to collider position
    //if (y2-y1) < 0, glow above
    //if (x2-x1) < 0, glow right (glow right means you need to look right)
    //player is always x2/y2

    public GameObject playerTouch;
    Vector3 playerTouchPosition = new Vector3();
    Vector3 colliderPosition = new Vector3();

    private void Start()
    {
        playerTouchPosition = playerTouch.transform.position;
        colliderPosition = gameObject.transform.position; 
    }
    private void Update()
    {
        playerTouchPosition = playerTouch.transform.position;
    }
}
