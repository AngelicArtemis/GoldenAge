using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksDelay : MonoBehaviour
{
    public float waitTime;
    float timer;
    float actualWait;

    private void Start()
    {
        float actualWait = waitTime + 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= actualWait)
        {
            gameObject.GetComponent<ParticleSystem>().Play();

            timer = 0;
        }
    }
}
