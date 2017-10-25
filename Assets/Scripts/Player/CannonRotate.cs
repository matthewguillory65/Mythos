using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotate : MonoBehaviour {

    public float rotateSpeed = 1;


    private Transform cannon;

	// Use this for initialization
	void Start ()
    {
        cannon = GameObject.Find("Cannon").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        cannon.Rotate(new Vector3(0, 0,-Input.GetAxis("Horizontal")*rotateSpeed));
        if (cannon.localRotation.eulerAngles.z > 160 || cannon.localRotation.eulerAngles.z < 20)
            cannon.Rotate(new Vector3(0,0,Input.GetAxis("Horizontal") * rotateSpeed));
    }
}
