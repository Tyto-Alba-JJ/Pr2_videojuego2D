using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject spawn;
    void Start()
    {
        spawn = GameObject.Find("Spawner");
        transform.position = spawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -10){
            transform.position = spawn.transform.position;
            GameManager.vidas--;
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
              
        };
    }
}
