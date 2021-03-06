﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearFondo : MonoBehaviour
{
    // Start is called before the first frame update
    private int total;
    private float posx, posy;
    public GameObject maderaPrefab, ladrilloPrefab;
    public Transform maderaParent, ladrilloParent;
    void Start()
    {
        Crear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Crear()
    {
        crearLadrillo();
        crearMadera();
    }

    public void crearMadera()
    {
        total = 60;
        posy = -5; posx = -9f;
        for (int i = 0; i < total; i++)
        {

            GameObject maderaTemp = Instantiate(maderaPrefab, new Vector3(posx, posy, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
            maderaTemp.name = "" + i + "";
            maderaTemp.transform.parent = maderaParent;
            posx = posx + 2;
            if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59)
            {
                posy = posy + 2;
                posx = -9;
            }
        }
    }

    public void crearLadrillo()
    {

        //HORIZONTAL
        total =18;
        posy = -8; posx = -16f;
        for (int i = 0; i < total; i++)
        {

            GameObject ladrilloTemp = Instantiate(ladrilloPrefab, new Vector3(posx, posy, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
            ladrilloTemp.name = "" + i + "";
            ladrilloTemp.transform.parent = ladrilloParent;
            posx = posx + 4 ;
            if (i == 8)
            {
                posy = 8;
                posx = -16;
            }
           
        }
        //VERTICAL  
        total = 12;
        posy = -4; posx = -16f;
        for (int i = 0; i < total; i++)
        {

            GameObject ladrilloTemp = Instantiate(ladrilloPrefab, new Vector3(posx, posy, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
            ladrilloTemp.name = "" + i + "";
            ladrilloTemp.transform.parent = ladrilloParent;
            posy = posy + 4;
            if( i == 2||i==8)
            {
                posx = posx + 4;
                posy = -4;
            }
            if (i == 5)
            {
                posy = -4;
                posx = 12;
            }
        }
    }
}
