using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    public int vidaFantasma = 10;
    public float velocidad = 1;
    public float limiteDcha = 1;
    public float limiteIzq = 1;
    private Vector3 posLimitDcha;
    private Vector3 posLimitIzq;
    bool direccionFantasma = true;
    private Vector3 posInicial; 
    private String estadofantasma = "Patrol";
    private GameObject player;

    void Start()
    {   

        player = GameObject.FindWithTag("Player");
        this.GetComponent<SpriteRenderer>().flipX = true;
        posInicial = transform.position; 
        posLimitDcha = new Vector3(posInicial.x + limiteDcha, posInicial.y, 0);
        posLimitIzq = new Vector3(posInicial.x - limiteIzq, posInicial.y, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(estadofantasma);

        if (direccionFantasma == true ){
            transform.Translate(velocidad*Time.deltaTime, 0, 0);
        }
        
        if(direccionFantasma == false) {
            transform.Translate((velocidad*Time.deltaTime)*-1, 0, 0);
        }

        if(transform.position.x >= posLimitDcha.x){
            direccionFantasma = false;
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
            if(transform.position.x <= posLimitIzq.x){
            direccionFantasma = true;
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
     
        
    }
}
