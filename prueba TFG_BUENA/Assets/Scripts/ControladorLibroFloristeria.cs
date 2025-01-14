using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLibroFloristeria : MonoBehaviour
{
    public GameObject panelLibroAbierto;
    public GameObject botonLibro;

    // Start is called before the first frame update
    void Start()
    {
        panelLibroAbierto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirLibro()
    {
        panelLibroAbierto.SetActive(true);
        botonLibro.SetActive(false);
    }

    public void CerrarLibro()
    {
        panelLibroAbierto.SetActive(false);
        botonLibro.SetActive(true);
    }
}
