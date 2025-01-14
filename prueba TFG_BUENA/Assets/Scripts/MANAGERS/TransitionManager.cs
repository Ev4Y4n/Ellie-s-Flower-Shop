using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public static TransitionManager THIS;
    public Animator transicion;
    public float duracionTransicion = 1f;

    private Dictionary<string, List<string>> siguienteEscena = new Dictionary<string, List<string>>();

    private void Awake()
    {
        THIS = this;

        siguienteEscena.Add("MENUINICIAL", new List<string> { "CASA PROTA" });
        siguienteEscena.Add("CASA PROTA", new List<string> { "PUEBLO", "InteriorCasaProta" });
        siguienteEscena.Add("InteriorCasaProta", new List<string> { "CASA PROTA", "MINIJUEGO 1", "MINIJUEGO 2" });
        siguienteEscena.Add("PUEBLO", new List<string> { "FLORISTERIA", "CASA PROTA", "InteriorMercado" });
        siguienteEscena.Add("InteriorMercado", new List<string> { "PUEBLO" });
        siguienteEscena.Add("FLORISTERIA", new List<string> { "InteriorFloristeria" });
    }

    public void CargarSiguienteEscena(string nombreEscenaActual)
    {
        if (siguienteEscena.ContainsKey(nombreEscenaActual))
        {
            List<string> posiblesSiguientes = siguienteEscena[nombreEscenaActual];
            string siguiente = posiblesSiguientes[Random.Range(0, posiblesSiguientes.Count)]; // Escoge aleatoriamente una siguiente escena
            StartCoroutine(LoadLevel(siguiente));
        }
        else
        {
            Debug.LogWarning("No se pudo encontrar la siguiente escena para " + nombreEscenaActual);
        }
    }

    IEnumerator LoadLevel(string nombreEscena)
    {
        transicion.SetTrigger("Start");
        yield return new WaitForSeconds(duracionTransicion);
        SceneManager.LoadScene(nombreEscena);
    }
}
