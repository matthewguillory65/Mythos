using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionBehavior : MonoBehaviour {

    public GameObject shot;
    public Transform shootPos;
    public float cooldown;
    public float decrement = 0.01f;
    public float xTarget;

	// Use this for initialization
	void Start ()
    {
        xTarget = Random.RandomRange(-2.5f, 2.5f);
        StartCoroutine(shootLoop());
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2((xTarget + 5) - (transform.position.x + 5), 0);
        if (transform.position.x + 5 <= xTarget + 5.1 && transform.position.x + 5 >= xTarget + 4.9)
            xTarget = Random.RandomRange(-2.5f, 2.5f);
    }

    void shoot()
    {
        var Clone = Instantiate(shot, shootPos);
    }

    IEnumerator shootLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown);
            shoot();
            if(cooldown > 1)
                cooldown -= decrement;
        }
    }
}
