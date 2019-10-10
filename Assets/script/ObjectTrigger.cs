using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    public bool nearObject;
    public bool cameraMode;
    bool displaying;

    public InteractableObjects oDesc;

    void Update()
    {
        if(cameraMode && nearObject)
        {
            //send odesc to manager
            //displays object description
            displaying = true;
            FindObjectOfType<ObjectManager>().displayODesc(oDesc, this.gameObject.transform.position);
        }
        if(displaying)
        {
            if(!cameraMode || !nearObject)
            {
                //ends display object discreption
                displaying = false;
                FindObjectOfType<ObjectManager>().endDisplay();
            }
        }
        
    }

    public void setCameraMode(bool camera) //call this from screen capture manager 
    {
       
        cameraMode = camera;
        Debug.Log("camera:" + camera);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "playerTouch")
        {
            nearObject = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "playerTouch")
        { 
            nearObject = false;
        }
    }
}
