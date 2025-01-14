using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBasura : MonoBehaviour
{
    public static ControladorBasura THIS;
    public GameObject basura1;
    public GameObject panelBasura;
    public GameObject basuraLlena;
    public int cantidadExperiencia = 150;

    public GameObject panelPapeleraLlena;
    public bool papeleraLlena;

    // Start is called before the first frame update
    void Awake()
    {
        // uso de SINGLETON:

        if (THIS == null)
        {
            THIS = this;
        }
    }


    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        panelBasura.SetActive(false);
        basuraLlena.SetActive(false);
        panelPapeleraLlena.SetActive(false);
        papeleraLlena = false;
    }

    public void RecogerBasura()
    {
        Debug.Log("Has recogido basura");
        basura1.SetActive(false);
        basuraLlena.SetActive(true);
        panelBasura.SetActive(false);
        papeleraLlena = true;
        ManagerExperiencia.THIS.SumarExperiencia();
        ManagerMonedas.THIS.SumarMonedas();
        Time.timeScale = 1f;
    }

    public void SalirPanelBasura()
    {
        Debug.Log("Has cerrado panel de basura");
        panelBasura.SetActive(false);
        Time.timeScale = 1f;
    }

    public void VaciarPapelera()
    {
        Debug.Log("Has vaciado la papelera");
        basuraLlena.SetActive(false);
        panelPapeleraLlena.SetActive(false);
        papeleraLlena = false;
        Time.timeScale = 1f;

    }

    public void SalirPanelPapeleraLlena()
    {
        Debug.Log("Has cerrado el panel de la papelera");
        panelPapeleraLlena.SetActive(false);
        Time.timeScale = 1f;
    }
}
