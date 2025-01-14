using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Plantar : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public GameObject flor1;
    public GameObject flor2;
    public GameObject flor3;
    public GameObject flor4;

    public GameObject brote1A;
    public GameObject brote1B;
    public GameObject brote1C;
    public GameObject brote1D;

    public GameObject brote2A;
    public GameObject brote2B;
    public GameObject brote2C;
    public GameObject brote2D;

    public GameObject semilla1;
    public GameObject semilla2;
    public GameObject semilla3;
    public GameObject semilla4;

    public Text contadorFlores;

    [SerializeField]
    TextMeshProUGUI temporizador1;
    [SerializeField]
    TextMeshProUGUI temporizador2;
    [SerializeField]
    TextMeshProUGUI temporizador3;
    [SerializeField]
    TextMeshProUGUI temporizador4;

    [SerializeField]
    float tiempoRestante;

    public bool hasPlantado1 =false;
    public bool hasPlantado2 =false;
    public bool hasPlantado3 =false;
    public bool hasPlantado4 =false;

    public int floresRojas;

    public ParticleSystem particula1;
    public ParticleSystem particula2;
    public ParticleSystem particula3;
    public ParticleSystem particula4;

    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);

        flor1.SetActive(false);
        flor2.SetActive(false);
        flor3.SetActive(false);
        flor4.SetActive(false);

        brote1A.SetActive(false);
        brote1B.SetActive(false);
        brote1C.SetActive(false);
        brote1D.SetActive(false);

        brote2A.SetActive(false);
        brote2B.SetActive(false);
        brote2C.SetActive(false);
        brote2D.SetActive(false);

        semilla1.SetActive(false);
        semilla2.SetActive(false);
        semilla3.SetActive(false);
        semilla4.SetActive(false);

        temporizador1.gameObject.SetActive(false);
        temporizador2.gameObject.SetActive(false);
        temporizador3.gameObject.SetActive(false);
        temporizador4.gameObject.SetActive(false);
        //MovimientoElisameth.THIS.inventario.SetActive(false);
    }

    public void ActualizarContadorFlores()
    {
        contadorFlores.text = "x" + floresRojas;
    }
    public void Maceta1()
    {
        if (hasPlantado1 == false)
        {
            semilla1.SetActive(true);
        }

        if(hasPlantado1 == true)
        {
            panel1.SetActive(true);
        }
        if (flor1.activeSelf)
        {
            flor1.SetActive(false);
            panel1.SetActive(false);
            contadorFlores.ToString();
            floresRojas++;
            ActualizarContadorFlores();
            temporizador1.gameObject.SetActive(false);
            particula1.Play();
            hasPlantado1 = false;
        }
        
    }

    public void Maceta2()
    {
        if (hasPlantado2 == false)
        {
            semilla2.SetActive(true);
        }

        if (hasPlantado2 == true)
        {
            panel2.SetActive(true);
        }
        if (flor2.activeSelf)
        {
            flor2.SetActive(false);
            panel2.SetActive(false);
            contadorFlores.ToString();
            floresRojas++;
            ActualizarContadorFlores();
            temporizador2.gameObject.SetActive(false);
            particula2.Play();
            hasPlantado2 = false;
        }
    }

    public void Maceta3()
    {
        if (hasPlantado3 == false)
        {
            semilla3.SetActive(true);
        }

        if (hasPlantado3 == true)
        {
            panel3.SetActive(true);
        }
        if (flor3.activeSelf)
        {
            flor3.SetActive(false);
            panel3.SetActive(false);
            contadorFlores.ToString();
            floresRojas++;
            ActualizarContadorFlores();
            temporizador3.gameObject.SetActive(false);
            particula3.Play();
            hasPlantado3 = false;
        }
    }

    public void Maceta4()
    {
        if (hasPlantado4 == false)
        {
            semilla4.SetActive(true);
        }

        if (hasPlantado4 == true)
        {
            panel4.SetActive(true);
        }
        if (flor4.activeSelf)
        {
            flor4.SetActive(false);
            panel4.SetActive(false);
            contadorFlores.ToString();
            floresRojas++;
            ActualizarContadorFlores();
            temporizador4.gameObject.SetActive(false);
            particula4.Play();
            hasPlantado4 = false;
        }
    }

    public void PlantarSemilla1()
    {
        brote1A.SetActive(true);
        semilla1.SetActive(false);
        hasPlantado1 = true;
        temporizador1.gameObject.SetActive(true);
    }

    public void PlantarSemilla2()
    {
        brote1B.SetActive(true);
        semilla2.SetActive(false);
        hasPlantado2 = true;
    }

    public void PlantarSemilla3()
    {
        brote1C.SetActive(true);
        semilla3.SetActive(false);
        hasPlantado3 = true;
    }

    public void PlantarSemilla4()
    {
        brote1D.SetActive(true);
        semilla4.SetActive(false);
        hasPlantado4 = true;
    }

    public void Sol1()
    {
        ActivarTemporizador1();
        panel1.SetActive(false);
        if (brote1A == false)
        {
            brote1A.SetActive(true);
        }
        if (brote1A.activeSelf)
        {
            brote1A.SetActive(false);
            brote2A.SetActive(true);
        }
        else if (brote2A.activeSelf)
        {
            brote2A.SetActive(false);
            flor1.SetActive(true);
        }
    }

    public void Regadera1()
    {
        ActivarTemporizador1();
        panel1.SetActive(false);
        if (brote1A == false)
        {
            brote1A.SetActive(true);
        }
        if (brote1A.activeSelf)
        {
            brote1A.SetActive(false);
            brote2A.SetActive(true);
        }
        else if (brote2A.activeSelf)
        {
            brote2A.SetActive(false);
            flor1.SetActive(true);
        }
    }

    public void Fertilizante1()
    {
        ActivarTemporizador1();
        panel1.SetActive(false);
        if (brote1A == false)
        {
            brote1A.SetActive(true);
        }
        if (brote1A.activeSelf)
        {
            brote1A.SetActive(false);
            brote2A.SetActive(true);
        }
        else if (brote2A.activeSelf)
        {
            brote2A.SetActive(false);
            flor1.SetActive(true);
        }
    }

    public void Sol2()
    {
        ActivarTemporizador2();
        panel2.SetActive(false);
        if (brote1B == false)
        {
            brote1B.SetActive(true);
        }
        if (brote1B.activeSelf)
        {
            brote1B.SetActive(false);
            brote2B.SetActive(true);
        }
        else if (brote2B.activeSelf)
        {
            brote2B.SetActive(false);
            flor2.SetActive(true);
        }
    }

    public void Regadera2()
    {
        ActivarTemporizador2();
        panel2.SetActive(false);
        if (brote1B == false)
        {
            brote1B.SetActive(true);
        }
        if (brote1B.activeSelf)
        {
            brote1B.SetActive(false);
            brote2B.SetActive(true);
        }
        else if (brote2B.activeSelf)
        {
            brote2B.SetActive(false);
            flor2.SetActive(true);
        }
    }

    public void Fertilizante2()
    {
        ActivarTemporizador2();
        panel2.SetActive(false);
        if (brote1B == false)
        {
            brote1B.SetActive(true);
        }
        if (brote1B.activeSelf)
        {
            brote1B.SetActive(false);
            brote2B.SetActive(true);
        }
        else if (brote2B.activeSelf)
        {
            brote2B.SetActive(false);
            flor2.SetActive(true);
        }
    }

    public void Sol3()
    {
        ActivarTemporizador3();
        panel3.SetActive(false);
        if (brote1C == false)
        {
            brote1C.SetActive(true);
        }
        if (brote1C.activeSelf)
        {
            brote1C.SetActive(false);
            brote2C.SetActive(true);
        }
        else if (brote2C.activeSelf)
        {
            brote2C.SetActive(false);
            flor3.SetActive(true);
        }
    }

    public void Regadera3()
    {
        ActivarTemporizador3();
        panel3.SetActive(false);
        if (brote1C == false)
        {
            brote1C.SetActive(true);
        }
        if (brote1C.activeSelf)
        {
            brote1C.SetActive(false);
            brote2C.SetActive(true);
        }
        else if (brote2C.activeSelf)
        {
            brote2C.SetActive(false);
            flor3.SetActive(true);
        }
    }

    public void Fertilizante3()
    {
        ActivarTemporizador3();
        panel3.SetActive(false);
        if (brote1C == false)
        {
            brote1C.SetActive(true);
        }
        if (brote1C.activeSelf)
        {
            brote1C.SetActive(false);
            brote2C.SetActive(true);
        }
        else if (brote2C.activeSelf)
        {
            brote2C.SetActive(false);
            flor3.SetActive(true);
        }
    }

    public void Sol4()
    {
        ActivarTemporizador4();
        panel4.SetActive(false);
        if (brote1D == false)
        {
            brote1D.SetActive(true);
        }
        if (brote1D.activeSelf)
        {
            brote1D.SetActive(false);
            brote2D.SetActive(true);
        }
        else if (brote2D.activeSelf)
        {
            brote2D.SetActive(false);
            flor4.SetActive(true);
        }
    }

    public void Regadera4()
    {
        ActivarTemporizador4();
        panel4.SetActive(false);
        if (brote1D == false)
        {
            brote1D.SetActive(true);
        }
        if (brote1D.activeSelf)
        {
            brote1D.SetActive(false);
            brote2D.SetActive(true);
        }
        else if (brote2D.activeSelf)
        {
            brote2D.SetActive(false);
            flor4.SetActive(true);
        }
    }

    public void Fertilizante4()
    {
        ActivarTemporizador4();
        panel4.SetActive(false);
        if (brote1D == false)
        {
            brote1D.SetActive(true);
        }
        if (brote1D.activeSelf)
        {
            brote1D.SetActive(false);
            brote2D.SetActive(true);
        }
        else if (brote2D.activeSelf)
        {
            brote2D.SetActive(false);
            flor4.SetActive(true);
        }
    }

    public void ActivarTemporizador1()
    {
        Debug.Log("Has activado el temporizador 1");
        temporizador1.gameObject.SetActive(true);
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
        temporizador1.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DesactivarTemporizador1()
    {
        temporizador1.gameObject.SetActive(false);
    }


    public void ActivarTemporizador2()
    {
        Debug.Log("Has activado el temporizador 2");
        temporizador2.gameObject.SetActive(true);
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
        temporizador2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DesactivarTemporizador2()
    {
        temporizador2.gameObject.SetActive(false);
    }

    public void ActivarTemporizador3()
    {
        Debug.Log("Has activado el temporizador 3");
        temporizador3.gameObject.SetActive(true);
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
        temporizador3.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DesactivarTemporizador3()
    {
        temporizador3.gameObject.SetActive(false);
    }

    public void ActivarTemporizador4()
    {
        Debug.Log("Has activado el temporizador 4");
        temporizador4.gameObject.SetActive(true);
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
        temporizador3.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DesactivarTemporizador4()
    {
        temporizador4.gameObject.SetActive(false);
    }

    public void SalirSistemaPlantar()
    {
        SceneManager.LoadSceneAsync(8);
    }
}
