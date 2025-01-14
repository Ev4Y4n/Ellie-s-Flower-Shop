using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosicionJugador : MonoBehaviour
{
    private Vector2 posicionInicial;

    private void Awake()
    {
        Debug.Log("Esta realizando el AWAKE");
        posicionInicial = transform.position;
    }

    void Start()
    {
        Debug.Log("Esta realizando el START");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        Debug.Log("Esta realizando el ONDESTROY");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Escena cargada: " + scene.name);
        Debug.Log("Posición inicial: " + posicionInicial);

        Vector3 nuevaPosicion = new Vector3(posicionInicial.x, posicionInicial.y, transform.position.z);
        Debug.Log("Nueva posición: " + nuevaPosicion);

        transform.position = nuevaPosicion;
    }
}
