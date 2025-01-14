using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirInventario : MonoBehaviour
{
    public GameObject inventario;
    // Start is called before the first frame update
    void Start()
    {
        inventario.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrarAlInventario()
    {
        inventario.SetActive(true);
        Time.timeScale = 0f;
    }

    public void SalirInventario()
    {
        inventario.SetActive(false);
        Time.timeScale = 1f;
    }
}
