using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLv : MonoBehaviour {
    private int currentLevel = 0;
    public GameObject level0, level1, level2;
    //public GameObject playerObj;

    // Use this for initialization
    void Start() {
        level2.SetActive(false);
        //level3.SetActive(false);
        level1.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.name == "playerTouch")
        {
            if (currentLevel == 0)
            {
                level0.SetActive(false);
                level1.SetActive(true);
                level2.SetActive(false);
                //level3.SetActive(false);
                Debug.Log("Lv1 activated");
                currentLevel++;
            } else if (currentLevel == 1 && photoCollider.photoCollected == 3)
            {
                level0.SetActive(false);
                level1.SetActive(false);
                level2.SetActive(true);
                Debug.Log("Lv2 activated");
                currentLevel++;
            }
        }
        */
    }

    // Update is called once per frame
    void Update () {
		
	}
}
