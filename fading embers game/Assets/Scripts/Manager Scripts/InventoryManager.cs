using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[8];
    
    public void PickUp(GameObject item)
    {
        int i = 0;
        while (inventory[i] != null) 
        {
            i++;
        }

        inventory[i] = item;
    }
}
