using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStuff : MonoBehaviour
{

    private bool playStars = false;
    public GameObject stars;
    public UnityEngine.Vector3 position; //put in the position through inspector

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
