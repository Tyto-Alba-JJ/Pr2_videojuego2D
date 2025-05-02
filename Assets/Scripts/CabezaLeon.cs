using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CabezaLeon : MonoBehaviour
{
    public float distanciaAtaque = 3;

    GameObject spawn;
    

    private Vector3 LugarParada;
    Vector3 posInical;

    public int velocidadAtaque = 5;
    float distancia;
    private GameObject player;

    private String EstadoAtaque;

    void Start()
    {   spawn = GameObject.Find("Spawner");
        posInical = transform.position;
        player = GameObject.FindWithTag("Player");
        LugarParada = new Vector3(posInical.x - 10, posInical.y, posInical.z);

    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);


        if (distancia <= distanciaAtaque)
        {
            EstadoAtaque = "Ataque";
            
        }
        if (EstadoAtaque == "Ataque")
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;

            transform.position = Vector3.MoveTowards(transform.position, LugarParada, velocidadAtaque * Time.deltaTime);
            if (player.transform.position == spawn.transform.position)
        {
            this.transform.position = posInical;
            EstadoAtaque = "NoAtacar";
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        }

        
    }
}
