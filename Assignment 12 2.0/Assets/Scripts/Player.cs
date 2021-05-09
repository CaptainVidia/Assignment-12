using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    
    
    private void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            
            if (inventory.AddItem(new Item(item.item), 1))
                Destroy(other.gameObject);
        }
    }
    
    public void OnApplicationQuit()
    {
        inventory.Container.Clear();
        
    }
}
