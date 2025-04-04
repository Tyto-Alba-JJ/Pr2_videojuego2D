using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int valor;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.tag == "Player")
        {   
            GameManager.marcador = GameManager.marcador+valor;
            this.GetComponent<Animator>().SetBool("destruirmoneda", true);
            Destroy(this.gameObject, 1.0f);
        }

    }

}


