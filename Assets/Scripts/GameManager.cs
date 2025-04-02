using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;
     GameObject spawn;



    void Start()
    {
           spawn = GameObject.Find("Spawner");
    }

  
    void Update()
    {
      
    }

}
