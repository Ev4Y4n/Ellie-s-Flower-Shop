using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirMinijuego2 : MonoBehaviour
{
    public void SalirJuego()
    {
        SceneManager.LoadSceneAsync(4);
        //MovimientoElisameth.THIS.elisabeth.SetActive(true);
    }
}
