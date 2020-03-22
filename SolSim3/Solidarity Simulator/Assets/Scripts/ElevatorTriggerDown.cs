using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerDown : MonoBehaviour
{
    public GameObject rightElevator;
    public GameObject leftElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<RightElevatorManager>().upOrDown == "up")
        {
            rightElevator.GetComponent<Animator>().SetTrigger("TriggerDown");
            rightElevator.GetComponent<Animator>().speed = 10;
        }
        if (leftElevator.GetComponent<LeftElevatorManager>().upOrDown == "up")
        {
            leftElevator.GetComponent<Animator>().SetTrigger("TriggerDown");
            leftElevator.GetComponent<Animator>().speed = 10;
        }
    }
}