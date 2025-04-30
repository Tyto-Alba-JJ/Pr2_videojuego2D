using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    public int vidaFantasma = 10;

    AudioSource _audioSource; 
    public float velocidad = 1;
    public float velocidadAtaque = 5;
    public float limiteDcha = 1;
    public float limiteIzq = 1;
    private Vector3 posLimitDcha;
    private Vector3 posLimitIzq;
    bool direccionFantasma = true;
    private Vector3 posInicial;
    private String estadofantasma = "Patrol";
    private GameObject player;

    private float distancia;
    public float distataque = 3;
    public float distPatrol = 3.32f;

    void Start()
    {

        player = GameObject.FindWithTag("Player");
        this.GetComponent<SpriteRenderer>().flipX = true;
        posInicial = transform.position;
        posLimitDcha = new Vector3(posInicial.x + limiteDcha, posInicial.y, 0);
        posLimitIzq = new Vector3(posInicial.x - limiteIzq, posInicial.y, 0);

        _audioSource = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= distataque)
        {
            estadofantasma = "Ataque";

        }

        if (distancia >= distPatrol)
        {
            estadofantasma = "Patrol";
        }

        // PATROL


        if (estadofantasma == "Patrol")
        {
            if (distancia > (limiteDcha + limiteIzq)){
                 transform.position = Vector3.MoveTowards(transform.position, posInicial, velocidadAtaque * Time.deltaTime);
            }
                if (direccionFantasma == true)
                {
                    transform.Translate(velocidad * Time.deltaTime, 0, 0);
                }

                if (direccionFantasma == false)
                {
                    transform.Translate((velocidad * Time.deltaTime) * -1, 0, 0);
                }

                if (transform.position.x >= posLimitDcha.x)
                {
                    direccionFantasma = false;
                    this.GetComponent<SpriteRenderer>().flipX = false;
                }
                if (transform.position.x <= posLimitIzq.x)
                {
                    direccionFantasma = true;
                    this.GetComponent<SpriteRenderer>().flipX = true;
                }
          


        }

        if (estadofantasma == "Ataque")
        {
           
            if(_audioSource.isPlaying == false){
                _audioSource.Play();
            }
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidadAtaque * Time.deltaTime);
        }else{
               if((transform.position == posInicial)&& _audioSource.isPlaying == true){
                 _audioSource.Stop();
               }
            }

        if (player.transform.position.x <= transform.position.x)
        {

            this.GetComponent<SpriteRenderer>().flipX = false;



        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }


    }

   
}
