using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad= 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadFinal = velocidad * Time.deltaTime;
         transform.Translate(velocidadFinal, 0f,0f);
    }
}
