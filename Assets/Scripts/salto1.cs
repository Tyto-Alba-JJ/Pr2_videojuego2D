using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto1 : MonoBehaviour
{
    
    public float salto = 1.0f;

    bool puedoSaltar = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f);

           if(hit.collider == null){

                puedoSaltar = false;


           }else{

                puedoSaltar = true;


           };
           
           
            if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){

                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, salto), ForceMode2D.Impulse) ;

            };
        
    }
}
