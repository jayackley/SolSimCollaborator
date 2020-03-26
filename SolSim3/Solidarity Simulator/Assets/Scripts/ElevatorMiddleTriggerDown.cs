using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMiddleTriggerDown : MonoBehaviour
{
    public GameObject middleElevator;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (middleElevator.GetComponent<MiddleElevatorManager>().upOrDown == "up")
        {
            middleElevator.GetComponent<Animator>().SetTrigger("TriggerDown");
            middleElevator.GetComponent<Animator>().speed = 10;
        }
    }
}