using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightElevatorManager : MonoBehaviour
{
    public GameObject walls;
    public Animator animator;
    public string upOrDown;

    public void Start()
    {
        upOrDown = "down";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (upOrDown == "down")
        {
            animator.SetTrigger("TriggerUp");
            walls.SetActive(true);
        }
        else if (upOrDown == "up")
        {
            animator.SetTrigger("TriggerDown");
            walls.SetActive(true);
        }
    }

    public void Update()
    {
        if (transform.localPosition.y >= 7.84 && upOrDown == "down") 
        {
            animator.speed = 1;
            walls.SetActive(false);
            upOrDown = "up";
        }
        else if (transform.position.y <= -13.19 && upOrDown == "up")
        {
            animator.speed = 1;
            walls.SetActive(false);
            upOrDown = "down";
        }
    }
}

