using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideArrows : MonoBehaviour
{
    public GameObject arrow1, arrow2;

    public void hide()
    {
        arrow1.SetActive(false);
        arrow2.SetActive(false);
    }
}
