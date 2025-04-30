using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Muerte : MonoBehaviour
{


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
        GameManager.vidas--;
      }
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.tag == "Player"){
            col.gameObject.transform.position = spawn.transform.position;
            GameManager.vidas--;
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
       
        };

        

    }


}


