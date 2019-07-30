using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoCollider : MonoBehaviour
{ 
    public bool playerClose = false;
    public bool playerLookingAtCollider = false;
    private int checkPhotoTaken = 0;
    public static int photoCollected = 0;
    public GameObject photo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (playerLookingAtCollider == true && playerClose == true && checkPhotoTaken == 0)
            {
                checkPhotoTaken = 1;
                photoCollected = photoCollected + 1;
                photo.SetActive(true);
                Debug.Log("photoActive = true");
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = true;
            Debug.Log("playerClose = true");
        }
        if(collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = true;
            Debug.Log("playerLookingAtCollider = true");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerClose = false;
            Debug.Log("playerClose = false");
        }
        if (collider.gameObject.name == "playerTouch")
        {
            playerLookingAtCollider = false;
            Debug.Log("playerLookingAtCollider = false");
        }
    }
}
