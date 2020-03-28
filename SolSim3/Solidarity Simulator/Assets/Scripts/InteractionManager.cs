using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionManager : MonoBehaviour
{
    public bool dialogueVisible;
    public GameObject uiCanvas;
    public GameObject playerObject;
    public GameObject sceneManager;
    public GameObject promptPanel;
    public GameObject promptText;
    public GameObject optionManager;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject optionThree;
    public GameObject solidarityPanel;
    public string whosTalking;
    public GameObject wrench;
    public GameObject temp;
    public GameObject welder;
    public GameObject bigGuy;
    public GameObject data;
    public GameObject accounting;
    public GameObject manager;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Wrench" && playerObject.transform.position.x > wrench.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 0;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "wrench";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(101,100,219,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;

        }

        else if (collision.gameObject.name == "Wrench" && playerObject.transform.position.x < wrench.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 0;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "wrench";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(101, 100, 219, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
            playerObject.GetComponent<SpriteRenderer>().flipX = true;

        }

        else if (collision.gameObject.name == "Temp" && playerObject.transform.position.x > temp.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 11;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "temp";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(137, 210, 220,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
            playerObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        else if (collision.gameObject.name == "Temp" && playerObject.transform.position.x < temp.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 11;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "temp";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(137, 210, 220, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }

        else if (collision.gameObject.name == "Welder" && playerObject.transform.position.x > welder.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 21;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "welder";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 1, 219,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;

        }
        else if (collision.gameObject.name == "Welder" && playerObject.transform.position.x < welder.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 21;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "welder";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 1, 219, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;

        }
        else if (collision.gameObject.name == "BigGuy" && playerObject.transform.position.x > bigGuy.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 29;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "bigguy";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(16, 83, 73,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "BigGuy" && playerObject.transform.position.x < bigGuy.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 29;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "bigguy";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(16, 83, 73, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Data" && playerObject.transform.position.x > data.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 36;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "data";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Data" && playerObject.transform.position.x < data.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 36;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "data";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Accounting" && playerObject.transform.position.x > accounting.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 42;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "accounting";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 148, 0,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Accounting" && playerObject.transform.position.x < accounting.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 42;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "accounting";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 148, 0, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Manager" && playerObject.transform.position.x > manager.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 52;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "manager";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(127, 5, 40,255);
            promptPanel.transform.localPosition = new Vector3(-170, 126, 0);
            optionOne.transform.localPosition = new Vector3(221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(221, -50, 0);
            optionThree.transform.localPosition = new Vector3(221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(-242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
        else if (collision.gameObject.name == "Manager" && playerObject.transform.position.x < manager.transform.position.x)
        {
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            optionManager.GetComponent<OptionManager>().sentenceIndex = 52;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "manager";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(127, 5, 40, 255);
            promptPanel.transform.localPosition = new Vector3(170, 126, 0);
            optionOne.transform.localPosition = new Vector3(-221, 50, 0);
            optionTwo.transform.localPosition = new Vector3(-221, -50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -150, 0);
            solidarityPanel.transform.localPosition = new Vector3(242, -150, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 1;
        }
    }

    private void OnGUI()
    {

    }

    private void Update()
    {
        if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "wrench")
        {
            wrench.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "temp")
        {
            temp.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "welder")
        {
            welder.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "bigguy")
        {
            bigGuy.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "data")
        {
            data.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "accounting")
        {
            accounting.GetComponent<AudioSource>().volume = 1;
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "manager")
        {
            manager.GetComponent<AudioSource>().volume = 1;
        }
        else
        {
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
        }

        bool flipBigGuy = (bigGuy.GetComponent<SpriteRenderer>().flipX ? (playerObject.transform.position.x > bigGuy.transform.position.x) : (playerObject.transform.position.x < bigGuy.transform.position.x));

        if (flipBigGuy)
        {
            bigGuy.GetComponent<SpriteRenderer>().flipX = !bigGuy.GetComponent<SpriteRenderer>().flipX;
        }
    }
}