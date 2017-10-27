using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider health;
    public GameObject Wall;
    public GameObject Enemy;

    public void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
