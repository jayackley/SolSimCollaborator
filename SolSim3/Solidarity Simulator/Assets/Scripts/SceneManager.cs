using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public GameObject uiCanvas;
    public int convoCounter;

    void Start()
    {
        foreach (GameObject floor in GameObject.FindGameObjectsWithTag("Floor"))
        {
            floor.GetComponent<SpriteRenderer>().enabled = false;
            uiCanvas.GetComponent<Canvas>().enabled = false;
        }
        foreach (GameObject floor in GameObject.FindGameObjectsWithTag("Diagonal"))
        {
            floor.GetComponent<SpriteRenderer>().enabled = false;
            uiCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
