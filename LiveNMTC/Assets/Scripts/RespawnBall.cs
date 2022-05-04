using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RespawnBall : MonoBehaviour
{
    public GameObject ball;
    public Camera cam;

	public void Spawn()
	{
        try
        {
        Vector3 position = new Vector3(-0.004f, -0.118f, 0.374f);
        Vector3 cameraPosition = new Vector3(-0.004f, -0.118f, 0.374f);
        cameraPosition = cam.transform.position;
        Debug.Log(cameraPosition);

/*
        GameObject newBall = Instantiate (ball, position+cameraPosition, Quaternion.AngleAxis(180, Vector3.up)) as GameObject;
        newBall.transform.parent = Camera.main.transform;
*/
        //GameObject newBall = Instantiate (ball, position+cameraPosition, Quaternion.identity) as GameObject;
        //newBall.transform.localPosition = position+cameraPosition;
        //newBall.transform.SetParent(cam);
        //newBall.transform.parent = cam.transform;

        //methode 2
        GameObject newBall = Instantiate (ball, position+cameraPosition, Quaternion.identity) as GameObject;
        newBall.transform.parent = Camera.main.transform;

       Debug.Log(newBall.transform.position);

        }
        catch(Exception e){};
    
	}
}
