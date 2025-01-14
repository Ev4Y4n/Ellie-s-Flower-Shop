using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorFlynn : MonoBehaviour
{
    public GameObject panelOpcionesFlynn;
    public GameObject dialogoFlynn;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;
    public Text texto5;
    public Text texto6;
    public Text texto7;
    public Text texto8;

    public Text nombreFlynn;
    public Text nombreElisabeth;

    public GameObject botonLluvia;
    public GameObject inventario;


    // Start is called before the first frame update
    void Start()
    {
        panelOpcionesFlynn.SetActive(false);
        dialogoFlynn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elisabeth"))
        {
            Debug.Log("Te has encontrado con Flynn");
            panelOpcionesFlynn.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CerrarPanelFlynn()
    {
        panelOpcionesFlynn.SetActive(false);
        Time.timeScale = 1;
    }

    public void AbrirDialogoFlynn()
    {
        dialogoFlynn.SetActive(true);
        nombreFlynn.gameObject.SetActive(true);
        panelOpcionesFlynn.SetActive(false);
        //MovimientoElisameth.THIS.inventario.SetActive(false);
        Time.timeScale = 0;
        botonLluvia.SetActive(false);
        inventario.SetActive(false);


    }

    public void CambiarTextoConversacion()
    {
        if (texto1.gameObject.activeInHierarchy)
        {
            texto1.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(false);
            texto2.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto2.gameObject.activeInHierarchy)
        {
            texto2.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(true);
            texto3.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto3.gameObject.activeInHierarchy)
        {
            texto3.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(false);
            texto4.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto4.gameObject.activeInHierarchy)
        {
            texto4.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(true);
            texto5.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto5.gameObject.activeInHierarchy)
        {
            texto5.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(true);
            texto6.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto6.gameObject.activeInHierarchy)
        {
            texto6.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(false);
            texto7.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto7.gameObject.activeInHierarchy)
        {
            texto7.gameObject.SetActive(false);
            nombreFlynn.gameObject.SetActive(true);
            texto8.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }

        else if (texto8.gameObject.activeInHierarchy)
        {
            texto8.gameObject.SetActive(false);
            dialogoFlynn.SetActive(false);
            nombreFlynn.gameObject.SetActive(false);
            Time.timeScale = 1f;
            botonLluvia.SetActive(true);
            inventario.SetActive(true);

        }
    }
}
