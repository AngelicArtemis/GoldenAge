using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksDelay : MonoBehaviour
{
    public float waitTime;
    float timer;
    ParticleSystem firework;

    private void Start()
    {
        firework = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= waitTime)
        {
            if (!firework.isPlaying)
            {
                firework.Play();
                var emmision = firework.emission;
                emmision.enabled = true;
                timer = 0;
            }
        }

    }
}
