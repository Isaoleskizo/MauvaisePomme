using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TestCouleur : MonoBehaviour
{
    public UnityEngine.UIElements.Image image;
    private SpriteRenderer sprite;
    public Color32[] texColors;
    public Color32[][] tabcouleurs;

    public float longueur=32;
    public float hauteur=24;


    public InstantierTerrain terrain;
    // Start is called before the first frame update
    void FixedUpdate()
    {
            sprite = GetComponentInChildren<SpriteRenderer>(); 
            texColors = sprite.sprite.texture.GetPixels32();
            for(int i=0;i<hauteur;i++)
            {

                for(int j=0;j<longueur;j++)
                {
                    //tabcouleurs[i][j] = texColors[(i + 1) * j];
                    terrain.cubes[i,j].GetComponent<Renderer>().material.color = texColors[j+(int)longueur*i];

                }
            }
            Debug.Log("tac");
    }
    private void RemplirTableau()
    {

    }


    private Color TestNoir(SpriteRenderer sprite,int x, int y)
    {
        return sprite.color;
    }
    /*
    private void OldCalculNoir()
    {

        texColors = texture.texture.GetPixels32();
        int comptenoir = 0;
        int total = texColors.Length;
        for (int i = 0; i < total; i++)
        {
            if (texColors[i].r != 0)
            {
                comptenoir++;
            }
        }

        float taux = (float)(total - comptenoir) / (float)total * 100;
        Debug.Log("total de pixels : " + total);
        Debug.Log("taux de noir : " + taux + "%");

        if (taux >= 50)
        {
            Debug.Log("NOIR");
        }
        else
        {
            Debug.Log("BLANC");
        }
    }
    */

    //longueur et hauteur totale : normalement 1440 et 1080
    //pos x et y : nombre entre 0 et 9 donnant la position des cubes
    /*private char TestZoneNoire(int longueurTotale,int hauteurTotale, int posX, int posY)
    {
        texColors = texture.texture.GetPixels32();
        int comptenoir = 0;
        int compteblanc = 0;
        int longueur10 = longueurTotale / 10;
        int hauteur10 = hauteurTotale / 10;
        for(int j=posY*hauteur10;j<hauteur10*(posY+1);j++)
        {
            for(int i=posX*longueur10;i<longueur10*(posX+1);i++)
            {
                //Debug.Log(" r:" + texColors[i + j * i].r + " g:" + texColors[i + j * i].g + " b:" + texColors[i + j * i].b);
                if (texColors[i+j*i].r != 0)
                {
                    compteblanc++;
                }
                else
                {
                    comptenoir++;
                }
            }
        }


        //Debug.Log("noirs : " + compteblanc + ", blancs : " + comptenoir);
        if(compteblanc>comptenoir)
        {
            return 'B';
        }
        return 'N';





    }*/
}
