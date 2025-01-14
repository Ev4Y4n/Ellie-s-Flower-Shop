using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNPCs : MonoBehaviour
{

    public Rigidbody2D rb;
    //public Animator anim;

    public bool estaCaminando;

    public float velocidadMaxima = 3f;
    public float tiempoCaminando = 3f;
    private float contadorMovimiento;
    public float tiempoEspera = 2f;
    private float contadorEsperar;

    public int direccion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        contadorEsperar = tiempoEspera;
        contadorMovimiento = tiempoCaminando;
        ElegirDireccion();
    }

    // Update is called once per frame
    void Update()
    {
        if (estaCaminando == true)
        {
            contadorMovimiento -= Time.deltaTime;


            switch (direccion)
            {
                case 0:
                    Debug.Log("Esta haciendo case 1");
                    rb.AddForce(Vector2.up * velocidadMaxima);
                    break;
                case 1:
                    Debug.Log("Esta haciendo case 2");

                    rb.AddForce(Vector2.right * velocidadMaxima);

                    break;
                case 2:
                    Debug.Log("Esta haciendo case 3");

                    rb.AddForce(Vector2.down * velocidadMaxima);

                    break;
                case 3:
                    Debug.Log("Esta haciendo case 4");

                    rb.AddForce(Vector2.left * velocidadMaxima);
                    break;
            }
            Debug.Log("Velocidad actual: " + rb.velocity.magnitude);
            if (contadorMovimiento < 0)
            {
                Debug.Log("Ha dejado de caminar");
                estaCaminando = false;
                contadorEsperar = tiempoEspera;
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            contadorEsperar -= Time.deltaTime;
            //rb.velocity = Vector2.zero;
            if (contadorEsperar < 0)
            {
                ElegirDireccion();
            }
        }
    }

    public void ElegirDireccion()
    {
        direccion = Random.Range(0, 4);
        Debug.Log("Se ha elegido nueva direccion: " + direccion);
        estaCaminando = true;
        contadorMovimiento = tiempoCaminando;
    }
}


