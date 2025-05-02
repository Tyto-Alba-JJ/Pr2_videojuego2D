using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad= 8.0f;

    public static bool fantasmaMuerte = false;

    bool bolaDerecha = true;

    float tiempoDestruccion = 1.0f;

    float queHoraes ;

    GameObject personaje;
    void Start()
    {
        personaje = GameObject.Find("personaje");
        bolaDerecha = personaje.GetComponent<MovPersonaje>().mirandoDerecha;

        queHoraes = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadFinal = velocidad * Time.deltaTime;

        if (Time.time >= queHoraes + tiempoDestruccion){
            Destroy(this.gameObject);
        }

       if(bolaDerecha){
        
         transform.Translate(velocidadFinal, 0f,0f, Space.World);
         
       }else
       {
        transform.Translate(velocidadFinal * -1.0f , 0f,0f);
       
       }
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Enemigo" ){
            col.gameObject.GetComponent<Animator>().SetBool("FantasmaMuereCall", true);   
            
            GameManager.muertes ++;

            Destroy(this.gameObject);
            
            Destroy(col.gameObject, 0.5f);

           

           
        }
    }
}
