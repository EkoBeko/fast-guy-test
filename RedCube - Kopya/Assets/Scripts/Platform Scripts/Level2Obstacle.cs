using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Obstacle : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene("Level2");
        }
    }
}
