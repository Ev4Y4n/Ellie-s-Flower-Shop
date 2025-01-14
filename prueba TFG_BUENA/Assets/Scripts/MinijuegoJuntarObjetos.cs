using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MinijuegoJuntarObjetos : MonoBehaviour
{
    public static MinijuegoJuntarObjetos THIS;
    private Vector2 posicionRaton;
    private float offsetX, offsetY;
    public static bool hasSoltadoRaton;
    private GameObject instanciaPrefab;


    private void Awake()
    {
        if(THIS == this)
        {
            THIS = this;
        }
    }
    void Start()
    {
        StartCoroutine(CrearSemillasNuevas());
     
    }
    private void OnMouseDown()
    {
        hasSoltadoRaton = false;
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        Debug.Log("Estar arrastrando el objeto");
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(posicionRaton.x - offsetX, posicionRaton.y - offsetY);
    }

    private void OnMouseUp()
    {
        Debug.Log("Has soltado el objeto");
        hasSoltadoRaton = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
               
        Debug.Log("Colisión continua detectada con: " + collision.gameObject.name);
        Debug.Log("Estas intentando juntar dos objetos");

        if (hasSoltadoRaton)
        {
            string tagObjetoArrastrado = gameObject.tag;
            string tagObjetoColisionado = collision.gameObject.tag;

            if (tagObjetoArrastrado == "Semilla" && tagObjetoArrastrado == tagObjetoColisionado)
            {

                Debug.Log("Has juntado dos semillas");
                GameObject prefab = Resources.Load<GameObject>("brote1_Object");
                Instantiate(prefab, transform.position, Quaternion.identity);
                hasSoltadoRaton = false;
                ControladorMinijuego3.THIS.SumarPuntos();

                Destroy(collision.gameObject);
                Destroy(gameObject);
                Debug.Log("Has obtenido un brote1");


            }

            else if (tagObjetoArrastrado == "Brote1" && tagObjetoArrastrado == tagObjetoColisionado)
            {
                Debug.Log("Has juntado dos de brote1");
                GameObject prefab = Resources.Load<GameObject>("brote2_Object");
                Instantiate(prefab, transform.position, Quaternion.identity);
                hasSoltadoRaton = false;
                Destroy(collision.gameObject); //Los objetos colisionados son destruidos 
                Destroy(gameObject);
                Debug.Log("Has obtenido un brote2");
            }


            else if (tagObjetoArrastrado == "Brote2" && tagObjetoArrastrado == tagObjetoColisionado)
            {
                Debug.Log("Has juntado dos de brote2");
                GameObject prefab = Resources.Load<GameObject>("brote3_Object");
                GameObject instanciaPrefab = Instantiate(prefab, this.gameObject.transform.position, Quaternion.identity);
                hasSoltadoRaton = false;
                Destroy(collision.gameObject);
                Destroy(gameObject);
                Debug.Log("Has obtenido un brote3");
                Destroy(instanciaPrefab, 3f);
            }
        }                
    }

    IEnumerator CrearSemillasNuevas()
    {
        Debug.Log("Va a empezar la primera corrutina de crear semillas");
        yield return new WaitForSeconds(7);
        Vector3 posicionAleatoria;
        Collider2D collider;
        do //hacer esto
        {
            posicionAleatoria = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0); //generar posición aleatoria

            collider = Physics2D.OverlapPoint(posicionAleatoria); //tiene que evitar las zonas donde haya otros colliders
     
        }
        while (collider != null || !DentroEscenario(posicionAleatoria)); //mientras que no haya otros colliders en la zona y la posición aleatoria esté dentro del escenario

        Debug.Log("Se han creado semillas nuevas");
        GameObject prefab = Resources.Load<GameObject>("semilla_Object");
        Instantiate(prefab, posicionAleatoria, Quaternion.identity);
        yield return new WaitForSeconds(3);
    }

    
    
    bool DentroEscenario(Vector3 posicion)
    {
        if (posicion.x >= -7f && posicion.x <= 6.7f && posicion.y >= -5.2f && posicion.y <= 0f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    IEnumerator DesactivarFlor()
    {
        Debug.Log("Se va a llamar la corrutina DesactivarFlor");
        yield return new WaitForSeconds(3);
        GameObject[] brote3Objects = GameObject.FindGameObjectsWithTag("Brote3");
        
        Debug.Log("Se ha desactivado la flor final");
        
        foreach (GameObject brote3Object in brote3Objects)
        {           
            brote3Object.SetActive(false);
        }
    }

    IEnumerator Esperar()
    {
        Debug.Log("Va a empezar corrutina Esperar");
        yield return new WaitForSeconds(0.1f);
    }
   
}
