using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ObjetoInventario 
{
    public DataObjeto itemData;
    public int stackSize;

    public ObjetoInventario(DataObjeto item)
    {
        itemData = item;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStak()
    {
        stackSize--;
    }
}
