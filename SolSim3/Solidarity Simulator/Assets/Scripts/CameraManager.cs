using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour {

    public string whosFocus;
    public GameObject pcCam;
    public GameObject wrenchCam;
    public GameObject tempCam;
    public GameObject welderCam;
    public GameObject bigguyCam;
    public GameObject dataCam;
    public GameObject accountingCam;
    public GameObject managerCam;
    public GameObject orbCam;
    public GameObject corporateCam;
	
	void Start ()
    {
        whosFocus = "pc";
	}

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("0")))
        {
            whosFocus = "pc";
        }
        if (Event.current.Equals(Event.KeyboardEvent("1")))
        {
            whosFocus = "wrench";
        }
        if (Event.current.Equals(Event.KeyboardEvent("2")))
        {
            whosFocus = "temp";
        }
        if (Event.current.Equals(Event.KeyboardEvent("3")))
        {
            whosFocus = "welder";
        }
        if (Event.current.Equals(Event.KeyboardEvent("4")))
        {
            whosFocus = "bigguy";
        }
        if (Event.current.Equals(Event.KeyboardEvent("5")))
        {
            whosFocus = "data";
        }
        if (Event.current.Equals(Event.KeyboardEvent("6")))
        {
            whosFocus = "accounting";
        }
        if (Event.current.Equals(Event.KeyboardEvent("7")))
        {
            whosFocus = "manager";
        }
        if (Event.current.Equals(Event.KeyboardEvent("8")))
        {
            whosFocus = "orb";
        }
        if (Event.current.Equals(Event.KeyboardEvent("9")))
        {
            whosFocus = "corporate";
        }
    }
    void Update () 
    {
        if (whosFocus == "pc") 
        {
            pcCam.SetActive(true);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "wrench")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(true);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "temp")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(true);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "welder")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(true);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "bigguy")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(true);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "data")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(true);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "accounting")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(true);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "manager")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(true);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "orb")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(true);
            corporateCam.SetActive(false);
        }
        if (whosFocus == "corporate")
        {
            corporateCam.SetActive(true);
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
        }

    }
}
