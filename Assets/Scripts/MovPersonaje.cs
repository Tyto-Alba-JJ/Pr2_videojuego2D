using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovPersonaje : MonoBehaviour
{
public float velocidad = 5f;
public float multiplicador = 5f;

public float multiplicadorSalto = 5f;

private bool puedoSaltar = true;

private Rigidbody2D rb;

private Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();

        transform.position = new Vector3(-3.1f, -1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float miDeltaTime = Time.deltaTime;

        float movTeclas = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(movTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(movTeclas != 0){
            animatorController.SetBool("activacamina", true);
        }else{
            animatorController.SetBool("activacamina", false);
        }

       RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
       Debug.DrawRay(transform.position, Vector2.down, Color.white);

        if (hit){
            puedoSaltar = true;
        }else{
            puedoSaltar = false;
        };

        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
            rb.AddForce(
                new Vector2(0,multiplicadorSalto),
                ForceMode2D.Impulse
            );
            //puedoSaltar = false;
        }
    }

    void OnCollisionEnter2D(){
        puedoSaltar = true;
    }

}


  