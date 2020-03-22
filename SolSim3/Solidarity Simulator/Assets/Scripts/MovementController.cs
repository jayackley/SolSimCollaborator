using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpVelocity = 10f;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRenderer;
    public GameObject playerObject;
    public bool diagonal;
    public AudioClip jump;
    public AudioClip steps;
    AudioSource sound;
    public float Volume;
    public bool footSteps;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            GetComponent<Animator>().SetBool("isjumping", true);
            sound.PlayOneShot(jump, Volume);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", true);
            footSteps = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", true);
            footSteps = true;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("isjumping", false);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", false);
            GetComponent<Animator>().SetBool("isjumping", false);
            footSteps = false;
        }

        bool flipSprite = (spriteRenderer.flipX ? (rigidbody2d.velocity.x < 0.0f) : (rigidbody2d.velocity.x > 0.0f));

        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (footSteps == true && sound.isPlaying == false)
        {
            sound.loop = true;
            sound.Play();
        }
        if (footSteps == false && sound.isPlaying == false)
        {
            sound.loop = false;
            sound.Stop();
        }
        else
        {
            sound.loop = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diagonal")
        {
            diagonal = true;
            playerObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 30);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diagonal")
        {
            diagonal = true;
            playerObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

