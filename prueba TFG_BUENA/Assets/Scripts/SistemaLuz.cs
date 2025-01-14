using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaLuz : MonoBehaviour
{
    public GameObject bombilla;

    public bool luzEncendida;

    // Start is called before the first frame update
    void Start()
    {
        bombilla.gameObject.SetActive(false);
    }

    public void EncenderLuz()
    {
        if (luzEncendida)
        {
            bombilla.gameObject.SetActive(false);
            luzEncendida = false;
        }
        else
        {
            bombilla.gameObject.SetActive(true);
            luzEncendida = true;
        }

    }
}
