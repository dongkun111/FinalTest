using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float upForce;
    Rigidbody2D rb2d;
    bool rbDoor;
    GameController d_getcore;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        d_getcore = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJumpPressed = Input.GetMouseButtonDown(0);
        if (isJumpPressed && rbDoor)
        {
            rb2d.AddForce(Vector2.up * upForce);
            rbDoor = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            rbDoor = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Danger"))
        {
            
            d_getcore.SetGameoverState(true);
            Debug.Log("Over Game");
        }
    }

}
