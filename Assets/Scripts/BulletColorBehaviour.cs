using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColorBehaviour : MonoBehaviour {

    public int colorType;

    private Collider2D thisCollider;
    public GameObject bullet;
    public ParticleSystem explode;

	// Use this for initialization
	void Start ()
    {
        thisCollider = GetComponentInChildren<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided!");

        if (collision.gameObject.GetComponent<EnemyColorBehaviour>())
            if (collision.gameObject.GetComponent<EnemyColorBehaviour>().colorType == colorType)
            {
                Destroy(collision.gameObject);
                gameObject.GetComponent<BulletParticleSystem>().trail.emissionRate = 0;
                Destroy(bullet);
                Destroy(gameObject, 1);
                explode.transform.parent = null;
                explode.Play();
                Destroy(explode.gameObject, 1);
            }
    }
}
