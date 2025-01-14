using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventario : MonoBehaviour
{
    public static Inventario THIS;

    public static event Action<List<ObjetoInventario>> OnInventoryChange;

    public List<ObjetoInventario> inventory =new List<ObjetoInventario>();
    private Dictionary<DataObjeto, ObjetoInventario> itemDictionary = new Dictionary<DataObjeto, ObjetoInventario>();

    private void OnEnable()
    {
        Semilla.OnGemCollected += Add;
    }

    private void OnDisable()
    {
        Semilla.OnGemCollected -= Add;
    }
    public void Add(DataObjeto itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out ObjetoInventario item)) //si tenemos el objeto se añade al stack
        {
            item.AddToStack();
            Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
            OnInventoryChange?.Invoke(inventory);
        }
        else //y si es objeto es un objeto nuevo, se añade en una viñeta por separado del inventario
        {
            ObjetoInventario newItem = new ObjetoInventario(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Added{itemData.displayName} to the inventory for the first time");
            OnInventoryChange?.Invoke(inventory);
        }

    }

    public void Remove(DataObjeto itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out ObjetoInventario item)) 
        {
            item.RemoveFromStak();
            if(item.stackSize == 0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
            OnInventoryChange?.Invoke(inventory);
        }
    }
}
