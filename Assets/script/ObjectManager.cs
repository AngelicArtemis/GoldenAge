﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject descBox;
    public GameObject descUI;
    public bool cameraMode;

    public void displayODesc(InteractableObjects interactableObject, Vector3 objectPosition)
    {
        if (cameraMode)
        {
            descBox.SetActive(true);
            descUI.transform.Find("Name Text").GetComponent<UnityEngine.UI.Text>().text = interactableObject.oName;
            descUI.transform.Find("Desc Text").GetComponent<UnityEngine.UI.Text>().text = interactableObject.description;


            descBox.transform.position = objectPosition;
        }
        else
            endDisplay();
    }

    public void setCameraMode(bool camera) //call this from screen capture manager 
    {

        cameraMode = camera;
        Debug.Log("camera:" + camera);

    }

    public void endDisplay()
    {
        descBox.SetActive(false);
    }
}
