using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public Canvas Pause;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.enabled = true;
        }
    }
}
