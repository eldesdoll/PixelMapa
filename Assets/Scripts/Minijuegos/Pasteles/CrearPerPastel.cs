﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPerPastel : MonoBehaviour
{
    public GameObject perPrefab, per;
    public Transform perParent;
    public int idPersonaje;
    public int posx, posy;
    public BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
       // idPersonaje = RestablecerValores.idPersonaje;
        Crear();
    }


    public void Crear()
    {
        GameObject personajeTemp = Instantiate(perPrefab, new Vector3(posx, posy, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        personajeTemp.transform.parent = perParent;
        per = GameObject.FindGameObjectWithTag("Personaje");
        box = per.GetComponent<BoxCollider2D>();
        // AsignarNombres();
        //AsignarTamanos();
        asignarTexturas();
    }

    public void asignarTexturas()
    {
        switch (idPersonaje)
        {
            case 0:
                per.GetComponent<Animator>().SetFloat("personaje", 0f);
                break;
            case 1:
                per.GetComponent<Animator>().SetFloat("personaje", 1f);
                break;
            case 2:
                per.GetComponent<Animator>().SetFloat("personaje", 2f);
                break;
            case 3:
                per.GetComponent<Animator>().SetFloat("personaje", 3f);
                per.transform.localScale = new Vector3(0.3f,0.3f);
                box.size = new Vector3(5.6f, 8);
                box.offset = new Vector3(0.1f, -3.519004f);
                break;
            case 4:
                per.GetComponent<Animator>().SetFloat("personaje", 4f);
                break;
            case 5:
                per.GetComponent<Animator>().SetFloat("personaje", 5f);
                break;
            default:
                break;
        }
    }
}
