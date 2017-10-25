using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleSystem : MonoBehaviour {

    public ParticleSystem trail;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnDestroy()
    {
        trail.transform.parent = null;
    }
}