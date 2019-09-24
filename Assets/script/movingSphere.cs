using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingSphere : MonoBehaviour
{
    private void Start()
    {
        transform.TransformPoint(Vector3.zero);
    }
    void Update()
    {
        if(Input.GetKey("i"))
        {
            Debug.Log("i");
            moveUp();
        }
        if (Input.GetKey("k"))
        {
            moveDown();
        }
        if (Input.GetKey("l"))
        {
            moveRight();
        }
        if (Input.GetKey("j"))
        {
            moveLeft();
        }

    }

    void moveRight()
    {
        this.gameObject.transform.Translate(Vector3.right);

    }

    void moveLeft()
    {
        this.gameObject.transform.Translate(Vector3.left);

    }

    void moveUp()
    {
        this.gameObject.transform.Translate(Vector3.up);


    }

    void moveDown()
    {
        this.gameObject.transform.Translate(Vector3.down);

    }
}
