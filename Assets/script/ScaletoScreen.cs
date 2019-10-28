using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaletoScreen : MonoBehaviour
{

    private void OnEnable()
    {
        
        var size = gameObject.transform as RectTransform;
        size.sizeDelta = new Vector2(Screen.width, Screen.height);
    }
}
