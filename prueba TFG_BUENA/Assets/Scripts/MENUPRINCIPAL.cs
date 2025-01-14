using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUPRINCIPAL : MonoBehaviour
{
    public void EmpezarJuego()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
