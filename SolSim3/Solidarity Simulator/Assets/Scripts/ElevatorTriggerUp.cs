using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerUp : MonoBehaviour
{
    public GameObject rightElevator;
    public GameObject leftElevator;
    public GameObject middleElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<RightElevatorManager>().upOrDown == "down")
        {
            rightElevator.GetComponent<Animator>().SetTrigger("TriggerUp");
            rightElevator.GetComponent<Animator>().speed = 10;
            rightElevator.GetComponent<RightElevatorManager>().upOrDown = "up";
        }
        if (leftElevator.GetComponent<LeftElevatorManager>().upOrDown == "down")
        {
            leftElevator.GetComponent<Animator>().SetTrigger("TriggerUp");
            leftElevator.GetComponent<Animator>().speed = 10; 
            leftElevator.GetComponent<LeftElevatorManager>().upOrDown = "up";
        }
        if (middleElevator.GetComponent<MiddleElevatorManager>().upOrDown == "down")
        {
            middleElevator.GetComponent<Animator>().SetTrigger("TriggerUp");
            middleElevator.GetComponent<Animator>().speed = 10;
        }
    }
}