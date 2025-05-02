using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax1 : MonoBehaviour
{
    public float ParallaxSpeed = 1;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate(){
         transform.position = new Vector3(Camera.main.transform.position.x/ParallaxSpeed, Camera.main.transform.position.y/ParallaxSpeed, 0);
        
    }


}




