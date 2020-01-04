using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformScripts : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float boundY=6f;


    public bool movingPlatform_Left, movingPlatform_Right, isBreakable, isSpike, isPlatform;

    private Animator anim;

    void Awake()
    {
        if (isBreakable)
            anim = GetComponent<Animator>();
    }
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= boundY)
            gameObject.SetActive(false);
    }//Move

    void BreakableDeactivate()
    {
        Invoke("DeactivateGameObject",0.4f);
    }
    void DeactivateGameObject()
    {
        //SoundManager.İnstance.IceBreakSound;
        gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.tag == "Player")
        {
            

            if (isSpike)
            {
                collision.transform.position = new Vector2(1000f, 1000f);
                SoundManager.instance.GameOverSound();
                GameManager.instance.RestartGame();
            }
        }
    }//On Trigger Enter
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isBreakable)
            {
                SoundManager.instance.LandSound();
                anim.Play("Break");
            }
            if (isPlatform)
            {
                SoundManager.instance.LandSound();
            }
        }
    }//On Collision Enter

     void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (movingPlatform_Left)
            {
                collision.gameObject.GetComponent<PlayerMovement>().PlatformMove(-1f);
            }
            if (movingPlatform_Right)
            {
                collision.gameObject.GetComponent<PlayerMovement>().PlatformMove(1f);
            }
        }
    }//On Collision Stay
}
