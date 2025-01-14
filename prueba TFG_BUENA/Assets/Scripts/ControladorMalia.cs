using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMalia : MonoBehaviour
{
    public GameObject panelOpcionesMalia;
    public GameObject tienda;
    public GameObject dialogoMalia;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;
    public Text texto5;
    public Text texto6;
    public Text texto7;
    public Text texto8;
    public Text texto9;
    public Text texto10;
    public Text texto11;

    public Text nombreMalia;
    public Text nombreElisabeth;

    public GameObject botonLuz;

    // Start is called before the first frame update
    void Start()
    {
        panelOpcionesMalia.SetActive(false);
        tienda.SetActive(false);
        dialogoMalia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elisabeth"))
        {
            Debug.Log("Te has encontrado conMalia");
            panelOpcionesMalia.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AbrirTienda()
    {
        Debug.Log("Has abierto tienda");
        tienda.SetActive(true);
        panelOpcionesMalia.SetActive(false);
        Time.timeScale = 0;
        MovimientoElisameth.THIS.inventario.SetActive(false);
        botonLuz.SetActive(false);
    }

    public void CerrarPanelMalia()
    {
        Debug.Log("Has cerrado el panel de Malia");
        panelOpcionesMalia.SetActive(false);
        Time.timeScale = 1;
    }

    public void SalirTienda()
    {
        Debug.Log("Has salido de la tienda");
        tienda.SetActive(false);
        Time.timeScale = 1;
        MovimientoElisameth.THIS.inventario.SetActive(true);
        botonLuz.SetActive(true);
    }

    public void AbrirDialogoMalia()
    {
        Debug.Log("Has comenzado una conversación con Malia");
        dialogoMalia.SetActive(true);
        panelOpcionesMalia.SetActive(false);
        texto1.gameObject.SetActive(true);
        Time.timeScale = 0;
        MovimientoElisameth.THIS.inventario.SetActive(false);
        nombreMalia.gameObject.SetActive(true);
        nombreElisabeth.gameObject.SetActive(false);
        botonLuz.SetActive(false);


    }

    public void CambiarTextoConversacion()
    {
        Debug.Log("Estas cambiando la conversación con Malia");
        if (texto1.gameObject.activeInHierarchy)
        {
            texto1.gameObject.SetActive(false);
            texto2.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);

        }
        else if (texto2.gameObject.activeInHierarchy)
        {
            texto2.gameObject.SetActive(false);
            texto3.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
            nombreMalia.gameObject.SetActive(true);
        }
        else if (texto3.gameObject.activeInHierarchy)
        {
            texto3.gameObject.SetActive(false);
            texto4.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);
        }
        else if (texto4.gameObject.activeInHierarchy)
        {
            texto4.gameObject.SetActive(false);
            texto5.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);
        }
        else if (texto5.gameObject.activeInHierarchy)
        {
            texto5.gameObject.SetActive(false);
            texto6.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);
        }
        else if (texto6.gameObject.activeInHierarchy)
        {
            texto6.gameObject.SetActive(false);
            texto7.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
            nombreMalia.gameObject.SetActive(true);
        }
        else if (texto7.gameObject.activeInHierarchy)
        {
            texto7.gameObject.SetActive(false);
            texto8.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
            nombreMalia.gameObject.SetActive(true);
        }
        else if (texto8.gameObject.activeInHierarchy)
        {
            texto8.gameObject.SetActive(false);
            texto9.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);
        }
        else if (texto9.gameObject.activeInHierarchy)
        {
            texto9.gameObject.SetActive(false);
            texto10.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
            nombreMalia.gameObject.SetActive(true);
        }
        else if (texto10.gameObject.activeInHierarchy)
        {
            texto10.gameObject.SetActive(false);
            texto11.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
            nombreMalia.gameObject.SetActive(false);
        }
        else if (texto11.gameObject.activeInHierarchy)
        {
            texto11.gameObject.SetActive(false);
            dialogoMalia.SetActive(false);
            MovimientoElisameth.THIS.inventario.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
            nombreMalia.gameObject.SetActive(false);

            Time.timeScale = 1f;
            botonLuz.SetActive(true);

        }
    }
}
