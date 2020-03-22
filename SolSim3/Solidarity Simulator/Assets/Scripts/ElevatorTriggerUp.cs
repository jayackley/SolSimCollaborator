using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerUp : MonoBehaviour
{
    public GameObject rightElevator;
    public GameObject leftElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<RightElevatorManager>().upOrDown == "down")
        {
            rightElevator.GetComponent<Animator>().SetTrigger("TriggerUp");
            rightElevator.GetComponent<Animator>().speed = 10;
        }
        if (leftElevator.GetComponent<LeftElevatorManager>().upOrDown == "down")
        {
            leftElevator.GetComponent<Animator>().SetTrigger("TriggerUp");
            leftElevator.GetComponent<Animator>().speed = 10;
        }
    }
}