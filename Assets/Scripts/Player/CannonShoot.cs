using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20;
    public float bulletDestroyTime = 5;

    void OnShoot()
    {
        GameObject Clone;

        Clone = (Instantiate(bulletPrefab, transform.position, transform.rotation)) as GameObject;
        Clone.GetComponent<Transform>().parent = null;
        Clone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3(0, bulletSpeed, 0));
        Debug.Log("Bullet has been found");
        StartCoroutine(DestroyBullet(Clone));
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OnShoot();
	}

    IEnumerator DestroyBullet(Object bullet)
    {
        yield return new WaitForSecondsRealtime(bulletDestroyTime);
        Destroy(bullet);
    }
}
