using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;
    public static int marcador = 0;
     GameObject spawn;



    void Start()
    {
           spawn = GameObject.Find("Spawner");
    }

  
    void Update()
    {
      Debug.Log(marcador);
    }

}
