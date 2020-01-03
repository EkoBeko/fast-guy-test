using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2PlayerMovement : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement;
    public float speed;
    public float maxWidth;
    public float minWidth;

    public Animator camAnim;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow)&& transform.position.x > minWidth)
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x < maxWidth)
        {

            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);

        }
    }
}
