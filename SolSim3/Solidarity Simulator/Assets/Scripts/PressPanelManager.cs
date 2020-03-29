using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPanelManager : MonoBehaviour {

    public GameObject waterCooler;
    public GameObject button;
    public GameObject boardManager;
    public GameObject primedIndicator;

    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
        primedIndicator.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update ()
    {
        if (waterCooler.GetComponent<InteractableManager>().primed == true || button.GetComponent<InteractableManager>().primed == true || boardManager.GetComponent<BoardManager>().primed == true)
        {
            GetComponent<Canvas>().enabled = true;
            primedIndicator.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<Canvas>().enabled = false;
            primedIndicator.GetComponent<SpriteRenderer>().enabled = false;
        }
	}
}
