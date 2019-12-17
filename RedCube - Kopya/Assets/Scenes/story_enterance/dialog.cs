using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dialog : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingspeed;
    public GameObject conButton;
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }

    public void nextSentence()
    {
        conButton.SetActive(false);
        if(index<sentences.Length-1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            conButton.SetActive(false);
        }
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            conButton.SetActive(true);
        }
    }

    void Start()
    {
        StartCoroutine(Type());
    }
}
