using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControls : MonoBehaviour
{
    public float speed;

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveRight;
    public KeyCode moveLeft;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rb2d.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb2d.velocity = new Vector2(0f, speed * -1f);
        }
        else if (Input.GetKey(moveRight))
        {
            rb2d.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetKey(moveLeft))
        {
            rb2d.velocity = new Vector2(speed * -1f, 0f);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
