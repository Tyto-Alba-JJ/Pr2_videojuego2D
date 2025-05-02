using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CofreAbre : MonoBehaviour
{
    private bool CofreToca = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollider2D(Collider2D col){ 
        if(col.gameObject.tag == "player" ){
            this.gameObject.GetComponent<Animator>().SetBool("CofreToca", true);   
        }
    }
    
}
