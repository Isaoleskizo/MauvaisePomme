using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{

    public SpriteRenderer spr;
    private int numero = 1;
    private string zeros="";
    private bool metronome = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if(metronome)
        //{

            try
            {
                if (numero < 10)
                {
                    zeros = "00";
                }
                else if (numero<100)
                {
                    zeros = "0";
                }
                else
                {
                    zeros = "";
                }
                Texture2D txt = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Images/image_sequence/bad_apple_"+zeros+""+numero+".png", typeof(Texture2D));
                spr = GetComponentInChildren<SpriteRenderer>();
                Sprite blankSprite = Sprite.Create(txt, new Rect(0, 0, 32, 24), new Vector2(0.5f, 0.5f));
                spr.sprite = blankSprite;
                spr.sprite.name = ("0"+numero);
                numero++;
            }
            catch(Exception e)
            {
                Debug.Log("fin");
            }
        //}
        //metronome = !metronome;
    }
}
