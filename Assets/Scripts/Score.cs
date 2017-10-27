using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text score;
    private Rigidbody rb;
    public GameObject enemy;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void EnemyDestroyed(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy Dead"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        score.text = "Score:" + score.ToString();
        if(count >= 999)
        {
            score.text = "You win!";
        }
    }

	// Update is called once per frame
	void Update()
    {
		
	}
}
