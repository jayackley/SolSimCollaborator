using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoardManager : MonoBehaviour {
    public TextMeshProUGUI textDisplay;
    public int index;
    public string whosTalking;
    public string[] sentences;
    public float typingSpeed;
    public GameObject solidarityObject;
    public bool isTyping;
    public GameObject wrench;
    public GameObject temp;
    public GameObject welder;
    public GameObject bigGuy;
    public GameObject data;
    public GameObject accounting;
    public GameObject manager;
    public GameObject orb;
    public GameObject corporate;
    public GameObject mainCamera;
    public GameObject buttonInstruction;
    public bool primed;

    private void Start()
    {
        isTyping = false;
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
            textDisplay.text = "";
            StartCoroutine(Type());
    }
    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            isTyping = false;
        }
        else
        {
            isTyping = true;
        }

        if (isTyping == false)
        {
            primed = true;
        }
        else if (isTyping == true)
        {
            primed = false;
        }

        if (isTyping == true & whosTalking == "wrench")
        {
            wrench.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<Animator>().SetBool("IsTalking", true);

            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "temp")
        {
            temp.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;

            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "welder")
        {
            welder.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;

            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "bigguy")
        {
            bigGuy.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;

            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.06f;
        }
        else if (isTyping == true & whosTalking == "data")
        {
            data.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;

            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "accounting")
        {
            accounting.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;

            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "manager")
        {
            manager.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;

            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "orb")
        {
            orb.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;

            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;
        }
        else if (isTyping == true & whosTalking == "corporate")
        {
            corporate.GetComponent<AudioSource>().volume = 1;
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;

        }
        else if (isTyping == false){
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.02f;

            wrench.GetComponent<Animator>().SetBool("IsTalking", false);

        }

        if (index == 1 || index == 12 || index == 21)
        {
            whosTalking = "orb";
            mainCamera.GetComponent<CameraManager>().whosFocus = "orb";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 255);
        }
        else if (index == 2 || index == 16 || index == 18 || index == 23 || index == 24)
        {
            whosTalking = "accounting";
            mainCamera.GetComponent<CameraManager>().whosFocus = "accounting";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 148, 0, 255);


        }
        else if (index == 0 || index == 3 || index == 6 || index == 14 || index == 19)
        {
            whosTalking = "corporate";
            mainCamera.GetComponent<CameraManager>().whosFocus = "corporate";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 55, 0, 255);

        }
        else if (index == 4 || index == 31 || index == 32)
        {
            whosTalking = "bigguy";
            mainCamera.GetComponent<CameraManager>().whosFocus = "bigguy";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(16, 83, 73, 255);

        }
        else if (index == 5 || index == 17 || index == 27 || index == 28)
        {
            whosTalking = "welder";
            mainCamera.GetComponent<CameraManager>().whosFocus = "welder";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 195, 0, 255);

        }
        else if (index == 7)
        {
            whosTalking = "manager";
            mainCamera.GetComponent<CameraManager>().whosFocus = "manager";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(127, 5, 40, 255);

        }
        else if (index == 8 || index == 10 || index == 13|| index == 15 || index == 20 || index == 22)
        {
            whosTalking = "wrench";
            mainCamera.GetComponent<CameraManager>().whosFocus = "wrench";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(101, 100, 219, 255);

        }
        else if (index == 9 || index == 25 || index == 26)
        {
            whosTalking = "data";
            mainCamera.GetComponent<CameraManager>().whosFocus = "data";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255,255,255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255);

        }

        else if (index == 11 || index == 29 || index == 30)
        {
            whosTalking = "temp";
            mainCamera.GetComponent<CameraManager>().whosFocus = "temp";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(137, 210, 220, 255);
        }
    }

    private void OnGUI()
    {
        if (index == 22 && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 30 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 23;
            NextSentence();
        }

        else if (index == 22 && solidarityObject.GetComponent<SolidarityManager>().solidarity < 30 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 24;
            NextSentence();
        }

        else if ((index == 23 || index == 24) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 50 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 25;
            NextSentence();
        }

        else if ((index == 23 || index == 24) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 50 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 26;
            NextSentence();
        }

        else if ((index == 25 || index == 26) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 70 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 27;
            NextSentence();
        }

        else if ((index == 25 || index == 26) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 70 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 28;
            NextSentence();
        }
        else if ((index == 27 || index == 28) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 90 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 29;
            NextSentence();
        }

        else if ((index == 27 || index == 28) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 90 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 30;
            NextSentence();
        }
        else if ((index == 29 || index == 30) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 110 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 31;
            NextSentence();
        }

        else if ((index == 29 || index == 30) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 110 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 32;
            NextSentence();
        }
        else if ((index == 31 || index == 32) && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 33;
            NextSentence();
        }
        else if (Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index += 1;
            NextSentence();
        }

        if (buttonInstruction.activeSelf == true && Event.current.Equals(Event.KeyboardEvent("return")))
        {
            buttonInstruction.SetActive(false);
        }
    }

        
    }
