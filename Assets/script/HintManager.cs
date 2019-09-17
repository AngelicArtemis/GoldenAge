using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    //chuck this into the collider game object.
    //complayer playerTouch to collider position

    /*  
     *  public Transform target;

        void Update()
        {
            Vector3 targetDir = target.position - transform.position;
            Vector3 forward = transform.forward;
            float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
            if (angle < -5.0F)      //this is an allowance of 5 degree deviation lol
                print("turn left");
            else if (angle > 5.0F)
                print("turn right");
            else
                print("forward");
        }
     */

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
