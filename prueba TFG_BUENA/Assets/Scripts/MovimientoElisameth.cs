using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovimientoElisameth : MonoBehaviour
{
    public static MovimientoElisameth THIS;
    public float speed;

    public Rigidbody2D rb;
    public Animator animator;    

    Vector2 movement;

    public GameObject inventario;
    public GameObject elisabeth;
    
    void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            //DontDestroyOnLoad(gameObject);
        }
        /*
        else
        {
            Destroy(gameObject);
        }
        */
    }
    private void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Velocidad", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("CaminoPueblo"))
        {
            Debug.Log("Has entrado al pueblo");
            SceneManager.LoadSceneAsync(2);
        }

        if (collision.collider.CompareTag("CaminoCasa"))
        {
            Debug.Log("Has vuelto a casa");
            SceneManager.LoadSceneAsync(1);
        }
        if (collision.collider.CompareTag("CaminoFloristeria"))
        {
            Debug.Log("Has ido a la floristeria");
            SceneManager.LoadSceneAsync(3);
        }

        if (collision.collider.CompareTag("EntradaCasa"))
        {
            Debug.Log("Has entrado a casa");
            SceneManager.LoadSceneAsync(4);
        }

        if (collision.collider.CompareTag("SalidaCasa"))
        {
            Debug.Log("Has salido de casa");
            SceneManager.LoadSceneAsync(1);
        }

        if (collision.collider.CompareTag("EntradaMercado"))
        {
            Debug.Log("Has entrado al mercado");
            SceneManager.LoadSceneAsync(5);
        }

        if (collision.collider.CompareTag("SalidaMercado"))
        {
            Debug.Log("Has salido del mercado");
            SceneManager.LoadSceneAsync(2);
            //TransitionManager.THIS.CargarSiguienteEscena("NombreEscena");
        }

        if (collision.collider.CompareTag("PapeleraLlena"))
        {
            Debug.Log("Tienes la papelera llena");
            ControladorBasura.THIS.panelPapeleraLlena.SetActive(true);
            Time.timeScale = 0f;
        }

        if (collision.collider.CompareTag("Flor"))
        {
            Debug.Log("Has recogido una flor");
            ControladorMinijuego2.THIS.textoPuntos.text = "Puntos:" + ControladorMinijuego2.THIS.puntos.ToString();
            ControladorMinijuego2.THIS.puntos++;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Basura")
        {
            Debug.Log("Has encontrado una basura");
            
            ControladorBasura.THIS.panelBasura.SetActive(true);
            Time.timeScale = 0f;
        }

        if(other.gameObject.tag == "Consola")
        {
            Debug.Log("Has encendido la consola");
            SeleccionarMinijuego.THIS.pantallaConsola.SetActive(true);
            //Time.timeScale = 0.1f;
        }

        if (other.gameObject.tag == "EntradaFloristeria")
        {
            Debug.Log("Has entrado a la floristería");
            SceneManager.LoadSceneAsync(8);
        }

        if (other.gameObject.tag == "SalidaFloristeria")
        {
            Debug.Log("Has salido de la floristería");
            SceneManager.LoadSceneAsync(3);
        }

        if (other.gameObject.tag == "Plantar")
        {
            ManagerSistemaPlantar.THIS.panelPlantar.SetActive(true);
            
        }

        if(other.gameObject.tag=="Plantar" && ManagerSistemaPlantar.THIS.hasPlantadoSemilla==true && ManagerSistemaPlantar.THIS.hasTerminadoDePlantar==false)
        {
            ManagerSistemaPlantar.THIS.panelRegar.SetActive(true);
        }

        if (other.gameObject.tag == "FlorCrecida")
        {
            ManagerSistemaPlantar.THIS.panelRecoger.SetActive(true);
            ManagerSistemaPlantar.THIS.DesactivarPanelRegar();
        }

        if (other.gameObject.tag == "ZonaJano")
        {
            DialogosNPCs.THIS.ActivarDialogoJano();
        }

        if(other.gameObject.tag == "ZonaMatteo")
        {
            DialogosNPCs.THIS.ActivarDialogoMatteo();
        }

        if (other.gameObject.tag == "ZonaOlivia")
        {
            DialogosNPCs.THIS.ActivarDialogoOlivia();
        }

        if (other.gameObject.tag == "ZonaMalia")
        {
            DialogosNPCs.THIS.ActivarDialogoMalia();
        }

        if (other.gameObject.tag == "ZonaHannah")
        {
            DialogosNPCs.THIS.ActivarDialogoHannah();
        }

        if (other.gameObject.tag == "ZonaLucas")
        {
            DialogosNPCs.THIS.ActivarDialogoLucas();
        }

        if (other.gameObject.tag == "ZonaTimo")
        {
            DialogosNPCs.THIS.ActivarDialogoTimo();
        }

        if (other.gameObject.tag == "ZonaNina")
        {
            DialogosNPCs.THIS.ActivarDialogoMatteo();
        }

        if (other.gameObject.tag == "PuertaPlantar")
        {
            SceneManager.LoadSceneAsync(9);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ZonaJano")
        {
            DialogosNPCs.THIS.DesactivarDialogoJano();
        }

        if (other.gameObject.tag == "ZonaMatteo")
        {
            DialogosNPCs.THIS.DesactivarDialogoMatteo();
        }

        if (other.gameObject.tag == "ZonaOlivia")
        {
            DialogosNPCs.THIS.DesactivarDialogoOlivia();
        }

        if (other.gameObject.tag == "ZonaMalia")
        {
            DialogosNPCs.THIS.DesactivarDialogoMalia();
        }

        if (other.gameObject.tag == "ZonaHannah")
        {
            DialogosNPCs.THIS.DesactivarDialogoHannah();
        }

        if (other.gameObject.tag == "ZonaLucas")
        {
            DialogosNPCs.THIS.DesactivarDialogoLucas();
        }

        if (other.gameObject.tag == "ZonaTimo")
        {
            DialogosNPCs.THIS.DesactivarDialogoTimo();
        }

        if (other.gameObject.tag == "ZonaNina")
        {
            DialogosNPCs.THIS.DesactivarDialogoMatteo();
        }
    }

}
