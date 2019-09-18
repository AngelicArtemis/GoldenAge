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
            FindObjectOfType<HintManager>().init();
            FindObjectOfType<HintManager>().target = GetComponentInChildren<SphereCollider>().gameObject;
            Explode();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        FindObjectOfType<HintManager>().target = null;
    }
    void Explode()
    {
        GameObject starsEffect = Instantiate(stars, position, Quaternion.identity);
        starsEffect.GetComponentInChildren<ParticleSystem>().Play();
        //Destroy(starsEffect);
    }

}
