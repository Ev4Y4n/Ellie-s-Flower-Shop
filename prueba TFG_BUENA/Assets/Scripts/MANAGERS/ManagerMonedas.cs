using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMonedas : MonoBehaviour
{
    public static ManagerMonedas THIS;
    [SerializeField] Text textoMonedas;
    [SerializeField] int monedas;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else Destroy(gameObject);
    }

    public void SumarMonedas()
    {
        Debug.Log("Has sumado una moneda");
        textoMonedas.ToString();       
        monedas++;
        ActualizarTextoMonedas();

    }

    public void ActualizarTextoMonedas()
    {
        Debug.Log("Se ha actualizado el texto de las monedas");
        textoMonedas.text = "Monedas:" + monedas;
    }
}
