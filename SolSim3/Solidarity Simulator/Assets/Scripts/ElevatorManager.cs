﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorManager : MonoBehaviour {

    public Vector3 elevatorTop;
    public Vector3 elevatorBottom;
    public GameObject walls;
    public string upOrDown;
    public float speed;
    public bool goingUp;
    public bool goingDown;

	void Start () 
    {
        upOrDown = "up";
        transform.position = elevatorTop;
        goingDown = true;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is CapsuleCollider2D && upOrDown == "down")
        {
            StartCoroutine("Elevate");
            upOrDown = "";
            walls.SetActive(true);
        }
        else if (collision is CapsuleCollider2D && upOrDown == "up")
        {
            StartCoroutine("Delevate");
            upOrDown = "";
            walls.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () 
    {
        if (goingUp == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorTop, speed * Time.deltaTime);
        }
        if (goingDown == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorBottom, speed * Time.deltaTime);
        }
        if (transform.position.y > (elevatorTop.y-0.1))
        {
            goingUp = false;
            upOrDown = "up";
        }
        if (transform.position.y < (elevatorBottom.y + 0.1))
        {
            goingDown = false;
            upOrDown = "down";
        }
    }

    public IEnumerator Elevate()
    {
        yield return new WaitForSeconds(Random.Range(.5f, 1.5f));
        goingUp = true;
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
    }
    IEnumerator Delevate()
    {
        yield return new WaitForSeconds(Random.Range(.5f, 1.5f));
        goingDown = true;
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
    }
}