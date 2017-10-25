using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float bulletSpeed = 1;

    void OnShoot()
    {
        GameObject Clone;

        Clone = (Instantiate(bulletPrefab, transform.position, transform.rotation)) as GameObject;
        Debug.Log("Bullet has been found");
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space));
            OnShoot();
	}
}
