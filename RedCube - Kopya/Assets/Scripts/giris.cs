using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giris : MonoBehaviour
{

    public Sprite[] girisEkran;
    SpriteRenderer spriteRenderer;
    int sayac = 0;
    float animasyonZaman = 0;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }
   
    void Update()
    {
        sahnelerArasiGecis();
    }
    void sahnelerArasiGecis()
    {
        int n=1;
        animasyonZaman += Time.deltaTime;

        for(int i = 0; i<=girisEkran.Length;i++)
        {
            if(animasyonZaman > n)
            {
                spriteRenderer.sprite = girisEkran[i]; // sahneler arası geçiş
                n = n + 5; //sahneler arası geçiş saniyesi
            }
        }
  //sprito.sprite = girisEkran[0];
        //if (animasyonZaman > 5)
        //{
        //    sprito.sprite = girisEkran[1];
        //    if (animasyonZaman > 10)
        //    {
        //        sprito.sprite = girisEkran[2];
        //    }
        //}

        
      
    }
}
