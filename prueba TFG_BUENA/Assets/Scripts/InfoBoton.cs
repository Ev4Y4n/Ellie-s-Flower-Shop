using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoton : MonoBehaviour
{
    public int ProductoID;
    public Text precioTxt;
    public Text cantidadTxt;
    public GameObject shopManager;
    
    void Update()
    {
        precioTxt.text = "$" + shopManager.GetComponent<ShopManager>().productosTienda[2, ProductoID].ToString();
        cantidadTxt.text = shopManager.GetComponent<ShopManager>().productosTienda[3, ProductoID].ToString();

    }
}
