using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    GameObject camara;
    public float velocidadParallax = 1;
    void Start()
    {
        player = GameObject.FindWithTag("PLayer");
        camara = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camara.transform.position * velocidadParallax;
    }
}
