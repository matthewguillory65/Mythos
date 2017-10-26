using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleSystem : MonoBehaviour {

    public GameObject bullet;
    public ParticleSystem trail;
    public float timeUntilDestroy = 3;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(loopStop());
        Destroy(bullet, timeUntilDestroy);
        Destroy(gameObject, timeUntilDestroy + 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator loopStop()
    {
        yield return new WaitForSeconds(timeUntilDestroy);
        trail.emissionRate = 0;
    }
}