using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   

    public float velocidad =1;

    float direccion;

    public bool direccionBalaDcha;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
    

        float MovimientoTecla = Input.GetAxis("Horizontal") * 0.02f;
        
             if (MovimientoTecla > 0){
           this.GetComponent<SpriteRenderer>().flipX = false;
           this.GetComponent<Animator>().SetBool("activaCamina",true);
           direccionBalaDcha = true;
         }
          if (MovimientoTecla < 0){
           this.GetComponent<SpriteRenderer>().flipX = true;
           this.GetComponent<Animator>().SetBool("activaCamina",true);
           direccionBalaDcha = false;
         }


       //ug.Log(MovimientoTecla);

       transform.Translate(MovimientoTecla, 0f,0f);

    }
}
