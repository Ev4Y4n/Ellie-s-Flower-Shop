using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{
    public GameObject slotPrefab;
    public List<RanuraInventario> inventorySlots = new List<RanuraInventario>(10);
    
    private void Awake()
    {
        GameObject parentObject = transform.parent.gameObject;
        //DontDestroyOnLoad(parentObject);
    }
    
    private void OnEnable()
    {
        Inventario.OnInventoryChange += DrawInventory;
    }

    private void OnDisable()
    {
        Inventario.OnInventoryChange -= DrawInventory;
    }

    void ResetInventory()
    {
        foreach (Transform childTransform in transform)
        {
            Destroy(childTransform.gameObject);
        }
        inventorySlots = new List<RanuraInventario>(10);
    }

    void DrawInventory(List<ObjetoInventario> inventory)
    {
        ResetInventory();

        for(int i=0; i< inventorySlots.Capacity; i++)
        {
            //Crear las 10 ranuras
            CreateInventorySlot();

        }

        for(int i=0; i < inventory.Count; i++)
        {
            inventorySlots[i].DrawSlot(inventory[i]);
        }
    }


    void CreateInventorySlot()
    {
        GameObject newSlot = Instantiate(slotPrefab);
        newSlot.transform.SetParent(transform, false);

        RanuraInventario newSlotComponent = newSlot.GetComponent<RanuraInventario>();
        newSlotComponent.ClearSlot();

        inventorySlots.Add(newSlotComponent);

    }
}
