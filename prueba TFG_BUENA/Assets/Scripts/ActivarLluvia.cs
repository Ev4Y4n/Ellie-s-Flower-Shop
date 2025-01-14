using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLluvia : MonoBehaviour
{
    public ParticleSystem efectoLluvia;

    public bool lluviaActivada;

    public AudioSource sonidoLluvia;

    // Start is called before the first frame update
    void Start()
    {
        efectoLluvia.gameObject.SetActive(false);
        sonidoLluvia.Stop();
    }

    public void ActivarEfectoLluvia()
    {
        if (lluviaActivada)
        {
            efectoLluvia.gameObject.SetActive(false);
            lluviaActivada = false;
            sonidoLluvia.Stop();
        }
        else
        {
            efectoLluvia.gameObject.SetActive(true);
            lluviaActivada = true;
            sonidoLluvia.Play();
        }
        
    }
}



