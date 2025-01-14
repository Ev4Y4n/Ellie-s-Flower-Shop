using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public static Temporizador THIS;
    [SerializeField]
    TextMeshProUGUI temporizador;
    [SerializeField]
    float tiempoRestante;

    public bool finTemporizador;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
        }
    }

    private void Start()
    {
        temporizador.gameObject.SetActive(false);
    }

    public void ActivarTemporizador()
    {
        Debug.Log("Has activado el temporizador");
        temporizador.gameObject.SetActive(true);
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
        }
        else if (tiempoRestante < 0)
        {
            tiempoRestante = 0;
        }

        int minutes = Mathf.FloorToInt(tiempoRestante / 60);
        int seconds = Mathf.FloorToInt(tiempoRestante % 60);
        temporizador.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DesactivarTemporizador()
    {
        temporizador.gameObject.SetActive(false);
    }
}
