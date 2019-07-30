using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(photoTimerFunc());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator photoTimerFunc() {

        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
