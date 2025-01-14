using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControladorMatteo : MonoBehaviour
{
    public GameObject dialogoMatteo;
    public GameObject matteo;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;
    public Text texto5;
    public Text texto6;
    public Text texto7;
    public Text texto8;

    public Text nombreMatteo;
    public Text nombreElisabeth;

    // Start is called before the first frame update
    void Start()
    {
        dialogoMatteo.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elisabeth"))
        {
            Debug.Log("Te has encontrado con Flynn");
            dialogoMatteo.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ActivarDialogoMatteo()
    {
        dialogoMatteo.SetActive(true);
        //texto1.gameObject.SetActive(true);
        nombreMatteo.gameObject.SetActive(true);
        MovimientoElisameth.THIS.inventario.SetActive(false);
        Time.timeScale = 0;
    }

    public void CambiarTextoConversacion()
    {
        if (texto1.gameObject.activeInHierarchy)
        {
            texto1.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(false);
            texto2.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto2.gameObject.activeInHierarchy)
        {
            texto2.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(true);
            texto3.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto3.gameObject.activeInHierarchy)
        {
            texto3.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(true);
            texto4.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto4.gameObject.activeInHierarchy)
        {
            texto4.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(false);
            texto5.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto5.gameObject.activeInHierarchy)
        {
            texto5.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(false);
            texto6.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }
        else if (texto6.gameObject.activeInHierarchy)
        {
            texto6.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(true);
            texto7.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(false);
        }
        else if (texto7.gameObject.activeInHierarchy)
        {
            texto7.gameObject.SetActive(false);
            nombreMatteo.gameObject.SetActive(false);
            texto8.gameObject.SetActive(true);
            nombreElisabeth.gameObject.SetActive(true);
        }

        else if (texto8.gameObject.activeInHierarchy)
        {
            texto8.gameObject.SetActive(false);
            dialogoMatteo.SetActive(false);
            nombreElisabeth.gameObject.SetActive(false);
            Time.timeScale = 1f;
            matteo.SetActive(false);
        }
    }
}
