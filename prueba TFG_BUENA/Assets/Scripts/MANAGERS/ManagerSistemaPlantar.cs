using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSistemaPlantar : MonoBehaviour
{
    public static ManagerSistemaPlantar THIS;
    public GameObject panelPlantar;
    public GameObject panelRegar;
    public GameObject panelRecoger;

    public GameObject semillaPlantada;
    public GameObject brote1Plantado;
    public GameObject brote2Plantado;
    public GameObject brote3Plantado;

    public bool hasPlantadoSemilla;
    public bool hasTerminadoDePlantar;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else Destroy(gameObject);
    }

    private void Start()
    {
        panelPlantar.SetActive(false);
        panelRegar.SetActive(false);
        panelRecoger.SetActive(false);
        semillaPlantada.SetActive(false);
        brote1Plantado.SetActive(false);
        brote2Plantado.SetActive(false);
        brote3Plantado.SetActive(false);
        hasPlantadoSemilla = false;
    }

    public void PlantarSemilla()
    {
        Debug.Log("Has plantado una semilla");
        semillaPlantada.SetActive(true);
        panelPlantar.SetActive(false);
        ManagerExperiencia.THIS.SumarExperiencia();
        hasPlantadoSemilla = true;
        hasTerminadoDePlantar = false;
        Temporizador.THIS.ActivarTemporizador();
    }

    public void Regar()
    {
        Debug.Log("Has regado la planta");
        if (semillaPlantada.activeSelf)
        {
            semillaPlantada.SetActive(false);
            brote1Plantado.SetActive(true);
            panelRegar.SetActive(false);
            panelPlantar.SetActive(false);
            ManagerExperiencia.THIS.SumarExperiencia();
            hasTerminadoDePlantar = false;           
        }
        else if (brote1Plantado.activeSelf)
        {
            brote1Plantado.SetActive(false);
            brote2Plantado.SetActive(true);
            panelRegar.SetActive(false);
            panelPlantar.SetActive(false);
            ManagerExperiencia.THIS.SumarExperiencia();
            hasTerminadoDePlantar=false;          
        }
        else if (brote2Plantado.activeSelf)
        {
            brote2Plantado.SetActive(false);
            brote3Plantado.SetActive(true);
            panelRegar.SetActive(false);
            panelPlantar.SetActive(false);
            ManagerExperiencia.THIS.SumarExperiencia();
            hasTerminadoDePlantar = true;
        }
    }

    public void Recoger()
    {
        brote3Plantado.SetActive(false);
        panelRecoger.SetActive(false);
        panelRegar.SetActive(false);
        ManagerExperiencia.THIS.SumarExperiencia();
        Debug.Log("Se ha desactivado temporizador");
        Temporizador.THIS.DesactivarTemporizador();
    }

    public void DesactivarPanelRegar()
    {
        if (hasTerminadoDePlantar == true)
        {
            panelRegar.SetActive(false);
        }
    }
}
