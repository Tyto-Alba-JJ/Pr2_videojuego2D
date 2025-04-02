using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvado : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject spawn;
    void Start()
    {
        spawn = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D col){
        
    }
}
