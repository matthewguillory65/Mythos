using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColorBehaviour : MonoBehaviour {

    public int colorType;
    public GameObject bullet;
    public ParticleSystem trailParticle;
    public ParticleSystem explode;
    public GameObject pointLight;

    private Collider2D thisCollider;

    void setColor()
    {
        switch(colorType)
        {
            case 0:
                pointLight.GetComponent<Light>().color = new Color(1, 0.4f, 0.6f);
                explode.startColor = new Color(1, 0.4f, 0.6f);
                trailParticle.startColor = new Color(1, 0.4f, 0.6f);
                break;
            case 1:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 1, 0.7f);
                explode.startColor = new Color(0.3f, 1, 0.7f);
                trailParticle.startColor = new Color(0.3f, 1, 0.7f);
                break;
            case 2:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 0.6f, 1);
                explode.startColor = new Color(0.3f, 0.8f, 1);
                trailParticle.startColor = new Color(0.3f, 0.8f, 1);
                break;
        }
    }

	// Use this for initialization
	void Start ()
    {
        thisCollider = GetComponentInChildren<Collider2D>();
        setColor();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void explodeBullet()
    {
        gameObject.GetComponent<BulletParticleSystem>().trail.emissionRate = 0;
        Destroy(bullet);
        Destroy(gameObject, 1);
        explode.transform.parent = null;
        explode.Play();
        Destroy(explode.gameObject, 1);
        Destroy(pointLight);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided!");

        if (collision.gameObject.GetComponent<EnemyColorBehaviour>())
            if (collision.gameObject.GetComponent<EnemyColorBehaviour>().colorType == colorType)
            {
                Destroy(collision.gameObject);
                explodeBullet();
            }
        if (collision.gameObject.tag == "Back")
            {
                explodeBullet();
            }
    }
}
