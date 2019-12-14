using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float moveSpeed = 2f;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x > Screen.width / 2)
            { //ekranin sagina basildiginda
                myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
            }
                if (touch.position.x < Screen.width / 2) { //ekranin soluna basildiginda 
                myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
            } 
            }

                if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        }
    }//move

    public void PlatformMove(float x)
    {
        myBody.velocity = new Vector2(x, myBody.velocity.y);
    }
}

/* foreach (Touch touch in Input.touches)
        {
            if ((touch.position.x > Screen.height / 2) && (touch.phase == TouchPhase.Began))
            {
                myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
            }

            if ((touch.position.x > Screen.height / 2) && (touch.phase == TouchPhase.Began))
            {
                myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
            }
        }*/
