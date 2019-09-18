using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    //chuck this into the collider game object.
    //complayer playerTouch to collider position




    public GameObject target; //DO NOT ASSIGN THIS IN INSPECTOR
    Vector3 playerPosition = new Vector3();
    Vector3 colliderPosition = new Vector3();
    GameObject glowHint;
    GameObject rightGlow,leftGlow,upGlow,downGlow;
    public bool glow;
    public bool trigger = false;
    bool inited = false;

    bool x = false;
    bool y = false;

    public void init()
    {
        //glowHint = GameObject.FindGameObjectWithTag("GlowHint");
        glowHint = GameObject.Find("GlowHint");
        leftGlow = glowHint.transform.GetChild(0).gameObject;
        rightGlow = glowHint.transform.GetChild(1).gameObject;
        upGlow = glowHint.transform.GetChild(2).gameObject;
        downGlow = glowHint.transform.GetChild(3).gameObject;
        inited = true;

    }

    private void Update()
    {
        if(target)
        {
            glowStuff();
        }

        if(!target && inited)
        {
            unglowStuff();
        }
        //maybe use vector 2d ? and then use the x and z coords as the 2d coords to make sure its only looking at left and right for angle
        //if((!target || !trigger) && inited)
        //{
        //    unglowStuff();
        //}
    }

    void glowStuff()
    {
        colliderPosition = target.transform.position;
        playerPosition = gameObject.transform.position;


        Vector3 targetDir = colliderPosition - playerPosition;
        Vector3 forward = transform.forward;
        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
        Debug.DrawRay(gameObject.transform.position, forward, Color.red);
        Debug.DrawLine(colliderPosition, playerPosition, Color.blue);
        //Debug.Log(angle);
        if (angle > 20.0F)
        {
            x = false;
            leftGlow.SetActive(true);
            rightGlow.SetActive(false);
            Debug.Log("look left");
        }
        else if (angle < -20.0F)
        {
            x = false;
            rightGlow.SetActive(true);
            leftGlow.SetActive(false);
            Debug.Log("look right");
        }

        if (angle < 20 && angle > -20)
        {
            rightGlow.SetActive(false);
            leftGlow.SetActive(false);
            x = true;
        }

        //the y axis
        float yAngle = Vector3.SignedAngle(targetDir, forward, Vector3.forward);
        Debug.DrawRay(gameObject.transform.position, forward, Color.red);
        Debug.DrawLine(colliderPosition, playerPosition, Color.blue);
        //Debug.Log(yAngle);
        if (angle > 20.0F)
        {
            y = false;
            downGlow.SetActive(false);
            upGlow.SetActive(true);
            Debug.Log("look up");
        }
        else if (yAngle < -20.0F)
        {
            y = false;
            downGlow.SetActive(true);
            upGlow.SetActive(false);
            Debug.Log("look down");
        }

        if (yAngle < 20 && yAngle > -20)
        {
            Debug.Log("y axis is right");
            y = true;
            upGlow.SetActive(false);
            downGlow.SetActive(false);
        }

        //if x and y is right 
        if (x && y)
        {
            target.GetComponentInParent<photoCollider>().playerLookingAtCollider = true;
        }

        if (!x || !y)
        {
            target.GetComponentInParent<photoCollider>().playerLookingAtCollider = false;
        }

    }

    public void unglowStuff()
    {
        rightGlow.SetActive(false);
        leftGlow.SetActive(false);
        upGlow.SetActive(false);
        downGlow.SetActive(false);
    }
}
