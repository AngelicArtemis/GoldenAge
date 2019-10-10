using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = player.transform.position - this.gameObject.transform.position;
        targetDir.y = 0;
        Quaternion rotate = Quaternion.LookRotation(targetDir);
        transform.rotation = rotate;
    }
}
