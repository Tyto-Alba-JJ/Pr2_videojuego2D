using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;
    public static int marcador = 0;
    public static bool EstoyMuerto ;
    public static int valor;

    public static int muertes = 0;

    GameObject VidasText;
  
     GameObject spawn;



    void Start()
    {
        VidasText = GameObject.Find("VidasText");

           spawn = GameObject.Find("Spawner");
    }

  
    void Update()
    {
      Debug.Log("monedas:" + marcador);


      VidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
    }

}
