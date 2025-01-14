using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerExperiencia : MonoBehaviour
{
    public static ManagerExperiencia THIS;

    [SerializeField] Text textoNivel;
    [SerializeField] Text puntosExperiencia;
    [SerializeField] private int nivel;
    public float experienciaActual;
    [SerializeField] private float experienciaMax;
    public Image barraExperiencia;

    void Awake()
    {
        // uso de SINGLETON:

        if (THIS == null)
        {
            THIS = this;
        }
    }

    public void ControladorExperiencia()
    {
        Debug.Log("La barra de experiencia ha sido modificada");
        textoNivel.text.ToString();
        barraExperiencia.fillAmount = (experienciaActual / experienciaMax);

        if(experienciaActual >= experienciaMax)
        {
            experienciaActual = experienciaActual - experienciaMax;
            nivel++;
            experienciaMax += 50;
        }
    }

    public void SumarExperiencia()
    {
        Debug.Log("Has sumado experiencia");
        experienciaActual += 20;
        puntosExperiencia.text = experienciaActual + "/" + experienciaMax;

        ControladorExperiencia();
    }

    public void DesactivarBarra()
    {
        Debug.Log("Se ha seactivado la barra de experiencia");
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            barraExperiencia.gameObject.SetActive(false);
        }
    }
}
