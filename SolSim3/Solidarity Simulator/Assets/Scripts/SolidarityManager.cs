using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolidarityManager : MonoBehaviour {

    public int solidarity;
    public TextMeshProUGUI textDisplay;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        textDisplay.text = "Solidarity: " + solidarity;
	
	}
}
