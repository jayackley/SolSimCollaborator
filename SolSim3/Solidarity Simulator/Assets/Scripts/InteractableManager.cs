using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour {

    public GameObject rightElevator;
    public GameObject buttonInstruction;
    public bool primed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is BoxCollider2D && collision.gameObject.name == "PlayerObject")
        {
            primed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        primed = false;
    }

    public void Pour()
    {
        if (primed == true)
        {
            GetComponent<Animator>().SetTrigger("pour");
        }
        if (buttonInstruction.activeSelf == true)
        {
            buttonInstruction.SetActive(false);
        }
    }
    public void TriggerElevator()
    {
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown=="down")
        {
            rightElevator.GetComponent<ElevatorManager>().goingUp = true;
        }
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            rightElevator.GetComponent<ElevatorManager>().goingDown = true;
        }
    }

}
