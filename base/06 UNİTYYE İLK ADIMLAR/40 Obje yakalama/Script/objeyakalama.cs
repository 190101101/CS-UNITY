﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{
    GameObject benim;
    GameObject[] cokluObje;
    public GameObject disaridan;
    public Material a;

    void Start()
    {
        disaridan.GetComponent<ilkdosyam>().yas = 60;


        /*
        cokluObje = GameObject.FindGameObjectsWithTag("Player");

        foreach(var item in cokluObje)
        {
            Debug.Log(item);
            item.GetComponent<ilkdosyam>().yas = 3;
        }
        */ 


        /*
        objecti number etmek olmaz!
        benim = GameObject.FindWithTag("Player").GetComponent<ilkdosyam>().yas=15
        */ 

        /*
        benim = GameObject.FindWithTag("Player");
        benim.GetComponent<ilkdosyam>().yas=15;
        */ 


        /*
        benim = GameObject.Find("Ana");
        benim.GetComponent<ilkdosyam>().yas=15;

        GameObject.Find("Ana").GetComponent<ilkdosyam>().yas = 15;
        GameObject.Find("Ana/cocuk").GetComponent<ilkdosyam>().yas = 9;
        */ 
    }
}
