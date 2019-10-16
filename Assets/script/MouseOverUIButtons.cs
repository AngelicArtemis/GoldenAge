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
        buttonStuff.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonStuff.SetActive(false);
    }



}
