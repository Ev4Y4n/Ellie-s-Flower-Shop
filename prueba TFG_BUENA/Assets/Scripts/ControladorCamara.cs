using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ControladorCamara : MonoBehaviour
{
    public static ControladorCamara THIS;

    public CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        if (THIS == null)
        {
            THIS = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else Destroy(gameObject);
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            virtualCamera.Follow = player.transform;
        }
    }
    

    
}
