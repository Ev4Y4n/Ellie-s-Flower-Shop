using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Semilla : MonoBehaviour, ICollectible
{
    public static event HandleGemCollected OnGemCollected;
    public delegate void HandleGemCollected(DataObjeto itemData);
    public DataObjeto gemData;

    public void Collect()
    {
        Destroy(gameObject);
        OnGemCollected?.Invoke(gemData);
    }
}
