using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverUIButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject buttonStuff;

    /*
    public void OnMouseOver()
    {
        Debug.Log("Here");
        buttonStuff.SetActive(true);
    }

    public void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        buttonStuff.SetActive(false);
    }
    */

    /*
public void OnMouseOver()
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

    if (hit.collider != null && hit.collider.transform == this.transform)
    {
        // raycast hit this gameobject
        Debug.Log("im not sure what im doing now");
    }
}
*/



    
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
