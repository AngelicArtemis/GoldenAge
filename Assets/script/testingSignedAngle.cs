using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingSignedAngle : MonoBehaviour
{
    public GameObject sphere;
    Vector3 spherePosition;
    public GameObject cube; //the cube is the one mirror 
    Vector3 cubePosition;
    public GameObject sphere2;
    Vector3 sphere2Position;

    private void Start()
    {
        spherePosition = sphere.transform.position;
        cubePosition = cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        spherePosition = sphere.transform.position;
        cubePosition = cube.transform.position;



        Vector3 targetDir = spherePosition - cubePosition;
        Vector3 forward = cube.transform.forward;
        float angle = Vector3.SignedAngle(targetDir, forward, new Vector3(0.0f,1,0.0f));

        sphere2.transform.position = cubePosition - targetDir;
        sphere2Position = sphere2.transform.position;
        sphere2Position.x += 2*targetDir.x;
        //sphere2Position.y = targetDir.y
        sphere2.transform.position = sphere2Position;



        if (Input.GetKey("b"))
        Debug.Log(angle);
        //Quaternion rotateangle = Quaternion.Euler(0f, 0f, 90f);

        Debug.DrawLine(spherePosition, cubePosition, Color.blue);
        Debug.DrawRay(cubePosition, targetDir, Color.magenta);

        Debug.DrawRay(cubePosition, forward, Color.cyan);
        Debug.DrawRay(spherePosition, forward,Color.red);     //this one fucking works
    }
}
