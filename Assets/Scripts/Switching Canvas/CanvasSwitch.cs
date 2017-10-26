using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasSwitch : MonoBehaviour {

    public Canvas mainMenuCanvas;
    //public Canvas optionsCanvas;
    public Canvas controlsCanvas;

    //public void MaintoOptions()
    //{
    //    mainMenuCanvas.enabled = false;
    //    optionsCanvas.enabled = true;
    //}

    //public void OptionstoMain()
    //{
    //    mainMenuCanvas.enabled = true;
    //    optionsCanvas.enabled = false;
    //}

    public void MaintoControls()
    {
        mainMenuCanvas.enabled = false;
        controlsCanvas.enabled = true;
    }

    public void ControlstoMain()
    {
        mainMenuCanvas.enabled = true;
        controlsCanvas.enabled = false;
    }
}
