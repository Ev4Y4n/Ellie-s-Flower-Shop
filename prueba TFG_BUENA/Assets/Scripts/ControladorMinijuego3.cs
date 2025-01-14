using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMinijuego3 : MonoBehaviour
{
    public static ControladorMinijuego3 THIS;

    public int puntos;
    public Text textoPuntos;

    private void Awake()
    {
        THIS = this;
    }


    public void SumarPuntos()
    {
        textoPuntos.text = "Puntos:" + puntos.ToString();
    }
}
