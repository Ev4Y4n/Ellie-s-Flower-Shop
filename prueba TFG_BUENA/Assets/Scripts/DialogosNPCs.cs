using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogosNPCs : MonoBehaviour
{
    public static DialogosNPCs THIS;
    public GameObject dialogoJano;
    public GameObject dialogoMatteo;
    public GameObject dialogoOlivia;
    public GameObject dialogoMalia;
    public GameObject dialogoHannah;
    public GameObject dialogoLucas;
    public GameObject dialogoTimo;
    public GameObject dialogoNina;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        dialogoJano.SetActive(false);
        dialogoMatteo.SetActive(false);
        dialogoOlivia.SetActive(false);
        dialogoMalia.SetActive(false);
        dialogoHannah.SetActive(false);
        dialogoLucas.SetActive(false);
        dialogoTimo.SetActive(false);
        dialogoNina.SetActive(false);
    }

    public void ActivarDialogoJano()
    {
        dialogoJano.SetActive(true);
    }

    public void DesactivarDialogoJano()
    {
        dialogoJano.SetActive(false);
    }

    public void ActivarDialogoMatteo()
    {
        dialogoMatteo.SetActive(true);
    }

    public void DesactivarDialogoMatteo()
    {
        dialogoMatteo.SetActive(false);
    }

    public void ActivarDialogoOlivia()
    {
        dialogoOlivia.SetActive(true);
    }

    public void DesactivarDialogoOlivia()
    {
        dialogoOlivia.SetActive(false);
    }

    public void ActivarDialogoMalia()
    {
        dialogoMalia.SetActive(true);
    }

    public void DesactivarDialogoMalia()
    {
        dialogoMalia.SetActive(false);
    }

    public void ActivarDialogoHannah()
    {
        dialogoHannah.SetActive(true);
    }

    public void DesactivarDialogoHannah()
    {
        dialogoHannah.SetActive(false);
    }

    public void ActivarDialogoLucas()
    {
        dialogoLucas.SetActive(true);
    }

    public void DesactivarDialogoLucas()
    {
        dialogoLucas.SetActive(false);
    }

    public void ActivarDialogoTimo()
    {
        dialogoTimo.SetActive(true);
    }

    public void DesactivarDialogoTimo()
    {
        dialogoTimo.SetActive(false);
    }

    public void ActivarDialogoNina()
    {
        dialogoNina.SetActive(true);
    }

    public void DesactivarDialogoNina()
    {
        dialogoNina.SetActive(false);
    }
}
