using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftElevatorManager : MonoBehaviour
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
        if (collision is CapsuleCollider2D && upOrDown == "down")
        {
            animator.SetTrigger("TriggerUp");
            walls.SetActive(true);
        }
        else if (collision is CapsuleCollider2D && upOrDown == "up")
        {
            animator.SetTrigger("TriggerDown");
            walls.SetActive(true);
        }
    }

    public void Update()
    {
        if (transform.localPosition.y >= -.16 && upOrDown == "down") 
        {
            animator.speed = 1;
            walls.SetActive(false);
            upOrDown = "up";
        }
        else if (transform.position.y <= -7.23 && upOrDown == "up")
        {
            animator.speed = 1;
            walls.SetActive(false);
            upOrDown = "down";
        }
    }
}

