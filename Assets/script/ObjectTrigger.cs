using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    public bool nearObject;
    bool displaying;

    public InteractableObjects oDesc;

    void Update()
    {
        if(nearObject)
        {
            //send odesc to manager
            //displays object description
            displaying = true;
            FindObjectOfType<ObjectManager>().displayODesc(oDesc, this.gameObject.transform.position);
        }
        if(displaying)
        {
            if(!nearObject)
            {
                //ends display object discreption
                displaying = false;
                FindObjectOfType<ObjectManager>().endDisplay();
            }
        }
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            nearObject = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            nearObject = false;
        }
    }
}
