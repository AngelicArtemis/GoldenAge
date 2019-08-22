using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverUIButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject buttonStuff;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Here"); 
        buttonStuff.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        buttonStuff.SetActive(false);
    }

    
}
