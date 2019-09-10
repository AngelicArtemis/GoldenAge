using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStuff : MonoBehaviour
{

    private bool playStars = false;
    GameObject stars;
    UnityEngine.Vector3 position;
    public GameObject fpc;

    private void Start()
    {
        //fpc = GameObject.Find("FPSController");
        stars = GameObject.Find("PhotoHintFX");
    }

    private void Update()
    {
        position = fpc.transform.position;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Debug.Log("hewwo?am i in the circle?");
            Explode();
        }
    }
    void Explode()
    {
        GameObject starsEffect = Instantiate(stars, position, Quaternion.identity);
        starsEffect.GetComponentInChildren<ParticleSystem>().Play();
        //Destroy(starsEffect);
    }

}
