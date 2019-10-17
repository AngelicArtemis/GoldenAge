using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditToggle : MonoBehaviour
{
    public GameObject credit2;
    public GameObject next;
    public GameObject prev;

    public void nextPage()
    {
        prev.SetActive(true);
        credit2.SetActive(true);
        next.SetActive(false);
    }

    public void prevPage()
    {
        next.SetActive(true);
        credit2.SetActive(false);
        prev.SetActive(false);
    }
}
