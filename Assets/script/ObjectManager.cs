using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject descBox;
    public GameObject descUI;

    public void displayODesc(InteractableObjects interactableObject, Vector3 objectPosition)
    {
        descBox.SetActive(true);
        descUI.transform.Find("Name Text").GetComponent<UnityEngine.UI.Text>().text = interactableObject.oName;
        descUI.transform.Find("Desc Text").GetComponent<UnityEngine.UI.Text>().text = interactableObject.description;

        //descbox always above the object
        Debug.Log(objectPosition);
        Vector3 targetPosition = objectPosition;
        targetPosition += transform.forward;
        Debug.Log(targetPosition);
        descBox.transform.position = targetPosition;
        
    }

    public void endDisplay()
    {
        descBox.SetActive(false);
    }
}
