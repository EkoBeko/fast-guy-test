using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static int scoreAmaout;
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmaout = 11;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + scoreAmaout;
    }
}
