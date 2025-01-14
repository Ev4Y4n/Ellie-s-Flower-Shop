using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMusica : MonoBehaviour
{
    public static ManagerMusica THIS;

    //public AudioSource musicaFondo;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    /*
    void Start()
    {
        musicaFondo.Play();
    }
    */
    
}

