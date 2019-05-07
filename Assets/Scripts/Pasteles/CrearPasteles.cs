﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPasteles : MonoBehaviour
{
    public GameObject[] pastelPrefab = new GameObject[4];
    public Transform pastelParent;
    public float tiempo, tiempo1;
    public int noPastel, noPastel1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crearPastelIzq();
        crearPastelDer();
        tiempo = Time.deltaTime + tiempo;
        tiempo1 = Time.deltaTime + tiempo1;
    }

    public void crearPastelDer()
    {
        if (tiempo >= 1f)
        {
            tiempo = 0;
            if (noPastel == 0)
            {
                noPastel = 1;
                GameObject pastelTemp = Instantiate(pastelPrefab[0], new Vector3(-10, 2.85f, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
                pastelTemp.transform.parent = pastelParent;
                pastelTemp.GetComponent<PastelDer>().idPastel = 4;
            }
            else
            {
                GameObject pastelTemp = Instantiate(pastelPrefab[1], new Vector3(-10, 2.85f, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
                pastelTemp.transform.parent = pastelParent;
                pastelTemp.GetComponent<PastelDer>().idPastel = 3;
                noPastel = 0;
               
            }
        }
    }

    public void crearPastelIzq()
    {
        if (tiempo1 >= 1f)
        {
            tiempo1 = 0;
            if (noPastel1 == 0)
            {
                noPastel1 = 1;
                GameObject pastelTemp1 = Instantiate(pastelPrefab[2], new Vector3(10, 2.85f, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
                pastelTemp1.transform.parent = pastelParent;
                pastelTemp1.GetComponent<PastelIzq>().idPastel = 2;
               
            }
            else
            {
                GameObject pastelTemp1 = Instantiate(pastelPrefab[3], new Vector3(10, 2.85f, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
                pastelTemp1.transform.parent = pastelParent;
                pastelTemp1.GetComponent<PastelIzq>().idPastel = 1;
                noPastel1 = 0;
            }
        }
    }
}
