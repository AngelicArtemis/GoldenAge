using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPagesScalling : MonoBehaviour
{

    private void Start()
    {
        var UIPage = gameObject.transform as RectTransform;
        UIPage.sizeDelta = new Vector2(Screen.width * 0.7f, Screen.height * 0.7f);
    }
}
