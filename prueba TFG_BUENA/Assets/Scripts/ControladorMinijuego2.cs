using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMinijuego2 : MonoBehaviour
{
    public static ControladorMinijuego2 THIS;

    public float puntos;
    public Text textoPuntos;


    void Awake()
    {
        // uso de SINGLETON:

        if (THIS == null)
        {
            THIS = this;
        }
    }

    /*
    private void Start()
    {
        Debug.Log("Se ha desactivado la barra de experiencia");
        ManagerExperiencia.THIS.barraExperiencia.gameObject.SetActive(false);
    }
    */


}
