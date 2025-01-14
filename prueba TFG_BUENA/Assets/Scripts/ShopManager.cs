using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int[,] productosTienda = new int [5, 5];
    public float monedas = 1000;
    public Text monedasTxt;

    void Start()
    {
        monedasTxt.text = "Monedas:" + monedas.ToString();

        //ID productos
        productosTienda[1, 1] = 1;  // El primer uno de los corchetes es la columna en la que se encuentra
        productosTienda[1, 2] = 2;
        productosTienda[1, 3] = 3;
        productosTienda[1, 4] = 4;

        //Precios
        productosTienda[2, 1] = 10;  
        productosTienda[2, 2] = 20;
        productosTienda[2, 3] = 30;
        productosTienda[2, 4] = 40;

        //Cantidad
        productosTienda[3, 1] = 0;  
        productosTienda[3, 2] = 0;
        productosTienda[3, 3] = 0;
        productosTienda[3, 4] = 0;
    }

    public void ComprarProducto()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(monedas >= productosTienda[2, ButtonRef.GetComponent<InfoBoton>().ProductoID])
        {
            monedas -= productosTienda[2, ButtonRef.GetComponent<InfoBoton>().ProductoID];
            productosTienda[3, ButtonRef.GetComponent<InfoBoton>().ProductoID]++;
            monedasTxt.text = "Monedas:" + monedas.ToString();
            ButtonRef.GetComponent<InfoBoton>().cantidadTxt.text = productosTienda[3, ButtonRef.GetComponent<InfoBoton>().ProductoID].ToString();
        }
    }
}



