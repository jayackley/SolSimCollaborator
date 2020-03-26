using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResponseManager : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public GameObject optionManager;
    public GameObject promptManager;


    void Update()
    {
        textDisplay.text = sentences[optionManager.GetComponent<OptionManager>().sentenceIndex];
    }

}
