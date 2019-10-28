using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStuff : MonoBehaviour
{

    GameObject stars;
    UnityEngine.Vector3 position;
    public GameObject fpc;

    private void Start()
    {
        fpc = GameObject.Find("FPSController");
        stars = GameObject.Find("PhotoHintFX");
    }

    void OnTriggerEnter(Collider coll)
    {
        if(fpc == null)
        {
            fpc = GameObject.Find("FPSController");
            stars = GameObject.Find("PhotoHintFX");
        }
        position = fpc.transform.position + (fpc.transform.forward * 3);
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
