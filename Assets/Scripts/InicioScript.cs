using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor.EditorTools;

public class InicioScript : MonoBehaviour
{

    GameObject panelSettings;
    
    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.Find("PanelSettings");
        panelSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
            SceneManager.LoadScene("1Escena1");
        }

    public void ExitGame(){
        #if !UNITY_EDITOR
            Application.Quit();
        #else
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void MostrarSettings(){
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
        panelSettings.SetActive(true);
    }

    public void OcultarSettings(){
        panelSettings.SetActive(false);
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButton);
    }
}
