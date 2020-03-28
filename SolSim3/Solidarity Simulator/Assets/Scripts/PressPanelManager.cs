using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPanelManager : MonoBehaviour {

    public GameObject waterCooler;
    public GameObject button;

    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    void Update ()
    {
        if (waterCooler.GetComponent<InteractableManager>().primed == true || button.GetComponent<InteractableManager>().primed == true)
        {
            GetComponent<Canvas>().enabled = true;
        }
        else
        {
            GetComponent<Canvas>().enabled = false;
        }
	}
}
