using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarMinijuego : MonoBehaviour
{
    public static SeleccionarMinijuego THIS;
    public GameObject pantallaConsola;


    void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else Destroy(gameObject);
    }

    void Start()
    {
        pantallaConsola.SetActive(false);
    }

    public void SeleccionarMinijuego1()
    {
        Debug.Log("Has seleccionado el minijuego 1");
        SceneManager.LoadSceneAsync(6);
        pantallaConsola.SetActive(false);
    }

    public void SeleccionarMinijuego2()
    {
        Debug.Log("Has seleccionado el minujego 2");
        SceneManager.LoadSceneAsync(7);
        pantallaConsola.SetActive(false);
    }

    public void CerrarConsola()
    {
        Debug.Log("Has cerrado la consola");
        pantallaConsola.SetActive(false);
        //Time.timeScale = 1;
    }

}
