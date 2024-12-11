using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstantierTerrain : MonoBehaviour
{
    //public GameObject mur;
    public Camera cacamera;
    public GameObject bloc;
    public Transform parent;
    public GameObject empty;
    private GameObject x;
    public int longueur = 32;
    public int hauteur = 24;
    public GameObject[,] cubes = new GameObject[24,32];
    
    // Start is called before the first frame update
    void Awake()
    {
        Vector3 positioncube = new Vector3(0f,0f,0f);

        empty = new GameObject(" ");
        //Instantiate(mur, Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)), Quaternion.identity);
        for (int i = 0; i < hauteur; i++)
        {
            GameObject ligne = Instantiate(empty,transform);
            ligne.name = "ligne " + (i+1);
            for(int j=0;j < longueur; j++)
            {
                x = Instantiate(bloc, positioncube, Quaternion.identity,ligne.transform);
                x.name ="case "+ (j+1);
                positioncube += new Vector3(1.1f, 0f, 0f);
                cubes[i,j] = x;
            }
            positioncube -= new Vector3(longueur+0.1f*longueur, 0f, 0f);
            positioncube += new Vector3(0f, 1.1f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBlock(Vector3 position, int type)
    {
        Instantiate(bloc, position, Quaternion.identity);
    }
}
