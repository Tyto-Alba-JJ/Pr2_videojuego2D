using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;


public class MovPersonaje : MonoBehaviour
{
   public bool puedoDobleSaltar = false;

   public static Vector3 Posicion;
    public GameObject spawn;
    public float velocidad = 5f;
    public float multiplicador = 5f;

    float movTeclas;

    public float multiplicadorSalto = 5f;

    private bool puedoSaltar = true;
    private bool activaSaltoFixed = false;
    private bool activaDobleSaltoFixed = false;

    public bool mirandoDerecha = true;

    private Rigidbody2D rb;

    private bool EstoyMuerto = false;

    private Animator animatorController;

    bool SoyVerde;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();

        Posicion = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.EstoyMuerto) return;

        float miDeltaTime = Time.deltaTime;

        movTeclas = Input.GetAxis("Horizontal");


        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            mirandoDerecha = false;
        }
        else if (movTeclas > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            mirandoDerecha = true;
        }

        if (movTeclas != 0)
        {
            animatorController.SetBool("activacamina", true);
        }
        else
        {
            animatorController.SetBool("activacamina", false);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.white);

        if (hit)
        {
            puedoSaltar  = true;
            puedoDobleSaltar = true;
        }
        else if(puedoDobleSaltar == true)
        {   
            activaSaltoFixed  = true;

            activaSaltoFixed = false;
        }
        ;

        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar && puedoDobleSaltar)
        {
          Salto();
          puedoSaltar = false;
        
        }

        if (GameManager.vidas <= 0)
        {
            GameManager.EstoyMuerto = true;
        }
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);

        
    }

    public void Respawnear()
    {
        Debug.Log("vidas" + GameManager.vidas);
        GameManager.vidas = GameManager.vidas - 1;
        Debug.Log("vidas" + GameManager.vidas);
        transform.position = spawn.transform.position;
    }

    public void CambiarColor(){
        if (SoyVerde){
            this.GetComponent<SpriteRenderer>().color = Color.white;
            SoyVerde=false;
        }else{
            this.GetComponent<SpriteRenderer>().color = Color.green;
            SoyVerde = true;
        }
        

    }

    public void Salto(){
        rb.AddForce(
              new Vector2(0, multiplicadorSalto),
              ForceMode2D.Impulse );
    }

    

}


