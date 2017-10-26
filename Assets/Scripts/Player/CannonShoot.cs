using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20;
    public float cooldown = 1;

    public Light pointLight;

    private int colorType;
    private bool canShoot = true;
    public double multiplier = 1;

    private void Start()
    {
        colorType = Random.RandomRange(0, 3);

        switch (colorType)
        {
            case 0:
                pointLight.GetComponent<Light>().color = new Color(1, 0.4f, 0.6f);
                break;
            case 1:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 1, 0.7f);
                break;
            case 2:
                pointLight.GetComponent<Light>().color = new Color(0.3f, 0.6f, 1);
                break;
        }
    }

    void OnShoot()
    {
        if (canShoot)
        {
            GameObject Clone;

            Clone = (Instantiate(bulletPrefab, transform.position, transform.rotation)) as GameObject;
            Clone.GetComponent<BulletColorBehaviour>().colorType = colorType;
            Clone.GetComponent<Transform>().parent = null;
            Clone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3(0, (float)(bulletSpeed * multiplier), 0));

            colorType = Random.RandomRange(0, 3);
            switch (colorType)
            {
                case 0:
                    pointLight.GetComponent<Light>().color = new Color(1, 0.4f, 0.6f);
                    break;
                case 1:
                    pointLight.GetComponent<Light>().color = new Color(0.3f, 1, 0.7f);
                    break;
                case 2:
                    pointLight.GetComponent<Light>().color = new Color(0.3f, 0.6f, 1);
                    break;
            }

            canShoot = false;
            StartCoroutine(shootWait());
        }

    }

	void Update ()
    {
        //if(Input.GetKeyDown(KeyCode.Space) && canShoot)
        if (Input.GetKey(KeyCode.Space) && multiplier <= 2.5 && canShoot)
        {
            transform.parent.GetComponentInChildren<Animator>().SetBool("SpaceDown", true);
            multiplier += 0.02;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.parent.GetComponentInChildren<Animator>().SetBool("SpaceDown", false);
            OnShoot();
            multiplier = 1;
        }
	}

    IEnumerator shootWait()
    {
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
