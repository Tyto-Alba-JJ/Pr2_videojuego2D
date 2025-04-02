using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Sta
    // rt is called before the first frame update

     GameObject spawn;
    void Start()
    {
           spawn = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -10){
        transform.position = spawn.transform.position;
      }
    }

    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.tag == "Player"){
            col.gameObject.transform.position = spawn.transform.position;
            GameManager.vidas--;
        };


    }


}


