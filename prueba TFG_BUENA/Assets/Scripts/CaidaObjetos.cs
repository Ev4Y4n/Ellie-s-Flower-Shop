using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaidaObjetos : MonoBehaviour
{
    float esperar = 0.1f; //tiempo entre la caida de las flores
    public GameObject floresCayendo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Caida", esperar, esperar);      
    }

    void Caida()
    {
        Debug.Log("Las flores han empezado a caer");
        Instantiate(floresCayendo, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
    }

    
    public void SalirMinijuego()
    {
        Debug.Log("Has salido del minijuego 1");
        SceneManager.LoadSceneAsync(4);
    }

}
