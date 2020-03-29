using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMiddleTriggerUp : MonoBehaviour
{
    public GameObject middleElevator;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (middleElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            middleElevator.transform.position = middleElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
    }
}