using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int valor = 1;

    Animator miAnimadorController;
    void Start()
    {
       
   miAnimadorController = this.GetComponent<Animator>();
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.tag == "Player")
        {   
            GameManager.marcador = GameManager.marcador+valor;
            this.GetComponent<Animator>().SetBool("destruirmoneda", true);
            miAnimadorController.SetBool("GoalCapture", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxCoin);
            Destroy(this.gameObject, 1.0f);
        
        }

    }

}


